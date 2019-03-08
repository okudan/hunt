using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{

    public Text text;
    private string last;

    public int[] values;

    private float cd;

    // Start is called before the first frame update
    void Start()
    {
        cd = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        GetValues();
        //!!!!!Kodu Buraya Yazın!!!!!
    }

    private void GetValues()
    {
        if (Time.time >= cd)
        {
            cd += 1;
            last = text.text;
            for (int i = 0; i < values.Length; i++)
            {
                values[i] = Random.Range(10, 100);
                text.text += " " + values[i];
            }
            text.text += " \n \n";
        }
    }

    private void Winner(int win)
    {
        text.text = last;
        for (int i = 0; i < values.Length; i++)
        {
            if (i == win)
            {
                text.text += " <color=red>" + values[i] + "</color>";
                Debug.Log("" + cd + ". saniyedeki " + (i + 1) + ". oyuncu kazandı!");
            } else {
                text.text += " " + values[i];
            }
        }
        text.text += " \n \n";
    }
}
