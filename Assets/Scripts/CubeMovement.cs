﻿using UnityEngine;
using System.Collections;

public class CubeMovement : MonoBehaviour 
{
	public float speed;

	// Use this for initialization
	void Start () 
	{
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (Input.GetKey (KeyCode.W)) 
		{
			transform.Translate(0,0,speed*Time.deltaTime);
		}

		if (Input.GetKey (KeyCode.S)) 
		{
			transform.Translate(0,0,-speed*Time.deltaTime);
		}

		if (Input.GetKey (KeyCode.A)) 
		{
			transform.Translate(-speed*Time.deltaTime,0,0);
		}
		
		if (Input.GetKey (KeyCode.D)) 
		{
			transform.Translate(speed*Time.deltaTime,0,0);
		}
	
	}
}
