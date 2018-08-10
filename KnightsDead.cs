using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KnightsDead : MonoBehaviour {

    public GameObject Collider;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (GameObject.Find("Trigger1").GetComponent<Knight5>().dead == true && GameObject.Find("Trigger2").GetComponent<Knight6>().dead == true && GameObject.Find("Trigger3").GetComponent<Knight4>().dead == true
            && GameObject.Find("Trigger4").GetComponent<Knight7>().dead == true && GameObject.Find("Trigger5").GetComponent<Knight1>().dead == true && GameObject.Find("Trigger6").GetComponent<Knight2>().dead == true) {

            Destroy(Collider.gameObject);
        }


    }
}
