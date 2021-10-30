using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoroutineLimitBehaviour : MonoBehaviour
{
    public float limitNum,rateNum;
    private Vector3 positionVector3 = new Vector3();

    private WaitForFixedUpdate wffuObj;


    private void Start()
    {
        wffuObj = new WaitForFixedUpdate();
        positionVector3 = transform.position;
    }

    public void RunCoroutine()
    {
        StartCoroutine(CoroutineWithLimit());
    }

    private IEnumerator CoroutineWithLimit()
    {
        while (positionVector3.x < limitNum)
        {
            positionVector3.x += rateNum;
            transform.Translate(positionVector3);

            yield return wffuObj;
        }
    }
}
