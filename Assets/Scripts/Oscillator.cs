using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Oscillator : MonoBehaviour
{
    private Vector3 startingPosition;
    [SerializeField] private Vector3 movementVector;
    private float movementFactor;
    [SerializeField] private float period = 2f; 
    private void Start()
    {
        startingPosition = transform.position;
    }
    private void Update()
    {
        if (period < Mathf.Epsilon) 
        { 
            return; 
        }
        float cycles = Time.time / period;

        const float tau = Mathf.PI * 2;
        float rawSinWawe = Mathf.Sin(cycles * tau);

        movementFactor = (rawSinWawe + 1f) / 2f;

        Vector3 offset = movementVector * movementFactor;
        transform.position = startingPosition + offset;
    }
}
