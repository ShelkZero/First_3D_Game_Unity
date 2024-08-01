using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public float rotateSpeed = 15.0f, speed = 20.0f, zoomSpeed = 100.0f;
    private float _mult = 1f;

    private void Update()
    {
        float hor = Input.GetAxis("Horizontal");
        float ver = Input.GetAxis("Vertical");

        float rotate = 0f;
        if (Input.GetKey(KeyCode.Q))
            rotate = -3f;
        else if (Input.GetKey(KeyCode.E))
            rotate = 3f;

        _mult = Input.GetKey(KeyCode.LeftShift) ? 2f : 1f;

        transform.Rotate(Vector3.up * rotateSpeed * Time.deltaTime * rotate * _mult, Space.Self);

        // »зменено на использование transform.forward дл€ передвижени€ камеры
        transform.position += transform.forward * ver * Time.deltaTime * _mult * speed;
        transform.position += transform.right * hor * Time.deltaTime * _mult * speed;

        transform.position += transform.up * zoomSpeed * Input.GetAxis("Mouse ScrollWheel");

        transform.position = new Vector3(
            transform.position.x,
            Mathf.Clamp(transform.position.y, 5f, 25f),
            transform.position.z);
    }
}
