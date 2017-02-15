using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillPoints : MonoBehaviour {

	public int earnedPoints; 

	void OnTriggerEnter2D (Collider2D other)
	{
		if (other.gameObject.CompareTag ("chainsaw") == null)
			return;

		PointKeeper.addPoints (earnedPoints);

	}



}