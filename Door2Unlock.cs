using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door2Unlock : MonoBehaviour
{
    public int distanceToItem;
    public GameObject Door;
    bool Access = false;
    bool Opened = false;

    // Use this for initialization
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (GameObject.Find("FirstPersonCharacter").GetComponent<PickUpItem>().KeyObtain == true)
        {
            Access = true;
        }
       
    }

    
    void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player")
        {
            if (Access == true && Opened == false)
            {
                if (Input.GetMouseButtonUp(0))
                
                        Door.GetComponent<Animation>().Play("DoorOpen2");
                Access = false;

                    }
                        }
                    }
    
                }


            

        
    



    