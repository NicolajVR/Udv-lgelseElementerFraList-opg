using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UdvælgelseElementerFraList_opg
{
    class Program
    {
        static void Main(string[] args)
        {
            //Opg. A + Opg. B.


            //Liste af Car objekter
            Car c1 = new Car(1, "Rio", "Kia", 2006, 250000, "Red");
            Car c2 = new Car(2, "Rio", "Kia", 2007, 265000, "Black");
            Car c3 = new Car(3, "Panda", "Fiat", 2017, 265000, "Black");
            Car c4 = new Car(4, "Panda", "Fiat", 2017, 365000, "Yellow");
            Car c5 = new Car(5, "S40", "Volvo", 2018, 665000, "White");
            Car c6 = new Car(6, "S65", "Volvo", 2018, 600000, "White");
            Car c7 = new Car(7, "Gorm", "Ferrari", 2000, 4665000, "White");
            Car c8 = new Car(8, "Gorm", "Ferrari", 2018, 4665000, "White");

            //Lister til Car.

            List<Car> CarList = new List<Car> { c1, c2, c3, c4, c5, c6, c7, c8 };

            List<Car> ModelList = new List<Car>();
            foreach (var item in CarList)
            {
                if (item.Model == "Rio")
                {
                    ModelList.Add(item);
                }
            }

            List<Car> BrandList = new List<Car>();
            foreach (var item in CarList)
            {
                if (item.Brand == "Ferrari")
                {
                    BrandList.Add(item);
                }
            }

            List<Car> totiogfrem = new List<Car>();
            foreach (var item in CarList)
            {
                if (item.Year >= 2010)
                {
                    totiogfrem.Add(item);
                }
            }

            List<Car> whitecars = new List<Car>();
            foreach (var item in CarList)
            {
                if (item.Color == "White")
                {
                    whitecars.Add(item);
                }
            }

            List<Car> idcar = new List<Car>();
            foreach (var item in CarList)
            {
                if (item.Id == 8)
                {
                    idcar.Add(item);
                }
            }
            ////////////////

            //liste med alle tal
            List<int> intList = new List<int>() { 4, 7, 12, 17, -3, 8, 0, -45, 101 };

            //Liste med alle tal mindre eller lign. 0.
            List<int> nlist = new List<int>();
            {
                foreach (var item in intList)
                {
                    if (item <= 0)
                    {
                        nlist.Add(item);
                    }
                }
            }

            //Liste med alle tal lig 7. (alle tal der er == 7??)
            List<int> sevenList = new List<int>();
            {
                foreach (var item in intList)
                {
                    if (item == 7)
                    {
                        sevenList.Add(item);
                    }
                }
            }

            //Liste med alle tal større end 4.
            List<int> fourUplist = new List<int>();
            {
                foreach (var item in intList)
                {
                    if (item > 4)
                    {
                        fourUplist.Add(item);   
                    }
                }
            }
            Console.WriteLine("tal 0 og under");
            UdskriListe(nlist);
            Console.WriteLine();
            Console.WriteLine("Hvor tal == 7");
            UdskriListe(sevenList);
            Console.WriteLine();
            Console.WriteLine("Hvor det over 4");
            UdskriListe(fourUplist);
            Console.WriteLine();

            Console.WriteLine("Udvalg:");
            Console.WriteLine();
            Console.WriteLine("Model Liste");
            UdskriListe(ModelList);
            Console.WriteLine("brand Liste");
            UdskriListe(BrandList);
            Console.WriteLine("2010 og frem liste");
            UdskriListe(totiogfrem);
            Console.WriteLine("Hvide biler liste");
            UdskriListe(whitecars);
            Console.WriteLine("id = 8 liste.");
            UdskriListe(idcar);


            Console.ReadKey();
        }

        //Metode til at udskrive alt i listen.
        static void UdskriListe(List<int> ModtagetListe)
        {
            foreach (var item in ModtagetListe)
            {
                Console.WriteLine(item.ToString());
            }
        }

        //Udvidelse af metoden (overload)
        static void UdskriListe(List<Car> ModtagetListe)
        {
            foreach (var item in ModtagetListe)
            {
                Console.WriteLine($"ID: {item.Id} - Model: {item.Model} Brand: {item.Brand} - Year {item.Year} - Color: {item.Color}");
            }
        }
    }
}
