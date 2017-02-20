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


    private bool CheckAnswer(string answer)
    {
        if (answer.Equals(PASSWORD))
        {
            return true;
        }

        return false;
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
        }
    }
}
