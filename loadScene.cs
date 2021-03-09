 using UnityEngine;
 using System.Collections;
 
 public class loadScene : MonoBehaviour 
 {
     public void NextLevelButton(int index)
     {
         Application.LoadLevel(index);
     }
 
     public void NextLevelButton(string levelName)
     {
         Application.LoadLevel(levelName);
     }
 }