using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class textscoreshow : MonoBehaviour
{
    public static int totscore;
    public TextMeshProUGUI scorecard;

    void Start()
    {
        
    }

    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space))
        {
            totscore += 1;
        }
        scorecard.text = ($"Score :{totscore}");
    }
}
