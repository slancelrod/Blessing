using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security;

using JetBrains.Annotations;

using UnityEditor;

using UnityEngine;
using UnityEngine.UI;

public class Gg : MonoBehaviour {

	public List<Text> TextButtons = new List<Text>(2);

	private List<PersonVariable> But = new List<PersonVariable>();
	
	void Start () 
	{
		Debug.Log("start");
		
		But.Add(new PersonVariable("Power",0));
		But.Add(new PersonVariable("Intellect",0));
		
	}

	public void OnClick(string name) {
		for (int i = 0; i < But.Count; i++) {
			if (But[i].name == name) {
				But[i].value++;
				TextButtons[i].text = But[i].name + " " + But[i].value;
			}
		}
	}
}