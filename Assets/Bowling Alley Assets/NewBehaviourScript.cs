using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public float jump_movement = 10.0f;

    // Update is called once per frame
    void Update()
    {
        float movement = Time.deltaTime * jump_movement * Input.GetAxis("Horizontal");
        Transform t = gameObject.transform;
        t.Translate (movement, 0.0f, 0.0f);


        if(Input.GetKeyDown(KeyCode.Space)) {
            Rigidbody rb = GetComponent<Rigidbody> ();
            rb.AddForce (new Vector3(0.0f, 50.0f, -100.0f));
        }




    }
}
