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
            resultText.text = "�����l�ł���!\n����̃X�R�A��" + GameManager.instance.score.ToString() + "�ł���!";
        }

        public void BackToTitle()
        {
            SceneManager.LoadScene("Title");
        }
    }
}
