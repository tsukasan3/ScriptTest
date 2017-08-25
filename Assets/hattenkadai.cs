using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss{
	private int mp = 53;	//MP
	
	public void Magic(){
		if(mp >= 5){
			this.mp -= 5;
			Debug.Log("魔法攻撃をした。残りMPは" + this.mp +"。");
		}else{
			Debug.Log("MPが足りないため魔法が使えない。");
		}
	}
	
}

public class hattenkadai : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
		Boss lastboss = new Boss();
		
		for(int i = 1; i < 12; i++){
			//魔法攻撃用の関数を呼び出す
			lastboss.Magic();
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
