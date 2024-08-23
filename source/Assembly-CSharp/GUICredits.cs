using System;
using Controller;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Terraria;
using Terraria.Audio;
using UnityEngine;

// Token: 0x020001C2 RID: 450
[global::Cpp2ILInjected.Token(Token = "0x2000258")]
public class GUICredits
{
	// Token: 0x06000C4F RID: 3151 RVA: 0x00024032 File Offset: 0x00022232
	[global::Cpp2ILInjected.Token(Token = "0x6000D6B")]
	[global::Cpp2ILInjected.Address(RVA = "0x9DA7D4", Offset = "0x9DA7D4", Length = "0x194")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DrawMenu", MemberParameters = new object[] { typeof(GameTime) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUITransactionButton), Member = "DrawWithBanner", MemberParameters = new object[]
	{
		typeof(TransactionButton_Layout),
		typeof(GUIControlsBanner.ActionSource),
		typeof(ControllerActionButton),
		typeof(Item),
		typeof(string),
		typeof(bool),
		typeof(ref float),
		typeof(bool),
		typeof(bool),
		typeof(bool),
		typeof(bool),
		typeof(bool),
		typeof(bool)
	}, ReturnType = typeof(GUITransactionButton.InputState))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(KeyboardInput), Member = "GetKeyUp", MemberParameters = new object[] { typeof(KeyCode) }, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SoundEngine), Member = "PlaySound", MemberParameters = new object[]
	{
		typeof(int),
		typeof(int),
		typeof(int),
		typeof(int),
		typeof(float),
		typeof(float)
	}, ReturnType = typeof(SoundEffectInstance))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "set_menuMode", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
	public void Draw()
	{
		throw null;
	}

	// Token: 0x06000C50 RID: 3152 RVA: 0x00024035 File Offset: 0x00022235
	[global::Cpp2ILInjected.Token(Token = "0x6000D6C")]
	[global::Cpp2ILInjected.Address(RVA = "0x9DA968", Offset = "0x9DA968", Length = "0x8")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIInstance), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
	public GUICredits()
	{
		throw null;
	}

	// Token: 0x040013EC RID: 5100
	[global::Cpp2ILInjected.Token(Token = "0x40018DA")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
	private float scale0;

	// Token: 0x040013ED RID: 5101
	[global::Cpp2ILInjected.Token(Token = "0x40018DB")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
	private float scale1;

	// Token: 0x040013EE RID: 5102
	[global::Cpp2ILInjected.Token(Token = "0x40018DC")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
	private float scale2;

	// Token: 0x040013EF RID: 5103
	[global::Cpp2ILInjected.Token(Token = "0x40018DD")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	private DateTime updateTime;
}
