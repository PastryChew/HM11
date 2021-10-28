using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace WildBall.Inputs
{
    [RequireComponent(typeof(PlayerMovement))]
    public class PlayerInput : MonoBehaviour
    {
        private Vector3 movement;
        private PlayerMovement PlayerMovement;

        private void Awake()
        {
            PlayerMovement = GetComponent<PlayerMovement>();
        }

        // Update is called once per frame
        void Update()
        {
            float Horizontal = Input.GetAxis(GlobalStringVars.Horizontal_Axis);
            float Vertical = Input.GetAxis(GlobalStringVars.Vertical_Axis);

            movement = new Vector3(Horizontal, 0, Vertical).normalized;
        }

        private void FixedUpdate()
        {
            PlayerMovement.MoveCharacter(movement);
        }


    }
}
