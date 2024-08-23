using System;
using Cpp2ILInjected;

namespace Terraria.GameContent.Animations
{
	// Token: 0x02000648 RID: 1608
	[global::Cpp2ILInjected.Token(Token = "0x2000971")]
	public interface IAnimationSegmentAction<T>
	{
		// Token: 0x06003F20 RID: 16160
		[global::Cpp2ILInjected.Token(Token = "0x6004843")]
		void BindTo(T obj);

		// Token: 0x17000773 RID: 1907
		// (get) Token: 0x06003F21 RID: 16161
		[global::Cpp2ILInjected.Token(Token = "0x1700082E")]
		int ExpectedLengthOfActionInFrames
		{
			[global::Cpp2ILInjected.Token(Token = "0x6004844")]
			get;
		}

		// Token: 0x06003F22 RID: 16162
		[global::Cpp2ILInjected.Token(Token = "0x6004845")]
		void ApplyTo(T obj, float localTimeForObj);

		// Token: 0x06003F23 RID: 16163
		[global::Cpp2ILInjected.Token(Token = "0x6004846")]
		void SetDelay(float delay);
	}
}
