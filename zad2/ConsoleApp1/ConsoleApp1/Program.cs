using System;
using System.IO;
using System.Collections.Generic;
using System.Globalization; // dla parsowania liczb z przecinkiem/kropką

class Program
{
    static void Main()
    {
        string sciezka = "ranking_raw.txt";
        string output = "ranking_clear.txt";
        if (!File.Exists(sciezka))
        {
            Console.WriteLine($"File {sciezka} not found");
            return;
        }

        string[] linieTablica = File.ReadAllLines(sciezka);
        if (linieTablica.Length == 0)
        {
            Console.WriteLine($"{sciezka} is empty");
            return;
        }

        //Tworzymy listę na linie (łatwiej modyfikować)
        List<string> wynik = new List<string>();
        string header = linieTablica[0];
        wynik.Add(header);
        for (int i = 1; i < linieTablica.Length; i++)
        {
            string linie = linieTablica[i];
            if (string.IsNullOrWhiteSpace(linie))
            {
                Console.WriteLine($"{header} is empty");
                continue;
            }
            string[] pola = linie.Split(';');
            if (pola.Length != 5)
            {
                Console.WriteLine($"linia {i + 1} ma zlom liczbe pole: {linie}");
                continue;
            }

            string nick = pola[0];
            string czas = pola[1];
            string punktytekst = pola[2];
            string status = pola[3];
            string opis = pola[4];
            bool badtime = (czas == "00:00:01" || czas == "0:00:01");
            bool haker = (status == "HACKER" || badtime);
            if (haker)
            {
                Console.WriteLine($"{nick} is haker wynik: {czas}");
                continue;
            }

            int punkty;
            if (!int.TryParse(punktytekst, out punkty))
            {
                punkty = 0;
            }

            string nowalinia = $"{nick};{czas};{punkty};{status};{opis}";
            wynik.Add(nowalinia);
        }
        File.WriteAllLines(output, wynik);

        string[] nowelinie = File.ReadAllLines(output);
        foreach (string linia in nowelinie)
        {
            Console.WriteLine(linia);


        }

    }
}