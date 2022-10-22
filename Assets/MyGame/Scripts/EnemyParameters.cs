using UnityEngine;

public class EnemyParameters : MonoBehaviour
{
    internal int finalyDamage = 10;
    internal int health;
    internal int armor;
    internal int buyDamage;
    internal int criticalDamage = 1;
    internal int chanceCriticalDamage = 1;

    internal int maxDamage;


    private EnemySpawner enemySpawner;
    private FlyDamage flyDamageScript;
    private CriticalFlyDamage criticalFlyDamageScript;



    private Enemy enemy;
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

        if (finalyDamage > 1)
        {
            finalyDamage = ((10 - armor) + buyDamage);

        }
        else
        {
            finalyDamage = 1;
        }


    }
    public void GetChanceCriticalDamage()
    {
        flyDamageScript.checkFlyDamage = true;
        int random = Random.Range(0, 101);

        if (random <= chanceCriticalDamage)
        {
            flyDamageScript.checkFlyDamage = false;
            criticalFlyDamageScript.checkCriticalFlyDamage = true;


            finalyDamage *= criticalDamage;
            maxDamage = finalyDamage;


            health -= maxDamage;


            enemy = FindObjectOfType<Enemy>();
            enemy.GetDamage();

        }
        else
        {
            health -= finalyDamage;


            enemy = FindObjectOfType<Enemy>();
            enemy.GetDamage();
        }


    }




}
