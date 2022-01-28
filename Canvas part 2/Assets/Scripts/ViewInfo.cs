using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ViewInfo : MonoBehaviour
{
    [SerializeField] private InputField nameStore = null;
    [SerializeField] private Slider cristalSlider = null;
    [SerializeField] private Slider coinsSlider = null;
    [SerializeField] private Slider MoneySlider = null;
    [SerializeField] private GameObject LevelsScreen = null;

   // [SerializeField] private Button close = null;
    
    private PointInfo currentInfo;
    private Action eventClose;
    

    public void Open(ref PointInfo pointInfo, ref Action close)
    {
        currentInfo = pointInfo;
        nameStore.text = currentInfo.name;
        cristalSlider.value = currentInfo.cristalsSlider;
        coinsSlider.value = currentInfo.coinsSlider;
        MoneySlider.value = currentInfo.MoneySlider;
        eventClose = close;
    }

    private void Update()
    {
        currentInfo.name = nameStore.text;
        currentInfo.cristalsSlider = cristalSlider.value ;
        currentInfo.coinsSlider = coinsSlider.value;
        currentInfo.MoneySlider = MoneySlider.value;
    }

    public void Close()
    {
        eventClose?.Invoke();
        gameObject.SetActive(false);
    }
}
