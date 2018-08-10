using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorTrig1 : MonoBehaviour
{

    
    public GameObject door;
    public GameObject Trigger;
    public bool Opened = false;
    public GameObject Hint;


    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(Opened == true)
        {
            Trigger.GetComponent<CapsuleCollider>().enabled = false;
        }

    }
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            door.GetComponent<Animation>().Play("DoorOpen1");
            Opened = true;
            Hint.SetActive(false);


        }
    }


}