using UnityEngine;
using TMPro;

public class CoinsCollectorVisualiser : MonoBehaviour
{
    [SerializeField] private TMP_Text _coinsCounter;

    private CoinsCollector _collector;

    private void OnEnable()
    {
        _collector.CountChanged += OnCountChanged;
    }

    private void OnDisable()
    {
        _collector.CountChanged -= OnCountChanged;
    }

    public void Init(CoinsCollector collector)
    {
        _collector = collector;
        enabled = true;
        OnCountChanged(0);
    }

    private void OnCountChanged(int count)
    {
        _coinsCounter.text = count.ToString();
    }
}
