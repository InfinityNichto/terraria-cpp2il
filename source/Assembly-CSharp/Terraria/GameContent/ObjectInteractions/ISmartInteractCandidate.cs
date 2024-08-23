using System;
using Cpp2ILInjected;

namespace Terraria.GameContent.ObjectInteractions
{
	// Token: 0x020005A5 RID: 1445
	[global::Cpp2ILInjected.Token(Token = "0x2000844")]
	public interface ISmartInteractCandidate
	{
		// Token: 0x17000725 RID: 1829
		// (get) Token: 0x06003BF2 RID: 15346
		[global::Cpp2ILInjected.Token(Token = "0x170007C6")]
		float DistanceFromCursor
		{
			[global::Cpp2ILInjected.Token(Token = "0x6004315")]
			get;
		}

		// Token: 0x06003BF3 RID: 15347
		[global::Cpp2ILInjected.Token(Token = "0x6004316")]
		void WinCandidacy();
	}
}
