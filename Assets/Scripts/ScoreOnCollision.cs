using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreOnCollision : MonoBehaviour
{
    public int score = 0;
   
   
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Star") {
            Debug.Log("star collected");
            Destroy(other.gameObject);
            score++;
            Debug.Log($"Plyer Score:{score}");
        }        
    }
}
