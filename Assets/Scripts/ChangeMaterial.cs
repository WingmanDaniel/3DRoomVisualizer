using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeMaterial : MonoBehaviour
{
    public Material[] material;
    Renderer rend;
    private int index;
    private int preIndex;
    // Start is called before the first frame update
    void Start()
    {
        index = 0;
        preIndex = index;
        rend = GetComponent<Renderer>();
        rend.enabled = true;
        rend.sharedMaterial = material[preIndex];
    }

    // Update is called once per frame
    void Update()
    {
        if(preIndex != index)
        {
            UpdateMaterial();
        }
    }
    private void UpdateMaterial()
    {
        rend.sharedMaterial = material[index];
        preIndex = index;
    }

    public void SetIndex(int num)
    {
        index = num;
    }
}
