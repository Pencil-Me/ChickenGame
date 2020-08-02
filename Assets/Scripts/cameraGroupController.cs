using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraGroupController : MonoBehaviour
{
    [SerializeField] float rotationSpeed = 40f;

    void Update()
    {
        if (Input.GetAxis("Horizontal") > 0)
        {
            transform.Rotate(Vector3.up * -rotationSpeed * Time.deltaTime);
        }
        else if (Input.GetAxis("Horizontal") < 0)
        {
            transform.Rotate(Vector3.up * rotationSpeed * Time.deltaTime);
        }
    }
}
