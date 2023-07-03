using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WelcomeScreenScript : MonoBehaviour
{
    [SerializeField] private TutorialScreen myTutorialScreen;

    // Start is called before the first frame update
    void Start()
    {
        OpenComfirmationWindow("Welcome to Cave Rave");
    }

    private void OpenComfirmationWindow(string message)
    {
        myTutorialScreen.gameObject.SetActive(true);
        myTutorialScreen.continueButton.onClick.AddListener(ButtonClicked);
        myTutorialScreen.messageText.text = message;
    }

    private void ButtonClicked()
    {
        myTutorialScreen.gameObject.SetActive(false);
        Debug.Log("Button clicked");
    }
}
