// do not need the other libraries when using scriptable objects
using UnityEngine;

[CreateAssetMenu]

public class FloatData : ScriptableObject
{
    public float value;

    // num is adjustable in the unity editor
    public void AddToValue(float num)
    {
        //simple function to add to value
        value += num;
    }
}
