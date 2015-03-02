using UnityEngine;
using System.Collections;

public class next : MonoBehaviour {
	public GameObject colorinfo;
	// Use this for initialization
	void Start () {
		DontDestroyOnLoad (colorinfo);
	}
	
	void Update () {}
	
	void  Iwate(){
		Application.LoadLevel("iwate");
	}
	void akita(){Application.LoadLevel("akita");}
	void aomori(){Application.LoadLevel("aomori");}

}
