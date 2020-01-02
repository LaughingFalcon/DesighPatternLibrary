using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Proxy
{
    public class RealImage : IImage
    {
        private String fileName;
        public RealImage(String fileName)
        {
            this.fileName = fileName;
            loadFromDisk(fileName);
        }
        public void display()
        {
            Console.WriteLine("Mostrando " + fileName);
        }
        private void loadFromDisk(String fileName)
        {
            Console.WriteLine("Carregando "+fileName);
        }
    }
}
