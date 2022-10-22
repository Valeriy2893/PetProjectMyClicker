using UnityEngine;
using UnityEngine.UI;

public class Display : MonoBehaviour
{
    internal Text hPMonster;
    internal Text armorMonster;
    internal Text level;
    internal Text finalyDamage;
    internal Text textNumberCoins;
    internal Text nameUser;
    internal Text criticalDamage;
    internal Text chanceCriticalDamage;

    internal Coins coins;
    internal EnemySpawner enemySpawner;
    internal EnemyParameters enemyParameters;

    private SceneLoader loadNameText;

    private void Start()
    {
        enemyParameters = FindObjectOfType<EnemyParameters>(); 

        hPMonster =GameObject.Find("HP").GetComponent<Text>();
        
        

        armorMonster =GameObject.Find("Armor").GetComponent<Text>();
        

        finalyDamage = GameObject.Find("FinalyDamage").GetComponent<Text>();

        criticalDamage = GameObject.Find("CriticalDamage").GetComponent<Text>();
        chanceCriticalDamage= GameObject.Find("ChanceCriticalDamage").GetComponent<Text>();



        textNumberCoins = GameObject.Find("CoinsText").GetComponent<Text>();
        coins = FindObjectOfType<Coins>();

        level = GameObject.Find("Level").GetComponent<Text>();
        enemySpawner = FindObjectOfType<EnemySpawner>();


        nameUser= GameObject.Find("User").GetComponent<Text>();

        Invoke("FindNameUser", 0.1f);


       

    }

    private void Update()
    {
        armorMonster.text = enemyParameters.armor.ToString();
        finalyDamage.text = enemyParameters.finalyDamage.ToString();
        level.text = enemySpawner.allMonster.ToString();
        textNumberCoins.text = coins.numberCoins.ToString();
        criticalDamage.text = enemyParameters.criticalDamage.ToString();
        chanceCriticalDamage.text = enemyParameters.chanceCriticalDamage.ToString() + "%";

        enemyParameters.FinalD();

        if (enemyParameters.health>0)
        {
            hPMonster.text = enemyParameters.health.ToString();
        }
        

    }
    void FindNameUser()
    {
        loadNameText = FindObjectOfType<SceneLoader>();
        nameUser.text = loadNameText.nameText;
    }



}
