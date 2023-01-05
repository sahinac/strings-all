using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace strings_all
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string Volvmenu;
            do
            {
                int choice;
                Console.WriteLine("Opciones:");
                Console.WriteLine("-------------------");
                Console.WriteLine("{1}Conteo del string y primera letra");
                Console.WriteLine("{2} Hay letras minisuculas?");
                Console.WriteLine("{3} Queersumme:");
                Console.WriteLine("{4} Vokale entfernen");
                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {

                    case 1:
                        {
                            Console.WriteLine("Anzahl der Zeichen:");
                            string text;
                            // int anzahl;      opcional
                            Console.Write("Ihre Eingabe:");
                            text = Console.ReadLine();
                            //anzahl=text.Length;            opcional

                            Console.WriteLine("Es gibt {0} Zeichen", text.Length);

                            // Zugreifen auf die einselnen Zeichen
                            Console.WriteLine("Ausgabe eines einzelnen Zeichens:");
                            Console.WriteLine("Das 1.Zeichen ist:" + text[0]);
                            Console.ReadLine();
                            break;
                        }

                    case 2:
                        {
                            Console.Write("Stringeingabe:");
                            string text1;
                            text1 = Console.ReadLine();

                            int z = 0;
                            for (int i = 0; i < text1.Length; i++)
                            {
                                if (char.IsLower(text1[i]))
                                {
                                    z++;
                                    if (z > 0)
                                    {
                                        Console.WriteLine("Es gibt kleine Buchstaben.");
                                        break;
                                    }

                                }
                                else if (z == 0)
                                {
                                    Console.WriteLine("Es gibt keine kleine Buchstaben");
                                    break;

                                }

                            }
                            Console.ReadLine();
                            break;
                        }
                    case 3:
                        {

                            Console.WriteLine("Quersumme");
                            Console.WriteLine("Eingabe einer strings");

                            string zahl;
                            zahl = Console.ReadLine();

                            int quersumme = 0;

                            for (int i = 0; i < zahl.Length; i++)
                            {
                                quersumme = quersumme + Convert.ToInt32(zahl[i].ToString());

                            }
                            Console.WriteLine("Die Quersumme von " + zahl + " ist: " + quersumme);


                            Console.ReadLine();
                            break;
                        }

                    case 4:
                        {
                            Console.WriteLine("Vokale sollen entfernt werden!");
                            string text3;
                            Console.Write("Zeichenkette eingeben: ");
                            text3 = Console.ReadLine();

                            string vokale = "aeiouAEIOU";

                            for (int j = 0; j < vokale.Length; j++)
                            {
                                text3 = text3.Replace(vokale[j].ToString(), "");
                            }

                            Console.WriteLine("neu:  " + text3);
                            Console.ReadLine();
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Elija opción correcta");
                            break;
                        }
                }

                Console.WriteLine("Quiere volver a elejir(escriba si o no");

                Volvmenu = Console.ReadLine();
                if (Volvmenu == "si")
                {
                    Console.Clear();
                }
                else
                {
                    Console.WriteLine("programa acaba aquí");
                }

            } while (Volvmenu == "si");

            string satz;
            char espacio = ' ';
            int count = 0;
            Console.WriteLine("Satz:");
            satz = Console.ReadLine();

            char[] satza = satz.ToCharArray();
            Array.Reverse(satza);
            foreach (char i in satza)
            {
                Console.WriteLine("última letra" + "\t" + i);
                break;
            }

            for (int i = 0; i < satz.Length; i++)
            {
                if (satz[i] == espacio)
                {
                    count++;
                }

            }
            Console.WriteLine("él número de espacios es " + "\t\t" + count);

            //string satz1;
            //Console.WriteLine("SATZ");
            //satz1 = Console.ReadLine();
            //string espacio = " ";

            //string cleanstrng = satz1.Replace(espacio, "");
            //Console.WriteLine(cleanstrng);

            

        }
    }
}
