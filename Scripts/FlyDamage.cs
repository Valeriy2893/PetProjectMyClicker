using UnityEngine;
using UnityEngine.UI;

public class FlyDamage : MonoBehaviour
{
    internal bool checkFlyDamage;

    public GameObject prefabText;

    internal GameObject objectText;

    internal Rigidbody rb;
    internal Text flyDamage;

    internal EnemyParameters enemyParameters;


    void Start()
    {
        enemyParameters = FindObjectOfType<EnemyParameters>();

    }


    void Update()
    {
        if (checkFlyDamage)
        {
            objectText = Instantiate(prefabText, transform);
            checkFlyDamage = false;

            flyDamage = objectText.GetComponent<Text>();

            flyDamage.text = enemyParameters.finalyDamage.ToString();

            rb = objectText.GetComponent<Rigidbody>();

            rb.AddForce(Random.Range(-500, 500), Random.Range(-500, 500), Random.Range(-500, 500), ForceMode.Impulse);
            

        }
        if (objectText != null)
        {
            Destroy(objectText, 1);
        }

    }
}
