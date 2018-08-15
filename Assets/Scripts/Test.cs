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

	public PersonVariable(string newName, int newValue)
	{
		name = newName;
		value = newValue;
	}

}
