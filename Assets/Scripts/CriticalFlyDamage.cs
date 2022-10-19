using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CriticalFlyDamage : MonoBehaviour
{
    internal bool checkCriticalFlyDamage;

    internal EnemyParameters enemyParameters;
    public GameObject prefabCriticalText;

    internal GameObject objectCriticalText;

    internal Rigidbody rb;
    internal Text criticalFlyDamage;

    void Start()
    {
        enemyParameters = FindObjectOfType<EnemyParameters>();
    }

   
    void Update()
    {
        if (checkCriticalFlyDamage)
        {
            objectCriticalText = Instantiate(prefabCriticalText, transform);
            checkCriticalFlyDamage = false;

            criticalFlyDamage = objectCriticalText.GetComponent<Text>();

            criticalFlyDamage.text = enemyParameters.maxDamage.ToString();

            rb = objectCriticalText.GetComponent<Rigidbody>();

            rb.AddForce(Random.Range(-500, 500), Random.Range(-500, 500), Random.Range(-500, 500), ForceMode.Impulse);


        }
        if (objectCriticalText != null)
        {
            Destroy(objectCriticalText, 1);
        }
    }
    }

