using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeeleeSystem : MonoBehaviour {

    private float health;
    public Camera Cam;
    public float range;
    public LayerMask myMask;
    public int damage;
    public GameObject Sword;

	// Use this for initialization
	void Start () {
        health = GameObject.Find("FirstPersonCharacter").GetComponent<PlayerHealth>().Playerhealth;
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButtonDown(1))
        {
            Attack();
            Sword.GetComponent<Animation>().Play("SwordHit");
        }


    }

    public void TakeDamage(int Amount)
    {
        health -= Amount;
        if (health <= 0)
        {
            Destroy();
        }
    }
    void Destroy()
    {
        Destroy(this.gameObject);
    }

    void Attack()
    {
        RaycastHit hit;
        if(Physics.Raycast(Cam.transform.position, Cam.transform.forward, out hit, range, myMask))
        {
            Target target = hit.transform.GetComponent<Target>();
            if(target !=null)
            {
                target.TakeDamage(damage);
            }
            
        }
    }
}
