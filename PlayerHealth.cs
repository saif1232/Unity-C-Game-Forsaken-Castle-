using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerHealth : MonoBehaviour {

    // private GameObject Enemy;
     public int damageDone = 20;
    public float Playerhealth = 100f;
    public  int damageTake = 8;
    public Transform Respawn;
    public Transform Player;
    public bool Revived = false;
    public GameObject GameOverNotice;
    public GameObject Retry;
    public GameObject Playerr;
    public GameObject GUICam;
    public GameObject Background;
    void Start()
    {
        //Enemy = GameObject.FindWithTag("Enemy");

    }

    void Update()
    {
        
            if (GameObject.Find("Enemy").GetComponent<EnemyChase>().hit == true) 
        {
            Debug.Log("hit!!!");
            EnemyHit();
            GameObject.Find("Enemy").GetComponent<EnemyChase>().hit = false;
          
        }
        if (GameObject.Find("Enemy (1)").GetComponent<EnemyChase>().hit == true)
        {
            Debug.Log("hit!!!");
            EnemyHit();
            GameObject.Find("Enemy (1)").GetComponent<EnemyChase>().hit = false;

        }
        if (GameObject.Find("Enemy (2)").GetComponent<EnemyChase>().hit == true)
        {
            Debug.Log("hit!!!");
            EnemyHit();
            GameObject.Find("Enemy (2)").GetComponent<EnemyChase>().hit = false;

        }
        if (GameObject.Find("Enemy (3)").GetComponent<EnemyChase>().hit == true)
        {
            Debug.Log("hit!!!");
            EnemyHit();
            GameObject.Find("Enemy (3)").GetComponent<EnemyChase>().hit = false;

        }
        if (GameObject.Find("Enemy (4)").GetComponent<EnemyChase>().hit == true)
        {
            Debug.Log("hit!!!");
            EnemyHit();
            GameObject.Find("Enemy (4)").GetComponent<EnemyChase>().hit = false;

        }
        if (GameObject.Find("Enemy (5)").GetComponent<EnemyChase>().hit == true)
        {
            Debug.Log("hit!!!");
            EnemyHit();
            GameObject.Find("Enemy (5)").GetComponent<EnemyChase>().hit = false;

        }
        if (GameObject.Find("Enemy (6)").GetComponent<EnemyChase>().hit == true)
        {
            Debug.Log("hit!!!");
            EnemyHit();
            GameObject.Find("Enemy (6)").GetComponent<EnemyChase>().hit = false;

        }
        if (GameObject.Find("Enemy (7)").GetComponent<EnemyChase>().hit == true)
        {
            Debug.Log("hit!!!");
            EnemyHit();
            GameObject.Find("Enemy (7)").GetComponent<EnemyChase>().hit = false;

        }
        


            if (Playerhealth <= 0)
        {
            Player.transform.position = Respawn.transform.position;
            Playerhealth = 100;
            Revived = true;
            
        }

    }
    public void TakeDamage(int damage)
    {
        int damageToApply = damage * damageTake;
        Playerhealth -= damageToApply;
        if (Playerhealth <= 0)
        {
            //GameObject.FindWithTag("Enemy").GetComponent<EnemyChase>().hit = false;
            Die();
        }
    }


    void Die()
    {
        Playerr.SetActive(false);
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
        Debug.Log("dead");
        GameOverNotice.SetActive(true);
        Retry.SetActive(true);
        GUICam.SetActive(true);
        Background.SetActive(true);
        //Destroy(this.gameObject);
    }
    void EnemyHit()
    
        {       

            TakeDamage(damageTake);
            Debug.Log("Damage");
        
        }


}