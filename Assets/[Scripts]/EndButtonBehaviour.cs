using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndButtonBehaviour : MonoBehaviour
{
    public void OnEndButtonPressed()
    {
        Application.Quit();
       Debug.Log("Quitting App");
    }
}
