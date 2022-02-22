using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class ColorChange : MonoBehaviourPun
{
    [SerializeField] private Color[] colors;
    [SerializeField] private Renderer target;

    int index = 0;

    public void ChangeColor()
    {
        index++;
        if (index >= colors.Length)
            index = 0;

        target.material.color = colors[index];
        photonView.RPC("OnColorChanged", RpcTarget.Others, index);
    }

    [PunRPC]
    public void OnColorChanged(int index)
    {
        this.index = index;
        target.material.color = colors[index];
    }
}
