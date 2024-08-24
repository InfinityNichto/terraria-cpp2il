using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.GameContent.UI;

// Token: 0x020001E3 RID: 483
[global::Cpp2ILInjected.Token(Token = "0x2000281")]
public class GUIStatusMenu
{
	// Token: 0x06000D6F RID: 3439 RVA: 0x00024392 File Offset: 0x00022592
	[global::Cpp2ILInjected.Token(Token = "0x6000E91")]
	[global::Cpp2ILInjected.Address(RVA = "0xA092CC", Offset = "0xA092CC", Length = "0xC8")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DrawMenu", MemberParameters = new object[] { typeof(GameTime) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "ClearVisualPostProcessEffects", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIStringButton), Member = "DrawButton", MemberParameters = new object[]
	{
		typeof(StringButton_Layout),
		typeof(string),
		typeof(ref float),
		typeof(bool),
		typeof(bool)
	}, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GameTipsDisplay), Member = "Update", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GameTipsDisplay), Member = "Draw", MemberParameters = new object[]
	{
		typeof(String_Layout),
		typeof(float)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
	public void Draw()
	{
		throw null;
	}

	// Token: 0x06000D70 RID: 3440 RVA: 0x00024395 File Offset: 0x00022595
	[global::Cpp2ILInjected.Token(Token = "0x6000E92")]
	[global::Cpp2ILInjected.Address(RVA = "0xA09394", Offset = "0xA09394", Length = "0x8")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIInstance), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
	public GUIStatusMenu()
	{
		throw null;
	}

	// Token: 0x04001565 RID: 5477
	[global::Cpp2ILInjected.Token(Token = "0x4001A80")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
	private float scale0;

	// Token: 0x04001566 RID: 5478
	[global::Cpp2ILInjected.Token(Token = "0x4001A81")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
	private float scale1;

	// Token: 0x04001567 RID: 5479
	[global::Cpp2ILInjected.Token(Token = "0x4001A82")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
	private float scale2;
}
