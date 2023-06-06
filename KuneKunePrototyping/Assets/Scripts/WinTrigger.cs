using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinTrigger : MonoBehaviour
{

    //All Figure tags have been turned on false initially until they are thrown in the well
    public bool figure1Placed = false;
    public bool figure2Placed = false;
    public bool figure3Placed = false;
   

    //Once each Figure collides with well they turn true
    public void OnTriggerEnter(Collider other)

    {
        if (other.gameObject.tag.Equals("Figure1"))
        {
            figure1Placed = true;
            Debug.Log("Figure1 has been collected");
        }


        if (other.gameObject.tag.Equals("Figure2"))
        {
            figure2Placed = true;
            Debug.Log("Figure2 has been collected");
        }

        if (other.gameObject.tag.Equals("Figure3"))
        {
            figure3Placed = true;
            Debug.Log("Figure3 has been collected");
        }


        //If all three Figures are true then Player will load into the winning area
        if (figure1Placed == true && figure2Placed == true && figure1Placed == true )
        {
            SceneManager.LoadScene("WinArea");

        }
       
   

       
      
    }








}

