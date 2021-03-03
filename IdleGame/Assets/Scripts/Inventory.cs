using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public static Inventory INSTANCE;

    [SerializeField] private TextMeshProUGUI m_goldAmount;
    protected Dictionary<EResource, int> m_resourceDictionary = new Dictionary<EResource, int>();

    // Start is called before the first frame update
    void Start()
    {
        if (INSTANCE == null || INSTANCE == this)
        {
            INSTANCE = this;
        }
        else
        {
            Destroy(this);
        }
    }

    public void AddResource(EResource resourceType, int resourceAmount)
    {
        if (m_resourceDictionary.ContainsKey(resourceType))
        {
            m_resourceDictionary[resourceType] += resourceAmount;
        }
        else
        {
            m_resourceDictionary.Add(resourceType, resourceAmount);
        }
        m_goldAmount.text = m_resourceDictionary[resourceType].ToString();
    }
}
