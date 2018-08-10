using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KnightWatch : MonoBehaviour {

    public Transform Respawn;
    public GameObject Player;
    public GameObject GameOver;
    public GameObject Background;
    public GameObject Retry;
    public GameObject GUICam;
    bool cursorstatus = false;

    
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (cursorstatus == true) {
            Cursor.visible = true;
            Screen.lockCursor = false;
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            cursorstatus = true;
            Background.SetActive(true);
            GameOver.SetActive(true);
            Retry.SetActive(true);
            Player.transform.position = Respawn.transform.position;
            GameObject.Find("FirstPersonCharacter").GetComponent<PlayerHealth>().Playerhealth = 100;
            Player.SetActive(false);
            GUICam.SetActive(true);
        }
    }
}
