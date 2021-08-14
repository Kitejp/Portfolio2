using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

namespace KH
{
    public class GameManager : MonoBehaviour
    {
        public static GameManager instance = null;
        [Header("スコア")] public int score;
        [Header("制限時間")] public float countTime = 60f;

        public TextMeshProUGUI timeText, scoreText;

        PlayerStats playerStats;

        private void Awake()
        {
            if (instance == null)
            {
                instance = this;
                DontDestroyOnLoad(this.gameObject);
            }
            else
            {
                Destroy(this.gameObject);
            }
        }

        private void Start()
        {
            playerStats = FindObjectOfType<PlayerStats>();
        }

        private void Update()
        {
            if (timeText != null && scoreText != null)
            {
                countTime -= Time.deltaTime;
                timeText.text = "残り時間: " + countTime.ToString("F0") + "秒";

                scoreText.text = "スコア:" + score.ToString();

                if (countTime <= 0f || playerStats.currentHealth <= 0)
                {
                    countTime = 0;
                    timeText.text = "残り時間: " + countTime.ToString("F0") + "秒";
                    SceneManager.LoadScene("Result");
                }
            }
        }
    }
}
