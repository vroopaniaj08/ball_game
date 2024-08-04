using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball_movement : MonoBehaviour
{
    // Start is called before the first frame update
    public float Speed;

    private void FixedUpdate()
    {

        float HorizonatalMovement = Input.GetAxis("Horizontal");
        float VerticalMovement = Input.GetAxis("Vertical");

        Vector3 MoveBall = new Vector3(HorizonatalMovement, 0, VerticalMovement);

        gameObject.transform.GetComponent<Rigidbody>().AddForce(MoveBall * Speed);
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
