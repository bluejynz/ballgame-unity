using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class UIController : MonoBehaviour
{
    public TextMeshProUGUI gameOverText;
    public Button playAgainBtn;

    void Start()
    {
        gameOverText.gameObject.SetActive(false);
        playAgainBtn.gameObject.SetActive(false);
    }

    void Update()
    {
        if (GameObject.FindGameObjectsWithTag("collectable").Length == 0)
        {
            gameOverText.gameObject.SetActive(true);
            playAgainBtn.gameObject.SetActive(true);
        }
    }

    public void PlayAgain()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
