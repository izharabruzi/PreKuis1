using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Kuis1
{
    internal class Manager : OutputClass
    {
        public string tipe_manager { get; set; }
        public List<Staff> staffs { get; set; }

        public Manager()
        {
            staffs = new List<Staff>();
        }


    }
}
