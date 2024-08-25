using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

[global::Cpp2ILInjected.Token(Token = "0x20002EB")]
public static class TexturePackerTileCompare
{
	[global::Cpp2ILInjected.Token(Token = "0x6001153")]
	[global::Cpp2ILInjected.Address(RVA = "0xA6AF64", Offset = "0xA6AF64", Length = "0x9C")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TexturePackerTileCompare), Member = "CompareIdentical", MemberParameters = new object[]
	{
		typeof(int),
		typeof(int),
		typeof(Color32[]),
		typeof(Color32[])
	}, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TexturePackerTileCompare), Member = "CompareXFlip", MemberParameters = new object[]
	{
		typeof(int),
		typeof(int),
		typeof(Color32[]),
		typeof(Color32[])
	}, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TexturePackerTileCompare), Member = "CompareYFlip", MemberParameters = new object[]
	{
		typeof(int),
		typeof(int),
		typeof(Color32[]),
		typeof(Color32[])
	}, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TexturePackerTileCompare), Member = "CompareXYFlip", MemberParameters = new object[]
	{
		typeof(int),
		typeof(int),
		typeof(Color32[]),
		typeof(Color32[])
	}, ReturnType = typeof(bool))]
	public static TexturePackerTileCompare.CompareResult Compare(int tileWidth, int tileHeight, Color32[] src1, Color32[] src2)
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x6001154")]
	[global::Cpp2ILInjected.Address(RVA = "0xA6B000", Offset = "0xA6B000", Length = "0x98")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TexturePackerTileCompare), Member = "Compare", MemberParameters = new object[]
	{
		typeof(int),
		typeof(int),
		typeof(Color32[]),
		typeof(Color32[])
	}, ReturnType = typeof(TexturePackerTileCompare.CompareResult))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	private static bool CompareIdentical(int tileWidth, int tileHeight, Color32[] src1, Color32[] src2)
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x6001155")]
	[global::Cpp2ILInjected.Address(RVA = "0xA6B098", Offset = "0xA6B098", Length = "0xA4")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TexturePackerTileCompare), Member = "Compare", MemberParameters = new object[]
	{
		typeof(int),
		typeof(int),
		typeof(Color32[]),
		typeof(Color32[])
	}, ReturnType = typeof(TexturePackerTileCompare.CompareResult))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	private static bool CompareXFlip(int tileWidth, int tileHeight, Color32[] src1, Color32[] src2)
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x6001156")]
	[global::Cpp2ILInjected.Address(RVA = "0xA6B13C", Offset = "0xA6B13C", Length = "0xA8")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TexturePackerTileCompare), Member = "Compare", MemberParameters = new object[]
	{
		typeof(int),
		typeof(int),
		typeof(Color32[]),
		typeof(Color32[])
	}, ReturnType = typeof(TexturePackerTileCompare.CompareResult))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	private static bool CompareYFlip(int tileWidth, int tileHeight, Color32[] src1, Color32[] src2)
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x6001157")]
	[global::Cpp2ILInjected.Address(RVA = "0xA6B1E4", Offset = "0xA6B1E4", Length = "0xAC")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TexturePackerTileCompare), Member = "Compare", MemberParameters = new object[]
	{
		typeof(int),
		typeof(int),
		typeof(Color32[]),
		typeof(Color32[])
	}, ReturnType = typeof(TexturePackerTileCompare.CompareResult))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	private static bool CompareXYFlip(int tileWidth, int tileHeight, Color32[] src1, Color32[] src2)
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x20002EC")]
	public enum CompareResult
	{
		[global::Cpp2ILInjected.Token(Token = "0x4002123")]
		NoMatch,
		[global::Cpp2ILInjected.Token(Token = "0x4002124")]
		Same,
		[global::Cpp2ILInjected.Token(Token = "0x4002125")]
		XFlip,
		[global::Cpp2ILInjected.Token(Token = "0x4002126")]
		YFlip,
		[global::Cpp2ILInjected.Token(Token = "0x4002127")]
		XYFlip
	}
}
