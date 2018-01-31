// uScript Action Node
// (C) 2012 Detox Studios LLC

using UnityEngine;
using System.Collections;

[NodePath("Actions/Rendering/Render Settings")]

[NodeCopyright("Copyright 2011 by Detox Studios LLC")]
[NodeToolTip("Returns the renderer's current fog color.")]
[NodeAuthor("Detox Studios LLC", "http://www.detoxstudios.com")]
[NodeHelp("http://docs.uscript.net/#3-Working_With_uScript/3.4-Nodes.htm")]

[FriendlyName("Get Fog Color", "Returns the renderer's current fog color.")]
public class uScriptAct_RenderSettingsGetFogColor : uScriptLogic
{
   public bool Out { get { return true; } }

   public void In([FriendlyName("Color", "The current fog color.")] out UnityEngine.Color FogColor)
   {
      FogColor = RenderSettings.fogColor;
   }
}