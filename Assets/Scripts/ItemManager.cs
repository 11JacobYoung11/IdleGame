using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class ItemManager : MonoBehaviour
{
    public static ItemManager Instance;

    public Item[] items;

    private void Awake()
    {
        Instance = this;

        items = Utils.GetAllInstances<Item>();
        items = items.OrderBy(p => p.Id).ToArray();
        foreach(Item item in items)
        {
            Debug.Log(item.Name);
            Debug.Log(item.Description);
        }
    }
}
