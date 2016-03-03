using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _50Zadach
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Выберите номер задания, или нажмите 0 для вывода списка заданий");
            int  caseSwitch = Convert.ToInt32(Console.ReadLine());
            switch (caseSwitch)
            {

                case 1:
                    Console.WriteLine("Zadanie 1 \n");

                    Console.Write("HelloWorld! ");  

                    break;


                case 2:
                    Console.WriteLine("Zadanie 2,введите три числа");
                    var a2 = Console.ReadLine();
                    var b2 = Console.ReadLine();
                    var c2 = Console.ReadLine();

                    Console.Write(c2 + "\n"  + b2 +  "\n"  + a2 + "\n");

                    break;
                case 3:
                    Console.WriteLine("Zadanie 3,ведите число");
                    var a3 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(a3*a3);
                    break;
                case 4:
                    Console.WriteLine("Zadanie 4, введите число");

                    var a4 = Convert.ToInt32(Console.ReadLine());
                    while (a4 != 0)
                    {
                        Console.Write(a4 % 10);
                        a4 = a4 / 10;
                    }
                    Console.Write("\n");
                    break;
                case 5:
                    Console.WriteLine("Zadanie 5, введите число");
                    var a5 = Convert.ToInt32(Console.ReadLine());
                    int k5 = 0;
                    while (a5 != 0)
                    {
                        k5 += a5 & 1;
                        a5 >>= 1;
                    }
                    Console.Write("в числе "+k5+ " единичных байтов ");  
                     break;









                case 6:
                    Console.WriteLine("Zadanie 6,ввведите 2 числа");
                    int a6 = Convert.ToInt32(Console.ReadLine());
                    int b6 = Convert.ToInt32(Console.ReadLine());
                    Console.Write((a6>b6)? a6:b6 );

                    break;

                case 7:
                    Console.WriteLine("Zadanie 7, введите 3 числа для сравнения");
                    int a7 = Convert.ToInt32(Console.ReadLine());
                    int b7 = Convert.ToInt32(Console.ReadLine());
                    int c7 = Convert.ToInt32(Console.ReadLine());
                    if ((a7>b7)   && (a7 > c7)) Console.Write(a7);
                    if ((b7 > a7) && (b7 > c7)) Console.Write(b7);
                    if ((c7 > b7) && (c7 > a7)) Console.Write(c7);
                    break;

                case 8:
                    Console.WriteLine("Zadanie 8, введите номер дня недели");
                    int a8 = Convert.ToInt32(Console.ReadLine());
              
                    switch (a8)
                    {
                        case 1:
                            Console.WriteLine("Понедельник");
                            break;
                        case 2:
                            Console.WriteLine("Вторник");
                            break;
                        case 3:
                            Console.WriteLine("Среда");
                            break;
                        case 4:
                            Console.WriteLine("Четверг");
                            break;
                        case 5:
                            Console.WriteLine("Пятница");
                            break;
                        case 6:
                            Console.WriteLine("Суббота");
                            break;
                        case 7:
                            Console.WriteLine("Воскресенье");
                            break;
                    }
                    break;


                case 9:
                    Console.WriteLine("Zadanie 9, введите число");
            
                    string a9 = Console.ReadLine();
            
                    string b9 = null;
                    for (int i = a9.Length - 1; i >= 0; i--)
                    {
                        b9 = b9 + a9[i];
                    }

                    if (a9==b9) Console.WriteLine("Palindrome");
                    else
                    Console.WriteLine("NotPalindrome");

                    break;

                case 10:
                    Console.WriteLine("Zadanie 10,введите номер билета");
                    string a = Console.ReadLine();
                    if (Convert.ToInt32(a[0]) + Convert.ToInt32(a[1]) == Convert.ToInt32(a[3]) + Convert.ToInt32(a[4])) Console.WriteLine("да"); else Console.WriteLine("нет");
   
                    break;

                case 11: 
                      Console.WriteLine("Zadanie 11, введите число");
                    int a11 = Convert.ToInt32(Console.ReadLine());
                    string str1 = null;

                    while (a11 != 0)
                    {
                        str1 = str1 + (char)(a11 % 2);
                        a11 = a11 / 2;
                    }
                    string str2 = null;
                    for (int i = str1.Length - 1; i >= 0; i--)
                    {
                        str2 = str2 + str1[i];
                    }
                    Console.WriteLine("Answer:");
                    if (str1==str2) Console.WriteLine("Palindrome"); else Console.WriteLine("NotPalindrome");

                    break;
                case 12:
                    Console.WriteLine("Zadanie 12, введите коофиценты");
                    string[] str = Console.ReadLine().Split(' ');
                    Console.WriteLine("Answer:");
                    double a12 = Convert.ToInt32(str[0]);
                    double b12 = Convert.ToInt32(str[1]);
                    double c12 = Convert.ToInt32(str[2]);
                    double d12 = b12 * b12 - 4 * a12 * c12;
                    Console.WriteLine("x1= " + ((-b12 + Math.Sqrt(d12)) / 2.0 / a12) + "\tx2= " + ((-b12 - Math.Sqrt(d12)) / 2.0 / a12));

                    break;
                case 13:
                    Console.WriteLine("Zadanie 13,введите число");
                    int a13 = Convert.ToInt32(Console.ReadLine());          
                    for (int i = 0; i <= a13; i++)
                    {
                        Console.Write(i + " ");
                    }
                    break;

                case 14:
                    
                    break;
                case 15:
                    Console.WriteLine("Zadanie 15,введите число");
                    int a15 = Convert.ToInt32(Console.ReadLine());
                    for (int i = 2; i <=a15; i++)
                    {
                        if (a15%i == 0)
                        {
                          
                            break;
                        }
                       
                     }
                    break;
                case 16:
            
                    Console.WriteLine("Zadanie 16,введите число");
                    int a16 = Convert.ToInt32(Console.ReadLine());
                    int k16 = 0;
                    for (int i = 1; i <= a16; i++)
                    {
                        if (a16 % i == 0)
                        {
                            k16++;
                        }
                        Console.WriteLine(k16);

                    }
                    break;
                case 17:
                    Console.WriteLine("Zadanie 17,введите число");
              
                    int a17 = Convert.ToInt32(Console.ReadLine());
                    int k17 = 0;
                    for (int i = 1; i <= a17; i++)
                    {
                        if (a17 % i == 0)
                        {
                            k17++;
                        }


                    }
                    Console.WriteLine((a17 == 2) ? 1:0);
                    break;
                  


                case 18:
                    Console.WriteLine("Zadanie 18,введите число");
                int a18 = Convert.ToInt32(Console.ReadLine());
                bool f18 = true;
                int j18;
                    for (j18 = 2; j18 < a18; j18++)
                    {
                        for (double i18 = 2; i18 < j18/2; i18++)
                        {
                            if ((j18%i18 == 0) && (f18))
                            {
                                f18 = false;
                            }
                        }
                        if ((f18) || (j18 == 2)) Console.WriteLine(j18 + " ");
                    }
                    f18 = true;
                    break;

                case 19:
                    Console.WriteLine("Zadanie 19, введите сколько чисел вывести");
                    int a19, k19 = 0, j19 = 2;
                    bool f19;
                    a19 = Convert.ToInt32(Console.ReadLine());
                    while (k19 < a19)
                    {
                        f19 = true;
                        for (double i19 = 2; i19 < j19 / 2; i19++)
                        {
                            if ((j19 % i19 == 0) & (f19))
                            {
                                f19 = false;
                            }
                        }
                        if ((f19) || (j19 == 2))
                        {
                            Console.WriteLine(j19 + " ");
                            k19++;
                        }
                        j19++;
                    }

                    break;
                case 20:
                    Console.WriteLine("Zadanie 20");
                    break;
                case 21:
                    Console.WriteLine("Zadanie 21");
                    break;
                case 22:
                    Console.WriteLine("Zadanie 22");
                    break;
                case 23:
                    Console.WriteLine("Zadanie 23");
                    break;
                case 24:
                    Console.WriteLine("Zadanie 24");
                    break;
                case 25:
                    Console.WriteLine("Zadanie 25");
                    break;
                case 26:
                    Console.WriteLine("Zadanie 26");
                    break;
                case 27:
                    Console.WriteLine("Zadanie 27");
                    break;
                case 28:
                    Console.WriteLine("Zadanie 28");
                    break;
                case 29:
                    Console.WriteLine("Zadanie 29");
                    break;
                case 30:
                    Console.WriteLine("Zadanie 30");
                    break;
                case 31:
                    Console.WriteLine("Zadanie 31");
                    break;
                case 32:
                    Console.WriteLine("Zadanie 32");
                    break;
                case 33:
                    Console.WriteLine("Zadanie 33");
                    break;
                case 34:
                    Console.WriteLine("Zadanie 34");
                    break;
                case 35:
                    Console.WriteLine("Zadanie 35");
                    break;
                case 36:
                    Console.WriteLine("Zadanie 36");
                    break;
                case 37:
                    Console.WriteLine("Zadanie 37");
                    break;
                case 38:
                    Console.WriteLine("Zadanie 38");
                    break;
                case 39:
                    Console.WriteLine("Zadanie 39");
                    break;
                case 40:
                    Console.WriteLine("Zadanie 40");
                    break;
                case 41:
                    Console.WriteLine("Zadanie 41");
                    break;
                case 42:
                    Console.WriteLine("Zadanie 42");
                    break;
                case 43:
                    Console.WriteLine("Zadanie 43");
                    break;
                case 44:
                    Console.WriteLine("Zadanie 44");
                    break;
                case 45:
                    Console.WriteLine("Zadanie 45");
                    break;
                case 46:
                    Console.WriteLine("Zadanie 46");
                    break;
                case 47:
                    Console.WriteLine("Zadanie 47");
                    break;
                case 48:
                    Console.WriteLine("Zadanie 48");
                    break;
                case 49:
                    Console.WriteLine("Zadanie 49");
                    break;
                case 50:
                    Console.WriteLine("Zadanie 50");
                    break;
                default:
                    Console.WriteLine("Default case");
                    break;

            }
        }

    }
}
