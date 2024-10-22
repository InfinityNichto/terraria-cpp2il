﻿using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine.Experimental.Rendering
{
	[NativeHeader("Runtime/Camera/ScriptableRuntimeReflectionSystem.h")]
	[RequiredByNativeCode]
	[global::Cpp2ILInjected.Token(Token = "0x200013F")]
	public static class ScriptableRuntimeReflectionSystemSettings
	{
		[global::Cpp2ILInjected.Token(Token = "0x1700014B")]
		private static IScriptableRuntimeReflectionSystem Internal_ScriptableRuntimeReflectionSystemSettings_system
		{
			[RequiredByNativeCode]
			[global::Cpp2ILInjected.Token(Token = "0x600061B")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F8F468", Offset = "0x1F8F468", Length = "0x138")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
			set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x1700014C")]
		private static ScriptableRuntimeReflectionSystemWrapper Internal_ScriptableRuntimeReflectionSystemSettings_instance
		{
			[RequiredByNativeCode]
			[global::Cpp2ILInjected.Token(Token = "0x600061C")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F8F5A0", Offset = "0x1F8F5A0", Length = "0x58")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		[StaticAccessor("ScriptableRuntimeReflectionSystem", StaticAccessorType.DoubleColon)]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterSceneLoad)]
		[global::Cpp2ILInjected.Token(Token = "0x600061D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F8F5F8", Offset = "0x1F8F5F8", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		private static extern void ScriptingDirtyReflectionSystemInstance();

		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x600061E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F8F620", Offset = "0x1F8F620", Length = "0x70")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		static ScriptableRuntimeReflectionSystemSettings()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x400060D")]
		private static ScriptableRuntimeReflectionSystemWrapper s_Instance;
	}
}
