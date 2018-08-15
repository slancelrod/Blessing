using System.Collections;
using System.Collections.Generic;
using System.Linq;

using JetBrains.Annotations;

using UnityEditor;

using UnityEngine;
using UnityEngine.UI;

public class Gg : MonoBehaviour {

	public Text Power0; 
	
	public List<PersonVariable> Boot = new List<PersonVariable>();
	
	void Start () {
		Debug.Log("start");
		Boot.Add(new PersonVariable("Power",0));
		Power0.text = Boot[0].name;
	}
	
	public void Button_Onclick () {
		Debug.Log("Button Clicked");
		Boot[0].value++;
		Power0.text = Boot[0].name + " " + Boot[0].value;
	}
}