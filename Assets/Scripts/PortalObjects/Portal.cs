using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Portal : MonoBehaviour, IInitialize<Transform>, IClickable
{
    [SerializeField] private Sprite _spriteObject;
    [SerializeField] private Sprite _spriteCristal;

    [SerializeField] private int _idObject;
    [SerializeField] private int _idCristal;

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
        portalObject.GetComponent<IInitialize<ObjectStruct>>().Initialize(NewObjectStruct());
    }

    private ObjectStruct NewObjectStruct()
    {
        ObjectStruct objectStruct = 
            (RandomValue() <= 10)? new ObjectStruct(_idCristal, _spriteCristal, _finalyPositionToPortalObject) : new ObjectStruct(_idObject, _spriteObject, _finalyPositionToPortalObject);
        return objectStruct;
    }

    private double RandomValue()
    {
        double value = Random.Range(0, 100);
        return value;
    }

    public void ReturnToPool(GameObject obj)
    {
        GetComponentInParent<IPoolable<GameObject>>().Return(obj);
    }
}