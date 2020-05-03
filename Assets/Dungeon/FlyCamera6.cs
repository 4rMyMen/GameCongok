using UnityEngine;
using System.Collections;

public class FlyCamera6 : MonoBehaviour {
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
		if (Input.GetKeyDown(KeyCode.A))
				transform.Rotate(0.0f, -90.0f, 0.0f, Space.Self);//muter kiri
			
		if (Input.GetKeyDown(KeyCode.D))
				transform.Rotate(0.0f, 90.0f, 0.0f, Space.Self);//muter kanan
			
		if (Input.GetKeyDown(KeyCode.E))//placeholder pindah lantai
		{
				if(transform.position.x<=2 && transform.position.x>=-2)//cek posisi x
				{
					if(transform.position.z<=162 && transform.position.z>=158)//cek posisi z
					{
						Application.LoadLevel("lt5");
					}
				if(transform.position.z<=142 && transform.position.z>=138)//cek posisi z
					{
						Application.LoadLevel("lt7");
					}
				}
		}		
	}
}