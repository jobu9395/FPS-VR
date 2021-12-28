using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomMovement : MonoBehaviour
{
    public float speed = 2.5f;

    void Start()
    {

    }

    void Update()
    {
        transform.position = new Vector3(Mathf.PingPong(Time.time, 5), transform.position.y, transform.position.z);
    }
}
