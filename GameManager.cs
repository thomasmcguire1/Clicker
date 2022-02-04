using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static int money;
    public static int multiplier;

    void Start()
    {
        multiplier = PlayerPrefs.GetInt("multiplier", 1);
        money = PlayerPrefs.GetInt("money", 0); 
    }

    public void Update()
        
        // press R to reset the build money

    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            PlayerPrefs.DeleteAll();
        }
    }
}
