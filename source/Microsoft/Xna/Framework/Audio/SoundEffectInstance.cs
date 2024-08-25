using System;
using System.Threading;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Terraria;
using Terraria.Audio;

namespace Microsoft.Xna.Framework.Audio
{
	[global::Cpp2ILInjected.Token(Token = "0x20003D0")]
	public class SoundEffectInstance
	{
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

		[global::Cpp2ILInjected.Token(Token = "0x6001A83")]
		[global::Cpp2ILInjected.Address(RVA = "0xB49EB8", Offset = "0xB49EB8", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		internal SoundEffectInstance(SoundEffect effect)
		{
			throw null;
		}

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

		[global::Cpp2ILInjected.Token(Token = "0x6001A85")]
		[global::Cpp2ILInjected.Address(RVA = "0xB4A35C", Offset = "0xB4A35C", Length = "0x68")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private static void PlayOnMainThread(object data)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001A86")]
		[global::Cpp2ILInjected.Address(RVA = "0xB4A3C4", Offset = "0xB4A3C4", Length = "0x6C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private static void StopOnMainThread(object data)
		{
			throw null;
		}

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

		[global::Cpp2ILInjected.Token(Token = "0x6001A88")]
		[global::Cpp2ILInjected.Address(RVA = "0xB4A444", Offset = "0xB4A444", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public virtual void Pause()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001A89")]
		[global::Cpp2ILInjected.Address(RVA = "0xB4A448", Offset = "0xB4A448", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public virtual void Resume()
		{
			throw null;
		}

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

		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x6001A8D")]
		[global::Cpp2ILInjected.Address(RVA = "0xB4A53C", Offset = "0xB4A53C", Length = "0x50")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		static SoundEffectInstance()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x40027DF")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		internal SoundEffect _effect;

		[global::Cpp2ILInjected.Token(Token = "0x40027E0")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private bool _loop;

		[global::Cpp2ILInjected.Token(Token = "0x40027E1")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C")]
		private float _pan;

		[global::Cpp2ILInjected.Token(Token = "0x40027E2")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private float _volume;

		[global::Cpp2ILInjected.Token(Token = "0x40027E3")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x24")]
		private float _pitch;

		[global::Cpp2ILInjected.Token(Token = "0x40027E4")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private SoundInstance _playingInstance;

		[global::Cpp2ILInjected.Token(Token = "0x40027E5")]
		public static float pitchOffset;

		[global::Cpp2ILInjected.Token(Token = "0x40027E6")]
		public static float pitchScale;
	}
}
