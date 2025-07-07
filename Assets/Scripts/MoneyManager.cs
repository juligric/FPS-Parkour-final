using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoneyManager : MonoBehaviour
{
    public float money;
    public UIManager uiManager;

    void Start()
    {
        if (uiManager == null)
        {
            uiManager = FindObjectOfType<UIManager>();
            if (uiManager == null)
            {
                Debug.LogWarning("UIManager no asignado en MoneyManager y no se encontró en la escena.");
            }
        }

        uiManager?.UpdateMoneyTxt(money.ToString());
    }

    public void UpdateMoney(float moneyToAdd)
    {
        if (money + moneyToAdd < 0)
        {
            Debug.Log("No te alcanza");
            return;
        }

        money += moneyToAdd;

        if (uiManager == null)
        {
            uiManager = FindObjectOfType<UIManager>();
        }

        uiManager?.UpdateMoneyTxt(money.ToString());
    }
}
