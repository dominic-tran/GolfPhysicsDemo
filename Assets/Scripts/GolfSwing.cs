using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GolfSwing : MonoBehaviour
{
    [SerializeField] private Transform cameraPos;
    [SerializeField] private Transform newClubPos;
    [SerializeField] private GameObject golfClub;
    [SerializeField] private GameObject golfBall;
    [SerializeField] private float swingSpeed;

    private float mouseY;
    private float rotation;

    private void Start()
    {
        golfClub.gameObject.SetActive(false);
        rotation = 0;
    }
    private void Update()
    {
        transform.rotation = cameraPos.rotation;
        // If player holds down left click, they can swing
        if(Input.GetMouseButton(0))
        {
            golfClub.gameObject.SetActive(true);

            mouseY = -Input.GetAxisRaw("Mouse Y") * Time.deltaTime * swingSpeed;
            rotation += mouseY;
            Vector3 v = transform.rotation.eulerAngles;
            transform.rotation = Quaternion.Euler(rotation, v.y, v.z);

        }
        else
        {
            rotation = 0;
            transform.position = newClubPos.position;
            golfClub.gameObject.SetActive(false);
        }
    }
}
