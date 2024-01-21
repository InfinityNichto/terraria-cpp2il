using Cpp2IlInjected;

namespace ReLogic.OS.Windows;

[Cpp2IlInjected.Token(Token = "0x200072A")]
internal static class WindowsMessage
{
	[Cpp2IlInjected.Token(Token = "0x4007183")]
	public const int SETFOCUS = 7;

	[Cpp2IlInjected.Token(Token = "0x4007184")]
	public const int KILLFOCUS = 8;

	[Cpp2IlInjected.Token(Token = "0x4007185")]
	public const int IME_STARTCOMPOSITION = 269;

	[Cpp2IlInjected.Token(Token = "0x4007186")]
	public const int IME_ENDCOMPOSITION = 270;

	[Cpp2IlInjected.Token(Token = "0x4007187")]
	public const int IME_COMPOSITION = 271;

	[Cpp2IlInjected.Token(Token = "0x4007188")]
	public const int IME_SETCONTEXT = 641;

	[Cpp2IlInjected.Token(Token = "0x4007189")]
	public const int IME_NOTIFY = 642;

	[Cpp2IlInjected.Token(Token = "0x400718A")]
	public const int IME_CONTROL = 643;

	[Cpp2IlInjected.Token(Token = "0x400718B")]
	public const int IME_COMPOSITIONFULL = 644;

	[Cpp2IlInjected.Token(Token = "0x400718C")]
	public const int IME_SELECT = 645;

	[Cpp2IlInjected.Token(Token = "0x400718D")]
	public const int IME_CHAR = 646;

	[Cpp2IlInjected.Token(Token = "0x400718E")]
	public const int IME_KEYDOWN = 656;

	[Cpp2IlInjected.Token(Token = "0x400718F")]
	public const int IME_KEYUP = 657;

	[Cpp2IlInjected.Token(Token = "0x4007190")]
	public const int INPUTLANGCHANGE = 81;

	[Cpp2IlInjected.Token(Token = "0x4007191")]
	public const int KEYDOWN = 256;

	[Cpp2IlInjected.Token(Token = "0x4007192")]
	public const int CHAR = 258;

	[Cpp2IlInjected.Token(Token = "0x4007193")]
	public const int ACTIVATE = 6;
}
