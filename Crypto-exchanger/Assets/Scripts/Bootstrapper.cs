using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bootstrapper : MonoBehaviour
{
    [SerializeField] private int amountOFSchirsh;

    private Wallet _wallet;

    void Start()
    {
        _wallet = new Wallet(amountOFSchirsh);
    }

    void Update()
    {
        
    }
}
