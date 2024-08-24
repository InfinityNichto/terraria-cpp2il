using System;
using System.Threading;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Terraria;
using Terraria.Audio;

namespace Microsoft.Xna.Framework.Audio
{
	// Token: 0x020002F7 RID: 759
	[global::Cpp2ILInjected.Token(Token = "0x20003D0")]
	public class SoundEffectInstance
	{
		// Token: 0x1700034E RID: 846
		// (get) Token: 0x060018EB RID: 6379 RVA: 0x0002651F File Offset: 0x0002471F
		// (set) Token: 0x060018EC RID: 6380 RVA: 0x00026522 File Offset: 0x00024722
		[global::Cpp2ILInjected.Token(Token = "0x17000379")]
		public virtual bool IsLooped
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001A7A")]
			[global::Cpp2ILInjected.Address(RVA = "0xB49FD4", Offset = "0xB49FD4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6001A7B")]
			[global::Cpp2ILInjected.Address(RVA = "0xB49FDC", Offset = "0xB49FDC", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x1700034F RID: 847
		// (get) Token: 0x060018ED RID: 6381 RVA: 0x00026525 File Offset: 0x00024725
		// (set) Token: 0x060018EE RID: 6382 RVA: 0x00026528 File Offset: 0x00024728
		[global::Cpp2ILInjected.Token(Token = "0x1700037A")]
		public float Pan
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001A7C")]
			[global::Cpp2ILInjected.Address(RVA = "0xB49FE8", Offset = "0xB49FE8", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6001A7D")]
			[global::Cpp2ILInjected.Address(RVA = "0xB49FF0", Offset = "0xB49FF0", Length = "0x74")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ActiveSound), Member = "Update", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LegacySoundPlayer), Member = "PlaySound", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int),
				typeof(int),
				typeof(int),
				typeof(float),
				typeof(float)
			}, ReturnType = typeof(SoundEffectInstance))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 62)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SoundInstance), Member = "SetPan", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000350 RID: 848
		// (get) Token: 0x060018EF RID: 6383 RVA: 0x0002652B File Offset: 0x0002472B
		// (set) Token: 0x060018F0 RID: 6384 RVA: 0x0002652E File Offset: 0x0002472E
		[global::Cpp2ILInjected.Token(Token = "0x1700037B")]
		public float Pitch
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001A7E")]
			[global::Cpp2ILInjected.Address(RVA = "0xB4A064", Offset = "0xB4A064", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6001A7F")]
			[global::Cpp2ILInjected.Address(RVA = "0xB4A06C", Offset = "0xB4A06C", Length = "0xE4")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ActiveSound), Member = "Play", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ActiveSound), Member = "PlayLooped", MemberParameters = new object[] { typeof(ActiveSound.LoopedPlayCondition) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ActiveSound), Member = "Update", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LegacySoundPlayer), Member = "PlaySound", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int),
				typeof(int),
				typeof(int),
				typeof(float),
				typeof(float)
			}, ReturnType = typeof(SoundEffectInstance))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 48)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SoundInstance), Member = "SetPitch", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000351 RID: 849
		// (get) Token: 0x060018F1 RID: 6385 RVA: 0x00026531 File Offset: 0x00024731
		// (set) Token: 0x060018F2 RID: 6386 RVA: 0x00026534 File Offset: 0x00024734
		[global::Cpp2ILInjected.Token(Token = "0x1700037C")]
		public float Volume
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001A80")]
			[global::Cpp2ILInjected.Address(RVA = "0xB4A150", Offset = "0xB4A150", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6001A81")]
			[global::Cpp2ILInjected.Address(RVA = "0xB49C34", Offset = "0xB49C34", Length = "0x40")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Projectile), Member = "AI_190_NightsEdge", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Projectile), Member = "AI_188_LightsBane", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ActiveSound), Member = "Update", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LegacySoundPlayer), Member = "PlaySound", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int),
				typeof(int),
				typeof(int),
				typeof(float),
				typeof(float)
			}, ReturnType = typeof(SoundEffectInstance))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 67)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SoundInstance), Member = "SetVolume", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000352 RID: 850
		// (get) Token: 0x060018F3 RID: 6387 RVA: 0x00026537 File Offset: 0x00024737
		[global::Cpp2ILInjected.Token(Token = "0x1700037D")]
		public virtual SoundState State
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001A82")]
			[global::Cpp2ILInjected.Address(RVA = "0xB4A158", Offset = "0xB4A158", Length = "0x94")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTime), Member = "get_UtcNow", ReturnType = typeof(DateTime))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTime), Member = "op_LessThan", MemberParameters = new object[]
			{
				typeof(DateTime),
				typeof(DateTime)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x060018F4 RID: 6388 RVA: 0x0002653A File Offset: 0x0002473A
		[global::Cpp2ILInjected.Token(Token = "0x6001A83")]
		[global::Cpp2ILInjected.Address(RVA = "0xB49EB8", Offset = "0xB49EB8", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		internal SoundEffectInstance(SoundEffect effect)
		{
			throw null;
		}

		// Token: 0x060018F5 RID: 6389 RVA: 0x0002653D File Offset: 0x0002473D
		[global::Cpp2ILInjected.Token(Token = "0x6001A84")]
		[global::Cpp2ILInjected.Address(RVA = "0xB4A1EC", Offset = "0xB4A1EC", Length = "0x170")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Thread), Member = "get_CurrentThread", ReturnType = typeof(Thread))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MainThreadExecution.ExecutionSnippet), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MainThreadExecution), Member = "ExecuteOnMainThread", MemberParameters = new object[]
		{
			typeof(MainThreadExecution.ExecutionSnippet),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SoundDefinition), Member = "Play", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(bool)
		}, ReturnType = typeof(SoundInstance))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		public virtual void Play()
		{
			throw null;
		}

		// Token: 0x060018F6 RID: 6390 RVA: 0x00026540 File Offset: 0x00024740
		[global::Cpp2ILInjected.Token(Token = "0x6001A85")]
		[global::Cpp2ILInjected.Address(RVA = "0xB4A35C", Offset = "0xB4A35C", Length = "0x68")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private static void PlayOnMainThread(object data)
		{
			throw null;
		}

		// Token: 0x060018F7 RID: 6391 RVA: 0x00026543 File Offset: 0x00024743
		[global::Cpp2ILInjected.Token(Token = "0x6001A86")]
		[global::Cpp2ILInjected.Address(RVA = "0xB4A3C4", Offset = "0xB4A3C4", Length = "0x6C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private static void StopOnMainThread(object data)
		{
			throw null;
		}

		// Token: 0x060018F8 RID: 6392 RVA: 0x00026546 File Offset: 0x00024746
		[global::Cpp2ILInjected.Token(Token = "0x6001A87")]
		[global::Cpp2ILInjected.Address(RVA = "0xB4A430", Offset = "0xB4A430", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LegacySoundPlayer), Member = "PlaySound", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(SoundEffectInstance))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SoundInstance), Member = "Restart", ReturnType = typeof(void))]
		public void Restart()
		{
			throw null;
		}

		// Token: 0x060018F9 RID: 6393 RVA: 0x00026549 File Offset: 0x00024749
		[global::Cpp2ILInjected.Token(Token = "0x6001A88")]
		[global::Cpp2ILInjected.Address(RVA = "0xB4A444", Offset = "0xB4A444", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public virtual void Pause()
		{
			throw null;
		}

		// Token: 0x060018FA RID: 6394 RVA: 0x0002654C File Offset: 0x0002474C
		[global::Cpp2ILInjected.Token(Token = "0x6001A89")]
		[global::Cpp2ILInjected.Address(RVA = "0xB4A448", Offset = "0xB4A448", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public virtual void Resume()
		{
			throw null;
		}

		// Token: 0x060018FB RID: 6395 RVA: 0x0002654F File Offset: 0x0002474F
		[global::Cpp2ILInjected.Token(Token = "0x6001A8A")]
		[global::Cpp2ILInjected.Address(RVA = "0xB4A44C", Offset = "0xB4A44C", Length = "0xF0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Thread), Member = "get_CurrentThread", ReturnType = typeof(Thread))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MainThreadExecution.ExecutionSnippet), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MainThreadExecution), Member = "ExecuteOnMainThread", MemberParameters = new object[]
		{
			typeof(MainThreadExecution.ExecutionSnippet),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SoundInstance), Member = "Stop", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public virtual void Stop(bool immediate = false)
		{
			throw null;
		}

		// Token: 0x17000353 RID: 851
		// (get) Token: 0x060018FC RID: 6396 RVA: 0x00026552 File Offset: 0x00024752
		// (set) Token: 0x060018FD RID: 6397 RVA: 0x00026555 File Offset: 0x00024755
		[global::Cpp2ILInjected.Token(Token = "0x1700037E")]
		public float CurrentPosition
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001A8B")]
			[global::Cpp2ILInjected.Address(RVA = "0xB49BAC", Offset = "0xB49BAC", Length = "0x18")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SoundInstance), Member = "get_CurrentPosition", ReturnType = typeof(float))]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6001A8C")]
			[global::Cpp2ILInjected.Address(RVA = "0xB49C04", Offset = "0xB49C04", Length = "0x14")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SoundInstance), Member = "set_CurrentPosition", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
			set
			{
				throw null;
			}
		}

		// Token: 0x060018FE RID: 6398 RVA: 0x00026558 File Offset: 0x00024758
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x6001A8D")]
		[global::Cpp2ILInjected.Address(RVA = "0xB4A53C", Offset = "0xB4A53C", Length = "0x50")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		static SoundEffectInstance()
		{
			throw null;
		}

		// Token: 0x04002171 RID: 8561
		[global::Cpp2ILInjected.Token(Token = "0x40027DF")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		internal SoundEffect _effect;

		// Token: 0x04002172 RID: 8562
		[global::Cpp2ILInjected.Token(Token = "0x40027E0")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private bool _loop;

		// Token: 0x04002173 RID: 8563
		[global::Cpp2ILInjected.Token(Token = "0x40027E1")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C")]
		private float _pan;

		// Token: 0x04002174 RID: 8564
		[global::Cpp2ILInjected.Token(Token = "0x40027E2")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private float _volume;

		// Token: 0x04002175 RID: 8565
		[global::Cpp2ILInjected.Token(Token = "0x40027E3")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x24")]
		private float _pitch;

		// Token: 0x04002176 RID: 8566
		[global::Cpp2ILInjected.Token(Token = "0x40027E4")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private SoundInstance _playingInstance;

		// Token: 0x04002177 RID: 8567
		[global::Cpp2ILInjected.Token(Token = "0x40027E5")]
		public static float pitchOffset;

		// Token: 0x04002178 RID: 8568
		[global::Cpp2ILInjected.Token(Token = "0x40027E6")]
		public static float pitchScale;
	}
}
