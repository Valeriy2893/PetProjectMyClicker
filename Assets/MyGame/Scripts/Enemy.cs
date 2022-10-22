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

        enemyParameters.health = 50 + enemySpawner.allMonster * 100;
        enemyParameters.FinalD();

    }

        
    
    public void GetDamage()
    {
        enemyParameters.FinalD();

        if (enemyParameters.health <=0)
        {
            animator.SetTrigger("Die");
            Destroy(gameObject, 0.5f);
        }
    }
    

    private void OnMouseDown()
    {
        animator.SetTrigger("Hit");
        coint.GetCoins();
        enemyParameters.GetChanceCriticalDamage();

    }


}

