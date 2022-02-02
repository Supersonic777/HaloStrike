using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//written by Maxim Kotlyarenko

public class Camera_Following : MonoBehaviour
{
    public GameObject player; // тут объект игрока
    public Transform target;
    public float followingSmooth= 5.0f;
    public Vector3 offset = new Vector3(0, 2, -5);


    void Start () 
    {        
        offset = transform.position - player.transform.position;
    }

    /*void LateUpdate () 
    {        
        transform.position = player.transform.position + offset;
    }
    */
    void Update ()
    {
    transform.position = Vector3.Lerp (transform.position, target.position + offset, Time.deltaTime * followingSmooth);
    } 
}