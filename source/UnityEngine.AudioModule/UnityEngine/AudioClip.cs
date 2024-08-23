using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x02000003 RID: 3
	[StaticAccessor("AudioClipBindings", StaticAccessorType.DoubleColon)]
	[NativeHeader("Modules/Audio/Public/ScriptBindings/Audio.bindings.h")]
	[global::Cpp2ILInjected.Token(Token = "0x2000005")]
	public sealed class AudioClip : Object
	{
		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000006 RID: 6
		[NativeProperty("LengthSec")]
		[global::Cpp2ILInjected.Token(Token = "0x17000003")]
		public extern float length
		{
			[global::Cpp2ILInjected.Token(Token = "0x600000F")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F693C8", Offset = "0x1F693C8", Length = "0x3C")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "SoundDefinition", Member = "AddVariation", MemberParameters = new object[] { typeof(AudioClip) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "SoundInstance", Member = ".ctor", MemberParameters = new object[]
			{
				"SoundChannel",
				"SoundDefinition",
				typeof(float),
				typeof(float),
				typeof(float),
				typeof(bool)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "SoundInstance", Member = "Restart", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "SoundInstance", Member = "set_CurrentPosition", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			[MethodImpl(4096)]
			get;
		}

		// Token: 0x06000007 RID: 7 RVA: 0x00002059 File Offset: 0x00000259
		[RequiredByNativeCode]
		[global::Cpp2ILInjected.Token(Token = "0x6000010")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F69404", Offset = "0x1F69404", Length = "0x1C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		private void InvokePCMReaderCallback_Internal(float[] data)
		{
			throw null;
		}

		// Token: 0x06000008 RID: 8 RVA: 0x0000205C File Offset: 0x0000025C
		[RequiredByNativeCode]
		[global::Cpp2ILInjected.Token(Token = "0x6000011")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F69420", Offset = "0x1F69420", Length = "0x1C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		private void InvokePCMSetPositionCallback_Internal(int position)
		{
			throw null;
		}

		// Token: 0x04000004 RID: 4
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[global::Cpp2ILInjected.Token(Token = "0x4000007")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private AudioClip.PCMReaderCallback m_PCMReaderCallback;

		// Token: 0x04000005 RID: 5
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[global::Cpp2ILInjected.Token(Token = "0x4000008")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private AudioClip.PCMSetPositionCallback m_PCMSetPositionCallback;

		// Token: 0x0200001C RID: 28
		// (Invoke) Token: 0x06000036 RID: 54
		[global::Cpp2ILInjected.Token(Token = "0x2000006")]
		public delegate void PCMReaderCallback(float[] data);

		// Token: 0x0200001D RID: 29
		// (Invoke) Token: 0x06000038 RID: 56
		[global::Cpp2ILInjected.Token(Token = "0x2000007")]
		public delegate void PCMSetPositionCallback(int position);
	}
}
