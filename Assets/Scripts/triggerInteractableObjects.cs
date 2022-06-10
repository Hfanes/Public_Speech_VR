using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class triggerInteractableObjects : MonoBehaviour
{
    public GameObject quandroObject;
    public GameObject frenteObject;

    public GameObject um;
    public GameObject microphone;


    private void Start()
    {
        quandroObject.GetComponentInChildren<Switch>().enabled = false;
        frenteObject.GetComponentInChildren<Switch>().enabled = false;

        um.GetComponent<Switch>().enabled = false;
        microphone.GetComponent<microfone>().enabled = false;

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "remote")
        {
            quandroObject.GetComponentInChildren<Switch>().enabled = true;
            frenteObject.GetComponentInChildren<Switch>().enabled = true;
        }

        if (other.gameObject.name == "Microphone")
        {
            quandroObject.GetComponentInChildren<Switch>().enabled = true;
            frenteObject.GetComponentInChildren<Switch>().enabled = true;
            microphone.GetComponent<microfone>().enabled = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.name == "remote")
        {
            quandroObject.GetComponentInChildren<Switch>().enabled = false;
            frenteObject.GetComponentInChildren<Switch>().enabled = false;
        }

        if (other.gameObject.name == "Microphone")
        {
            quandroObject.GetComponentInChildren<Switch>().enabled = false;
            frenteObject.GetComponentInChildren<Switch>().enabled = false;
            microphone.GetComponent<microfone>().enabled = false;
        }
    }
}
