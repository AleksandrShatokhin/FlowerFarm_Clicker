using UnityEngine;

public class GameController : CSingleton<GameController>
{
    [SerializeField] private GameObject _mainUI;
    [SerializeField] private GameObject _portalManager;
    [SerializeField] private GameObject _poolPortalObjects;

    public GameObject MainUI { get { return _mainUI; } }

    private void Start()
    {
        _mainUI.GetComponent<IInitialize>().Initialize();
        _poolPortalObjects.GetComponent<IInitialize>().Initialize();
        _portalManager.GetComponent<IInitialize<PoolPortalObjects>>().Initialize(_poolPortalObjects.GetComponent<PoolPortalObjects>());
    }
}