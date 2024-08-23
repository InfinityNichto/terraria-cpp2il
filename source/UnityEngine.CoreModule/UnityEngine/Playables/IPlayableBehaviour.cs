using System;
using Cpp2ILInjected;
using UnityEngine.Scripting;

namespace UnityEngine.Playables
{
	// Token: 0x0200012E RID: 302
	[global::Cpp2ILInjected.Token(Token = "0x2000155")]
	public interface IPlayableBehaviour
	{
		// Token: 0x06000628 RID: 1576
		[RequiredByNativeCode]
		[global::Cpp2ILInjected.Token(Token = "0x6000660")]
		void OnGraphStart(Playable playable);

		// Token: 0x06000629 RID: 1577
		[RequiredByNativeCode]
		[global::Cpp2ILInjected.Token(Token = "0x6000661")]
		void OnGraphStop(Playable playable);

		// Token: 0x0600062A RID: 1578
		[RequiredByNativeCode]
		[global::Cpp2ILInjected.Token(Token = "0x6000662")]
		void OnPlayableCreate(Playable playable);

		// Token: 0x0600062B RID: 1579
		[RequiredByNativeCode]
		[global::Cpp2ILInjected.Token(Token = "0x6000663")]
		void OnPlayableDestroy(Playable playable);

		// Token: 0x0600062C RID: 1580
		[RequiredByNativeCode]
		[global::Cpp2ILInjected.Token(Token = "0x6000664")]
		void OnBehaviourPlay(Playable playable, FrameData info);

		// Token: 0x0600062D RID: 1581
		[RequiredByNativeCode]
		[global::Cpp2ILInjected.Token(Token = "0x6000665")]
		void OnBehaviourPause(Playable playable, FrameData info);

		// Token: 0x0600062E RID: 1582
		[RequiredByNativeCode]
		[global::Cpp2ILInjected.Token(Token = "0x6000666")]
		void PrepareFrame(Playable playable, FrameData info);

		// Token: 0x0600062F RID: 1583
		[RequiredByNativeCode]
		[global::Cpp2ILInjected.Token(Token = "0x6000667")]
		void ProcessFrame(Playable playable, FrameData info, object playerData);
	}
}
