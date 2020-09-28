﻿using UnityEngine;

namespace Logistics
{
    public class Clicker : MonoBehaviour
    {
        private Raycast _raycast;

        private void Awake()
        {
            _raycast = GetComponent<Raycast>();
        }

        private void Update()
        {
            if (!Input.GetMouseButtonDown(0))
                return;
            _raycast.Shoot();
        }
    }
}
