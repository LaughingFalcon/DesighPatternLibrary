using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Interator
{
    public class UserInfo
    {
        public UserInfo(int id, string name, string lastname)
        {
            this.Id = id;
            this.Name = name;
            this.lastname = lastname;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string lastname { get; set; }
    }
}
