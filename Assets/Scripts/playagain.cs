using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playagain : MonoBehaviour
{
    public void getplayedagain()
    {
        SceneManager.LoadScene("Level");
    }
}
