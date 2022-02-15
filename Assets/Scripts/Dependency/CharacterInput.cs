using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterInput : MonoBehaviour
{
    public float Rotation { get; set; }
    public float Movement { get; set; }



    private void Update()
    {
        Rotation = RotationValue();
        Movement = MovementValue();
    }

    public float RotationValue()
    {
        float rotation = Input.GetAxis("Horizontal");
        return rotation;
    }
    public float MovementValue()
    {

        float movement = Input.GetAxis("Vertical");
        return movement;
    }


}
