using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLook : MonoBehaviour
{
public Transform player;

    void Start()
    {
        // Update camera position to match player position
        transform.position = player.position;

        // Update player rotation to match camera rotation
        player.rotation = transform.rotation;
    }
}



















