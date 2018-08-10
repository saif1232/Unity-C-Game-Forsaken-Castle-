using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour {

    public Image Healthbar;
    float maxHealth = 100f;
    public static float health;
    public static float Damage;
    public static float Reduction;
	// Use this for initialization
	void Start () {
        
        //Healthbar = GetComponent<Image> ();
       
       //float  Damage = GameObject.Find("FirstPersonCharacter").GetComponent<PlayerHealth>().damageTake;
       // Reduction = maxHealth - health / 100;
    }
	
	// Update is called once per frame
	void FixedUpdate () {
        float health = GameObject.Find("FirstPersonCharacter").GetComponent<PlayerHealth>().Playerhealth;
        Healthbar.fillAmount = health/100;
        Debug.Log("hp down");
	}
}
