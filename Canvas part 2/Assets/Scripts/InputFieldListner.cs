using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InputFieldListner : MonoBehaviour
{
    [SerializeField] private InputField _inputField = null;

    public void TestOnValueChanged()
    {
        print($"From change event {_inputField.text}");
    } 
    
    public void TestOnEndEdit()
    {
        print($"From end event {_inputField.text}");
    }

    private void Start()
    {
        _inputField.onValueChanged.AddListener(delegate(string str)
        {
            print($"From CODE changed event {str}");
        });
        
        _inputField.onEndEdit.AddListener(delegate(string str)
        {
            print($"From CODE end event {str}");
        });
    }
}
