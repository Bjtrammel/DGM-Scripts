﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MatchID : MonoBehaviour
{

	public List<NameID> nameIDList;

	public DoWorkEvent;
	private void OnTriggerEnter(Collider other)
	{
		var doWorkObj = other.GetComponent<SelfId>();
		var otherNameID = doWorkObj.self;
		
		foreach (var nameId in nameIDList)
		{
			if (nameId == otherNameID)
			{
				//DoWorkEvent.WorkTest;
			}
		}
	}

	/*foreach (var nameId in nameIDList)
	{
		if (nameId == otherNameID)
		{
			doWorkObj.Work();
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
