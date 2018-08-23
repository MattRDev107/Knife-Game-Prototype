using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {

    public GameObject playerKnife;
    

    void Start() {
        Instantiate(playerKnife, transform.position, Quaternion.identity);
    }

    void Update() {
        GameObject[] spawnPosDupications = GameObject.FindGameObjectsWithTag("Spawn");
        foreach(GameObject spawnPos in spawnPosDupications){
            if(spawnPos.name == "SpawnPos(Clone)"){
                Destroy(spawnPos);
            }
        }
        Screen.orientation = ScreenOrientation.Portrait;
    }
}
