using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wallet
{
    private int _amountOFSchirsh;
    private int _amountOFDobbner;
    private int _amountOFKrokens;
    private int _amountOFUkht;

    public Wallet(int amountOFSchirsh)
    {
        _amountOFSchirsh = amountOFSchirsh;
        _amountOFDobbner = 0;
        _amountOFKrokens = 0;
        _amountOFUkht = 0;
    }
}
