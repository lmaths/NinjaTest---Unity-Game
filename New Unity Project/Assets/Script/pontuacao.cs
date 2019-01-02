using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class pontuacao : MonoBehaviour
{
    public static int pontos;
    public Text pontosTXT;
    
   
    // Start is called before the first frame update
    void Start()
    {
        pontos = 0;
        
    }

    // Update is called once per frame
    void Update()
    {
        pontosTXT.text = pontos.ToString();
    }
}
