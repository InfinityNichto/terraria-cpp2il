using System;
using Cpp2ILInjected;

namespace UnityEngine.UI.CoroutineTween
{
	[global::Cpp2ILInjected.Token(Token = "0x2000088")]
	internal interface ITweenValue
	{
		[global::Cpp2ILInjected.Token(Token = "0x6000553")]
		void TweenValue(float floatPercentage);

		[global::Cpp2ILInjected.Token(Token = "0x1700015C")]
		bool ignoreTimeScale
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000554")]
			get;
		}

		[global::Cpp2ILInjected.Token(Token = "0x1700015D")]
		float duration
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000555")]
			get;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000556")]
		bool ValidTarget();
	}
}
