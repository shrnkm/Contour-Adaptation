using System;
using UnityEngine;
using System.Collections;

public class Looloo : MonoBehaviour
{
    public float MoveSpeed;

    private GameObject Playa;
    private Transform PlayaTransform;
    //public Transform playa;

    void Start()
    {
        Playa = GameObject.Find("/Playa"); //"/BodyCollider");
        PlayaTransform = Playa.transform;
        print(PlayaTransform);
    }
    
    
    void Update ()
    {
        transform.LookAt(PlayaTransform);
        transform.position += transform.forward * MoveSpeed * Time.deltaTime;
        //transform.Rotate (new Vector3 (0, 45, 0) * Time.deltaTime * 3);

    }
    
    private void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
    }
}