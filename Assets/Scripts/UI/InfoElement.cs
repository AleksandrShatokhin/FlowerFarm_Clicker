using TMPro;
using UnityEngine;

public class InfoElement : MonoBehaviour, ISetable
{
    [SerializeField] private TextMeshProUGUI _text;

    public void Set()
    {
        int value = int.Parse(_text.text);
        value += 1;
        _text.text = value.ToString();
    }
}
