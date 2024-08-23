using System;
using Cpp2ILInjected;

namespace Terraria.GameContent.Animations
{
	// Token: 0x0200064C RID: 1612
	[global::Cpp2ILInjected.Token(Token = "0x2000994")]
	public interface IAnimationSegment
	{
		// Token: 0x17000774 RID: 1908
		// (get) Token: 0x06003F25 RID: 16165
		[global::Cpp2ILInjected.Token(Token = "0x17000846")]
		float DedicatedTimeNeeded
		{
			[global::Cpp2ILInjected.Token(Token = "0x60048CB")]
			get;
		}

		// Token: 0x06003F26 RID: 16166
		[global::Cpp2ILInjected.Token(Token = "0x60048CC")]
		void Draw(ref GameAnimationSegment info);
	}
}
