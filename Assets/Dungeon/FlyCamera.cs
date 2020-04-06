using UnityEngine;
using System.Collections;

public class FlyCamera : MonoBehaviour {
	public float movementSpeed = 10.0f;
	

    void Start()
    {
        
    }

	void Update () {
		 if (Input.GetKeyDown(KeyCode.W))
        {
            
            transform.position += transform.forward * movementSpeed;
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            transform.position -= transform.forward * movementSpeed;
        }
		if (Input.GetKeyDown(KeyCode.A))
				transform.Rotate(0.0f, -90.0f, 0.0f, Space.Self);
		
		if (Input.GetKeyDown(KeyCode.D))
				transform.Rotate(0.0f, 90.0f, 0.0f, Space.Self);
	}
}