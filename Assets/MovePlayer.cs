
/*
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;
using Valve.VR.InteractionSystem;

public class MovePlayer : MonoBehaviour
{
   // Use this for initialization

    private void start(){
        trigger.AddOnStateDownListener(OnTriggerPressed, inputSource);
        trigger.AddOnStateUpListener(OnTriggerReleased, inputSource);
    }
    public void OnTriggerPressed(SteamVR_Action_Boolean action_In, SteamVR_Input_Sources fromSource)
    {
        Debug.Log("Trigger was released");
        moveValue = 1;
        Debug.Log(moveValue);
    }
    public void OnTriggerReleased(SteamVR_Action_Boolean action_In, SteamVR_Input_Sources fromSource)
    {
        Debug.Log("Trigger was released");
        moveValue = 0;
        Debug.Log(moveValue);
    }

    // Update is called once per frame
    void Update()
    {
        if(moveValue>0){
            Vector3 direction = Player.instance.hmdTransform.TransformDirection(new Vector3(0,0,moveValue));
            speed = moveValue * sensitivity;
            speed = Mathf.Clamp(speed, 0, maxSpeed);
            transform.position += speed * Time.deltaTime * Vector3.ProjectOnPlane(direction, Vector3.up);
        }
    }
}
*/

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;
using Valve.VR.InteractionSystem;
public class MovePlayer : MonoBehaviour
{
    // move value used to move forward or not

    public int moveValue;
    public float maxSpeed;
    private float speed;
    // a reference to the action
    public SteamVR_Action_Boolean trigger;
    // a reference to the hand
    public SteamVR_Input_Sources handType;
    //reference to the sphere
    void Start()
    {
        trigger.AddOnStateDownListener(TriggerDown, handType);
        trigger.AddOnStateUpListener(TriggerUp, handType);
    }
    public void TriggerUp(SteamVR_Action_Boolean fromAction, SteamVR_Input_Sources fromSource)
    {
        moveValue = 0;
        Debug.Log("Trigger is up");
    }
    public void TriggerDown(SteamVR_Action_Boolean fromAction, SteamVR_Input_Sources fromSource)
    {
        moveValue = 25;
        Debug.Log("Trigger is down");
    }
    void Update()
    {
        if(moveValue>0){
            Vector3 direction = Player.instance.hmdTransform.TransformDirection(new Vector3(0,0,moveValue));
            speed = moveValue;
            speed = Mathf.Clamp(speed, 0, maxSpeed);
            transform.position += speed * Time.deltaTime * Vector3.ProjectOnPlane(direction, Vector3.up);
        }
    }
}