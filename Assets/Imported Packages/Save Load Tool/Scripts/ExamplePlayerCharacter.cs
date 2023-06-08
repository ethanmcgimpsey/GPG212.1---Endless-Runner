using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SaveLoadTool
{
    public class ExamplePlayerCharacter : MonoBehaviour
    {
        [SerializeField] public int currentLevel = 0;
        [SerializeField] public string characterName = "Undefined";
    }
}