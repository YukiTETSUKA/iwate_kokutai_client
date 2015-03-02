using UnityEngine;
using System.Collections;

public class ouen : MonoBehaviour {
	public GameObject img;
	public GameObject img2;
	public GameObject img3;
	public GameObject img4;
	public GameObject img5;
	// Use this for initialization
	void Start () {
		img.SetActive (true);
		img2.SetActive (false);
		img3.SetActive (false);
		img4.SetActive (false);
		img5.SetActive (true);
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void changeimg(){
		img.SetActive (false);
		img2.SetActive (true);
		img3.SetActive (true);
		img4.SetActive (true);
		img5.SetActive (false);
	}
	void goback(){
		Application.LoadLevel (1);
		}
}
