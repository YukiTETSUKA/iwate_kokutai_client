using UnityEngine;
using System.Collections;
public class CameraController : MonoBehaviour {
// Use this for initialization
		void Start () {
			
		}
		
		// Update is called once per frame
		void Update () {
		this.transform.Translate ( 0, ( Input.GetAxis ( "Vertical" ) * -1 ), 0 );
		this.transform.Translate ( ( Input.GetAxis ( "Horizontal" ) * -1 ), 0, 0 );

		//this.transform.Translate ( 0, 0, ( Input.GetAxis ( "X" ) * -1 ) );
		}
	}