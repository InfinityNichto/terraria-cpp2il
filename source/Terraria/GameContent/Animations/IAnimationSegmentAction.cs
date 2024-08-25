using System;
using Cpp2ILInjected;

namespace Terraria.GameContent.Animations
{
	[global::Cpp2ILInjected.Token(Token = "0x2000971")]
	public interface IAnimationSegmentAction<T>
	{
		[global::Cpp2ILInjected.Token(Token = "0x6004843")]
		void BindTo(T obj);

		[global::Cpp2ILInjected.Token(Token = "0x1700082E")]
		int ExpectedLengthOfActionInFrames
		{
			[global::Cpp2ILInjected.Token(Token = "0x6004844")]
			get;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6004845")]
		void ApplyTo(T obj, float localTimeForObj);

		[global::Cpp2ILInjected.Token(Token = "0x6004846")]
		void SetDelay(float delay);
	}
}
