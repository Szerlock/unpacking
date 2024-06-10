using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PackingScene : MonoBehaviour
{
    [SerializeField]
    private Button changeScene;

    void Start()
    {
        changeScene.onClick.AddListener(NextScene);
    }

    public void NextScene()
    {
        SceneManager.LoadScene (sceneName:"Packing Boxes");
    }
    
}
