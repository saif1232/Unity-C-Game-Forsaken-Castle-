using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GUIPICKUP : MonoBehaviour {

    public GameObject Hint;

    // Use this for initialization
    void Start()
    {
        Hint.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player")
        {
            Hint.SetActive(true);

        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            Hint.SetActive(false);

        }
    }
}