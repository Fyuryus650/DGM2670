using UnityEngine;
using UnityEngine.Events;
using System.Collections;

public class WeaponFiring : MonoBehaviour
{
    public IntData livesData, ammoData;
    private int lives;
    private Vector3 playerPos;
    public GameObject projectile;
    public UnityEvent UpdateUI;
    private bool firingWeapon = false;

    private void Start()
    {
        lives = livesData.value;
    }
    public void UpdateUIEvent()
    {
        UpdateUI.Invoke();
    }
    private void FireWeaponActions()
    {
        Instantiate(projectile, playerPos, gameObject.transform.rotation);
    }
    public void KillPlayer()
    {
        lives = livesData.value;
        if (lives <= 0)
        {
            gameObject.SetActive(false);
        }
    }
    public void FireWeapon()
    {
        StartCoroutine(FireWeaponRoutine());
    }

    public void StopFireWeapon()
    {
        if(firingWeapon == true)
        {
            StopAllCoroutines();
            firingWeapon = false;
            UpdateUIEvent();
        }
    }
    public IEnumerator FireWeaponRoutine()
    {
        while (lives >= 1)
        {
            yield return new WaitForSeconds(.3f);

            playerPos = gameObject.transform.position;
            //checks if there is ammo to fire before running anything else
            if (ammoData.value <= 0)
            {
                firingWeapon = false;
                StopAllCoroutines();
                ammoData.value = 0;
            }

            FireWeaponActions();

            ammoData.value--;

            UpdateUIEvent();

            firingWeapon = true;
        }
    }
}
