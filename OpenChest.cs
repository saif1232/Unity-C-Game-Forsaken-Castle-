using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenChest : MonoBehaviour {

    public GameObject OpenedChest;
    public GameObject Coins;
    public GameObject ClosedChest;
    public int distanceToItem;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Open();
	}

    public void Open()
    {
        if (Input.GetMouseButtonUp(0))
        {

            RaycastHit hit;

            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit, distanceToItem))
            {
                if (hit.collider.gameObject.name == "ChestCol")
                {
                    Debug.Log("item hit Chest");
                    Destroy(GameObject.Find("chest_close"));
                    OpenedChest.SetActive(true);
                    Coins.SetActive(true);
                    
                }
               

            }



        }
    }
}
