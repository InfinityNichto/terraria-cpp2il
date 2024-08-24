using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using ReLogic.Content.Sources;

namespace Terraria.Audio
{
	// Token: 0x02000483 RID: 1155
	[global::Cpp2ILInjected.Token(Token = "0x2000687")]
	public interface IAudioSystem : IDisposable
	{
		// Token: 0x06003295 RID: 12949
		[global::Cpp2ILInjected.Token(Token = "0x60037C2")]
		void LoadCue(int cueIndex, string cueName);

		// Token: 0x06003296 RID: 12950
		[global::Cpp2ILInjected.Token(Token = "0x60037C3")]
		void PauseAll();

		// Token: 0x06003297 RID: 12951
		[global::Cpp2ILInjected.Token(Token = "0x60037C4")]
		void ResumeAll();

		// Token: 0x06003298 RID: 12952
		[global::Cpp2ILInjected.Token(Token = "0x60037C5")]
		void UpdateMisc();

		// Token: 0x06003299 RID: 12953
		[global::Cpp2ILInjected.Token(Token = "0x60037C6")]
		void UpdateAudioEngine();

		// Token: 0x0600329A RID: 12954
		[global::Cpp2ILInjected.Token(Token = "0x60037C7")]
		void UpdateAmbientCueState(int i, bool gameIsActive, ref float trackVolume, float systemVolume);

		// Token: 0x0600329B RID: 12955
		[global::Cpp2ILInjected.Token(Token = "0x60037C8")]
		void UpdateAmbientCueTowardStopping(int i, float stoppingSpeed, ref float trackVolume, float systemVolume);

		// Token: 0x0600329C RID: 12956
		[global::Cpp2ILInjected.Token(Token = "0x60037C9")]
		void UpdateCommonTrack(bool active, int i, float totalVolume, ref float tempFade);

		// Token: 0x0600329D RID: 12957
		[global::Cpp2ILInjected.Token(Token = "0x60037CA")]
		void UpdateCommonTrackTowardStopping(int i, float totalVolume, ref float tempFade, bool isMainTrackAudible);

		// Token: 0x0600329E RID: 12958
		[global::Cpp2ILInjected.Token(Token = "0x60037CB")]
		bool IsTrackPlaying(int trackIndex);

		// Token: 0x0600329F RID: 12959
		[global::Cpp2ILInjected.Token(Token = "0x60037CC")]
		void UseSources(List<IContentSource> sources);

		// Token: 0x060032A0 RID: 12960
		[global::Cpp2ILInjected.Token(Token = "0x60037CD")]
		void LoadFromSources();

		// Token: 0x060032A1 RID: 12961
		[global::Cpp2ILInjected.Token(Token = "0x60037CE")]
		void Update();
	}
}
