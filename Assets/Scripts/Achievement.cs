using UnityEngine;
using UnityEngine.UI;

public class Achievement : MonoBehaviour
{
    private GameObject panelAchievement;

    public Slider sliderCountScorpions;
    public Slider sliderCountSpiders;
    public Slider sliderCountSnakes;

    private Coins coins;

    void Start()
    {
        FindSliderCountScorpions();
        FindSliderCountSpiders();
        FindSliderCountSnakes();

        coins = FindObjectOfType<Coins>();

    }

    private void FindSliderCountScorpions()
    {
        sliderCountScorpions = GameObject.Find("ButtonAchievementActive").transform.GetChild(1).gameObject.transform.GetChild(0).GetComponent<Slider>();
    }
    private void FindSliderCountSpiders()
    {
        sliderCountSpiders = GameObject.Find("ButtonAchievementActive").transform.GetChild(1).gameObject.transform.GetChild(1).GetComponent<Slider>();
    }
    private void FindSliderCountSnakes()
    {
        sliderCountSnakes = GameObject.Find("ButtonAchievementActive").transform.GetChild(1).gameObject.transform.GetChild(2).GetComponent<Slider>();
    }
    public void CountScorpions()
    {
        
        sliderCountScorpions.value += 1f;
        
    }

    public void CountSpider()
    {
        
        sliderCountSpiders.value += 1f;
        
    }
    public void CountSnakes()
    {

        sliderCountSnakes.value += 1f;
    }

    public void AddCoinScorpions()
    {
        if (sliderCountScorpions.value % 5 == 0)
        {
            coins.numberCoins += 5;
        }
        

    }
    public void AddCoinSpiders()
    {
        if (sliderCountSpiders.value %5==0)
        {
            coins.numberCoins += 10;
        }
        

    }
    public void AddCoinSnakes()
    {
        if (sliderCountSnakes.value % 5 == 0)
        {
            coins.numberCoins += 15;
        }
        

    }

    public void ActivePanel()
    {
        panelAchievement = GameObject.Find("ButtonAchievementActive").transform.GetChild(1).gameObject;
        panelAchievement.SetActive(true);
    }
    public void ExitPanel()
    {
        panelAchievement = GameObject.Find("ButtonAchievementActive").transform.GetChild(1).gameObject;
        panelAchievement.SetActive(false);
    }

   
}
