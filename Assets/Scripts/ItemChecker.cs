using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemChecker 
{
    public event EventHandler OnItemListChanged;

    int itemAmt;


    public ItemChecker()
    {
        itemAmt = 0;
    }

    public int getAmt()
    {
        return itemAmt;
    }

    private void itemAdded()
    {
        itemAmt++;
        Debug.Log("item added" + itemAmt); ;
        OnItemListChanged?.Invoke(this, EventArgs.Empty);
        
    }
}
