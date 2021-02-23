using System;
using EquazioniLibrary;
namespace ProvaEquazioni
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("che operazione vuoi eseguire:\n1-IsDetermined \n2-IsInconsisted \n3-IsDegree \n4-Delta \n5-result \n6-EqationDegree");
            Console.WriteLine("seleziona un operazione");
            string scelta = Console.ReadLine();

            switch(scelta)
            {
                case "1":
                case "IsDetermined":
                    Console.WriteLine($"Inserire il coefficente del primo membro");
                    double a = double.Parse(Console.ReadLine());
                    bool risposta = Equazioni.IsDetermined(a);
                    if(risposta == true)
                    {
                        Console.WriteLine("Determinata");
                    }
                    else
                    {
                        Console.WriteLine("Non è determinata");
                    }
                    break;
                case "2":
                case "IsInconsisted":
                    break;
                case "3":
                case "IsDegree":
                    break;
                case "4":
                case "Delta":
                    break;
                case "5":
                case "result":
                    break;
                case "6":
                case "EqationDegree":
                    break;
            }
        }
    }
}

