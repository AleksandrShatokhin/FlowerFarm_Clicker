using System.Collections;
using UnityEngine;

public class PortalObject : MonoBehaviour, IInitialize<Transform>
{
    [SerializeField] private float _speed;

    public void Initialize(Transform finalyPosition)
    {
        Vector3 starPosition = transform.position;

        StartCoroutine(Move(transform.position, finalyPosition.position, _speed));
    }

    private IEnumerator Move(Vector3 startPosition, Vector3 finalyPosition, float speed)
    {
        float step = (speed / (startPosition - finalyPosition).magnitude * Time.fixedDeltaTime);
        float time = 0;

        while (time <= 1.0f)
        {
            time += step;
            transform.position = Vector3.Lerp(startPosition, finalyPosition, time);
            yield return new WaitForFixedUpdate();
        }

        transform.position = finalyPosition;

        GetComponentInParent<Portal>().ReturnToPool(this.gameObject);
    }
}