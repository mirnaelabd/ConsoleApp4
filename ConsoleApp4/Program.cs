using ConsoleApp4;
using System.Net.NetworkInformation;

namespace ConsoleApp4
{

    internal struct points
    {

        public int X;
        public int Y;


    }


    internal class Program
    {
        #region q1
        /*   public enum days
           {
               Monday,
               Tuesday,
               Wednesday,
               Thursday,
               Friday,
               Saturday,
               Sunday
           }*/
        #endregion

        #region q2:
        public enum Season
        {
            Spring,
            Summer,
            Autumn,
            Winter
        }
        #endregion

        #region q3;
        [Flags]
        public enum permession
        {
            Read = 1, write = 2, Delete = 4, Execute = 8
        }

        #endregion

        #region q4
        public enum Colors
        {
            blue,
            red,
            green

        }
        #endregion
        static void Main()
        {
            #region q1:
            /*   foreach (days day in Enum.GetValues(typeof(days)))
               {
                   Console.WriteLine(day);
               } */
            #endregion
            #region q 2 
            /*    Console.WriteLine("Enter a season (Spring, Summer, Autumn, Winter):");
                string s = Console.ReadLine();
                if (Enum.TryParse(s, true, out Season input))
                {
                    switch (input)
                    {
                        case Season.Spring:
                            Console.WriteLine("Spring months: March to May");
                            break;
                        case Season.Autumn:
                            Console.WriteLine("Autumn months: September to November");
                            break;
                        case Season.Winter:
                            Console.WriteLine("Winter months: December to February");
                            break;
                        case Season.Summer:
                            Console.WriteLine("Summer months: June to August");
                            break;

                        default:
                            Console.WriteLine("Invalid season entered.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("try again , Please enter naame of seasons.");
                }*/
            #endregion

            #region  q3 

            /*    permession p=new permession();
                   p= (permession)3;
                Console.WriteLine(p);
                if (p ==((permession)4))
                p = p | permession.Read;
                else if (p==((permession)1))
             p = p | permession.Delete;
                else 
                Console.WriteLine(p);*/
            #endregion

            #region q4

            /*
                        Console.WriteLine("Enter a color name:");
                        string color = Console.ReadLine();

                        if (Enum.TryParse(color, true, out Colors input))
                        {

                            if (input == Colors.Green ||input == Colors.Red || input == Colors.Blue)
                            {
                                Console.WriteLine($"{color} is a primary color ");
                            }
                            else
                            {
                                Console.WriteLine($"{color} is not a primary color.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("try again , Please enter a color name");
                        }
                    */
            #endregion

            #region q5
            /* point p = new point();
             Console.WriteLine("enter an frist integer ");
             if (int.TryParse(Console.ReadLine(), out int r))
                 p.X = r;

             else
                 Console.WriteLine("enter an integer ");

             if (int.TryParse(Console.ReadLine(), out int c))
                 p.Y= c;
             else
             {
                 Console.WriteLine("enter an integer ");
             }

             int s = p.X - p.Y;
             Console.WriteLine($"the distance between {p.X} and {p.Y} is {s} ");*/
            #endregion
        }
    }
}






