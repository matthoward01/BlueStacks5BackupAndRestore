using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlueStacks5BackupAndRestore
{
    class Models
    {
        public class Instances
        {
            public string Name { get; set; }
            public string Type { get; set; }
            public string Id { get; set; }
            public List<string> Values { get; set; } = new List<string>();
        }
        public class InstancesList
        {
            public List<Instances> Instances { get; set; } = new List<Instances>();
        }
    }
}
