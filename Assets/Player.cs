using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class Player : MonoBehaviour {

	[Tooltip("in Meters/second")] [SerializeField] float xSpeed = 4f;
	[Tooltip("In meters")] [SerializeField] float xRange = 3f;
	[Tooltip("in Meters/second")] [SerializeField] float ySpeed = 4f;
	[Tooltip("In meters")] [SerializeField] float yRange = 2f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		float xThrow = CrossPlatformInputManager.GetAxis("Horizontal");
		float yThrow = CrossPlatformInputManager.GetAxis("Vertical");
		float xOffset = xThrow * xSpeed * Time.deltaTime;
		float yOffset = yThrow * ySpeed * Time.deltaTime;
		float rawXPos = transform.localPosition.x + xOffset;
		float rawYPos = transform.localPosition.y + yOffset;
		float clampedXPos = Mathf.Clamp(rawXPos, -xRange, xRange);
		float clampedYPos = Mathf.Clamp(rawYPos, -yRange, yRange); 

		transform.localPosition = new Vector3(clampedXPos, transform.localPosition.y, transform.localPosition.z);
		transform.localPosition = new Vector3(transform.localPosition.x, clampedYPos, transform.localPosition.z);
	}
}
