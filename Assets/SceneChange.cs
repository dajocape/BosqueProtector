﻿using System.Collections;

using System.Collections.Generic;

using UnityEngine;
using UnityEngine.SceneManagement;


public class SceneChange : MonoBehaviour {


	
	// Use this for initialization

	void Start () {
	
	
	
	}


	
// Update is called once per frame

	void Update () {
	
	
	
	}


	public void ChangeScene(){
		SceneManager.LoadScene("Forest Scene");
	}

	public void Volver(){
		SceneManager.LoadScene("Bosque");
	}
}
