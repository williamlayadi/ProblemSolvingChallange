using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyboardInput : MonoBehaviour
{
    public int speed = 10;
    public bool usingRigidbody = false;


    public void Move()
    {

        Vector3 Movement = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"),0 );

        transform.position += Movement * speed * Time.deltaTime;

    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (usingRigidbody)
        {
            Rigidbody2D rb = GetComponent<Rigidbody2D>();
            if (Input.GetKey(KeyCode.A))
                rb.AddForce(Vector3.left);
            if (Input.GetKey(KeyCode.D))
                rb.AddForce(Vector3.right);
            if (Input.GetKey(KeyCode.W))
                rb.AddForce(Vector3.up);
            if (Input.GetKey(KeyCode.S))
                rb.AddForce(Vector3.down);
        }
        else
        {
            Move();
        }

        
    }
}
