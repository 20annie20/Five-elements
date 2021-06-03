using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Player: MonoBehaviour
{
    private Rigidbody2D rb;
    private float moveH, moveV;
    [SerializeField] private float moveSpeed = 6.0f;
    public Joystick joystick;
    Statistics stats;
    
    private void Awake()
    {
        stats = UnityEngine.Object.FindObjectOfType<Statistics>();
        rb = GetComponent<Rigidbody2D>();
        moveSpeed = stats.GetSpeed();
        stats.SetKey(false);
        stats.SetHealth(stats.GetGeneralHealth());
    }

    private void Update()
    {
        if(Math.Abs(joystick.Horizontal) >= .2f || Math.Abs(joystick.Vertical) >= .2f ) {
            moveH = joystick.Horizontal * moveSpeed;
            moveV = joystick.Vertical * moveSpeed;
        } else {
            moveH = 0;
            moveV = 0;
        }        

        rb.velocity = new Vector2(moveH, moveV);
        
        Vector2 direction = new Vector2(moveH, moveV);
        FindObjectOfType<PlayerAnimation>().SetDirection(direction);

        if(stats.GetHealth() == 0)
        {
            Debug.Log("You died!");
            UnityEngine.Object.FindObjectOfType<Canvas>().GetComponentInChildren<UIscript>().RestartLevel();
        }
    }
}