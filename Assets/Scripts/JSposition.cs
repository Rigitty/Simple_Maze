using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using static UnityEngine.GraphicsBuffer;

public class JSposition : MonoBehaviour
{
	public GameObject player;
	public GameObject robot;
	private Vector2 playerpos;
	public bool enable = true;
	private void Update()
	{
		if (enable)
		{
			playerpos = new Vector2(player.transform.position.x, player.transform.position.z);
			transform.LookAt(robot.transform);
			transform.position = new Vector3(playerpos.x, 0, playerpos.y);
		}
    }
}
