using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Balll : MonoBehaviour
{

    public GameManager gameManager;
    public Rigidbody2D Ballphy;
    public float speed = 3f;
    public float criticalangle = 0.72f;
    public float initialX = 0f;
    public float initialY = 5.5f;
    public float multiplier = 1.05f;

    private void Start()
    {
        Spawn();
    }

    private void Spawn()
    {
        Vector2 angle = Vector2.left;

        if (Random.value < 0.5f)
        {
            angle = Vector2.right;
        }


        angle.y = Random.Range(-criticalangle, criticalangle);

        Ballphy.velocity = angle * speed;
    }

    private void Resetball()
    {
        float posY = Random.Range(-initialY, initialY);
        Vector2 position = new Vector2(initialX, posY);
        transform.position = position;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Scorezone limit = collision.GetComponent<Scorezone>();
        if (limit)
        {
            gameManager.OnScoreZoneReached(limit.id);
            Resetball();
            Spawn();
        }

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Bat bat = collision.collider.GetComponent<Bat>();
        if (bat)
        {
            Ballphy.velocity *= multiplier;
        }
    }
}
