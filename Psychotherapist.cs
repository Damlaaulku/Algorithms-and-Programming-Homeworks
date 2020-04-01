using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Psychotherapist
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] ignore_chars = { '.', ',', '’', ';', '"', '?', '!', '-', '{', '}', '(', ')', '[', ']' };

            string[] stop_words =     {"a", "after", "again","all", "am", "and", "any", "are", "as", "at", "be", "been", "before",
                                       "between", "both", "but", "by", "can", "could", "for", "from", "had", "has", "he", "her", "here", "him", "in", "into",
                                       "I", "ı", "is", "it", "me", "my", "of", "on", "our", "she", "so", "such", "than", "that", "the", "then", "they", "this", "to",
                                       "until", "we", "was", "were", "with", "you"};

            string[] negative_words = {"stress", "depression", "sad", "angry", "hate", "pain", "abnormal", "abort", "abuse",
                                       "brittle", "hurt", "scared", "afraid", "upset", "confused", "lonely", "tired", "vulnerable", "guilty", "anxiety",
                                       "disappointment", "regret", "awful", "sick", "regretful", "unhappy", "sorrowful", "troubled", "worried", "annoyed"};
            bool control = true;

            Console.WriteLine("Welcome! Tell me about you: ");

            while (control)
            {
                Console.WriteLine();
                string texttemp = "";
                bool punctiation = true;
                int index = 0;
                bool rules = true;
                string text = Console.ReadLine();
                text = text.ToLower(); //büyük küçük harf kontrolü

                if (text == "ı have to go now." || text == "i have to go now.")//bitiş
                {
                    control = false;
                    break;
                }

                for (int i = 0; i < text.Length - 1; i++)//birden fazla cümle kontrolü
                {
                    if (text[i] == '.' || text[i] == '?' || text[i] == '!')
                    {
                        index = i;
                        punctiation = false;
                    }
                }

                if (!punctiation)
                {
                    texttemp = text.Substring(index + 2);
                }
                else
                {
                    texttemp = text;
                }


                for (int i = 0; i < texttemp.Length; i++) //noktalama işaretlerini kaldırıyor
                {
                    for (int j = 0; j < ignore_chars.Length; j++)
                    {
                        if (texttemp[i] == ignore_chars[j])
                        {
                            texttemp = texttemp.Remove(i, 1);
                            break;
                        }
                    }
                }
                texttemp = texttemp.ToLower();

                string[] texttemp_array = texttemp.Split(' ');

                for (int i = 0; i < text.Length; i++) //noktalama işaretlerini kaldırıyor
                {
                    for (int j = 0; j < ignore_chars.Length; j++)
                    {
                        if (text[i] == ignore_chars[j])
                        {
                            text = text.Remove(i, 1);
                            break;
                        }
                    }
                }
                string[] text_array = text.Split(' ');

                if (rules)//rule 1
                {
                    int counter = 0, countertemp = 0;
                    string max = "";

                    for (int i = 0; i < text_array.Length; i++)
                    {
                        bool flag = true;
                        counter = 0;

                        for (int k = 0; k < stop_words.Length; k++)
                        {
                            if (text_array[i] == stop_words[k])
                            {
                                flag = false;
                                break;
                            }
                        }
                        if (flag)
                        {
                            for (int j = 1; j < text_array.Length; j++)
                            {
                                if (text_array[i] == text_array[j])
                                {
                                    counter++;
                                    if (counter > countertemp)
                                    {
                                        countertemp = counter;
                                        max = text_array[i];
                                    }
                                }
                            }
                        }
                    }
                    if (countertemp > 2)
                    {
                        Console.WriteLine("Do you love " + max + "?");
                        rules = false;
                    }
                }

                if (rules)//rule 2
                {
                    int question;

                    for (int i = 0; i < text_array.Length; i++)
                    {
                        if (text_array[i] == "why" || text_array[i] == "who" || text_array[i] == "when" || text_array[i] == "where" || text_array[i] == "what" || text_array[i] == "how")
                        {
                            Random rnd = new Random();
                            question = rnd.Next(1, 3);
                            if (question == 1)
                            {
                                Console.WriteLine("Do you often think about this question?");
                                rules = false;
                            }
                            else
                            {
                                Console.WriteLine("Why do you want to know?");
                                rules = false;
                            }
                        }
                    }
                }

                if (rules)//rule 3
                {
                    for (int i = 0; i < text_array.Length; i++)
                    {
                        for (int j = 0; j < negative_words.Length; j++)
                        {
                            if (text_array[i] == negative_words[j])
                            {
                                Console.WriteLine("Beeing " + negative_words[j] + " is bad for your health. How long do you feel " + negative_words[j] + "?" + " Why do you feel " + negative_words[j] + "?");
                                rules = false;
                            }
                        }
                    }
                }

                if (rules)//rule 4
                {
                    int response;

                    for (int i = 0; i < texttemp_array.Length; i++)
                    {
                        if (texttemp_array[i] == "yes")
                        {
                            texttemp = texttemp.Substring(3);
                        }
                        if (texttemp_array[i] == "i" || texttemp_array[i] == "ı")
                        {
                            texttemp_array[i] = texttemp_array[i].Replace("i", "you");
                            texttemp_array[i] = texttemp_array[i].Replace("ı", "you");
                        }
                        else if (texttemp_array[i] == "my")
                        {
                            texttemp_array[i] = texttemp_array[i].Replace("my", "your");
                        }
                        else if (texttemp_array[i] == "myself")
                        {
                            texttemp_array[i] = texttemp_array[i].Replace("myself", "yourself");
                        }
                        else if (texttemp_array[i] == "am")
                        {
                            texttemp_array[i] = texttemp_array[i].Replace("am", "are");
                        }
                        else if (texttemp_array[i] == "me")
                        {
                            texttemp_array[i] = texttemp_array[i].Replace("me", "you");
                        }
                    }

                    texttemp = null;

                    for (int i = 0; i < texttemp_array.Length; i++)
                    {
                        texttemp += texttemp_array[i] + " ";
                    }

                    texttemp = texttemp.Trim();

                    Random rndm = new Random();
                    response = rndm.Next(1, 3);

                    if (response == 1)
                    {
                        texttemp = texttemp.Substring(0, 1).ToUpper() + texttemp.Substring(1);
                        Console.Write(texttemp + ",right?");
                        rules = false;
                    }
                    else
                    {
                        Console.Write("You say, " + texttemp + "?");
                        rules = false;
                    }
                }
            }

            Console.ReadLine();
        }
    }
}
