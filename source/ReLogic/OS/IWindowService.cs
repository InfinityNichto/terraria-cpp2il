using System;
using Cpp2ILInjected;
using Microsoft.Xna.Framework;

namespace ReLogic.OS
{
	[global::Cpp2ILInjected.Token(Token = "0x2000B21")]
	public interface IWindowService
	{
		[global::Cpp2ILInjected.Token(Token = "0x6005349")]
		void SetUnicodeTitle(GameWindow window, string title);

		[global::Cpp2ILInjected.Token(Token = "0x600534A")]
		void StartFlashingIcon(GameWindow window);

		[global::Cpp2ILInjected.Token(Token = "0x600534B")]
		void StopFlashingIcon(GameWindow window);

		[global::Cpp2ILInjected.Token(Token = "0x600534C")]
		float GetScaling();

		[global::Cpp2ILInjected.Token(Token = "0x600534D")]
		void SetQuickEditEnabled(bool enabled);
	}
}
