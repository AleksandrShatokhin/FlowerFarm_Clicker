using UnityEngine;

public interface IInitialize
{
    void Initialize();
}

public interface IInitialize<T>
{
    void Initialize(T type);
}

public interface IPoolable<T>
{
    GameObject Take();
    void Return(T type);
}

public interface IClickable
{
    void Click();
}

public interface ISetable
{
    void Set();
}

public interface ISetable<T>
{
    void Set(T type);
}