using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PosterScene : MonoBehaviour
{
    public Animator animator;
    public int levelToLoad;

    // Update is called once per frame
    
    public void FadeToStart (int levelIndex)
    {
        levelToLoad = levelIndex;
        animator.SetTrigger("FadeOut");

    }   
    public void OnFadeComplete(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }    

}
