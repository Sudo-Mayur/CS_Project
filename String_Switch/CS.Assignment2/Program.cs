using System;

namespace CS.Assignment2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string content = "James Bond is a fictional character created by novelist Ian Fleming in 1953. A British secret agent working for MI6 under the codename 007, he has been portrayed on film by actors Sean Connery, David Niven, George Lazenby, Roger Moore, Timothy Dalton, Pierce Brosnan and Daniel Craig in twenty-seven productions. All but two films were made by Eon Productions, which now holds the adaptation rights to all of Fleming\'s Bond novels.[1][2]\nIn 1961, producers Albert R.Broccoli and Harry Saltzman purchased the filming rights to Fleming\'s novels.[3] They founded Eon Productions and, with financial backing by United Artists, produced Dr. No, directed by Terence Young and featuring Connery as Bond.[4] Following its release in 1962, Broccoli and Saltzman created the holding company Danjaq to ensure future productions in the James Bond film series.[5] The series currently has twenty-five films, with the most recent, No Time to Die, released in September 2021. With a combined gross of nearly $7 billion to date, it is the fifth-highest-grossing film series.[6] Accounting for inflation, it has earned over $14 billion at current prices.[a] The films have won five Academy Awards: for Sound Effects (now Sound Editing) in Goldfinger (at the 37th Awards), to John Stears for Visual Effects in Thunderball (at the 38th Awards), to Per Hallberg and Karen Baker Landers for Sound Editing, to Adele and Paul Epworth for Original Song in Skyfall (at the 85th Awards) and to Sam Smith and Jimmy Napes for Original Song in Spectre (at the 88th Awards). Several of the songs produced for the films have been nominated for Academy Awards for Original Song, including Paul McCartney's \"Live and Let Die\", Carly Simon\'s \"Nobody Does It Better\" and Sheena Easton\'s \"For Your Eyes Only\".In 1982 Albert R. Broccoli received the Irving G.Thalberg Memorial Award.[8]";
            Console.WriteLine("Enter the operation which you want to perform\n" +
                "1.Find out number of 'Blank Spaces' in the string\n" +
                "2.Find out number of 'Words'\n" +
                "3.Find out number of '.'\n" +
                "4.Find out number of statements\n" +
                "5.Find out number of digits\n" +
                "6.Find out number of vowels (a,e,i,o,u)\n" +
                "7.Find out number of 'the', 'is', 'to', 'and' and their positions (indexes)\n");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    BlankSpaces(content);
                    break;
                case 2:
                    CountWords(content);
                    break;
                case 3:
                    NumberOfStatement(content);
                    break;
                case 4:
                    NumberOfStatement(content);
                    break;
                case 5:
                    NumberOfDigit(content);
                    break;
                case 6:
                    CountVowel(content);
                    break;
                //case 7:
                //    PrepositionAndPosition(content);
                //    break;
                default:
                    Console.WriteLine("Invalid Choice");
                    break;
            }
        }
        static void BlankSpaces(string content)
        {
            int count = 0;
            foreach (char c in content)
            {
                if (c == ' ')
                {
                    count++;
                }
            }
            Console.WriteLine(count);
        }
        static void CountWords(string content)
        {
            int word = 0;
            foreach (char c in content)
            {
                if (c == ' ' || c == ',' || c == '.')
                {
                    word++;
                }
            }
            Console.WriteLine(word);
        }
        static void NumberOfStatement(string content)
        {
            int statements = 0;
            foreach (char c in content)
            {
                if (c == '.')
                {
                    statements++;
                }
            }
            Console.WriteLine(statements);
        }
        static void NumberOfDigit(string content)
        {
            int digit = 0;
            foreach (char c in content)
            {
                if (char.IsDigit(c))
                {
                    digit++;
                }
            }
            Console.WriteLine(digit);
        }
        static void CountVowel(string content)
        {
            int countVowel = 0;
            foreach (char c in content)
            {
                if (c == 'a' || c == 'A' || c == 'e' || c == 'E' || c == 'i' || c == 'I' || c == 'o' || c == 'O' || c == 'u' || c == 'U')
                {
                    countVowel++;
                }
            }
            Console.WriteLine(countVowel);
        }
        //static void PrepositionAndPosition(string content)
        //{
        //    int countNumber = 0;
        //    foreach (string item in arr)
        //    {
        //        while (content.)
        //            if (content.Contains(item))
        //            {
        //                countNumber++;
        //                if (item == "the")
        //                {
        //                }
        //            }
        //    }
        //}
    }
}
    

