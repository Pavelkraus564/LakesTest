using System.Security.Cryptography.X509Certificates;
using System.ComponentModel;
namespace LakesTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
         List<Rybník> rybníky = new List<Rybník>();

            string path = "C:\\Users\\Pavel\\source\\repos\\LakesTest\\LakesTest\\lakes.txt";

            using StreamReader sr = new StreamReader(path);
            string line = "";
            while ((line = sr.ReadLine()) != null)
            {
                var lineParts = line.Split('/');

                Rybník rybník = new Rybník(Convert.ToInt32(lineParts[0]), lineParts[1], Convert.ToInt32(lineParts[2]), Convert.ToInt32(lineParts[3]),lineParts[4]);
                rybníky.Add(rybník);
            }
            VypsaniOkres(rybníky);
        }
        static void VypsaniOkres(List<Rybník>rybníky)
        {
           while (true)
            {
               for (int i = 0;rybníky.Count > 0;i++)
                {
                    Console.WriteLine("napište okres");
                    string okresInput = Console.ReadLine();
                    if (okresInput == rybníky[i].okres )
                    {
                        
                         
                        Console.WriteLine("okres je: " +rybníky[i].okres);
                        Console.WriteLine("objem je:" + rybníky[i].objemKm + rybníky[i].objemKm);
                    }
                    else
                    {
                        Console.WriteLine("zadali jste špatný okres/okres nefunguje");
                    } 

                }
               
            
            
            
            }
        }
    } 
}
