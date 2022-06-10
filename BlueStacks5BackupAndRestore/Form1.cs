using BlueStacks5BackupAndRestore.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Windows.Forms;

namespace BlueStacks5BackupAndRestore
{
    public partial class Form1 : Form
    {
        Models.InstancesList backupList = new Models.InstancesList();
        public Form1()
        {
            InitializeComponent();
            tbBSInstallLocation.Text = Settings.Default.BlueStacksInstall;
        }

        public void GetInstances()
        {
            backupList = new Models.InstancesList();
            Models.Instances instances = new Models.Instances();
            List<Models.Instances> instancesList = new List<Models.Instances>();

            string currentInstance = "";
            bool nougat32 = false;
            bool nougat64 = false;
            string bluestacksDir = "";
            if (Directory.Exists(tbBSInstallLocation.Text))
            {
                bluestacksDir = new DirectoryInfo(tbBSInstallLocation.Text).Name;
            }
            if (bluestacksDir == "BlueStacks_nxt")
            {
                using (StreamReader reader = new StreamReader(Path.Combine(tbBSInstallLocation.Text, "bluestacks.conf")))
                {
                    while (reader.Peek() >= 0)
                    {
                        string nextLine = reader.ReadLine();
                        if (nextLine != null)
                        {
                            if (nextLine.Contains("bst.installed_images"))
                            {
                                if (nextLine.Contains("Nougat32"))
                                {
                                    nougat32 = true;
                                }
                                if (nextLine.Contains("Nougat64"))
                                {
                                    nougat64 = true;
                                }
                            }
                            if (nougat32)
                            {
                                if (nextLine.Contains("bst.instance.Nougat32"))
                                {
                                    nextLine = nextLine.Replace("bst.instance.Nougat32", "");
                                    if (nextLine.StartsWith("."))
                                    {
                                        currentInstance = "0";
                                        instances.Id = "0";
                                        instances.Type = "Nougat32";
                                        instances.Values.Add(nextLine.Substring(nextLine.IndexOf(".")));
                                        if (nextLine.Contains("display_name"))
                                        {
                                            instances.Name = nextLine.Substring(nextLine.IndexOf("\"")+1, nextLine.LastIndexOf("\"") - nextLine.IndexOf("\"")-1);
                                        }
                                    }
                                    else
                                    {
                                        string id = nextLine.Substring(0, nextLine.IndexOf("."));
                                        if (id != currentInstance)
                                        {
                                            instancesList.Add(instances);
                                            instances = new Models.Instances();
                                        }
                                        currentInstance = id;
                                        instances.Id = id;
                                        instances.Type = "Nougat32";
                                        instances.Values.Add(nextLine.Substring(nextLine.IndexOf(".")));
                                        if (nextLine.Contains("display_name"))
                                        {
                                            instances.Name = nextLine.Substring(nextLine.IndexOf("\"") + 1, nextLine.LastIndexOf("\"") - nextLine.IndexOf("\"") - 1);
                                        }
                                    }
                                }
                            }
                            if (nougat64)
                            {
                                if (nextLine.Contains("bst.instance.Nougat64"))
                                {
                                    nextLine.Replace("bst.instance.Nougat64", "");
                                    if (nextLine.StartsWith("."))
                                    {
                                        currentInstance = "0";
                                        instances.Id = "0";
                                        instances.Type = "Nougat64";
                                        instances.Values.Add(nextLine.Substring(nextLine.IndexOf(".")));
                                        if (nextLine.Contains("display_name"))
                                        {
                                            instances.Name = nextLine.Substring(nextLine.IndexOf("\"") + 1, nextLine.LastIndexOf("\"") - nextLine.IndexOf("\"") - 1);
                                        }
                                    }
                                    else
                                    {
                                        string id = nextLine.Substring(0, nextLine.IndexOf("."));
                                        if (id != currentInstance)
                                        {
                                            instancesList.Add(instances);
                                            instances = new Models.Instances();
                                        }
                                        currentInstance = id;
                                        instances.Id = id;
                                        instances.Type = "Nougat64";
                                        instances.Values.Add(nextLine.Substring(nextLine.IndexOf(".")));
                                        if (nextLine.Contains("display_name"))
                                        {
                                            instances.Name = nextLine.Substring(nextLine.IndexOf("\"") + 1, nextLine.LastIndexOf("\"") - nextLine.IndexOf("\"") - 1);
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            else
            {
                tbException.Visible = true;
                tbException.Text = "Make sure the BlueStacks_nxt folder is selected as the BlueStacks Directory.";
            }
            foreach (Models.Instances i in instancesList)
            {
                instanceListBox.Items.Add(i.Name);
                
            }
            
            backupList.Instances = instancesList;
        }

        private void Backup(List<string> names)
        {
            foreach (Models.Instances i in backupList.Instances)
            {
                if (names.Count() == 0)
                {
                    if (i.Id == "0")
                    {
                        i.Id = "";
                    }
                    
                    using (StreamWriter writer = new StreamWriter(Path.Combine(tbBSInstallLocation.Text, "Engine", i.Type + i.Id, "conf.txt")))
                    {
                        writer.WriteLine(i.Name);
                        writer.WriteLine(i.Type);
                        writer.WriteLine(i.Id);
                        foreach (string s in i.Values)
                        {
                            writer.WriteLine(s);
                        }
                    }
                    object[] workArgs = { Path.Combine(tbBSInstallLocation.Text, "Engine", i.Type + i.Id), Path.Combine(tbBackupLocation.Text, i.Name + ".zip") };
                    backgroundWorker1.RunWorkerAsync(workArgs);
                    pictureBox1.Visible = true;
                    buttonBackup.Enabled = false;
                }
                else
                {
                    if (i.Id == "0")
                    {
                        i.Id = "";
                    }
                    if (names.Contains(i.Name))
                    {
                        using (StreamWriter writer = new StreamWriter(Path.Combine(tbBSInstallLocation.Text, "Engine", i.Type + i.Id, "conf.txt")))
                        {
                            writer.WriteLine(i.Name);
                            writer.WriteLine(i.Type);
                            writer.WriteLine(i.Id);
                            foreach (string s in i.Values)
                            {
                                writer.WriteLine(s);
                            }
                        }
                        object[] workArgs = { Path.Combine(tbBSInstallLocation.Text, "Engine", i.Type + i.Id), Path.Combine(tbBackupLocation.Text, i.Name + ".zip") };
                        backgroundWorker1.RunWorkerAsync(workArgs);
                        pictureBox1.Visible = true;
                        buttonBackup.Enabled = false;
                    }
                }
                
            }
        }

        private void tbBSInstallLocation_Leave(object sender, EventArgs e)
        {
            try
            {
                if (Directory.Exists(tbBSInstallLocation.Text))
                {
                    Settings.Default.BlueStacksInstall = tbBSInstallLocation.Text;
                    if (checkBoxBackup.Checked || checkBoxRestore.Checked)
                    {
                        buttonBackup.Enabled = true;
                        buttonRestore.Enabled = true;
                    }
                    tbException.Visible = false;
                    tbException.Text = "";
                }
                else
                {
                    throw new Exception();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bluestacks Install Directory does not Exist.");
                buttonBackup.Enabled = false;
                buttonRestore.Enabled = false;
                tbException.Visible = true;
                tbException.Text = "Bluestacks Install Directory does not Exist.";
            }
        }

        private void checkBoxBackup_Click(object sender, EventArgs e)
        {
            if (checkBoxBackup.Checked)
            {
                checkBoxRestore.Checked = false;
                labelRestore.Visible = false;
                tbRestoreFile.Visible = false;
                buttonPickRestore.Visible = false;
                labelBackup.Visible = true;
                tbBackupLocation.Visible = true;
                buttonPickBackup.Visible = true;
                buttonRestore.Enabled = false;
                if (tbException.Text != "")
                {
                    buttonBackup.Enabled = true;
                }
                tbRestoreFile.Text = "";
            }
            else
            {
                labelBackup.Visible = false;
                tbBackupLocation.Visible = false;
                buttonPickBackup.Visible = false;
                buttonBackup.Enabled = false;
                instanceListBox.Items.Clear();
                tbBackupLocation.Text = "";
            }
        }

        private void checkBoxRestore_Click(object sender, EventArgs e)
        {
            if (checkBoxRestore.Checked)
            {
                checkBoxBackup.Checked = false;
                labelRestore.Visible = true;
                tbRestoreFile.Visible = true;
                buttonPickRestore.Visible = true;
                labelBackup.Visible = false;
                tbBackupLocation.Visible = false;
                buttonPickBackup.Visible = false;
                buttonBackup.Enabled = false;
                if (tbException.Text != "")
                {
                    buttonRestore.Enabled = true;
                }
                instanceListBox.Items.Clear();
                tbBackupLocation.Text = "";
            }
            else
            {
                labelRestore.Visible = false;
                tbRestoreFile.Visible = false;
                buttonPickRestore.Visible = false;
                buttonRestore.Enabled = false;
                tbRestoreFile.Text = "";
            }
        }

        private void buttonBlueStacksInstall_Click(object sender, EventArgs e)
        {
            if (tbBSInstallLocation.Text != "")
            {
                if (Directory.Exists(tbBSInstallLocation.Text))
                {
                    fbdBlueStacksInstall.SelectedPath = tbBSInstallLocation.Text;
                }
                else
                {
                    fbdBlueStacksInstall.SelectedPath = Settings.Default.lastDirectory;
                }
            }
            else
            {
                fbdBlueStacksInstall.SelectedPath = Settings.Default.lastDirectory;
            }

            if (fbdBlueStacksInstall.ShowDialog() == DialogResult.OK)
            {
                tbBSInstallLocation.Text = fbdBlueStacksInstall.SelectedPath;
                Settings.Default.lastDirectory = fbdBlueStacksInstall.SelectedPath;
                Settings.Default.BlueStacksInstall = tbBSInstallLocation.Text;
                Settings.Default.Save();
            }
        }

        private void buttonPickBackup_Click(object sender, EventArgs e)
        {
            if (tbBackupLocation.Text != "")
            {
                if (Directory.Exists(tbBackupLocation.Text))
                {
                    fbdBackupLocation.SelectedPath = tbBackupLocation.Text;
                }
                else
                {
                    fbdBackupLocation.SelectedPath = Settings.Default.lastDirectory;
                }
            }
            else
            {
                fbdBackupLocation.SelectedPath = Settings.Default.lastDirectory;
            }

            if (fbdBackupLocation.ShowDialog() == DialogResult.OK)
            {
                tbBackupLocation.Text = fbdBackupLocation.SelectedPath;
                Settings.Default.lastDirectory = fbdBackupLocation.SelectedPath;
                Settings.Default.Save();
                if (tbBackupLocation.Text != "")
                {
                    buttonBackup.Enabled = true;
                    GetInstances();
                }
            }
        }

        private void buttonPickRestore_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialogRestore = new OpenFileDialog())
            {
                openFileDialogRestore.InitialDirectory = Settings.Default.lastDirectory;
                openFileDialogRestore.Filter = "zip files (*.zip)|*.zip|All files (*.*)|*.*";
                openFileDialogRestore.FilterIndex = 1;
                openFileDialogRestore.RestoreDirectory = true;
                if (openFileDialogRestore.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    tbRestoreFile.Text = openFileDialogRestore.FileName;
                    buttonRestore.Enabled = true;
                }
            }
        }

        private void tbBackupLocation_Leave(object sender, EventArgs e)
        {
            if(tbBackupLocation.Text != "")
            {
                buttonBackup.Enabled = true;
            }
        }
        private static void CloneDirectory(string root, string dest)
        {
            foreach (var directory in Directory.GetDirectories(root))
            {
                string dirName = Path.GetFileName(directory);
                if (!Directory.Exists(Path.Combine(dest, dirName)))
                {
                    Directory.CreateDirectory(Path.Combine(dest, dirName));
                }
                CloneDirectory(directory, Path.Combine(dest, dirName));
            }

            foreach (var file in Directory.GetFiles(root))
            {
                File.Copy(file, Path.Combine(dest, Path.GetFileName(file)));
            }
        }
        private void ZipDirectory(string from, string to)
        {            
            ZipFile.CreateFromDirectory(from, to);
        }

        private void ExtractDirectory(string from, string to)
        {
            ZipFile.ExtractToDirectory(from, to);
        }

        private void buttonBackup_Click(object sender, EventArgs e)
        {
            List<string> backupItems = new List<string>();
            foreach (var item in instanceListBox.SelectedItems)
            {
                backupItems.Add(item.ToString());
            }
            Backup(backupItems);
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {            
            object[] arg = e.Argument as object[];
            string from = (string)arg[0];
            string to = (string)arg[1];            
            ZipDirectory(from, to);
            Invoke(new Action(() => {
                pictureBox1.Visible = false;
                buttonBackup.Enabled = true;
            }));
            if (File.Exists(Path.Combine(from, "conf.txt")))
            {
                File.Delete(Path.Combine(from, "conf.txt"));
            }
        }

        private void buttonRestore_Click(object sender, EventArgs e)
        {
            //Directory.CreateDirectory(Path.Combine(tbBSInstallLocation.Text, "Engine", Path.GetFileNameWithoutExtension(tbRestoreFile.Text) + "\\"));
            object[] workArgs = { tbRestoreFile.Text, Path.Combine(tbBSInstallLocation.Text,"Engine", Path.GetFileNameWithoutExtension(tbRestoreFile.Text)) };
            backgroundWorker2.RunWorkerAsync(workArgs);
            pictureBox2.Visible = true;
            buttonRestore.Enabled = false;
        }

        private void backgroundWorker2_DoWork(object sender, DoWorkEventArgs e)
        {
            
            object[] arg = e.Argument as object[];
            string from = (string)arg[0];
            string to = (string)arg[1];
            if (Directory.Exists(to))
            {
                Directory.Delete(to, true);
                Directory.CreateDirectory(to);
            }
            ExtractDirectory(from, to);
            int count = 0;
            int count2 = 1;
            Models.Instances instances = new Models.Instances();
            using (StreamReader reader = new StreamReader(Path.Combine(to, "conf.txt")))
            {
                while (reader.Peek() >= 0)
                {
                    string nextLine = reader.ReadLine();
                    if (nextLine != null)
                    {
                        if(count == 0)
                        {
                            instances.Name = nextLine;
                        }
                        else if (count == 1)
                        {
                            instances.Type = nextLine;
                        }
                        else if (count == 2)
                        {
                            instances.Id = nextLine;
                            while(Directory.Exists(Path.Combine(Directory.GetParent(to).FullName,instances.Type+instances.Id)))
                            {
                                instances.Id = "_" + count2;
                                count2++;
                            }
                        }
                        else
                        {
                            instances.Values.Add(nextLine);
                        }                        
                    }
                    count++;
                }
                count = 0;
                count2 = 1;                
            }
            if (Directory.Exists(to))
            {
                string newDir = Path.Combine(Directory.GetParent(to).FullName, instances.Type + instances.Id);
                Directory.Move(to, newDir);
            }
            string bluestacksConf = Path.Combine(Directory.GetParent(Directory.GetParent(to).FullName).FullName, "bluestacks.conf");
            List<string> writerLineList = new List<string>();
            int countIndex = 0;
            int installedImagesIndex = 0;
            using (StreamReader readerConf = new StreamReader(bluestacksConf))
            {
                while (readerConf.Peek() >= 0)
                {
                    string nextLine = readerConf.ReadLine();
                    if (nextLine != null)
                    {
                        writerLineList.Add(nextLine);
                        if (nextLine.Contains("bst.installed_images"))
                        {
                            installedImagesIndex = countIndex;
                        }
                        countIndex++;
                    }
                }
            }
            for (int i = 0; i < instances.Values.Count(); i++)
            {
                instances.Values[i] = "bst.instance." + instances.Type+instances.Id + instances.Values[i];
            }
            if (!writerLineList[installedImagesIndex].Contains(instances.Type))
            {
                writerLineList[installedImagesIndex] = "bst.installed_images = \"Nougat32,Nougat64\"";
            }
            writerLineList.InsertRange(installedImagesIndex + 1, instances.Values.ToArray());

            if (File.Exists(bluestacksConf))
            {
                File.Delete(bluestacksConf);
            }

            using (StreamWriter writeConf = new StreamWriter(bluestacksConf))
            {
                foreach (string s in writerLineList)
                {
                    writeConf.WriteLine(s);
                }
            }

            Invoke(new Action(() => {
                pictureBox2.Visible = false;
                buttonRestore.Enabled = true;
            }));
        }
    }
}
