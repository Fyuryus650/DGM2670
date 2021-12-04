using UnityEngine;
using UnityEngine.Events;

public class CollisionWithTags: MonoBehaviour
{
    public UnityEvent CompareTagEvent;
    public bool destroyBool;
    public string tagName;

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag(tagName))
        {
            CompareTagEvent.Invoke();
            if(destroyBool == true)
            {
                Destroy(collision.gameObject);
            }
        }
    }
}