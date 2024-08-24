using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Terraria;

// Token: 0x0200010A RID: 266
[global::Cpp2ILInjected.Token(Token = "0x200017B")]
public class GUIInputRegion
{
	// Token: 0x060009C7 RID: 2503 RVA: 0x0002389A File Offset: 0x00021A9A
	[global::Cpp2ILInjected.Token(Token = "0x6000AC7")]
	[global::Cpp2ILInjected.Address(RVA = "0x9A0DF4", Offset = "0x9A0DF4", Length = "0xC")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "GetInputText", MemberParameters = new object[]
	{
		typeof(string),
		typeof(Rectangle),
		typeof(int),
		typeof(bool),
		typeof(bool),
		typeof(bool),
		typeof(bool)
	}, ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	public void Set(int x0, int x1, int y0, int y1)
	{
		throw null;
	}

	// Token: 0x060009C8 RID: 2504 RVA: 0x0002389D File Offset: 0x00021A9D
	[global::Cpp2ILInjected.Token(Token = "0x6000AC8")]
	[global::Cpp2ILInjected.Address(RVA = "0x9A0E00", Offset = "0x9A0E00", Length = "0x3C")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "GetInputText", MemberParameters = new object[]
	{
		typeof(string),
		typeof(Rectangle),
		typeof(int),
		typeof(bool),
		typeof(bool),
		typeof(bool),
		typeof(bool)
	}, ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	public bool Over(int x, int y)
	{
		throw null;
	}

	// Token: 0x060009C9 RID: 2505 RVA: 0x000238A0 File Offset: 0x00021AA0
	[global::Cpp2ILInjected.Token(Token = "0x6000AC9")]
	[global::Cpp2ILInjected.Address(RVA = "0x9A0E3C", Offset = "0x9A0E3C", Length = "0x6C")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIInputRegionManager), Member = "IsOverRegionExpanded", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	public bool OverExpanded(int x, int y, float expanded)
	{
		throw null;
	}

	// Token: 0x060009CA RID: 2506 RVA: 0x000238A3 File Offset: 0x00021AA3
	[global::Cpp2ILInjected.Token(Token = "0x6000ACA")]
	[global::Cpp2ILInjected.Address(RVA = "0x9A0EA8", Offset = "0x9A0EA8", Length = "0x8")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "GetInputText", MemberParameters = new object[]
	{
		typeof(string),
		typeof(Rectangle),
		typeof(int),
		typeof(bool),
		typeof(bool),
		typeof(bool),
		typeof(bool)
	}, ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
	public GUIInputRegion()
	{
		throw null;
	}

	// Token: 0x0400084E RID: 2126
	[global::Cpp2ILInjected.Token(Token = "0x4000B25")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
	public int xMin;

	// Token: 0x0400084F RID: 2127
	[global::Cpp2ILInjected.Token(Token = "0x4000B26")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
	public int xMax;

	// Token: 0x04000850 RID: 2128
	[global::Cpp2ILInjected.Token(Token = "0x4000B27")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
	public int yMin;

	// Token: 0x04000851 RID: 2129
	[global::Cpp2ILInjected.Token(Token = "0x4000B28")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C")]
	public int yMax;
}
