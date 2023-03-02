using UnityEngine;
using TMPro;

public class HUD : MonoBehaviour
{
    public TextMeshProUGUI scoreTMP;
    public GameObject pauseMenu;

    public void UpdateScore(int score)
    {
        scoreTMP.text = score.ToString();
    }

    public void EnablePause()
    {
        Time.timeScale = 0f;
        pauseMenu.SetActive(true);
    }

    public void DisablePause()
    {
        Time.timeScale = 1f;
        pauseMenu.SetActive(false);
    }
}
