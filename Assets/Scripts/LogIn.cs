using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LogIn : UiTransation
{
    public string Usernane;
    public string PassWard;
    public Text User;
    public Text pass;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnSubmit()
    {
        Usernane = User.text.ToString();
        PassWard = pass.text.ToString();
        CurrntUI.SetActive(false);
        TargetUI.SetActive(true);
        Debug.Log(Usernane);
        Debug.Log(PassWard);
    }
}
