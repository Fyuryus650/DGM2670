using UnityEngine;
using UnityEngine.Events;

public class CollisionWithTags: MonoBehaviour
{
    public UnityEvent CompareTagEvent;
    public bool collisionDestroy;
    public string tagName;

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag(tagName))
        {
            CompareTagEvent.Invoke();
            if(collisionDestroy == true)
            {
                Destroy(collision.gameObject);
            }
        }
    }
}