using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputControl : MonoBehaviour
{
    public CharacterController character;
    private float playerSpeed = 2.5f;
    string m_HorizontalAxis;
    string m_VerticalAxis;
    string m_Interaction;
    string m_Welcome;

    void Start()
    {
        m_HorizontalAxis = "PlayerA_Horizontal";
        m_VerticalAxis = "PlayerA_Vertical";
        m_Interaction = "PlayerA_Interaction";
        m_Welcome = "PlayerA_Welcome";
    }

    bool BePressInteaction = true;
    bool BePressWelcome = true;


    void Update()
    {
        bool shouldMove = false;
        Vector3 move = new Vector3(0, 0, 0);
        move = new Vector3(Input.GetAxis(m_HorizontalAxis), 0, Input.GetAxis(m_VerticalAxis));
        if (move != Vector3.zero)
        {
            shouldMove = true;
        }

        if (shouldMove)
        {
            character.Move(move * Time.deltaTime * playerSpeed);
        }

        if (Input.GetButton(m_Interaction))
        {
            if (!BePressInteaction)
            {
                Debug.Log("Press Interaction Button !");
            }
            BePressInteaction = true;
        }
        else
        {
            BePressInteaction = false;
        }

        if (Input.GetButton(m_Welcome))
        {
            if (!BePressWelcome)
            {
                Debug.Log("Hold Welcome Button !");
            }
            BePressWelcome = true;
        }
        else
        {
            BePressWelcome = false;
        }


    }
}
