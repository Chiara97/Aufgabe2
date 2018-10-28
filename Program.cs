using System;

namespace test
{
    class Program
    {
        //Typ Inferenz
        static void Main(string[] args)
        {           
            var i = 42;
            var pi = 3.1415;
            var salute = "Hello, World";

            Console.WriteLine(i);
            Console.WriteLine(pi);
            Console.WriteLine(salute);

            //Double
            var ia = 48.0;  
            System.Type iatype = ia.GetType();
            Console.WriteLine(iatype);

            //float
            var ib = 48.0;  
            var ic = (float) ib;
            System.Type ibtype = ic.GetType();
            Console.WriteLine(ibtype);

            //short
            var id = 48.0;  
            var ie = (short) id;
            System.Type idtype = ie.GetType();
            Console.WriteLine(idtype);

            //andere Methoden aufrufen
            //array();
            //strings();
            //Verzweigung();
            //switchcase();
            //whileschleife();
            //forschleife();
            //whilebreak();
            whilebreak1();
        }

        //Array
        static void array()
        {
            int[] ia = {1, 0, 2, 9, 3, 8, 4, 7, 5};
            int ergebnis = ia[2] * ia[8] + ia[4];
            Console.WriteLine(ergebnis);

            double[] zahlen = new double[3];
            zahlen[0] = Math.PI;
            zahlen[1] = Math.E;
            zahlen[2] = Math.PI;
            Console.WriteLine(zahlen[1]);           

            Console.WriteLine(ia.Length);
        }

        //Stings
        static void strings()
        {
            string meinString = "Dies ist ein String";
            Console.WriteLine(meinString);

            string aa = "Dies ist ";
            string bb = "ein String";
            string cc = aa + bb;  
            Console.WriteLine(cc);

            string a = "eins";
            string b = "zwei";
            string c = "eins";
            bool a_eq_b = (a == b);
            bool a_eq_c = (a == c);
            Console.WriteLine(a_eq_b);
            Console.WriteLine(a_eq_c);

            char zeichen = meinString[5];
            Console.WriteLine(zeichen);
        }

        //Verzweigung
        static void Verzweigung()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            
                if (a>3 && b==6)
                {
                    Console.WriteLine("Du hast gewonnen");
                }
                else
                {
                    Console.WriteLine("Leider verloren");
                }
           
        }

        //switch/case
        static void switchcase()
        {
            string i = Console.ReadLine();
            switch (i)
                {
                case "1":
                    Console.WriteLine("Du hast EINS eingegeben");
                    break;
                case "2":
                    Console.WriteLine("ZWEI war Deine Wahl");
                    break;
                case "3":
                    Console.WriteLine("Du tipptest eine DREI");
                    break;
                case "4":
                    Console.WriteLine("Du tipptest eine VIER");
                    break;
                default:
                    Console.WriteLine("Unbekannt");
                    break;
                }           
        }

        //while
        static void whileschleife()
        {
            int i=1; //Initialisierung 
            while (i>=1 && i<=10) //Bedingung
            {
                Console.WriteLine(i);
                i++; //Inkrement               
            }
        }

        //for
        static void forschleife ()
        {
            string[] someStrings = 
            {
                /*"Hier",
                "sehen",
                "wir",
                "einen",
                "Array",
                "von",
                "Strings",
                "Ende"*/
            };
            var i = 0;
            while (i<someStrings.Length)
            {
                Console.WriteLine(someStrings[i]);
                i++;
            }
        }

        //whilebreak
        static void whilebreak()
        {
            string[] someStrings = 
            {
                /*"Hier",
                "sehen",
                "wir",
                "einen",
                "Array",
                "von",
                "Strings",
                "Ende"*/
            };

            int i = 0;
            do
            {
                Console.WriteLine(someStrings[i]);
                i++;
            }
            while (i < someStrings.Length);
        }

        //Teil2 whilebreak
        static void whilebreak1()
        {
            string[] someStrings = 
            {
               /*  "Hier",
                "sehen",
                "wir",
                "einen",
                "Array",
                "von",
                "Strings",
                "Ende" */
            };

            int i = 0;
            while (true)
            {
                Console.WriteLine(someStrings[i]);
                i++;
                if (i == someStrings.Length)
                {
                    break;
                }
                
            }
        }
        
    }
}
