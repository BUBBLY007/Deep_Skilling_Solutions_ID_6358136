public class FinancialForecaster
{
    public double ForecastValueRecursive(double currentValue, double growthRate, int periods)
    {
        if (periods <= 0) 
            return currentValue;

        double nextValue = currentValue * (1 + growthRate);

        return ForecastValueRecursive(nextValue, growthRate, periods - 1);
    }

    public double ForecastValueOptimized(double currentValue, double growthRate, int periods)
    {
        return currentValue * Math.Pow(1 + growthRate, periods);
    }
}
