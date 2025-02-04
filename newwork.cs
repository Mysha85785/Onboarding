using System;
using System.Collections.Generic;

public class Product
{
    public string Name { get; set; }
    public int Quantity { get; set; }
    public string Quality { get; set; }

    public Product(string name, int quantity, string quality)
    {
        Name = name;
        Quantity = quantity;
        Quality = quality;
    }

    public override string ToString()
    {
        return $"{Name}, Количество: {Quantity}, Качество: {Quality}";
    }
}

class Program
{
    static void Main()
    {
        // Список продуктов
        List<Product> products = new List<Product>
        {
            new Product("Яблоки", 50, "Высокое"),
            new Product("Молоко", 20, "Среднее"),
            new Product("Хлеб", 100, "Высокое"),
            new Product("Мясо", 10, "Низкое"),
            new Product("Картофель", 70, "Среднее")
        };

        // Сортировка по количеству
        products.Sort((p1, p2) => p1.Quantity.CompareTo(p2.Quantity));

        // Вывод отсортированного списка по количеству
        Console.WriteLine("Продукты, отсортированные по количеству:");
        foreach (var product in products)
        {
            Console.WriteLine(product);
        }

        Console.WriteLine();

        // Сортировка по качеству
        // Для сортировки качества мы будем использовать приоритет: "Высокое" > "Среднее" > "Низкое"
        products.Sort((p1, p2) => 
        {
            var qualityOrder = new Dictionary<string, int>
            {
                { "Высокое", 3 },
                { "Среднее", 2 },
                { "Низкое", 1 }
            };

            return qualityOrder[p2.Quality].CompareTo(qualityOrder[p1.Quality]);
        });

        // Вывод отсортированного списка по качеству
        Console.WriteLine("Продукты, отсортированные по качеству:");
        foreach (var product in products)
        {
            Console.WriteLine(product);
        }
    }
}
