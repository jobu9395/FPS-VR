using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomMovement : MonoBehaviour
{
    public float speed = 100f;

    void Start()
    {

    }

    void Update()
    {
        transform.position = new Vector3(Mathf.PingPong(Time.time * 2, speed), transform.position.y, transform.position.z);
    }
}
