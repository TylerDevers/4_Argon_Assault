using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class PlayerController : MonoBehaviour {

	[Header("General")]
	[Tooltip("in Meters/second")] [SerializeField] float controlSpeed = 4f;
	[Tooltip("In meters")] [SerializeField] float xRange = 3f;
	[Tooltip("in Meters/second")] [SerializeField] float ySpeed = 4f;
	[Tooltip("In meters")] [SerializeField] float yRange = 2f;

	[Header("Screen-position Based")]
	[SerializeField] float positionPitchFactor = -5f;
	[SerializeField] float controlPitchFactor = -30f;

	[Header("Control-throw Based")]
	[SerializeField] float controlRollFactor = -20f;
	[SerializeField] float positionYawFactor = 7f;

	float xThrow, yThrow;
	bool controlsEnabled = true;

	void OnPlayerDeath()  //called from CollisionHandler
	{
		controlsEnabled = false;
		print("death is tested!");
	}

    // Update is called once per frame
    void Update () {
		if (controlsEnabled)
		{
			ProcessTranslation();
			ProcessRotation();
		}
	}

    private void ProcessRotation()
    {
		float pitchDueToPostion = transform.localPosition.y * positionPitchFactor;
		float pitchDueToControl = yThrow * controlPitchFactor;
		float pitch =  pitchDueToControl + pitchDueToPostion; 
		float roll = xThrow * controlRollFactor;
		float yaw = transform.localPosition.x * positionYawFactor;

        transform.localRotation = Quaternion.Euler(pitch, yaw, roll);
    }

    private void ProcessTranslation()
    {
        xThrow = CrossPlatformInputManager.GetAxis("Horizontal");
		yThrow = CrossPlatformInputManager.GetAxis("Vertical");
		float xOffset = xThrow * controlSpeed * Time.deltaTime;
		float yOffset = yThrow * ySpeed * Time.deltaTime;
		float rawXPos = transform.localPosition.x + xOffset;
		float rawYPos = transform.localPosition.y + yOffset;
		float clampedXPos = Mathf.Clamp(rawXPos, -xRange, xRange);
		float clampedYPos = Mathf.Clamp(rawYPos, -yRange, yRange); 

		transform.localPosition = new Vector3(clampedXPos, transform.localPosition.y, transform.localPosition.z);
		transform.localPosition = new Vector3(transform.localPosition.x, clampedYPos, transform.localPosition.z);

    }

}
