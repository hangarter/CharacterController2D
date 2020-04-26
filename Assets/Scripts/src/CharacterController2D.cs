using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(BoxCollider2D))]
public class CharacterController2D : MonoBehaviour
{
    [SerializeField] private float gravity;

    public CollisionFlags Move(Vector2 moveDirection)
    {
        gameObject.transform.position += new Vector3(moveDirection.x, moveDirection.y);
        return CollisionFlags.None;
    }
}
