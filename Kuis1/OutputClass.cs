using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Kuis1
{
    class OutputClass
    {

        public Guid Id { get; set; }
        public string nama { get; set; }
        public string posisi { get; set; }
        public double gaji { get; set; }
        
        public DateTime BOD { get; set; } 

        public string BODString(DateTime x)
        {
            return x.ToString("dd-MM-yyyy");
        }
        
        
        
        
        public virtual void Print()
        {
            List<string> list = new List<string>();
            list.Add("ID: " + Id);
            list.Add("Name: " + nama);
            list.Add("Position: " + posisi);
            list.Add("BOD: " + BODString(BOD));
            list.Add("Salary: " + gaji);
            
            

            if (this is Staff)
            {
                Staff staff = (Staff) this;
                list.Add("Division: " + staff.divisi);
            }
            else if (this is Manager)
            {
                Manager manager = (Manager)this;
                list.Add("Manager Type: " + manager.tipe_manager);
                list.Add("List of Staff: ");
                foreach (var staff in manager.staffs)
                {
                    list.Add("Nama : " + staff.nama);
                    list.Add(staff.nama +" Id : " + staff.Id);
                }
            }
            else if (this is Presiden)
            {
               Presiden president = (Presiden)this;
               list.Add("Nama Perusahaan: " + president.namaperusahaan);
               //list.Add("List of Manager: "+ president.managers);


            }

            foreach (string item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
}

