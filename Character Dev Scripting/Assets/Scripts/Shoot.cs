using UnityEngine;
using System.Collections;

public class Shoot : MonoBehaviour
{

    public Rigidbody projectile;
    public Transform playerlocation;
    public FloatData shootSpeed;
    public FloatData coolDown;
    private bool fireDown = true;
    public IntData arrowDamage;
    public FloatData startSpeed;

    // Update is called once per frame

    private void Start()
    {
        coolDown.value = startSpeed.value;
    }

    void Update()
    {
        if (Input.GetButtonDown("Fire1") && fireDown.Equals(true))
        {
            Rigidbody clone;
            clone = (Rigidbody)Instantiate(projectile, playerlocation.position, playerlocation.rotation);
            clone.velocity = playerlocation.TransformDirection(new Vector3 (x:0, 0, 2) * shootSpeed.value);
            fireDown = false;
            StartCoroutine(CoolDownTimer());
        }
    }

    public IEnumerator CoolDownTimer()
    {
        yield return new WaitForSeconds(coolDown.value);
        fireDown = true;
    }
}