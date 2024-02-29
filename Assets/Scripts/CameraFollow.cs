using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public GameObject player;
    private float zOffset = 14;
    private float cameraHeight = 11;

    void LateUpdate()
    {
        transform.position = new Vector3(player.transform.position.x, player.transform.position.y+cameraHeight, player.transform.position.z -zOffset);
    }
}
