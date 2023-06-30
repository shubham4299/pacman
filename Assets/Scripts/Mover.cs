using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] float moveSpeed = 1f;
   
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
}
