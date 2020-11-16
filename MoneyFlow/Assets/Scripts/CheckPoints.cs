using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPoints : MonoBehaviour
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

    [SerializeField] Sprite atmGreen;
    [SerializeField] Sprite busGreen;
    [SerializeField] Sprite companyGreen;
    [SerializeField] Sprite parisGreen;
    [SerializeField] Sprite personGreen;
    [SerializeField] Sprite storeGreen;
    [SerializeField] Sprite tradingUpGreen;
    [SerializeField] Sprite tradingDownGreen;

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
                
                case "atm":
                    moneySprite.sprite = credit;
                    checkSpriteRenderer.sprite = atmGreen;
                    endPointScript.pointsCounter++;
                    break;
                case "bus":             
                    checkSpriteRenderer.sprite = busGreen;
                    endPointScript.pointsCounter++;
                    break;
                case "company":
                    moneySprite.sprite = chequera;
                    checkSpriteRenderer.sprite = companyGreen;
                    endPointScript.pointsCounter++;
                    break;
                case "paris":
                    moneySprite.sprite = euro;
                    checkSpriteRenderer.sprite = parisGreen;
                    endPointScript.pointsCounter++;
                    break;
                case "person":
                    moneySprite.sprite = cheque;
                    checkSpriteRenderer.sprite = personGreen;
                    endPointScript.pointsCounter++;
                    break;
                case "store":
                    checkSpriteRenderer.sprite = storeGreen;
                    endPointScript.pointsCounter++;
                    break;
                case "tradingUp":
                    moneySprite.sprite = bills;
                    checkSpriteRenderer.sprite = tradingUpGreen;
                    endPointScript.pointsCounter++;
                    break;
                case "tradingDown":
                    moneySprite.sprite = coin;
                    checkSpriteRenderer.sprite = tradingDownGreen;
                    endPointScript.pointsCounter++;
                    break;
                default:
                    moneySprite.sprite = moneySprite.sprite;
                    break;
            }
        }
    }
}
