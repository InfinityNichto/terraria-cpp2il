using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Terraria.Audio;

namespace Microsoft.Xna.Framework.Audio
{
	// Token: 0x020002F4 RID: 756
	[global::Cpp2ILInjected.Token(Token = "0x20003CD")]
	public class Cue
	{
		// Token: 0x060018D8 RID: 6360 RVA: 0x000264E6 File Offset: 0x000246E6
		[global::Cpp2ILInjected.Token(Token = "0x6001A67")]
		[global::Cpp2ILInjected.Address(RVA = "0xB49A40", Offset = "0xB49A40", Length = "0x3C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SoundEffect), Member = "CreateInstance", ReturnType = typeof(SoundEffectInstance))]
		public Cue(SoundEffect musicSource)
		{
			throw null;
		}

		// Token: 0x17000349 RID: 841
		// (get) Token: 0x060018D9 RID: 6361 RVA: 0x000264E9 File Offset: 0x000246E9
		[global::Cpp2ILInjected.Token(Token = "0x17000374")]
		public bool IsPaused
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001A68")]
			[global::Cpp2ILInjected.Address(RVA = "0xB49AE8", Offset = "0xB49AE8", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700034A RID: 842
		// (get) Token: 0x060018DA RID: 6362 RVA: 0x000264EC File Offset: 0x000246EC
		[global::Cpp2ILInjected.Token(Token = "0x17000375")]
		public bool IsPlaying
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001A69")]
			[global::Cpp2ILInjected.Address(RVA = "0xB49AF0", Offset = "0xB49AF0", Length = "0x34")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LegacyAudioSystem), Member = "PauseAll", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LegacyAudioSystem), Member = "UpdateAmbientCueState", MemberParameters = new object[]
			{
				typeof(int),
				typeof(bool),
				typeof(ref float),
				typeof(float)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LegacyAudioSystem), Member = "UpdateAmbientCueTowardStopping", MemberParameters = new object[]
			{
				typeof(int),
				typeof(float),
				typeof(ref float),
				typeof(float)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LegacyAudioSystem), Member = "IsTrackPlaying", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LegacyAudioSystem), Member = "UpdateCommonTrack", MemberParameters = new object[]
			{
				typeof(bool),
				typeof(int),
				typeof(float),
				typeof(ref float)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LegacyAudioSystem), Member = "UpdateCommonTrackTowardStopping", MemberParameters = new object[]
			{
				typeof(int),
				typeof(float),
				typeof(ref float),
				typeof(bool)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700034B RID: 843
		// (get) Token: 0x060018DB RID: 6363 RVA: 0x000264EF File Offset: 0x000246EF
		[global::Cpp2ILInjected.Token(Token = "0x17000376")]
		public bool IsStopped
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001A6A")]
			[global::Cpp2ILInjected.Address(RVA = "0xB49B24", Offset = "0xB49B24", Length = "0x24")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LegacyAudioSystem), Member = "UpdateCommonTrackTowardStopping", MemberParameters = new object[]
			{
				typeof(int),
				typeof(float),
				typeof(ref float),
				typeof(bool)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x060018DC RID: 6364 RVA: 0x000264F2 File Offset: 0x000246F2
		[global::Cpp2ILInjected.Token(Token = "0x6001A6B")]
		[global::Cpp2ILInjected.Address(RVA = "0xB49B48", Offset = "0xB49B48", Length = "0x18")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LegacyAudioSystem), Member = "UpdateAmbientCueState", MemberParameters = new object[]
		{
			typeof(int),
			typeof(bool),
			typeof(ref float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LegacyAudioSystem), Member = "UpdateCommonTrack", MemberParameters = new object[]
		{
			typeof(bool),
			typeof(int),
			typeof(float),
			typeof(ref float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public void Play()
		{
			throw null;
		}

		// Token: 0x060018DD RID: 6365 RVA: 0x000264F5 File Offset: 0x000246F5
		[global::Cpp2ILInjected.Token(Token = "0x6001A6C")]
		[global::Cpp2ILInjected.Address(RVA = "0xB49B60", Offset = "0xB49B60", Length = "0x4C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LegacyAudioSystem), Member = "PauseAll", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SoundInstance), Member = "get_CurrentPosition", ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public void Pause()
		{
			throw null;
		}

		// Token: 0x060018DE RID: 6366 RVA: 0x000264F8 File Offset: 0x000246F8
		[global::Cpp2ILInjected.Token(Token = "0x6001A6D")]
		[global::Cpp2ILInjected.Address(RVA = "0xB49BC4", Offset = "0xB49BC4", Length = "0x40")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LegacyAudioSystem), Member = "ResumeAll", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LegacyAudioSystem), Member = "UpdateAmbientCueState", MemberParameters = new object[]
		{
			typeof(int),
			typeof(bool),
			typeof(ref float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SoundInstance), Member = "set_CurrentPosition", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
		public void Resume()
		{
			throw null;
		}

		// Token: 0x060018DF RID: 6367 RVA: 0x000264FB File Offset: 0x000246FB
		[global::Cpp2ILInjected.Token(Token = "0x6001A6E")]
		[global::Cpp2ILInjected.Address(RVA = "0xB49C18", Offset = "0xB49C18", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LegacyAudioSystem), Member = "LoadFromSources", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LegacyAudioSystem), Member = "UpdateAmbientCueState", MemberParameters = new object[]
		{
			typeof(int),
			typeof(bool),
			typeof(ref float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LegacyAudioSystem), Member = "UpdateAmbientCueTowardStopping", MemberParameters = new object[]
		{
			typeof(int),
			typeof(float),
			typeof(ref float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LegacyAudioSystem), Member = "UpdateCommonTrackTowardStopping", MemberParameters = new object[]
		{
			typeof(int),
			typeof(float),
			typeof(ref float),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public void Stop(AudioStopOptions option)
		{
			throw null;
		}

		// Token: 0x060018E0 RID: 6368 RVA: 0x000264FE File Offset: 0x000246FE
		[global::Cpp2ILInjected.Token(Token = "0x6001A6F")]
		[global::Cpp2ILInjected.Address(RVA = "0xB49C2C", Offset = "0xB49C2C", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LegacyAudioSystem), Member = "UpdateAmbientCueState", MemberParameters = new object[]
		{
			typeof(int),
			typeof(bool),
			typeof(ref float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LegacyAudioSystem), Member = "UpdateAmbientCueTowardStopping", MemberParameters = new object[]
		{
			typeof(int),
			typeof(float),
			typeof(ref float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LegacyAudioSystem), Member = "UpdateCommonTrack", MemberParameters = new object[]
		{
			typeof(bool),
			typeof(int),
			typeof(float),
			typeof(ref float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LegacyAudioSystem), Member = "UpdateCommonTrackTowardStopping", MemberParameters = new object[]
		{
			typeof(int),
			typeof(float),
			typeof(ref float),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
		public void SetVariable(string id, float value)
		{
			throw null;
		}

		// Token: 0x0400216A RID: 8554
		[global::Cpp2ILInjected.Token(Token = "0x40027D8")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private bool _paused;

		// Token: 0x0400216B RID: 8555
		[global::Cpp2ILInjected.Token(Token = "0x40027D9")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
		private float _pausedTime;

		// Token: 0x0400216C RID: 8556
		[global::Cpp2ILInjected.Token(Token = "0x40027DA")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private SoundEffectInstance _audioInstance;

		// Token: 0x0400216D RID: 8557
		[global::Cpp2ILInjected.Token(Token = "0x40027DB")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private SoundEffect _effect;
	}
}
