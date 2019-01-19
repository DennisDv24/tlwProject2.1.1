using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoadController:MonoBehaviour{

private PlayerController player;
private RoadGeneratorController generator;

	void Start(){
		generator = GetComponentInParent<RoadGeneratorController>();
		player = GetComponentInParent<RoadGeneratorController>().player;
	}

			void OnTriggerStay2D(){
				player.alive = true;
			}
			void OnTriggerEnter2D() {
				print("done");
				player.alive = true;
				generator.generateNextRoadPiece();
			}
			void OnTriggerExit2D(){
				player.alive = false;
				Destroy(gameObject,3);
			}
}

