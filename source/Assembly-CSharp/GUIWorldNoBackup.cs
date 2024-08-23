using System;
using Controller;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.Audio;

// Token: 0x020001E9 RID: 489
[global::Cpp2ILInjected.Token(Token = "0x2000289")]
public class GUIWorldNoBackup
{
	// Token: 0x06000DD1 RID: 3537 RVA: 0x000244B8 File Offset: 0x000226B8
	[global::Cpp2ILInjected.Token(Token = "0x6000EF5")]
	[global::Cpp2ILInjected.Address(RVA = "0xA1C6A4", Offset = "0xA1C6A4", Length = "0x54")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "set_menuMode", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
	public void Open()
	{
		throw null;
	}

	// Token: 0x06000DD2 RID: 3538 RVA: 0x000244BB File Offset: 0x000226BB
	[global::Cpp2ILInjected.Token(Token = "0x6000EF6")]
	[global::Cpp2ILInjected.Address(RVA = "0xA1C6F8", Offset = "0xA1C6F8", Length = "0x224")]
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
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIStringButton), Member = "DrawButton", MemberParameters = new object[]
	{
		typeof(StringButton_Layout),
		typeof(string),
		typeof(ref float),
		typeof(bool),
		typeof(bool)
	}, ReturnType = typeof(bool))]
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
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
	public void Draw()
	{
		throw null;
	}

	// Token: 0x06000DD3 RID: 3539 RVA: 0x000244BE File Offset: 0x000226BE
	[global::Cpp2ILInjected.Token(Token = "0x6000EF7")]
	[global::Cpp2ILInjected.Address(RVA = "0xA1C91C", Offset = "0xA1C91C", Length = "0x18")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIInstance), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
	public GUIWorldNoBackup()
	{
		throw null;
	}

	// Token: 0x040015FC RID: 5628
	[global::Cpp2ILInjected.Token(Token = "0x4001B1A")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
	private float statusScale;

	// Token: 0x040015FD RID: 5629
	[global::Cpp2ILInjected.Token(Token = "0x4001B1B")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
	private float descriptionScale;

	// Token: 0x040015FE RID: 5630
	[global::Cpp2ILInjected.Token(Token = "0x4001B1C")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
	private float backScale;
}
