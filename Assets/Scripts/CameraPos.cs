using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraPos : MonoBehaviour
{
    [SerializeField] private Transform golfBall;
    [SerializeField] private float rotationSpeed;

    private float mouseX;
    private float rotation;

    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        rotation = 0;
    }

    private void Update()
    {
        // Translates object with golf ball without affecting rotation
        transform.position = golfBall.transform.position;

        // Move camera based on left-right mouse rotation
        // if player presses right click on mouse
        if(Input.GetMouseButton(1))
        {
            mouseX = -Input.GetAxisRaw("Mouse X") * Time.deltaTime * rotationSpeed;
            rotation += mouseX;

            transform.rotation = Quaternion.Euler(0, rotation, 0);
        }
    }
}
