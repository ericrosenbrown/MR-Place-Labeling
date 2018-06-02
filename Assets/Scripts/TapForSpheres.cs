// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See LICENSE in the project root for license information.

using System;
using UnityEngine;
using HoloToolkit.Unity.InputModule;
using HoloToolkit.Unity.InputModule.Utilities.Interactions;

/// <summary>
/// This class implements IInputClickHandler to handle the tap gesture.
/// It increases the scale of the object when tapped.
/// </summary>
public class TapForSpheres : MonoBehaviour, IInputClickHandler {
    public void OnInputClicked(InputClickedEventData eventData) {
        // Increase the scale of the object just as a response.
        gameObject.transform.localScale += 0.05f * gameObject.transform.localScale;
        GameObject s = new GameObject();
        s = GameObject.CreatePrimitive(PrimitiveType.Sphere);
        s.transform.position = new Vector3(this.transform.position.x + 2, this.transform.position.y + 2, this.transform.position.z + 2);
        s.AddComponent<TwoHandManipulatable>();
        eventData.Use(); // Mark the event as used, so it doesn't fall through to other handlers.
    }
}