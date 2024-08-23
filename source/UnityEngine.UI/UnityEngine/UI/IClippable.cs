using System;
using Cpp2ILInjected;

namespace UnityEngine.UI
{
	// Token: 0x0200000B RID: 11
	[global::Cpp2ILInjected.Token(Token = "0x200000D")]
	public interface IClippable
	{
		// Token: 0x17000011 RID: 17
		// (get) Token: 0x0600004A RID: 74
		[global::Cpp2ILInjected.Token(Token = "0x17000013")]
		GameObject gameObject
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000051")]
			get;
		}

		// Token: 0x0600004B RID: 75
		[global::Cpp2ILInjected.Token(Token = "0x6000052")]
		void RecalculateClipping();

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x0600004C RID: 76
		[global::Cpp2ILInjected.Token(Token = "0x17000014")]
		RectTransform rectTransform
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000053")]
			get;
		}

		// Token: 0x0600004D RID: 77
		[global::Cpp2ILInjected.Token(Token = "0x6000054")]
		void Cull(Rect clipRect, bool validRect);

		// Token: 0x0600004E RID: 78
		[global::Cpp2ILInjected.Token(Token = "0x6000055")]
		void SetClipRect(Rect value, bool validRect);

		// Token: 0x0600004F RID: 79
		[global::Cpp2ILInjected.Token(Token = "0x6000056")]
		void SetClipSoftness(Vector2 clipSoftness);
	}
}
