using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinnerObstacle : MonoBehaviour
{
    [SerializeField] float xRotate = 0;
    [SerializeField] float yRotate = 0;
    [SerializeField] float zRotate = 0;
    
    void Start()
    {
        
    }

    
    void Update()
    {
        transform.Rotate(xRotate, yRotate, zRotate);

    }
}
