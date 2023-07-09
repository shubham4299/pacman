using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Mover : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 1f;
    
    //private int i;
    /*void Start()
    {
        
    }*/

    // Update is called once per frame
    void Update()
    {
        MovePlayer();
        //i = textscoreshow.totscore;


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
            textscoreshow.totscore += 1;
            if (textscoreshow.totscore == 52)
            {
                SceneManager.LoadScene("gameover");
            }
            if (textscoreshow.totscore == 26)
            {
                SceneManager.LoadScene("Level_2");
            }

        }
    }
}
