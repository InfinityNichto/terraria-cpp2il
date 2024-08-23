using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine.Audio;
using UnityEngine.Bindings;
using UnityEngine.Internal;

namespace UnityEngine
{
	// Token: 0x02000006 RID: 6
	[StaticAccessor("AudioSourceBindings", StaticAccessorType.DoubleColon)]
	[RequireComponent(typeof(Transform))]
	[global::Cpp2ILInjected.Token(Token = "0x200000A")]
	public sealed class AudioSource : AudioBehaviour
	{
		// Token: 0x06000009 RID: 9
		[global::Cpp2ILInjected.Token(Token = "0x6000016")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F695FC", Offset = "0x1F695FC", Length = "0x4C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		private static extern void SetPitch([NotNull("ArgumentNullException")] AudioSource source, float pitch);

		// Token: 0x0600000A RID: 10
		[global::Cpp2ILInjected.Token(Token = "0x6000017")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F69648", Offset = "0x1F69648", Length = "0x44")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		private static extern void PlayHelper([NotNull("ArgumentNullException")] AudioSource source, ulong delay);

		// Token: 0x0600000B RID: 11
		[global::Cpp2ILInjected.Token(Token = "0x6000018")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F6968C", Offset = "0x1F6968C", Length = "0x44")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		private extern void Stop(bool stopOneShots);

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x0600000C RID: 12
		// (set) Token: 0x0600000D RID: 13
		[global::Cpp2ILInjected.Token(Token = "0x17000004")]
		public extern float volume
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000019")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F696D0", Offset = "0x1F696D0", Length = "0x3C")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "SoundInstance", Member = "StartFade", MemberParameters = new object[]
			{
				typeof(float),
				typeof(DateTime),
				typeof(DateTime)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			[MethodImpl(4096)]
			get;
			[global::Cpp2ILInjected.Token(Token = "0x600001A")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F6970C", Offset = "0x1F6970C", Length = "0x4C")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "SoundInstance", Member = ".ctor", MemberParameters = new object[]
			{
				"SoundChannel",
				"SoundDefinition",
				typeof(float),
				typeof(float),
				typeof(float),
				typeof(bool)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "SoundInstance", Member = "SetVolume", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			[MethodImpl(4096)]
			set;
		}

		// Token: 0x17000003 RID: 3
		// (set) Token: 0x0600000E RID: 14 RVA: 0x0000205F File Offset: 0x0000025F
		[global::Cpp2ILInjected.Token(Token = "0x17000005")]
		public float pitch
		{
			[global::Cpp2ILInjected.Token(Token = "0x600001B")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F69758", Offset = "0x1F69758", Length = "0x4C")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "SoundInstance", Member = ".ctor", MemberParameters = new object[]
			{
				"SoundChannel",
				"SoundDefinition",
				typeof(float),
				typeof(float),
				typeof(float),
				typeof(bool)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "SoundInstance", Member = "SetPitch", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x0600000F RID: 15
		// (set) Token: 0x06000010 RID: 16
		[NativeProperty("SecPosition")]
		[global::Cpp2ILInjected.Token(Token = "0x17000006")]
		public extern float time
		{
			[global::Cpp2ILInjected.Token(Token = "0x600001C")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F697A4", Offset = "0x1F697A4", Length = "0x3C")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "SoundInstance", Member = "get_CurrentPosition", ReturnType = typeof(float))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			[MethodImpl(4096)]
			get;
			[global::Cpp2ILInjected.Token(Token = "0x600001D")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F697E0", Offset = "0x1F697E0", Length = "0x4C")]
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
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			[MethodImpl(4096)]
			set;
		}

		// Token: 0x17000005 RID: 5
		// (set) Token: 0x06000011 RID: 17
		[NativeProperty("AudioClip")]
		[global::Cpp2ILInjected.Token(Token = "0x17000007")]
		public extern AudioClip clip
		{
			[global::Cpp2ILInjected.Token(Token = "0x600001E")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F6982C", Offset = "0x1F6982C", Length = "0x44")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "SoundInstance", Member = ".ctor", MemberParameters = new object[]
			{
				"SoundChannel",
				"SoundDefinition",
				typeof(float),
				typeof(float),
				typeof(float),
				typeof(bool)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			[MethodImpl(4096)]
			set;
		}

		// Token: 0x17000006 RID: 6
		// (set) Token: 0x06000012 RID: 18
		[global::Cpp2ILInjected.Token(Token = "0x17000008")]
		public extern AudioMixerGroup outputAudioMixerGroup
		{
			[global::Cpp2ILInjected.Token(Token = "0x600001F")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F69870", Offset = "0x1F69870", Length = "0x44")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "SoundInstance", Member = ".ctor", MemberParameters = new object[]
			{
				"SoundChannel",
				"SoundDefinition",
				typeof(float),
				typeof(float),
				typeof(float),
				typeof(bool)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			[MethodImpl(4096)]
			set;
		}

		// Token: 0x06000013 RID: 19 RVA: 0x00002062 File Offset: 0x00000262
		[ExcludeFromDocs]
		[global::Cpp2ILInjected.Token(Token = "0x6000020")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F698B4", Offset = "0x1F698B4", Length = "0x40")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "SoundInstance", Member = ".ctor", MemberParameters = new object[]
		{
			"SoundChannel",
			"SoundDefinition",
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public void Play()
		{
			throw null;
		}

		// Token: 0x06000014 RID: 20 RVA: 0x00002065 File Offset: 0x00000265
		[global::Cpp2ILInjected.Token(Token = "0x6000021")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F698F4", Offset = "0x1F698F4", Length = "0x40")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "SoundInstance", Member = "Stop", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public void Stop()
		{
			throw null;
		}

		// Token: 0x17000007 RID: 7
		// (set) Token: 0x06000015 RID: 21
		[global::Cpp2ILInjected.Token(Token = "0x17000009")]
		public extern bool loop
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000022")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F69934", Offset = "0x1F69934", Length = "0x44")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "SoundInstance", Member = ".ctor", MemberParameters = new object[]
			{
				"SoundChannel",
				"SoundDefinition",
				typeof(float),
				typeof(float),
				typeof(float),
				typeof(bool)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			[MethodImpl(4096)]
			set;
		}

		// Token: 0x17000008 RID: 8
		// (set) Token: 0x06000016 RID: 22
		[NativeProperty("StereoPan")]
		[global::Cpp2ILInjected.Token(Token = "0x1700000A")]
		public extern float panStereo
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000023")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F69978", Offset = "0x1F69978", Length = "0x4C")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "SoundInstance", Member = ".ctor", MemberParameters = new object[]
			{
				"SoundChannel",
				"SoundDefinition",
				typeof(float),
				typeof(float),
				typeof(float),
				typeof(bool)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "SoundInstance", Member = "SetPan", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			[MethodImpl(4096)]
			set;
		}

		// Token: 0x17000009 RID: 9
		// (set) Token: 0x06000017 RID: 23
		[global::Cpp2ILInjected.Token(Token = "0x1700000B")]
		public extern int priority
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000024")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F699C4", Offset = "0x1F699C4", Length = "0x44")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "SoundInstance", Member = ".ctor", MemberParameters = new object[]
			{
				"SoundChannel",
				"SoundDefinition",
				typeof(float),
				typeof(float),
				typeof(float),
				typeof(bool)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			[MethodImpl(4096)]
			set;
		}
	}
}
