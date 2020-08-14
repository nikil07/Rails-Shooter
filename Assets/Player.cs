using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class Player : MonoBehaviour
{
    [Tooltip("in m/s")][SerializeField] float speed = 4f;
    [Tooltip("in m")] [SerializeField] float rangeX = 25f;
    [Tooltip("in m")] [SerializeField] float rangeY = 10f;

    [SerializeField] float pitchFactor = -5f;
    [SerializeField] float throwPitchFactor =-5f;

    [SerializeField] float yawFactor = -5f;

    [SerializeField] float rollFactor = -5f;

    Boolean isDisabled = false;


    float xThrow;
    float yThrow;


    // Update is called once per frame
    void Update()
    {
        if (!isDisabled)
        {
            handleMovememt();
            handleRotation();
        }
    }

    private void handleRotation()
    {
        float pitch = (transform.localPosition.y * pitchFactor) + (yThrow* throwPitchFactor);
        float yaw = (transform.localPosition.x * yawFactor);
        float roll = xThrow * rollFactor; ;

        transform.localRotation = Quaternion.Euler(pitch,yaw,roll);

    }

    private void handleMovememt()
    {
        xThrow = CrossPlatformInputManager.GetAxis("Horizontal");
        //print(horizontalThrow);
        float xOffSet = speed  * xThrow * Time.deltaTime;
        float rawX = transform.localPosition.x + xOffSet;
        float clampedRawX = Mathf.Clamp(rawX, -rangeX, rangeX);
        //transform.localPosition = new Vector3(clampedRawX, transform.localPosition.y, transform.localPosition.z);

        yThrow = CrossPlatformInputManager.GetAxis("Vertical");
        float yOffSet = speed * yThrow * Time.deltaTime;
        float rawY = transform.localPosition.y + yOffSet;
        float clampedRawY = Mathf.Clamp(rawY, -rangeY, rangeY);
        transform.localPosition = new Vector3(clampedRawX, clampedRawY, transform.localPosition.z);
    }

    private void disableControls() {
        print("controlled disabled");
        isDisabled = true;
    }
}
