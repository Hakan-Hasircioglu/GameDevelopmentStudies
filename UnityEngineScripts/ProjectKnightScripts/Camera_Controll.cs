using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControll : MonoBehaviour
{
    public GameObject player;
    float CameraSpeed = 0.0025f;
    float cameraSmoothSizepSpeed = 1;

    void Start()
    {
        transform.position = player.transform.position + new Vector3(8, 0, -10);
    }
    
    void LateUpdate()
    {
        //* Smooth Sizing
        Camera.main.orthographicSize = Mathf.Lerp(Camera.main.orthographicSize, 3, Time.deltaTime * cameraSmoothSizepSpeed);

        //* Smooth Following 
        transform.position = Vector3.Lerp(transform.position, player.transform.position, CameraSpeed) +
        new Vector3(0, 0, -1);
    }
}