using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine.Playables
{
	// Token: 0x0200012C RID: 300
	[RequiredByNativeCode]
	[global::Cpp2ILInjected.Token(Token = "0x2000153")]
	public struct PlayableOutput : IEquatable<PlayableOutput>
	{
		// Token: 0x06000618 RID: 1560 RVA: 0x00002DF4 File Offset: 0x00000FF4
		[VisibleToOtherModules]
		[global::Cpp2ILInjected.Token(Token = "0x6000650")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F90174", Offset = "0x1F90174", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		internal PlayableOutput(PlayableOutputHandle handle)
		{
			throw null;
		}

		// Token: 0x06000619 RID: 1561 RVA: 0x00002DF7 File Offset: 0x00000FF7
		[global::Cpp2ILInjected.Token(Token = "0x6000651")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F9017C", Offset = "0x1F9017C", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public PlayableOutputHandle GetHandle()
		{
			throw null;
		}

		// Token: 0x0600061A RID: 1562 RVA: 0x00002DFA File Offset: 0x00000FFA
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

		// Token: 0x0600061B RID: 1563 RVA: 0x00002DFD File Offset: 0x00000FFD
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

		// Token: 0x040005DB RID: 1499
		[global::Cpp2ILInjected.Token(Token = "0x4000631")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private PlayableOutputHandle m_Handle;

		// Token: 0x040005DC RID: 1500
		[global::Cpp2ILInjected.Token(Token = "0x4000632")]
		private static readonly PlayableOutput m_NullPlayableOutput;
	}
}
