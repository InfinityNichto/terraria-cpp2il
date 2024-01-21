using Cpp2IlInjected;
using UnityEngine;

[Cpp2IlInjected.Token(Token = "0x2000236")]
public static class TexturePackerTileCompare
{
	[Cpp2IlInjected.Token(Token = "0x200080D")]
	public enum CompareResult
	{
		[Cpp2IlInjected.Token(Token = "0x4007D56")]
		NoMatch,
		[Cpp2IlInjected.Token(Token = "0x4007D57")]
		Same,
		[Cpp2IlInjected.Token(Token = "0x4007D58")]
		XFlip,
		[Cpp2IlInjected.Token(Token = "0x4007D59")]
		YFlip,
		[Cpp2IlInjected.Token(Token = "0x4007D5A")]
		XYFlip
	}

	[Cpp2IlInjected.Token(Token = "0x600101D")]
	[Cpp2IlInjected.Address(RVA = "0x10CCDC0", Offset = "0x10CCDC0", VA = "0x10CCDC0")]
	public static CompareResult Compare(int tileWidth, int tileHeight, Color32[] src1, Color32[] src2)
	{
		return default(CompareResult);
	}

	[Cpp2IlInjected.Token(Token = "0x600101E")]
	[Cpp2IlInjected.Address(RVA = "0x10CCE5C", Offset = "0x10CCE5C", VA = "0x10CCE5C")]
	private static bool CompareIdentical(int tileWidth, int tileHeight, Color32[] src1, Color32[] src2)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600101F")]
	[Cpp2IlInjected.Address(RVA = "0x10CCEF4", Offset = "0x10CCEF4", VA = "0x10CCEF4")]
	private static bool CompareXFlip(int tileWidth, int tileHeight, Color32[] src1, Color32[] src2)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6001020")]
	[Cpp2IlInjected.Address(RVA = "0x10CCF90", Offset = "0x10CCF90", VA = "0x10CCF90")]
	private static bool CompareYFlip(int tileWidth, int tileHeight, Color32[] src1, Color32[] src2)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6001021")]
	[Cpp2IlInjected.Address(RVA = "0x10CD038", Offset = "0x10CD038", VA = "0x10CD038")]
	private static bool CompareXYFlip(int tileWidth, int tileHeight, Color32[] src1, Color32[] src2)
	{
		return default(bool);
	}
}
