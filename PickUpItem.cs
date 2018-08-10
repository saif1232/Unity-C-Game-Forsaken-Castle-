using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpItem : MonoBehaviour {

    public GameObject Swordd;
    public int distanceToItem;
    public GameObject Key;
    public GameObject Sword;
    public bool KeyObtain = false;
    public bool SwordObtain = false;
    public GameObject LockedGUI;

    // Use this for initialization
    void Start() {

    }

    // Update is called once per frame
  public  void Update() {
        Collect();
        CollectSword();
        if (SwordObtain == true)
        {
            EquipWeapon();
        }

    }

    public void EquipWeapon()
    { 
        Swordd.SetActive(true);
    }
    public void CollectSword()
    {
        if (Input.GetMouseButtonUp(0))
        {

            RaycastHit hit;

            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit, distanceToItem))
            {
                if (hit.collider.gameObject.name == "TableSwordCol")
                {
                    Debug.Log("item hit TableSword");
                    Destroy(GameObject.Find("TableSword"));
                    SwordObtain = true;
                }
                else
                {
                    SwordObtain = false;
                }

            }
            


        }
    }
   public void Collect()
    {

        if (Input.GetMouseButtonUp(0))
        {

            RaycastHit hit;

            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);



                if (Physics.Raycast(ray, out hit, distanceToItem))
                {
                    if (hit.collider.gameObject.name == "KeyCol")
                    {
                        Debug.Log("item hit Key");
                        Destroy(GameObject.Find("Key"));
                        KeyObtain = true;
                    LockedGUI.SetActive(false);
                }
                }
        }
        }
    }





