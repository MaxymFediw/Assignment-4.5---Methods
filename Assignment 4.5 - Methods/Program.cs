using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Assignment_4._5___Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int drawing;
            string answer;

            Console.WriteLine("Choose Who You Want To Draw:");
            Console.WriteLine("1 = Penguin");
            Console.WriteLine("2 = SpongeBob");
            Console.WriteLine("3 = Eric Cartman");
            
            Console.WriteLine();

            if (Int32.TryParse(Console.ReadLine(), out drawing))
            {
                if (drawing == 1)
                {
                    DrawPenguin();
                }

                else if (drawing == 2)
                {
                    DrawSpongeBob();
                }

                else if (drawing == 3)
                {
                    DrawCartman();
                }
            }

            Console.WriteLine();

            if (drawing !=1 &&  drawing !=2 && drawing !=3)
            {
                Console.WriteLine("Since You Want To Be Diferent, Here's ALL Of The Drawings.");

                DrawPenguin();
                DrawSpongeBob();
                DrawCartman();
            }

            Console.WriteLine("Wanna hear a Knock Knock Joke?");
            answer = Console.ReadLine();

            if (answer.ToLower().Trim() == "yes")
            {
                Console.WriteLine("Great!");
                KnockKnockJoke();
            }

            else 
            {
                Console.WriteLine("Too Bad!");
                KnockKnockJoke();
            }
                

                Console.WriteLine();
            Console.WriteLine("Ahahahahahahahaha! *Ba-Dum CRASH!*");




        }

        public static void DrawCartman() 
        {

            Console.WriteLine("                       _.-**-._\r\n                    _,(        ),_\r\n                 .-\"   '-^----'   \"-.\r\n              .-'                    '-.\r\n            .'                          '.\r\n          .'    __.--**'\"\"\"\"\"\"'**--.__    '.\r\n         /_.-*\"'__.--**'\"\"\"\"\"\"'**--.__'\"*-._\\\r\n        /_..-*\"'   .-*\"*-.  .-*\"*-.   '\"*-.._\\\r\n       :          /       ;:       \\          ;\r\n       :         :     *  !!  *     :         ;\r\n        \\        '.     .'  '.     .'        /\r\n         \\         '-.-'      '-.-'         /\r\n      .-*''.                              .'-.\r\n   .-'      '.                          .'    '.\r\n  :           '-.        _.._        .-'        '._\r\n ;\"*-._          '-._  --___ `   _.-'        _.*'  '*.\r\n:      '.            `\"*-.__.-*\"`           (        :\r\n ;      ;                 *|                 '-.     ;\r\n  '---*'                   |                    \"\"--'\r\n   :                      *|                      :\r\n   '.                      |                     .'\r\n     '.._                 *|        ____----.._-'\r\n      \\  \"\"\"----_____------'-----\"\"\"         /\r\n       \\  __..-------.._        ___..---._  /\r\n       :'\"              '-..--''          \"';\r\n        '\"\"\"\"\"\"\"\"\"\"\"\"\"\"\"\"' '\"\"\"\"\"\"\"\"\"\"\"\"\"\"\"'\r\n              C A R T M A N by Matzec\r\n"); 

        }

        public static void DrawPenguin() 
        {
            Console.WriteLine(" __\r\n( o>\r\n///\\\r\n\\V_/_");
        }

        public static void DrawSpongeBob() 
        {
            Console.WriteLine("      .--..--..--..--..--..--.\r\n    .' \\  (`._   (_)     _   \\\r\n  .'    |  '._)         (_)  |\r\n  \\ _.')\\      .----..---.   /\r\n  |(_.'  |    /    .-\\-.  \\  |\r\n  \\     0|    |   ( O| O) | o|\r\n   |  _  |  .--.____.'._.-.  |\r\n   \\ (_) | o         -` .-`  |\r\n    |    \\   |`-._ _ _ _ _\\ /\r\n    \\    |   |  `. |_||_|   |\r\n    | o  |    \\_      \\     |     -.   .-.\r\n    |.-.  \\     `--..-'   O |     `.`-' .'\r\n  _.'  .' |     `-.-'      /-.__   ' .-'\r\n.' `-.` '.|='=.='=.='=.='=|._/_ `-'.'\r\n`-._  `.  |________/\\_____|    `-.'\r\n   .'   ).| '=' '='\\/ '=' |\r\n   `._.`  '---------------'\r\n           //___\\   //___\\\r\n             ||       ||\r\n    LGB      ||_.-.   ||_.-.\r\n            (_.--__) (_.--__)\r\n");
        }

        public static void KnockKnockJoke() 
        {
            Console.WriteLine("Knock Knock!");
            Console.WriteLine("You: Who's there?");
            Console.WriteLine("No One.");
            Console.WriteLine("No One Who?");
            Console.WriteLine("*Silence*");


        }



    }
}
