using System;
using Cpp2ILInjected;

namespace UnityEngine.UI
{
	[global::Cpp2ILInjected.Token(Token = "0x2000046")]
	public interface ILayoutElement
	{
		[global::Cpp2ILInjected.Token(Token = "0x60002AA")]
		void CalculateLayoutInputHorizontal();

		[global::Cpp2ILInjected.Token(Token = "0x60002AB")]
		void CalculateLayoutInputVertical();

		[global::Cpp2ILInjected.Token(Token = "0x170000B6")]
		float minWidth
		{
			[global::Cpp2ILInjected.Token(Token = "0x60002AC")]
			get;
		}

		[global::Cpp2ILInjected.Token(Token = "0x170000B7")]
		float preferredWidth
		{
			[global::Cpp2ILInjected.Token(Token = "0x60002AD")]
			get;
		}

		[global::Cpp2ILInjected.Token(Token = "0x170000B8")]
		float flexibleWidth
		{
			[global::Cpp2ILInjected.Token(Token = "0x60002AE")]
			get;
		}

		[global::Cpp2ILInjected.Token(Token = "0x170000B9")]
		float minHeight
		{
			[global::Cpp2ILInjected.Token(Token = "0x60002AF")]
			get;
		}

		[global::Cpp2ILInjected.Token(Token = "0x170000BA")]
		float preferredHeight
		{
			[global::Cpp2ILInjected.Token(Token = "0x60002B0")]
			get;
		}

		[global::Cpp2ILInjected.Token(Token = "0x170000BB")]
		float flexibleHeight
		{
			[global::Cpp2ILInjected.Token(Token = "0x60002B1")]
			get;
		}

		[global::Cpp2ILInjected.Token(Token = "0x170000BC")]
		int layoutPriority
		{
			[global::Cpp2ILInjected.Token(Token = "0x60002B2")]
			get;
		}
	}
}
