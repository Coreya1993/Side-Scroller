using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fireball : MonoBehaviour
{

    public float speed = 40f;
    public Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        var targetPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        targetPos.z = transform.position.z;
        transform.position = Vector3.MoveTowards(transform.position, targetPos, speed * Time.deltaTime);
    }
}

   
    

