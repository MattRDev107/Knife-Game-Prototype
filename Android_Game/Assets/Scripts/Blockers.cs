using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blockers : MonoBehaviour {

	public GameObject blockers;
	private GameObject[] spawnPoints; 

	void start(){
		spawnPoints = GameObject.FindGameObjectsWithTag("SpawnPoint");
		foreach(GameObject spawnPoint in spawnPoints){
			Instantiate(blockers,spawnPoint.transform.position, Quaternion.identity);
		}
	}

}
