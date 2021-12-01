﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PrintedText : MonoBehaviour
{
    public Text printedText;
    private string text;
    public bool textEnd = false;

    IEnumerator TextPrinting()
    {
        foreach (char c in text)
        {
            printedText.text += c;
            yield return new WaitForSeconds(0.07f);
        }
        textEnd = true;
    }

    // Start is called before the first frame update
    void Start()
    {
        text = printedText.text;
        printedText.text = "";
        StartCoroutine(TextPrinting());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
