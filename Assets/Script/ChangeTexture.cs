using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ChangeTexture : MonoBehaviour
{
    [SerializeField]
    private GameObject cube;

    [SerializeField]
    private Material[] materials;

    private Renderer cubeRenderer;
    private int randomMaterialIndex;

    void Start()
    {
        cubeRenderer = cube.GetComponent<Renderer>();
        gameObject.GetComponent<Button>().onClick.AddListener(ChangeCubeMaterial);
    }

    private void ChangeCubeMaterial()
    {
        randomMaterialIndex = Random.Range(0, materials.Length);
        cubeRenderer.material = materials[randomMaterialIndex];
    }
}
