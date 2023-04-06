using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class UI_Manager : MonoBehaviour
{
    //I know that I do not need these variables but it helps keep 
    //my mind organized when writing

    [Header("Buttons")]
    public Button tooEasyButton;
    public Button tooHardButton;
    public Button justRightButton; 

    //This is the code for the tooEasyButton
    public void goToEasy()
    {
        SceneManager.LoadScene("TooEasy");
        Debug.Log("You have loaded into the Too Easy level");
    }

    //This is the code for the tooHardButton



    //This is the code for the justRightButton
    public void goToJustRight()
    {
        SceneManager.LoadScene("JustRight");
        Debug.Log("You have loaded into the Just Right Level");
    }
}
