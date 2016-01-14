using UnityEngine;
using System.Collections;

public class PlayerMain : MonoBehaviour {

	// === 캐쉬 ==========================================
	PlayerController 	playerCtrl;

	// === 코드（Monobehaviour 기본 기능 구현） ================
	void Awake () {
		playerCtrl = GetComponent<PlayerController>();
	}

	void Update () {
		// 조작 가능한지 확인
		if (!playerCtrl.activeSts) {
			return;
		}

		// 패드 처리
		float joyMv = Input.GetAxis ("Horizontal");
		playerCtrl.ActionMove (joyMv);
		//Debug.Log ("joyMv = " + joyMv);

		// 점프
		if (Input.GetButtonDown ("Jump")) {
			playerCtrl.ActionJump ();
			return;
		}

		// 공격
		if (Input.GetButtonDown("Fire1") || Input.GetButtonDown("Fire2") || Input.GetButtonDown("Fire3")) {
			playerCtrl.ActionAttack();
		}
	}

}
