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
		if (gameManager) {
			Debug.Log ("GUITexture object found: " + gameManager.name);
		}
		else
			Debug.Log("No gameManager object could be found");
		
		//determines depth of bird within environment
		int layerNum = Random.Range (0, 4);
		gameObject.renderer.sortingOrder = layerNum;
		Debug.Log ("new bird" + gameObject.transform.position + gameObject.name);
		gameObject.transform.Rotate(new Vector3(0, 180f, 0));
		float deduct = (float)(0.015 * layerNum);
		gameObject.transform.localScale += new Vector3 (deduct, deduct, 0);
	}
	
	
	// Update is called once per frame
	void Update () {
		if (transform.position.x > 8) {
			Debug.Log ("dead bird" + gameObject.transform.position);
			Destroy (gameObject);
		}
		
		
		RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);
		
		if (hit.collider != null) {
			Debug.Log ("Target Position: " + hit.collider.gameObject.transform.position);
			audio.PlayOneShot(wings);
			gameManager.hearts--;
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

