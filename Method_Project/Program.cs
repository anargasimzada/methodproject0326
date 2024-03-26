using System.Numerics;

namespace Method_Project
{
    internal class Program
    {
       
        static List<string> namesList = new List<string>();

        static void Main(string[] args)
        {
            int reqem;

            do
            {
                Console.WriteLine("Menyu:");
                Console.WriteLine("1. Siyahıya keçid et");
                Console.WriteLine("0. Menyudan çıxış");

                Console.Write("Reqem daxil edin: ");
                if (int.TryParse(Console.ReadLine(), out reqem))
                {
                    switch (reqem)
                    {
                        case 1:
                            nameList();
                            break;
                        case 2:
                            AddName();
                            break;
                        case 3:
                            checkName();
                            break;
                        case 0:
                            Console.WriteLine("Çıxış...");
                            break;
                        default:
                            Console.WriteLine("Başqa rəqəm daxil edin.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Reqem daxil edin.");
                }

                Console.WriteLine();
            } while (reqem != 0);
        }

        static void nameList()
        {
            Console.WriteLine("Siyahıdakı adlar:Anar,Nurlan,Vuqar");
            foreach (string name in namesList)
            {
                Console.WriteLine(name);
            }
        }
        static void AddName()
        {
            Console.WriteLine("Ad daxil edin");
            string newName= Console.ReadLine();
            if (AddName((newName))
            {
                namesList.Add(newName);
                Console.WriteLine("siyahiya ad elave edildi");
            }
            else
            {
                Console.WriteLine("");
            }  
        }
        static bool checkName()
        {
            string newName = Console.ReadLine();
            if (checkName(newName))
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }

    }
}   

