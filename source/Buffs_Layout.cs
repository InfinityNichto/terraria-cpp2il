using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

[global::Cpp2ILInjected.Token(Token = "0x2000194")]
public class Buffs_Layout : LayoutDefinition
{
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

	[global::Cpp2ILInjected.Token(Token = "0x4000C85")]
	public static Buffs_Layout InstanceNormal;

	[global::Cpp2ILInjected.Token(Token = "0x4000C86")]
	public static Buffs_Layout Instance4Page;

	[global::Cpp2ILInjected.Token(Token = "0x4000C87")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
	public ItemGrid_Layout BuffsGrid;

	[global::Cpp2ILInjected.Token(Token = "0x4000C88")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	public ItemGrid_Layout HorizontalBuffsGrid;

	[global::Cpp2ILInjected.Token(Token = "0x4000C89")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
	public float ItemScale;

	[global::Cpp2ILInjected.Token(Token = "0x4000C8A")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x2C")]
	public float SelectedScale;

	[global::Cpp2ILInjected.Token(Token = "0x4000C8B")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
	public float BaseTextScale;

	[global::Cpp2ILInjected.Token(Token = "0x4000C8C")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x34")]
	public Vector2 TextOffset;

	[global::Cpp2ILInjected.Token(Token = "0x4000C8D")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x3C")]
	public Color SelectedColour;

	[global::Cpp2ILInjected.Token(Token = "0x4000C8E")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
	public Color NormalColour;

	[global::Cpp2ILInjected.Token(Token = "0x4000C8F")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x44")]
	public Color SelectedTextColour;

	[global::Cpp2ILInjected.Token(Token = "0x4000C90")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
	public Color NormalTextColour;
}
