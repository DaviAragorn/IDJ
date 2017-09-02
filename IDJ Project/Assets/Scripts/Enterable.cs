using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enterable : Interactable {
    public string LevelName;
	// Use this for initialization
	void Start () {
        Application.LoadLevel(LevelName);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
