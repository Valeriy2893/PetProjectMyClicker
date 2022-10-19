using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;



public class SceneLoader : MonoBehaviour
{
    private InputField namePlayer;
    private GameObject namePanel;
    public string nameText;
    public  bool checkContinue;

    private MessageMenu messageMenu;
    private void Start()
    {
        
        namePanel = GameObject.Find("ButtonStart").transform.GetChild(1).gameObject;
        DontDestroyOnLoad(this);
        NameText();
        messageMenu=FindObjectOfType<MessageMenu>();


    }
    public void NameText()
    {
        
        namePlayer = namePanel.transform.GetChild(0).GetComponent<InputField>();
        nameText = namePlayer.text;
    }


    
    public void ExitGame()
    {
        Application.Quit();
    }

    public void SavePlayer()
    {
        if (namePlayer.text.Length >= 2 && namePlayer.text.Length <= 15)
        {
            
            SceneManager.LoadScene(1);
            
        }
        else
        {
            messageMenu.SetActiveTrueMenu();
            messageMenu.InitialiseMessageTextMenu("Введите имя больше трёх символов, но меньше 16");
            messageMenu.Invoke("SetActiveFalseMenu",2);
        }
    }
    public void Continue()
    {
        if (PlayerPrefs.GetInt("FirstOpen", 0) == 0)
        {
            messageMenu.SetActiveTrueMenu();
            messageMenu.InitialiseMessageTextMenu("Не найдено загрузок");
            messageMenu.Invoke("SetActiveFalseMenu", 2);
        }
        else
        {
            SceneManager.LoadScene(1);
            checkContinue = true;

        }
    }
    
    

    


 }




