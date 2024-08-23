using System;
using Controller;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.Audio;
using Terraria.IO;
using UnityEngine;

// Token: 0x020001CB RID: 459
[global::Cpp2ILInjected.Token(Token = "0x2000263")]
public class GUILowMemoryPopup
{
	// Token: 0x06000C95 RID: 3221 RVA: 0x00024104 File Offset: 0x00022304
	[global::Cpp2ILInjected.Token(Token = "0x6000DB2")]
	[global::Cpp2ILInjected.Address(RVA = "0x9E433C", Offset = "0x9E433C", Length = "0x58")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIMultiplayerLobby), Member = "JoinServerCheck", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIWorldCreateMenu), Member = "CreateWorldCheck", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIWorldSelectMenu), Member = "PlayWorldCheck", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldFile), Member = "RenameWorldCheck", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SystemInfo), Member = "get_systemMemorySize", ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	public void CheckMemoryAction(GUILowMemoryPopup.MemoryAction action, Action continueAction)
	{
		throw null;
	}

	// Token: 0x1700014F RID: 335
	// (get) Token: 0x06000C96 RID: 3222 RVA: 0x00024107 File Offset: 0x00022307
	[global::Cpp2ILInjected.Token(Token = "0x17000176")]
	public static long DeviceMemory
	{
		[global::Cpp2ILInjected.Token(Token = "0x6000DB3")]
		[global::Cpp2ILInjected.Address(RVA = "0x9E4394", Offset = "0x9E4394", Length = "0x18")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUISettingsOverlay), Member = "ResetSetting", MemberParameters = new object[] { typeof(GUISettingID) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TextureAtlasDB), Member = "get_DefaultTexturesHigh", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "LoadSettings", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileData), Member = "Allocate", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 7)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SystemInfo), Member = "get_systemMemorySize", ReturnType = typeof(int))]
		get
		{
			throw null;
		}
	}

	// Token: 0x06000C97 RID: 3223 RVA: 0x0002410A File Offset: 0x0002230A
	[global::Cpp2ILInjected.Token(Token = "0x6000DB4")]
	[global::Cpp2ILInjected.Address(RVA = "0x9E43AC", Offset = "0x9E43AC", Length = "0x3A0")]
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
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(KeyboardInput), Member = "GetKeyUp", MemberParameters = new object[] { typeof(KeyCode) }, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIKeyboardMappings), Member = "DisableEscapeKeyUsage", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 13)]
	public void Draw()
	{
		throw null;
	}

	// Token: 0x06000C98 RID: 3224 RVA: 0x0002410D File Offset: 0x0002230D
	[global::Cpp2ILInjected.Token(Token = "0x6000DB5")]
	[global::Cpp2ILInjected.Address(RVA = "0x9E474C", Offset = "0x9E474C", Length = "0x8")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIInstance), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
	public GUILowMemoryPopup()
	{
		throw null;
	}

	// Token: 0x04001457 RID: 5207
	[global::Cpp2ILInjected.Token(Token = "0x400194C")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
	public bool WarningDisplayed;

	// Token: 0x04001458 RID: 5208
	[global::Cpp2ILInjected.Token(Token = "0x400194D")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x11")]
	public bool DisableWarnings;

	// Token: 0x04001459 RID: 5209
	[global::Cpp2ILInjected.Token(Token = "0x400194E")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
	private GUILowMemoryPopup.MemoryAction CurrentWarning;

	// Token: 0x0400145A RID: 5210
	[global::Cpp2ILInjected.Token(Token = "0x400194F")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
	private Action ContinueCallback;

	// Token: 0x0400145B RID: 5211
	[global::Cpp2ILInjected.Token(Token = "0x4001950")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	private float scale0;

	// Token: 0x0400145C RID: 5212
	[global::Cpp2ILInjected.Token(Token = "0x4001951")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x24")]
	private float scale1;

	// Token: 0x0400145D RID: 5213
	[global::Cpp2ILInjected.Token(Token = "0x4001952")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
	private float scale2;

	// Token: 0x020007F9 RID: 2041
	[global::Cpp2ILInjected.Token(Token = "0x2000264")]
	public enum MemoryAction
	{
		// Token: 0x04007CC0 RID: 31936
		[global::Cpp2ILInjected.Token(Token = "0x4001954")]
		Host,
		// Token: 0x04007CC1 RID: 31937
		[global::Cpp2ILInjected.Token(Token = "0x4001955")]
		PlayLarge,
		// Token: 0x04007CC2 RID: 31938
		[global::Cpp2ILInjected.Token(Token = "0x4001956")]
		GenerateLarge
	}
}
