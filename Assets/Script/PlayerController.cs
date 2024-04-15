using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
   
    private float speed = 20f;
    private float turnSpeed = 45.0f;
    private float horizontalInput;
    private float forwardInput;
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {

        //Move the vehicle forward
        /* if (a < 20)
         {
             a = a + 1;
         }
         Debug.Log("Update" + a);
        */
        //transform.Translate(0, 0, 1);
        //transform.Translate(Vector3.forward);
        //update method called every single frame, but depending on how powerful your computer is you might get 20frames in one secondi  you might get 60frames in one second
        //this can effect working with different computers.
        //transform.Translate(Vector3.forward * Time.deltaTime); //Frames farkında performans eşitlemesi Time.deltaTime etkilidir.

        //this is get player input
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");

        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput); //Frames farkında performans eşitlemesi Time.deltaTime etkilidir.
        if (forwardInput != 0)
        {
            transform.Rotate(Vector3.up, horizontalInput * Time.deltaTime * turnSpeed);
        }

        // transform.Translate(Vector3.right * Time.deltaTime * turnSpeed * horizontalInput);
    }
}
