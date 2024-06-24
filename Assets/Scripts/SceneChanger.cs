using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    public int targetSceneIndex;
    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            ChangeScene();
        }
    }

public void ChangeScene()
    {
        SceneManager.LoadScene(targetSceneIndex);
    }
}