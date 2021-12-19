using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOnImpact : MonoBehaviour
{
    // Start is called before the first frame update
    // void Start()
    // {
        
    // }

    // // Update is called once per frame
    // void Update()
    // {
        
    // }

    private void OnCollionEnter(Collision collision)
    {
        if(collision.collider.CompareTag("ThrowableObject"))
        {
            Destroy(collision.gameObject);
        }
        
    }
}
