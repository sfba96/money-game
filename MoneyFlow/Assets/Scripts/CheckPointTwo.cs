using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPointTwo : MonoBehaviour
{
    GameObject Money;
    GameObject EndPoint;
    EndPoint endPointScript;

    SpriteRenderer moneySprite;
    SpriteRenderer checkSpriteRenderer;

    Sprite dollar;
    [SerializeField] Sprite bills;
    [SerializeField] Sprite cheque;
    [SerializeField] Sprite chequera;
    [SerializeField] Sprite credit;
    [SerializeField] Sprite coin;
    [SerializeField] Sprite euro;
    [SerializeField] Sprite yen;
    [SerializeField] Sprite pound;
    [SerializeField] Sprite time;
    [SerializeField] Sprite groceries;


    [SerializeField] Sprite alcoholGreen;
    [SerializeField] Sprite chinaGreen;
    [SerializeField] Sprite deadGreen;
    [SerializeField] Sprite factoryGreen;
    [SerializeField] Sprite farmGreen;
    [SerializeField] Sprite foodGreen;
    [SerializeField] Sprite gunsGreen;
    [SerializeField] Sprite healthGreen;
    [SerializeField] Sprite londonGreen;
    [SerializeField] Sprite marijuanaGreen;
    [SerializeField] Sprite politicsGreen;
    [SerializeField] Sprite thiefGreen;
    [SerializeField] Sprite workingGreen;

    string spriteName;



    // Start is called before the first frame update
    void Start()
    {
        Money = GameObject.Find("Money");
        EndPoint = GameObject.Find("EndPoint");

        moneySprite = Money.GetComponent<SpriteRenderer>();
        checkSpriteRenderer = GetComponent<SpriteRenderer>();
        dollar = Money.GetComponent<SpriteRenderer>().sprite;

        endPointScript = EndPoint.GetComponent<EndPoint>();

        spriteName = checkSpriteRenderer.sprite.name;

        endPointScript.pointsCounter = 0;

    }

    // Update is called once per frame
    void Update()
    {
        spriteName = checkSpriteRenderer.sprite.name;
    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Money")
        {
            switch (spriteName)
            {

                case "alcohol":
                    moneySprite.sprite = credit;
                    checkSpriteRenderer.sprite = alcoholGreen;
                    endPointScript.pointsCounter++;
                    break;
                case "china":
                    checkSpriteRenderer.sprite = chinaGreen;
                    endPointScript.pointsCounter++;
                    break;
                case "dead":
                    moneySprite.sprite = chequera;
                    checkSpriteRenderer.sprite = deadGreen;
                    endPointScript.pointsCounter++;
                    break;
                case "factory":
                    moneySprite.sprite = euro;
                    checkSpriteRenderer.sprite = factoryGreen;
                    endPointScript.pointsCounter++;
                    break;
                case "farm":
                    moneySprite.sprite = cheque;
                    checkSpriteRenderer.sprite = farmGreen;
                    endPointScript.pointsCounter++;
                    break;
                case "food":
                    checkSpriteRenderer.sprite = foodGreen;
                    endPointScript.pointsCounter++;
                    break;
                case "guns":
                    moneySprite.sprite = bills;
                    checkSpriteRenderer.sprite = gunsGreen;
                    endPointScript.pointsCounter++;
                    break;
                case "health":
                    moneySprite.sprite = coin;
                    checkSpriteRenderer.sprite = healthGreen;
                    endPointScript.pointsCounter++;
                    break;
                case "london":
                    moneySprite.sprite = coin;
                    checkSpriteRenderer.sprite = londonGreen;
                    endPointScript.pointsCounter++;
                    break;
                case "marijuana":
                    moneySprite.sprite = coin;
                    checkSpriteRenderer.sprite = marijuanaGreen;
                    endPointScript.pointsCounter++;
                    break;
                case "politics":
                    moneySprite.sprite = coin;
                    checkSpriteRenderer.sprite = politicsGreen;
                    endPointScript.pointsCounter++;
                    break;
                case "thief":
                    moneySprite.sprite = coin;
                    checkSpriteRenderer.sprite = thiefGreen;
                    endPointScript.pointsCounter++;
                    break;
                case "working":
                    moneySprite.sprite = coin;
                    checkSpriteRenderer.sprite = workingGreen;
                    endPointScript.pointsCounter++;
                    break;
                default:
                    moneySprite.sprite = moneySprite.sprite;
                    break;
            }
        }
    }
}
