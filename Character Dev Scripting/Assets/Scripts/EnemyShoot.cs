using UnityEngine;
using System.Collections;
using System.Net.NetworkInformation;
using UnityEngine.Animations;
using UnityEngine.Experimental.PlayerLoop;

public class EnemyShoot : MonoBehaviour
{

    public Rigidbody projectile;
    public Transform enemyLocation;
    public FloatData shootSpeed;
    public FloatData coolDown;
    private bool fireDown = true;
    public bool canClone;
    public IntData arrowDamage;
    private Vector3 rotDirection;


    public void AttackPlayer()
    {
        if (fireDown.Equals(true) && canClone.Equals(true))
        {
            Rigidbody clone;
            clone = (Rigidbody)Instantiate(projectile, enemyLocation.position, enemyLocation.rotation);
            clone.velocity = enemyLocation.TransformDirection(new Vector3 (x:0, 0, 2) * shootSpeed.value);
            fireDown = false;
            StartCoroutine(CoolDownTimer());
        }
     }

    public void StopFiring()
    {
        canClone = false;
    }

    public IEnumerator CoolDownTimer()
    {
        yield return new WaitForSeconds(coolDown.value);
        fireDown = true;
        AttackPlayer();
    }
}