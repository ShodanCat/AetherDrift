using UnityEngine;
using System.Collections;

public class Crouch : MonoBehaviour
{
	Animator anim;
	bool isCrouching = false;

	void Awake ()
	{
		anim = GetComponent<Animator>();
	}

	void Update ()
	{
		if(Input.GetKey ("s")) isCrouching = true;
		else isCrouching = false;
		anim.SetBool ("isCrouching", isCrouching);
	}
}
