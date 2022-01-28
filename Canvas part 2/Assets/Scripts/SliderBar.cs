using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliderBar : MonoBehaviour
{
    [SerializeField] private Slider slider = null;
    [SerializeField] private Slider progressBar = null;

    private void Update()
    {
        progressBar.value = Mathf.Lerp(progressBar.value, slider.value, Time.deltaTime * 10f);
    }
}
