using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

namespace KH 
{
    public class ResultManager : MonoBehaviour
    {
        public TextMeshProUGUI resultText;

        // Update is called once per frame
        void Update()
        {
            resultText.text = "お疲れ様でした!\n今回のスコアは" + GameManager.instance.score.ToString() + "でした!";
        }

        public void BackToTitle()
        {
            SceneManager.LoadScene("Title");
        }
    }
}
