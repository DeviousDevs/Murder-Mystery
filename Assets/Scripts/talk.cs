using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class talk : MonoBehaviour
{


    [SerializeField] private Text text;
    [SerializeField] private Text name;
    [SerializeField] private GameObject Caroline;
    [SerializeField] private GameObject Alexandria;
    [SerializeField] private GameObject Drew;
    [SerializeField] private GameObject Hunter;
    [SerializeField] private GameObject Police;


    int itemAmt;

    private void Awake()
    {
        itemAmt = 0;
    }

    private void OnTriggerEnter2D(Collider2D collider)
    {
            
        if (collider.gameObject == Caroline)
        {
            name.text = "Caroline:";
            text.text = "''Hello!''";
        }
        if (collider.gameObject == Alexandria)
        {
            name.text = "Alexandria:";
            text.text = "''Hello!''";
        }
        if (collider.gameObject == Drew)
        {
            name.text = "Drew:";
            text.text = "''Hello!''";
        }
        if (collider.gameObject == Police)
        {
            name.text = "Police:";

            
            if (itemAmt < 1)
            {
                text.text = "''what are you doing?''";
                
            }
            if(itemAmt > 1)
            {
                text.text = "''wow! you found evidence!''";
            }
            else
            {
                text.text = "'...''";
            }
             

        }
        if (collider.gameObject == Hunter)
        {
            name.text = "Dead Hunter:";
            text.text = "''...''";
        }
        
    }

    public void itemAdded()
    {
        itemAmt++;
        Debug.Log("item added" + itemAmt); ;


    }



}

