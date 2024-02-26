using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Threading;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
	public GameObject sett;
	public float speed;
	private CharacterController controller;
	private Vector3 moveInputs;
	private Vector3 moveVelocity;
	public bool isground;
	public GameObject isground_mesh;
	public float isground_radius;
	public LayerMask obstaclelayer;
	private Vector3 velocity;
	public float gravity;
	public float jumpheight;
	public float gravitydivide;
	public GameObject maincamera;
	public GameObject followflashlight;
	public float sensivity;
	private float getaxismousey=0;
	private float defaultspeed;
	private bool counter;
	public GameObject head;
	public GameObject lstosprintobj;
	[Header("Headbob parameters")]
	[SerializeField] private bool canusehadbob = true;
	[SerializeField] private float walkbobspeed = 14f;
	[SerializeField] private float walkbobamount = 0.05f;
	[SerializeField] private float sprintbobspeed = 18f;
	[SerializeField] private float sprintbobamount = 0.1f;
	private bool issprinting;
	private float defaultYpos = 0;
	private float timer;

	private void HandleHeadbob()
	{
		if (!isground) return;
		if(Mathf.Abs(moveVelocity.x)>0.01f || Mathf.Abs(moveVelocity.z) > 0.01f)
		{
			timer += Time.deltaTime * (issprinting ? sprintbobspeed : walkbobspeed);
			Camera.main.transform.localPosition = new Vector3(Camera.main.transform.localPosition.x,
				defaultYpos + Mathf.Sin(timer) * (issprinting ? sprintbobamount : walkbobamount),
				Camera.main.transform.localPosition.z);
		}
	}
	private void Awake()
	{
		sett = GameObject.FindGameObjectWithTag("Sett");
		defaultspeed = speed;
		//Cursor
		Cursor.visible = false;
		Cursor.lockState = CursorLockMode.Locked;
		controller=GetComponent<CharacterController>();

		defaultYpos = Camera.main.transform.localPosition.y;
	}
	private void Start()
	{
		StartCoroutine(lstosprint());
	}
	private void Update()
	{
		if (sett != null)
			sensivity = sett.GetComponent<Dontdestroy>().mousesens;
		if (Input.GetKey(KeyCode.LeftShift))
		{
			if (counter == false)
			{
				speed = speed * 1.5f;
				counter=true;
				issprinting = true;
			}
		}
		else
		{
			speed = defaultspeed;
			counter = false;
			issprinting = false;
		}
		isground = Physics.CheckSphere(isground_mesh.transform.position, isground_radius,obstaclelayer);
		if (!isground)
		{
			velocity.y = velocity.y+gravity / gravitydivide * Time.deltaTime;
		}
		else
		{
			velocity.y = -0.1f;
		}

		if (Input.GetKeyDown(KeyCode.Space)&&isground)
		{
			velocity.y = Mathf.Sqrt(jumpheight * -2 * gravity/gravitydivide * Time.deltaTime);
		}

		moveInputs = Input.GetAxis("Horizontal") * transform.right + Input.GetAxis("Vertical") * transform.forward;
		moveVelocity = moveInputs * speed * Time.deltaTime;
		controller.Move(moveVelocity);
		controller.Move(velocity*Time.deltaTime);

		transform.Rotate(0, Input.GetAxis("Mouse X") * sensivity*Time.deltaTime, 0);
		getaxismousey = getaxismousey - (Input.GetAxis("Mouse Y") * sensivity * Time.deltaTime);
		if(getaxismousey>90) {
			getaxismousey = 90;
		}
		if (getaxismousey < -90)
		{
			getaxismousey = -90;
		}
		maincamera.transform.localRotation=Quaternion.Euler(getaxismousey, 0, 0);
		followflashlight.transform.localRotation = Quaternion.Euler(getaxismousey, 0, 0);

		if (canusehadbob)
		{
			HandleHeadbob();
		}
	}

	IEnumerator lstosprint()
	{
		yield return new WaitForSeconds(5f);
		lstosprintobj.GetComponent<Animator>().SetTrigger("showtext");
	}
}
