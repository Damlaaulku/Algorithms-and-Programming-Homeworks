using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calender_Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            int day1, day2, year1, year2;
            string month1, month2;

            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkCyan;

            Console.WriteLine("Please enter the first date: ");
            Console.Write("Day= ");
            day1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Month= ");
            month1 = Console.ReadLine();
            Console.Write("Year=  ");
            year1 = Convert.ToInt32(Console.ReadLine());
            month1 = month1.ToLower(); 

            if (day1 <= 31 && day1 >= 1)
            {
                while (year1<1)
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine();
                    Console.WriteLine("Year is wrong, please press enter to enter a new value!");
                    Console.ReadLine();
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("Please enter the first date: ");
                    Console.Write("Day= ");
                    day1 = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Month= ");
                    month1 = Console.ReadLine();
                    Console.Write("Year=  ");
                    year1 = Convert.ToInt32(Console.ReadLine());
                    month1 = month1.ToLower();
                }
                while ((month1 == "february" && year1 % 4 != 0 && day1 > 28) ||
                      (month1 == "february" && year1 % 4 == 0 && day1 > 29) ||
                      (month1 == "april" && day1 > 30) ||
                      (month1 == "june" && day1 > 30) ||
                      (month1 == "september" && day1 > 30) ||
                      (month1 == "december" && day1 > 30))
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine();
                    Console.WriteLine("Day is wrong, please press enter to enter a new value!");
                    Console.ReadLine();
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("Please enter the first date: ");
                    Console.Write("Day= ");
                    day1 = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Month= ");
                    month1 = Console.ReadLine();
                    Console.Write("Year=  ");
                    year1 = Convert.ToInt32(Console.ReadLine());
                    month1 = month1.ToLower();
                }
                while (month1 != "january" && month1 != "february" && month1 != "march" && month1 != "april" && month1 != "may" && month1 != "june" && month1 != "july" && month1 != "august" && month1 != "september" && month1 != "october" && month1 != "november" && month1 != "december")
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine();
                    Console.WriteLine("Month is wrong, please press enter to enter a new value!");
                    Console.ReadLine();
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("Please enter the first date: ");
                    Console.Write("Day= ");
                    day1 = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Month= ");
                    month1 = Console.ReadLine();
                    Console.Write("Year=  ");
                    year1 = Convert.ToInt32(Console.ReadLine());
                    month1 = month1.ToLower();
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine();
                Console.WriteLine("Day is wrong, please press enter to enter a new value!");
                Console.ReadLine();
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Please enter the first date: ");
                Console.Write("Day= ");
                day1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Month= ");
                month1 = Console.ReadLine();
                Console.Write("Year=  ");
                year1 = Convert.ToInt32(Console.ReadLine());
                month1 = month1.ToLower();
            }


            Console.WriteLine();
            Console.WriteLine("Please enter the second date:");
            Console.Write("Day= ");
            day2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Month= ");
            month2 = Console.ReadLine();
            Console.Write("Year=  ");
            year2 = Convert.ToInt32(Console.ReadLine());
            month1 = month1.ToLower();

            if (day2 <= 31 && day2 >= 1)
            {
                while (year2 < 1)
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine();
                    Console.WriteLine("Year is wrong, please press enter to enter a new value!");
                    Console.ReadLine();
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("Please enter the first date: ");
                    Console.Write("Day= ");
                    day1 = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Month= ");
                    month1 = Console.ReadLine();
                    Console.Write("Year=  ");
                    year1 = Convert.ToInt32(Console.ReadLine());
                    month1 = month1.ToLower();
                }
                while ((month2 == "february" && year2 % 4 != 0 && day2 > 28) ||
                      (month2 == "february" && year2 % 4 == 0 && day2 > 29) || 
                      (month2 == "april" && day2 > 30) ||
                      (month2 == "june" && day2 > 30) ||
                      (month2 == "september" && day2 > 30) || 
                      (month2 == "november" && day2 > 30))
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine();
                    Console.WriteLine("Day is wrong, please press enter to enter a new value!");
                    Console.ReadLine();
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("Please enter the first date: ");
                    Console.WriteLine("Day= " + day1);
                    Console.WriteLine("Month= " + month1);
                    Console.WriteLine("Year=  " + year1);
                    Console.WriteLine();
                    Console.WriteLine("Please enter the second date");
                    Console.Write("Day= ");
                    day2 = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Month= ");
                    month2 = Console.ReadLine();
                    Console.Write("Year=  ");
                    year2 = Convert.ToInt32(Console.ReadLine());
                    month1 = month1.ToLower();
                }

                while (month2 != "january" && month2 != "february" && month2 != "march" && month2 != "april" && month2 != "may" && month2 != "june" && month2 != "july" && month2 != "august" && month2 != "september" && month2 != "october" && month2 != "november" && month2 != "december")
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine();
                    Console.WriteLine("Month is wrong, please press enter to enter a new value!");
                    Console.ReadLine();
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("Please enter the first date: ");
                    Console.WriteLine("Day= " + day1);
                    Console.WriteLine("Month= " + month1);
                    Console.WriteLine("Year=  " + year1);
                    Console.WriteLine();
                    Console.WriteLine("Please enter the second date:");
                    Console.Write("Day= ");
                    day2 = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Month= ");
                    month2 = Console.ReadLine();
                    Console.Write("Year=  ");
                    year2 = Convert.ToInt32(Console.ReadLine());
                    month1 = month1.ToLower();
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine();
                Console.WriteLine("Day is wrong, please press enter to enter a new value!");
                Console.ReadLine();
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Please enter the first date: ");
                Console.WriteLine("Day= " + day1);
                Console.WriteLine("Month= " + month1);
                Console.WriteLine("Year=  " + year1);
                Console.WriteLine();
                Console.WriteLine("Please enter the second date:");
                Console.Write("Day= ");
                day2 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Month= ");
                month2 = Console.ReadLine();
                Console.Write("Year=  ");
                year2 = Convert.ToInt32(Console.ReadLine());
                month1 = month1.ToLower();
            }

            int aykontrol1;

            if (month1 == "january") 

                aykontrol1 = 1;

            else if (month1 == "february")

                aykontrol1 = 2;

            else if (month1 == "march")

                aykontrol1 = 3;

            else if (month1 == "april")

                aykontrol1 = 4;

            else if (month1 == "may")

                aykontrol1 = 5;

            else if (month1 == "june")

                aykontrol1 = 6;

            else if (month1 == "july")

                aykontrol1 = 7;

            else if (month1 == "august")

                aykontrol1 = 8;

            else if (month1 == "september")

                aykontrol1 = 9;

            else if (month1 == "october")

                aykontrol1 = 10;

            else if (month1 == "november")

                aykontrol1 = 11;

            else

                aykontrol1 = 12;

            int aykontrol2;

            if (month2 == "january")

                aykontrol2 = 1;

            else if (month2 == "february")
                
                aykontrol2 = 2;

            else if (month2 == "march")

                aykontrol2 = 3;

            else if (month2 == "april")

                aykontrol2 = 4;

            else if (month2 == "may")

                aykontrol2 = 5;

            else if (month2 == "june")

                aykontrol2 = 6;

            else if (month2 == "july")

                aykontrol2 = 7;

            else if (month2 == "august")

                aykontrol2 = 8;

            else if (month2 == "september")

                aykontrol2 = 9;

            else if (month2 == "october")

                aykontrol2 = 10;

            else if (month2 == "november")

                aykontrol2 = 11;

            else

                aykontrol2 = 12;

            
            
            if  ((day1>day2 && aykontrol1<=aykontrol2 && year2>=year1) || 
                (day1== day2 && aykontrol2>aykontrol1 && year1<=year2) || 
                (day2>day1 && aykontrol1<=aykontrol2 && year1<=year2) ||
                (day1 > day2 && aykontrol1>aykontrol2 && year2 >= year1) ||
                (day1 == day2 && aykontrol2 <= aykontrol1 && year1 <= year2) ||
                (day2 > day1 && aykontrol1 > aykontrol2 && year1 <= year2)) 
            {
                int month = aykontrol1;
                string monthname = " ";
                string season = " ";
                int monthend = 12;
                int monthday = day1;
                int monthdayend = 0;

                for (int i = year1; i <= year2; i++)
                {
                    if (i == year2)
                        monthend = aykontrol2;
                    else
                        monthend = 12;

                    for (int x = month; x <= monthend; x++)
                    {
                        if (x == 1)
                        {
                            season = "winter";
                            monthname = "january";
                            monthdayend = 31;
                        }
                        else if (x == 2)
                        {
                            season = "winter";
                            monthname = "february";
                            if (i%4==0)
                            {
                                monthdayend = 29;
                            }
                            else
                            {
                                monthdayend = 28;
                            }
                        }
                        else if (x == 3)
                        {
                            season = "spring";
                            monthname = "march";
                            monthdayend = 31;
                        }
                        else if (x == 4)
                        {
                            season = "spring";
                            monthname = "april";
                            monthdayend = 30;
                        }
                        else if (x == 5)
                        {
                            season = "spring";
                            monthname = "may";
                            monthdayend = 31;
                        }
                        else if (x == 6)
                        {
                            season = "summer";
                            monthname = "june";
                            monthdayend = 30;
                        }
                        else if (x == 7)
                        {
                            season = "summer";
                            monthname = "july";
                            monthdayend = 31;
                        }
                        else if (x == 8)
                        {
                            season = "summer";
                            monthname = "august";
                            monthdayend = 31;
                        }
                        else if (x == 9)
                        {
                            season = "autumn";
                            monthname = "september";
                            monthdayend = 30;
                        }
                        else if (x == 10)
                        {
                            season = "autumn";
                            monthname = "october";
                            monthdayend = 31;
                        }
                        else if (x == 11)
                        {
                            season = "autumn";
                            monthname = "november";
                            monthdayend = 30;
                        }
                        else
                        {
                            season = "winter";
                            monthname = "december";
                            monthdayend = 31;
                        }
                        if (i == year2 && x == aykontrol2)
                        {
                            monthdayend = day2;
                        }
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.DarkMagenta;
                        Console.WriteLine(monthname.ToUpper() + " " + i + " " + season.ToUpper());
                        Console.WriteLine("---------------------");
                        Console.WriteLine("Mo Tu We Th Fr Sa Su");
                        Console.WriteLine("---------------------");
                        int xHold  = 0;

                        bool flag = true;
                        for (int y = monthday; y <= monthdayend; y++)
                        {
                            if (x == 1)
                            {
                                xHold = 13;
                                i--;
                            }
                            else if (x == 2)
                            {
                                xHold = 14;
                                i--;
                            }
                            else
                            {
                                xHold = x;
                            }

                            int q = y;
                            int m = xHold;
                            int k = i % 100;
                            int j = i / 100;
                            int h = q + 13 * (m + 1) / 5 + k + k / 4 + j / 4 + 5 * j;
                            h = h % 7;

                            if (x == 1)
                            {
                                i++;
                            }
                            else if (x == 2)
                            {
                                i++;
                            }
                            if (flag)
                            {
                                if (h == 2)
                                    Console.Write("");
                                else if (h == 3)
                                    Console.Write("   ");
                                else if (h == 4)
                                    Console.Write("      ");
                                else if (h == 5)
                                    Console.Write("         ");
                                else if (h == 6)
                                    Console.Write("            ");
                                else if (h == 0)
                                    Console.Write("               ");
                                else
                                    Console.Write("                  ");
                            }
                            if (y < 10)
                            {
                                Console.Write(" " + y + " ");
                            }
                            else
                            {
                                Console.Write(y + " ");
                            }
                            
                            if (h == 1)
                            {
                                Console.WriteLine();
                            }
                            flag = false;
                        }
                        
                        monthday = 1;
                    }
                    month = 1;
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine();
                Console.WriteLine("The first date must be before the second date. Please try again!"); 
            }
            Console.ReadLine();
        }
    }
}
