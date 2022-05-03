using UnityEngine;

[CreateAssetMenu(fileName = "New Item", menuName = "ScriptableObjects/Item")]
public class Item : ScriptableObject
{
    public string Name;
    public string Description;
    public string Id;
    public Sprite Icon;
    public int Quantity;
}
