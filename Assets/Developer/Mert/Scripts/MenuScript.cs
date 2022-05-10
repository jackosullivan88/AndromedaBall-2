using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour
{

    [SerializeField] public sfxManager sfxRef;
    [SerializeField] private AudioClip clickSound;
    [SerializeField] private AudioClip backSound;
    private SelectionStorage storageRef;
    private string arena;

    private void Start()
    {
        storageRef = FindObjectOfType<SelectionStorage>();
    }

    public void ButtonPlay(){
        sfxRef.playSFX(clickSound);
        arena = storageRef.LoadArena();
        storageRef.Destroy();
        //TODO character select logic
        SceneManager.LoadScene(arena);
    }
    public void ButtonFighter()
    {
        sfxRef.playSFX(clickSound);
        SceneManager.LoadScene("FighterScene");
    }    public void ButtonArena()
    {
        sfxRef.playSFX(clickSound);
        SceneManager.LoadScene("ArenaScene");
    }
    public void ButtonMainMenu(){
        sfxRef.playSFX(backSound);
        SceneManager.LoadScene("MainMenu");
    }
    public void ButtonControls(){
        sfxRef.playSFX(clickSound);
        SceneManager.LoadScene("ControlsMenu");
    }
    public void ButtonCredits(){
        sfxRef.playSFX(clickSound);
        SceneManager.LoadScene("CreditsMenu");
    }
    public void ButtonQuit(){
        sfxRef.playSFX(clickSound);
        Application.Quit();
    }
}
