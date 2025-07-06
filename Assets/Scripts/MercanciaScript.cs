using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MercanciaScript : MonoBehaviour
{
    public float cost;
    public MoneyManager moneyManager;

     void Start()
    {
        moneyManager = FindObjectOfType<MoneyManager>();
    }

    void OnCollisionEnter (Collision collision)
    {
        if (collision.gameObject.name == "Player")
        {
            //actualizar dinero por la compra
            moneyManager.UpdateMoney(-cost);
            Destroy(gameObject);
        }
    }
}
