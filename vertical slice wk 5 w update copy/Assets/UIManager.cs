using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;
using UnityEngine.UI;

public class UIManager : MonoBehaviour {

    public GameObject myInputField;
	
    void ShowInputField(){
        myInputField.SetActive(true);
    }

    void HideInputField()
    {
        myInputField.SetActive(false);
    }
}
