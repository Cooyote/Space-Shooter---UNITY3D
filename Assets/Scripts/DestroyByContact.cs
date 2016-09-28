using UnityEngine;
using System.Collections;

public class DestroyByContact : MonoBehaviour 
{
	public GameObject explosion;
	public GameObject playerExplosion;
	public int scoreValue;

	private GameController gameController;

	void Awake()
	{
		
	}

	void Start()
	{
		GameObject gameControllerObject = GameObject.FindGameObjectWithTag ("GameController");

		if (gameControllerObject != null) 
		{
			gameController = gameControllerObject.GetComponent<GameController> ();
		}
		else  
		{
			Debug.Log("Cannot find gameController Script");
		}
	}

	void OnTriggerEnter(Collider other)
	{
		if (other.CompareTag ("Boundary")) 
		{
			return;
		}

		Instantiate (explosion, transform.position, transform.rotation);

		if (other.CompareTag ("Player")) 
		{	
			Instantiate (playerExplosion, other.transform.position, other.transform.rotation);
			gameController.GameOver ();
		}

		gameController.AddScore (scoreValue);
		Destroy (other.gameObject);
		Destroy (gameObject);
	}
}
