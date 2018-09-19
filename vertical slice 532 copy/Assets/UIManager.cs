using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;
using UnityEngine.UI;

public class UIManager : MonoBehaviour {

	public InputField intentionInput;


	void RevealTextInput(){
		intentionInput.ActivateInputField ();
	}
}
