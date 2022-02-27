using System;
using System.Collections;
using System.Text.RegularExpressions;


namespace String_Switch
{
    internal class Program
    {
        public static void Main()
        {
            string str = "James Bond is a fictional character created by novelist Ian Fleming in 1953. A British secret agent working for MI6 under the codename 007, he has been portrayed on film by actors Sean Connery, David Niven, George Lazenby, Roger Moore, Timothy Dalton, Pierce Brosnan and Daniel Craig in twenty-seven productions. All but two films were made by Eon Productions, which now holds the adaptation rights to all of Fleming\'s Bond novels.[1][2]\nIn 1961, producers Albert R.Broccoli and Harry Saltzman purchased the filming rights to Fleming\'s novels.[3] They founded Eon Productions and, with financial backing by United Artists, produced Dr. No, directed by Terence Young and featuring Connery as Bond.[4] Following its release in 1962, Broccoli and Saltzman created the holding company Danjaq to ensure future productions in the James Bond film series.[5] The series currently has twenty-five films, with the most recent, No Time to Die, released in September 2021. With a combined gross of nearly $7 billion to date, it is the fifth-highest-grossing film series.[6] Accounting for inflation, it has earned over $14 billion at current prices.[a] The films have won five Academy Awards: for Sound Effects (now Sound Editing) in Goldfinger (at the 37th Awards), to John Stears for Visual Effects in Thunderball (at the 38th Awards), to Per Hallberg and Karen Baker Landers for Sound Editing, to Adele and Paul Epworth for Original Song in Skyfall (at the 85th Awards) and to Sam Smith and Jimmy Napes for Original Song in Spectre (at the 88th Awards). Several of the songs produced for the films have been nominated for Academy Awards for Original Song, including Paul McCartney's \"Live and Let Die\", Carly Simon\'s \"Nobody Does It Better\" and Sheena Easton\'s \"For Your Eyes Only\".In 1982 Albert R. Broccoli received the Irving G.Thalberg Memorial Award.[8]";
            Console.WriteLine("Enter the operation that you want to perform\n" +
           "1.Find out number of 'Blank Spaces' in the string\n" +
           "2.Find out number of 'Words'\n" +
           "3.Find out number of '.'\n" +
           "4.Find out number of statements\n" +
           "5.Find out number of digits\n" +
           "6.Find out number of vowels (a,e,i,o,u)\n" +
           "7.Find out number of 'the', 'is', 'to', 'and' and their positions (indexes)\n" +
           "8.Find out number and positions of comma (,)\n" +
           "9.Reverse each word in string\n" +
           "10.Reverse entire string\n" +
           "11.Print each statement in separate line on console from the above string\n" +
           "12.Print all words decorated uasing  e.g. Live and Let Die\n" +
           "13.Convert first character of each word in upper case.\n" +
           "14.List 'month names' from the above list e.g. January, February, etc.\n");

            int UserChoice = Convert.ToInt32(Console.ReadLine());
            switch (UserChoice)
            { 

                case 1:
                    int count = 0;
                    foreach (char c in str)
                    {
                        if (c == ' ')
                        {
                            count++;
                        }
                    }
                    Console.WriteLine(count);
                    break;
                case 2:
                    int words = 0;
                    foreach (char c in str)
                    {
                        if (c == ' ')
                        {
                            words++;
                        }
                    }
                    Console.WriteLine(words+1);
                    break;
                case 3:
                    int countFullstop = 0;
                    foreach (char c in str)
                    {
                        if (c == '.')
                        {
                            countFullstop++;
                        }
                    }
                    Console.WriteLine(countFullstop);
                    break;
                case 4:
                    int countstatements = 0;
                    foreach (char c in str)
                    {
                        if (c == '.')
                        {
                            countstatements++;
                        }
                    }
                    Console.WriteLine(countstatements);
                    break;
                case 5:
                    int digit = 0;
                    foreach (char c in str)
                    {
                        if (char.IsDigit(c))
                        {
                            digit++;
                        }
                    }
                    Console.WriteLine(digit);
                    break;
                case 6:
                    int countVowel = 0;
                    foreach (char c in str)
                    {
                        if (c == 'a' || c == 'A' || c == 'e' || c == 'E' || c == 'i' || c == 'I' || c == 'o' || c == 'O' || c == 'u' || c == 'U')
                        {
                            countVowel++;
                        }
                    }
                    Console.WriteLine(countVowel);
                    break;

                    case 7:
                    int countNumber = 0;
                    string[] sample = { "the", "is", "to", "and" };
                    ArrayList index = new ArrayList();
                    foreach (string item in sample)
                    {
                        for (int i = str.IndexOf(item); i >= 0; i = str.IndexOf(item, i + 1))
                        {
                            countNumber++;
                            index.Add(i);
                        }
                        Console.WriteLine($"count of '{item}' in string is {countNumber} and the index position are as follows");
                        foreach (int element in index)
                        {
                            Console.WriteLine(element);
                        }
                        index.Clear();
                    }
                    break;


                case 8:
                    int count1 = 0;
                    for (int i = 0; i < str.Length; i++)
                    {
                        if (str[i] == ',')
                        {
                            Console.WriteLine(i);
                            count1++;
                        }
                    }
                    Console.WriteLine($"Total number of comma\'s are {count1}");
                    break;

                case 9:
                    string strrev = "";

                    foreach (var item in str.Split(' '))
                    {
                        string temp = "";
                        foreach (var ch in item.ToCharArray())
                        {
                            temp = ch + temp;
                        }
                        strrev = strrev + temp + "";
                    }
                    Console.WriteLine(strrev);
                    break;


                case 10:
                    string reverseString = "";
                    for(int i=str.Length-1; i>=0; i--)
                    {
                        reverseString= reverseString + str[i];
                    }
                    Console.WriteLine(reverseString);
                    break;

                case 11:
                    string[] myString = str.Split(".");
                    foreach (string item in myString)
                    {
                        Console.WriteLine(item);
                        Console.WriteLine("\n");
                    }
                    break;

                case 12:
                    var reg = new Regex("\".*?\"");
                    var matches = reg.Matches(str);
                    foreach (var item in matches)
                    {
                        Console.WriteLine(item.ToString());
                    }
                    break;

              

                case 13:
                    string[] word = str.Split(' ');
                    foreach (string item in word)
                    {
                        Console.Write(char.ToUpper(item[0]) + item.Substring(1) + " ");
                    }
                    break;
            

                case 14:
                    string[] months = { "january", "february", "march", "april", "may", "june", "july", "august", "september", "october", "november", "december" };
                    foreach (string item in months)
                    {
                        if (str.Contains(item))
                        {
                            Console.WriteLine(item);
                        }
                    }
                    break;


                default:
                    Console.WriteLine("Invalid Choice");
                    break;
            }
        }
    }
}
    

