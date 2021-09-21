using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class CameraController : MonoBehaviour
{
	public GameObject player;

	public Transform followTarget;

	public Transform camRoot;

	public Transform cam;

	[SerializeField]
	private float positionRate = 4;

	[SerializeField]
	private float sensitivity = .1f;

	// Start is called before the first frame update
	void Start()
    {
	}

	void FixedUpdate()
	{
		float mousePos = player.GetComponent<InputManager>().cameraVector.x;
		float deltaTime = Time.deltaTime;
		transform.RotateAround(followTarget.position, Vector3.up, mousePos * sensitivity);
		transform.position = Vector3.Lerp(transform.position, followTarget.position, deltaTime * positionRate);
	}
}
