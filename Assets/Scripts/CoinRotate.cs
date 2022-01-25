using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinRotate : MonoBehaviour
{
    [SerializeField] float rotateSpeed;
    [SerializeField] Vector3 moveVector;
    float moveFactor;
    Vector3 startingPosition;
    [SerializeField] float period = 2f;
    void Start() 
    {
        startingPosition = transform.position;
    }
    void Update()
    {
        float cycles = Time.time / period;
        const float tau = Mathf.PI * 2;
        float rawSinWave = Mathf.Sin(cycles * tau);
        moveFactor = rawSinWave;
        transform.Rotate(0, rotateSpeed, 0);
        Vector3 offset = moveVector * moveFactor;
        transform.position = startingPosition + offset;
    }
}
