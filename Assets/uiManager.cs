using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class uiManager : MonoBehaviour {

  public Canvas mainMenu;
  public Canvas settingsMenu;

  // Use this for initialization
  void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

  public void showSettingsMenu () {
    mainMenu.enabled = false;
    settingsMenu.enabled = true;
  }

  public void hideSettingsMenu()
  {
    settingsMenu.enabled = false;
    mainMenu.enabled = true;
  }

}
