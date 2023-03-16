using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Cell : MonoBehaviour
{
    public Image icon;
    public TextMeshProUGUI nameText;
    public TextMeshProUGUI costText;
    public CurrencieData currencieData;

    private int _currentCost;

    private void Start()
    {
        _currentCost = (currencieData.minCost + currencieData.maxCost) / 2;
        costText.text = $"{_currentCost}";
        StartCoroutine(StartExchanger());
    }

    IEnumerator StartExchanger()
    {
        yield return new WaitForSeconds(currencieData.updateTime);
        CountCost(_currentCost, out _currentCost);
        costText.text = $"{_currentCost}";
        StartCoroutine(StartExchanger());
    }

    private void CountCost(int pastCost,out int currentCost)
    {
        int rndCost = Random.Range(currencieData.minCost, currencieData.maxCost);
        currentCost = rndCost - pastCost;
        currentCost *= (int)currencieData.priceChangeFactor;
        currentCost += pastCost;
    }
}
