using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AimGun : MonoBehaviour
{
    //////////////////////////////////////////// MY CODE START //////////////////////////////////////////
    private Vector2 playerMouseInput;
    private float vertAngle;

    [SerializeField] private float movementSpeed;

    // Update is called once per frame
    void Update()
    {
        vertAngle = Input.GetAxisRaw("Mouse Y");

        // Input is 'inverted' by default, this negative vertAngle is used
        transform.Rotate(-vertAngle, 0f, 0f);
    }
    //////////////////////////////////////////// MY CODE END ////////////////////////////////////////////
}
