using UnityEngine;
using System.Collections;

public class TurretRotator : MonoBehaviour
{
	public int speed;

	void Update () 
	{
		transform.Rotate(new Vector3(0,45,0) * Time.deltaTime * speed);
	}
}
