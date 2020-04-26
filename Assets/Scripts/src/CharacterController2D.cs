using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(BoxCollider2D)), RequireComponent(typeof(Rigidbody2D))]
public class CharacterController2D : MonoBehaviour
{
    public bool isGrounded = true;
    
    [SerializeField] private float gravity;

    private Rigidbody2D _rigidbody2D;

#if UNITY_EDITOR
    public Rigidbody2D Rigidbody2D
    {
        get => _rigidbody2D;
        set => _rigidbody2D = value;
    }
#endif
    
    private void Start()
    {
        _rigidbody2D = gameObject.GetComponent<Rigidbody2D>();
    }

    public CollisionFlags Move(Vector2 moveDirection)
    {
        // gameObject.transform.Translate(new Vector3(moveDirection.x, moveDirection.y));
        var position = gameObject.transform.position + new Vector3(moveDirection.x, moveDirection.y);
        _rigidbody2D.MovePosition(position);
        return CollisionFlags.None;
    }


}
