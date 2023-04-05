using System.Xml.Linq;

namespace solution
{
    class program
    {
        static void Main(string[] args)
        {
            #region
            //1.2
            /*
            Console.WriteLine("ho va ten: ta huynh duc");
            Console.WriteLine("ngay sinh: 03/03/2000");
            Console.WriteLine("Dia chi: ha noi");
            Console.WriteLine("123456789");
            Console.WriteLine("dang hoc lai C#");
            */

            //1.3
            /*
            //khai bao bien
            int id = 1;
            string name = "David George";
            byte age = 18;
            char gender = 'M';
            //khai bao hang so
            const float percent = 75.50F;
            //Hiển thị giá trị các biến và hằng số
            Console.WriteLine("Student ID : {0}", id);
            Console.WriteLine("Student Name : {0}", name);
            Console.WriteLine("Age : " + age);
            Console.WriteLine("Gender : " + gender);
            Console.WriteLine("Percentage : {0}", percent);
            */

            //1.4
            /*
            Console.WriteLine("Thong tin sinh vien");
            int Id = int.Parse(Console.ReadLine());
            string Name = Console.ReadLine();
            DateTime Birthday = DateTime.Parse(Console.ReadLine());
            float Mark1 = float.Parse(Console.ReadLine());
            float Mark2 = float.Parse(Console.ReadLine());
            float Mark3 = float.Parse(Console.ReadLine());
            float average = (Mark1+ Mark2+ Mark3)/3;

            Console.WriteLine("Ma so:{0}", Id);
            Console.WriteLine("Ho va ten:{0}", Name);
            Console.WriteLine("Ngay sinh:{0:dd/MM/yyyy}", Birthday);
            Console.WriteLine("Diem 1:{0:N}, Diem 2:{1:N}, Diem 2:{2:N}", Mark1,
            Mark2, Mark3);
            Console.WriteLine("Diem trung binh:{0:N}", average);
            */
            #endregion


            //1.1
            /*
            Console.WriteLine("       +++++++++                ++++ ++++");
            Console.WriteLine("     +++++++++++++        +++++++++++++++++++");
            Console.WriteLine("    ++++       ++++      +++++++++++++++++++");
            Console.WriteLine("   ++++                      ++++ ++++");
            Console.WriteLine("   ++++                     ++++ ++++");
            Console.WriteLine("    ++++       ++++    +++++++++++++++++++");
            Console.WriteLine("     +++++++++++++    +++++++++++++++++++");
            Console.WriteLine("       ++++++++         ++++  ++++");
            */

            //1.2
            /*
            Console.WriteLine("thong tin nhan vien");
            int Id = int.Parse(Console.ReadLine());
            string Name = Console.ReadLine();
            string Address = Console.ReadLine();
            DateTime Birthday = DateTime.Parse(Console.ReadLine());
            int Salary = int.Parse(Console.ReadLine());
            int Bonus = int.Parse(Console.ReadLine());
            int TotalSalary = Salary + Bonus;

            Console.WriteLine($"id:{Id}");
            Console.WriteLine($"Name:{Name}");
            Console.WriteLine($"Address:{Address}");
            Console.WriteLine($"Birthday:{Birthday}");
            Console.WriteLine($"TotalSalary:{TotalSalary}");
            */



            Console.ReadLine();
        }
    }
}