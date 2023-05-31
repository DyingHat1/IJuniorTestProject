using System;

public class CoinsCollector
{
    public int CoinsCount { get; private set; }

    public event Action<int> CountChanged;

    public CoinsCollector ()
    {
        CoinsCount = 0;
    }

    public void AddCoin()
    {
        CoinsCount++;
        CountChanged?.Invoke(CoinsCount);
    }
}
