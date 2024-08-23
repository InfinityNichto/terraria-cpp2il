using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.Audio;
using Terraria.Utilities;

// Token: 0x020001E7 RID: 487
[global::Cpp2ILInjected.Token(Token = "0x2000287")]
public class GUIWorldLoadBackup
{
	// Token: 0x06000DCC RID: 3532 RVA: 0x000244A9 File Offset: 0x000226A9
	[global::Cpp2ILInjected.Token(Token = "0x6000EF0")]
	[global::Cpp2ILInjected.Address(RVA = "0xA1BD90", Offset = "0xA1BD90", Length = "0x54")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "set_menuMode", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
	public void Open()
	{
		throw null;
	}

	// Token: 0x06000DCD RID: 3533 RVA: 0x000244AC File Offset: 0x000226AC
	[global::Cpp2ILInjected.Token(Token = "0x6000EF1")]
	[global::Cpp2ILInjected.Address(RVA = "0xA1BDE4", Offset = "0xA1BDE4", Length = "0x3DC")]
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
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_worldPathName", ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
	{
		typeof(string),
		typeof(string)
	}, ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FileUtilities), Member = "Exists", MemberParameters = new object[]
	{
		typeof(string),
		typeof(bool)
	}, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FileUtilities), Member = "Move", MemberParameters = new object[]
	{
		typeof(string),
		typeof(string),
		typeof(bool),
		typeof(bool)
	}, ReturnType = typeof(void))]
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
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WorldGen), Member = "playWorld", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 17)]
	public void Draw()
	{
		throw null;
	}

	// Token: 0x06000DCE RID: 3534 RVA: 0x000244AF File Offset: 0x000226AF
	[global::Cpp2ILInjected.Token(Token = "0x6000EF2")]
	[global::Cpp2ILInjected.Address(RVA = "0xA1C1C0", Offset = "0xA1C1C0", Length = "0x10")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIInstance), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
	public GUIWorldLoadBackup()
	{
		throw null;
	}

	// Token: 0x040015F5 RID: 5621
	[global::Cpp2ILInjected.Token(Token = "0x4001B13")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
	private float statusScale;

	// Token: 0x040015F6 RID: 5622
	[global::Cpp2ILInjected.Token(Token = "0x4001B14")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
	private float descriptionScale;

	// Token: 0x040015F7 RID: 5623
	[global::Cpp2ILInjected.Token(Token = "0x4001B15")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
	private float loadScale;

	// Token: 0x040015F8 RID: 5624
	[global::Cpp2ILInjected.Token(Token = "0x4001B16")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C")]
	private float backScale;
}
