﻿double numeroum;
double numerodois;
double numerotres;

    Console.WriteLine("");
    Console.WriteLine("descubra sua média de 3 numeros!");
    Console.WriteLine("");
    Console.WriteLine("digite um numero");
        numeroum = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("digite outro numero");
        numerodois = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("digite mais um numero");
        numerotres = Convert.ToDouble(Console.ReadLine());
double media;
        media = (numeroum + numerodois + numerotres) / 3;
    Console.WriteLine($"sua média é de {media}");
    Console.WriteLine("");