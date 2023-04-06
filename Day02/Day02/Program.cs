using static System.Runtime.InteropServices.JavaScript.JSType;

namespace solution
{
    class program
    {
        static void Main(string[] args)
        {
            #region
            //2.1
            /*
            string name = Console.ReadLine();
            int useNumber = int.Parse(Console.ReadLine());
            double money = 0;

            if(useNumber <= 30)
            {
                money = 30;
            }
            else if(useNumber >30 && useNumber <=50)
            {
                money = 30 + (useNumber - 30 ) * 1.2;
            }
            else
            {
                money = 30 + 20 * 1.2 + (useNumber - 50) * 1.5;
            }
            Console.WriteLine(money);
            */

            //2.2
            /*
            char ch;
            Console.WriteLine("Nhap vao ky tu:");
            ch = (char)Console.Read();
            switch (ch)
            {
                case 'a':
                case 'o':
                case 'e':
                case 'u':
                case 'i':
                    Console.WriteLine("{0} la nguyen am.", ch);
                    break;
                default:
                    Console.WriteLine("{0} la phu am.", ch);
                    break;
            }
            */

            //2.3
            /*
            //Khai báo các biến
            double a, b, c, delta, x1, x2;
            //Nhập a,b,c
            Console.Write("a=");
            //a phải !=0
            do
            {
                a = Convert.ToInt32(Console.ReadLine());
            }
            while (a == 0);
            Console.Write("b=");
            b = Convert.ToInt32(Console.ReadLine());
            Console.Write("c=");
            c = Convert.ToInt32(Console.ReadLine());
            //tính delta
            delta = b * b - 4 * a * c;
            //biện luận
            if (delta < 0)
                Console.Write("Phuong trinh vo nghiem");
            else if (delta == 0)
            {
                Console.WriteLine("Phuong trinh co nghiem kep");
                Console.WriteLine("x1=x2={0}", -b / (2 * a));
            }
            else
            {
                Console.WriteLine("Phuong trinh co 2 nghiem");
                x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                Console.WriteLine("x1={0}", x1);
                x2 = (-b - Math.Sqrt(delta)) / (2 * a);
                Console.WriteLine("x2={0}", x2);
            }
            */

            //2.4
            /*
            //khai báo biến đánh dấu
            bool check_i;
            Console.Write("Danh sach cac so nguyen to tu 2-100: ");
            //duyệt từ 2-100
            for (int i = 2; i <= 100; i++)
            {
                check_i = true; //giả sử i là số nguyên tố
                for (int j = 2; j <= i / 2; j++) //duyệt từ 2-j/2
                {
                    if (i % j == 0)//nếu i chia hết cho j thì
                    {
                        check_i = false;//kết luận không là số nguyên tố
                        break;//thoát khỏi vòng lặp hiện tại
                    }
                }
                if (check_i) //nếu giả sử vẫn đúng -> i là số nguyên tố
                    Console.Write(" {0} ", i);
            }
            */

            //2.5
            /*
            int sum=0;
            for(int i = 0; i<=100; i++) 
            {
                if(i % 2 != 0 && i %3 == 0 )
                {
                    sum += i;
                }
            }
            Console.WriteLine(sum);
            */

            //2.6
            /*
            string[] names = { "Thang", "Long", "Hoa", "Dao" };
            Console.Write("Danh sanh sinh vien:\n");
            foreach (var name in names) 
            {
                Console.WriteLine(name);
            }*/
            #endregion

            //2.1
            /*
            Console.Write("Nhập năm: ");
            int year = int.Parse(Console.ReadLine());

            Console.Write("Nhập tháng: ");
            int month = int.Parse(Console.ReadLine());

            int daysInMonth = DateTime.DaysInMonth(year, month);
            Console.WriteLine($"Số ngày trong tháng {month}/{year} là {daysInMonth}");
            */

            //2.2
            /*
            Console.Write("Nhập số giây: ");
            int totalSeconds = int.Parse(Console.ReadLine());

            int hours = totalSeconds / 3600;
            int minutes = (totalSeconds % 3600) / 60;
            int seconds = totalSeconds % 60;

            string formattedTime = $"{hours:00}:{minutes:00}:{seconds:00}";
            Console.WriteLine(formattedTime);
            */

            //2.3
            /*
            int sum = 0;
            for (int i = 100; i <= 999; i++)
            {
                if (i % 2 != 0 && i % 3 == 0)
                {
                    sum += i;
                }
            }
            Console.WriteLine(sum);
            */

            //2.4
            /*
            for (int i = 0; i < 5; i++) 
            {
                Console.WriteLine();
                for (int j = i; j < 5; j++)
                {
                    Console.Write("$");
                }
            }
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine();
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("*");
                }
            }

            for (int i = 0; i < 5; i++)
            {
                for (int j = 1; j <= 5 - i; j++)
                    Console.Write(" ");
                for (int j = 1; j <= 2 * i - 1; j++)
                    Console.Write("*");
                Console.Write("\n");
            }*/

            //2.5
            /*
            Console.Write("Nhập a: ");
            int a = int.Parse(Console.ReadLine());
        
            Console.Write("Nhập b: ");
            int b = int.Parse(Console.ReadLine());
        
            Console.Write("Nhập c: ");
            int c = int.Parse(Console.ReadLine());
        
            if (a + b > c && a + c > b && b + c > a)
            {
                if (a == b && b == c)
                {
                    Console.WriteLine("Đây là tam giác đều.");
                }
                else if (a == b || b == c || c == a)
                {
                    Console.WriteLine("Đây là tam giác cân.");
                }
                else if (a * a + b * b == c * c || b * b + c * c == a * a || c * c + a * a == b * b)
                {
                    Console.WriteLine("Đây là tam giác vuông.");
                }
                else
                {
                    Console.WriteLine("Đây là tam giác thường.");
                }
            }
            else
            {
                Console.WriteLine("a, b, c không tạo thành độ dài 3 cạnh của một tam giác.");
            }
             */

            //2.6
            /*
            int n = 10;
            int x = 0;
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= n - i; j++)
                {
                    Console.Write(" ");
                }

                for (int j = 1; j <= i; j++)
                {
                    x++;
                    Console.Write(x % 10);
                }

                for (int j = i - 1; j >= 1; j--)
                {
                    x--;
                    Console.Write(x % 10);
                }
                Console.WriteLine();
            }*/

            //2.7
            /*
            Console.WriteLine("Nhap so tien gui: ");
            double tienGoc = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Nhap lai suat ngan hang (tinh theo nam): ");
            double laiSuatNam = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Nhap so thang gui: ");
            int soThangGui = Convert.ToInt32(Console.ReadLine());

            double laiSuatThang = (laiSuatNam / 12) / 100;
            double tienLaiThang = tienGoc * laiSuatThang;

            for (int i = 0; i < soThangGui; i++)
            {
                tienGoc += tienLaiThang;
            }

            double tienLaiCuoiKy = tienGoc - (tienGoc / (1 + laiSuatThang) * Math.Pow(1 + laiSuatThang, soThangGui));

            Console.WriteLine("So du cuoi ky: " + tienGoc);
            Console.WriteLine("Tien lai cuoi ky: " + tienLaiCuoiKy);
            */

            Console.ReadLine();
        }
    }
}