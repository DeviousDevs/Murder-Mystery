using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item 
{
   public enum ItemType
    {
        Key,
        Glass,
        Gun
    }


    public ItemType itemType;
    public int amount;

    public Sprite GetSprite()
    {
        switch (itemType)
        {
            default:
            case ItemType.Key:      return ItemAssets.Instance.Item_Key;
            case ItemType.Gun:      return ItemAssets.Instance.Item_Gun;
            case ItemType.Glass:    return ItemAssets.Instance.Item_Glass;

        }
    }

    
}
