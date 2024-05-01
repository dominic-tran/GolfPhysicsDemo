using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinningObstacle : MonoBehaviour
{
    [SerializeField] private float rotateSpeed;
    private float currAngle;

    private void Start()
    {
        currAngle = 0;
    }
    private void FixedUpdate()
    {
        currAngle += rotateSpeed;
        transform.rotation = Quaternion.Euler(0, currAngle, 0);

        // Reset currAngle back to 0 when it makes a full 360 angle rotation
        if(currAngle >= 360)
        {
            currAngle = 0;
        }
    }
}
