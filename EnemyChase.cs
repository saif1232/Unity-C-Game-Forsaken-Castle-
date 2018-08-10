using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyChase : MonoBehaviour {

    public GameObject Enemy;
    public GameObject Player;
    public Transform target;
    //public Transform myTransform;
    private bool run = false;
    public int moveSpeed = 5;
    public bool hit = false;
    private bool follow = false;
    private bool dead = false;
    public GameObject Respawn;
    private bool chase = false;
    
        
	// Use this for initialization
	void Start () {
        Enemy.GetComponent<Animation>().Play("Idle");
        
    }
	
	// Update is called once per frame
	void Update () {
        Follow();
           
    }
    void Reset()
    {
       if (GameObject.Find("FirstPersonCharacter").GetComponent<PlayerHealth>().Revived == true){

        }


    }


void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Enemy.GetComponent<Animation>().Play("Attack(1)");
            hit = true;
            chase = false;
        }
    }

void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player")
        {
            chase = false;
            
        }
    }


    void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            hit = false;
            if (GameObject.Find("FirstPersonCharacter").GetComponent<PlayerHealth>().Revived == false)
                chase = true;
            
        }
    }

    void Follow()
    {
        if (chase == true)
        {
            
            Enemy.GetComponent<Animation>().Play("Run");
            transform.LookAt(target);
            transform.position += (target.position - transform.position).normalized
        * moveSpeed * Time.deltaTime;
        }
        }
}



    
