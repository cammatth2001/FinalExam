using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GetSize : MonoBehaviour
{
    public static int currentSize;

    public Text sizeText;


    public void Start()
    {
        sizeText.text = currentSize.ToString();

    }

    public void Update()
    {
        sizeText.text = currentSize.ToString();
    }
}
