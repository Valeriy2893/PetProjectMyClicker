using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    private Coins coins;
    private EnemyParameters enemyParameters;
    private Message message;


    private void Start()
    {
        coins = FindObjectOfType<Coins>();
        enemyParameters = FindObjectOfType<EnemyParameters>();
        message = FindObjectOfType<Message>();
    }


    public void BuyDamage()
    {
        if (coins.numberCoins >= 10)
        {
            enemyParameters.buyDamage++;
            coins.numberCoins -= 10;

            message.SetActiveTrue();
            message.InitialiseMessageText("������� ��������� �����");
            message.Invoke("SetActiveFalse", 1);


        }
        else
        {
            message.SetActiveTrue();
            message.InitialiseMessageText("���� �����");
            message.Invoke("SetActiveFalse", 1);
        }


    }

    public void BuyCriticalDamage()
    {
        if (coins.numberCoins >= 20)
        {
            enemyParameters.criticalDamage++;
            coins.numberCoins -= 20;

            message.SetActiveTrue();
            message.InitialiseMessageText("������� ������������ �����");
            message.Invoke("SetActiveFalse", 1);
        }
        else
        {
            message.SetActiveTrue();
            message.InitialiseMessageText("���� �����");
            message.Invoke("SetActiveFalse", 1);
        }

    }

    public void BuyChanceCriticalDamage()
    {
        if (coins.numberCoins >= 100)
        {
            enemyParameters.chanceCriticalDamage -= 1;
            coins.numberCoins -= 100;

            message.SetActiveTrue();
            message.InitialiseMessageText("������� ����� ������������ �����");
            message.Invoke("SetActiveFalse", 1);
        }
        else
        {
            message.SetActiveTrue();
            message.InitialiseMessageText("���� �����");
            message.Invoke("SetActiveFalse", 1);
        }
    }

}
