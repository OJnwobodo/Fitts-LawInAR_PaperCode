using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class TimerController : MonoBehaviour
{
    public TMP_Text timerText;
    private float totalTime;  // Total time for the game based on the number of samples
    private float currentTime; // Current time elapsed

    void Start()
    {
        // Retrieve the number of samples from the user input
        int nofSamples = GetNofSamplesFromUser();

        // Calculate the total time based on the number of samples (adjust as needed)
        totalTime = nofSamples * 2.0f; // Assuming 2 seconds per sample, adjust as needed
        currentTime = 0f; // Start the timer
    }

    void Update()
    {
        // Update the timer logic
        UpdateTimer();

        // Follow the user's head movement
        FollowHeadMovement();
    }

    void UpdateTimer()
    {
        // Update the timer logic
        currentTime += Time.deltaTime;

        // Check if the game duration has reached the total time
        if (currentTime >= totalTime)
        {
            // Game over, perform actions (e.g., return to the menu)
            EndGame();
        }

        // Update the timer text
        timerText.text = $"Time Left: {Mathf.Max(0, totalTime - currentTime):F2} seconds";
    }

    void FollowHeadMovement()
    {
        // Follow the user's head movement
        if (Camera.main != null)
        {
            transform.position = Camera.main.transform.position + Camera.main.transform.forward * 2.0f; // Adjust the distance from the user
            transform.LookAt(Camera.main.transform.position);
        }
    }

    public void EndGame()
    {
        // Game over actions (e.g., return to the menu)
        SceneManager.LoadScene("Menu");
    }

    int GetNofSamplesFromUser()
    {
        // Retrieve the number of samples from the user input
        if (GameObject.Find("InputActivator") != null)
        {
            Input_Activator inputActivator = GameObject.Find("InputActivator").GetComponent<Input_Activator>();
            return int.Parse(inputActivator.nofSamplesInputField.text);
        }

        // Default to 10 if InputActivator is not found
        return 10;
    }
}
