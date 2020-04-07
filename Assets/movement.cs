using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{

    public float speed = 5.0f;
    private Vector3 lastMovement;
    private GameObject[] inventory;
    private int filled;
    // Start is called before the first frame update
    void Start()
    {
        inventory = new GameObject[30];
        filled = 0;



    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector3 movement = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical")).normalized * speed * Time.deltaTime;

        lastMovement = movement;
        //transform.position += movement;
        transform.Translate(movement);



    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Collectable")
        {
            //maybe look into dictionaries
            inventory[filled] = collision.gameObject;
            filled++;
            collision.gameObject.SetActive(false);
        }
    }

}
