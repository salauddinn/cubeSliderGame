using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private Rigidbody rb;

    public float movementForce = 2000f;
    public float sideWayForces = 2000f;
    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        rb.AddForce(0, 0, movementForce*Time.deltaTime);
        if (Input.GetKey(UnityEngine.KeyCode.A)) {

            rb.AddForce(-sideWayForces * Time.deltaTime, 0, 0,ForceMode.VelocityChange);
        }
        if (Input.GetKey(UnityEngine.KeyCode.D))
        {

            rb.AddForce(sideWayForces * Time.deltaTime, 0, 0,ForceMode.VelocityChange);
        }
        if(rb.position.y < -1f)
        {
            FindObjectOfType<GameManger>().endGame();
        }

    }
}
