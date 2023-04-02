using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraRotater : MonoBehaviour
{
    float xRot, yRot = 0f;

    public Rigidbody ball;

    public float rotationSpeed = 5f;

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(0,1f,0);

        if (Input.GetMouseButton(0)) {
            xRot += Input.GetAxis("Mouse X") * rotationSpeed;
            yRot =0;
            if (xRot < -10f) {
                xRot = -10f;
            }
            if (xRot > 10f) {
                xRot = 10f;
            }
            transform.rotation = Quaternion.Euler(-yRot, xRot, 0f);
        }
    }
}
