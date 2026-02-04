using UnityEngine;

public class PortalManager : MonoBehaviour, IInitialize<PoolPortalObjects>, IPoolable<GameObject>
{
    [SerializeField] private Transform _professorPosition;

    private PoolPortalObjects _poolPortalObjects;
    private Portal[] _portals;

    public void Initialize(PoolPortalObjects poolPortalObjects)
    {
        _poolPortalObjects = poolPortalObjects;
        _portals = GetComponentsInChildren<Portal>();

        foreach (Portal portal in _portals)
        {
            portal.Initialize(_professorPosition);
        }
    }
    public GameObject Take() => _poolPortalObjects.Take();
    public void Return(GameObject portalObject) => _poolPortalObjects.Return(portalObject);
}
