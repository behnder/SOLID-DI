 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] private float rotationSpeed;
    [SerializeField] private float movementSpeed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float rotation = Input.GetAxis("Horizontal");
        float aceleration = Input.GetAxis("Vertical");

        transform.Rotate(Vector3.up * rotation * Time.deltaTime * rotationSpeed);
        transform.position += transform.forward *  aceleration * Time.deltaTime * movementSpeed;
        
    }
}
