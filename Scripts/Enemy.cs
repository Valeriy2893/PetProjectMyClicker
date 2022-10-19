using UnityEngine;

public class Enemy : MonoBehaviour
{
    private Animator animator;
    private Coins coint;
    private EnemyParameters enemyParameters;
    private EnemySpawner enemySpawner;

    private void Awake()
    {
        animator = GetComponent<Animator>();
        enemyParameters = FindObjectOfType<EnemyParameters>();
        coint = FindObjectOfType<Coins>();
        enemySpawner=FindObjectOfType<EnemySpawner>();

        
    }
    private void Start()
    {
        
        enemyParameters.health = 50+ enemySpawner.allMonster;
        enemyParameters.FinalD();
    }

    public void GetDamage()
    {
        enemyParameters.FinalD();
        if (enemyParameters.health < enemyParameters.maxDamage)
        {
            animator.SetTrigger("Die");
            Destroy(gameObject, 0.5f);
        }
        else
        {
            enemyParameters.GetChanceCriticalDamage();
            
        }
    }
    

    private void OnMouseDown()
    {
        animator.SetTrigger("Hit");
        GetDamage();
        coint.GetCoins();
        
        
    }


}

