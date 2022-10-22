using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{

    internal GameObject gameOb;
    internal int allMonster = 0;

    public List<GameObject> enemySpawns;

    internal int random;


    private Achievement achievement;
    private void Start()
    {
        achievement = FindObjectOfType<Achievement>();
    }
    void Update()
    {
        if (transform.childCount == 0)
        {
            allMonster++;
            random = Random.Range(0, 3);
            if (random == 0)
            {
                gameOb = Instantiate(enemySpawns[0], transform);
                achievement.CountScorpions();
            }
            else if (random == 1)
            {
                gameOb = Instantiate(enemySpawns[1], transform);
                achievement.CountSpider();
            }
            else
            {
                gameOb = Instantiate(enemySpawns[2], transform);
                achievement.CountSnakes();
            }


        }

    }

}
