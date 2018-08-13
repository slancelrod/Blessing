using System.Collections;
using System.Collections.Generic;
using System.Linq;

using JetBrains.Annotations;

using UnityEngine;
using UnityEngine.UI;

public class Gg : MonoBehaviour {

	public Text Power; 
	public PersonVariable Hts;
	List<PersonVariable> lizt = new List<PersonVariable>();
	void Start () {
		Debug.Log("start");
		Hts = new PersonVariable();
		Hts.name = "Power";
		Power.text = Hts.name;
	}
	
	public void Button_Onclick () {
		Debug.Log("Button Clicked");
		Hts.value++;
		Power.text = Hts.name + " " + Hts.value;
	}
}