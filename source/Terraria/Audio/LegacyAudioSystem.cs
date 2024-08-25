using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework.Audio;
using ReLogic.Content.Sources;
using Terraria.Utilities;
using UnityEngine;

namespace Terraria.Audio
{
	[global::Cpp2ILInjected.Token(Token = "0x2000688")]
	public class LegacyAudioSystem : IAudioSystem, IDisposable
	{
		[global::Cpp2ILInjected.Token(Token = "0x60037CF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1421724", Offset = "0x1421724", Length = "0x204")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LegacyAudioSystem), Member = "UseSources", MemberParameters = new object[] { typeof(List<IContentSource>) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<int, object>), Member = "TryGetValue", MemberParameters = new object[]
		{
			typeof(int),
			typeof(ref object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(char), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<int, object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "TValue")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Cue), Member = "Stop", MemberParameters = new object[] { typeof(AudioStopOptions) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
		public void LoadFromSources()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60037D0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1421928", Offset = "0x1421928", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LegacyAudioSystem), Member = "LoadFromSources", ReturnType = typeof(void))]
		public void UseSources(List<IContentSource> sourcesFromLowestToHighest)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60037D1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1421930", Offset = "0x1421930", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public void Update()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60037D2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1421934", Offset = "0x1421934", Length = "0x1D4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "LoadContent", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AudioEngine), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SoundBank), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(AudioEngine),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WaveBank), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(AudioEngine),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<int, object>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 17)]
		public LegacyAudioSystem()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60037D3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1421B08", Offset = "0x1421B08", Length = "0xEC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SoundBank), Member = "LoadMusicId", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SoundBank), Member = "GetCue", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(Cue))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<int, object>), Member = "set_Item", MemberParameters = new object[]
		{
			typeof(int),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public void LoadCue(int cueIndex, string cueName)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60037D4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1421BF4", Offset = "0x1421BF4", Length = "0x80")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public void UpdateMisc()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60037D5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1421C74", Offset = "0x1421C74", Length = "0x14C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Cue), Member = "get_IsPlaying", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Cue), Member = "Pause", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
		public void PauseAll()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60037D6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1421DC0", Offset = "0x1421DC0", Length = "0x134")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Cue), Member = "Resume", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
		public void ResumeAll()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60037D7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1421EF4", Offset = "0x1421EF4", Length = "0x148")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Cue), Member = "get_IsPlaying", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Cue), Member = "Stop", MemberParameters = new object[] { typeof(AudioStopOptions) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Cue), Member = "Resume", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Cue), Member = "Play", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Cue), Member = "SetVariable", MemberParameters = new object[]
		{
			typeof(string),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public void UpdateAmbientCueState(int i, bool gameIsActive, ref float trackVolume, float systemVolume)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60037D8")]
		[global::Cpp2ILInjected.Address(RVA = "0x142203C", Offset = "0x142203C", Length = "0xF4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Cue), Member = "get_IsPlaying", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Cue), Member = "SetVariable", MemberParameters = new object[]
		{
			typeof(string),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Cue), Member = "Stop", MemberParameters = new object[] { typeof(AudioStopOptions) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public void UpdateAmbientCueTowardStopping(int i, float stoppingSpeed, ref float trackVolume, float systemVolume)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60037D9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1422130", Offset = "0x1422130", Length = "0x24")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Cue), Member = "get_IsPlaying", ReturnType = typeof(bool))]
		public bool IsTrackPlaying(int trackIndex)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60037DA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1422154", Offset = "0x1422154", Length = "0x184")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Cue), Member = "get_IsPlaying", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Cue), Member = "SetVariable", MemberParameters = new object[]
		{
			typeof(string),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_SettingMusicReplayDelayEnabled", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnifiedRandom), Member = "Next", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Cue), Member = "Play", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public void UpdateCommonTrack(bool active, int i, float totalVolume, ref float tempFade)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60037DB")]
		[global::Cpp2ILInjected.Address(RVA = "0x14222D8", Offset = "0x14222D8", Length = "0x174")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Cue), Member = "get_IsPlaying", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Cue), Member = "get_IsStopped", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Cue), Member = "SetVariable", MemberParameters = new object[]
		{
			typeof(string),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Cue), Member = "Stop", MemberParameters = new object[] { typeof(AudioStopOptions) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public void UpdateCommonTrackTowardStopping(int i, float totalVolume, ref float tempFade, bool isMainTrackAudible)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60037DC")]
		[global::Cpp2ILInjected.Address(RVA = "0x142244C", Offset = "0x142244C", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public void UpdateAudioEngine()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60037DD")]
		[global::Cpp2ILInjected.Address(RVA = "0x1422450", Offset = "0x1422450", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public void Dispose()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x40078AC")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		public Cue[] AudioTracks;

		[global::Cpp2ILInjected.Token(Token = "0x40078AD")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		public int MusicReplayDelay;

		[global::Cpp2ILInjected.Token(Token = "0x40078AE")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		public AudioEngine Engine;

		[global::Cpp2ILInjected.Token(Token = "0x40078AF")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		public SoundBank SoundBank;

		[global::Cpp2ILInjected.Token(Token = "0x40078B0")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		public WaveBank WaveBank;

		[global::Cpp2ILInjected.Token(Token = "0x40078B1")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		public Dictionary<int, string> TrackNamesByIndex;

		[global::Cpp2ILInjected.Token(Token = "0x40078B2")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		public Dictionary<int, Cue> DefaultTrackByIndex;

		[global::Cpp2ILInjected.Token(Token = "0x40078B3")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
		public List<IContentSource> FileSources;
	}
}
