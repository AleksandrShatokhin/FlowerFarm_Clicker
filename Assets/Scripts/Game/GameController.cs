using UnityEngine;

public class GameController : CSingleton<GameController>
{
    [SerializeField] private GameObject _portalManager;
    [SerializeField] private GameObject _poolPortalObjects;

    private void Start()
    {
        _poolPortalObjects.GetComponent<IInitialize>().Initialize();
        _portalManager.GetComponent<IInitialize<PoolPortalObjects>>().Initialize(_poolPortalObjects.GetComponent<PoolPortalObjects>());
    }
}