using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class MenuUIHandler : MonoBehaviour
{
    [SerializeField] private TMP_InputField usernameInput;
    [SerializeField] private Button startButton;

    private void Start()
    {
        startButton.onClick.AddListener(StartGame);
        usernameInput.onValueChanged.AddListener(delegate { SetUsername(); });
    }

    private void StartGame()
    {
        SceneManager.LoadScene(1);
    }

    private void SetUsername()
    {
        GameManager.Instance.username = usernameInput.text;
    }
}