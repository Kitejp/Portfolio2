using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class TitleManager : MonoBehaviour
{
    public GameObject start, summary, operation, back, back2, sprite;

    public TextMeshProUGUI title, summaryText, operationText;

    // Start is called before the first frame update
    void Start()
    {
        start.SetActive(true);
        summary.SetActive(true);
        operation.SetActive(true);
        title.gameObject.SetActive(true);

        back.SetActive(false);
        back2.SetActive(false);
        sprite.SetActive(false);
        summaryText.gameObject.SetActive(false);
        operationText.gameObject.SetActive(false);
    }

    public void GameStart()
    {
        SceneManager.LoadScene("GameScene");
    }

    public void Summary()
    {
        back.SetActive(true);
        sprite.SetActive(true);
        summaryText.gameObject.SetActive(true);

        start.SetActive(false);
        summary.SetActive(false);
        operation.SetActive(false);
        title.gameObject.SetActive(false);
    }

    public void Operation()
    {
        back2.SetActive(true);
        sprite.SetActive(true);
        operationText.gameObject.SetActive(true);

        start.SetActive(false);
        summary.SetActive(false);
        operation.SetActive(false);
        title.gameObject.SetActive(false);
    }

    public void SummaryBack()
    {
        start.SetActive(true);
        summary.SetActive(true);
        operation.SetActive(true);
        title.gameObject.SetActive(true);

        back.SetActive(false);
        sprite.SetActive(false);
        summaryText.gameObject.SetActive(false);
    }

    public void OperationBack()
    {
        start.SetActive(true);
        summary.SetActive(true);
        operation.SetActive(true);
        title.gameObject.SetActive(true);

        back2.SetActive(false);
        sprite.SetActive(false);
        operationText.gameObject.SetActive(false);
    }
}
