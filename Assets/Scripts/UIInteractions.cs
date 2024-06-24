using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIInteractions : MonoBehaviour
{
    public void ClickFunction()
    {
        Debug.Log("Button was clicked");
    }

    public void SliderChange(float sliderValue)
    {
        Debug.Log(sliderValue);
    }

    public void ToggleChange(bool toggleValue)
    {
        Debug.Log(toggleValue);
    }
}