using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Return_To_Menu : MonoBehaviour
{
    public void LoadMenuScene()
    {
        SceneManager.LoadScene("Menu");
    }
    public void LoadExperimentScene()
    {
        SceneManager.LoadScene("Experiment");
    }

}
