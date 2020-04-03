﻿using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

[CreateAssetMenu(fileName = "New Character", menuName = "Characters")]
public class Character : ScriptableObject
{
    public string characterName;
    public Sprite avatarSprite;
    [TextArea]
    public string backStory;
    [TextArea]
    public List<string> tips = new List<string>();
}
