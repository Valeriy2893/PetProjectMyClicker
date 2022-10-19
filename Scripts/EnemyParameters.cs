using System;
using System.Drawing;
using UnityEngine;

public class EnemyParameters : MonoBehaviour
{
    internal int finalyDamage;
    internal int health = 50;
    internal int damage = 10;
    internal int armor;
    internal int buyDamage;
    internal int criticalDamage = 1;
    internal int chanceCriticalDamage = 50;

    internal int maxDamage;


    private EnemySpawner enemySpawner;
    private FlyDamage flyDamageScript;
    private CriticalFlyDamage criticalFlyDamageScript;


   
    private void Awake()
    {
        enemySpawner = FindObjectOfType<EnemySpawner>();
        flyDamageScript = FindObjectOfType<FlyDamage>();
        criticalFlyDamageScript = FindObjectOfType<CriticalFlyDamage>();
    }
    private void Start()
    {
        
    }


    public void FinalD()
    {
        armor = enemySpawner.allMonster / 3;

        finalyDamage = ((damage - armor) + buyDamage);


    }
    public void GetChanceCriticalDamage()
    {
        flyDamageScript.checkFlyDamage = true;
        int random = UnityEngine.Random.Range(0, 101);

        if (random >= chanceCriticalDamage)
        {
            flyDamageScript.checkFlyDamage = false;
            criticalFlyDamageScript.checkCriticalFlyDamage = true;

            if (finalyDamage <= 1)
            {
                finalyDamage = 1;
                finalyDamage *= criticalDamage;
                maxDamage = finalyDamage;
                health -= maxDamage;
            }
            else
            {
                finalyDamage *= criticalDamage;
                maxDamage = finalyDamage;
                health -= maxDamage;

            }
        }
        else
            if (finalyDamage <= 1)
        {
            finalyDamage = 1;
            health -= finalyDamage;
        }
        else
        {
            health -= finalyDamage;
        }



    }


    

}
