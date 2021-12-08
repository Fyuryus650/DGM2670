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
        lives = lives - 1;
        if (lives <= 1)
        {
            gameObject.SetActive(false);
        }
    }
    public void FireWeapon()
    {
        StartCoroutine(FireWeaponRoutine());
    }
    public IEnumerator FireWeaponRoutine()
    {
        while (lives >= 1)
        {
            yield return new WaitForSeconds(.3f);

            playerPos = gameObject.transform.position;
            FireWeaponActions();
            ammoData.value--;
            UpdateUIEvent();
            if (ammoData.value <= 0)
            {
                StopAllCoroutines();
            }
        }
    }
}
