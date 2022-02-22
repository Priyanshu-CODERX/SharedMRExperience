using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using Microsoft.MixedReality.Toolkit;

public class PinPlacer : MonoBehaviour
{
    public void PlacePin()
    {
        PhotonNetwork.Instantiate("PinRed", CoreServices.InputSystem.GazeProvider.GazeCursor.Position, CoreServices.InputSystem.GazeProvider.GazeCursor.Rotation);
    }
}
