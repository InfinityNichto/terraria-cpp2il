using System;
using Cpp2ILInjected;

namespace UnityEngine.UI
{
	[global::Cpp2ILInjected.Token(Token = "0x2000007")]
	public interface ICanvasElement
	{
		[global::Cpp2ILInjected.Token(Token = "0x600001A")]
		void Rebuild(CanvasUpdate executing);

		[global::Cpp2ILInjected.Token(Token = "0x17000009")]
		Transform transform
		{
			[global::Cpp2ILInjected.Token(Token = "0x600001B")]
			get;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600001C")]
		void LayoutComplete();

		[global::Cpp2ILInjected.Token(Token = "0x600001D")]
		void GraphicUpdateComplete();

		[global::Cpp2ILInjected.Token(Token = "0x600001E")]
		bool IsDestroyed();
	}
}
