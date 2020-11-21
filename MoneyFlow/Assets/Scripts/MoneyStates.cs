using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoneyStates : MonoBehaviour
{
    [Min(0)] public float DelayBeforeFade = 3;
    [Min(0.01f)] public float FadeDuration = 5;
    [SerializeField] AudioSource checkPoint;
    [SerializeField] GameObject message;
    MoneyMovement moneyMovement;
    SpriteRenderer moneySprite;
    public float alpha;
    private float delay;
    public bool cont = false;
    public bool movementAllowed = true;

    // Start is called before the first frame update
    void Start()
    {
        moneyMovement = GetComponent<MoneyMovement>();
        moneySprite = GetComponent<SpriteRenderer>();
        alpha = moneySprite.color.a;
        delay = DelayBeforeFade;

    }

    // Update is called once per frame
    void Update()
    {

        Devalue();

        

    }

    void Devalue()
    {
        if (moneyMovement.isMoving)
        {
            alpha = 1f;
            delay = DelayBeforeFade;
        }
        else if (delay <= 0)
        {
            alpha = Mathf.Max(alpha - Time.deltaTime / FadeDuration, 0);

        }
        else
        {
            delay -= Time.deltaTime;
        }

        moneySprite.color = new Color(moneySprite.color.r, moneySprite.color.g, moneySprite.color.b, alpha);

        if (alpha == 0 && cont == false)
        {
            message.SetActive(true);
            movementAllowed = false;
        } else if (cont == true)
        {
            message.SetActive(false);
            alpha = 1f;
            movementAllowed = true;
            cont = false;
        }
    }

    

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "CheckPoint")
        {
            checkPoint.Play(0);
        }
    }

    public void Continue()
    {
        cont = true;

    }

}
