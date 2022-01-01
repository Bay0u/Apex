using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Cards",fileName ="Card")]
public class Card : ScriptableObject
{
    public string name, desc;
    public int attack, health, manaCount;
    public Sprite artwork;
}
