using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CheckTo_Floor_Trigger : MonoBehaviour
{
    #region Variables
    public GameObject playerObject;
    bool isContactToFloor;
    #endregion
    
    //! Check the player contact !
    //? Does the player have any contact with the ground ?
    //* If the player hasn't any contact with the ground, the player cannot jump. *
    
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Parkour"))
        {
            PlayerMove playerMove = playerObject.GetComponent<PlayerMove>();
            playerMove.jumpJump = true;
        }
    }
    void OnTriggerExit2D (Collider2D other)
    {
        if (other.gameObject.CompareTag("Parkour"))
        {
            PlayerMove playerMove = playerObject.GetComponent<PlayerMove>();
            playerMove.jumpJump = false;
        }
    }
}
