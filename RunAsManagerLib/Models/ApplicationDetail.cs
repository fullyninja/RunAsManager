using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RunAsManagerLib.Models
{
    public class ApplicationDetail
    {
        public string ApplicationName { get; set; }
        public string ExePath { get; set; }
        public string CommandLineArgs { get; set; }
    }
}
