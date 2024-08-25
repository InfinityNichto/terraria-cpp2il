using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine.Scripting;

namespace UnityEngine.Experimental.Rendering
{
	[RequiredByNativeCode]
	[global::Cpp2ILInjected.Token(Token = "0x2000141")]
	internal class ScriptableRuntimeReflectionSystemWrapper
	{
		[global::Cpp2ILInjected.Token(Token = "0x1700014D")]
		internal IScriptableRuntimeReflectionSystem implementation
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6000620")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F8F698", Offset = "0x1F8F698", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6000621")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F8F6A0", Offset = "0x1F8F6A0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		[RequiredByNativeCode]
		[global::Cpp2ILInjected.Token(Token = "0x6000622")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F8F6A8", Offset = "0x1F8F6A8", Length = "0xB4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private void Internal_ScriptableRuntimeReflectionSystemWrapper_TickRealtimeProbes(out bool result)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000623")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F8F690", Offset = "0x1F8F690", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public ScriptableRuntimeReflectionSystemWrapper()
		{
			throw null;
		}

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[global::Cpp2ILInjected.Token(Token = "0x400060E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private IScriptableRuntimeReflectionSystem <implementation>k__BackingField;
	}
}
