using UnityEngine;

public class Clickable : MonoBehaviour
{
    [SerializeField] protected AudioSource m_audioSource;
    
    protected void OnMouseDown()
    {
        OnClick();
    }

    protected virtual void OnClick()
    {
        if (m_audioSource != null && m_audioSource.clip != null)
        {
            m_audioSource.PlayOneShot(m_audioSource.clip);
        }
    }
}
