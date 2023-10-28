using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject player;
    private Vector3 offset = new Vector3(0,6,-9);

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // LateUpdate is called once per frame
    void LateUpdate()
    {
        // Offset the camera behind the player by adding the player's position
        transform.position = player.transform.position + offset;
    }
}
