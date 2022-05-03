using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class InventoryCreator : MonoBehaviour
{
    [SerializeField] private GameObject itemPrefab;
    [SerializeField] private Transform itemContainer;
    [SerializeField] private Sprite Icon;


    private void Start()
    {
        StartCoroutine(CreateInventory());
    }
    IEnumerator CreateInventory()
    {
        yield return new WaitForEndOfFrame();

        foreach (Item item in ItemManager.Instance.items)
        {
            GameObject instance = Instantiate(itemPrefab, itemContainer);
            instance.name = item.Name;
            InventoryItem inventoryItem = instance.GetComponent<InventoryItem>();
            inventoryItem.Item = item;
            inventoryItem.Renderer.sprite = item.Icon;
        }
    }
}
