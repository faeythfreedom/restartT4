using UnityEngine;
using System.Collections;

public class QuitGame : MonoBehaviour
{
    public void Exit()
    {
        Application.Quit();
        Debug.Log("Game is exiting");
        //Just to make sure its working
    }
}