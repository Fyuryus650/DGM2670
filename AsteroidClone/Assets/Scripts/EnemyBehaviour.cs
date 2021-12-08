using UnityEngine;

public class EnemyBehaviour : MonoBehaviour
{
    public float speed;
    public int healthVal;
    public IntData healthData;

    private void Start()
    {
        healthVal = healthData.value;
    }
    void Update()
    {
        transform.Translate(Vector3.up * -speed * Time.deltaTime);
    }

    public void SubtractHealth()
    {
        healthVal--;
    }
    
    public void DestroyEvent()
    {
        if (healthVal <= 0)
        {
            Destroy(gameObject);
        }
    }
}
