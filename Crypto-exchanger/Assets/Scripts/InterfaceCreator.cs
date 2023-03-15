using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InterfaceCreator : MonoBehaviour
{
    [SerializeField] private CurrencieData dobbner;
    [SerializeField] private CurrencieData krokens;
    [SerializeField] private CurrencieData ukht;
    [SerializeField] private GameObject cellBuyPrefab;
    [SerializeField] private GameObject cellSellPrefab;

    private CurrencieData[] _currencieDatas;

    void Start()
    {
        _currencieDatas = new CurrencieData[] {krokens, dobbner, ukht };
        for (int i = 0; i < 3; i++)
        {
            GameObject obj = Instantiate(cellBuyPrefab, transform);
            Cell objCell = obj.GetComponent<Cell>();
            objCell.nameText.text = _currencieDatas[i].name;
            objCell.costText.text = $"{(_currencieDatas[i].minCost + _currencieDatas[i].maxCost)/ 2}";
            objCell.icon.sprite = _currencieDatas[i].icon;
        }

        for (int i = 0; i < 3; i++)
        {
            GameObject obj = Instantiate(cellSellPrefab, transform);
            Cell objCell = obj.GetComponent<Cell>();
            objCell.nameText.text = _currencieDatas[i].name;
            objCell.costText.text = "0";
            objCell.icon.sprite = _currencieDatas[i].icon;
        }
    }

    void Update()
    {
        
    }


}
