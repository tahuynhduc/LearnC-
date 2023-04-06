namespace day03
{
    class program
    {
        static void Main(string[] args)
        {
            exam01();
            exam02();

        }

        private static void exam02()
        {
            int[,] a ={
                        {4,6,9},
                        {2,4,5},
                        {9,2,6},
                        {1,6,3}
                        };
            //duyệt mảng và in theo hàng cột
            Console.WriteLine("Noi dung mang:");
            for (int i = 0; i <= a.GetUpperBound(0); i++)
            {
                Console.WriteLine();
                for (int j = 0; j <= a.GetUpperBound(1); j++)
                {
                    Console.Write(" {0} ", a[i, j]);
                }
                Console.WriteLine();
            }
            //tìm các phần tử có chỉ số hàng bằng chỉ số cột
            Console.WriteLine("Cac phan tu co chi so hang bang chi so cot:");
            for (int i = 0; i <= a.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= a.GetUpperBound(1); j++)
                {
                    if (i == j)
                        Console.Write(" {0} ", a[i, j]);
                }
            }
            //các phần tử lớn nhất trên hàng
            Console.WriteLine("Cac phan tu lon nhat tren hang");
            for (int i = 0; i <= a.GetUpperBound(0); i++)
            {
                int max = a[i, 0];
                for (int j = 0; j <= a.GetUpperBound(1); j++)
                {
                    if (max < a[i, j])
                        max = a[i, j];

                }
                Console.WriteLine("Hang {0}:{1}", i, max);
            }
        }

        private static void exam01()
        {
            //khai báo và khởi tạo mảng 1 chiều
            int[] m = { 5, 8, 3, 0, 2, 1, 7, 8 };
            //duyệt mảng và in dữ liệu
            Console.Write("Cac phan tu cua mang:");
            for (int i = 0; i < m.Length; i++)
            {
                Console.Write(" {0} ", m[i]);
            }
            //tìm phần tử lớn nhất
            int max = m[0];
            for (int i = 0; i < m.Length; i++)
            {
                if (max < m[i])
                    max = m[i];

            }
            Console.WriteLine("\nPhan tu lon nhat:" + max);
            //kiểm tra mảng có đối xứng không?
            bool kt = true;
            for (int i = 0; i < m.Length / 2; i++)
            {
                if (m[i] != m[m.Length - 1 - i])
                {
                    kt = false;
                    break;
                }
            }
            if (kt)
                Console.WriteLine("Mang doi xung");
            else

                Console.WriteLine("Mang khong doi xung");
        }
    }
}