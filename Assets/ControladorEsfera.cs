using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorEsfera : MonoBehaviour{
    // Update is called once per frame
    public float speed;

    void FixedUpdate()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        GetComponent<Rigidbody>().AddForce(horizontal * speed, 0, vertical * speed);
    }
}
