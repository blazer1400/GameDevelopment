using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ConstantMovement : MonoBehaviour
{
    public float speed = 1f; // Adjust the speed as desired

    private void Start()
    {
        InvokeRepeating("IncreaseSpeed", 1f, 1f);
    }

    private void Update()
    {
        // Move the object to the right
        transform.Translate(Vector2.left * speed * Time.deltaTime);
    }

    private void IncreaseSpeed()
    {
        // speed += Score.currentScore;
    }
}