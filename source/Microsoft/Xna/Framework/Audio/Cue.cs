using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Terraria.Audio;

namespace Microsoft.Xna.Framework.Audio
{
	[global::Cpp2ILInjected.Token(Token = "0x20003CD")]
	public class Cue
	{
		[global::Cpp2ILInjected.Token(Token = "0x6001A67")]
		[global::Cpp2ILInjected.Address(RVA = "0xB49A40", Offset = "0xB49A40", Length = "0x3C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SoundEffect), Member = "CreateInstance", ReturnType = typeof(SoundEffectInstance))]
		public Cue(SoundEffect musicSource)
		{
			throw null;
		}

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

		[global::Cpp2ILInjected.Token(Token = "0x40027D8")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private bool _paused;

		[global::Cpp2ILInjected.Token(Token = "0x40027D9")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
		private float _pausedTime;

		[global::Cpp2ILInjected.Token(Token = "0x40027DA")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private SoundEffectInstance _audioInstance;

		[global::Cpp2ILInjected.Token(Token = "0x40027DB")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private SoundEffect _effect;
	}
}
