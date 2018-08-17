using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[System.Serializable]
public class PersonVariable
{
	
	public string name;
	public int value ;
	public Text txt;
	
	public PersonVariable(string newName, int newValue,Text newTxt)
	{
		name = newName;
		value = newValue;
		txt = newTxt;
	}

}
