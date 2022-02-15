using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementV2 : MonoBehaviour
{
    [SerializeField] private float rotationSpeed;
    [SerializeField] private float movementSpeed;

    private CharacterInput characterInput;
    private void Awake()
    {
        characterInput = GetComponent<CharacterInput>();
    }
  
    void Update()
    {
        float rotation = characterInput.Rotation;
        float aceleration = characterInput.Movement;

        transform.Rotate(Vector3.up * rotation * Time.deltaTime * rotationSpeed);
        transform.position += transform.forward * aceleration * Time.deltaTime * movementSpeed;

    }
}
