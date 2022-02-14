using System.Collections;
using UnityEngine.UI;
using UnityEngine;

public class Game : MonoBehaviour
{
    public Text ui;
    
    public void Increment()
    {
        GameManager.money += GameManager.multiplier;
        PlayerPrefs.SetInt("money", GameManager.money);
    }

    public void Buy(int num)
    {
        if (num == 1 && GameManager.money >= 25)
        {
            GameManager.multiplier += 1;
            GameManager.money -= 25;
            PlayerPrefs.SetInt("money", GameManager.money);
            PlayerPrefs.SetInt("multiplier", GameManager.multiplier);
        }
        
        if (num == 2 && GameManager.money >= 125)
        {
            GameManager.multiplier += 10;
            GameManager.money -= 125;
            PlayerPrefs.SetInt("money", GameManager.money);
            PlayerPrefs.SetInt("multiplier", GameManager.multiplier);
        }
        
        if (num == 3 && GameManager.money >= 1500)
        {
            GameManager.multiplier += 100;
            GameManager.money -= 1500;
            PlayerPrefs.SetInt("money", GameManager.money);
            PlayerPrefs.SetInt("multiplier", GameManager.multiplier);
        }
    }

    void Update()
    {
        ui.text = "$" + GameManager.money;
    }
}
