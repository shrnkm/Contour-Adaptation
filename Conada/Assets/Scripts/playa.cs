using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playa : MonoBehaviour
{
    public Transform Player;
    private Rigidbody playyer;
    public static int health = 5;
    private AudioSource source;
    public AudioClip scream;
    
    // Start is called before the first frame update
    void Start()
    {
        playyer = GetComponent<Rigidbody>();
        source = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        playyer.transform.position = Player.position;
        if (health <= 0)
        {
            Death();
        }
    }
    
    private void OnTriggerEnter(Collider other)
    {
        print("goozz");
        //health -= 1;
        source.clip = scream;
        source.PlayOneShot(scream);
    }


    void Death()
    {
        
    }
}
