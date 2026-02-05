using TMPro;
using UnityEngine;

public class MainUI : MonoBehaviour, IInitialize, ISetable<int>
{
    [SerializeField] private GameObject[] _infoElements;

    public void Initialize()
    {

    }

    public void Set(int id)
    {
        int tempID = id - 1;
        _infoElements[tempID].GetComponent<ISetable>()?.Set();
    }
}
