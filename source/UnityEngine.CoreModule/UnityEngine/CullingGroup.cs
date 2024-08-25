using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine
{
	[NativeHeader("Runtime/Export/Camera/CullingGroup.bindings.h")]
	[global::Cpp2ILInjected.Token(Token = "0x2000079")]
	[StructLayout(0)]
	public class CullingGroup
	{
		[RequiredByNativeCode]
		[global::Cpp2ILInjected.Token(Token = "0x60001F2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F75E64", Offset = "0x1F75E64", Length = "0x78")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private static void SendEvents(CullingGroup cullingGroup, IntPtr eventsPtr, int count)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x40002EA")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		internal IntPtr m_Ptr;

		[global::Cpp2ILInjected.Token(Token = "0x40002EB")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private CullingGroup.StateChanged m_OnStateChanged;

		[global::Cpp2ILInjected.Token(Token = "0x200007A")]
		public delegate void StateChanged(CullingGroupEvent sphere);
	}
}
