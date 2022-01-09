using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Scene1 : MonoBehaviour
{
    public static Scene1 Instance;
    public InputField inputField;
    public Text bestScoreText;

    public string playerName;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
        MainManager data = new MainManager();
        data.LoadScore();
        bestScoreText.text = "Best Score : " + data.bestPlayerName + " - " + data.bestScore;
    }

    public void SetPlayerName()
    {
        playerName = inputField.text;
    }

}
