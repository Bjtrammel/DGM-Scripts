using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Bullet : MonoBehaviour
{
	public float time = 5f;
	public GameObject bullet;

	private void Start()
	{
		StartCoroutine(DestroyBullet());
	}

	IEnumerator DestroyBullet()
	{
		yield return new WaitForSeconds(time);
		Destroy(bullet);
	}
}
