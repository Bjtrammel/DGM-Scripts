﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu]
public class MovePattern : ScriptableObject //SO that way you can plug in your own SO numbers.
{
    //floatData is a SO
    //public FloatData gravity; //Delete the comments to make gravity a float you choose.
    private float Gravity = 9.81f;

    public FloatData MoveX, MoveY, MoveZ; //can be input or value, determines how fast you move.
    public FloatData RotX, RotY, RotZ; //creates rotate for xyz

    protected Vector3 moveDirection; //temp var
    private Vector3 rotDirection;

    public virtual void Invoke(CharacterController controller, Transform transform)
    {
        if (controller.isGrounded)
        {
            Move(transform);
        }

        Move(controller);
    }

    protected void Move(Transform transform)
    {
        moveDirection.Set(MoveX.Value, MoveY.Value,
            MoveZ.Value); //allows the object to move depending on XYZ and the value is determined by the floats
        rotDirection.Set(RotX.Value, RotY.Value, RotZ.Value);
        transform.Rotate(rotDirection); //rotates on the directions
        moveDirection = transform.TransformDirection(moveDirection); //  
    }

    protected void Move(CharacterController controller)
    {
        //moveDirection.y -= gravity.Value; no longer want Gravity to be an inputable float
        moveDirection.y -= Gravity;
        controller.Move(moveDirection * Time.deltaTime);
    }
}  