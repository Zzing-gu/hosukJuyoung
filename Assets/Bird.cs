using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : MonoBehaviour {

	private GameObject MyBird;
	private Rigidbody rBody;

	// Moving Value
	private float status_JumpPower;	// 점프하는 힘
	private float status_Forward;	// 전진하는 속도
	private float status_Backstep;	// 벽에 부딛히고 뒤로 물러나는 힘
	private bool status_hit;

	// Life
	private bool isAlive;			// 생존여부
	private int status_MaxHeart;	// 최대 생명력 
	private int status_CurrHeart;	// 현재 생명력




	// Use this for initialization
	void Start () {
		MyBird = this.gameObject;
		rBody = GetComponent<Rigidbody> ();

		status_JumpPower = 20f;
		status_Forward = 10f;
		status_Backstep = 100f;
		status_hit = false;

		isAlive = true;
		status_MaxHeart = 3;
		status_CurrHeart = 3;
	}
	
	// Update is called once per frame
	void Update () {

		if (!status_hit) {
			//MyBird.transform.Translate (Vector3.forward * status_Forward * Time.deltaTime);
		}



		if (Input.GetKeyDown(KeyCode.Space)) {
			Debug.Log ("Jump");
			rBody.AddForce (transform.up * status_JumpPower, ForceMode.Impulse);
			rBody.velocity = Vector3.zero;
		}
	}
}
