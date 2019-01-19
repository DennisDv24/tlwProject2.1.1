using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour{

	public Transform player;
	private float initial;

			void Start() {
				initial = player.position.y;
			}

		void Update(){
			transform.position = new Vector3(transform.position.x, player.position.y-initial, transform.position.z);
		}
}
