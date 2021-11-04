using UnityEngine;

public class PlinkoObstacleBehaviour : MonoBehaviour
{
    public float speed;
    public Vector3 startPos = new Vector3(6.53999996f, 5.01999998f, -0.163000003f);

    private void Update()     
    {
        transform.Translate(Vector3.up * speed * Time.deltaTime);
    }
    public void Teleport()
    {
        transform.position = startPos;
        print("Teleporting");
    }
}
