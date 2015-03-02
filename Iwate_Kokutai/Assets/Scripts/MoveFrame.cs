using UnityEngine;
using System.Collections;

public class MoveFrame : MonoBehaviour {
	private float movelimit = -5.2f;
	public float movespeed;
	private float timer;
	Vector3 m_pos;

	// Use this for initialization
	void Start () {
		transform.localPosition = m_pos;
		timer = 0.0f;
		movespeed = -0.2f;
	}
	
	// Update is called once per frame
	void Update () {
		if (transform.localPosition.y >= movelimit) {
			m_pos.y += movespeed*(timer);
			m_pos.z = 42.5f;
			transform.localPosition = m_pos;
		}
		timer += Time.deltaTime;
	}
}
