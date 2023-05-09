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
    Glue,
    Key,
    Lever,

}

public enum ActionType
{
    Fix,
    Hit,
    Cut,
    Pry,
    Open
}
