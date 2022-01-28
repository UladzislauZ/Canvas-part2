using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Point : MonoBehaviour
{
    [SerializeField] private ViewInfo _viewInfo = null;
    [SerializeField] private GameObject _marker = null;
    [SerializeField] private GameObject _star1 = null;
    [SerializeField] private GameObject _star2 = null;
    [SerializeField] private GameObject _star3 = null;
    
    private PointInfo _pointInfo = new PointInfo();
    private bool isOpenView;
    private int countStars = 0;
    
    public Action onClose;

    public int GetCountStars()=>countStars;
    
    private void Start()
    {
        onClose += CloseInfo;
    }

    private void Update()
    {
        if (isOpenView)
        {
            if (Input.GetKeyDown(KeyCode.Alpha1))
            {
                ActivateStars(1);
            }
        
            if (Input.GetKeyDown(KeyCode.Alpha2))
            {
                ActivateStars(2);
            }
        
            if (Input.GetKeyDown(KeyCode.Alpha3))
            {
                ActivateStars(3);
            }
        }
    }
    
    private void ActivateStars(int count)
    {
        switch (count)
        {
            case 1:
            {
                _star1.SetActive(true);
                _star2.SetActive(false);
                _star3.SetActive(false);
                countStars = 1;
                break;
            }
            case 2:
            {
                _star1.SetActive(true);
                _star2.SetActive(true);
                _star3.SetActive(false);
                countStars = 2;
                break;
            }
            case 3:
            {
                _star1.SetActive(true);
                _star2.SetActive(true);
                _star3.SetActive(true);
                countStars = 3;
                break;
            }
        }
    }

    public void OpenInfo()
    {
        if (!_viewInfo.gameObject.activeSelf)
        {
            _viewInfo.gameObject.SetActive(true);
        }
        
        _viewInfo.Open(ref _pointInfo, ref onClose);

        _marker.SetActive(true);
        gameObject.transform.localScale = new Vector3(1.5f, 1.5f);
        isOpenView = true;
    }

    public void CloseInfo()
    {
        isOpenView = false;
        _marker.SetActive(false);
        gameObject.transform.localScale = new Vector3(1f, 1f);
    }
}
