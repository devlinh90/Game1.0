using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelController : MonoBehaviour
{

    public string PASSWORD = "kabul";
    public string MESSAGE = "ACCESS DENIED";
    public string nextSceneName = "";

    public InputField passwordInput;
    public Text textMessage;
    public string levelHintText = "name of the place";

    private Coroutine hintCoroutine;
    public List<GameObject> levelHints = new List<GameObject>();
    private int currentHintIndex = 0;
    public Button buttonHintNext;
    void Start()
    {
        if (levelHints.Count > 1)
        {
            buttonHintNext.gameObject.SetActive(true);
            DisplayNumberHint(currentHintIndex);
        }
    }
    private bool CheckAnswer(string answer)
    {
        if (answer.Equals(PASSWORD))
        {
            return true;
        }

        return false;
    }

    public void OnNextHintButtonClicked()
    {
        currentHintIndex = ++currentHintIndex % levelHints.Count;
        DisplayNumberHint(currentHintIndex);
    }

    private void DisplayNumberHint(int hintIndex)
    {
        for (int i =0; i < levelHints.Count;i++)
        {
            levelHints[i].SetActive(i == hintIndex);
        }
        if (currentHintIndex == levelHints.Count - 1)
        {
            buttonHintNext.transform.localScale = new Vector3(-1, 1, 1);
        }
        else
        {
            buttonHintNext.transform.localScale = Vector3.one;
        }
    }

    public void OnSubmitButtonClicked()
    {
        string answer = passwordInput.text;
        if (CheckAnswer(answer))
        {
            TKSceneManager.ChangeScene(nextSceneName);
        }
        else
        {
            textMessage.text = MESSAGE;
            textMessage.color = Color.red;
            passwordInput.text = "";

            if (hintCoroutine == null)
            {
                hintCoroutine = StartCoroutine(ChangeHintTextBack(2f));
            }
        }
    }

    private IEnumerator ChangeHintTextBack(float delayTime)
    {
        yield return new WaitForSeconds(delayTime);
        textMessage.text = levelHintText;
        textMessage.color = Color.black;
    }
}
