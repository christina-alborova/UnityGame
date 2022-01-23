using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{   
    [SerializeField]
    private float speed=1f;
    private Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        transform.position += transform.forward * Input.GetAxis("Vertical")*Time.deltaTime*speed;
        transform.position += transform.right * Input.GetAxis("Horizontal")*Time.deltaTime*speed;
        if (Input.GetKeyDown(KeyCode.Space)) 
        {
            rb.AddForce(transform.up*speed,ForceMode.Impulse);
        }
    }
}
