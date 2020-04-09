using UnityEngine;
using System.Collections;

public class FlyCamera1 : MonoBehaviour {
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
                if(transform.position.x<=12 && transform.position.x>=8)//cek posisi x
                {
                    if(transform.position.z<=222 && transform.position.z>=218)//cek posisi z
                    {
                        Application.LoadLevel("lt2");
                    }
                }
        }
    }
}