using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.XR.Interaction.Toolkit;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private InputActionReference jumpActionReference;
    [SerializeField] private float jumpforce = 500.0f;


    private XRRig _xrRig;
    private CapsuleCollider _collider;
    private Rigidbody _body;
    private bool IsGrounded => Physics.Raycast(
        new Vector2(transform.position.x, transform.position.y + 2.0f), 
        Vector3.down, 2.0f
    );

    void Start()
    {
        _xrRig = GetComponent<XRRig>();
        _collider = GetComponent<CapsuleCollider>();
        _body = GetComponent<Rigidbody>();
        jumpActionReference.action.performed += OnJump;
    }

    void Update()
    {
        var center = _xrRig.cameraInRigSpacePos;
        _collider.center = new Vector3(center.x, _collider.center.y, center.z);
        _collider.height = _xrRig.cameraInRigSpaceHeight;
    }

    private void OnJump(InputAction.CallbackContext obj)
    {
        if (!IsGrounded) return;
            _body.AddForce(Vector3.up * jumpforce);

    }
}
