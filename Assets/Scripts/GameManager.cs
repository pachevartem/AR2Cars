using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    
    public int SpeedCars = 5;
    [Range(1,4)]
    public int startSpeedCollisionObject = 1;

    private void Awake()
    {
        instance = this;
    }
}
