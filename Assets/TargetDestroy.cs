using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetDestroy : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnCollionEnter(Collision collision)
    {
        if(collision.collider.CompareTag("TargetObject"))
        {
            Destroy(collision.gameObject);
        }   
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("TargetObject"))
        {
            Destroy(other.gameObject);
        }
    }
}
