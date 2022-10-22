using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputPanel : MonoBehaviour
{
    private GameObject namePanel;

    private void Start()
    {
        namePanel = GameObject.Find("ButtonStart").transform.GetChild(1).gameObject;
    }
    public void ActiveInputPanel()
    {
        namePanel.SetActive(true);

    }
}
