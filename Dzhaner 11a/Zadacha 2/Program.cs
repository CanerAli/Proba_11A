﻿namespace ZadachiZaPregovor
{
    internal class StartUP
    {
        static void Zadazha2()
        {
            double filmBudget = double.Parse(Console.ReadLine());
            int countStatist = int.Parse(Console.ReadLine());
            double priceForClothing = double.Parse(Console.ReadLine());
            double decoration = filmBudget * (10 / 100);
            double totalCostForClothing = priceForClothing * countStatist;
            // double priceTotalForClothingAndDecoration = priceForClothing + decoration;
            if (countStatist > 150)
            {
                totalCostForClothing = totalCostForClothing * 0.9;


            }
            else if (filmBudget < priceForClothing + decoration)
            {
                Console.WriteLine($"Not enough money!");
                Console.WriteLine($"Wingard needs {filmBudget - priceTotalForClothingAndDecoration} leva more.");
            }
            else if (priceForClothing + decoration <= filmBudget)
            {
                Console.WriteLine("Action!");
                Console.WriteLine($"Wingard starts filming with {totalLeft} leva left.");

            }
            double totalLeft = filmBudget - priceTotalForClothingAndDecoration;
        }
    }
}