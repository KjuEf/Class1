using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class1
{
    public enum tipoviPoste
    {
        ObicnaPosiljka = 1,
        Preporucena = 2,
        BrzaPošta = 3,
    }

    public enum Seasons
    {
        Proljece,
        ljeto,
        jesen,
        zima
    }

    public class person
    {
        public int Age;
    }

    class Program
    {
        static void Main(string[] args)
        {
            var metoda = tipoviPoste.BrzaPošta;
            Console.WriteLine((int)metoda);

            var metodaId = 1;
            Console.WriteLine((tipoviPoste)metodaId);

            Console.WriteLine(metoda.ToString());

            var metodaNeka = "BrzaPošta";
            var tipoviPoste1 = (tipoviPoste)Enum.Parse(typeof(tipoviPoste), metodaNeka);
            Console.WriteLine(tipoviPoste1);

            var number = 1;
            Povecaj(number);
            Console.WriteLine(number);

            var person = new person() { Age = 20 };
            MakeOld(person);
            Console.WriteLine(person.Age);

            //

            Console.WriteLine("hours");
            int hour = 10;

            if (hour > 0 && hour < 12)
            {
                Console.WriteLine("It's morning");
            }
            else if(hour >= 12 && hour < 18)
            {
                Console.WriteLine("It's afternoon");
            }
            else
            {
                Console.WriteLine("It's evening");
            }

            //

            bool isGoldCustomer = true;

            float price;
            if (isGoldCustomer)
                price = 15.54f;
            else
                price = 20.54f;
            Console.WriteLine(price);
        
            float price2 = (isGoldCustomer) ? 15.54f : 20.54f;
            Console.WriteLine(price2);

            //

            var sezona = Seasons.zima;

            switch (sezona)
            {
                case Seasons.zima:
                    Console.WriteLine("Zima je Zima jee");
                    break;
                case Seasons.ljeto:
                    Console.WriteLine("Ljeto je Ljeto jew");
                    break;
                case Seasons.jesen:
                    Console.WriteLine("Jesen je");
                    break;
                case Seasons.Proljece:
                    Console.WriteLine("Proljece jeee");
                    break;
                default:
                    Console.WriteLine("Nije nista");
                    break;
            }
            
        }
       
        public static void Povecaj(int number)
        {
            number += 10;
            Console.WriteLine(number);
        }
        public static void MakeOld(person person)
        {
            person.Age += 10;
        }

    }




}
