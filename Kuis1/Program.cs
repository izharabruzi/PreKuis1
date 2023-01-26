using System.Globalization;
using System.Reflection.Metadata;

namespace Kuis1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            

            Presiden pres = new Presiden() {Id = Guid.NewGuid(), nama = "Ali",BOD = DateTime.ParseExact("31/12/2022", "dd/MM/yyyy", CultureInfo.InvariantCulture), posisi = "Presiden", gaji = 12_000_000, namaperusahaan = "ABC Inc" };

            Manager manager1 = new Manager() { Id = Guid.NewGuid(), BOD = DateTime.ParseExact("31/12/2022", "dd/MM/yyyy", CultureInfo.InvariantCulture), nama = "Bambang", posisi = "Manager", gaji = 8_000_000, tipe_manager = "HR Manager" };
            Manager manager2 = new Manager() { Id = Guid.NewGuid(), BOD = DateTime.ParseExact("31/12/2022", "dd/MM/yyyy", CultureInfo.InvariantCulture),nama = "Joko", posisi = "Manager", gaji = 8_000_000, tipe_manager = "Finance Manager" };
            Manager manager3 = new Manager() { Id = Guid.NewGuid(),BOD = DateTime.ParseExact("31/12/2022", "dd/MM/yyyy", CultureInfo.InvariantCulture), nama = "Jahar", posisi = "Manager", gaji = 8_000_000, tipe_manager = "IT Manager" };

            Staff staff1 = new Staff() { Id = Guid.NewGuid(), BOD = DateTime.ParseExact("08/01/2023", "dd/MM/yyyy", CultureInfo.InvariantCulture),nama = "Jarot", posisi = "Staff", gaji = 5_000_000, divisi = "Finance" };
            Staff staff2 = new Staff() { Id = Guid.NewGuid(),BOD = DateTime.ParseExact("12/01/2023", "dd/MM/yyyy", CultureInfo.InvariantCulture), nama = "Pamungkas", posisi = "Staff", gaji = 5_000_000, divisi = "Finance" };
            Staff staff3 = new Staff() { Id = Guid.NewGuid(),BOD = DateTime.ParseExact("15/01/2023", "dd/MM/yyyy", CultureInfo.InvariantCulture), nama = "Steve", posisi = "Staff", gaji = 5_000_000, divisi = "IT" };


            pres.managers.Add(manager1);
            pres.managers.Add(manager2);
            pres.managers.Add(manager3);

            manager2.staffs.Add(staff1);
            manager3.staffs.Add(staff2);
            manager3.staffs.Add(staff3);




            //pres.Print();
            //manager2.Print();
            staff2.Print();
            




        }
    }
}