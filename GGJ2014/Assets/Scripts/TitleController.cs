﻿using UnityEngine;
using System.Collections;

public class TitleController : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyUp ("return") || Input.GetKeyUp ("enter")){
			Application.LoadLevel ("Level");
		}
	}
}