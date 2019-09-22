using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeadFollower : MonoBehaviour
{
    
    public Transform Player;
    private Rigidbody playyer;
    
    void Start()
    {
        playyer = GetComponent<Rigidbody>();
    }
    // Update is called once per frame
    void Update()
    {
        playyer.transform.position = Player.position;
    }
}
