using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GUIScript : MonoBehaviour {

    //public GameObject Canvas;
    public GameObject StartButton;
    public GameObject Player;
    public GameObject Title;
    public GameObject Background;
    public GameObject GUICam;
    
	// Use this for initialization
	void Start () {

        //GameObject.Find("FPSController").GetComponent<FirstPersonController>().SetActive(false);
        GUICam.SetActive(true);
        Background.SetActive(true);
        Player.SetActive(false);
        Title.SetActive(true);
        StartButton.SetActive(true);
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButtonUp(0))
        {
            Destroy(StartButton);
            Destroy(Title);
            Background.SetActive(false);
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
            Player.SetActive(true);
            GUICam.SetActive(false);
        }
	}

    
}
