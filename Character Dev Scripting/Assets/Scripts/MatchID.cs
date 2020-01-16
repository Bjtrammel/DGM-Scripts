using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MatchID : MonoBehaviour
{
	/*private void OnTriggerEnter(Collider other)
	{
		if (other.CompareTag("fred"))
		{
			do work
		}*/

	public NameID nameIDobj;

	private void OnTriggerEnter(Collider other)
	{
		var other.nameID = other.GetComponent<MatchID().nameID
	}
}
