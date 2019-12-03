using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class CollisionObject : MonoBehaviour
{

    public Transform StartPos;
    public Transform EndPos;

    private float Speed;

    private void Start()
    {
        transform.position = StartPos.position;
        Speed = Random.Range( GameManager.instance.startSpeedCollisionObject, GameManager.instance.startSpeedCollisionObject*1.2f);
    }

    // Update is called once per frame
    void Update()
    {
        TowardToTarget(EndPos);
    }
    
    void TowardToTarget(Transform target)
    {
        transform.position = Vector3.MoveTowards(transform.position, target.position, Time.deltaTime * Speed); //TODO: Вынести данное число в глобалку
        if (transform.position==target.position)
        {
            transform.position = StartPos.position;
            Speed = Random.Range( GameManager.instance.startSpeedCollisionObject, GameManager.instance.startSpeedCollisionObject*1.2f);
        }
    }
    

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(1);// игра закончена.
    }
}
