using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{

    public Transform target = null;

    public Transform player = null;

    public Vector3 newposition = Vector3.zero;
    public float speed = 5.0f;

    void LateUpdate()
    {

        newposition.x = Mathf.Lerp(this.transform.position.x, target.position.x, speed * Time.deltaTime);
        newposition.y = Mathf.Lerp(this.transform.position.y, target.position.y+1, speed * Time.deltaTime);
        newposition.z = Mathf.Lerp(this.transform.position.z, target.position.z, speed * Time.deltaTime);

        this.transform.position = newposition;

        this.transform.LookAt(player.position);

    }
}
