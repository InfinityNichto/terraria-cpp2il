using System;
using Cpp2ILInjected;

namespace MonoGame.OpenGL
{
	[global::Cpp2ILInjected.Token(Token = "0x200031C")]
	internal interface IGraphicsContext
	{
		[global::Cpp2ILInjected.Token(Token = "0x170001D1")]
		int SwapInterval
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001287")]
			get;
			[global::Cpp2ILInjected.Token(Token = "0x6001288")]
			set;
		}

		[global::Cpp2ILInjected.Token(Token = "0x170001D2")]
		bool IsDisposed
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001289")]
			get;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600128A")]
		void MakeCurrent(IWindowInfo info);

		[global::Cpp2ILInjected.Token(Token = "0x600128B")]
		void SwapBuffers();

		[global::Cpp2ILInjected.Token(Token = "0x170001D3")]
		bool IsCurrent
		{
			[global::Cpp2ILInjected.Token(Token = "0x600128C")]
			get;
		}
	}
}
