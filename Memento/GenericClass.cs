using System;
using System.Collections.Generic;
using System.Text;

namespace DesighPatternLibrary.Memento
{
    public class GenericClass
    {
        string name;
        int version;
        string status;

        public GenericClass(string name,string status)
        {
            this.name = name;
            version = 0;
            this.status = status;
        }

        public void setName(string name)
        {
            this.name = name;
            version++;
        }
        public void setStatus(string status)
        {
            this.status = status;
            version++;
        }
        public void setNameAndStatus(string name, string status)
        {
            this.name = name;
            this.status = status;
            version++;
        }
        public string getName()
        {
            return name;
        }
        public string getStatus()
        {
            return status;
        }
        public int getVersion()
        {
            return version;
        }

        public GenericClass Clone()
        {
            GenericClass clone = new GenericClass(name,status);
            clone.version = this.version;
            return  clone;
        }
    }
}
