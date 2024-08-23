using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

// Token: 0x02000234 RID: 564
[global::Cpp2ILInjected.Token(Token = "0x20002EB")]
public static class TexturePackerTileCompare
{
	// Token: 0x06001004 RID: 4100 RVA: 0x00024AEE File Offset: 0x00022CEE
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

	// Token: 0x06001005 RID: 4101 RVA: 0x00024AF1 File Offset: 0x00022CF1
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

	// Token: 0x06001006 RID: 4102 RVA: 0x00024AF4 File Offset: 0x00022CF4
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

	// Token: 0x06001007 RID: 4103 RVA: 0x00024AF7 File Offset: 0x00022CF7
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

	// Token: 0x06001008 RID: 4104 RVA: 0x00024AFA File Offset: 0x00022CFA
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

	// Token: 0x02000816 RID: 2070
	[global::Cpp2ILInjected.Token(Token = "0x20002EC")]
	public enum CompareResult
	{
		// Token: 0x04007D69 RID: 32105
		[global::Cpp2ILInjected.Token(Token = "0x4002123")]
		NoMatch,
		// Token: 0x04007D6A RID: 32106
		[global::Cpp2ILInjected.Token(Token = "0x4002124")]
		Same,
		// Token: 0x04007D6B RID: 32107
		[global::Cpp2ILInjected.Token(Token = "0x4002125")]
		XFlip,
		// Token: 0x04007D6C RID: 32108
		[global::Cpp2ILInjected.Token(Token = "0x4002126")]
		YFlip,
		// Token: 0x04007D6D RID: 32109
		[global::Cpp2ILInjected.Token(Token = "0x4002127")]
		XYFlip
	}
}
