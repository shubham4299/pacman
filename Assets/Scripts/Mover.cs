using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Mover : MonoBehaviour
{
    Animator pacAnimator;
    [SerializeField] private float moveSpeed = 1f;
    
    //private int i;
    void Start()
    {
        pacAnimator = GetComponent<Animator>();
    }
    void Update()
    {
        //MovePlayer();
        MovePlayerAltr();
        //i = textscoreshow.totscore;


    }
    public void MovePlayer()
    {
        float xVal = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
        float yVal = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;
        transform.Translate(xVal, yVal, 0);

    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Star")
        {
            textscoreshow.totscore += 1;
            if (textscoreshow.totscore ==52)
            {
                SceneManager.LoadScene("gameover");
            }
            if (textscoreshow.totscore == 26)
            {
                SceneManager.LoadScene("Level_2");
            }

        }
    }

    void MovePlayerAltr()
    {
        if(Input.GetKey(KeyCode.W)) 
        {
            pacAnimator.SetBool("isTurn", false);
            transform.localScale = new Vector2(0.13f, 0.13f);
            float yVal=(Input.GetAxis("Vertical")*moveSpeed*Time.deltaTime);
            transform.Translate(0, yVal, 0);
        }
        else if(Input.GetKey(KeyCode.S))
        {
            pacAnimator.SetBool("isTurn", false);
            transform.localScale = new Vector2(0.13f, -0.13f);
            float yVal = (Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime);
            transform.Translate(0, yVal, 0);
        }
        else if (Input.GetKey(KeyCode.A))
        {
            pacAnimator.SetBool("isTurn", true);
            transform.localScale = new Vector2(-0.13f, 0.13f);
            float xVal = (Input.GetAxis("Horizontal") * moveSpeed * Time.deltaTime);
            transform.Translate(xVal, 0, 0);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            pacAnimator.SetBool("isTurn", true);
            transform.localScale = new Vector2(0.13f, -0.13f);
            float xVal = (Input.GetAxis("Horizontal") * moveSpeed * Time.deltaTime);
            transform.Translate(xVal,0, 0);
        }
    }
}
