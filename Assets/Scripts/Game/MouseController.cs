using UnityEngine;

public class MouseController : MonoBehaviour
{
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            CastRayToMousePoint();
        }
    }

    private void CastRayToMousePoint()
    {
        Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector2 mousePosition2D = new Vector2(mousePosition.x, mousePosition.y);

        RaycastHit2D hit = Physics2D.Raycast(mousePosition2D, Vector2.zero);

        if (hit.collider != null)
        {
            hit.collider?.GetComponent<IClickable>()?.Click();
        }
    }
}
