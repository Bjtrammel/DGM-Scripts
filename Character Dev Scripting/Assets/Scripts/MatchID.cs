using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MatchID : MonoBehaviour
{

	public List<NameID> nameIDList;
	
	private void OnTriggerEnter(Collider other)
	/*{
		var doWorkObj = other.GetComponent<DoWork>();
		var otherNameID = doWorkObj.nameIdobj;
		
		foreach (var nameId in nameIDList)
		{
			if (nameId == otherNameID)
			{
				event.invoke;
			}
		}
	} */
	
	{
		var doWorkObj = other.GetComponent<DoWork>();
		var otherNameID = doWorkObj.nameIdobj;
		
		foreach (var nameId in nameIDList)
		{
			if (nameId == otherNameID)
			{
				doWorkObj.Work();
			}
		}
	}

	/*private void OnTriggerEnter(Collider other)
	{
		if (other.CompareTag("fred"))
		{
			do work
		}*/

	/*public NameID nameIDobj;

	private void OnTriggerEnter(Collider other)
	{
		var other.nameID = other.GetComponent<MatchID().nameID
	}*/
}
