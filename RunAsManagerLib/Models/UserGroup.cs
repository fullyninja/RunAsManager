using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RunAsManagerLib.Models
{
    public class UserGroup
    {
        public string UserName { get; set; }
        public string Domain { get; set; }
        public string password { get; set; }
        public List<ApplicationDetail> ApplicationDetails { get; set; }
    }
}
