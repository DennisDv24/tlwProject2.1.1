using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController:MonoBehaviour{

public float velocity = 0.2f;
public float rotationRatio = 0.3f;
private float rotation;
	public bool alive;
	void Start() => alive=true;

		void FixedUpdate(){
			gameState();
			movement();
		}
			void gameState(){
				if (!alive){
					gameOver();
				}
			}

			void movement(){
				transform.Translate(Vector3.up * velocity);
					if (Input.GetKey("right")){
						rightMove();
					}
					else if (Input.GetKey("left")){
						leftMove();
					}
			}
				void rightMove(){
					transform.Rotate(Vector3.forward, transform.rotation.z + rotation);
					rotation = -rotationRatio;
				}
				void leftMove(){
					transform.Rotate(Vector3.forward, transform.rotation.z + rotation);
					rotation = +rotationRatio;
				}

		void gameOver() {
			SceneManager.LoadScene("GameOverScene");
		}
}
