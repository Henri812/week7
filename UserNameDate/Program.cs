using System;

namespace UserNameDate
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                // prog küsib sisestada oma eesnime;
                // prog kuvab eesnime pikkust;
                // prog kuvab kasutaja eesnime esimest tähte;
                //Program kuvab kasutaja eesnime tagurpid;
                // main meetodis ei tohi olla rohkem, kui kolm rida kood;

                Console.WriteLine("Sisesta oma eesnimi: ");
                string userName = Console.ReadLine();

                GetUsernameData(userName);

            }
            public static void GetUsernameData(string userInput)
            {
                Console.WriteLine($"Sinu nimi on {userInput.Length} sümbolit pikk.");// pikkus
                Console.WriteLine($"sinu eesnme esimene täht on {userInput[0]} .");//esimene täht
                for (int i = userInput.Length - 1; i >= 0; i--) //tagurpidi
                {
                    Console.Write(userInput[i]);
                }
    }
}
