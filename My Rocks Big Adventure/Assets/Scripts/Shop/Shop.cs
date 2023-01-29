using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Shop : MonoBehaviour
{
    public int lifePrice = 200;
    public float currentScore;
    public int currentLives;
    public int dashCdPrice = 200;
    public int cdSeconds;
    public int maxCdTimer = 1;
    public bool maxedCdTimer = false;

    public Text cdPrice;
    public Text livePrice;

    public Score gameScore;
    public LivesKill Lives;
    public RockDash rockDash;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }
    
    // Update is called once per frame.
    void Update()
    {
        //keeps track of score, rock dash cd and lives.
        currentScore = gameScore.score;
        currentLives = LivesKill.Lives;
        cdSeconds = rockDash.seconds;

        //Displays Prices.
        cdPrice.text = "Price:" + dashCdPrice.ToString();
        livePrice.text = "Price:" + lifePrice.ToString();

       // if (cdSeconds == maxCdTimer)
          //  maxedCdTimer = true;
        
          //cheat test, remove when finished.
        /*if (Input.GetKeyDown(KeyCode.Space))
        {
            gameScore.score += 5000;
        }*/
    }
    
    //This to buy lives in the shop.
    public void BuyLife()
    {
        if (currentScore >= lifePrice)
        {
            gameScore.score -= lifePrice;
            LivesKill.Lives += 1;
            lifePrice += lifePrice;
        }
    }
    
    //This to reduce the dash cd.
    public void BuyDashCd()
    {
            //This checks if there is enough score to buy a cooldown.
        if (currentScore >= dashCdPrice)
        {
            //This checks if the player has reached the max cooldown timer.
            if (cdSeconds >= maxCdTimer && rockDash.onCooldown == false)
            {
                //Then takes of the score, reduces the seconds by 1 and double the price.
                gameScore.score -= dashCdPrice;
                rockDash.seconds--;
                dashCdPrice += dashCdPrice;
            }
        }
    }
}
