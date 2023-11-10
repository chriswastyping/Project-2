using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    
    public GameObject menuCanvas;

    public void OnButtonPress(string buttonText)
    {
        switch(buttonText)
        {
            case "Dogs":
            {
                SceneManager.LoadScene("Prototype 2");
                break;
            }
            case "Fetch":
            {
                SceneManager.LoadScene("");
                break;
            }
            case "Exit":
            {
                menuCanvas.SetActive(false); 
                break;
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
      
    }
}
