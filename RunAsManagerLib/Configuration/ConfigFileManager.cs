using RunAsManagerLib.Helpers;
using RunAsManagerLib.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RunAsManagerLib.Configuration
{
    public class ConfigFileManager
    {
        private string _filePath;
        private string _schemaPath;
        private List<UserGroup> _userGroups = new List<UserGroup>();

        public ConfigFileManager(string filePath)
        {
            _filePath = ConfigHelper.GetFilePathFromConfig();
            _filePath = ConfigHelper.GetSchemaPathFromConfig();
        }        

        // LIST User Groups
        public List<UserGroup> GetUserGroup()
        {
            throw new NotImplementedException();
        }

        // ADD User Group
        public void AddUserGroup(UserGroup userGroup)
        {
            throw new NotImplementedException();
        }

        // UPDATE User Group
        public void UpdateUserGroup(UserGroup userGroup)
        {
            throw new NotImplementedException();
        }

        // DELETE User Group
        public void DeleteUserGroup(UserGroup userGroup)
        {
            throw new NotImplementedException();
        }


        // ADD Application Detail

        // UPDATE Application Detail

        // DELETE Application Detail

        

        public bool ValidateSchema()
        {
            throw new NotImplementedException();
        }
    }
}
