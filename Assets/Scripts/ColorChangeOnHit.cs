using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ColorChangeOnHit : MonoBehaviour
{
    /*[SerializeField] private float loadDelay=2f;
    [SerializeField] private ParticleSystem crashEffect;*/
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            GetComponent<SpriteRenderer>().color = Color.cyan;
           
                textscoreshow.totscore -= textscoreshow.totscore;//decrement score on collision with an obstacle
            
            //Invoke("ReloadScene", loadDelay);
        }

    }

    void Start()
    {
        
    }

    
    void Update()
    {

       
    }
}
