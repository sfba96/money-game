﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MoneyMovement : MonoBehaviour
{
    [SerializeField] float speed;
    [SerializeField] GameObject info;
    MoneyStates moneyStates;
    Rigidbody2D moneyRigidBody;
    SpriteRenderer moneySprite;
    public bool isMoving = false;
    public bool isActive = true;

    // Start is called before the first frame update
    void Start()
    {
        moneyRigidBody = GetComponent<Rigidbody2D>();
        moneySprite = GetComponent<SpriteRenderer>();
        moneyStates = GetComponent<MoneyStates>();
    }

    // Update is called once per frame
    void Update()
    {
        if (moneyStates.movementAllowed) { 
            Move();
        }

        hideArrows();
    }

    private void Move()
    {
        SetSpeed();
        float controlDirHorizontal = Input.GetAxis("Horizontal");
        float controlDirVertical = Input.GetAxis("Vertical");

        Vector2 moneyVel = new Vector2(controlDirHorizontal * speed, controlDirVertical * speed);

        moneyRigidBody.velocity = moneyVel;

        if (moneyRigidBody.velocity.x != 0 || moneyRigidBody.velocity.y != 0)
        {
            isMoving = true;
        } else
        {
            isMoving = false;
        }

        

    }

    private void SetSpeed()
    {
        if(moneySprite.sprite.name == "credit")
        {
            speed = 7;
        } else if(moneySprite.sprite.name == "coin" || moneySprite.sprite.name == "rustyDollar")
        {
            speed = 2;
        }
        else if (moneySprite.sprite.name == "pound")
        {
            speed = 3;
        }
        else if (moneySprite.sprite.name == "bloodCoin")
        {
            speed = 1;
        }
        else
        {
            speed = 4;
        }
    }

    private void hideArrows()
    {
        if(SceneManager.GetActiveScene().buildIndex == 1) { 
            if (Input.GetKeyDown(KeyCode.RightArrow) && isActive)
            {
                isActive = false;
                info.SetActive(false);
            }
        }
    }

}
