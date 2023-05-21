using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Item : ScriptableObject
{
    //creates the items for the inventory
    [Header("Only Gameplay")]
    public ItemType itemType;
    public ActionType actionType;
    public Vector3Int range = new Vector3Int(5, 4, 3);

    [Header("Only UI")]
    public bool stackable = true;

    [Header("Both")]
    public Sprite image;

}
// fuck if i know how to explain, its enums, they make the new special bit things
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
