using UnityEngine;
using System.Collections;

[RequireComponent(typeof(AudioSource))]
public class WrongBirdRev: MonoBehaviour {
	public Map2 map;
	
	public GameManager2 gameManager;
	
	public GUISkin skin;
	
	public bool isDead;
	
	public int moveSpeed;
	
	public int curScore;
	
	public AudioClip wings;
	
	private Ray ray; // The ray
	private RaycastHit hit; // What we hit
	//private GameObject selectorSprite;
	
	
	//private LayerMask mask = 0;
	
	void Start () {
		gameManager = (GameManager2) GameObject.FindObjectOfType(typeof(GameManager2));

		//determines depth of bird within environment
		int layerNum = Random.Range (0, 4);
		gameObject.renderer.sortingOrder = layerNum;
		//Debug.Log ("new bird" + gameObject.transform.position + gameObject.name);
		gameObject.transform.Rotate(new Vector3(0, 180f, 0));
		float deduct = (float)(0.015 * layerNum);
		gameObject.transform.localScale += new Vector3 (deduct, deduct, 0);
		
		//adjust shading 
		float shade = (float)(1 - 0.1 * (4 - layerNum));
		gameObject.renderer.material.color = new Vector4(shade, shade, shade, 1);

		//adjust speed
		moveSpeed = Random.Range (2, 5);
	}
	
	
	// Update is called once per frame
	void Update () {
		if (transform.position.x < -14) {
			Destroy (gameObject);
		}
		
		
		RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);
		
		if ((hit.collider != null) & Input.GetMouseButtonUp(0)) {
			//Debug.Log ("Target Position: " + hit.collider.gameObject.transform.position);
			audio.PlayOneShot(wings);
			gameManager.hearts--;
			Debug.Log ("wrong" + gameObject.name);
			Destroy (hit.collider.gameObject);
			
			if (gameManager.hearts == 0){
				gameManager.showGameOver = true;
			}
		}
		else {
			transform.Translate (transform.right * (-1) * moveSpeed * Time.deltaTime);
		}
	}

}

