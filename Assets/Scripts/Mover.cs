using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Mover : MonoBehaviour
{
    [SerializeField] float moveSpeed = 1f;
    private int i = 0;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        MovePlayer();
       
                
    }
    public void MovePlayer()
    {
        float xVal = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
        float yVal = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;
        transform.Translate(xVal, yVal, 0);

    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Star")
        {
            i += 1;
            if (i == 26)
            {
                SceneManager.LoadScene("Level 2");
            }
            if (i == 52)
            {
                SceneManager.LoadScene("gameover");
            }
        }
    }
}
