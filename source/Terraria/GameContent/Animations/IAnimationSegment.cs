using System;
using Cpp2ILInjected;

namespace Terraria.GameContent.Animations
{
	[global::Cpp2ILInjected.Token(Token = "0x2000994")]
	public interface IAnimationSegment
	{
		[global::Cpp2ILInjected.Token(Token = "0x17000846")]
		float DedicatedTimeNeeded
		{
			[global::Cpp2ILInjected.Token(Token = "0x60048CB")]
			get;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60048CC")]
		void Draw(ref GameAnimationSegment info);
	}
}
