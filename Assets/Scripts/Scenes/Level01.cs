using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Level01 : MonoBehaviour
{

    public string CORRECT_ANSWER = "kabul";
    public string FAIL_MESSAGE = "ACCESS DENIED";
    public InputField passwordInput;
    public Text hintTextField;
    public Text textMessage;


    private bool CheckAnswer(string answer)
    {
        if (answer.Equals(CORRECT_ANSWER))
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
            TKSceneManager.ChangeScene(TKSceneManager.START_SCENE);
        }
        else
        {
            textMessage.text = FAIL_MESSAGE;
            textMessage.color = Color.red;

            passwordInput.text = "";
        }
    }
}
