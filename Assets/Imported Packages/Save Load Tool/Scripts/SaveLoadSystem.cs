using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SaveLoadTool
{
    public class SaveLoadSystem : MonoBehaviour
    {
        public static void Save(ExamplePlayerCharacter playerCharacter)
        {
            Debug.Log("Starting to SAVE data for [" + playerCharacter + "]...");

            PlayerPrefs.SetString("Character Name", playerCharacter.characterName);
            PlayerPrefs.SetInt("Character Level", playerCharacter.currentLevel);

            Debug.Log("Finished SAVING data");
        }

        public static void Load(ExamplePlayerCharacter playerCharacter)
        {
            Debug.Log("Starting to LOAD data for [" + playerCharacter + "]...");

            playerCharacter.characterName = PlayerPrefs.GetString("Character Name");
            playerCharacter.currentLevel = PlayerPrefs.GetInt("Character Level");

            Debug.Log("Finished LOADING data");
        }
    }
}