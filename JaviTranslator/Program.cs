using System;

namespace JaviTranslator
{
    class Program
    {
        static void Main(string[] args)
        {
            char desc = 'a';
           
            while (char.ToUpper(desc) != 'X')
            {
                string translatedText = "";
                Console.WriteLine("Welcome to the Javi translator");
                Console.WriteLine("Use 1 to translate from Javi to human");
                Console.WriteLine("Use 2 to translate from Human to Javi");
                Console.WriteLine("Use X to Exit");
                desc = char.Parse(Console.ReadLine());
                switch (char.ToUpper(desc))
                {
                    case '1':
                        Console.WriteLine("Insert the Javi Text please");
                        string javiText = Console.ReadLine();
                       
                        for (int i = javiText.Length-1; i > 0; i--)
                        {
                            translatedText += javiText[i];
                        }

                        Console.WriteLine(translatedText);
                        break;
                    
                    case '2':
                        Console.WriteLine("Insert the Human Text please");
                        string humanText = Console.ReadLine();
                       
                        for (int i = humanText.Length-1; i > -1; i--)
                        {
                            translatedText += humanText[i];
                        }

                        Console.WriteLine(translatedText);
                        break;
                    case 'X':
                        
                        break;
                }
                
            }
        }
    }
}