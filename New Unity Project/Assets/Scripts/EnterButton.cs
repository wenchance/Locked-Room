using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class EnterButton : MonoBehaviour {

	public InputField infield;
	public string correctText;
	public GameObject ui;
	public GameObject winObject;

	public void CheckField ()
	{ if (infield.text == correctText) 
		{
			ui.SetActive (false);
			winObject.SetActive (true);
		}
	}
}
