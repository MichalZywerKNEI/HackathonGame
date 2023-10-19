using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float MoveSpeed;
    public Transform MoveTarget;
    void Start()
    {
        MoveTarget.parent = null;
    }

    void FixedUpdate()
    {
        transform.position = Vector3.MoveTowards(transform.position, MoveTarget.position, MoveSpeed * Time.deltaTime);

        if (Vector3.Distance(transform.position, MoveTarget.position) <= .05f)
        {
            if (Mathf.Abs(Input.GetAxisRaw("Horizontal")) == 1f)
            {
                MoveTarget.position += new Vector3(Input.GetAxisRaw("Horizontal")/2, 0f, 0f);
            }
            if (Mathf.Abs(Input.GetAxisRaw("Vertical")) == 1f)
            {
                MoveTarget.position += new Vector3(0f, Input.GetAxisRaw("Vertical")/2, 0f);
            }
        }
    }
}
