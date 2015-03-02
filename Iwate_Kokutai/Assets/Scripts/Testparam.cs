using UnityEngine;
using System.Collections;

public class Testparam : MonoBehaviour {

	public GameObject myCube;
	public GUIStyle buttonStyle;
	
	// Use this for initialization
	void Start () {
		
		//gameObject取得 
		myCube = GameObject.Find("iwate");
		
		//今の色コンソールに出力
		Debug.Log(myCube.renderer.material.color);
		
		//青色に変更
		myCube.renderer.material.color = Color.blue;
		
		//変更後の色コンソールに出力
		Debug.Log(myCube.renderer.material.color);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	
	void OnGUI(){
		//GUI.Button(Rect,テキスト,GUIStyle);
		GUI.Button(new Rect(10,10,100,200),"Hello",buttonStyle);
	}
}

