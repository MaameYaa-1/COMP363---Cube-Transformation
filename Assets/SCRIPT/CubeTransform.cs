using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeTransform : MonoBehaviour
{
    public float moveSpeed = 2.0f;
    public float rotateSpeed = 50.0f;
    public float scaleSpeed = 0.5f;

    void Update()
    {
        // Move right
        transform.Translate(Vector3.right * moveSpeed * Time.deltaTime);
        
        // Rotate around Y-axis
        transform.Rotate(Vector3.up * rotateSpeed * Time.deltaTime);
        
        // Scale up and down
        float newSize = Mathf.PingPong(Time.time * scaleSpeed, 2.0f) + 0.5f;
        transform.localScale = new Vector3(newSize, newSize, newSize);
    }
}