using UnityEngine;
using HoloToolkit.Unity.InputModule;
using RosSharp.RosBridgeClient;

public class SpeechHandler : MonoBehaviour, ISpeechHandler {
  
    void ISpeechHandler.OnSpeechKeywordRecognized(SpeechEventData eventData) {
    }

    // Sends the goal position to MoveIt
    public void Plan() {
        Debug.Log("Plan");
        //GameObject go = GameObject.CreatePrimitive(PrimitiveType.Sphere);
        //go.AddComponent<Animation>();
        //go.AddComponent<MeshFilter>();
        //go.AddComponent<MeshCollider>();
        //go.AddComponent<MeshRenderer>();
    }

    // Tells MoveIt to execute the plan
    public void Move() {
        Debug.Log("Execute");
    }

    public void Activate() {
        Debug.Log("Activate");
    }
}