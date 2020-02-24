using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Reflection;

namespace AufgabeZuLINQFilterOperationen
{
    class Program
    {
        static void Main(string[] args)
        {//Erste Aufgabe Filter Operationen
         //alle Zahlen ausgeben mittels Linq die kleiner als 7 sind 
            Console.WriteLine("**************************************************");
            Console.WriteLine("Filter Operationen");
            Console.WriteLine("**************************************************");
            Console.WriteLine();
            Console.WriteLine("Alle Zahlen echt kleiner 7");
            int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0, 22, 12, 16, 18, 11, 19, 13 };
            string[] textZahlen = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten", "eleven", "twelve", "thirteen", "fourteen" };


            var kleinerSieben = from kleiner in numbers
                                where kleiner < 7
                                select new { kleiner };

            foreach (var item in kleinerSieben)
            {
                Console.WriteLine(item);
            }
          

            Console.WriteLine();
            Console.WriteLine("**************************************************");


            // Zweite aufgabe alle zahlen die grade sind mittels Linq ausgeben
            Console.WriteLine("Alle geraden Zahlen");
            var geradeZahlen = from gerade in numbers
                               where gerade % 2 == 0
                               select new { gerade };

            foreach (var item in geradeZahlen)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();
            Console.WriteLine("**************************************************");


            // Dritte Aufgabe alle einstelligen ungeraden zahlen ausgeben mittels Linq
            Console.WriteLine("Alle einstelligen ungeraden Zahlen");

            var einstelligUngerade = from ungerade in numbers
                                     where ungerade % 2 == 1 && ungerade < 10
                                     select new { ungerade };

            foreach (var item in einstelligUngerade)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();
            Console.WriteLine("**************************************************");
            //Vierte Aufgabe alle Geraden zahlen ab dem 6 Element (einschliesslich) im Array ausgeben mit Linq
            Console.WriteLine("Alle geraden Zahlen ab dem 6 Element");
            var sechstesElement = from geradesechstes in numbers.Skip(6)
                                  where geradesechstes % 2 == 0
                                  select new { geradesechstes };

            foreach (var item in sechstesElement)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            Console.WriteLine("**************************************************");
            Console.WriteLine("Ab Hier Aufgabe 2 Arbeiten mit String Array und Linq");

            // Aufgabe Mit Linq String Array Filtern

            // aufgabe 1 Alle zahlen ermiteln die drei Zeichen lang sind 
            Console.WriteLine("Alle zahlen die drei Zeichen lang sind");

            var dreiZeichenLang = from dreiZeichen in textZahlen
                                  where dreiZeichen.Length == 3
                                  select new { dreiZeichen };

            foreach (var item in dreiZeichenLang)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();
            Console.WriteLine("**************************************************");
            var oenthalten = from o in textZahlen
                             where o.Contains("o")
                             select new { o };

            foreach (var item in oenthalten)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();
            Console.WriteLine("**************************************************");

            // Alle Elemente die mit einem teen enden ausgeben mit Linq

            Console.WriteLine("Alle Elemente im Array die mit teen enden");
            var teenEnden = from teen in textZahlen
                            where teen.EndsWith("teen")
                            select new { teen };

            foreach (var item in teenEnden)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();
            Console.WriteLine("**************************************************");

            // Alle Elemente in Großbuchstaben ausgeben die mit teen enden mit Linq
            Console.WriteLine("Großbuchstaben Darstellung aller Zahlen die mit teen enden ");
            var GroßmitTeen = from groß in textZahlen
                              where groß.EndsWith("teen")
                              select new { G = groß.ToUpper() };


            foreach (var item in GroßmitTeen)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();
            Console.WriteLine("**************************************************");

            //  Alle Elemnte ausgeben die four enthalten mit Linq
            Console.WriteLine("Alle elemente die four enthalten");
            var fourEnthalten = from four in textZahlen
                                where four.Contains("four")
                                select new { four };

            foreach (var item in fourEnthalten)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("**************************************************");

            // Aufgabe 3
            Console.WriteLine("**************************************************");
            Console.WriteLine("Aggregation");
            Console.WriteLine("**************************************************");
            Console.WriteLine();

            // Summe aller Werte im Array 
            Console.WriteLine("summe aller werte im Array");
            int sum = numbers.Sum();
            Console.WriteLine(sum);

            Console.WriteLine();
            Console.WriteLine("**************************************************");

            // kleinste zahl
            Console.WriteLine("Kleinste Zahl im Array");
            int kleinste = numbers.Min();

            Console.WriteLine(kleinste);

            Console.WriteLine();
            Console.WriteLine("**************************************************");

            // größte zahl
            Console.WriteLine("Größte Zahl im Array");
            int größte = numbers.Min();

            Console.WriteLine(größte);

            Console.WriteLine();
            Console.WriteLine("**************************************************");



            // durchschnitt
            Console.WriteLine("Durchschnitt (Average) der Elemente im Array");
            double durchschnitt = numbers.Average();

            Console.WriteLine(durchschnitt);

            Console.WriteLine();
            Console.WriteLine("**************************************************");



            // kleinste gerade zahl

            Console.WriteLine("Kleinste gerade Zahl im Array");
            int kleinstegerade = numbers.Where(x => x % 2 == 0).Min();

            Console.WriteLine(kleinstegerade);


            Console.WriteLine();
            Console.WriteLine("**************************************************");

            // größte ungerade zahl
            Console.WriteLine("Größte ungerade zahl im  Array");
            int größteUngerade = numbers.Where(x => x % 2 == 1).Max();

            Console.WriteLine(größteUngerade);


            Console.WriteLine();
            Console.WriteLine("**************************************************");

            //Summer aller geraden zahlen
            Console.WriteLine("Summe aller gerader zahlen");
            int summeGrade = numbers.Where(x => x % 2 == 0).Sum();

            Console.WriteLine(summeGrade);


            Console.WriteLine();
            Console.WriteLine("**************************************************");

            // Durchschnittswert aller ungeraden zahlen
            Console.WriteLine("Alle ungeraden Zahlen im Array");
            double DurschnittUngerade = numbers.Where(x => x % 2 == 1).Average();

            Console.WriteLine(DurschnittUngerade);
            Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("**************************************************");


            //Array aufsteigend Sortiert und ausgeben
            Console.WriteLine("**************************************************");
            Console.WriteLine("Sortierung");
            Console.WriteLine("**************************************************");
            Console.WriteLine();
            Console.WriteLine("Array aufsteigend Sortiert");
            int[] Sortierenzahlen = numbers.OrderBy(x => x).ToArray();

            foreach (var item in Sortierenzahlen)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();
            Console.WriteLine("**************************************************");


            //Array absteigend Sortieren und ausgeben
            Console.WriteLine("Array aifsteigend Sortiert");
            int[] SortierenAbsteigend = numbers.OrderByDescending(x => x).ToArray();

            foreach (var item in SortierenAbsteigend)
            {
                Console.WriteLine(item);
            }



            Console.WriteLine();
            Console.WriteLine("**************************************************");

            // Array Alle geraden zahlen ausgeben und aufsteigend sortieren
            Console.WriteLine("Alle geraden Zahlen aus dem Array ausgeben und Sortieren");
            int[] geradeZahlenAufsteigend = numbers.Where(x => x % 2 == 0).OrderBy(x => x).ToArray();


            foreach (var item in geradeZahlenAufsteigend)
            {
                Console.WriteLine(item);
            }


            Console.WriteLine();
            Console.WriteLine("**************************************************");

            // Array nach Länger der Wörter aufsteigend Sortieren
            Console.WriteLine("Array nach länge der Wörter aufsteigend sortiert");
            var längeWörterSortiert = textZahlen.OrderBy(x => x.Length);

            foreach (var item in längeWörterSortiert)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();
            Console.WriteLine("**************************************************");

            //Array nach Länge der Wörter aufsteigend Sortieren bei gleicher Länger der wörter alphabetisch absteigend sortierenn
            Console.WriteLine("Array nach Länge der Wörter aufsteigend Sortieren bei gleicher Länger der wörter alphabetisch absteigend sortiert");
            var wörterSortieren = textZahlen.OrderBy(x => x.Length).ThenBy(x => x);

            foreach (var item in wörterSortieren)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();
            Console.WriteLine("**************************************************");


            // Rheinfolge Elemente umdrehen im Array
            Console.WriteLine("Die Reihenfolge der Elemente im Array umgedreht");
            var reihenfolgeUmdrehen = textZahlen.OrderByDescending(x => x.Length).ThenBy(x => x);

            foreach (var item in reihenfolgeUmdrehen)
            {
                Console.WriteLine(item);
            }


            Console.WriteLine();
            Console.WriteLine("**************************************************");

            // Listet alle Namen im verzeichnisse Sortoert nach namen auf 
            Console.WriteLine("Alle Dateien im Verzeichniss Aufsteigend sortiert");
            DirectoryInfo directoryInfo = new DirectoryInfo(@"C:\Users\samir\Documents");

            FileInfo[] directoryNachNamen = directoryInfo.GetFiles().OrderBy(x => x.Name).ToArray();

            foreach (var item in directoryNachNamen)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();
            Console.WriteLine("**************************************************");

            // Listet alle Verzeichnisse nach größe sortiert auf
            Console.WriteLine("Alle Dateien im Verzeichniss nach Größe sortiert");
            var directoryNachGröße = directoryInfo.GetFiles().OrderBy(x => x.Length);

            foreach (var item in directoryNachGröße)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();
            Console.WriteLine("**************************************************");

            // Listet alle dateien nach dem letzten zugriff auf (Jüngster zugriff zuerst)
            Console.WriteLine("Alle dateien nach dem letzten zugriff auf (Jüngster zugriff zuerst) Sortiert");
            var directoryNachZugriff = directoryInfo.GetFiles().OrderBy(x => x.LastAccessTime);

            foreach (var item in directoryNachZugriff)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("**************************************************");

            // Aufgaben zu Partitionierung
            Console.WriteLine("Partitionierung");
            Console.WriteLine("**************************************************");
            Console.WriteLine();
            // Erste 5 elemente im Array ermitteln
            Console.WriteLine("Erste 5 Elemente im Array Ermitteln");
            var ersteFünfAusArray = numbers.Take(5);

            foreach (var item in ersteFünfAusArray)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();
            Console.WriteLine("**************************************************");

            // Letzte 5 Elemente im Array ermitteln
            Console.WriteLine("Letzte 5 Elemente im Array ermitteln");
            var letzteFünfAusArray = numbers.Skip(numbers.Count() - 5).Take(5);

            foreach (var item in letzteFünfAusArray)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();
            Console.WriteLine("**************************************************");

            // Alle elemente ausser das erste und die letzten drei elemente 
            Console.WriteLine("Alle Elemente ausser das erste und die letzten drei elemente Ermitteln");
            var allemitAussnahme = numbers.Skip(3).Skip(numbers.Count() - 3);

            foreach (var item in allemitAussnahme)
            {
                Console.WriteLine(item);
            }


            Console.WriteLine();
            Console.WriteLine("**************************************************");

            // Alle elemnte die Größer als 0 sind







            Console.WriteLine();
            Console.WriteLine("**************************************************");


            //Alle elemnte die nach der 12 im Array stehen






            Console.WriteLine();
            Console.WriteLine("**************************************************");


            // Listen sie die fünf neusten Datein im Verzeichniss auf





            Console.WriteLine();
            Console.WriteLine("**************************************************");

            // Listen sie alle Datein in dem verzeichnis in "Seiten" zu je 5 Seiten auf





            Console.WriteLine();
            Console.WriteLine("**************************************************");


            // Gruppierung
            //Gruppieren Array nach Anfangsbuchstaben 
            Console.WriteLine("**************************************************");
            Console.WriteLine("Gruppierung");
            Console.WriteLine("**************************************************");
            Console.WriteLine();
            Console.WriteLine("Gruppiert das Array nach Anfangsbuchstaben");

            var textzahlenAnfang = textZahlen.GroupBy(x => new { AnfangsBuchstaben = x.Substring(0, 1) });

            foreach (var item in textzahlenAnfang)
            {
                Console.WriteLine(item.Key);
            }

            
            Console.WriteLine();
            Console.WriteLine("**************************************************");



            //Gruppieren Array nach Wortlänge 
            Console.WriteLine("Gruppiert das Array nach Wortlänge");
            var textzahlenLänge = textZahlen.GroupBy(x => new { x.Length });

            foreach (var item in textzahlenLänge)
            {
                Console.WriteLine(item.Key);
            }


            Console.WriteLine();
            Console.WriteLine("**************************************************");


            //Gruppieren Array nach Anfangsbuchstaben und Worlänge 
            Console.WriteLine("Gruppert das Array nach Anfangsbuchstaben und Wortlänge");
            var textzahlenAnfangundLänge = textZahlen.GroupBy(x => new { x.Length, Buchstaben = x.Substring(0, 1) });

            foreach (var item in textzahlenAnfangundLänge)
            {
                Console.WriteLine(item.Key);
            }


            Console.WriteLine();
            Console.WriteLine("**************************************************");


            // Prozess gruppiert nach anzahl der Threads ausgeben 
            Console.WriteLine("Prozesse Gruppiert nach anzahl der Threads");
            Process[] locallAll = Process.GetProcesses();
            var ProzessgruppierenanzThread = locallAll.GroupBy(x => x.Threads).ToArray();

            foreach (var item in ProzessgruppierenanzThread)
            {
                Console.WriteLine(item.First());
            }

            Console.WriteLine();
            Console.WriteLine("**************************************************");

            // Mengenoperationen
            Console.WriteLine("Mengenoperatoren");
            Console.WriteLine("**************************************************");
            
            // Wie ist die Vereinigungsmenge der beiden Arrays?
            Console.WriteLine("Vereinigungsmenge zweier Arrays");
            int[] factorsof300 = { 2, 2, 3, 5, 5 };
            int[] numbersA = { 0, 2, 4, 5, 6, 8, 9 };
            int[] numbersB = { 1, 3, 5, 7, 8 };

            int[] vereinigungsmenge = numbersA.Union(numbersB).ToArray();

            foreach (var item in vereinigungsmenge)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();
            Console.WriteLine("**************************************************");

            // Schnittmenge beider Arrays
            Console.WriteLine("Schnittmenge zweier Arrays(intersect)");
            int[] schnittmenge = numbersA.Intersect(numbersB).ToArray();

            foreach (var item in schnittmenge)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();
            Console.WriteLine("**************************************************");

            // Welche Zahlen kommen in numbersB vor aber nicht in NumbersA?
            Console.WriteLine("welche zahlen kommen in arrayb vor aber nicht in arraya (Exception)");
            int[] vergleich = numbersB.Except(numbersA).ToArray();

            foreach (var item in vergleich)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();

        }
    }
}
