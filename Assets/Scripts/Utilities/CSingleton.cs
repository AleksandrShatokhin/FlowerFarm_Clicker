using UnityEngine;

public class CSingleton<T> : MonoBehaviour where T : CSingleton<T>
{
    private static T _instance;
    public static T GetInstance() => _instance;

    protected virtual void Awake()
    {
        if (_instance != null)
        {
            Destroy(this);
        }
        else
        {
            _instance = this as T;
        }
    }
}