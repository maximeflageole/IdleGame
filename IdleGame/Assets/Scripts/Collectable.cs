using UnityEngine;

public class Collectable : Clickable
{
    [SerializeField] protected EResource m_resourceType;
    [SerializeField] protected int m_baseAmount;
    
    protected override void OnClick()
    {
        Inventory.INSTANCE.AddResource(m_resourceType, m_baseAmount);
        base.OnClick();
    }
}
