using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "CurrencieData", menuName = "SO/NewCurrencieData")]
public class CurrencieData : ScriptableObject
{
    public string name;
    public int maxCost;
    public int minCost;
    public int updateTime;
    public Sprite icon;
    [Range(0f, 1f)]
    public float priceChangeFactor;
}