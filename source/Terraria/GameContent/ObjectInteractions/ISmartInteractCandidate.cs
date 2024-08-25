using System;
using Cpp2ILInjected;

namespace Terraria.GameContent.ObjectInteractions
{
	[global::Cpp2ILInjected.Token(Token = "0x2000844")]
	public interface ISmartInteractCandidate
	{
		[global::Cpp2ILInjected.Token(Token = "0x170007C6")]
		float DistanceFromCursor
		{
			[global::Cpp2ILInjected.Token(Token = "0x6004315")]
			get;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6004316")]
		void WinCandidacy();
	}
}
