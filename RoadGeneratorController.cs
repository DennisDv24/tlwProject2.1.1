using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoadGeneratorController:MonoBehaviour{
public PlayerController player;

	private int iterations = 0;

	private int[] type = new int[2];
		private int typeCount = 3;//Numero provesional, cuantas mas tipos de conexiones aparezcan mas habra
			private GameObject[,,] roadPrefab;
					public GameObject[] allPrefabs;//The count must be (typeCount**2)*prefabsForEachType, ///in this case its 27
					public int prefabsForEachType = 3;
						private GameObject[] roads;
							public int maxRoadsPermitedInScreen = 8;
							private int roadCount = 0;
			private Vector3 nextRoadPostion;

public void Start(){
	transformPrefabsToTensor();
	setSomeValues();
	firstInstatiations();
}

	void transformPrefabsToTensor(){
		roadPrefab = new GameObject[typeCount,typeCount,prefabsForEachType];
			int totalIterations = 0;
				for(int i = 0; i<typeCount; i++){
					for(int j = 0; j<typeCount; j++){
						for(int n = 0; n<prefabsForEachType;n++){
							roadPrefab[i,j,n] = allPrefabs[totalIterations];
							totalIterations++;
						}
					}
				}
						
	}

		void setSomeValues(){
			roads = new GameObject[maxRoadsPermitedInScreen];
			nextRoadPostion.z = 1;
		}

		void firstInstatiations(){
			for(int i = 0; i<1; i++){
				nextRoadPostion.y+=10;
				calcType();
					roads[i] = Instantiate(roadPrefab[type[0] , type[1] , Random.Range(0,prefabsForEachType)],
										   nextRoadPostion,
										   Quaternion.identity);
					
					roads[i].transform.parent = transform;
						roadCount++;
			}
			nextRoadPostion.y+=10;
									
		}


	public void generateNextRoadPiece(){ 
		calcType();
			transformRoadsArray();
			instantiateNextRoad();
			calculateInfoAboutGeneration();
	}

		void transformRoadsArray(){
			if(roadCount==maxRoadsPermitedInScreen){
				for(int i = 0; i<roads.Length-1; i++){
					roads[i] = roads[i+1];
				}
					roadCount--;
			}
		}

		void instantiateNextRoad(){
			roads[roadCount] = Instantiate(roadPrefab[type[0] , type[1] , Random.Range(0,prefabsForEachType)],
										   nextRoadPostion,
										   Quaternion.identity);

			roads[roadCount].transform.parent = transform;
		}

			void calculateInfoAboutGeneration(){
				roadCount++;
				iterations++;
				nextRoadPostion.y+=10;
			}


		void calcType(){
			type[0] = type[1];
			type[1] = Random.Range(0,typeCount);
		}
}

