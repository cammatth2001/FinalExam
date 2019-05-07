using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnSpeed : MonoBehaviour
{
    public void GetSpeed(float speed)
    {
     
        Speed.currentSpeed = speed;

        Debug.Log(Speed.currentSpeed);
    }
}
