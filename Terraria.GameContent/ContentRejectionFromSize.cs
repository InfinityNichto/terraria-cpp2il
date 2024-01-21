using Cpp2IlInjected;
using ReLogic.Content;

namespace Terraria.GameContent;

[Cpp2IlInjected.Token(Token = "0x2000576")]
public class ContentRejectionFromSize : IRejectionReason
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4006AC6")]
	private int _neededWidth;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4006AC7")]
	private int _neededHeight;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4006AC8")]
	private int _actualWidth;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4006AC9")]
	private int _actualHeight;

	[Cpp2IlInjected.Token(Token = "0x6003AFF")]
	[Cpp2IlInjected.Address(RVA = "0x1081790", Offset = "0x1081790", VA = "0x1081790")]
	public ContentRejectionFromSize(int neededWidth, int neededHeight, int actualWidth, int actualHeight)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003B00")]
	[Cpp2IlInjected.Address(RVA = "0x10817C8", Offset = "0x10817C8", VA = "0x10817C8", Slot = "4")]
	public string GetReason()
	{
		return null;
	}
}
