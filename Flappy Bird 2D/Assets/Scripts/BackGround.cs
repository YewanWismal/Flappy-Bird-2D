using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackGround : MonoBehaviour
{
    private MeshRenderer meshRenderer;
    private Player player;
    public float animationspeed = 0.05f;
    private void Awake()
    {
        meshRenderer = GetComponent<MeshRenderer>();
        player = FindObjectOfType<Player>();
    }
    private void Update()
    {
        if (player.isDead == false)
        {
            meshRenderer.material.mainTextureOffset += new Vector2(animationspeed * Time.deltaTime, 0);
        }
    }
}
