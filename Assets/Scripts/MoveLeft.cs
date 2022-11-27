using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    public float speed;
    private PlayerController controller;
    private SpawnManager counter;
    // Start is called before the first frame update
    void Start()
    {        
        controller = GameObject.Find("Player").GetComponent<PlayerController>();
        counter = GameObject.Find("SpawnManager").GetComponent<SpawnManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if(controller.gameOver == false)
        {
            speed = 10 + (float)(counter.spawnCount);
            transform.Translate(Vector3.left * Time.deltaTime * speed);
        }
        
        if (transform.position.x < - 15 && gameObject.CompareTag("Obstacle"))
        {
            Destroy(gameObject);            
        }
    }
}
