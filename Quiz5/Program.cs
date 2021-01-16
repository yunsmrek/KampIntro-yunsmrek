using System;

namespace Quiz5
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] Names = new string[] { "Asibe", "Ahmet", "Hatice", "Yunus Emre", "Zeynep Sude"};

          while (true)
          {
               Console.WriteLine("1-5 arasında bir sayı giriniz");            
               int x = Convert.ToInt32(Console.ReadLine());
            
              switch (x)
                {
                case 1:
                     Console.WriteLine(Names[0]);
                break;
                case 2:
                     Console.WriteLine(Names[1]);
                break;
                case 3:
                     Console.WriteLine(Names[2]);
                break;
                case 4:
                     Console.WriteLine(Names[3]);
                break;
                case 5:
                     Console.WriteLine(Names[4]);
                break;
                default:
                     Console.WriteLine("Girdiğiniz veri 1-5 arasında bir sayı değil !!!");
                break;
            }
          }
        }
    }
}
