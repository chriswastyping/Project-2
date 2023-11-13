using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIHandler : MonoBehaviour
{
    public GameObject mainMenuCanvas;
    public void OnButtonPress(string buttonValue)
    {
        switch(buttonValue)
        {
            case "Prototype 2":
                {
                    SceneManager.LoadScene("Prototype 2");
                    break;
                }

            case "Challenge 2" :
                {
                    SceneManager.LoadScene("Challenge 2");
                    break;
                }
            case "Exit":
                {
                    Application.Quit();
                    break;
                }
                default: 
                {
                    break;
                }
            
        }
    }
}
