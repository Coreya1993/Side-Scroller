using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    
    public GameObject Fireball;
    public float moveSpeed = 40f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("fire1"))
        {
            SpawnFireball();

        }

        void SpawnFireball()
        {
            for (int i = 0; i < 6; i++)
            {
                float spawnY = Random.Range(9, 12);
                float spawnX = Random.Range(-17, 14);


                Vector2 spawnPosition = new Vector2(spawnX, spawnY);
                Instantiate(Fireball, spawnPosition, Quaternion.identity);
            }
        }
    }
}

