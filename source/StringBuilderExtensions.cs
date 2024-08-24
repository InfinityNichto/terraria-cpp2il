using System;
using System.Text;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.UI;

// Token: 0x02000246 RID: 582
[global::Cpp2ILInjected.Token(Token = "0x20002FF")]
public static class StringBuilderExtensions
{
	// Token: 0x06001075 RID: 4213 RVA: 0x00024C41 File Offset: 0x00022E41
	[global::Cpp2ILInjected.Token(Token = "0x60011C4")]
	[global::Cpp2ILInjected.Address(RVA = "0xA6EBEC", Offset = "0xA6EBEC", Length = "0x3C")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIHearts), Member = "DrawLifeString", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIHotbar), Member = "DrawHotbarItem", MemberParameters = new object[]
	{
		typeof(SpriteBatch),
		typeof(ItemGrid_Layout),
		typeof(Item[]),
		typeof(int),
		typeof(Vector2),
		typeof(Color),
		typeof(float)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIInventory), Member = "DrawItem", MemberParameters = new object[]
	{
		typeof(SpriteBatch),
		typeof(ItemGrid_Layout),
		typeof(Item[]),
		typeof(int),
		typeof(Vector2),
		typeof(Color),
		typeof(float)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIMana), Member = "Draw", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIMainMenu), Member = "Draw", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DrawFPS", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemSlot), Member = "Draw", MemberParameters = new object[]
	{
		typeof(SpriteBatch),
		typeof(Item[]),
		typeof(int),
		typeof(int),
		typeof(Vector2),
		typeof(Color),
		typeof(Color)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 15)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(StringBuilder))]
	public static void AppendInt(this StringBuilder stringBuilder, int value)
	{
		throw null;
	}

	// Token: 0x06001076 RID: 4214 RVA: 0x00024C44 File Offset: 0x00022E44
	[global::Cpp2ILInjected.Token(Token = "0x60011C5")]
	[global::Cpp2ILInjected.Address(RVA = "0xA6EC28", Offset = "0xA6EC28", Length = "0x64")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(StringBuilderExtensions), Member = "AppendIntCharacter", MemberParameters = new object[]
	{
		typeof(StringBuilder),
		typeof(int)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilderExtensions), Member = "AppendIntCharacter", MemberParameters = new object[]
	{
		typeof(StringBuilder),
		typeof(int)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(StringBuilder))]
	private static void AppendIntCharacter(StringBuilder stringBuilder, int value)
	{
		throw null;
	}
}
