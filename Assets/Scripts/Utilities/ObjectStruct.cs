using UnityEngine;

public class ObjectStruct
{
    private int _id;
    private Sprite _sprite;
    private Transform _finalyPosition;

    public ObjectStruct(int id, Sprite sprite, Transform finalyPosition)
    {
        _id = id;
        _sprite = sprite;
        _finalyPosition = finalyPosition;
    }

    public int ID { get { return _id; } }
    public Sprite Sprite { get { return _sprite; } }
    public Transform FinalyPosition { get { return _finalyPosition; } }
}
