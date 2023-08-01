using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyBehavior : MonoBehaviour
{

    [SerializeField] float moveSpeed = 1f;
    Rigidbody2D rb;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        rb.velocity = new Vector2(moveSpeed, 0f);

    }
    void OnTriggerEnter2D(Collider2D other)
    
    {
        moveSpeed = -moveSpeed;
        FlipEnemyFacing();
        if(other.tag == "Player")
        {
            SceneManager.LoadScene("Level");
        }
    }

    void FlipEnemyFacing() 
    {
        transform.localScale=new Vector2 (-0.5f,0.5f);
    }
}
