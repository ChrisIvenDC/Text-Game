using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;
using UnityEditor;

public class NewBehaviourScript : MonoBehaviour
{

    public TextMeshProUGUI storytextMeshPro, hptextMeshPro, statextmeshPro;
    public string storyText;
    public int HPVal, StaVal;
    public GameObject 
        UIStatsimg, RetryButton,
        MainMenu_Object, Level1_Object, PostThornyPath_Object, PostGravelPath_Object,
        Thorn_Path, Gravel_Path;

    // Start is called before the first frame update
    void Start()
    {
        MainMenu_Object.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        storytextMeshPro.text = storyText;
        hptextMeshPro.text = HPVal.ToString();
        statextmeshPro.text = StaVal.ToString();
    }
    
    
    //TITLE MENU
    public void Menu()
    {
        MainMenu_Object.SetActive(true);  
        Level1_Object.SetActive(false);
        PostGravelPath_Object.SetActive(false);
        PostThornyPath_Object.SetActive(false);
        UIStatsimg.SetActive(false);
        RetryButton.SetActive(false);
        storyText = "Stranded in a forest, you find three paths, which will you take?";
        HPVal = 10;
        StaVal = 10;

    }


    //START
    public void GameStart()
    {
        UIStatsimg.SetActive(true);
        Level1_Object.SetActive(true);
        MainMenu_Object.SetActive(false);
        RetryButton.SetActive(true);
    }
    //LEVELS
    public void ThornyPath()
    {
        storyText = "You managed to get pass through despite having cuts and bruises all over your body, You also found a Steel Sword on the way! Now there's a plant monster in front of you, What do you do?";
        HPVal = HPVal - 5;
        StaVal = StaVal - 3;
        Level1_Object.SetActive(false);
        PostThornyPath_Object.SetActive(true);
    }

    public void GravelPath()
    {
        storyText = "You went through Unscathed, But now theres a huge plant monster in front of you. What do you do?";

        Level1_Object.SetActive(false);
        StaVal = StaVal - 1;
        PostGravelPath_Object.SetActive(true);
    }

    public void HugeFootPrints()
    {
        storyText = "While following the path, the footprint stopped midway. You heard a low growl. A huge mosnter ate you. \n \n \n Obvious Ending: Try not to be too curious" ;
        HPVal = HPVal - 10;
        StaVal = StaVal - 10;

        Level1_Object.SetActive(false);
    }

    //Thorn Route

    public void Fight_Thorn()
    {
        storyText = "You managed to kill the plant monster! it dropped tons of gold! you continued your path and managed to escape the forest! \n \n \n Best Ending: Loot! Loot! but barely alive";
        HPVal = HPVal - 4;
        StaVal = StaVal - 6;
        PostThornyPath_Object.SetActive(false);
    }

    public void Escape_Thorn()
    {
        storyText = "You Escaped the Plant! And managed to escape the forest with a shiny steel sword!  \n \n \n Normal Ending: the sword was shiny!";
        StaVal = StaVal - 3;
        PostThornyPath_Object.SetActive(false);
    }

    //Gravel Route
    public void Fight_Gravel()
    {
        storyText = "You tried fighting the plant wiht your bare hands! It Impaled you with its thorns, you died. \n \n \n Noob Ending: THE VEGTABLE WAS HUGE!";
        HPVal = HPVal - 10;
        StaVal = StaVal - 9;
        PostGravelPath_Object.SetActive(false);

    }

    public void Escape_Gravel()
    {
        storyText = "The pland didnt notice you, and you managed to escape. \n \n \n Boring Ending: wow! You escaped... Nice...";
        StaVal = StaVal - 2;
        PostGravelPath_Object.SetActive(false);

    }
    //EXIT 
    public void Close()
    {
        Application.Quit();
    }
}
