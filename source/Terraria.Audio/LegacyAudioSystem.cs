using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using Microsoft.Xna.Framework.Audio;
using ReLogic.Content.Sources;

namespace Terraria.Audio;

[Cpp2IlInjected.Token(Token = "0x2000487")]
public class LegacyAudioSystem : IAudioSystem, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40064B1")]
	public Cue[] AudioTracks;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40064B2")]
	public int MusicReplayDelay;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40064B3")]
	public AudioEngine Engine;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x40064B4")]
	public SoundBank SoundBank;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40064B5")]
	public WaveBank WaveBank;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40064B6")]
	public Dictionary<int, string> TrackNamesByIndex;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40064B7")]
	public Dictionary<int, Cue> DefaultTrackByIndex;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x40064B8")]
	public List<IContentSource> FileSources;

	[Cpp2IlInjected.Token(Token = "0x60032DE")]
	[Cpp2IlInjected.Address(RVA = "0x106EE7C", Offset = "0x106EE7C", VA = "0x106EE7C", Slot = "15")]
	public void LoadFromSources()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60032DF")]
	[Cpp2IlInjected.Address(RVA = "0x106F07C", Offset = "0x106F07C", VA = "0x106F07C", Slot = "14")]
	public void UseSources(List<IContentSource> sourcesFromLowestToHighest)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60032E0")]
	[Cpp2IlInjected.Address(RVA = "0x106F084", Offset = "0x106F084", VA = "0x106F084", Slot = "16")]
	public void Update()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60032E1")]
	[Cpp2IlInjected.Address(RVA = "0x106F088", Offset = "0x106F088", VA = "0x106F088")]
	public LegacyAudioSystem()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60032E2")]
	[Cpp2IlInjected.Address(RVA = "0x106F210", Offset = "0x106F210", VA = "0x106F210", Slot = "4")]
	public void LoadCue(int cueIndex, string cueName)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60032E3")]
	[Cpp2IlInjected.Address(RVA = "0x106F2F8", Offset = "0x106F2F8", VA = "0x106F2F8", Slot = "7")]
	public void UpdateMisc()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60032E4")]
	[Cpp2IlInjected.Address(RVA = "0x106F398", Offset = "0x106F398", VA = "0x106F398", Slot = "5")]
	public void PauseAll()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60032E5")]
	[Cpp2IlInjected.Address(RVA = "0x106F518", Offset = "0x106F518", VA = "0x106F518", Slot = "6")]
	public void ResumeAll()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60032E6")]
	[Cpp2IlInjected.Address(RVA = "0x106F680", Offset = "0x106F680", VA = "0x106F680", Slot = "9")]
	public void UpdateAmbientCueState(int i, bool gameIsActive, ref float trackVolume, float systemVolume)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60032E7")]
	[Cpp2IlInjected.Address(RVA = "0x106F7D0", Offset = "0x106F7D0", VA = "0x106F7D0", Slot = "10")]
	public void UpdateAmbientCueTowardStopping(int i, float stoppingSpeed, ref float trackVolume, float systemVolume)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60032E8")]
	[Cpp2IlInjected.Address(RVA = "0x106F8DC", Offset = "0x106F8DC", VA = "0x106F8DC", Slot = "13")]
	public bool IsTrackPlaying(int trackIndex)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60032E9")]
	[Cpp2IlInjected.Address(RVA = "0x106F904", Offset = "0x106F904", VA = "0x106F904", Slot = "11")]
	public void UpdateCommonTrack(bool active, int i, float totalVolume, ref float tempFade)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60032EA")]
	[Cpp2IlInjected.Address(RVA = "0x106FAA4", Offset = "0x106FAA4", VA = "0x106FAA4", Slot = "12")]
	public void UpdateCommonTrackTowardStopping(int i, float totalVolume, ref float tempFade, bool isMainTrackAudible)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60032EB")]
	[Cpp2IlInjected.Address(RVA = "0x106FC38", Offset = "0x106FC38", VA = "0x106FC38", Slot = "8")]
	public void UpdateAudioEngine()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60032EC")]
	[Cpp2IlInjected.Address(RVA = "0x106FC3C", Offset = "0x106FC3C", VA = "0x106FC3C", Slot = "17")]
	public void Dispose()
	{
	}
}
