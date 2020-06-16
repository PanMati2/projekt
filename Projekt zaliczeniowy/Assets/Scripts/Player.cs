using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public CharacterController controller;
    public float speed = 10;

    void Update()
    {
        float hInput = Input.GetAxis("Horizontal");
        controller.Move(new Vector3(hInput * speed * Time.deltaTime, 0, 0));
    }
}
