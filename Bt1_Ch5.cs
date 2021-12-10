/*
1.	Viết chương trình nhập vào một số nguyên dương n. Viết menu cho phép lựa chọn tính và hiển thị kết quả một trong các biểu thức sau:
A = Tổng các số lẻ nhỏ hơn hay bằng n.
B = Tích các bội số của 3 và nhỏ hơn hoặc bằng n.
C = 1 + 1/2 + 1/3 + . . . + 1/n-1.
D = 2 * 4 * 6 * … 2n.
E = N! = 1 * 2 * . .  * n.
 DO PHAN DUY HUNG 
 CD21TT11
*/
using System;


namespace bai_tap_chuong5
{
    class Bt1_Ch5
    {
        static void Main(string[] args)
        {
            int a ;
            int b ;
            double c ;
            int d ;
            int e ;
            int n=0;
            char kitu = '\0';
            
            Console.WriteLine("nhap so nguyen n = ");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("lua chon phep tinh ");
            Console.WriteLine("A = tong cac so le nho hon hay bang n ");
           
            Console.WriteLine("B = tich cac boi so cua 3 va nho hon hoac bang n ");
            Console.WriteLine("C = 1 + 1/2 + 1/3 + . . . + 1/n-1. ");
            Console.WriteLine("D = 2 * 4 * 6 * … 2n.");
            Console.WriteLine("E = N! = 1 * 2 * . .  * n.");
            char.TryParse(Console.ReadLine(), out kitu);
            switch (kitu)
            {
                case 'a':
                case 'A':
                    int tongle = 0;
                for ( a =1;a<=n;a+=2)
                    {
                        tongle += a;
                    }
                    Console.WriteLine($" tong so le = {tongle}");
                    //int tichB = 1;
                   // for (int b =1; 3*b<= n;b++)
                    //{ }
                   break;
                case 'b':
                case 'B':
                    int tichB = 1;
                for (b=3;b<=n;b+=3)
                    {
                            tichB *= b;
                    }
                    Console.WriteLine($" tong tich = {tichB}");
                    break;
                case 'c':
                case 'C':
                    //C = 1 + 1/2 + 1/3 + . . . + 1/n-1.
                  double tongC = 0;
                    for (c = 1 ; c <= n ; c++)
                    {
                        tongC += 1/c;   //1 / (n-1);
                    }
                    Console.WriteLine($" tong C = {tongC}");
                    break;
                case 'd':
                case 'D':
                    //D = 2 * 4 * 6 * … 2n.
                    int tichD = 2;
                    for ( d=2;d<= n;d+=2)
                    {
                        tichD = tichD*d;
                    }
                    Console.WriteLine($" D = 2 * 4 * 6 * … 2n = {tichD}");
                    break;
                case 'e':
                case 'E':
                    //E = N! = 1 * 2 * . .  * n.
                    int tichE = 1;
                    for (e = 1; e <= n; e++)
                    {
                        tichE *= e;
                    }
                    Console.WriteLine($" E = N! = 1 * 2 * . .  * n. = {tichE}");
                    break;
            }
            Console.ReadKey();
         
        }
    }
}
