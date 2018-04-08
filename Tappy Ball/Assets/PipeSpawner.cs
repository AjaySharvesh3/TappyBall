using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawner : MonoBehaviour {

	public float maxYpos;
	public float SpawnTime;
	public GameObject pipe;

	// Use this for initialization
	void Start () {
		//StartSpawningPipes ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void StopSpawningPipes() {
		CancelInvoke ("SpawnPipes");
	}

	public void StartSpawningPipes() {
		InvokeRepeating ("SpawnPipes", 0.2f, SpawnTime);
	}

	void SpawnPipes() {
		Instantiate (pipe, new Vector3 (transform.position.x, Random.Range (-maxYpos, maxYpos), 0), Quaternion.identity);
	}
}
