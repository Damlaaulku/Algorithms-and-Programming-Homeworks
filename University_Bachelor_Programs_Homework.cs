using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University_Bachelor_Programs_Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            int true_answers = 0;
            int wrong_answers = 0;
            int score;
            char[] key = new char[] { 'A', 'D', 'B', 'C', 'D', 'C', 'D', 'A', 'B', 'C', 'A', 'B', 'A', 'A', 'B', 'A', 'C', 'A', 'D', 'D' };
            char[,] answers = new char[,] {{'A', 'D', 'B', 'B', ' ', 'C', 'A', 'A', 'B', ' ', 'A', 'B', 'A', 'A', 'A', 'A', 'C', 'A', 'C', 'D' },
                                {'A', 'B', 'B', 'A', 'D', ' ', ' ', 'A', ' ', 'C', 'D', 'B', ' ', 'A', 'B', 'A', 'C', 'B', ' ', 'D' },
                                {'A', 'D', 'A', 'B', 'D', 'C', 'A', 'A', 'B', 'C', 'A', 'B', 'A', 'B', ' ', 'C', 'C', 'A', ' ', 'D' },
                                {'A', ' ', 'B', 'C', 'D', 'C', 'D', 'A', 'B', 'C', 'A', 'B', 'A', ' ', 'B', 'A', 'C', 'A', 'D', 'D' },
                                { 'A', 'D', 'B', 'C', 'D', 'C', 'D', 'A', 'B', 'C', 'A', 'B', 'A', 'A', 'B', 'A', 'C', 'A', 'D', 'D' },
                                { ' ', 'D', 'B', 'D', 'D', 'C', 'D', 'A', 'A', 'C', 'A', 'B', 'A', 'A', 'B', 'B', 'C', 'A', 'D', 'D' },
                                { 'A', 'D', 'B', 'C', 'D', 'C', 'D', 'A', 'B', 'C', 'A', 'B', 'A', 'A', 'B', ' ', ' ', ' ', ' ', ' ' },
                                { 'C', 'D', ' ', 'C', 'A', 'C', 'D', 'A', 'D', 'C', 'A', 'B', 'A', 'B', 'B', 'A', 'C', ' ', 'D', 'D' },
                                { 'A', 'D', 'D', 'B', 'D', 'C', 'D', 'A', 'B', 'C', 'A', 'B', 'A', 'A', ' ', 'A', 'C', 'A', 'D', 'D' },
                                { 'A', 'A', 'B', 'C', 'D', ' ', 'A', 'C', 'B', 'C', 'D', 'C', 'A', 'A', 'B', ' ', ' ', ' ', 'D', ' ' },
                                { 'A', 'D', 'A', 'A', ' ', 'C', 'D', 'A', 'B', 'C', 'A', 'B', 'A', 'A', 'B', ' ', 'C', 'A', 'D', 'A' },
                                { 'A', 'D', 'B', 'C', 'D', 'C', 'D', ' ', 'B', 'C', 'A', 'B', ' ', 'A', 'B', 'A', 'C', 'A', 'D', 'D' },
                                { 'A', 'D', 'B', 'C', 'D', 'C', 'C', 'A', 'B', 'C', 'A', 'B', 'A', 'A', 'B', 'A', 'C', 'A', 'D', 'D' },
                                { 'A', 'D', 'B', ' ', ' ', 'C', 'D', 'A', 'B', 'C', 'A', 'B', 'A', 'A', 'B', 'A', 'C', 'A', ' ', 'D' },
                                { 'A', 'D', 'A', 'C', 'D', ' ', ' ', 'A', 'B', ' ', 'A', 'B', 'A', ' ', 'D', 'A', 'C', 'A', 'A', 'D' },
                                };

            int[] results = new int[answers.GetLength(0)];
            string[,] candidates = {{"4848", "Elif Kızılkaya","4","6","1"},
                                     {"7207", "Okan Taşkın","1","4","7"},
                                     {"7861", "Nilüfer Derelioğlu","3","2","5"},
                                     {"8768", "Arzum Tükel","1","3","5"},
                                     {"8069", "Kübra Ekiz","1","",""},
                                     {"2515", "Nihan Çetin","3","4","2"},
                                     {"2335", "Zelal Akkaya","1","2","5"},
                                     {"9171", "Dila Çağlar","2","3","5"},
                                     {"5495", "Eylül Eren","7","",""},
                                     {"2677", "Mert Dülger","3","6","7"},
                                     {"4626", "Belen Dinçoğlu","1","4","6"},
                                     {"7149", "Utku Tanyeri","2","5",""},
                                     {"0799", "Karya Ön","1","2","3"},
                                     {"7085", "Tahsin Ataöz","6","1",""},
                                     {"1906", "İrem Suakar","5","4","6"},};

            int[,] scoretable = new int[candidates.GetLength(0), 2]; //score, student number

            for (int i = 0; i < answers.GetLength(0); i++) //score hesplayıp, numaralarla birlikte sıralı olarak scoretable arrayinin içine atıyor
            {
                for (int j = 0; j < answers.GetLength(1); j++)
                {

                    if (answers[i, j] == key[j])
                    {
                        true_answers++;
                    }
                    else if (answers[i, j] != key[j] && answers[i, j] != ' ')
                    {
                        wrong_answers++;
                    }
                }
                score = (5 * true_answers) - (2 * wrong_answers);
                scoretable[i, 0] = score;
                results[i] = score;
                true_answers = 0;
                wrong_answers = 0;

                scoretable[i, 1] = Int32.Parse(candidates[i, 0]);
            }

            int temp;    
            int tempn;

            for (int i = scoretable.GetLength(0) - 1; i >= 0; i--)//Bubble Sort Algoritması 
            {
                for (int j = 1; j <= scoretable.GetLength(0) - 1; j++)
                {
                    if (scoretable[j - 1, 0] < scoretable[j, 0])
                    {
                        temp = scoretable[j - 1, 0];
                        scoretable[j - 1, 0] = scoretable[j, 0];
                        scoretable[j, 0] = temp;
                        tempn = scoretable[j - 1, 1];
                        scoretable[j - 1, 1] = scoretable[j, 1];
                        scoretable[j, 1] = tempn;
                    }
                }
            }
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Number   Name-Surname                  Score"); //kişilerle birlikte aldıkları puanları yazan tablo
            Console.ForegroundColor = ConsoleColor.White;
            for (int i = 0; i < candidates.GetLength(0); i++)
            {
                Console.Write(candidates[i, 0] + "     ");
                Console.Write(candidates[i, 1]);
                Console.SetCursorPosition(40, i + 1);
                if (results[i] < 50)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write(results[i]);
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write(results[i]);
                }
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine();
            }

            string[,] departments = {{"1","Medicine"},
                                     {"2","Dentistry"},
                                     {"3","Computer Engineering"},
                                     {"4","Electric Electronics Engineering"},
                                     {"5","Machine Engineering"},
                                     {"6","Indastrial Engineering"},
                                     {"7","Nursing"}};

            string[,] contenjan = new string[departments.GetLength(0), 5]; //depatman numarası, students

            for (int i = 0; i < departments.GetLength(0); i++)
            {
                contenjan[i, 0] = departments[i, 0];
            }



            for (int i = 0; i < candidates.GetLength(0); i++) //scorelara göre tercihlere bakıp yerleştirme yapıyor
            {
                for (int k = 0; k < scoretable.GetLength(0); k++)
                {
                    if (scoretable[k, 0] > 50)
                    {
                        if (Int32.Parse(candidates[k, 0]) == scoretable[i, 1])
                        {
                            for (int j = 0; j < departments.GetLength(0); j++)
                            {
                                if (candidates[k, 2] == departments[j, 0])
                                {
                                    if (contenjan[j, 1] == null)
                                        contenjan[j, 1] = scoretable[i, 1].ToString();
                                    else if (contenjan[j, 2] == null)
                                        contenjan[j, 2] = scoretable[i, 1].ToString();
                                    else if (contenjan[j, 3] == null)
                                        contenjan[j, 3] = scoretable[i, 1].ToString();
                                    else
                                    {
                                        for (int l = 0; l < departments.GetLength(0); l++)
                                        {
                                            if (candidates[k, 2] == departments[l, 0])
                                            {
                                                if (contenjan[l, 1] == null)
                                                    contenjan[l, 1] = scoretable[i, 1].ToString();
                                                else if (contenjan[l, 2] == null)
                                                    contenjan[l, 2] = scoretable[i, 1].ToString();
                                                else if (contenjan[l, 3] == null)
                                                    contenjan[l, 3] = scoretable[i, 1].ToString();
                                                else
                                                {
                                                    for (int m = 0; m < departments.GetLength(0); m++)
                                                    {
                                                        if (candidates[k, 2] == departments[m, 0])
                                                        {
                                                            if (contenjan[m, 1] == null)
                                                                contenjan[m, 1] = scoretable[i, 1].ToString();
                                                            else if (contenjan[m, 2] == null)
                                                                contenjan[m, 2] = scoretable[i, 1].ToString();
                                                            else if (contenjan[m, 3] == null)
                                                                contenjan[m, 3] = scoretable[i, 1].ToString();
                                                        }
                                                    }
                                                }
                                            }

                                        }
                                    }

                                }
                            }
                        }
                    }
                }
            }


            Console.WriteLine();
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("No Departments         Students Numbers");//departmanları ve numaraları yazan tablo
            Console.ForegroundColor = ConsoleColor.White;
            for (int i = 0; i < departments.GetLength(0); i++)
            {
                Console.Write(departments[i, 0] + "  " + departments[i, 1] + " ----- " + contenjan[i, 1] + "  " + contenjan[i, 2] + "  " + contenjan[i, 3] + "  " + contenjan[i, 4]);
                Console.WriteLine();
            }
            Console.ReadLine();

        }
    }
    }

