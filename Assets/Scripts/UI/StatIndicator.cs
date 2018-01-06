using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StatIndicator : MonoBehaviour {

    public Slider indicatorSlider;

	
    public void SetValue(float value)
    {
        indicatorSlider.value = value;
    }
	
}
