using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwordOrderLayer : MonoBehaviour
{
    #region Variables
    public string sortingLayerName = "Default";
    public string sortingLayerNameTwo = "Default2";
    public int sortingOrder;
    public int sortingOrderTwo;
    #endregion

    //! Sorting weapon layer
    //? What's happening if the player's character turn to other side ?
    //* Sort Swords and Shields according to the side the player's character's is facing *
    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.D))
        {
            PlayerMove isCanMove = FindObjectOfType<PlayerMove>();
            if (isCanMove.isCanMove == true)
            {
                Renderer renderer = GetComponent<Renderer>();
                renderer.sortingLayerName = sortingLayerName;
                renderer.sortingOrder = sortingOrder;
            }   
        }
        else if (Input.GetKeyDown(KeyCode.A))
        {
            PlayerMove isCanMove = FindObjectOfType<PlayerMove>();
            if (isCanMove.isCanMove == true)
            {
                Renderer renderer = GetComponent<Renderer>();
                renderer.sortingLayerName = sortingLayerNameTwo;
                renderer.sortingOrder = sortingOrderTwo;
            }   
        }
    }
}
