using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playa : MonoBehaviour
{
    public Transform Player;
    private Rigidbody playyer;
    // Start is called before the first frame update
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
