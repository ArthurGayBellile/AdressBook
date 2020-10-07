using System;
using System.Collections.Generic;
using System.Threading;

namespace AdressBook
{
    class Program
    {

        static void Livres(LinkedListNode<Musique> current)
        {
            int number = 1;
            while (current != null)
            {
                Console.Clear();
                string numberString = $"- {number} -";
                int leadingSpaces = (90 - numberString.Length) / 2;
                Console.WriteLine(numberString.PadLeft(leadingSpaces + numberString.Length));
                Console.WriteLine();

                string content = current.Value.Contentt;
                for (int i = 0; i < content.Length; i += 90)
                {
                    string line = content.Substring(i);
                    line = line.Length > 90 ? line.Substring(0, 90) : line;
                    Console.WriteLine(line);
                }

                Console.WriteLine();
                Console.WriteLine($"Quote from \"Windows Application Development Cookbook\" by Marcin Jamro,{Environment.NewLine}published by Packt Publishing in 2016.");

                Console.WriteLine();
                Console.Write(current.Previous != null ? "< PREVIOUS [P]" : GetSpaces(14));
                Console.Write(current.Next != null ? "[N] NEXT >".PadLeft(76) : string.Empty);
                Console.WriteLine();

                switch (Console.ReadKey(true).Key)
                {
                    case ConsoleKey.N:
                        //if (current.Next != null)
                        //{
                            current = current.Next;
                            number++;
                        //}
                        break;
                    case ConsoleKey.P:
                        //if (current.Previous != null)
                        //{
                            current = current.Previous;
                            number--;
                        //}
                        break;
                    default:
                        return;
                }
            }


            static string GetSpaces(int number)
            {
                string result = string.Empty;
                for (int i = 0; i < number; i++)
                {
                    result += " ";
                }
                return result;
            }
        }
        static void Main(string[] args)
        {
            /*
            SortedList<string, Person> people = new SortedList<string, Person>();

            people.Add("Marcin", new Person() { Name = "Marcin", Country = CountryEnum.IR, Age = 29 });
            people.Add("Sabine", new Person() { Name = "Sabine", Country = CountryEnum.FR, Age = 25 });
            people.Add("Ann", new Person() { Name = "Ann", Country = CountryEnum.UK, Age = 31 });

            people.Add("Arthur", new Person() { Name = "Arthur", Country = CountryEnum.UK, Age = 10 });
            people.Add("Aurélie", new Person() { Name = "Aurélie", Country = CountryEnum.UK, Age = 15 });
            people.Add("Aurélien", new Person() { Name = "Aurélien", Country = CountryEnum.UK, Age = 25 });
            people.Add("Amélie", new Person() { Name = "Amélie", Country = CountryEnum.UK, Age = -2 });



            SortedList<int, Person> people2 = new SortedList<int, Person>();

            people2.Add(29, new Person() { Name = "Marcin", Country = CountryEnum.IR, Age = 29 });
            people2.Add(25, new Person() { Name = "Sabine", Country = CountryEnum.FR, Age = 25 });
            people2.Add(31, new Person() { Name = "Ann", Country = CountryEnum.UK, Age = 31 });

            people2.Add(10, new Person() { Name = "Arthur", Country = CountryEnum.UK, Age = 10 });
            people2.Add(15, new Person() { Name = "Aurélie", Country = CountryEnum.UK, Age = 15 });
            people2.Add(26, new Person() { Name = "Aurélien", Country = CountryEnum.UK, Age = 26 });
            people2.Add(-2, new Person() { Name = "Amélie", Country = CountryEnum.UK, Age = -2 });

            foreach (KeyValuePair<int, Person> person in people2)
            {
                Console.WriteLine($"{person.Value.Name}({ person.Value.Age}   years) from { person.Value.Country}.");
            }
            */

            //The following will throw exceptions
            //numberNames.Add("Three", 3); //Compile-time error: key must be int type
            //numberNames.Add(1, "One"); //Run-time exception: duplicate key
            //numberNames.Add(null, "Five");//Run-time exception: key cannot be null

            
            Musique musiqueFirst = new Musique() { Contentt = "Night Fever - Bee GEES" };
            Musique musiqueSecond = new Musique() { Contentt = "I Beleive i can fly - R KELLY" };
            Musique musiqueThird = new Musique() { Contentt = "New York - Alicia KEYS" };
            Musique musiqueFourth = new Musique() { Contentt = "Dragovic - MAES" };
            Musique musiqueFifth = new Musique() { Contentt = "Habitué - DOSSEH" };
            Musique musiqueSixth = new Musique() { Contentt = "1000 degrés - Romeo ELVIS" };

            CircularLinkedList<Musique> Listemusique = new CircularLinkedList<Musique>();
            Listemusique.AddLast(musiqueSecond);
            Listemusique.AddLast(musiqueSixth);
            Listemusique.AddFirst(musiqueFirst);

            LinkedListNode<Musique> nodeMusiqueFourth = Listemusique.AddLast(musiqueFourth);

            Listemusique.AddBefore(nodeMusiqueFourth, musiqueThird);
            Listemusique.AddAfter(nodeMusiqueFourth, musiqueFifth);
            int i = 0;
            /*foreach (Musique a in Listemusique)
            {
                Console.WriteLine(a.ToString());
                Thread.Sleep(500);
                i++;
                if (i == 6) Console.WriteLine();
                if (i == 15) Console.ReadKey();
            }
            */
            



            Page pageFirst = new Page() { Content = "Nowadays, there are various (...)" };
            Page pageSecond = new Page() { Content = "Application development is (...)" };
            Page pageThird = new Page() { Content = "A lot of applications (...)" };
            Page pageFourth = new Page() { Content = "Do you know that modern (...)" };
            Page pageFifth = new Page() { Content = "While developing applications (...)" };
            Page pageSixth = new Page() { Content = "Could you imagine your (...)" };

            LinkedList<Page> livre = new LinkedList<Page>();
            livre.AddLast(pageSecond);

            LinkedListNode<Page> noeud4 = livre.AddLast(pageFourth);


            foreach (Page a in livre)
            {
                Console.WriteLine(a.toString());
            }

            livre.AddLast(pageSixth);
            livre.AddFirst(pageFirst);

            livre.AddBefore(noeud4, pageThird);
            livre.AddAfter(noeud4, pageFifth);


            LinkedListNode<Musique> currentt = Listemusique.First;
            LinkedListNode<Page> current = livre.First;
            Livres(currentt);

            /*
            CircularLinkedList<string> categories = new CircularLinkedList<string>();
            
            categories.AddLast("Sport");
            categories.AddLast("Culture");
            categories.AddLast("History");
            categories.AddLast("Geography");
            categories.AddLast("People");
            categories.AddLast("Technology");
            categories.AddLast("Nature");
            categories.AddLast("Science");
            

            categories.AddLast("bankrupt");
            categories.AddLast("10");
            categories.AddLast("5000");
            categories.AddLast("200");
            categories.AddLast("15000");
            categories.AddLast("spin");
            categories.AddLast("50");
            categories.AddLast("75"); 
            categories.AddLast("650");
            categories.AddLast("2000");
            categories.AddLast("Lose a turn");
            categories.AddLast("100");
            categories.AddLast("450");
            categories.AddLast("3000");
            categories.AddLast("20");
            categories.AddLast("500");


            Random random = new Random();
            int totalTime = 0;
            int remainingTime = 0;
            foreach (string category in categories)
            {
                if (remainingTime <= 0)
                {
                    Console.WriteLine("Press [Enter] to start or any other to exit.");
                    switch (Console.ReadKey().Key)
                    {
                        case ConsoleKey.Enter:
                            totalTime = random.Next(1000, 5000);
                            remainingTime = totalTime;
                            break;
                        default:
                            return;
                    }
                }

                int categoryTime = (-450 * remainingTime) / (totalTime - 50) + 500 + (22500 / (totalTime - 50));
                remainingTime -= categoryTime;
                Thread.Sleep(categoryTime);
                Console.Write(categoryTime + "  ");

                Console.ForegroundColor = remainingTime <= 0 ? ConsoleColor.Red : ConsoleColor.Gray;
                Console.WriteLine(category);
                Console.ForegroundColor = ConsoleColor.Gray;
                */

            Console.ReadKey();
        }
    }
}
    