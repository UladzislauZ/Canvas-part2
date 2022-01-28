using System;
using UnityEngine;
using UnityEngine.UI;

public class ResourcesManager : MonoBehaviour
{
    [SerializeField] private Text text = null;

    [SerializeField] private Point[] points = null;

    private int countStars;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        countStars = 0;
        foreach (var point in points)
        {
            countStars += point.GetCountStars();
        }

        text.text = Convert.ToString(countStars);
    }
}
