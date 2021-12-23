using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectController : MonoBehaviour
{
    public ScoreTextController _ScoreTextController;
    // Start is called before the first frame update
    void Start()
    {
        _ScoreTextController = FindObjectOfType<ScoreTextController>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        _ScoreTextController.addScore();
        Destroy(gameObject);
    }
}
