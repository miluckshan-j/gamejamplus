using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public float movespeed = 0.5f;
    public float rotatespeed = 100.0f;
    private Animator anim;

    private void Start()
    {
        anim = GetComponent<Animator>();
        if (anim != null)
        {
            anim.Play("Idle", 0);
            Vector3 spawn = new Vector3(-5.02f, 0.05f, 8.13f);
            this.gameObject.transform.position = spawn;
        }
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            if (anim != null)
            {
                anim.Play("Walking", 0);
            }
            transform.Translate(0, 0, movespeed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            if (anim != null)
            {
                anim.Play("Walking", 0);
            }
            transform.Translate(0, 0, -movespeed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            if (anim != null)
            {
                anim.Play("Left Turn", 0);
            }
            this.transform.RotateAround(this.transform.position, transform.up, Time.deltaTime * -rotatespeed);
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            if (anim != null)
            {
                anim.Play("Right Turn", 0);
            }
            this.transform.RotateAround(this.transform.position, transform.up, Time.deltaTime * rotatespeed);

        }
    }
}
