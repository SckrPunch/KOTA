using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class startgame : MonoBehaviour
{
    public Animator animator;
    public void PlayGame()
    {
        FadetoLevel();

        //SceneChange();
    }

    public void FadetoLevel()
    {

        animator.SetTrigger("FadeOut");

    }
    public void SceneChange()
    {
        SceneManager.LoadScene(0);
    }
}
