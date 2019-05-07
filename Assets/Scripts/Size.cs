using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Size : MonoBehaviour
{
   public void SetSize(int size)
    {

        GetSize.currentSize = size;

        Debug.Log(GetSize.currentSize);
    }
}
