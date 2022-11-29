using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraFolow : MonoBehaviour
{
    public Transform player;
    public float smoothSpeed = 0.125f;
    public Vector3 offset;
    public float EndX;
    public float EndZ;
    public Vector3 END;
    private void FixedUpdate()
    {
        END = new Vector3(EndX, 0, EndZ);
        Vector3 desiredPosition = player.position + offset;
        Vector3 smoothPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
        transform.position = smoothPosition + END;

        
        Vector3 end = transform.position;
        if(end.x > 20)
        {
            EndX = 20 - end.x;
        }
        else
        {
            EndX = 0;
        }

        if (end.z > 20)
        {
            EndZ = 20 - end.z;
        }
        else
        {
            EndZ = 0;
        }

        if (end.x > 20)
        {
            EndX = 20 - end.x;
        }
        else
        {
            EndX = 0;
        }

        if (end.z > 20)
        {
            EndZ = 20 - end.z;
        }
        else
        {
            EndZ = 0;
        }
    }
}