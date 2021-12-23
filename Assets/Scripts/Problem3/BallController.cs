using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    private Rigidbody2D rigidBody2D;
    public float xInitialForce;
    public float yInitialForce;
    // Start is called before the first frame update
    void Start()
    {
        rigidBody2D = GetComponent<Rigidbody2D>();
        Invoke("PushBall", 1);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void PushBall()
    {
        rigidBody2D.AddForce(new Vector2(xInitialForce, yInitialForce));
    }
}
