using System;
using Slider;
using UnityEngine;

public class ConcurrencyController : MonoBehaviour
{
    public static ConcurrencyController Instance;
    public int maxGem;
    public int maxCoin;
    public SliderController gemSlider;
    public SliderController coinSlider;

    private void Awake()
    {
        if (Instance != null) return;
        Instance = this;
    }
    

    private void Update()
    {
        gemSlider.SetMaxValue(maxGem);
        coinSlider.SetMaxValue(maxCoin);
    }

    public bool AddConcurrency(int gem, int coin)
    {
        if (User.Gem + gem > maxGem || User.Coin + coin > maxCoin) return false;
        User.Gem += gem;
        User.Coin += coin;
        gemSlider.UpdateSlider(gem);
        coinSlider.UpdateSlider(coin);
        return true;
    }
}