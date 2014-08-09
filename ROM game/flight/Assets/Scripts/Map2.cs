using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Map2 : MonoBehaviour {

	//secs between generating new birds
	//public float genRate;

	//ref to flock objects
	public GameManager2 manager;

	public GameObject pgnObject; //most common

	public GameObject psgObject;

	public GameObject carObject;

	public GameObject owlObject;

	public GameObject gsObject;

	//reverse versions
	public GameObject pgnRObject; //most common
	
	public GameObject psgRObject;
	
	public GameObject carRObject;
	
	public GameObject owlRObject;

	public GameObject gsRObject;

	private float nextActionTime = 0.0f;
	public float period;



	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {

		if (Time.time > nextActionTime) {
			nextActionTime += period;
			int randomNumber = Random.Range (0, 3);
			if (randomNumber == 0){
				GenerateColumn1 ();}
			else if (randomNumber == 1){
				GenerateColumn2 ();}
			else {
				GenerateColumn3 ();}
		}

		}

	//random bird, speed, direction
	//column 1: at y = 3
	void GenerateColumn1 (){
		int randomNumber = Random.Range(0, 2);
		//forward
		if (randomNumber == 0) {
			GenerateColumn(new Vector2(-10f, 4.5f));
		} 
		//reverse
		else {
			GenerateColumnRev(new Vector2(8.5f, 4.5f));
		}

	}

	//column 2: at y = 0
	void GenerateColumn2 (){
		int randomNumber = Random.Range (0, 2);
		//forward
		if (randomNumber == 0) {
			GenerateColumn(new Vector2(-10, 0));
		} 
		//reverse
		else {
			GenerateColumnRev(new Vector2(8f, 0f));
		}
	}

	//column 3: at y = -3
	void GenerateColumn3 (){
		int randomNumber = Random.Range (0, 2);
		//forward
		if (randomNumber == 0) {
			GenerateColumn(new Vector2(-10, -3));
		} 
		//reverse
		else {
			GenerateColumnRev(new Vector2(8f, -3f));
		}

	}


	void GenerateColumn (Vector2 vector){
		float randomNumber = Random.Range (0.0f, 10.0f);
		if (randomNumber < 0.5f) {
			GameObject InsObject = (GameObject)Instantiate (pgnObject, vector, Quaternion.identity);
			//InsObject.transform.parent = this.transform;
		} 
		else if (randomNumber < 0.6f) {
			GameObject InsObject = (GameObject)Instantiate (owlObject, vector, Quaternion.identity);
			//InsObject.transform.parent = this.transform;
		}
		else if (randomNumber < 0.7f) {
			GameObject InsObject = (GameObject)Instantiate (psgObject, vector, Quaternion.identity);
			//InsObject.transform.parent = this.transform;
		}
		
		else if (randomNumber < 0.8f) {
			GameObject InsObject = (GameObject)Instantiate (carObject, vector, Quaternion.identity);
			//InsObject.transform.parent = this.transform;
		}
		
		else if (randomNumber < 1.3f) {
			GameObject InsObject = (GameObject)Instantiate (gsObject, vector, Quaternion.identity);
			//InsObject.transform.parent = this.transform;
		}
		
	}

	void GenerateColumnRev (Vector2 vector){
		float randomNumber = Random.Range (0.0f, 10.0f);
		if (randomNumber < 0.5f) {
			GameObject InsObject = (GameObject)Instantiate (pgnRObject, vector, Quaternion.identity);
			//InsObject.transform.parent = this.transform;
		} 
		else if (randomNumber < 0.55f) {
			GameObject InsObject = (GameObject)Instantiate (owlRObject, vector, Quaternion.identity);
			//InsObject.transform.parent = this.transform;
		}
		else if (randomNumber < 0.6f) {
			GameObject InsObject = (GameObject)Instantiate (psgRObject, vector, Quaternion.identity);
			//InsObject.transform.parent = this.transform;
		}
		
		else if (randomNumber < 0.65f) {
			GameObject InsObject = (GameObject)Instantiate (carRObject, vector, Quaternion.identity);
			//InsObject.transform.parent = this.transform;
		}

		else if (randomNumber < 1.15f) {
			GameObject InsObject = (GameObject)Instantiate (gsRObject, vector, Quaternion.identity);
			//InsObject.transform.parent = this.transform;
		}
		
	}
}
