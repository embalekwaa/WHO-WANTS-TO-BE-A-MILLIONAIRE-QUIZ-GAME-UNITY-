using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainScript : MonoBehaviour
{
    public GameObject IncorrectAnswer1;
    public GameObject IncorrectAnswer2;
    public GameObject QuitConfirmation;
    public GameObject RestartConfirmation;
    public GameObject ButtonNo;
    public GameObject ButtonYes;

    //Method for the 50:50 button
    public void FiftyFifty()
    {
        //Method to remove two incorrect answers
        IncorrectAnswer1.SetActive(false);
        IncorrectAnswer2.SetActive(false);
    }

    //Method for the confirmation to quit the game
    public void QuitConfirm()
    {
        QuitConfirmation.GetComponent<Text>().text = "ARE YOU SURE YOU WANT TO QUIT?";
        ButtonYes.SetActive(true);
        ButtonNo.SetActive(true);
    }

    //Method for the confirmation to return to the splash screen
    public void RestartConfirm()
    {
        RestartConfirmation.GetComponent<Text>().text = "ARE YOU SURE YOU WANT TO RETURN TO THE MAIN SCREEN?";
        ButtonNo.SetActive(true);
        ButtonYes.SetActive(true);
    }

    //Method to send the user to Quiz 1
    public void StartGame()
    {
        //LoadScene method will load the QUIZ1_SCENE
        SceneManager.LoadScene("QUIZ1_SCENE");
    }

    //Method to quit the game
    public void QuitGame()
    {
        //Debug.Log("GAME CLOSED");
        print("GAME CLOSED");
        //Application.Quit();
     
       
    }

    //Method to go return to the splash screen
    public void SPLASH()
    {
        //LoadScene Method will load the PLAY_SCENE;
        SceneManager.LoadScene("PLAY_SCENE");
    }

    //Method for Quiz 1 correct answer
    public void QuizTwo()
    {
        //LoadScene method will load the QUIZ2_SCENE
        SceneManager.LoadScene("QUIZ2_SCENE");
    }

    //Method for Quiz 1 incorrect answers
    public void GameOverOne()
    {
        //LoadScene method will load the GAMEOVER1_SCENE
        SceneManager.LoadScene("GAMEOVER1_SCENE");
    }

    //Method for Quiz 2 correct answer
    public void QuizThree()
    {
        //LoadScene method will load the QUIZ3_SCENE
        SceneManager.LoadScene("QUIZ3_SCENE");
    }

    //Method for Quiz 2 incorrect answers
    public void GameOverTwo()
    {
        //LoadScene method will load the GAMEOVER2_SCENE
        SceneManager.LoadScene("GAMEOVER2_SCENE");
    }

    //Method for Quiz 3 correct answer
    public void QuizFour()
    {
        //LoadScene method will load the QUIZ4_SCENE
        SceneManager.LoadScene("QUIZ4_SCENE");
    }

    //Method for Quiz 3 incorrect answers
    public void GameOverThree()
    {
        //LoadScene method will load the GAMEOVER3_SCENE
        SceneManager.LoadScene("GAMEOVER3_SCENE");
    }

    //Method for Quiz 4 correct answer
    public void QuizFive()
    {
        //LoadScene method will load the QUIZ5_SCENE
        SceneManager.LoadScene("QUIZ5_SCENE");
    }

    //Method for Quiz 4 incorrect answers
    public void GameOverFour()
    {
        //LoadScene method will load the GAMEOVER4_SCENE
        SceneManager.LoadScene("GAMEOVER4_SCENE");
    }

    //Method for Quiz 5 correct answer
    public void Finish()
    {
        //LoadScene method will load the WON_SCENE
        SceneManager.LoadScene("WON_SCENE");
    }
    
    //Method for Quiz 5 incorrect answer
    public void GameOverFive()
    {
        //LoadScene method will load the GAMEOVER5_SCENE
        SceneManager.LoadScene("GAMEOVER5_SCENE");
    }
        
    

    

   


   
    
}
