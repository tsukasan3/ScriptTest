﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kadai: MonoBehaviour {

	// Use this for initialization
	void Start () {
		//要素数5の配列を初期化する
		int[] array = {1, 2, 3, 4, 5};
		
		//配列の各要素を順番に表示する
		for(int i = 0; i < 5; i++){
			Debug.Log(array[i]);
		}
		
		//配列の各要素を逆順に表示する
		for(int i = 5; i > 0 ; i--){
			Debug.Log(array[i-1]);
		}
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
