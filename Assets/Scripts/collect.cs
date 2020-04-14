using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collect : MonoBehaviour
{
    [SerializeField] private UI_Inventory uiInventory;
    private Inventory inventory;


    private void Awake()
    {
        //Instance = this;
        Debug.Log("awake");
        inventory = new Inventory();
        uiInventory.SetInventory(inventory);

        //will be able to randomize placement of items later

        ItemWorld.SpawnItemWorld(new Vector3(4, -4), new Item { itemType = Item.ItemType.Key, amount = 1 });
        ItemWorld.SpawnItemWorld(new Vector3(8, 5), new Item { itemType = Item.ItemType.Gun, amount = 1 });
        ItemWorld.SpawnItemWorld(new Vector3(-4, 1), new Item { itemType = Item.ItemType.Glass, amount = 1 });

    }


    private void OnTriggerEnter2D(Collider2D collider)
    {
        ItemWorld itemWorld = collider.GetComponent<ItemWorld>();
        if (itemWorld != null)
        {
            inventory.AddItem(itemWorld.GetItem());
            itemWorld.DestroySelf();
        }
        /*
        Debug.Log("object collected");
        if (collision.gameObject.tag == "Collectable")
        {

            //maybe look into dictionaries
            inventory[filled] = collision.gameObject;
            filled++;
            collision.gameObject.SetActive(false);
            Debug.Log("object collected");

        }
        */
    }
}
