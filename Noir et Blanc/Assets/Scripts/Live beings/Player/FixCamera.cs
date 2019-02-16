using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FixCamera : MonoBehaviour {
    public float moveSpeed = 1f;
    public float turnSpeed = 50f;
    public GameObject player;

    void Update()
    {
        Vector3 place = transform.position;

        if (Input.GetKey(KeyCode.UpArrow))
        {
            place.z = player.transform.position.x;
            place.x = player.transform.position.x;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            place.z = player.transform.position.x;
            place.x = player.transform.position.x;
        }
    }
}
//https://www.youtube.com/watch?v=cfjLQrMGEb4