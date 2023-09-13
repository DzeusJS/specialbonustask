// See https://aka.ms/new-console-template for more information
using System.ComponentModel.DataAnnotations;

Console.WriteLine("Hello, World!");
//assuming years are always 2 digits and fromYear is less than toYear
printBonusDatesBetween(2000, 2015);
 static void printBonusDatesBetween(int fromYear, int toYear)
{
    int[] intervalas = new int[(toYear-fromYear)+1];
    int j=0;
    for(int i = fromYear; i <= toYear; i++)
    {
        intervalas[j] = i;
        j++;
    }
    string[] intervalas2 = new string[intervalas.Length-1];

    for(int i=0; i < intervalas.Length-1; i++)
    {
        intervalas2[i] = intervalas[i].ToString();
    }
    string[] atvirkscias = new string[intervalas.Length-1];
    for (int i = 0; i < intervalas2.Length - 1; i++)
    {
        atvirkscias[i] = new string(intervalas2[i].ToCharArray().Reverse().ToArray());
    }
    for (int i = 0; i < intervalas2.Length-1; i++)
    {
        if (Int64.Parse(atvirkscias[i]) <= 1231)
        {
            if (intervalas2[i][0] == atvirkscias[i][3]
          && intervalas2[i][1] == atvirkscias[i][2]
          && intervalas2[i][2] == atvirkscias[i][1]
          && intervalas2[i][3] == atvirkscias[i][0])
            {
                Console.WriteLine(intervalas2[i] + '-' + atvirkscias[i]);
            }
        }
      
    }
}

//metu intervala placinu i array
//splittinu array i skaicius
//splittinu skaicius po viena skaiciu
//for ciklas praeinantis pro raides is kaires i desine
//reverse
//limitas menesis 12, diena 31

// metai-menesis-diena
// 2010-01-02
// max  1321-12-31 // negali apverstas array but daugiau uz 12-31
