using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager1 : MonoBehaviour
{
    public bool yesCorrect = false;
   // int count = 0;
   // int wCount = 0;
    public Quiz QuizM;



    public void Answers()
    {
        if (yesCorrect)
        {
            //count ++;
            QuizM.Correct();
           
        }
        else
        {
            Debug.Log("Wrong ");
           // wCount++;
            QuizM.Correct();

        }

        

    }





}
