using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RunAsManagerLib.Configuration
{
    public class ConfigFileProperties : ConfigurationSection
    {
        [ConfigurationProperty("location")]
        public string Location {
            get
            {
                return this["location"].ToString();
            }
            set
            {
                this["location"] = value;
            }
        }
    }
}
