using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraFolow : MonoBehaviour
{
    public Transform player;
    public Transform EndBox;
    
    public float smoothSpeed = 0.125f;
    public float EndX;
    public float EndZ;
    public float EndBoxX;
    public float EndBoxZ;
    
    public Vector3 offset;
    public Vector3 END;
    public Vector3 box;

    private void FixedUpdate()
    {
       
        

        Vector3 desiredPosition = player.position + offset;
        Vector3 smoothPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
        transform.position = smoothPosition + END;


        box = GameObject.Find("Border").transform.localScale;
        EndBoxX = box.x;
        EndBoxZ = box.z;
        
        Vector3 end = transform.position;
        if(end.x > EndBoxX)
        {
            EndX = EndBoxX - end.x;
        }
        else if(end.x < -EndBoxX)
        {
            EndX = -EndBoxX - end.x ;
        }
        else
        {
            EndX = 0;
        }

        if (end.z > EndBoxZ)
        {
            EndZ = EndBoxZ - end.z;
        }
        else if(end.z < -EndBoxZ)
        {
            EndZ = -EndBoxZ - end.z;
        }
        else
        {
            EndZ = 0;
        }
        END = new Vector3(EndX, 0, EndZ);
    }
}