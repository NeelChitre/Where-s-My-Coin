using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Elevator : MonoBehaviour
{
    [SerializeField] Vector3 moveVector;
    float moveFactor;
    Vector3 startingPosition;
    [SerializeField] float period = 2f;
    bool move = false;
    [SerializeField] GameObject elevator;

    void Start()
    {
        startingPosition = elevator.transform.position;
    }
    void Update()
    {
        if (move) 
        {
            float cycles = Time.time / period;
            const float tau = Mathf.PI * 2;
            float rawSinWave = Mathf.Sin(cycles * tau);
            moveFactor = (rawSinWave + 1f) / 2f;
            Vector3 offset = moveVector * moveFactor;
            elevator.transform.position = startingPosition + offset;
        }
    }
    private void OnTriggerEnter(Collider other) 
    {
        if (other.gameObject.tag == "Elevator")
        {
            move = true;
        }       
    }
}
