using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameComplete : MonoBehaviour
{

    public GameObject Background;
    public GameObject Title;
    public GameObject Button;
    public int distanceToItem;
    public GameObject Player;
    public GameObject GUICam;
    public GameObject Hint;
    public bool open = false;
    // Use this for initialization
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        OpenChest();
       
    }
    //void OnTriggerEnter(Collider other)
    //{
    //    if (other.tag == "Player")
    //    {
    //        if (Input.GetMouseButtonUp(0))
    //        {
    //            Background.SetActive(true);
    //            Title.SetActive(true);
    //            Button.SetActive(true);
    //            Player.SetActive(false);
    //            Cursor.visible = true;
    //            GUICam.SetActive(true);
    //            Debug.Log("working");

    //        }
    //    }
    //}
    public void OpenChest()
    {
        if (Input.GetMouseButtonUp(0))
        {

            RaycastHit hit;

            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit, distanceToItem))
            {
                if (hit.collider.gameObject.name == "chest_open")
                {
                    
                    Debug.Log("opened");
                    Player.SetActive(false);        
                    Hint.SetActive(false);
                    Background.SetActive(true);
                    Title.SetActive(true);
                    Button.SetActive(true);
                    Cursor.lockState = CursorLockMode.None;
                    Cursor.visible = true;
                    GUICam.SetActive(true);
                    

                }



            }
        }
    }
}

