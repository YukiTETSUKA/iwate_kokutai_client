using UnityEngine;
using System.Collections;

public class colorcontroller : MonoBehaviour {
		
	public GameObject iwate;
	public GameObject akita;
	public GameObject aomori;
	public GameObject miyagi;
	public GameObject yamagata;
	public GameObject fukushima;
	public int num = 6;
	public float[] score;
	

		
	// Use this for initialization
	void Start () {
		for (int i = 0; i < num; i++) {
			score[i] = Random.value;		
		}

		//gameObject取得 
		iwate = GameObject.Find("iwate");
		aomori = GameObject.Find ("aomori");
		akita = GameObject.Find("akita");
		miyagi = GameObject.Find("miyagi");
		yamagata = GameObject.Find("yamagata");
		fukushima = GameObject.Find("fukushima");
		changecolor (score [0], iwate);
		changecolor (score [1], akita);
		changecolor (score [2], aomori);
		changecolor (score [3], miyagi);
		changecolor (score [4], yamagata);
		changecolor (score [5], fukushima);
		}
		
		// Update is called once per frame
		void Update () {
			
		}
	void changecolor(float getscore, GameObject chiiki){
		if (getscore >= 0.0f && getscore <= 0.3f) {
			chiiki.renderer.material.color = new Color (0.71f, 0.72f, (0.7f+getscore/10));
		}
		else if (getscore > 0.3 && getscore < 0.6) {
			chiiki.renderer.material.color = new Color (0.72f, (0.7f+getscore/10), 0.72f);
		}
		else if (getscore > 0.6 && getscore <= 1.0) {
			chiiki.renderer.material.color = new Color ((0.7f+getscore/10), 0.71f,0.72f);
		}
	}
}
