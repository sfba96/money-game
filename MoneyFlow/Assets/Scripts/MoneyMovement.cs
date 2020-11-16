using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoneyMovement : MonoBehaviour
{
    [SerializeField] float speed;
    Rigidbody2D moneyRigidBody;
    SpriteRenderer moneySprite;
    public bool isMoving = false;

    // Start is called before the first frame update
    void Start()
    {
        moneyRigidBody = GetComponent<Rigidbody2D>();
        moneySprite = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        Move(); 
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
        } else if(moneySprite.sprite.name == "coin")
        {
            speed = 1;
        } else
        {
            speed = 4;
        }
    }
}
