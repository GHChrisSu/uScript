// uScript Action Node
// (C) 2011 Detox Studios LLC

using UnityEngine;
using System.Collections;

[NodePath("Actions/Variables/Vector4")]

[NodeCopyright("Copyright 2011 by Detox Studios LLC")]
[NodeToolTip("Randomly sets the value of a Vector4 variable.")]
[NodeAuthor("Detox Studios LLC", "http://www.detoxstudios.com")]
[NodeHelp("http://docs.uscript.net/#3-Working_With_uScript/3.4-Nodes.htm")]

[FriendlyName("Set Random Vector4", "Randomly sets the value of a Vector4 variable.")]
public class uScriptAct_SetRandomVector4 : uScriptLogic
{
   public bool Out { get { return true; } }

   public void In(
      [FriendlyName("Min X", "Minimum allowable float value for X.")]
      [DefaultValue(0f), SocketState(false, false)]
      float MinX,

      [FriendlyName("Max X", "Maximum allowable float value for X.")]
      [DefaultValue(1f), SocketState(false, false)]
      float MaxX,

      [FriendlyName("Min Y", "Minimum allowable float value for Y.")]
      [DefaultValue(0f), SocketState(false, false)]
      float MinY,

      [FriendlyName("Max Y", "Maximum allowable float value for Y.")]
      [DefaultValue(1f), SocketState(false, false)]
      float MaxY,

      [FriendlyName("Min Z", "Minimum allowable float value for Z.")]
      [DefaultValue(0f), SocketState(false, false)]
      float MinZ,

      [FriendlyName("Max Z", "Maximum allowable float value for Z.")]
      [DefaultValue(1f), SocketState(false, false)]
      float MaxZ,

      [FriendlyName("Min W", "Minimum allowable float value for W.")]
      [DefaultValue(0f), SocketState(false, false)]
      float MinW,

      [FriendlyName("Max W", "Maximum allowable float value for W.")]
      [DefaultValue(1f), SocketState(false, false)]
      float MaxW,
      
      [FriendlyName("Target Vector4", "The Vector4 variable that gets set.")]
      out Vector4 TargetVector4
      )
   {
      float finalX = Random.Range(MinX, MaxX);
      float finalY = Random.Range(MinY, MaxY);
      float finalZ = Random.Range(MinZ, MaxZ);
      float finalW = Random.Range(MinW, MaxW);

      TargetVector4 = new Vector4(finalX, finalY, finalZ, finalW);
   }
}
