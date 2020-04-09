using UnityEngine;
using System.Collections;

public class FlyCamera5 : MonoBehaviour {
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
				if(transform.position.x<=-108 && transform.position.x>=-112)//cek posisi x
				{
					if(transform.position.z<=242 && transform.position.z>=238)//cek posisi z
					{
						Application.LoadLevel("lt4");
					}
				}
				if(transform.position.x<=2 && transform.position.x>=-2)//cek posisi x
				{
					if(transform.position.z<=2 && transform.position.z>=-2)//cek posisi z
						{
							Application.LoadLevel("lt6");
						}
				}
				
		}		
	}
}