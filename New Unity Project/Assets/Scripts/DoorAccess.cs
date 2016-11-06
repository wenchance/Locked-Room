using UnityEngine;
using System.Collections;
using UnityStandardAssets.Characters.FirstPerson;

public class DoorAccess : MonoBehaviour {

	public GameObject ui;
	public FirstPersonController fpcontroller;

	void OnMouseDown()
	{
		Cursor.lockState = CursorLockMode.None;
		Cursor.visible = true;
		ui.SetActive (true);
		fpcontroller.enabled = false;
	}

}
