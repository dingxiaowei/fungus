﻿using UnityEngine;
using System.Collections;

namespace Fungus
{
	[CommandInfo("Scripting", 
	             "Debug Log", 
	             "Writes a log message to the debug console.")]
	[AddComponentMenu("")]
	public class DebugLog : Command 
	{
		public enum DebugLogType
		{
			Info,
			Warning,
			Error
		}

		public DebugLogType logType;

		public StringData logMessage;

		public override void OnEnter ()
		{
			FungusScript fungusScript = GetFungusScript();
			string message = fungusScript.SubstituteVariables(logMessage.Value);

			switch (logType)
			{
			case DebugLogType.Info:
				Debug.Log(message);
				break;
			case DebugLogType.Warning:
				Debug.LogWarning(message);
				break;
			case DebugLogType.Error:
				Debug.LogError(message);
				break;
			}

			Continue();
		}

		public override string GetSummary()
		{
			return logMessage.GetDescription();
		}

		public override Color GetButtonColor()
		{
			return new Color32(235, 191, 217, 255);
		}
	}

}