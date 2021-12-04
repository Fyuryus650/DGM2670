using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour
{
    public float turnSpeed;
    public IntData livesData, ammoData;
    private int lives;
    private Vector3 playerPos;
    public GameObject projectile;



    private void Start()
    {
        lives = livesData.value;
        playerPos = gameObject.transform.position;
        
    }
    public void DefaultRot()
    {
        gameObject.transform.rotation = new Quaternion(0f, 0f, 0f,0f);
    }
    public void RotatePlayerRight()
    {
        transform.Rotate(Vector3.forward * turnSpeed * Time.deltaTime);
    }
    public void RotatePlayerLeft()
    {
        transform.Rotate(Vector3.forward * -turnSpeed * Time.deltaTime);
    }
    public void KillPlayer()
    {
        lives = lives - 1;
        if(lives <= 0)
        {
            gameObject.SetActive(false);
        }
    }
    private void FireWeaponActions()
    {
        Instantiate(projectile, playerPos + (new Vector3(0f, .3f, 0f)), gameObject.transform.rotation);
    }
    public void FireWeapon()
    {
        StartCoroutine(FireWeaponRoutine());
    }
    public IEnumerator FireWeaponRoutine()
    {
        while(ammoData.value > 0)
        {
            yield return new WaitForSeconds(1f);
            
            FireWeaponActions();
            ammoData.value--;
            if (ammoData.value < 0)
            {
                StopAllCoroutines();
                ammoData.value = 0;
            }
        }
    }
}
