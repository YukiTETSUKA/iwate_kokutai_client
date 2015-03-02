using UnityEngine;

public class Textfrom : MonoBehaviour 
{
	private string text = "";
	void OnGUI()
	{
		Rect rect1 = new Rect(10, 430, 400, 170);
		text = GUI.TextField(rect1, text, 16);
	}
}