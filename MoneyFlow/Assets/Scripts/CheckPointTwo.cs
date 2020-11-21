using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class CheckPointTwo : MonoBehaviour
{
    GameObject Money;
    GameObject EndPoint;
    GameObject camera;
    VideoPlayer colors;
    EndPoint endPointScript;
    

    SpriteRenderer moneySprite;
    SpriteRenderer checkSpriteRenderer;

    [SerializeField] Sprite bills;
    [SerializeField] Sprite bullets;
    [SerializeField] Sprite cheque;
    [SerializeField] Sprite chequera;
    [SerializeField] Sprite credit;
    [SerializeField] Sprite coin;
    [SerializeField] Sprite dollar;
    [SerializeField] Sprite euro;
    [SerializeField] Sprite yen;
    [SerializeField] Sprite pound;
    [SerializeField] Sprite time;
    [SerializeField] Sprite groceries;
    [SerializeField] Sprite bloodCoin;
    [SerializeField] Sprite bag;
    [SerializeField] Sprite change;


    [SerializeField] Sprite alcoholGreen;
    [SerializeField] Sprite chinaGreen;
    [SerializeField] Sprite clockGreen;
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
        camera = GameObject.Find("Video Player");

        moneySprite = Money.GetComponent<SpriteRenderer>();
        checkSpriteRenderer = GetComponent<SpriteRenderer>();
        colors = camera.GetComponent<VideoPlayer>();

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
                    moneySprite.sprite = yen;
                    checkSpriteRenderer.sprite = chinaGreen;
                    endPointScript.pointsCounter++;
                    break;
                case "clock":
                    moneySprite.sprite = coin;
                    checkSpriteRenderer.sprite = clockGreen;
                    endPointScript.pointsCounter++;
                    break;
                case "dead":
                    moneySprite.sprite = bloodCoin;
                    checkSpriteRenderer.sprite = deadGreen;
                    endPointScript.pointsCounter++;
                    break;
                case "factory":
                    colors.Stop();
                    moneySprite.sprite = bag;
                    checkSpriteRenderer.sprite = factoryGreen;
                    endPointScript.pointsCounter++;
                    break;
                case "farm":
                    moneySprite.sprite = credit;
                    checkSpriteRenderer.sprite = farmGreen;
                    endPointScript.pointsCounter++;
                    break;
                case "food":
                    moneySprite.sprite = change;
                    checkSpriteRenderer.sprite = foodGreen;
                    endPointScript.pointsCounter++;
                    break;
                case "guns":
                    moneySprite.sprite = bullets;
                    checkSpriteRenderer.sprite = gunsGreen;
                    endPointScript.pointsCounter++;
                    break;
                case "health":
                    moneySprite.sprite = dollar;
                    checkSpriteRenderer.sprite = healthGreen;
                    endPointScript.pointsCounter++;
                    break;
                case "london":
                    moneySprite.sprite = pound;
                    checkSpriteRenderer.sprite = londonGreen;
                    endPointScript.pointsCounter++;
                    break;
                case "marijuana":
                    moneySprite.sprite = cheque;
                    checkSpriteRenderer.sprite = marijuanaGreen;
                    endPointScript.pointsCounter++;
                    colors.Play();
                    break;
                case "politics":
                    moneySprite.sprite = bills;
                    checkSpriteRenderer.sprite = politicsGreen;
                    endPointScript.pointsCounter++;
                    break;
                case "thief":
                    moneySprite.sprite = coin;
                    checkSpriteRenderer.sprite = thiefGreen;
                    endPointScript.pointsCounter++;
                    break;
                case "working":
                    moneySprite.sprite = time;
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
