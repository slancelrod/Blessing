using System.Collections;
using System.Collections.Generic;
using System.Linq;

using UnityEngine;
using UnityEngine.UI;

public class Gg : MonoBehaviour {

	public Text Power;
	
	private int i = 0;
	
	// Use this for initialization
	void Start () {
		Debug.Log("start");
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void Button_Onclick () 
	{
		Debug.Log("Button Clicked");
		
		i++;
		Power.text = i.ToString();
	}
}