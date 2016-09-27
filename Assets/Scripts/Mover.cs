using UnityEngine;
using System.Collections;

public class Mover : MonoBehaviour 
{
	private Rigidbody rb;
	public float speed;

	void Awake ()
	{
		rb = GetComponent<Rigidbody> ();
	}
	// Use this for initialization
	void Start () 
	{
		rb.velocity = transform.forward * speed;
	}

}
