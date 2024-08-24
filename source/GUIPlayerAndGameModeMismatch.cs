using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.Audio;
using Terraria.GameContent.UI;
using Terraria.Localization;
using UnityEngine;

// Token: 0x020001DA RID: 474
[global::Cpp2ILInjected.Token(Token = "0x2000275")]
public class GUIPlayerAndGameModeMismatch
{
	// Token: 0x06000CFD RID: 3325 RVA: 0x0002423C File Offset: 0x0002243C
	[global::Cpp2ILInjected.Token(Token = "0x6000E1C")]
	[global::Cpp2ILInjected.Address(RVA = "0x9F3B04", Offset = "0x9F3B04", Length = "0xCC")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIPlayerSelectMenu), Member = "Draw", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIPlayerSelectMenu), Member = "PlayerDraw", MemberParameters = new object[]
	{
		typeof(ItemGrid_Layout),
		typeof(int),
		typeof(Microsoft.Xna.Framework.Vector2),
		typeof(float)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIWorldSelectMenu), Member = "Draw", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIWorldSelectMenu), Member = "WorldDraw", MemberParameters = new object[]
	{
		typeof(ItemGrid_Layout),
		typeof(int),
		typeof(Microsoft.Xna.Framework.Vector2),
		typeof(float)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Language), Member = "GetTextValue", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
	public bool CheckMismatch(int playerGameMode, int worldGameMode)
	{
		throw null;
	}

	// Token: 0x06000CFE RID: 3326 RVA: 0x0002423F File Offset: 0x0002243F
	[global::Cpp2ILInjected.Token(Token = "0x6000E1D")]
	[global::Cpp2ILInjected.Address(RVA = "0x9F3BD0", Offset = "0x9F3BD0", Length = "0x1E0")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DrawMenu", MemberParameters = new object[] { typeof(GameTime) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerNavigationController), Member = "set_CurrentNavigationItem", MemberParameters = new object[] { typeof(GUIControllerItem) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerPlayerAndGameModeMistmatch), Member = "Activate", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPanel), Member = "Draw", MemberParameters = new object[]
	{
		typeof(Panel_Layout),
		typeof(bool),
		typeof(Microsoft.Xna.Framework.Graphics.Color?),
		typeof(Microsoft.Xna.Framework.Graphics.Color?),
		typeof(Microsoft.Xna.Framework.Graphics.Color?)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Language), Member = "GetTextValue", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
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
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPlayerAndGameModeMismatch), Member = "Back", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(KeyboardInput), Member = "GetKeyUp", MemberParameters = new object[] { typeof(KeyCode) }, ReturnType = typeof(bool))]
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
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
	public void Draw()
	{
		throw null;
	}

	// Token: 0x06000CFF RID: 3327 RVA: 0x00024242 File Offset: 0x00022442
	[global::Cpp2ILInjected.Token(Token = "0x6000E1E")]
	[global::Cpp2ILInjected.Address(RVA = "0x9F3DB0", Offset = "0x9F3DB0", Length = "0xE4")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIPlayerAndGameModeMismatch), Member = "Draw", ReturnType = typeof(void))]
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
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
	private void Back()
	{
		throw null;
	}

	// Token: 0x06000D00 RID: 3328 RVA: 0x00024245 File Offset: 0x00022445
	[global::Cpp2ILInjected.Token(Token = "0x6000E1F")]
	[global::Cpp2ILInjected.Address(RVA = "0x9F3E94", Offset = "0x9F3E94", Length = "0x60")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIInstance), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerPlayerAndGameModeMistmatch), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
	public GUIPlayerAndGameModeMismatch()
	{
		throw null;
	}

	// Token: 0x040014BB RID: 5307
	[global::Cpp2ILInjected.Token(Token = "0x40019C5")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
	public bool WarningDisplayed;

	// Token: 0x040014BC RID: 5308
	[global::Cpp2ILInjected.Token(Token = "0x40019C6")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
	private float statusScale;

	// Token: 0x040014BD RID: 5309
	[global::Cpp2ILInjected.Token(Token = "0x40019C7")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
	private float backScale;

	// Token: 0x040014BE RID: 5310
	[global::Cpp2ILInjected.Token(Token = "0x40019C8")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	private string messageText;

	// Token: 0x040014BF RID: 5311
	[global::Cpp2ILInjected.Token(Token = "0x40019C9")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
	private GUIControllerPlayerAndGameModeMistmatch _inputController;
}
