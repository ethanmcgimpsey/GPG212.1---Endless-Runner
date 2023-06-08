using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SaveLoadTool
{
    public class ExampleGameManager : MonoBehaviour
    {
        [SerializeField] private ExamplePlayerCharacter playerCharacter;

        void Start()
        {
            // Spawn the player character
            // ksdfjsdfsjdfskdsfd

            // Load player character data from SaveLoadSystem
            SaveLoadSystem.Load(playerCharacter);
        }

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.S))
            {
                SaveLoadSystem.Save(playerCharacter);
            }

            if (Input.GetKeyDown(KeyCode.L))
            {
                SaveLoadSystem.Load(playerCharacter);
            }
            /*if(Time.time % 1 == 0)
            {
                SaveLoadSystem.Save(playerCharacter);
            }*/
        }

        private void OnDestroy()
        {
            SaveLoadSystem.Save(playerCharacter);
        }
    }
}