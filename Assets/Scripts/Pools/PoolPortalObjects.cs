using UnityEngine;

public class PoolPortalObjects : MonoBehaviour, IInitialize, IPoolable<GameObject>
{
    [SerializeField] private GameObject _portalObjectPrefab;
    [SerializeField] private int _count;

    private CStack<GameObject> _stackObjects;

    public void Initialize()
    {
        _stackObjects = new CStack<GameObject>();

        FillPool(_count);
    }

    private void FillPool(int count)
    {
        for (int i = 0; i < count; i++)
        {
            GameObject obj = Instantiate(_portalObjectPrefab, _portalObjectPrefab.transform.position, _portalObjectPrefab.transform.rotation);
            obj.transform.SetParent(transform);
            obj.SetActive(false);
            _stackObjects.AddElement(obj);
        }
    }

    public GameObject Take()
    {
        GameObject tempObj = _stackObjects.TakeElement();
        return tempObj;
    }
    public void Return(GameObject obj)
    {
        obj.transform.SetParent(transform);
        obj.SetActive(false);
        _stackObjects.AddElement(obj);
    }

}
