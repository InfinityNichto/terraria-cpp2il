using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine.Bindings;
using UnityEngine.Playables;
using UnityEngine.Scripting;

namespace UnityEngine.Audio
{
	// Token: 0x0200000C RID: 12
	[NativeHeader("Runtime/Director/Core/HPlayable.h")]
	[NativeHeader("Modules/Audio/Public/Director/AudioMixerPlayable.h")]
	[NativeHeader("Modules/Audio/Public/ScriptBindings/AudioMixerPlayable.bindings.h")]
	[RequiredByNativeCode]
	[StaticAccessor("AudioMixerPlayableBindings", StaticAccessorType.DoubleColon)]
	[global::Cpp2ILInjected.Token(Token = "0x2000010")]
	public struct AudioMixerPlayable : IEquatable<AudioMixerPlayable>
	{
		// Token: 0x0600001C RID: 28 RVA: 0x00002071 File Offset: 0x00000271
		[global::Cpp2ILInjected.Token(Token = "0x6000029")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F69B28", Offset = "0x1F69B28", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public PlayableHandle GetHandle()
		{
			throw null;
		}

		// Token: 0x0600001D RID: 29 RVA: 0x00002074 File Offset: 0x00000274
		[global::Cpp2ILInjected.Token(Token = "0x600002A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F69B34", Offset = "0x1F69B34", Length = "0x78")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlayableHandle), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(PlayableHandle),
			typeof(PlayableHandle)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public bool Equals(AudioMixerPlayable other)
		{
			throw null;
		}

		// Token: 0x04000008 RID: 8
		[global::Cpp2ILInjected.Token(Token = "0x400000B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private PlayableHandle m_Handle;
	}
}
