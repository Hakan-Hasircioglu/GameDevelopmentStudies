using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unused_HP_Recovery : MonoBehaviour
{
    public float PlayerHp = 5;
    /**
    *?      This variable check to Player Hp. If the Player HP is less than this variable,
    *!  it means the Player taking damage */
    float checkPlayerHp = 4.999999f;
    float Recoverytime = 200;
    public bool isTakingDamage = false;

    void FixedUpdate()
    {
        if (PlayerHp <= checkPlayerHp)
        {
            checkPlayerHp = PlayerHp - 0.000001f;
            isTakingDamage = true;
        }
        if (isTakingDamage == true)
        {
            Recoverytime--;
            if (Recoverytime == 0)
            {
                isTakingDamage = false;
                Recoverytime = 200;
            }
        }
        if (isTakingDamage == false)
        {
            if (PlayerHp < 5f)
            {
                PlayerHp += 0.0025f;
                checkPlayerHp = PlayerHp - 0.000001f;
            }

        }
    }
}