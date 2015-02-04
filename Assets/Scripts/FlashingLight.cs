using UnityEngine;
using System.Collections;

[RequireComponent(typeof(Light))]
public class FlashingLight : MonoBehaviour {
	private Light FlashLightOB;
	public float frec = 0.2f; //Increase to make it faster
	
	void Start()
	{
		FlashLightOB = GetComponent<Light>();
		frec = Mathf.Clamp01(frec);
	}
	
	void Update(){
		if (Time.timeScale > 0f){
			float RandomNumber = Random.value;
			
			if (RandomNumber <= frec)
			{
				FlashLightOB.enabled = true;
			}
			else
			{
				FlashLightOB.enabled = false;
			}
		}
	}
}