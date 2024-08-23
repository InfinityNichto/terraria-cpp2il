using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

// Token: 0x0200011C RID: 284
[global::Cpp2ILInjected.Token(Token = "0x2000194")]
public class Buffs_Layout : LayoutDefinition
{
	// Token: 0x170000F9 RID: 249
	// (get) Token: 0x06000A47 RID: 2631 RVA: 0x00023A1A File Offset: 0x00021C1A
	[global::Cpp2ILInjected.Token(Token = "0x17000120")]
	public static Buffs_Layout Instance
	{
		[global::Cpp2ILInjected.Token(Token = "0x6000B54")]
		[global::Cpp2ILInjected.Address(RVA = "0x9ABCD0", Offset = "0x9ABCD0", Length = "0x7C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerBuff), Member = "GetSelectedItemRegion", ReturnType = typeof(Rectangle))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIBuffs), Member = "GetRegion", ReturnType = typeof(Rectangle))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIBuffs), Member = "Draw", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIBuffs), Member = "ItemScale", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIBuffs), Member = "ItemDraw", MemberParameters = new object[]
		{
			typeof(ItemGrid_Layout),
			typeof(int),
			typeof(Vector2),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 13)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		get
		{
			throw null;
		}
	}

	// Token: 0x06000A48 RID: 2632 RVA: 0x00023A1D File Offset: 0x00021C1D
	[global::Cpp2ILInjected.Token(Token = "0x6000B55")]
	[global::Cpp2ILInjected.Address(RVA = "0x9ABD4C", Offset = "0x9ABD4C", Length = "0x84")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Equality", MemberParameters = new object[]
	{
		typeof(string),
		typeof(string)
	}, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
	private void Awake()
	{
		throw null;
	}

	// Token: 0x06000A49 RID: 2633 RVA: 0x00023A20 File Offset: 0x00021C20
	[global::Cpp2ILInjected.Token(Token = "0x6000B56")]
	[global::Cpp2ILInjected.Address(RVA = "0x9ABDD0", Offset = "0x9ABDD0", Length = "0x140")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(float),
		typeof(float)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Color), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(float),
		typeof(float),
		typeof(float),
		typeof(float)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LayoutDefinition), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
	public Buffs_Layout()
	{
		throw null;
	}

	// Token: 0x04000963 RID: 2403
	[global::Cpp2ILInjected.Token(Token = "0x4000C85")]
	public static Buffs_Layout InstanceNormal;

	// Token: 0x04000964 RID: 2404
	[global::Cpp2ILInjected.Token(Token = "0x4000C86")]
	public static Buffs_Layout Instance4Page;

	// Token: 0x04000965 RID: 2405
	[global::Cpp2ILInjected.Token(Token = "0x4000C87")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
	public ItemGrid_Layout BuffsGrid;

	// Token: 0x04000966 RID: 2406
	[global::Cpp2ILInjected.Token(Token = "0x4000C88")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	public ItemGrid_Layout HorizontalBuffsGrid;

	// Token: 0x04000967 RID: 2407
	[global::Cpp2ILInjected.Token(Token = "0x4000C89")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
	public float ItemScale;

	// Token: 0x04000968 RID: 2408
	[global::Cpp2ILInjected.Token(Token = "0x4000C8A")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x2C")]
	public float SelectedScale;

	// Token: 0x04000969 RID: 2409
	[global::Cpp2ILInjected.Token(Token = "0x4000C8B")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
	public float BaseTextScale;

	// Token: 0x0400096A RID: 2410
	[global::Cpp2ILInjected.Token(Token = "0x4000C8C")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x34")]
	public Vector2 TextOffset;

	// Token: 0x0400096B RID: 2411
	[global::Cpp2ILInjected.Token(Token = "0x4000C8D")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x3C")]
	public Color SelectedColour;

	// Token: 0x0400096C RID: 2412
	[global::Cpp2ILInjected.Token(Token = "0x4000C8E")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
	public Color NormalColour;

	// Token: 0x0400096D RID: 2413
	[global::Cpp2ILInjected.Token(Token = "0x4000C8F")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x44")]
	public Color SelectedTextColour;

	// Token: 0x0400096E RID: 2414
	[global::Cpp2ILInjected.Token(Token = "0x4000C90")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
	public Color NormalTextColour;
}
