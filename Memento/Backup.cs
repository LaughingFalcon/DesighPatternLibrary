using System;
using System.Collections.Generic;
using System.Text;

namespace DesighPatternLibrary.Memento
{
    public class Backup
    {
        int control;
        Dictionary<int, GenericClass> versions;

        public Backup()
        {
            control = 0;
            versions = new Dictionary<int, GenericClass>();
        }
        public void addBackup(GenericClass memento)
        {
            control++;
            versions.Add(control, memento);
        }
        public GenericClass recoverVersion(int version)
        {
            return versions[version];
        }
        public bool containsVersion(int value)
        {
            return versions.ContainsKey(value);
        }
    }
}
