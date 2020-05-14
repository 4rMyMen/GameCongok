using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    #region Singleton
    public static Inventory instance;

    private void Awake()
    {
        if(instance != null)
        {
            Debug.LogWarning("More than one instance of Inventory found");
            return;
        }

        instance = this;
    }
    #endregion

    public delegate void OnItemChanged();
    public OnItemChanged onItemChangedCallback;

    //public int space = 20;

    public List<Items> items = new List<Items>();

    public void Add(Items item)
    {
        if (!item.isDefaultItem)
        {
            items.Add(item);
            if(onItemChangedCallback != null)
                onItemChangedCallback.Invoke();
        }
    }

    public void Remove(Items item)
    {
        items.Remove(item);
        if (onItemChangedCallback != null)
            onItemChangedCallback.Invoke();
    }

}
