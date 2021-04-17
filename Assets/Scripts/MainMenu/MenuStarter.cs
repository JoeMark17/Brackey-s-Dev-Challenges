using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class MenuStarter : MonoBehaviour
{
    //public Animator transition; //This will be set to a transition animation if used.
    public float transitionTime = 1f;
    public void PlayGame ()
    {
        //This will transition the next scene in the build index.
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1); 
    }

    IEnumerator LoadLevel(int levelIndex)
    {
        //Play transition animation if used.
        //transition.SetTrigger("Start"); //Use if you want an animation to transition.

        //Wait for the animation to end
        yield return new WaitForSeconds(transitionTime);

        //Load the scene
        SceneManager.LoadScene(levelIndex);
    }

    //Quit function to set for a button. Will want to check this is working.
    public void QuitGame ()
    {
        Debug.Log("Quit the Game.");
        Application.Quit();

    }
}
