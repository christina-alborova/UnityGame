using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{   
    [SerializeField]
    private float speed=1f;

    private void Update()
    {
        transform.position += transform.forward * Input.GetAxis("Vertical")*Time.deltaTime*speed;
        transform.position += transform.right * Input.GetAxis("Horizontal")*Time.deltaTime*speed;
    }
}
