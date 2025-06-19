// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

using System;
using System.Diagnostics;
using System.Linq;

class Program
{
    static void Main()
    {

        Product[] products = {
            new Product(100, "Laptop", "Electronics"),
            new Product(205, "T-Shirt", "Clothing"),
            new Product(310, "Blender", "Kitchen"),
            new Product(422, "Novel", "Books"),
            new Product(578, "Smartphone", "Electronics")
        };

        Product[] sortedProducts = products.OrderBy(p => p.ProductId).ToArray();

        int targetId = 310;

        //Recheck the below code(might be wrong)
        var linearResult = SearchOp.LinearSearch(products, targetId);
        Console.WriteLine($"Linear Search Found: {linearResult?.ProductName}");

        var binaryResult = SearchOp.BinarySearch(sortedProducts, targetId);
        Console.WriteLine($"Binary Search Found: {binaryResult?.ProductName}");

        CompareSearchPerformance(products, sortedProducts);
    }

    static void CompareSearchPerformance(Product[] unsorted, Product[] sorted)
    {
        const int Iterations = 100000;
        var random = new Random();
        var stopwatch = new Stopwatch();

        stopwatch.Start();
        for (int i = 0; i < Iterations; i++)
        {
            int randomId = unsorted[random.Next(unsorted.Length)].ProductId;
            SearchOp.LinearSearch(unsorted, randomId);
        }
        stopwatch.Stop();
        Console.WriteLine($"Linear Search Time: {stopwatch.ElapsedMilliseconds}ms");

        stopwatch.Restart();
        for (int i = 0; i < Iterations; i++)
        {
            int randomId = sorted[random.Next(sorted.Length)].ProductId;
            SearchOp.BinarySearch(sorted, randomId);
        }
        stopwatch.Stop();
        Console.WriteLine($"Binary Search Time: {stopwatch.ElapsedMilliseconds}ms");
    }
}

