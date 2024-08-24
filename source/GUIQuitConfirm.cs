using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.Audio;
using UnityEngine;

// Token: 0x020001DF RID: 479
[global::Cpp2ILInjected.Token(Token = "0x200027C")]
public class GUIQuitConfirm
{
	// Token: 0x06000D47 RID: 3399 RVA: 0x0002431A File Offset: 0x0002251A
	[global::Cpp2ILInjected.Token(Token = "0x6000E66")]
	[global::Cpp2ILInjected.Address(RVA = "0x9FFE80", Offset = "0x9FFE80", Length = "0x54")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIMainMenu), Member = "Draw", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "set_menuMode", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
	public void Open()
	{
		throw null;
	}

	// Token: 0x06000D48 RID: 3400 RVA: 0x0002431D File Offset: 0x0002251D
	[global::Cpp2ILInjected.Token(Token = "0x6000E67")]
	[global::Cpp2ILInjected.Address(RVA = "0x9FFED4", Offset = "0x9FFED4", Length = "0x288")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DrawMenu", MemberParameters = new object[] { typeof(GameTime) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteBatch), Member = "End", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteBatch), Member = "Begin", MemberParameters = new object[]
	{
		typeof(SpriteSortMode),
		typeof(BlendState),
		typeof(SamplerState),
		typeof(DepthStencilState),
		typeof(RasterizerState),
		typeof(Effect),
		typeof(Matrix?),
		typeof(bool)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerNavigationController), Member = "set_CurrentNavigationItem", MemberParameters = new object[] { typeof(GUIControllerItem) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerModalResponse), Member = "Activate", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPanel), Member = "Draw", MemberParameters = new object[]
	{
		typeof(Panel_Layout),
		typeof(bool),
		typeof(Microsoft.Xna.Framework.Graphics.Color?),
		typeof(Microsoft.Xna.Framework.Graphics.Color?),
		typeof(Microsoft.Xna.Framework.Graphics.Color?)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIStringButton), Member = "DrawButton", MemberParameters = new object[]
	{
		typeof(StringButton_Layout),
		typeof(string),
		typeof(ref float),
		typeof(bool),
		typeof(bool)
	}, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUITransactionButton), Member = "Draw", MemberParameters = new object[]
	{
		typeof(TransactionButton_Layout),
		typeof(Item),
		typeof(string),
		typeof(bool),
		typeof(ref float),
		typeof(bool),
		typeof(bool),
		typeof(bool),
		typeof(bool)
	}, ReturnType = typeof(GUITransactionButton.InputState))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Application), Member = "Quit", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(KeyboardInput), Member = "GetKeyDown", MemberParameters = new object[] { typeof(KeyCode) }, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIQuitConfirm), Member = "Back", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
	public void Draw()
	{
		throw null;
	}

	// Token: 0x06000D49 RID: 3401 RVA: 0x00024320 File Offset: 0x00022520
	[global::Cpp2ILInjected.Token(Token = "0x6000E68")]
	[global::Cpp2ILInjected.Address(RVA = "0xA0015C", Offset = "0xA0015C", Length = "0x74")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIQuitConfirm), Member = "Draw", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
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
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
	private void Back()
	{
		throw null;
	}

	// Token: 0x06000D4A RID: 3402 RVA: 0x00024323 File Offset: 0x00022523
	[global::Cpp2ILInjected.Token(Token = "0x6000E69")]
	[global::Cpp2ILInjected.Address(RVA = "0xA001D0", Offset = "0xA001D0", Length = "0x68")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIInstance), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerModalResponse), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
	public GUIQuitConfirm()
	{
		throw null;
	}

	// Token: 0x04001530 RID: 5424
	[global::Cpp2ILInjected.Token(Token = "0x4001A49")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
	private float statusScale;

	// Token: 0x04001531 RID: 5425
	[global::Cpp2ILInjected.Token(Token = "0x4001A4A")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
	private float loadScale;

	// Token: 0x04001532 RID: 5426
	[global::Cpp2ILInjected.Token(Token = "0x4001A4B")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
	private float backScale;

	// Token: 0x04001533 RID: 5427
	[global::Cpp2ILInjected.Token(Token = "0x4001A4C")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C")]
	private float titleScale;

	// Token: 0x04001534 RID: 5428
	[global::Cpp2ILInjected.Token(Token = "0x4001A4D")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	private GUIControllerModalResponse _controller;
}
