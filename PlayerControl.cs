using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    ///////////////////////
    ///CameraControl
    public float mouseSensitivity = 100f;
    float xRotation = 0f;

    ///////////////////////
    ///MoveControl
    [SerializeField]
    Transform cameraTransform;

    [SerializeField]
    float speed;

    public CharacterController cc;

    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;

        //vagy ez vagy behuzom PlayerControl script-be
        // cc = GetComponent<CharacterController>();    
    }

    // Update is called once per frame
    void Update()
    {
        //tengelyek hogy mi korül foroglyanak
        //////////////////////////////////////////
        ///MovementControll
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 move = transform.right * x + transform.forward * z;
        cc.Move(move * speed * Time.deltaTime);

        //////////////////////////////////////////
        ///CameraControll
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;

        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);

        cameraTransform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
        transform.Rotate(Vector3.up* mouseX);


    }
}
