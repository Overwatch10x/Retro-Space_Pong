using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bat : MonoBehaviour
{
    public Rigidbody2D rb2d;
    public int id;
    public float moveSpeed = 2f;

    private void Update()
    {
        float value = ProcessInput();
        Move(value);
    }
    private float ProcessInput()
    {
        float movement = 0f;
        switch (id)
        {
            case 1:
                movement = Input.GetAxis("MovePlayer1");
                break;

            case 2:
                movement = Input.GetAxis("MovePlayer2");
                break;

        }
        return movement;
    }

    private void Move(float value)
    {
        Vector2 velo = rb2d.velocity;
        velo.y = moveSpeed * value;
        rb2d.velocity = velo;

    }
}