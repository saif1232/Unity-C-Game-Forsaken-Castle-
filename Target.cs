using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{

    // private GameObject Enemy;
    public int Playerhealth = 100;
    public int damageTake = 20;
   // private bool CanHit = false;

    void Start()
    {
        //Enemy = GameObject.FindWithTag("Enemy");

    }

    void Update()
    {
        EnemyHit();
        
    }
    public void TakeDamage(int Amount)
    {
        Playerhealth -= Amount;
        if (Playerhealth <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        Destroy(this.gameObject);
    }
    void EnemyHit()
    {
        if (GameObject.FindWithTag("Enemy").GetComponent<EnemyChase>().hit == true)
        {
            TakeDamage(damageTake);
            Debug.Log("Damage");
        }

    }

}
    

