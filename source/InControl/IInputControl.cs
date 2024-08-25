using System;
using Cpp2ILInjected;

namespace InControl
{
	[global::Cpp2ILInjected.Token(Token = "0x200001D")]
	public interface IInputControl
	{
		[global::Cpp2ILInjected.Token(Token = "0x17000049")]
		bool HasChanged
		{
			[global::Cpp2ILInjected.Token(Token = "0x600012B")]
			get;
		}

		[global::Cpp2ILInjected.Token(Token = "0x1700004A")]
		bool IsPressed
		{
			[global::Cpp2ILInjected.Token(Token = "0x600012C")]
			get;
		}

		[global::Cpp2ILInjected.Token(Token = "0x1700004B")]
		bool WasPressed
		{
			[global::Cpp2ILInjected.Token(Token = "0x600012D")]
			get;
		}

		[global::Cpp2ILInjected.Token(Token = "0x1700004C")]
		bool WasReleased
		{
			[global::Cpp2ILInjected.Token(Token = "0x600012E")]
			get;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600012F")]
		void ClearInputState();
	}
}
