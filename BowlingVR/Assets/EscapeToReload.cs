﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EscapeToReload : MonoBehaviour {

    public string _sceneToLoad;
    void Update() {
        if (Input.GetKeyDown(KeyCode.Escape)) {

            SceneManager.LoadScene(_sceneToLoad);
        }
		
	}
}
