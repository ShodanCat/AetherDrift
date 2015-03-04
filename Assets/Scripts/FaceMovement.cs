using UnityEngine;
using System.Collections;

public class FaceMovement : MonoBehaviour
{
	void Update()
	{
		if(Input.GetKey ("a") && Mathf.RoundToInt (transform.eulerAngles.y) == 90)
		{
			transform.Rotate (Vector3.up, -180.0f);
		}

		if(Input.GetKey("d") && Mathf.RoundToInt (transform.eulerAngles.y) == 270)
		{
			transform.Rotate (Vector3.up, 180.0f);
		} 
	}
}