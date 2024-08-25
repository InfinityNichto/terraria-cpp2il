using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine.Playables
{
	[RequiredByNativeCode]
	[global::Cpp2ILInjected.Token(Token = "0x2000153")]
	public struct PlayableOutput : IEquatable<PlayableOutput>
	{
		[VisibleToOtherModules]
		[global::Cpp2ILInjected.Token(Token = "0x6000650")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F90174", Offset = "0x1F90174", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		internal PlayableOutput(PlayableOutputHandle handle)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000651")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F9017C", Offset = "0x1F9017C", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public PlayableOutputHandle GetHandle()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000652")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F90188", Offset = "0x1F90188", Length = "0x74")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlayableOutputHandle), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(PlayableOutputHandle),
			typeof(PlayableOutputHandle)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public bool Equals(PlayableOutput other)
		{
			throw null;
		}

		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x6000653")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F901FC", Offset = "0x1F901FC", Length = "0x70")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlayableOutputHandle), Member = "get_Null", ReturnType = typeof(PlayableOutputHandle))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		static PlayableOutput()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x4000631")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private PlayableOutputHandle m_Handle;

		[global::Cpp2ILInjected.Token(Token = "0x4000632")]
		private static readonly PlayableOutput m_NullPlayableOutput;
	}
}
