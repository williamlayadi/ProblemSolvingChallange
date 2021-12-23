using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseInput : MonoBehaviour
{
    public float speed = 10;
    public Vector3 desiredPos;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 worldPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        worldPosition.z = 1;
        if (Input.GetMouseButtonDown(0))
        {
            desiredPos = worldPosition;
            
        }
        transform.position = Vector3.MoveTowards(transform.position, desiredPos, speed * Time.deltaTime);
    }
}
