using UnityEngine;
using UnityEngine.UI;

public class Flower : MonoBehaviour
{
    [SerializeField] private int _clickCounter;
    [SerializeField] private int _clickStatus;

    private void Start()
    {
        this.GetComponent<Button>().onClick.AddListener(ChangeClickCounter);

        _clickCounter = 0;
        _clickStatus = 0;
    }

    private void ChangeClickCounter()
    {
        _clickCounter = _clickCounter + 1;

        if (_clickCounter == 10)
        {
            _clickCounter = 0;
            ChangeClickStatus();
        }
    }

    private void ChangeClickStatus()
    {
        if (_clickStatus >= 10) return;

        _clickStatus = _clickStatus + 1;
    }
}