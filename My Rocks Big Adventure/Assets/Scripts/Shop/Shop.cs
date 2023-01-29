using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Shop : MonoBehaviour
{
    public int lifePrice = 500;
    public float currentScore;
    public int currentLives;
    public int dashCdPrice = 500;
    public int cdSeconds;
    public int maxCdTimer = 1;
    public bool maxedCdTimer = false;

    public Score gameScore;
    public LivesKill Lives;
    public RockDash rockDash;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        currentScore = gameScore.score;
        currentLives = LivesKill.Lives;
        cdSeconds = rockDash.seconds;

       // if (cdSeconds == maxCdTimer)
          //  maxedCdTimer = true;

        if (Input.GetKeyDown(KeyCode.Space))
        {
            gameScore.score += 5000;
        }
    }

    public void BuyLife()
    {
        if (currentScore >= lifePrice)
        {
            gameScore.score -= lifePrice;
            LivesKill.Lives += 1;
            lifePrice += lifePrice;
        }
    }

    public void BuyDashCd()
    {

        if (currentScore >= dashCdPrice)
        {
            if (cdSeconds >= maxCdTimer)
            {
                gameScore.score -= dashCdPrice;
                rockDash.seconds--;
                dashCdPrice += dashCdPrice;
            }
        }
    }
}
