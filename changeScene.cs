﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System;

public class changeScene : MonoBehaviour{

	public String sceneToLoad;

		public void change(){
			SceneManager.LoadScene(sceneToLoad);
		}
}
