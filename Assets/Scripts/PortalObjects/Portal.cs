using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Portal : MonoBehaviour, IInitialize<Transform>, IClickable
{
    [SerializeField] private int _clickCounter;
    [SerializeField] private int _clickStatus;

    private Transform _finalyPositionToPortalObject;

    public void Initialize(Transform finalyPositionToPortalObject)
    {
        _finalyPositionToPortalObject = finalyPositionToPortalObject;
    }

    public void Click()
    {
        GameObject portalObject = GetComponentInParent<IPoolable<GameObject>>().Take();
        portalObject.transform.SetParent(transform);
        portalObject.transform.position = transform.position;
        portalObject.SetActive(true);
        portalObject.GetComponent<IInitialize<Transform>>().Initialize(_finalyPositionToPortalObject);
    }

    public void ReturnToPool(GameObject obj)
    {
        GetComponentInParent<IPoolable<GameObject>>().Return(obj);
    }
}