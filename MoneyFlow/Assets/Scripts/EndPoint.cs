using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class EndPoint : MonoBehaviour
{
    SpriteRenderer endPointRenderer;
    public int pointsCounter;


    // Start is called before the first frame update
    void Start()
    {
        endPointRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {

        if (pointsCounter == 8 && SceneManager.GetActiveScene().buildIndex == 1)
        {
            endPointRenderer.color = new Color(0, 1, 0, 1);
        } else if (pointsCounter == 13 && SceneManager.GetActiveScene().buildIndex == 2)
        {
            endPointRenderer.color = new Color(0, 1, 0, 1);
        }

        Debug.Log(pointsCounter);
    }
}
