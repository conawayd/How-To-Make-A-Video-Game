using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Slider : MonoBehaviour
{
    public Text percentageText;

    private void Start()
    {
        percentageText = GetComponent<Text>();
    }

    public void AdjustSlider(float newValue)
    {
        percentageText.text = Mathf.RoundToInt(newValue * 100) + "%";
    }
}
