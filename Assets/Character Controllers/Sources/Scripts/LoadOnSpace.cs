using UnityEngine;
using System.Collections;

public class LoadOnSpace : MonoBehaviour
{
	void Update ()
	{
		if(Input.GetKeyDown(KeyCode.Space)) 
			Application.LoadLevel("Level 1");
	}
}
