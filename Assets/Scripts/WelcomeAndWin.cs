using UnityEngine;


public class WelcomeAndWin : MonoBehaviour
{
    public Achievement achievement;

    void Start()
    {
        achievement = FindObjectOfType<Achievement>();
    }

    
    void Update()
    {
        if (achievement.sliderCountScorpions.value==1000 && achievement.sliderCountSnakes.value==1000 && achievement.sliderCountSpiders.value==1000)
        {
            GameObject.Find("WinParent").transform.GetChild(0).gameObject.SetActive(true);
        }
    }
    

    public void WelcomePanel()
    {
        GameObject.Find("PanelWelcome").gameObject.SetActive(false); 
    }
}
