using System;
using Cpp2ILInjected;

namespace ReLogic.OS.Windows
{
	[global::Cpp2ILInjected.Token(Token = "0x2000B26")]
	internal static class WindowsMessage
	{
		[global::Cpp2ILInjected.Token(Token = "0x4008B1F")]
		public const int SETFOCUS = 7;

		[global::Cpp2ILInjected.Token(Token = "0x4008B20")]
		public const int KILLFOCUS = 8;

		[global::Cpp2ILInjected.Token(Token = "0x4008B21")]
		public const int IME_STARTCOMPOSITION = 269;

		[global::Cpp2ILInjected.Token(Token = "0x4008B22")]
		public const int IME_ENDCOMPOSITION = 270;

		[global::Cpp2ILInjected.Token(Token = "0x4008B23")]
		public const int IME_COMPOSITION = 271;

		[global::Cpp2ILInjected.Token(Token = "0x4008B24")]
		public const int IME_SETCONTEXT = 641;

		[global::Cpp2ILInjected.Token(Token = "0x4008B25")]
		public const int IME_NOTIFY = 642;

		[global::Cpp2ILInjected.Token(Token = "0x4008B26")]
		public const int IME_CONTROL = 643;

		[global::Cpp2ILInjected.Token(Token = "0x4008B27")]
		public const int IME_COMPOSITIONFULL = 644;

		[global::Cpp2ILInjected.Token(Token = "0x4008B28")]
		public const int IME_SELECT = 645;

		[global::Cpp2ILInjected.Token(Token = "0x4008B29")]
		public const int IME_CHAR = 646;

		[global::Cpp2ILInjected.Token(Token = "0x4008B2A")]
		public const int IME_KEYDOWN = 656;

		[global::Cpp2ILInjected.Token(Token = "0x4008B2B")]
		public const int IME_KEYUP = 657;

		[global::Cpp2ILInjected.Token(Token = "0x4008B2C")]
		public const int INPUTLANGCHANGE = 81;

		[global::Cpp2ILInjected.Token(Token = "0x4008B2D")]
		public const int KEYDOWN = 256;

		[global::Cpp2ILInjected.Token(Token = "0x4008B2E")]
		public const int CHAR = 258;

		[global::Cpp2ILInjected.Token(Token = "0x4008B2F")]
		public const int ACTIVATE = 6;
	}
}
