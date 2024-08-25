using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using ReLogic.Content.Sources;

namespace Terraria.Audio
{
	[global::Cpp2ILInjected.Token(Token = "0x2000687")]
	public interface IAudioSystem : IDisposable
	{
		[global::Cpp2ILInjected.Token(Token = "0x60037C2")]
		void LoadCue(int cueIndex, string cueName);

		[global::Cpp2ILInjected.Token(Token = "0x60037C3")]
		void PauseAll();

		[global::Cpp2ILInjected.Token(Token = "0x60037C4")]
		void ResumeAll();

		[global::Cpp2ILInjected.Token(Token = "0x60037C5")]
		void UpdateMisc();

		[global::Cpp2ILInjected.Token(Token = "0x60037C6")]
		void UpdateAudioEngine();

		[global::Cpp2ILInjected.Token(Token = "0x60037C7")]
		void UpdateAmbientCueState(int i, bool gameIsActive, ref float trackVolume, float systemVolume);

		[global::Cpp2ILInjected.Token(Token = "0x60037C8")]
		void UpdateAmbientCueTowardStopping(int i, float stoppingSpeed, ref float trackVolume, float systemVolume);

		[global::Cpp2ILInjected.Token(Token = "0x60037C9")]
		void UpdateCommonTrack(bool active, int i, float totalVolume, ref float tempFade);

		[global::Cpp2ILInjected.Token(Token = "0x60037CA")]
		void UpdateCommonTrackTowardStopping(int i, float totalVolume, ref float tempFade, bool isMainTrackAudible);

		[global::Cpp2ILInjected.Token(Token = "0x60037CB")]
		bool IsTrackPlaying(int trackIndex);

		[global::Cpp2ILInjected.Token(Token = "0x60037CC")]
		void UseSources(List<IContentSource> sources);

		[global::Cpp2ILInjected.Token(Token = "0x60037CD")]
		void LoadFromSources();

		[global::Cpp2ILInjected.Token(Token = "0x60037CE")]
		void Update();
	}
}
