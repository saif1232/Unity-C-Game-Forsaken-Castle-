using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Knight1 : MonoBehaviour {


    public GameObject Knight;
    public GameObject Arrow;
    public bool dead = false;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Arrow.GetComponent<Animation>().Play("ArrowHit6");
            dead = true;
                         

        }
    }
    void OnTriggerExit(Collider other)
    {
        Destroy(Knight.gameObject);
        Destroy(Arrow.gameObject);
    }
}
