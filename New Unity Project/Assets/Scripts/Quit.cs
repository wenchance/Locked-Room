using UnityEngine;
using System.Collections;

public class Quit : MonoBehaviour {

	public void doExitGame() {
		Application.Quit ();
		Debug.Log ("Game is Exiting");
	}
}
