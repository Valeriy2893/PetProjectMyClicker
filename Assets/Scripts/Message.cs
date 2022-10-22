using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Message : MonoBehaviour
{
    internal Text messageText;
    internal GameObject message;

   
    void Start()
    {
        message = GameObject.Find("MessageParent").transform.GetChild(0).gameObject;
        messageText = message.GetComponent<Text>();
        
    }
    public void SetActiveFalse()
    {
        message.SetActive(false);
    }
    
    public void SetActiveTrue()
    {
        message.SetActive(true);
    }

    public void InitialiseMessageText(string text)
    {
        messageText.text = text;
    }
}
