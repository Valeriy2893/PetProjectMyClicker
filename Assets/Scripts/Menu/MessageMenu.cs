using UnityEngine;
using UnityEngine.UI;

public class MessageMenu : MonoBehaviour
{
    public Text messageTextMenu;
    public GameObject messageMenu;


    void Start()
    {
        messageMenu = GameObject.Find("MessageParentMenu").transform.GetChild(0).gameObject;
        messageTextMenu = messageMenu.GetComponent<Text>();

    }
    public void SetActiveFalseMenu()
    {
        messageMenu.SetActive(false);
        
    }

    public void SetActiveTrueMenu()
    {
        messageMenu.SetActive(true);
        
    }

    public void InitialiseMessageTextMenu(string text)
    {
        messageTextMenu.text = text;
    }
}
