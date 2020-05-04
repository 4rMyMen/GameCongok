using UnityEngine;
using System.Collections;

public class FlyCamera2 : MonoBehaviour {
	public float movementSpeed = 10.0f;
	

    void Start()
    {
        
    }

	void Update () {
		if (Input.GetKeyDown(KeyCode.W))//maju
        {
            
            transform.position += transform.forward * movementSpeed;
        }

        if (Input.GetKeyDown(KeyCode.S))//mundur
        {
            transform.position -= transform.forward * movementSpeed;
        }
	if (Input.GetKeyDown(KeyCode.A))//muter kiri
			transform.Rotate(0.0f, -90.0f, 0.0f, Space.Self);
		
	if (Input.GetKeyDown(KeyCode.D))//muter kanan
			transform.Rotate(0.0f, 90.0f, 0.0f, Space.Self);
       
        if (Input.GetKeyDown(KeyCode.E))//placeholder pindah lantai
		{
                if(transform.position.x<=-88 && transform.position.x>=-92)//cek posisi x
                {
                    if(transform.position.z<=212 && transform.position.z>=208)//cek posisi z
                    {
                        Application.LoadLevel("lt1");
                    }
                }
                if(transform.position.x<=-28 && transform.position.x>=-32)//cek posisi x
                {
                    if(transform.position.z<=92 && transform.position.z>=88)//cek posisi z
                    {
                        Application.LoadLevel("lt3");
                    }
                }
        }
    }
}