using UnityEngine;
using System.Collections;

public class StartTerminal : MonoBehaviour
{
	void OnMouseDown()
	{
		Debug.Log ("Reading this terminal!");
		GUI.Label(new Rect(5,5,400,100), "This is a terminal that would give useful info or story.");
	}
}
