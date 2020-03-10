using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{

    public float speed = 5.0f;
    private Vector3 lastMovement;

    // Start is called before the first frame update
    void Start()
    {





    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector3 movement = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical")).normalized * speed * Time.deltaTime;

        lastMovement = movement;
        //transform.position += movement;
        transform.Translate(movement);



    }



}
