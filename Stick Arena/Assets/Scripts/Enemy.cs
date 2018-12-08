using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {

    private int startHealth;
    private int health = 15;
    private Quaternion startRotation;
    private Vector3 position;


    public GameObject deathEffect;
    public GameObject respawnEnemey;

    private float spawnY = Random.Range
                (Camera.main.ScreenToWorldPoint(new Vector2(0, 0)).y, Camera.main.ScreenToWorldPoint(new Vector2(0, Screen.height)).y);
    private float spawnX = Random.Range
                (Camera.main.ScreenToWorldPoint(new Vector2(0, 0)).x, Camera.main.ScreenToWorldPoint(new Vector2(Screen.width, 0)).x);

    // Use this for initialization

    public void Start()
    {
        startHealth = health;








    }

    public void TakeDamage(int damage)
    {
        health -= damage;
        if (health <= 0)
        {


                Instantiate(deathEffect, transform.position, Quaternion.identity);
                Destroy(gameObject);
                KillAndReset();

        }
    }

    void KillAndReset()
    {
       

        health = startHealth;
        Vector2 spawnPosition = new Vector2(spawnX, spawnY);

        Instantiate(respawnEnemey, spawnPosition, Quaternion.identity);
        

       // transform.position = 
        //transform.rotation = startRotation;

    }
}
