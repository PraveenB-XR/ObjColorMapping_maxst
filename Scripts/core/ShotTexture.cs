using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShotTexture : MonoBehaviour
{
   
    [SerializeField] private GameObject catGameObject;
    [SerializeField] private Texture catTexture;
    private Renderer catMaterial;

    private void Start()
    {
        catMaterial = catGameObject.GetComponent<Renderer>();
    }

    public void ChangeTexture()
    {
        catMaterial.material.mainTexture = catTexture;
    }
}

