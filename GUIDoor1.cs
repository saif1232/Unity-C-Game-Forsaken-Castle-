using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GUIDoor1 : MonoBehaviour {

    public GameObject Hint;
   
	// Use this for initialization
	void Start () {
       // Hint.SetActive(false);

    }
	
	// Update is called once per frame
	void Update () {
       
    }
    void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player")
        {
            if (Input.GetMouseButtonUp(0))
            {
                Hint.SetActive(true);
                Debug.Log("DOOR CLICKED");
            }
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
