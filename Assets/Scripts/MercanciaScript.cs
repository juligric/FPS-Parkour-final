using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MercanciaScript : MonoBehaviour
{
    public float cost;
    public MoneyManager moneyManager;

    void Start()
    {
        if (moneyManager == null)
        {
            moneyManager = FindObjectOfType<MoneyManager>();
        }
    }
    public void Comprar()
    {
        Debug.Log("Intentando comprar...");

        if (moneyManager != null)
        {
            Debug.Log("Dinero actual: " + moneyManager.money);
            if (moneyManager.money >= cost)
            {
                moneyManager.UpdateMoney(-cost);
                Debug.Log("Compra exitosa. Dinero restante: " + moneyManager.money);
                Destroy(gameObject);
            }
            else
            {
                Debug.Log("No tenés suficiente dinero para comprar esta caja.");
            }
        }
        else
        {
            Debug.LogWarning("MoneyManager no encontrado");
        }

    }


}