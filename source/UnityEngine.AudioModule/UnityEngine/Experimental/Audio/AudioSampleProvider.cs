using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine.Experimental.Audio
{
	// Token: 0x0200000D RID: 13
	[StaticAccessor("AudioSampleProviderBindings", StaticAccessorType.DoubleColon)]
	[NativeType(Header = "Modules/Audio/Public/ScriptBindings/AudioSampleProvider.bindings.h")]
	[global::Cpp2ILInjected.Token(Token = "0x2000011")]
	public class AudioSampleProvider
	{
		// Token: 0x0600001E RID: 30 RVA: 0x00002077 File Offset: 0x00000277
		[RequiredByNativeCode]
		[global::Cpp2ILInjected.Token(Token = "0x600002B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F69BAC", Offset = "0x1F69BAC", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		private void InvokeSampleFramesAvailable(int sampleFrameCount)
		{
			throw null;
		}

		// Token: 0x0600001F RID: 31 RVA: 0x0000207A File Offset: 0x0000027A
		[RequiredByNativeCode]
		[global::Cpp2ILInjected.Token(Token = "0x600002C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F69BD4", Offset = "0x1F69BD4", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		private void InvokeSampleFramesOverflow(int droppedSampleFrameCount)
		{
			throw null;
		}

		// Token: 0x04000009 RID: 9
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[global::Cpp2ILInjected.Token(Token = "0x400000C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private AudioSampleProvider.SampleFramesHandler sampleFramesAvailable;

		// Token: 0x0400000A RID: 10
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x400000D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private AudioSampleProvider.SampleFramesHandler sampleFramesOverflow;

		// Token: 0x0200001E RID: 30
		// (Invoke) Token: 0x0600003A RID: 58
		[global::Cpp2ILInjected.Token(Token = "0x2000012")]
		public delegate void SampleFramesHandler(AudioSampleProvider provider, uint sampleFrameCount);
	}
}
