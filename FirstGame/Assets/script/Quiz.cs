using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Quiz : MonoBehaviour
{


    public List<game> QA;

    public GameObject[] opt;
    public int current;

    public Text QText;

    private void start()
    {
        generate();

    }

    public void Correct()
    {
        QA.RemoveAt(current);
        generate();
    }
   

    void SetAns()
    {
       for(int x =0; x< opt.Length; x++)
       {
            opt[x].GetComponent<GameManager1>().yesCorrect = false;
            opt[x].transform.GetChild(0).GetComponent<Text>().text = QA[current].Ans[x];

            if (QA[current].Correct == x++)
            {
                opt[x].GetComponent<GameManager1>().yesCorrect = true;
            }

       }

    }


    void generate()
    {
        current =Random.Range(0 , QA.Count);
        QText.text = QA[current].Q;
        SetAns();

    }





}
