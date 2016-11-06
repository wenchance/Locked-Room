using UnityEngine;
using System.Collections;
using UnityStandardAssets.Characters.FirstPerson;

public class ExitButton : MonoBehaviour {

	public GameObject ui;
	public FirstPersonController fpcontroller;

	public void CloseUi () {
		ui.SetActive (false);
		fpcontroller.enabled = true;
	}
}
