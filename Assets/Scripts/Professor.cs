using UnityEngine;

public class Professor : MonoBehaviour, ISetable<ObjectStruct>
{
    public void Set(ObjectStruct objectStruct)
    {
        GameController.GetInstance().MainUI.GetComponent<ISetable<int>>()?.Set(objectStruct.ID);
    }
}
