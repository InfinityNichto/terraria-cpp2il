using System;
using Cpp2ILInjected;

namespace UnityEngine.UI.CoroutineTween
{
	// Token: 0x02000046 RID: 70
	[global::Cpp2ILInjected.Token(Token = "0x2000088")]
	internal interface ITweenValue
	{
		// Token: 0x060004D2 RID: 1234
		[global::Cpp2ILInjected.Token(Token = "0x6000553")]
		void TweenValue(float floatPercentage);

		// Token: 0x17000149 RID: 329
		// (get) Token: 0x060004D3 RID: 1235
		[global::Cpp2ILInjected.Token(Token = "0x1700015C")]
		bool ignoreTimeScale
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000554")]
			get;
		}

		// Token: 0x1700014A RID: 330
		// (get) Token: 0x060004D4 RID: 1236
		[global::Cpp2ILInjected.Token(Token = "0x1700015D")]
		float duration
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000555")]
			get;
		}

		// Token: 0x060004D5 RID: 1237
		[global::Cpp2ILInjected.Token(Token = "0x6000556")]
		bool ValidTarget();
	}
}
