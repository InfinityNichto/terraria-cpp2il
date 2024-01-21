using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using ReLogic.Content.Sources;

namespace Terraria.Audio;

[Cpp2IlInjected.Token(Token = "0x2000486")]
public interface IAudioSystem : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60032D1")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void LoadCue(int cueIndex, string cueName);

	[Cpp2IlInjected.Token(Token = "0x60032D2")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void PauseAll();

	[Cpp2IlInjected.Token(Token = "0x60032D3")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void ResumeAll();

	[Cpp2IlInjected.Token(Token = "0x60032D4")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void UpdateMisc();

	[Cpp2IlInjected.Token(Token = "0x60032D5")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void UpdateAudioEngine();

	[Cpp2IlInjected.Token(Token = "0x60032D6")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void UpdateAmbientCueState(int i, bool gameIsActive, ref float trackVolume, float systemVolume);

	[Cpp2IlInjected.Token(Token = "0x60032D7")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void UpdateAmbientCueTowardStopping(int i, float stoppingSpeed, ref float trackVolume, float systemVolume);

	[Cpp2IlInjected.Token(Token = "0x60032D8")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void UpdateCommonTrack(bool active, int i, float totalVolume, ref float tempFade);

	[Cpp2IlInjected.Token(Token = "0x60032D9")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void UpdateCommonTrackTowardStopping(int i, float totalVolume, ref float tempFade, bool isMainTrackAudible);

	[Cpp2IlInjected.Token(Token = "0x60032DA")]
	[Cpp2IlInjected.Address(Slot = "9")]
	bool IsTrackPlaying(int trackIndex);

	[Cpp2IlInjected.Token(Token = "0x60032DB")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void UseSources(List<IContentSource> sources);

	[Cpp2IlInjected.Token(Token = "0x60032DC")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void LoadFromSources();

	[Cpp2IlInjected.Token(Token = "0x60032DD")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void Update();
}
