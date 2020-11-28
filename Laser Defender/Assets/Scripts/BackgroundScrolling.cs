using System;
using UnityEngine;

namespace DefaultNamespace
{
    [RequireComponent(typeof(Renderer))]
    public class BackgroundScrolling : MonoBehaviour
    {
        [SerializeField] 
        private float scrollingSpeed;

        private Material _material;
        
        private void Awake()
        {
            _material = GetComponent<Renderer>().material;
        }

        private void Update()
        {
            _material.mainTextureOffset = new Vector2(0, scrollingSpeed * Time.time);
        }
    }
}