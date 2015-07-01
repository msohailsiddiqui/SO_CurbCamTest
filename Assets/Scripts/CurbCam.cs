using UnityEngine;
using System.Collections;

public class CurbCam : MonoBehaviour 
{
	public Transform targetPosition;
	public float camWindowDimension;

	Vector2 targetScreenPos;
	float deltaX;
	float deltaZ;
	// Use this for initialization
	void Start () 
	{
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		//convert target pos to 2D
		targetScreenPos = Camera.main.WorldToScreenPoint (targetPosition.position);

		if (targetScreenPos.x > (Screen.width/2) + camWindowDimension) 
		{
			deltaX = targetScreenPos.x - ((Screen.width/2) + camWindowDimension);
			transform.position = new Vector3(transform.position.x + deltaX, transform.position.y, transform.position.z);
		}

		if (targetScreenPos.x < (Screen.width/2) - camWindowDimension) 
		{
			deltaX = targetScreenPos.x - ((Screen.width/2) - camWindowDimension);
			transform.position = new Vector3(transform.position.x + deltaX, transform.position.y, transform.position.z);
		}

		if (targetScreenPos.y > (Screen.height/2) + camWindowDimension) 
		{
			deltaZ = targetScreenPos.y - ((Screen.height/2) + camWindowDimension);
			transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z + deltaZ);
		}

		if (targetScreenPos.y < (Screen.height/2) - camWindowDimension) 
		{
			deltaZ = targetScreenPos.y - ((Screen.height/2) - camWindowDimension);
			transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z + deltaZ);
		}
	
	}
}
