using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExperimentPosition : MonoBehaviour
{
    public Transform Player;
    private Rigidbody playyer;
    private Vector3 distance;
    
    void Start()
    {
        playyer = GetComponent<Rigidbody>();
        distance = playyer.transform.position - Player.position;
    }
    // Update is called once per frame
    void Update()
    {
        playyer.transform.position = Player.position + distance;
    }
}
