//uScript Generated Code - Build 1.0.3085
//Generated with Debug Info
using UnityEngine;
using System.Collections;
using System.Collections.Generic;

[NodePath("Graphs")]
[System.Serializable]
[FriendlyName("Untitled", "")]
public class PlayerScript : uScriptLogic
{

   #pragma warning disable 414
   GameObject parentGameObject = null;
   uScript_GUI thisScriptsOnGuiListener = null; 
   bool m_RegisteredForEvents = false;
   delegate void ContinueExecution();
   ContinueExecution m_ContinueExecution;
   bool m_Breakpoint = false;
   const int MaxRelayCallCount = 1000;
   int relayCallCount = 0;
   
   //externally exposed events
   
   //external parameters
   
   //local nodes
   System.Single local_11_System_Single = (float) 0;
   System.Single local_12_System_Single = (float) 0;
   UnityEngine.Vector3 local_14_UnityEngine_Vector3 = new Vector3( (float)0, (float)0, (float)0 );
   UnityEngine.GameObject local_16_UnityEngine_GameObject = default(UnityEngine.GameObject);
   UnityEngine.GameObject local_16_UnityEngine_GameObject_previous = null;
   UnityEngine.GameObject local_30_UnityEngine_GameObject = default(UnityEngine.GameObject);
   UnityEngine.GameObject local_30_UnityEngine_GameObject_previous = null;
   UnityEngine.Vector3 local_9_UnityEngine_Vector3 = new Vector3( (float)0, (float)0, (float)0 );
   System.Boolean local_Fire_button_held_down__System_Boolean = (bool) false;
   System.Single local_FireRate_System_Single = (float) 0.2;
   
   //owner nodes
   UnityEngine.GameObject owner_Connection_3 = null;
   UnityEngine.GameObject owner_Connection_5 = null;
   
   //logic nodes
   //pointer to script instanced logic node
   uScriptAct_OnInputEventFilter logic_uScriptAct_OnInputEventFilter_uScriptAct_OnInputEventFilter_1 = new uScriptAct_OnInputEventFilter( );
   UnityEngine.KeyCode logic_uScriptAct_OnInputEventFilter_KeyCode_1 = UnityEngine.KeyCode.W;
   bool logic_uScriptAct_OnInputEventFilter_KeyDown_1 = true;
   bool logic_uScriptAct_OnInputEventFilter_KeyHeld_1 = true;
   bool logic_uScriptAct_OnInputEventFilter_KeyUp_1 = true;
   //pointer to script instanced logic node
   uScriptAct_OnInputEventFilter logic_uScriptAct_OnInputEventFilter_uScriptAct_OnInputEventFilter_6 = new uScriptAct_OnInputEventFilter( );
   UnityEngine.KeyCode logic_uScriptAct_OnInputEventFilter_KeyCode_6 = UnityEngine.KeyCode.S;
   bool logic_uScriptAct_OnInputEventFilter_KeyDown_6 = true;
   bool logic_uScriptAct_OnInputEventFilter_KeyHeld_6 = true;
   bool logic_uScriptAct_OnInputEventFilter_KeyUp_6 = true;
   //pointer to script instanced logic node
   uScriptAct_RaycastFromCursor logic_uScriptAct_RaycastFromCursor_uScriptAct_RaycastFromCursor_8 = new uScriptAct_RaycastFromCursor( );
   UnityEngine.Camera logic_uScriptAct_RaycastFromCursor_Camera_8 = default(UnityEngine.Camera);
   System.Single logic_uScriptAct_RaycastFromCursor_Distance_8 = (float) 100;
   UnityEngine.LayerMask logic_uScriptAct_RaycastFromCursor_layerMask_8 = 1;
   System.Boolean logic_uScriptAct_RaycastFromCursor_include_8 = (bool) true;
   System.Boolean logic_uScriptAct_RaycastFromCursor_showRay_8 = (bool) false;
   UnityEngine.GameObject logic_uScriptAct_RaycastFromCursor_HitObject_8;
   System.Single logic_uScriptAct_RaycastFromCursor_HitDistance_8;
   UnityEngine.Vector3 logic_uScriptAct_RaycastFromCursor_HitLocation_8;
   UnityEngine.Vector3 logic_uScriptAct_RaycastFromCursor_HitNormal_8;
   bool logic_uScriptAct_RaycastFromCursor_NotObstructed_8 = true;
   bool logic_uScriptAct_RaycastFromCursor_Obstructed_8 = true;
   //pointer to script instanced logic node
   uScriptAct_GetComponentsVector3 logic_uScriptAct_GetComponentsVector3_uScriptAct_GetComponentsVector3_10 = new uScriptAct_GetComponentsVector3( );
   UnityEngine.Vector3 logic_uScriptAct_GetComponentsVector3_InputVector3_10 = new Vector3( );
   System.Single logic_uScriptAct_GetComponentsVector3_X_10;
   System.Single logic_uScriptAct_GetComponentsVector3_Y_10;
   System.Single logic_uScriptAct_GetComponentsVector3_Z_10;
   bool logic_uScriptAct_GetComponentsVector3_Out_10 = true;
   //pointer to script instanced logic node
   uScriptAct_SetComponentsVector3 logic_uScriptAct_SetComponentsVector3_uScriptAct_SetComponentsVector3_13 = new uScriptAct_SetComponentsVector3( );
   System.Single logic_uScriptAct_SetComponentsVector3_X_13 = (float) 0;
   System.Single logic_uScriptAct_SetComponentsVector3_Y_13 = (float) 0.5;
   System.Single logic_uScriptAct_SetComponentsVector3_Z_13 = (float) 0;
   UnityEngine.Vector3 logic_uScriptAct_SetComponentsVector3_OutputVector3_13;
   bool logic_uScriptAct_SetComponentsVector3_Out_13 = true;
   //pointer to script instanced logic node
   uScriptAct_LookAt logic_uScriptAct_LookAt_uScriptAct_LookAt_15 = new uScriptAct_LookAt( );
   UnityEngine.GameObject[] logic_uScriptAct_LookAt_Target_15 = new UnityEngine.GameObject[] {};
   System.Object logic_uScriptAct_LookAt_Focus_15 = "";
   System.Single logic_uScriptAct_LookAt_time_15 = (float) 0;
   uScriptAct_LookAt.LockAxis logic_uScriptAct_LookAt_lockAxis_15 = uScriptAct_LookAt.LockAxis.None;
   bool logic_uScriptAct_LookAt_Out_15 = true;
   //pointer to script instanced logic node
   uScriptAct_OnInputEventFilter logic_uScriptAct_OnInputEventFilter_uScriptAct_OnInputEventFilter_17 = new uScriptAct_OnInputEventFilter( );
   UnityEngine.KeyCode logic_uScriptAct_OnInputEventFilter_KeyCode_17 = UnityEngine.KeyCode.Space;
   bool logic_uScriptAct_OnInputEventFilter_KeyDown_17 = true;
   bool logic_uScriptAct_OnInputEventFilter_KeyHeld_17 = true;
   bool logic_uScriptAct_OnInputEventFilter_KeyUp_17 = true;
   //pointer to script instanced logic node
   uScriptAct_SpawnPrefab logic_uScriptAct_SpawnPrefab_uScriptAct_SpawnPrefab_18 = new uScriptAct_SpawnPrefab( );
   System.String logic_uScriptAct_SpawnPrefab_PrefabName_18 = "Bullet";
   System.String logic_uScriptAct_SpawnPrefab_ResourcePath_18 = "";
   UnityEngine.GameObject logic_uScriptAct_SpawnPrefab_SpawnPoint_18 = default(UnityEngine.GameObject);
   System.String logic_uScriptAct_SpawnPrefab_SpawnedName_18 = "";
   UnityEngine.Vector3 logic_uScriptAct_SpawnPrefab_LocationOffset_18 = new Vector3( (float)0, (float)0, (float)0 );
   UnityEngine.GameObject logic_uScriptAct_SpawnPrefab_SpawnedGameObject_18;
   System.Int32 logic_uScriptAct_SpawnPrefab_SpawnedInstancedID_18;
   bool logic_uScriptAct_SpawnPrefab_Immediate_18 = true;
   //pointer to script instanced logic node
   uScriptAct_SetBool logic_uScriptAct_SetBool_uScriptAct_SetBool_20 = new uScriptAct_SetBool( );
   System.Boolean logic_uScriptAct_SetBool_Target_20;
   bool logic_uScriptAct_SetBool_Out_20 = true;
   bool logic_uScriptAct_SetBool_SetTrue_20 = true;
   bool logic_uScriptAct_SetBool_SetFalse_20 = true;
   //pointer to script instanced logic node
   uScriptAct_SetBool logic_uScriptAct_SetBool_uScriptAct_SetBool_23 = new uScriptAct_SetBool( );
   System.Boolean logic_uScriptAct_SetBool_Target_23;
   bool logic_uScriptAct_SetBool_Out_23 = true;
   bool logic_uScriptAct_SetBool_SetTrue_23 = true;
   bool logic_uScriptAct_SetBool_SetFalse_23 = true;
   //pointer to script instanced logic node
   uScriptCon_CompareBool logic_uScriptCon_CompareBool_uScriptCon_CompareBool_24 = new uScriptCon_CompareBool( );
   System.Boolean logic_uScriptCon_CompareBool_Bool_24 = (bool) false;
   bool logic_uScriptCon_CompareBool_True_24 = true;
   bool logic_uScriptCon_CompareBool_False_24 = true;
   //pointer to script instanced logic node
   uScriptAct_Delay logic_uScriptAct_Delay_uScriptAct_Delay_25 = new uScriptAct_Delay( );
   System.Single logic_uScriptAct_Delay_Duration_25 = (float) 0;
   System.Boolean logic_uScriptAct_Delay_SingleFrame_25 = (bool) false;
   bool logic_uScriptAct_Delay_Immediate_25 = true;
   bool logic_uScriptAct_Delay_AfterDelay_25 = true;
   bool logic_uScriptAct_Delay_Stopped_25 = true;
   bool logic_uScriptAct_Delay_DrivenDelay_25 = false;
   //pointer to script instanced logic node
   uScriptAct_Toggle logic_uScriptAct_Toggle_uScriptAct_Toggle_29 = new uScriptAct_Toggle( );
   UnityEngine.GameObject[] logic_uScriptAct_Toggle_Target_29 = new UnityEngine.GameObject[] {};
   System.Boolean logic_uScriptAct_Toggle_IgnoreChildren_29 = (bool) false;
   bool logic_uScriptAct_Toggle_Out_29 = true;
   //pointer to script instanced logic node
   uScriptAct_Delay logic_uScriptAct_Delay_uScriptAct_Delay_31 = new uScriptAct_Delay( );
   System.Single logic_uScriptAct_Delay_Duration_31 = (float) 0.1;
   System.Boolean logic_uScriptAct_Delay_SingleFrame_31 = (bool) false;
   bool logic_uScriptAct_Delay_Immediate_31 = true;
   bool logic_uScriptAct_Delay_AfterDelay_31 = true;
   bool logic_uScriptAct_Delay_Stopped_31 = true;
   bool logic_uScriptAct_Delay_DrivenDelay_31 = false;
   
   //event nodes
   UnityEngine.GameObject event_UnityEngine_GameObject_Instance_0 = default(UnityEngine.GameObject);
   UnityEngine.GameObject event_UnityEngine_GameObject_Instance_7 = default(UnityEngine.GameObject);
   UnityEngine.GameObject event_UnityEngine_GameObject_Instance_28 = default(UnityEngine.GameObject);
   
   //property nodes
   
   //method nodes
   System.Single method_Detox_ScriptEditor_Plug_UnityEngine_GameObject_x_2 = (float) 0;
   System.Single method_Detox_ScriptEditor_Plug_UnityEngine_GameObject_y_2 = (float) 0;
   System.Single method_Detox_ScriptEditor_Plug_UnityEngine_GameObject_z_2 = (float) 0.1;
   System.Single method_Detox_ScriptEditor_Plug_UnityEngine_GameObject_x_4 = (float) 0;
   System.Single method_Detox_ScriptEditor_Plug_UnityEngine_GameObject_y_4 = (float) 0;
   System.Single method_Detox_ScriptEditor_Plug_UnityEngine_GameObject_z_4 = (float) -0.1;
   #pragma warning restore 414
   
   //functions to refresh properties from entities
   
   void SyncUnityHooks( )
   {
      SyncEventListeners( );
      if ( null == logic_uScriptAct_RaycastFromCursor_Camera_8 || false == m_RegisteredForEvents )
      {
         GameObject gameObject = GameObject.Find( "/Main Camera" );
         if ( null != gameObject )
         {
            logic_uScriptAct_RaycastFromCursor_Camera_8 = gameObject.GetComponent<UnityEngine.Camera>();
         }
      }
      if ( null == logic_uScriptAct_SpawnPrefab_SpawnPoint_18 || false == m_RegisteredForEvents )
      {
         logic_uScriptAct_SpawnPrefab_SpawnPoint_18 = GameObject.Find( "/Player/Weapon" ) as UnityEngine.GameObject;
      }
      if ( null == local_16_UnityEngine_GameObject || false == m_RegisteredForEvents )
      {
         local_16_UnityEngine_GameObject = GameObject.Find( "Player" ) as UnityEngine.GameObject;
      }
      //if our game object reference was changed then we need to reset event listeners
      if ( local_16_UnityEngine_GameObject_previous != local_16_UnityEngine_GameObject || false == m_RegisteredForEvents )
      {
         //tear down old listeners
         
         local_16_UnityEngine_GameObject_previous = local_16_UnityEngine_GameObject;
         
         //setup new listeners
      }
      if ( null == local_30_UnityEngine_GameObject || false == m_RegisteredForEvents )
      {
         local_30_UnityEngine_GameObject = GameObject.Find( "Point light" ) as UnityEngine.GameObject;
      }
      //if our game object reference was changed then we need to reset event listeners
      if ( local_30_UnityEngine_GameObject_previous != local_30_UnityEngine_GameObject || false == m_RegisteredForEvents )
      {
         //tear down old listeners
         
         local_30_UnityEngine_GameObject_previous = local_30_UnityEngine_GameObject;
         
         //setup new listeners
      }
      if ( null == owner_Connection_3 || false == m_RegisteredForEvents )
      {
         owner_Connection_3 = parentGameObject;
      }
      if ( null == owner_Connection_5 || false == m_RegisteredForEvents )
      {
         owner_Connection_5 = parentGameObject;
      }
   }
   
   void RegisterForUnityHooks( )
   {
      SyncEventListeners( );
      //if our game object reference was changed then we need to reset event listeners
      if ( local_16_UnityEngine_GameObject_previous != local_16_UnityEngine_GameObject || false == m_RegisteredForEvents )
      {
         //tear down old listeners
         
         local_16_UnityEngine_GameObject_previous = local_16_UnityEngine_GameObject;
         
         //setup new listeners
      }
      //if our game object reference was changed then we need to reset event listeners
      if ( local_30_UnityEngine_GameObject_previous != local_30_UnityEngine_GameObject || false == m_RegisteredForEvents )
      {
         //tear down old listeners
         
         local_30_UnityEngine_GameObject_previous = local_30_UnityEngine_GameObject;
         
         //setup new listeners
      }
   }
   
   void SyncEventListeners( )
   {
      if ( null == event_UnityEngine_GameObject_Instance_0 || false == m_RegisteredForEvents )
      {
         event_UnityEngine_GameObject_Instance_0 = uScript_MasterComponent.LatestMaster;
         if ( null != event_UnityEngine_GameObject_Instance_0 )
         {
            {
               uScript_Input component = event_UnityEngine_GameObject_Instance_0.GetComponent<uScript_Input>();
               if ( null == component )
               {
                  component = event_UnityEngine_GameObject_Instance_0.AddComponent<uScript_Input>();
               }
               if ( null != component )
               {
                  component.KeyEvent += Instance_KeyEvent_0;
               }
            }
         }
      }
      if ( null == event_UnityEngine_GameObject_Instance_7 || false == m_RegisteredForEvents )
      {
         event_UnityEngine_GameObject_Instance_7 = uScript_MasterComponent.LatestMaster;
         if ( null != event_UnityEngine_GameObject_Instance_7 )
         {
            {
               uScript_Update component = event_UnityEngine_GameObject_Instance_7.GetComponent<uScript_Update>();
               if ( null == component )
               {
                  component = event_UnityEngine_GameObject_Instance_7.AddComponent<uScript_Update>();
               }
               if ( null != component )
               {
                  component.OnUpdate += Instance_OnUpdate_7;
                  component.OnLateUpdate += Instance_OnLateUpdate_7;
                  component.OnFixedUpdate += Instance_OnFixedUpdate_7;
               }
            }
         }
      }
      if ( null == event_UnityEngine_GameObject_Instance_28 || false == m_RegisteredForEvents )
      {
         event_UnityEngine_GameObject_Instance_28 = uScript_MasterComponent.LatestMaster;
         if ( null != event_UnityEngine_GameObject_Instance_28 )
         {
            {
               uScript_Global component = event_UnityEngine_GameObject_Instance_28.GetComponent<uScript_Global>();
               if ( null == component )
               {
                  component = event_UnityEngine_GameObject_Instance_28.AddComponent<uScript_Global>();
               }
               if ( null != component )
               {
                  component.uScriptStart += Instance_uScriptStart_28;
                  component.uScriptLateStart += Instance_uScriptLateStart_28;
               }
            }
         }
      }
   }
   
   void UnregisterEventListeners( )
   {
      if ( null != event_UnityEngine_GameObject_Instance_0 )
      {
         {
            uScript_Input component = event_UnityEngine_GameObject_Instance_0.GetComponent<uScript_Input>();
            if ( null != component )
            {
               component.KeyEvent -= Instance_KeyEvent_0;
            }
         }
      }
      if ( null != event_UnityEngine_GameObject_Instance_7 )
      {
         {
            uScript_Update component = event_UnityEngine_GameObject_Instance_7.GetComponent<uScript_Update>();
            if ( null != component )
            {
               component.OnUpdate -= Instance_OnUpdate_7;
               component.OnLateUpdate -= Instance_OnLateUpdate_7;
               component.OnFixedUpdate -= Instance_OnFixedUpdate_7;
            }
         }
      }
      if ( null != event_UnityEngine_GameObject_Instance_28 )
      {
         {
            uScript_Global component = event_UnityEngine_GameObject_Instance_28.GetComponent<uScript_Global>();
            if ( null != component )
            {
               component.uScriptStart -= Instance_uScriptStart_28;
               component.uScriptLateStart -= Instance_uScriptLateStart_28;
            }
         }
      }
   }
   
   public override void SetParent(GameObject g)
   {
      parentGameObject = g;
      
      logic_uScriptAct_OnInputEventFilter_uScriptAct_OnInputEventFilter_1.SetParent(g);
      logic_uScriptAct_OnInputEventFilter_uScriptAct_OnInputEventFilter_6.SetParent(g);
      logic_uScriptAct_RaycastFromCursor_uScriptAct_RaycastFromCursor_8.SetParent(g);
      logic_uScriptAct_GetComponentsVector3_uScriptAct_GetComponentsVector3_10.SetParent(g);
      logic_uScriptAct_SetComponentsVector3_uScriptAct_SetComponentsVector3_13.SetParent(g);
      logic_uScriptAct_LookAt_uScriptAct_LookAt_15.SetParent(g);
      logic_uScriptAct_OnInputEventFilter_uScriptAct_OnInputEventFilter_17.SetParent(g);
      logic_uScriptAct_SpawnPrefab_uScriptAct_SpawnPrefab_18.SetParent(g);
      logic_uScriptAct_SetBool_uScriptAct_SetBool_20.SetParent(g);
      logic_uScriptAct_SetBool_uScriptAct_SetBool_23.SetParent(g);
      logic_uScriptCon_CompareBool_uScriptCon_CompareBool_24.SetParent(g);
      logic_uScriptAct_Delay_uScriptAct_Delay_25.SetParent(g);
      logic_uScriptAct_Toggle_uScriptAct_Toggle_29.SetParent(g);
      logic_uScriptAct_Delay_uScriptAct_Delay_31.SetParent(g);
      owner_Connection_3 = parentGameObject;
      owner_Connection_5 = parentGameObject;
   }
   public void Awake()
   {
      
      logic_uScriptAct_LookAt_uScriptAct_LookAt_15.Finished += uScriptAct_LookAt_Finished_15;
      logic_uScriptAct_SpawnPrefab_uScriptAct_SpawnPrefab_18.FinishedSpawning += uScriptAct_SpawnPrefab_FinishedSpawning_18;
      logic_uScriptAct_Toggle_uScriptAct_Toggle_29.OnOut += uScriptAct_Toggle_OnOut_29;
      logic_uScriptAct_Toggle_uScriptAct_Toggle_29.OffOut += uScriptAct_Toggle_OffOut_29;
      logic_uScriptAct_Toggle_uScriptAct_Toggle_29.ToggleOut += uScriptAct_Toggle_ToggleOut_29;
   }
   
   public void Start()
   {
      SyncUnityHooks( );
      m_RegisteredForEvents = true;
      
   }
   
   public void OnEnable()
   {
      RegisterForUnityHooks( );
      m_RegisteredForEvents = true;
   }
   
   public void OnDisable()
   {
      UnregisterEventListeners( );
      m_RegisteredForEvents = false;
   }
   
   public void Update()
   {
      //reset each Update, and increments each method call
      //if it ever goes above MaxRelayCallCount before being reset
      //then we assume it is stuck in an infinite loop
      if ( relayCallCount < MaxRelayCallCount ) relayCallCount = 0;
      if ( null != m_ContinueExecution )
      {
         ContinueExecution continueEx = m_ContinueExecution;
         m_ContinueExecution = null;
         m_Breakpoint = false;
         continueEx( );
         return;
      }
      UpdateEditorValues( );
      
      //other scripts might have added GameObjects with event scripts
      //so we need to verify all our event listeners are registered
      SyncEventListeners( );
      
      logic_uScriptAct_LookAt_uScriptAct_LookAt_15.Update( );
      logic_uScriptAct_SpawnPrefab_uScriptAct_SpawnPrefab_18.Update( );
      if (true == logic_uScriptAct_Delay_DrivenDelay_25)
      {
         Relay_DrivenDelay_25();
      }
      if (true == logic_uScriptAct_Delay_DrivenDelay_31)
      {
         Relay_DrivenDelay_31();
      }
   }
   
   public void OnDestroy()
   {
      logic_uScriptAct_LookAt_uScriptAct_LookAt_15.Finished -= uScriptAct_LookAt_Finished_15;
      logic_uScriptAct_SpawnPrefab_uScriptAct_SpawnPrefab_18.FinishedSpawning -= uScriptAct_SpawnPrefab_FinishedSpawning_18;
      logic_uScriptAct_Toggle_uScriptAct_Toggle_29.OnOut -= uScriptAct_Toggle_OnOut_29;
      logic_uScriptAct_Toggle_uScriptAct_Toggle_29.OffOut -= uScriptAct_Toggle_OffOut_29;
      logic_uScriptAct_Toggle_uScriptAct_Toggle_29.ToggleOut -= uScriptAct_Toggle_ToggleOut_29;
   }
   
   void Instance_KeyEvent_0(object o, System.EventArgs e)
   {
      //reset event call
      //if it ever goes above MaxRelayCallCount before being reset
      //then we assume it is stuck in an infinite loop
      if ( relayCallCount < MaxRelayCallCount ) relayCallCount = 0;
      
      //fill globals
      //relay event to nodes
      Relay_KeyEvent_0( );
   }
   
   void Instance_OnUpdate_7(object o, System.EventArgs e)
   {
      //reset event call
      //if it ever goes above MaxRelayCallCount before being reset
      //then we assume it is stuck in an infinite loop
      if ( relayCallCount < MaxRelayCallCount ) relayCallCount = 0;
      
      //fill globals
      //relay event to nodes
      Relay_OnUpdate_7( );
   }
   
   void Instance_OnLateUpdate_7(object o, System.EventArgs e)
   {
      //reset event call
      //if it ever goes above MaxRelayCallCount before being reset
      //then we assume it is stuck in an infinite loop
      if ( relayCallCount < MaxRelayCallCount ) relayCallCount = 0;
      
      //fill globals
      //relay event to nodes
      Relay_OnLateUpdate_7( );
   }
   
   void Instance_OnFixedUpdate_7(object o, System.EventArgs e)
   {
      //reset event call
      //if it ever goes above MaxRelayCallCount before being reset
      //then we assume it is stuck in an infinite loop
      if ( relayCallCount < MaxRelayCallCount ) relayCallCount = 0;
      
      //fill globals
      //relay event to nodes
      Relay_OnFixedUpdate_7( );
   }
   
   void Instance_uScriptStart_28(object o, System.EventArgs e)
   {
      //reset event call
      //if it ever goes above MaxRelayCallCount before being reset
      //then we assume it is stuck in an infinite loop
      if ( relayCallCount < MaxRelayCallCount ) relayCallCount = 0;
      
      //fill globals
      //relay event to nodes
      Relay_uScriptStart_28( );
   }
   
   void Instance_uScriptLateStart_28(object o, System.EventArgs e)
   {
      //reset event call
      //if it ever goes above MaxRelayCallCount before being reset
      //then we assume it is stuck in an infinite loop
      if ( relayCallCount < MaxRelayCallCount ) relayCallCount = 0;
      
      //fill globals
      //relay event to nodes
      Relay_uScriptLateStart_28( );
   }
   
   void uScriptAct_LookAt_Finished_15(object o, System.EventArgs e)
   {
      //fill globals
      //relay event to nodes
      Relay_Finished_15( );
   }
   
   void uScriptAct_SpawnPrefab_FinishedSpawning_18(object o, System.EventArgs e)
   {
      //fill globals
      //links to SpawnedGameObject = 0
      //links to SpawnedInstancedID = 0
      //relay event to nodes
      Relay_FinishedSpawning_18( );
   }
   
   void uScriptAct_Toggle_OnOut_29(object o, System.EventArgs e)
   {
      //fill globals
      //relay event to nodes
      Relay_OnOut_29( );
   }
   
   void uScriptAct_Toggle_OffOut_29(object o, System.EventArgs e)
   {
      //fill globals
      //relay event to nodes
      Relay_OffOut_29( );
   }
   
   void uScriptAct_Toggle_ToggleOut_29(object o, System.EventArgs e)
   {
      //fill globals
      //relay event to nodes
      Relay_ToggleOut_29( );
   }
   
   void Relay_KeyEvent_0()
   {
      if (true == CheckDebugBreak("979c3836-79a4-4cb2-8264-b91c886a4285", "Input_Events", Relay_KeyEvent_0)) return; 
      Relay_In_1();
      Relay_In_6();
      Relay_In_17();
   }
   
   void Relay_In_1()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("d3653ac1-1b26-4079-a39a-cc4f0959e52b", "Input_Events_Filter", Relay_In_1)) return; 
         {
            {
            }
         }
         logic_uScriptAct_OnInputEventFilter_uScriptAct_OnInputEventFilter_1.In(logic_uScriptAct_OnInputEventFilter_KeyCode_1);
         
         //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
         bool test_0 = logic_uScriptAct_OnInputEventFilter_uScriptAct_OnInputEventFilter_1.KeyHeld;
         
         if ( test_0 == true )
         {
            Relay_Translate_2();
         }
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript PlayerScript.uscript at Input Events Filter.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   void Relay_Translate_2()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("9f454572-6b73-455e-87e1-c70b61aafce7", "UnityEngine_Transform", Relay_Translate_2)) return; 
         {
            {
            }
            {
            }
            {
            }
         }
         {
            UnityEngine.Transform component;
            component = owner_Connection_3.GetComponent<UnityEngine.Transform>();
            if ( null != component )
            {
               component.Translate(method_Detox_ScriptEditor_Plug_UnityEngine_GameObject_x_2, method_Detox_ScriptEditor_Plug_UnityEngine_GameObject_y_2, method_Detox_ScriptEditor_Plug_UnityEngine_GameObject_z_2);
            }
         }
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript PlayerScript.uscript at UnityEngine.Transform.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   void Relay_Translate_4()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("56346892-9d36-4eee-bc97-e492877d1de4", "UnityEngine_Transform", Relay_Translate_4)) return; 
         {
            {
            }
            {
            }
            {
            }
         }
         {
            UnityEngine.Transform component;
            component = owner_Connection_5.GetComponent<UnityEngine.Transform>();
            if ( null != component )
            {
               component.Translate(method_Detox_ScriptEditor_Plug_UnityEngine_GameObject_x_4, method_Detox_ScriptEditor_Plug_UnityEngine_GameObject_y_4, method_Detox_ScriptEditor_Plug_UnityEngine_GameObject_z_4);
            }
         }
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript PlayerScript.uscript at UnityEngine.Transform.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   void Relay_In_6()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("49a0e846-16d3-4667-a439-55e9f05e99fc", "Input_Events_Filter", Relay_In_6)) return; 
         {
            {
            }
         }
         logic_uScriptAct_OnInputEventFilter_uScriptAct_OnInputEventFilter_6.In(logic_uScriptAct_OnInputEventFilter_KeyCode_6);
         
         //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
         bool test_0 = logic_uScriptAct_OnInputEventFilter_uScriptAct_OnInputEventFilter_6.KeyHeld;
         
         if ( test_0 == true )
         {
            Relay_Translate_4();
         }
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript PlayerScript.uscript at Input Events Filter.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   void Relay_OnUpdate_7()
   {
      if (true == CheckDebugBreak("728fcbe9-ec60-4aea-8fab-063869230c38", "Global_Update", Relay_OnUpdate_7)) return; 
      Relay_In_8();
   }
   
   void Relay_OnLateUpdate_7()
   {
      if (true == CheckDebugBreak("728fcbe9-ec60-4aea-8fab-063869230c38", "Global_Update", Relay_OnLateUpdate_7)) return; 
   }
   
   void Relay_OnFixedUpdate_7()
   {
      if (true == CheckDebugBreak("728fcbe9-ec60-4aea-8fab-063869230c38", "Global_Update", Relay_OnFixedUpdate_7)) return; 
   }
   
   void Relay_In_8()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("021cdefc-ac69-4c5e-9efd-66d019175287", "Raycast_From_Mouse_Cursor", Relay_In_8)) return; 
         {
            {
            }
            {
            }
            {
            }
            {
            }
            {
            }
            {
            }
            {
            }
            {
            }
            {
            }
         }
         logic_uScriptAct_RaycastFromCursor_uScriptAct_RaycastFromCursor_8.In(logic_uScriptAct_RaycastFromCursor_Camera_8, logic_uScriptAct_RaycastFromCursor_Distance_8, logic_uScriptAct_RaycastFromCursor_layerMask_8, logic_uScriptAct_RaycastFromCursor_include_8, logic_uScriptAct_RaycastFromCursor_showRay_8, out logic_uScriptAct_RaycastFromCursor_HitObject_8, out logic_uScriptAct_RaycastFromCursor_HitDistance_8, out logic_uScriptAct_RaycastFromCursor_HitLocation_8, out logic_uScriptAct_RaycastFromCursor_HitNormal_8);
         local_9_UnityEngine_Vector3 = logic_uScriptAct_RaycastFromCursor_HitLocation_8;
         
         //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
         bool test_0 = logic_uScriptAct_RaycastFromCursor_uScriptAct_RaycastFromCursor_8.Obstructed;
         
         if ( test_0 == true )
         {
            Relay_In_10();
         }
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript PlayerScript.uscript at Raycast From Mouse Cursor.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   void Relay_In_10()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("b19a0cfd-de5a-4fdb-bf30-b4b1b8c2dec7", "Get_Components__Vector3_", Relay_In_10)) return; 
         {
            {
               logic_uScriptAct_GetComponentsVector3_InputVector3_10 = local_9_UnityEngine_Vector3;
               
            }
            {
            }
            {
            }
            {
            }
         }
         logic_uScriptAct_GetComponentsVector3_uScriptAct_GetComponentsVector3_10.In(logic_uScriptAct_GetComponentsVector3_InputVector3_10, out logic_uScriptAct_GetComponentsVector3_X_10, out logic_uScriptAct_GetComponentsVector3_Y_10, out logic_uScriptAct_GetComponentsVector3_Z_10);
         local_11_System_Single = logic_uScriptAct_GetComponentsVector3_X_10;
         local_12_System_Single = logic_uScriptAct_GetComponentsVector3_Z_10;
         
         //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
         bool test_0 = logic_uScriptAct_GetComponentsVector3_uScriptAct_GetComponentsVector3_10.Out;
         
         if ( test_0 == true )
         {
            Relay_In_13();
         }
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript PlayerScript.uscript at Get Components (Vector3).  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   void Relay_In_13()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("6958909c-4cbc-434e-b261-a6eb75b6ddb1", "Set_Components__Vector3_", Relay_In_13)) return; 
         {
            {
               logic_uScriptAct_SetComponentsVector3_X_13 = local_11_System_Single;
               
            }
            {
            }
            {
               logic_uScriptAct_SetComponentsVector3_Z_13 = local_12_System_Single;
               
            }
            {
            }
         }
         logic_uScriptAct_SetComponentsVector3_uScriptAct_SetComponentsVector3_13.In(logic_uScriptAct_SetComponentsVector3_X_13, logic_uScriptAct_SetComponentsVector3_Y_13, logic_uScriptAct_SetComponentsVector3_Z_13, out logic_uScriptAct_SetComponentsVector3_OutputVector3_13);
         local_14_UnityEngine_Vector3 = logic_uScriptAct_SetComponentsVector3_OutputVector3_13;
         
         //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
         bool test_0 = logic_uScriptAct_SetComponentsVector3_uScriptAct_SetComponentsVector3_13.Out;
         
         if ( test_0 == true )
         {
            Relay_In_15();
         }
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript PlayerScript.uscript at Set Components (Vector3).  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   void Relay_Finished_15()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("61b0764c-bf2a-4a2b-8b70-fe2ab4b311f9", "Look_At", Relay_Finished_15)) return; 
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript PlayerScript.uscript at Look At.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   void Relay_In_15()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("61b0764c-bf2a-4a2b-8b70-fe2ab4b311f9", "Look_At", Relay_In_15)) return; 
         {
            {
               int index = 0;
               {
                  //if our game object reference was changed then we need to reset event listeners
                  if ( local_16_UnityEngine_GameObject_previous != local_16_UnityEngine_GameObject || false == m_RegisteredForEvents )
                  {
                     //tear down old listeners
                     
                     local_16_UnityEngine_GameObject_previous = local_16_UnityEngine_GameObject;
                     
                     //setup new listeners
                  }
               }
               if ( logic_uScriptAct_LookAt_Target_15.Length <= index)
               {
                  System.Array.Resize(ref logic_uScriptAct_LookAt_Target_15, index + 1);
               }
               logic_uScriptAct_LookAt_Target_15[ index++ ] = local_16_UnityEngine_GameObject;
               
            }
            {
               logic_uScriptAct_LookAt_Focus_15 = local_14_UnityEngine_Vector3;
               
            }
            {
            }
            {
            }
         }
         logic_uScriptAct_LookAt_uScriptAct_LookAt_15.In(logic_uScriptAct_LookAt_Target_15, logic_uScriptAct_LookAt_Focus_15, logic_uScriptAct_LookAt_time_15, logic_uScriptAct_LookAt_lockAxis_15);
         
         //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
         
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript PlayerScript.uscript at Look At.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   void Relay_In_17()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("cd229adf-c1c4-416f-8b6e-a2043e545e6a", "Input_Events_Filter", Relay_In_17)) return; 
         {
            {
            }
         }
         logic_uScriptAct_OnInputEventFilter_uScriptAct_OnInputEventFilter_17.In(logic_uScriptAct_OnInputEventFilter_KeyCode_17);
         
         //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
         bool test_0 = logic_uScriptAct_OnInputEventFilter_uScriptAct_OnInputEventFilter_17.KeyDown;
         bool test_1 = logic_uScriptAct_OnInputEventFilter_uScriptAct_OnInputEventFilter_17.KeyUp;
         
         if ( test_0 == true )
         {
            Relay_True_20();
         }
         if ( test_1 == true )
         {
            Relay_False_23();
         }
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript PlayerScript.uscript at Input Events Filter.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   void Relay_FinishedSpawning_18()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("7b604b5e-3f6b-469e-b928-c4aebbc84db8", "Spawn_Prefab", Relay_FinishedSpawning_18)) return; 
         Relay_In_25();
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript PlayerScript.uscript at Spawn Prefab.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   void Relay_In_18()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("7b604b5e-3f6b-469e-b928-c4aebbc84db8", "Spawn_Prefab", Relay_In_18)) return; 
         {
            {
            }
            {
            }
            {
            }
            {
            }
            {
            }
            {
            }
            {
            }
         }
         logic_uScriptAct_SpawnPrefab_uScriptAct_SpawnPrefab_18.In(logic_uScriptAct_SpawnPrefab_PrefabName_18, logic_uScriptAct_SpawnPrefab_ResourcePath_18, logic_uScriptAct_SpawnPrefab_SpawnPoint_18, logic_uScriptAct_SpawnPrefab_SpawnedName_18, logic_uScriptAct_SpawnPrefab_LocationOffset_18, out logic_uScriptAct_SpawnPrefab_SpawnedGameObject_18, out logic_uScriptAct_SpawnPrefab_SpawnedInstancedID_18);
         
         //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
         
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript PlayerScript.uscript at Spawn Prefab.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   void Relay_True_20()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("8fb805e3-0393-4517-8746-acfce993d754", "Set_Bool", Relay_True_20)) return; 
         {
            {
            }
         }
         logic_uScriptAct_SetBool_uScriptAct_SetBool_20.True(out logic_uScriptAct_SetBool_Target_20);
         local_Fire_button_held_down__System_Boolean = logic_uScriptAct_SetBool_Target_20;
         
         //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
         bool test_0 = logic_uScriptAct_SetBool_uScriptAct_SetBool_20.Out;
         
         if ( test_0 == true )
         {
            Relay_In_24();
         }
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript PlayerScript.uscript at Set Bool.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   void Relay_False_20()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("8fb805e3-0393-4517-8746-acfce993d754", "Set_Bool", Relay_False_20)) return; 
         {
            {
            }
         }
         logic_uScriptAct_SetBool_uScriptAct_SetBool_20.False(out logic_uScriptAct_SetBool_Target_20);
         local_Fire_button_held_down__System_Boolean = logic_uScriptAct_SetBool_Target_20;
         
         //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
         bool test_0 = logic_uScriptAct_SetBool_uScriptAct_SetBool_20.Out;
         
         if ( test_0 == true )
         {
            Relay_In_24();
         }
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript PlayerScript.uscript at Set Bool.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   void Relay_True_23()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("c71af7a4-9c34-4e14-8a80-1b97bfdf37b0", "Set_Bool", Relay_True_23)) return; 
         {
            {
            }
         }
         logic_uScriptAct_SetBool_uScriptAct_SetBool_23.True(out logic_uScriptAct_SetBool_Target_23);
         local_Fire_button_held_down__System_Boolean = logic_uScriptAct_SetBool_Target_23;
         
         //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
         
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript PlayerScript.uscript at Set Bool.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   void Relay_False_23()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("c71af7a4-9c34-4e14-8a80-1b97bfdf37b0", "Set_Bool", Relay_False_23)) return; 
         {
            {
            }
         }
         logic_uScriptAct_SetBool_uScriptAct_SetBool_23.False(out logic_uScriptAct_SetBool_Target_23);
         local_Fire_button_held_down__System_Boolean = logic_uScriptAct_SetBool_Target_23;
         
         //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
         
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript PlayerScript.uscript at Set Bool.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   void Relay_In_24()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("27dc3955-08a5-4e5d-81fa-e5427aae4a34", "Compare_Bool", Relay_In_24)) return; 
         {
            {
               logic_uScriptCon_CompareBool_Bool_24 = local_Fire_button_held_down__System_Boolean;
               
            }
         }
         logic_uScriptCon_CompareBool_uScriptCon_CompareBool_24.In(logic_uScriptCon_CompareBool_Bool_24);
         
         //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
         bool test_0 = logic_uScriptCon_CompareBool_uScriptCon_CompareBool_24.True;
         
         if ( test_0 == true )
         {
            Relay_In_18();
            Relay_TurnOn_29();
         }
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript PlayerScript.uscript at Compare Bool.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   void Relay_In_25()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("d473a6a4-27b3-49a5-a5c4-948e33e3bdb5", "Delay", Relay_In_25)) return; 
         {
            {
               logic_uScriptAct_Delay_Duration_25 = local_FireRate_System_Single;
               
            }
            {
            }
         }
         logic_uScriptAct_Delay_uScriptAct_Delay_25.In(logic_uScriptAct_Delay_Duration_25, logic_uScriptAct_Delay_SingleFrame_25);
         logic_uScriptAct_Delay_DrivenDelay_25 = true;
         
         //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
         bool test_0 = logic_uScriptAct_Delay_uScriptAct_Delay_25.AfterDelay;
         
         if ( test_0 == true )
         {
            Relay_In_24();
         }
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript PlayerScript.uscript at Delay.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   void Relay_Stop_25()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("d473a6a4-27b3-49a5-a5c4-948e33e3bdb5", "Delay", Relay_Stop_25)) return; 
         {
            {
               logic_uScriptAct_Delay_Duration_25 = local_FireRate_System_Single;
               
            }
            {
            }
         }
         logic_uScriptAct_Delay_uScriptAct_Delay_25.Stop(logic_uScriptAct_Delay_Duration_25, logic_uScriptAct_Delay_SingleFrame_25);
         logic_uScriptAct_Delay_DrivenDelay_25 = true;
         
         //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
         bool test_0 = logic_uScriptAct_Delay_uScriptAct_Delay_25.AfterDelay;
         
         if ( test_0 == true )
         {
            Relay_In_24();
         }
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript PlayerScript.uscript at Delay.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   void Relay_DrivenDelay_25( )
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         {
            {
               logic_uScriptAct_Delay_Duration_25 = local_FireRate_System_Single;
               
            }
            {
            }
         }
         logic_uScriptAct_Delay_DrivenDelay_25 = logic_uScriptAct_Delay_uScriptAct_Delay_25.DrivenDelay();
         if ( true == logic_uScriptAct_Delay_DrivenDelay_25 )
         {
            if ( logic_uScriptAct_Delay_uScriptAct_Delay_25.AfterDelay == true )
            {
               Relay_In_24();
            }
         }
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript PlayerScript.uscript at Delay.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   void Relay_uScriptStart_28()
   {
      if (true == CheckDebugBreak("cde74580-5899-401f-a688-408d5b3e30b4", "uScript_Events", Relay_uScriptStart_28)) return; 
      Relay_TurnOff_29();
   }
   
   void Relay_uScriptLateStart_28()
   {
      if (true == CheckDebugBreak("cde74580-5899-401f-a688-408d5b3e30b4", "uScript_Events", Relay_uScriptLateStart_28)) return; 
   }
   
   void Relay_OnOut_29()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("076aa6c1-bdeb-4f2b-811e-bac2cc40c72c", "Toggle", Relay_OnOut_29)) return; 
         Relay_In_31();
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript PlayerScript.uscript at Toggle.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   void Relay_OffOut_29()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("076aa6c1-bdeb-4f2b-811e-bac2cc40c72c", "Toggle", Relay_OffOut_29)) return; 
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript PlayerScript.uscript at Toggle.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   void Relay_ToggleOut_29()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("076aa6c1-bdeb-4f2b-811e-bac2cc40c72c", "Toggle", Relay_ToggleOut_29)) return; 
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript PlayerScript.uscript at Toggle.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   void Relay_TurnOn_29()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("076aa6c1-bdeb-4f2b-811e-bac2cc40c72c", "Toggle", Relay_TurnOn_29)) return; 
         {
            {
               int index = 0;
               {
                  //if our game object reference was changed then we need to reset event listeners
                  if ( local_30_UnityEngine_GameObject_previous != local_30_UnityEngine_GameObject || false == m_RegisteredForEvents )
                  {
                     //tear down old listeners
                     
                     local_30_UnityEngine_GameObject_previous = local_30_UnityEngine_GameObject;
                     
                     //setup new listeners
                  }
               }
               if ( logic_uScriptAct_Toggle_Target_29.Length <= index)
               {
                  System.Array.Resize(ref logic_uScriptAct_Toggle_Target_29, index + 1);
               }
               logic_uScriptAct_Toggle_Target_29[ index++ ] = local_30_UnityEngine_GameObject;
               
            }
            {
            }
         }
         logic_uScriptAct_Toggle_uScriptAct_Toggle_29.TurnOn(logic_uScriptAct_Toggle_Target_29, logic_uScriptAct_Toggle_IgnoreChildren_29);
         
         //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
         
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript PlayerScript.uscript at Toggle.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   void Relay_TurnOff_29()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("076aa6c1-bdeb-4f2b-811e-bac2cc40c72c", "Toggle", Relay_TurnOff_29)) return; 
         {
            {
               int index = 0;
               {
                  //if our game object reference was changed then we need to reset event listeners
                  if ( local_30_UnityEngine_GameObject_previous != local_30_UnityEngine_GameObject || false == m_RegisteredForEvents )
                  {
                     //tear down old listeners
                     
                     local_30_UnityEngine_GameObject_previous = local_30_UnityEngine_GameObject;
                     
                     //setup new listeners
                  }
               }
               if ( logic_uScriptAct_Toggle_Target_29.Length <= index)
               {
                  System.Array.Resize(ref logic_uScriptAct_Toggle_Target_29, index + 1);
               }
               logic_uScriptAct_Toggle_Target_29[ index++ ] = local_30_UnityEngine_GameObject;
               
            }
            {
            }
         }
         logic_uScriptAct_Toggle_uScriptAct_Toggle_29.TurnOff(logic_uScriptAct_Toggle_Target_29, logic_uScriptAct_Toggle_IgnoreChildren_29);
         
         //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
         
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript PlayerScript.uscript at Toggle.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   void Relay_Toggle_29()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("076aa6c1-bdeb-4f2b-811e-bac2cc40c72c", "Toggle", Relay_Toggle_29)) return; 
         {
            {
               int index = 0;
               {
                  //if our game object reference was changed then we need to reset event listeners
                  if ( local_30_UnityEngine_GameObject_previous != local_30_UnityEngine_GameObject || false == m_RegisteredForEvents )
                  {
                     //tear down old listeners
                     
                     local_30_UnityEngine_GameObject_previous = local_30_UnityEngine_GameObject;
                     
                     //setup new listeners
                  }
               }
               if ( logic_uScriptAct_Toggle_Target_29.Length <= index)
               {
                  System.Array.Resize(ref logic_uScriptAct_Toggle_Target_29, index + 1);
               }
               logic_uScriptAct_Toggle_Target_29[ index++ ] = local_30_UnityEngine_GameObject;
               
            }
            {
            }
         }
         logic_uScriptAct_Toggle_uScriptAct_Toggle_29.Toggle(logic_uScriptAct_Toggle_Target_29, logic_uScriptAct_Toggle_IgnoreChildren_29);
         
         //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
         
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript PlayerScript.uscript at Toggle.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   void Relay_In_31()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("1c1ddfbf-b381-4156-ba00-b06c4210735e", "Delay", Relay_In_31)) return; 
         {
            {
            }
            {
            }
         }
         logic_uScriptAct_Delay_uScriptAct_Delay_31.In(logic_uScriptAct_Delay_Duration_31, logic_uScriptAct_Delay_SingleFrame_31);
         logic_uScriptAct_Delay_DrivenDelay_31 = true;
         
         //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
         bool test_0 = logic_uScriptAct_Delay_uScriptAct_Delay_31.AfterDelay;
         
         if ( test_0 == true )
         {
            Relay_TurnOff_29();
         }
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript PlayerScript.uscript at Delay.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   void Relay_Stop_31()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("1c1ddfbf-b381-4156-ba00-b06c4210735e", "Delay", Relay_Stop_31)) return; 
         {
            {
            }
            {
            }
         }
         logic_uScriptAct_Delay_uScriptAct_Delay_31.Stop(logic_uScriptAct_Delay_Duration_31, logic_uScriptAct_Delay_SingleFrame_31);
         logic_uScriptAct_Delay_DrivenDelay_31 = true;
         
         //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
         bool test_0 = logic_uScriptAct_Delay_uScriptAct_Delay_31.AfterDelay;
         
         if ( test_0 == true )
         {
            Relay_TurnOff_29();
         }
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript PlayerScript.uscript at Delay.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   void Relay_DrivenDelay_31( )
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         {
            {
            }
            {
            }
         }
         logic_uScriptAct_Delay_DrivenDelay_31 = logic_uScriptAct_Delay_uScriptAct_Delay_31.DrivenDelay();
         if ( true == logic_uScriptAct_Delay_DrivenDelay_31 )
         {
            if ( logic_uScriptAct_Delay_uScriptAct_Delay_31.AfterDelay == true )
            {
               Relay_TurnOff_29();
            }
         }
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript PlayerScript.uscript at Delay.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   private void UpdateEditorValues( )
   {
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "PlayerScript.uscript:9", local_9_UnityEngine_Vector3);
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "44eb022d-1728-4508-9f1d-12dea41e70c9", local_9_UnityEngine_Vector3);
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "PlayerScript.uscript:11", local_11_System_Single);
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "071717e9-4828-45ec-a6cc-068db06e2ccf", local_11_System_Single);
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "PlayerScript.uscript:12", local_12_System_Single);
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "0e03fa95-84f4-4806-b578-bc62db55c905", local_12_System_Single);
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "PlayerScript.uscript:14", local_14_UnityEngine_Vector3);
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "f26b192e-e50d-496d-a2e4-aeb861844a15", local_14_UnityEngine_Vector3);
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "PlayerScript.uscript:16", local_16_UnityEngine_GameObject);
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "13f64ae2-3f84-4928-bfbd-5dbf0684c80e", local_16_UnityEngine_GameObject);
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "PlayerScript.uscript:FireRate", local_FireRate_System_Single);
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "4b0c2bf2-07c6-4c53-9915-761ba2f5d910", local_FireRate_System_Single);
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "PlayerScript.uscript:Fire button held down?", local_Fire_button_held_down__System_Boolean);
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "4d36099a-f8d1-468a-ab6e-6a19de5e579d", local_Fire_button_held_down__System_Boolean);
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "PlayerScript.uscript:30", local_30_UnityEngine_GameObject);
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "9a2ef58f-fd73-467c-948e-2025756055fd", local_30_UnityEngine_GameObject);
   }
   bool CheckDebugBreak(string guid, string name, ContinueExecution method)
   {
      if (true == m_Breakpoint) return true;
      
      if (true == uScript_MasterComponent.FindBreakpoint(guid))
      {
         if (uScript_MasterComponent.LatestMasterComponent.CurrentBreakpoint == guid)
         {
            uScript_MasterComponent.LatestMasterComponent.CurrentBreakpoint = "";
         }
         else
         {
            uScript_MasterComponent.LatestMasterComponent.CurrentBreakpoint = guid;
            UpdateEditorValues( );
            UnityEngine.Debug.Log("uScript BREAK Node:" + name + " ((Time: " + Time.time + "");
            UnityEngine.Debug.Break();
            #if (!UNITY_FLASH)
            m_ContinueExecution = new ContinueExecution(method);
            #endif
            m_Breakpoint = true;
            return true;
         }
      }
      return false;
   }
}
