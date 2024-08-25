using System;
using Cpp2ILInjected;
using UnityEngine.Scripting;

namespace UnityEngine.Playables
{
	[global::Cpp2ILInjected.Token(Token = "0x2000155")]
	public interface IPlayableBehaviour
	{
		[RequiredByNativeCode]
		[global::Cpp2ILInjected.Token(Token = "0x6000660")]
		void OnGraphStart(Playable playable);

		[RequiredByNativeCode]
		[global::Cpp2ILInjected.Token(Token = "0x6000661")]
		void OnGraphStop(Playable playable);

		[RequiredByNativeCode]
		[global::Cpp2ILInjected.Token(Token = "0x6000662")]
		void OnPlayableCreate(Playable playable);

		[RequiredByNativeCode]
		[global::Cpp2ILInjected.Token(Token = "0x6000663")]
		void OnPlayableDestroy(Playable playable);

		[RequiredByNativeCode]
		[global::Cpp2ILInjected.Token(Token = "0x6000664")]
		void OnBehaviourPlay(Playable playable, FrameData info);

		[RequiredByNativeCode]
		[global::Cpp2ILInjected.Token(Token = "0x6000665")]
		void OnBehaviourPause(Playable playable, FrameData info);

		[RequiredByNativeCode]
		[global::Cpp2ILInjected.Token(Token = "0x6000666")]
		void PrepareFrame(Playable playable, FrameData info);

		[RequiredByNativeCode]
		[global::Cpp2ILInjected.Token(Token = "0x6000667")]
		void ProcessFrame(Playable playable, FrameData info, object playerData);
	}
}
