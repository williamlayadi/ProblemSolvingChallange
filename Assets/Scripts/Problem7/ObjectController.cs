using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectController : MonoBehaviour
{
    public ScoreTextController _ScoreTextController;
    public AudioClip hitClip;
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
        var spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
        spriteRenderer.enabled = false;
        var boxCollider = gameObject.GetComponent<BoxCollider2D>();
        boxCollider.enabled = false;
        //hit music
        gameObject.GetComponent<AudioSource>().PlayOneShot(hitClip);
        //respawning
        StartCoroutine(startRespawning());
    }
    private IEnumerator startRespawning()
    {
        yield return new WaitForSeconds(3);
        float x = Random.Range((float)-7.5, (float)7.5);
        float y = Random.Range((float)-3.5, (float)3.5);
        //cek posisi biar tidak tabrakan dengan player
        Vector3 playerPos = GameObject.FindGameObjectWithTag("Player").transform.position;
        while(x == playerPos.x && y == playerPos.y)
        {
            x = Random.Range((float)-7.5, (float)7.5);
            y = Random.Range((float)-3.5, (float)3.5);
        }
        //ganti posisi
        Vector3 newPos = new Vector3(x, y, 1);
        transform.position = newPos;
        var spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
        spriteRenderer.enabled = true;
        var boxCollider = gameObject.GetComponent<BoxCollider2D>();
        boxCollider.enabled = true;
    }
}
