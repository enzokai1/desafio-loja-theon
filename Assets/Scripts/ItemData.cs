using UnityEngine;

[CreateAssetMenu(fileName = "NewItemData", menuName = "Shop/Item Data")]
public class ItemData : ScriptableObject
{
    [Header("Item Information")]
    public string itemName;
    public Sprite itemIcon;
    
    [TextArea(3, 5)]
    public string itemDescription;
    
    [Header("Economy")]
    public int itemPrice;
}