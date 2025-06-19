// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

using System;
using System.Diagnostics;

class Program
{
    static void Main()
    {
        var forecaster = new FinancialForecaster();
        double initialValue = 1000; 
        double growthRate = 0.05; 
        int periods = 10;           

        double recursiveResult = forecaster.ForecastValueRecursive(initialValue, growthRate, periods);
        Console.WriteLine($"Recursive Forecast: {recursiveResult:F2}");
        
        double optimizedResult = forecaster.ForecastValueOptimized(initialValue, growthRate, periods);
        Console.WriteLine($"Optimized Forecast: {optimizedResult:F2}");

        ComparePerformance(forecaster, initialValue, growthRate, periods);
    }

    static void ComparePerformance(FinancialForecaster forecaster, double initial, double rate, int periods)
    {
        const int Iterations = 10000;
        var stopwatch = new Stopwatch();
        stopwatch.Start();
        for (int i = 0; i < Iterations; i++)
        {
            forecaster.ForecastValueRecursive(initial, rate, periods);
        }
        stopwatch.Stop();
        Console.WriteLine($"Recursive Time: {stopwatch.ElapsedMilliseconds}ms");
        stopwatch.Restart();
        for (int i = 0; i < Iterations; i++)
        {
            forecaster.ForecastValueOptimized(initial, rate, periods);
        }
        stopwatch.Stop();
        Console.WriteLine($"Optimized Time: {stopwatch.ElapsedMilliseconds}ms");
    }
}

