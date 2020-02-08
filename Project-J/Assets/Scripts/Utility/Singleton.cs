using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Singleton<T> : MonoBehaviour where T : Component
{
    public static T instance;

    protected virtual void Awake()
    {
        if (instance != null)
        {
            Destroy(instance.gameObject);
        }
        instance = GetComponent<T>();
    }
}
