using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine.Bindings;
using UnityEngine.Playables;
using UnityEngine.Scripting;

namespace UnityEngine.Audio
{
	// Token: 0x0200000B RID: 11
	[NativeHeader("Modules/Audio/Public/Director/AudioClipPlayable.h")]
	[StaticAccessor("AudioClipPlayableBindings", StaticAccessorType.DoubleColon)]
	[NativeHeader("Runtime/Director/Core/HPlayable.h")]
	[RequiredByNativeCode]
	[NativeHeader("Modules/Audio/Public/ScriptBindings/AudioClipPlayable.bindings.h")]
	[global::Cpp2ILInjected.Token(Token = "0x200000F")]
	public struct AudioClipPlayable : IEquatable<AudioClipPlayable>
	{
		// Token: 0x0600001A RID: 26 RVA: 0x0000206B File Offset: 0x0000026B
		[global::Cpp2ILInjected.Token(Token = "0x6000027")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F69AA4", Offset = "0x1F69AA4", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public PlayableHandle GetHandle()
		{
			throw null;
		}

		// Token: 0x0600001B RID: 27 RVA: 0x0000206E File Offset: 0x0000026E
		[global::Cpp2ILInjected.Token(Token = "0x6000028")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F69AB0", Offset = "0x1F69AB0", Length = "0x78")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlayableHandle), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(PlayableHandle),
			typeof(PlayableHandle)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public bool Equals(AudioClipPlayable other)
		{
			throw null;
		}

		// Token: 0x04000007 RID: 7
		[global::Cpp2ILInjected.Token(Token = "0x400000A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private PlayableHandle m_Handle;
	}
}
