using UnityEngine;
using System.Collections;

public class Looloo : MonoBehaviour
{
    public Transform Player;
    public float MoveSpeed;

    void Update ()
    {
        
        transform.LookAt(Player);
        transform.position += transform.forward * MoveSpeed * Time.deltaTime;
        //transform.Rotate (new Vector3 (0, 45, 0) * Time.deltaTime * 3);

    }
    
    public void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
    }
}