using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;




    public class PlayerFinalTimeDisplay : MonoBehaviour
    {
        public TMP_Text finalTimeText;
        public Timer timerScript; // Reference to the Timer script attached to the player

        void Start()
        {
            if (timerScript == null)
            {
                Debug.LogError("Timer script reference is missing!");
            }
        }

        void Update()
        {
            // You can update other UI elements or perform other actions here if needed
        }

        public void DisplayFinalTime()
        {
            if (timerScript != null)
            {
                float finalTime = timerScript.GetFinalTime();
                UpdateFinalTimeUI(finalTime);
            }
            else
            {
                Debug.LogError("Timer script reference is missing!");
            }
        }

        void UpdateFinalTimeUI(float finalTime)
        {
            // Update the UI element with the final time
            finalTimeText.text = string.Format("Final Time: {0:00}:{1:00}", Mathf.FloorToInt(finalTime / 60), Mathf.FloorToInt(finalTime % 60));
        }
    }
