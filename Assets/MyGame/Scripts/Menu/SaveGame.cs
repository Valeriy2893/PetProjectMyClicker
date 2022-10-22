//using System.IO;
using UnityEngine;

public class SaveGame : MonoBehaviour
{
    public string nameUser;
    public int finalyDamage;
    public int health;
    public int damage;
    public int armor;
    public int buyDamage;
    public int criticalDamage;
    public int chanceCriticalDamage;
    public int maxDamage;

    public int allMonster;

    public int numberCoins;

    public int countScorpions;
    public int countSpiders;
    public int countSnakes;

    public EnemyParameters enemyParameters;
    public EnemySpawner enemySpawner;
    public Coins coins;

    public Achievement achievement;


    private SceneLoader loadNameText;

    
    public string data;

    //private string path = "D:/save.txt";

    private void Start()
    {
        loadNameText = FindObjectOfType<SceneLoader>();
        nameUser = loadNameText.nameText;

        if (loadNameText.checkContinue)
        {

            Load();
        }
   

    }

    private void FindObject()
    {

        enemyParameters = FindObjectOfType<EnemyParameters>();
        enemySpawner = FindObjectOfType<EnemySpawner>();
        achievement=FindObjectOfType<Achievement>();
        coins = FindObjectOfType<Coins>();

        
    }

    public void CollectInfo()
    {
        countScorpions = (int)achievement.sliderCountScorpions.value;
        countSpiders = (int)achievement.sliderCountSpiders.value;
        countSnakes = (int)achievement.sliderCountSnakes.value;

        nameUser = loadNameText.nameText;
        finalyDamage = enemyParameters.finalyDamage;
        health = enemyParameters.health;
        armor = enemyParameters.armor;
        buyDamage = enemyParameters.buyDamage;
        criticalDamage = enemyParameters.criticalDamage;
        chanceCriticalDamage = enemyParameters.chanceCriticalDamage;
        maxDamage = enemyParameters.maxDamage;
        allMonster = enemySpawner.allMonster;
        numberCoins = coins.numberCoins;
    }

    public void SetInfo()
    {
        achievement.sliderCountScorpions.value = countScorpions;
        achievement.sliderCountSpiders.value = countSpiders;
        achievement.sliderCountSnakes.value = countSnakes;

        loadNameText.nameText = nameUser;
        enemyParameters.finalyDamage = finalyDamage;
        enemyParameters.health = health;
        enemyParameters.armor = armor;
        enemyParameters.buyDamage = buyDamage;
        enemyParameters.criticalDamage = criticalDamage;
        enemyParameters.chanceCriticalDamage = chanceCriticalDamage;
        enemyParameters.maxDamage = maxDamage;
        enemySpawner.allMonster = allMonster;
        coins.numberCoins = numberCoins;
    }

    public void Save()
    {
        FindObject();
        CollectInfo();
        data = JsonUtility.ToJson(this, true);
        PlayerPrefs.SetString("Parameters", data);
        
        //File.WriteAllText(path, data);


    }

    public void Load()
    {
        Invoke("FindObject", 0.1f);
        //data = File.ReadAllText(path);
        JsonUtility.FromJsonOverwrite(PlayerPrefs.GetString("Parameters"), this);
        Invoke("SetInfo", 0.1f);
    }

    private void OnApplicationPause()
    {
        PlayerPrefs.SetInt("FirstOpen", 1);
        Save();
    }
    private void OnApplicationQuit()
    {
        OnApplicationPause();
        
        
    }
    

}
