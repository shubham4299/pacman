using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChangeOnHit : MonoBehaviour
{
    [SerializeField]float loadDelay=2f;
    [SerializeField]ParticleSystem crashEffect;
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            GetComponent<SpriteRenderer>().color = Color.cyan;
            Invoke("ReloadScene", loadDelay);
        }

    }

    void Start()
    {
        
    }

    
    void Update()
    {

       
    }
}
