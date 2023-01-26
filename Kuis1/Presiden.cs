using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlTypes;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Kuis1
{
    class Presiden : OutputClass
    {
        public string namaperusahaan { set; get; }
        //public string manager { set; get; }

        public List<Manager> managers { get; set; }

        public Presiden()
        {
            managers = new List<Manager>();
        }

        public override void Print()
        {
            base.Print();
            Console.WriteLine("List of Managers: ");
            foreach (var manager in managers)
            {
                Console.WriteLine("Nama : " + manager.nama);
                Console.WriteLine(manager.nama + "Id : " + manager.Id);
            }
        }


    }
}
