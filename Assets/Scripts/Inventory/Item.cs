using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(menuName = "Scriptable object/Item")]
public class Item : ScriptableObject
{
    [Header("Only Gameplay")]
    public ItemType itemType;
    public ActionType actionType;
    public Vector3Int range = new Vector3Int(5, 4, 3);

    [Header("Only UI")]
    public bool stackable = true;

    [Header("Both")]
    public Sprite image;

}

public enum ItemType
{
    Shard,
    Bowl,
    Key,
    Lever,
    RedHerring,
    FabricScrap,
    Drain,
    Clock,
    Pot,
    Scissors,
    Valve,
}

public enum ActionType
{
    Fix,
    Lever,
    Cut,    
    Open,
    Give,
    Null,
    Drip,
    Fill,
    Kine,
    Turn,
}
