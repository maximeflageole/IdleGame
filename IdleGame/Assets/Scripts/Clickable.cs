using UnityEngine;

public class Clickable : MonoBehaviour
{
    protected void OnMouseDown()
    {
        OnClick();
    }

    protected virtual void OnClick()
    {
        
    }
}
