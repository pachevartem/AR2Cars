using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car : MonoBehaviour
{
    public Transform LeftZone;
    public Transform RightZone;
    
    const float SpeedCar = 10;

    // данный метод устанавливает машинку в нужное место
    private void SetStarPosition(Vector3 pos)
    {
        transform.position = pos;
    }

    private bool isTurn;


    private void Update()
    {
        Movement();
    }

    void Movement()
    {
        if (isTurn)
        {
            TowardToTarget(LeftZone);
        }
        else
        {
            TowardToTarget(RightZone);
        }
    }

    public void SwitchSide()
    {
        isTurn = !isTurn;
    }

    void TowardToTarget(Transform target)
    {
        transform.position = Vector3.MoveTowards(transform.position, target.position, Time.deltaTime * GameManager.instance.SpeedCars);
    }
}