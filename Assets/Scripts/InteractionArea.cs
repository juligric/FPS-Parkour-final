using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractionArea : MonoBehaviour
{
    public GameObject interactionMessage;
    public MercanciaScript mercancia;

    // Start is called before the first frame update
    void Start()
    {
        interactionMessage.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            Destroy(mercancia.gameObject);
            StopInteraction();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.gameObject.name);
        interactionMessage.SetActive(true);
        mercancia = other.GetComponent<MercanciaScript>();
        if (mercancia)
        {
            interactionMessage.SetActive(true);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        StopInteraction();
    }

    void StopInteraction()
    {
        interactionMessage.SetActive(false);
        mercancia = null;
    }
}

