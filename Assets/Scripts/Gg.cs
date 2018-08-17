using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security;

using JetBrains.Annotations;

using UnityEditor;

using UnityEngine;
using UnityEngine.UI;

public class Gg : MonoBehaviour {

	public List<PersonVariable> But = new List<PersonVariable>();
	
	void Start () 
	{
		Debug.Log("start");
	}

	public void OnClick(string name) {
		foreach (var i in But) {
			if (i.name == name) {
				i.value++;
				i.txt.text = i.name + " " + i.value;
			}
		}
		Debug.Log("Click" + " " + name);
	}
}