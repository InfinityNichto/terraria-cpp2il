using System;
using Cpp2ILInjected;

namespace UnityEngine.UI
{
	[global::Cpp2ILInjected.Token(Token = "0x200000D")]
	public interface IClippable
	{
		[global::Cpp2ILInjected.Token(Token = "0x17000013")]
		GameObject gameObject
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000051")]
			get;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000052")]
		void RecalculateClipping();

		[global::Cpp2ILInjected.Token(Token = "0x17000014")]
		RectTransform rectTransform
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000053")]
			get;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000054")]
		void Cull(Rect clipRect, bool validRect);

		[global::Cpp2ILInjected.Token(Token = "0x6000055")]
		void SetClipRect(Rect value, bool validRect);

		[global::Cpp2ILInjected.Token(Token = "0x6000056")]
		void SetClipSoftness(Vector2 clipSoftness);
	}
}
