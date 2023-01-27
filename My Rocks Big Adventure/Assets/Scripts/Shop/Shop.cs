using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Shop : MonoBehaviour
{
    public int lifePrice = 500;
    public int currentScore;
    public int currentLives;
    public int dashCdPrice = 500;
    public int cdSeconds;
    public int maxCdTimer = 1;
    public bool maxedCdTimer = false;

    public Score gameScore;
    public LivesKill Lives;
    public RockDash seconds;
    
    
    
    
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        currentScore = Score.score;
        currentLives = LivesKill.Lives;
        cdSeconds = RockDash.seconds;

       // if (cdSeconds == maxCdTimer)
          //  maxedCdTimer = true;

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Score.score += 5000;
        }
    }

    public void BuyLife()
    {
        if (currentScore >= lifePrice)
        {
            Score.score -= lifePrice;
            LivesKill.Lives += 1;
            lifePrice += lifePrice;
        }
    }

    public void BuyDashCd()
    {

        if (currentScore >= dashCdPrice)
        {
            Score.score -= dashCdPrice;
            RockDash.seconds--;
            dashCdPrice += dashCdPrice;
        }
        else
        {
            Debug.Log("i dont have enough score or Maxed out CD");
        }
    }
}
