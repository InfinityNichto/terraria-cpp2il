using System;
using System.Collections.Generic;
using System.Globalization;
using Controller;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.Audio;
using Terraria.Graphics;
using Terraria.Initializers;
using Terraria.IO;
using Terraria.Localization;
using Terraria.Social.iOS;
using Terraria.Utilities;
using UnityEngine;

// Token: 0x020001EA RID: 490
[global::Cpp2ILInjected.Token(Token = "0x200028A")]
public class GUIWorldSelectMenu
{
	// Token: 0x1700015D RID: 349
	// (get) Token: 0x06000DD4 RID: 3540 RVA: 0x000244C1 File Offset: 0x000226C1
	[global::Cpp2ILInjected.Token(Token = "0x17000185")]
	private GUIContollerTransactionButtonList WorldListOptionsController
	{
		[global::Cpp2ILInjected.Token(Token = "0x6000EF8")]
		[global::Cpp2ILInjected.Address(RVA = "0xA1C934", Offset = "0xA1C934", Length = "0x118")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIContollerTransactionButtonList), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(bool),
			typeof(bool),
			typeof(TransactionButton_Layout[]),
			typeof(GUIContollerTransactionButtonList.SetupRegions)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		get
		{
			throw null;
		}
	}

	// Token: 0x06000DD5 RID: 3541 RVA: 0x000244C4 File Offset: 0x000226C4
	[global::Cpp2ILInjected.Token(Token = "0x6000EF9")]
	[global::Cpp2ILInjected.Address(RVA = "0xA1CA4C", Offset = "0xA1CA4C", Length = "0x1C4")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Initializers.AssetInitializer.<LoadAssetsWhileInInitialBlackScreen_InSteps>d__3", Member = "MoveNext", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AssetInitializer), Member = "LoadAssetsWhileInInitialBlackScreen", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ContentManager), Member = "Load", MemberTypeParameters = new object[] { "T1" }, MemberParameters = new object[] { typeof(string) }, ReturnType = "T1")]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
	public static void LoadContent(ContentManager content)
	{
		throw null;
	}

	// Token: 0x06000DD6 RID: 3542 RVA: 0x000244C7 File Offset: 0x000226C7
	[global::Cpp2ILInjected.Token(Token = "0x6000EFA")]
	[global::Cpp2ILInjected.Address(RVA = "0xA1CC10", Offset = "0xA1CC10", Length = "0x190")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIWorldSelectMenu), Member = "DrawWorld", MemberParameters = new object[] { typeof(WorldFileData) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnifiedRandom), Member = "Next", MemberParameters = new object[]
	{
		typeof(int),
		typeof(int)
	}, ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnifiedRandom), Member = "Next", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "Frame", MemberParameters = new object[]
	{
		typeof(Microsoft.Xna.Framework.Graphics.Texture2D),
		typeof(int),
		typeof(int),
		typeof(int),
		typeof(int),
		typeof(int),
		typeof(int)
	}, ReturnType = typeof(Rectangle))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
	private Rectangle UpdateGlitchAnimation(WorldFileData worldData)
	{
		throw null;
	}

	// Token: 0x06000DD7 RID: 3543 RVA: 0x000244CA File Offset: 0x000226CA
	[global::Cpp2ILInjected.Token(Token = "0x6000EFB")]
	[global::Cpp2ILInjected.Address(RVA = "0xA1CDA0", Offset = "0xA1CDA0", Length = "0x274")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIWorldSelectMenu), Member = "DrawWorld", MemberParameters = new object[] { typeof(WorldFileData) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TextureManager), Member = "Load", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(Microsoft.Xna.Framework.Graphics.Texture2D))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
	{
		typeof(string),
		typeof(string),
		typeof(string)
	}, ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 17)]
	private Microsoft.Xna.Framework.Graphics.Texture2D GetIcon(WorldFileData worldData)
	{
		throw null;
	}

	// Token: 0x06000DD8 RID: 3544 RVA: 0x000244CD File Offset: 0x000226CD
	[global::Cpp2ILInjected.Token(Token = "0x6000EFC")]
	[global::Cpp2ILInjected.Address(RVA = "0xA1D014", Offset = "0xA1D014", Length = "0x110")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
	{
		typeof(string),
		typeof(string),
		typeof(string),
		typeof(string)
	}, ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TextureManager), Member = "Load", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(Microsoft.Xna.Framework.Graphics.Texture2D))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
	private Microsoft.Xna.Framework.Graphics.Texture2D GetSeedIcon(WorldFileData worldData, string seed)
	{
		throw null;
	}

	// Token: 0x06000DD9 RID: 3545 RVA: 0x000244D0 File Offset: 0x000226D0
	[global::Cpp2ILInjected.Token(Token = "0x6000EFD")]
	[global::Cpp2ILInjected.Address(RVA = "0xA1D124", Offset = "0xA1D124", Length = "0xF0")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Action), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(object),
		typeof(IntPtr)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUILowMemoryPopup), Member = "CheckMemoryAction", MemberParameters = new object[]
	{
		typeof(GUILowMemoryPopup.MemoryAction),
		typeof(Action)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
	private void PlayWorldCheck()
	{
		throw null;
	}

	// Token: 0x06000DDA RID: 3546 RVA: 0x000244D3 File Offset: 0x000226D3
	[global::Cpp2ILInjected.Token(Token = "0x6000EFE")]
	[global::Cpp2ILInjected.Address(RVA = "0xA1D320", Offset = "0xA1D320", Length = "0x110")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "set_menuMode", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_ActivePlayerFileData", ReturnType = typeof(PlayerFileData))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "set_GameMode", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIWorldCreateMenu), Member = "GenerateSeed", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIWorldCreateMenu), Member = "GenerateName", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
	public void ActionNew()
	{
		throw null;
	}

	// Token: 0x06000DDB RID: 3547 RVA: 0x000244D6 File Offset: 0x000226D6
	[global::Cpp2ILInjected.Token(Token = "0x6000EFF")]
	[global::Cpp2ILInjected.Address(RVA = "0xA1D430", Offset = "0xA1D430", Length = "0x168")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIWorldSelectMenu), Member = "Draw", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteBatchItem), Member = "EnableClipping", MemberParameters = new object[]
	{
		typeof(Rectangle),
		typeof(Rectangle),
		typeof(SpriteBatch),
		typeof(bool)
	}, ReturnType = typeof(void))]
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
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteBatchItem), Member = "DisabledClipping", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
	private bool DrawMenuButton(string label, TransactionButton_Layout buttonLayout, ref float scale, bool disabled)
	{
		throw null;
	}

	// Token: 0x06000DDC RID: 3548 RVA: 0x000244D9 File Offset: 0x000226D9
	[global::Cpp2ILInjected.Token(Token = "0x6000F00")]
	[global::Cpp2ILInjected.Address(RVA = "0xA1D598", Offset = "0xA1D598", Length = "0x58")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
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
	private bool DrawMenuButton(ControllerActionButton action, string label, TransactionButton_Layout buttonLayout, ref float scale, bool disabled)
	{
		throw null;
	}

	// Token: 0x06000DDD RID: 3549 RVA: 0x000244DC File Offset: 0x000226DC
	[global::Cpp2ILInjected.Token(Token = "0x6000F01")]
	[global::Cpp2ILInjected.Address(RVA = "0xA1D5F0", Offset = "0xA1D5F0", Length = "0x74")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	public Microsoft.Xna.Framework.Vector2 ItemSize(int index)
	{
		throw null;
	}

	// Token: 0x06000DDE RID: 3550 RVA: 0x000244DF File Offset: 0x000226DF
	[global::Cpp2ILInjected.Token(Token = "0x6000F02")]
	[global::Cpp2ILInjected.Address(RVA = "0xA1D664", Offset = "0xA1D664", Length = "0x238")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIWorldSelectMenu), Member = "Draw", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIString), Member = "Draw", MemberParameters = new object[]
	{
		typeof(String_Layout),
		typeof(string)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "Frame", MemberParameters = new object[]
	{
		typeof(Microsoft.Xna.Framework.Graphics.Texture2D),
		typeof(int),
		typeof(int),
		typeof(int),
		typeof(int),
		typeof(int),
		typeof(int)
	}, ReturnType = typeof(Rectangle))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIButton), Member = "Draw", MemberParameters = new object[]
	{
		typeof(Button_Layout),
		typeof(Rectangle),
		typeof(Microsoft.Xna.Framework.Graphics.Texture2D),
		typeof(Microsoft.Xna.Framework.Graphics.Color?),
		typeof(float?)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 14)]
	private void DrawWorldSync()
	{
		throw null;
	}

	// Token: 0x06000DDF RID: 3551 RVA: 0x000244E2 File Offset: 0x000226E2
	[global::Cpp2ILInjected.Token(Token = "0x6000F03")]
	[global::Cpp2ILInjected.Address(RVA = "0xA1D89C", Offset = "0xA1D89C", Length = "0x294")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "worldGenCallback", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CacheFileManager), Member = "CleanPath", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WorldFileData), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Equality", MemberParameters = new object[]
	{
		typeof(string),
		typeof(string)
	}, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SoundEngine), Member = "PlaySound", MemberParameters = new object[]
	{
		typeof(int),
		typeof(int),
		typeof(int),
		typeof(int),
		typeof(float),
		typeof(float)
	}, ReturnType = typeof(SoundEffectInstance))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FileData), Member = "SetFavorite", MemberParameters = new object[]
	{
		typeof(bool),
		typeof(bool)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Comparison<object>), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(object),
		typeof(IntPtr)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "Sort", MemberParameters = new object[] { typeof(Comparison<object>) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 12)]
	public void SelectAndHighlight(WorldFileData worldDataOld)
	{
		throw null;
	}

	// Token: 0x06000DE0 RID: 3552 RVA: 0x000244E5 File Offset: 0x000226E5
	[global::Cpp2ILInjected.Token(Token = "0x6000F04")]
	[global::Cpp2ILInjected.Address(RVA = "0xA1DB30", Offset = "0xA1DB30", Length = "0x8C")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIWorldSelectMenu), Member = "Draw", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIMenuNameEdit), Member = "Enable", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
	private void OpenNameEdit()
	{
		throw null;
	}

	// Token: 0x06000DE1 RID: 3553 RVA: 0x000244E8 File Offset: 0x000226E8
	[global::Cpp2ILInjected.Token(Token = "0x6000F05")]
	[global::Cpp2ILInjected.Address(RVA = "0xA1DBBC", Offset = "0xA1DBBC", Length = "0x1D8")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIWorldSelectMenu), Member = "Draw", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIWorldSelectMenu), Member = "WorldDraw", MemberParameters = new object[]
	{
		typeof(ItemGrid_Layout),
		typeof(int),
		typeof(Microsoft.Xna.Framework.Vector2),
		typeof(float)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SoundEngine), Member = "PlaySound", MemberParameters = new object[]
	{
		typeof(int),
		typeof(int),
		typeof(int),
		typeof(int),
		typeof(float),
		typeof(float)
	}, ReturnType = typeof(SoundEffectInstance))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIWorldSelectMenu), Member = "CloseNameEdit", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Trim", ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WorldFile), Member = "RenameWorldUsingLoadAndSave", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WorldFile), Member = "RenameWorld", MemberParameters = new object[]
	{
		typeof(string),
		typeof(bool)
	}, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
	private void CloseNameEditAndSaveIf()
	{
		throw null;
	}

	// Token: 0x06000DE2 RID: 3554 RVA: 0x000244EB File Offset: 0x000226EB
	[global::Cpp2ILInjected.Token(Token = "0x6000F06")]
	[global::Cpp2ILInjected.Address(RVA = "0xA1DDE8", Offset = "0xA1DDE8", Length = "0x60")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIWorldSelectMenu), Member = "Draw", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIWorldSelectMenu), Member = "Back", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIWorldSelectMenu), Member = "WorldDraw", MemberParameters = new object[]
	{
		typeof(ItemGrid_Layout),
		typeof(int),
		typeof(Microsoft.Xna.Framework.Vector2),
		typeof(float)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 7)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIWorldSelectMenu), Member = "CloseNameEdit", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	private void CloseNameEditIf()
	{
		throw null;
	}

	// Token: 0x06000DE3 RID: 3555 RVA: 0x000244EE File Offset: 0x000226EE
	[global::Cpp2ILInjected.Token(Token = "0x6000F07")]
	[global::Cpp2ILInjected.Address(RVA = "0xA1DD94", Offset = "0xA1DD94", Length = "0x54")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIWorldSelectMenu), Member = "CloseNameEditAndSaveIf", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIWorldSelectMenu), Member = "CloseNameEditIf", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIWorldSelectMenu), Member = "WorldDraw", MemberParameters = new object[]
	{
		typeof(ItemGrid_Layout),
		typeof(int),
		typeof(Microsoft.Xna.Framework.Vector2),
		typeof(float)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIMenuNameEdit), Member = "set_Enabled", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	private void CloseNameEdit()
	{
		throw null;
	}

	// Token: 0x06000DE4 RID: 3556 RVA: 0x000244F1 File Offset: 0x000226F1
	[global::Cpp2ILInjected.Token(Token = "0x6000F08")]
	[global::Cpp2ILInjected.Address(RVA = "0xA1DE48", Offset = "0xA1DE48", Length = "0x1038")]
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
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPanel), Member = "Draw", MemberParameters = new object[]
	{
		typeof(Panel_Layout),
		typeof(bool),
		typeof(Microsoft.Xna.Framework.Graphics.Color?),
		typeof(Microsoft.Xna.Framework.Graphics.Color?),
		typeof(Microsoft.Xna.Framework.Graphics.Color?)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerNavigationController), Member = "set_CurrentNavigationItem", MemberParameters = new object[] { typeof(GUIControllerItem) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerNavigationController), Member = "UpdateCursorPosition", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LayoutCalculator), Member = "GetAnchoredPosition", MemberParameters = new object[]
	{
		typeof(ControlAnchor.ControlId),
		typeof(LayoutCalculator.AnchorType),
		typeof(Microsoft.Xna.Framework.Vector2)
	}, ReturnType = typeof(Microsoft.Xna.Framework.Vector2))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Microsoft.Xna.Framework.Vector2), Member = "op_Division", MemberParameters = new object[]
	{
		typeof(Microsoft.Xna.Framework.Vector2),
		typeof(float)
	}, ReturnType = typeof(Microsoft.Xna.Framework.Vector2))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Microsoft.Xna.Framework.Vector2), Member = "op_Subtraction", MemberParameters = new object[]
	{
		typeof(Microsoft.Xna.Framework.Vector2),
		typeof(Microsoft.Xna.Framework.Vector2)
	}, ReturnType = typeof(Microsoft.Xna.Framework.Vector2))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIItemGrid.GetItemScaleHandler), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(object),
		typeof(IntPtr)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIItemGrid.CursorOver), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(object),
		typeof(IntPtr)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIItemGrid.DrawItemHandler), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(object),
		typeof(IntPtr)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIItemGrid.GetItemSizeHandler), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(object),
		typeof(IntPtr)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIDraggableItemGrid), Member = "Draw", MemberParameters = new object[]
	{
		typeof(DraggableItemGrid_Layout),
		typeof(GUIItemGrid.GetItemScaleHandler),
		typeof(GUIItemGrid.CursorOver),
		typeof(GUIItemGrid.DrawItemHandler),
		typeof(int),
		typeof(ref float),
		typeof(ref float),
		typeof(ref int),
		typeof(ref Microsoft.Xna.Framework.Vector2),
		typeof(GUIItemGrid.GetItemSizeHandler),
		typeof(bool),
		typeof(bool),
		typeof(bool)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIWorldSelectMenu), Member = "DrawWorldSync", ReturnType = typeof(void))]
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
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIWorldSelectMenu), Member = "Back", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WorldSelectMenu_Layout), Member = "get_PlatformMaxWorlds", ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Language), Member = "GetTextValue", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIWorldSelectMenu), Member = "CloseNameEditIf", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SoundEngine), Member = "PlaySound", MemberParameters = new object[]
	{
		typeof(int),
		typeof(int),
		typeof(int),
		typeof(int),
		typeof(float),
		typeof(float)
	}, ReturnType = typeof(SoundEffectInstance))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Action), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(object),
		typeof(IntPtr)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUILowDiskSpacePopup), Member = "CheckDiskSpace", MemberParameters = new object[] { typeof(Action) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIWorldSelectMenu), Member = "DrawMenuButton", MemberParameters = new object[]
	{
		typeof(string),
		typeof(TransactionButton_Layout),
		typeof(ref float),
		typeof(bool)
	}, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIWorldSelectMenu), Member = "CloseNameEditAndSaveIf", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIWorldSelectMenu), Member = "CanWorldBePlayed", MemberParameters = new object[] { typeof(WorldFileData) }, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_ActivePlayerFileData", ReturnType = typeof(PlayerFileData))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPlayerAndGameModeMismatch), Member = "CheckMismatch", MemberParameters = new object[]
	{
		typeof(int),
		typeof(int)
	}, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "set_menuMode", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FileData), Member = "ToggleFavorite", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Comparison<object>), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(object),
		typeof(IntPtr)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "Sort", MemberParameters = new object[] { typeof(Comparison<object>) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Equality", MemberParameters = new object[]
	{
		typeof(string),
		typeof(string)
	}, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerWorldSelect), Member = "Activate", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIWorldSelectMenu), Member = "OpenNameEdit", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WorldFileData), Member = "get_HasValidSeed", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIStringButton), Member = "DrawButton", MemberParameters = new object[]
	{
		typeof(StringButton_Layout),
		typeof(string),
		typeof(ref float),
		typeof(bool),
		typeof(bool)
	}, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CloudSocialModule), Member = "IsAvailable", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CloudSocialModule), Member = "IsRequired", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControllerActionButton), Member = "get_RequiredState", ReturnType = typeof(ControllerActionButton.RequiredButtonState))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CloudSocialModule), Member = "IsConnected", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 56)]
	public void Draw()
	{
		throw null;
	}

	// Token: 0x06000DE5 RID: 3557 RVA: 0x000244F4 File Offset: 0x000226F4
	[global::Cpp2ILInjected.Token(Token = "0x6000F09")]
	[global::Cpp2ILInjected.Address(RVA = "0xA1B518", Offset = "0xA1B518", Length = "0x144")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIWorldSelectMenu), Member = "Draw", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIWorldSelectMenu), Member = "CloseNameEditIf", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerNavigationController), Member = "set_CurrentNavigationItem", MemberParameters = new object[] { typeof(GUIControllerItem) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SoundEngine), Member = "PlaySound", MemberParameters = new object[]
	{
		typeof(int),
		typeof(int),
		typeof(int),
		typeof(int),
		typeof(float),
		typeof(float)
	}, ReturnType = typeof(SoundEffectInstance))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DrPlatform), Member = "get_CurrentPlatform", ReturnType = typeof(DrPlatform.DrPlatformType))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "set_menuMode", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIMultiplayerLobby), Member = "Startup", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
	public void Back()
	{
		throw null;
	}

	// Token: 0x06000DE6 RID: 3558 RVA: 0x000244F7 File Offset: 0x000226F7
	[global::Cpp2ILInjected.Token(Token = "0x6000F0A")]
	[global::Cpp2ILInjected.Address(RVA = "0xA1EF24", Offset = "0xA1EF24", Length = "0x230")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIWorldSelectMenu), Member = "WorldDraw", MemberParameters = new object[]
	{
		typeof(ItemGrid_Layout),
		typeof(int),
		typeof(Microsoft.Xna.Framework.Vector2),
		typeof(float)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LayoutCalculator), Member = "GetAnchoredPosition", MemberParameters = new object[]
	{
		typeof(ControlAnchor.ControlId),
		typeof(LayoutCalculator.AnchorType),
		typeof(Microsoft.Xna.Framework.Vector2)
	}, ReturnType = typeof(Microsoft.Xna.Framework.Vector2))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Microsoft.Xna.Framework.Vector2), Member = "op_Division", MemberParameters = new object[]
	{
		typeof(Microsoft.Xna.Framework.Vector2),
		typeof(float)
	}, ReturnType = typeof(Microsoft.Xna.Framework.Vector2))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Microsoft.Xna.Framework.Vector2), Member = "op_Subtraction", MemberParameters = new object[]
	{
		typeof(Microsoft.Xna.Framework.Vector2),
		typeof(Microsoft.Xna.Framework.Vector2)
	}, ReturnType = typeof(Microsoft.Xna.Framework.Vector2))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIWorldSelectMenu), Member = "GetIcon", MemberParameters = new object[] { typeof(WorldFileData) }, ReturnType = typeof(Microsoft.Xna.Framework.Graphics.Texture2D))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIWorldSelectMenu), Member = "UpdateGlitchAnimation", MemberParameters = new object[] { typeof(WorldFileData) }, ReturnType = typeof(Rectangle))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "Frame", MemberParameters = new object[]
	{
		typeof(Microsoft.Xna.Framework.Graphics.Texture2D),
		typeof(int),
		typeof(int),
		typeof(int),
		typeof(int),
		typeof(int),
		typeof(int)
	}, ReturnType = typeof(Rectangle))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle?), Member = ".ctor", MemberParameters = new object[] { typeof(Rectangle) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPanel), Member = "DrawBacking", MemberParameters = new object[]
	{
		typeof(Microsoft.Xna.Framework.Vector2),
		typeof(Microsoft.Xna.Framework.Vector2),
		typeof(Microsoft.Xna.Framework.Graphics.Texture2D),
		typeof(Microsoft.Xna.Framework.Graphics.Color),
		typeof(Rectangle?)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
	private void DrawWorld(WorldFileData worldData)
	{
		throw null;
	}

	// Token: 0x06000DE7 RID: 3559 RVA: 0x000244FA File Offset: 0x000226FA
	[global::Cpp2ILInjected.Token(Token = "0x6000F0B")]
	[global::Cpp2ILInjected.Address(RVA = "0xA1F154", Offset = "0xA1F154", Length = "0x11CC")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(int),
		typeof(int),
		typeof(int),
		typeof(int)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControlAnchor), Member = "SetGridItemRegion", MemberParameters = new object[] { typeof(Rectangle) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPanel), Member = "DrawAtPosition", MemberParameters = new object[]
	{
		typeof(Panel_Layout),
		typeof(Microsoft.Xna.Framework.Vector2),
		typeof(Microsoft.Xna.Framework.Vector2),
		typeof(bool)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPanel), Member = "Draw", MemberParameters = new object[]
	{
		typeof(Panel_Layout),
		typeof(bool),
		typeof(Microsoft.Xna.Framework.Graphics.Color?),
		typeof(Microsoft.Xna.Framework.Graphics.Color?),
		typeof(Microsoft.Xna.Framework.Graphics.Color?)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIButton), Member = "Draw", MemberParameters = new object[]
	{
		typeof(Button_Layout),
		typeof(Microsoft.Xna.Framework.Graphics.Texture2D),
		typeof(Microsoft.Xna.Framework.Graphics.Color?),
		typeof(float?)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CloudSocialModule), Member = "IsAvailable", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIWorldSelectMenu), Member = "DrawWorld", MemberParameters = new object[] { typeof(WorldFileData) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIWorldSelectMenu), Member = "CloseNameEditIf", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControlAnchor), Member = "GetControlRegion", MemberParameters = new object[] { typeof(ControlAnchor.ControlId) }, ReturnType = typeof(Rectangle))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIMenuNameEdit), Member = "GetInputText", MemberParameters = new object[]
	{
		typeof(Rectangle),
		typeof(int)
	}, ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIString), Member = "Draw", MemberParameters = new object[]
	{
		typeof(String_Layout),
		typeof(string)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIString), Member = "Draw", MemberParameters = new object[]
	{
		typeof(String_Layout),
		typeof(string),
		typeof(Microsoft.Xna.Framework.Graphics.Color),
		typeof(bool)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTimeFormatInfo), Member = "get_CurrentInfo", ReturnType = typeof(DateTimeFormatInfo))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTime), Member = "ToString", MemberParameters = new object[]
	{
		typeof(string),
		typeof(IFormatProvider)
	}, ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Language), Member = "GetTextValue", MemberParameters = new object[]
	{
		typeof(string),
		typeof(object)
	}, ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WorldFileData), Member = "get_WorldSizeName", ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Language), Member = "GetTextValue", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Microsoft.Xna.Framework.Graphics.Color), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(int),
		typeof(int),
		typeof(int)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIWorldSelectMenu), Member = "CloseNameEdit", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WorldFileData), Member = "get_HasValidSeed", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WorldFileData), Member = "GetFullSeedText", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
	{
		typeof(string),
		typeof(string),
		typeof(string)
	}, ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIWorldSelectMenu), Member = "CanWorldBePlayed", MemberParameters = new object[] { typeof(WorldFileData) }, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUITransactionButton), Member = "GetPickRegion", MemberParameters = new object[] { typeof(TransactionButton_Layout) }, ReturnType = typeof(Rectangle))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_mouseX", ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_mouseY", ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle), Member = "Contains", MemberParameters = new object[]
	{
		typeof(int),
		typeof(int)
	}, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_screenWidth", ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_screenHeight", ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIInputRegionManager), Member = "RegisterInputRegion", MemberParameters = new object[]
	{
		typeof(int),
		typeof(int),
		typeof(int),
		typeof(int)
	}, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIInputRegionManager), Member = "RegisterInputRegion", MemberParameters = new object[] { typeof(Rectangle) }, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_mouseLeft", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_mouseLeftRelease", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTime), Member = "op_Equality", MemberParameters = new object[]
	{
		typeof(DateTime),
		typeof(DateTime)
	}, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTime), Member = "get_Now", ReturnType = typeof(DateTime))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Microsoft.Xna.Framework.Vector2), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(float),
		typeof(float)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTime), Member = "op_GreaterThan", MemberParameters = new object[]
	{
		typeof(DateTime),
		typeof(DateTime)
	}, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Microsoft.Xna.Framework.Vector2), Member = "Distance", MemberParameters = new object[]
	{
		typeof(Microsoft.Xna.Framework.Vector2),
		typeof(Microsoft.Xna.Framework.Vector2)
	}, ReturnType = typeof(float))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTime), Member = "op_Subtraction", MemberParameters = new object[]
	{
		typeof(DateTime),
		typeof(DateTime)
	}, ReturnType = typeof(TimeSpan))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TimeSpan), Member = "get_TotalMilliseconds", ReturnType = typeof(double))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerNavigationController), Member = "set_CurrentNavigationItem", MemberParameters = new object[] { typeof(GUIControllerItem) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SoundEngine), Member = "PlaySound", MemberParameters = new object[]
	{
		typeof(int),
		typeof(int),
		typeof(int),
		typeof(int),
		typeof(float),
		typeof(float)
	}, ReturnType = typeof(SoundEffectInstance))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIWorldSelectMenu), Member = "CloseNameEditAndSaveIf", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Action), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(object),
		typeof(IntPtr)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUILowDiskSpacePopup), Member = "CheckDiskSpace", MemberParameters = new object[] { typeof(Action) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerNavigationController), Member = "UpdateCursorPosition", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_ActivePlayerFileData", ReturnType = typeof(PlayerFileData))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPlayerAndGameModeMismatch), Member = "CheckMismatch", MemberParameters = new object[]
	{
		typeof(int),
		typeof(int)
	}, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 72)]
	private void WorldDraw(ItemGrid_Layout gridLayout, int index, Microsoft.Xna.Framework.Vector2 position, float scale)
	{
		throw null;
	}

	// Token: 0x06000DE8 RID: 3560 RVA: 0x000244FD File Offset: 0x000226FD
	[global::Cpp2ILInjected.Token(Token = "0x6000F0C")]
	[global::Cpp2ILInjected.Address(RVA = "0xA1D214", Offset = "0xA1D214", Length = "0x10C")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "set_menuMode", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DrPlatform), Member = "get_CurrentPlatform", ReturnType = typeof(DrPlatform.DrPlatformType))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIMultiplayerHost), Member = "HostServer", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WorldGen), Member = "playWorld", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
	private void PlayWorld()
	{
		throw null;
	}

	// Token: 0x06000DE9 RID: 3561 RVA: 0x00024500 File Offset: 0x00022700
	[global::Cpp2ILInjected.Token(Token = "0x6000F0D")]
	[global::Cpp2ILInjected.Address(RVA = "0xA20320", Offset = "0xA20320", Length = "0x1BC")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "LoadWorlds", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new object[]
	{
		typeof(Array),
		typeof(int),
		typeof(int)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "AddRange", MemberParameters = new object[] { typeof(IEnumerable<object>) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Comparison<object>), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(object),
		typeof(IntPtr)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "Sort", MemberParameters = new object[] { typeof(Comparison<object>) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WorldSelectMenu_Layout), Member = "get_PlatformMaxWorlds", ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Math), Member = "Min", MemberParameters = new object[]
	{
		typeof(int),
		typeof(int)
	}, ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 12)]
	public void SortWorlds()
	{
		throw null;
	}

	// Token: 0x06000DEA RID: 3562 RVA: 0x00024503 File Offset: 0x00022703
	[global::Cpp2ILInjected.Token(Token = "0x6000F0E")]
	[global::Cpp2ILInjected.Address(RVA = "0xA204DC", Offset = "0xA204DC", Length = "0xD4")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIWorldSelectMenu), Member = "CanWorldBePlayed", MemberParameters = new object[] { typeof(WorldFileData) }, ReturnType = typeof(bool))]
	private int SortEntry(WorldFileData a, WorldFileData b)
	{
		throw null;
	}

	// Token: 0x06000DEB RID: 3563 RVA: 0x00024506 File Offset: 0x00022706
	[global::Cpp2ILInjected.Token(Token = "0x6000F0F")]
	[global::Cpp2ILInjected.Address(RVA = "0xA1EE80", Offset = "0xA1EE80", Length = "0xA4")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIWorldSelectMenu), Member = "Draw", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIWorldSelectMenu), Member = "WorldDraw", MemberParameters = new object[]
	{
		typeof(ItemGrid_Layout),
		typeof(int),
		typeof(Microsoft.Xna.Framework.Vector2),
		typeof(float)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIWorldSelectMenu), Member = "SortEntry", MemberParameters = new object[]
	{
		typeof(WorldFileData),
		typeof(WorldFileData)
	}, ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 11)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_ActivePlayerFileData", ReturnType = typeof(PlayerFileData))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
	private bool CanWorldBePlayed(WorldFileData world)
	{
		throw null;
	}

	// Token: 0x06000DEC RID: 3564 RVA: 0x00024509 File Offset: 0x00022709
	[global::Cpp2ILInjected.Token(Token = "0x6000F10")]
	[global::Cpp2ILInjected.Address(RVA = "0xA20624", Offset = "0xA20624", Length = "0x8")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	private float WorldScale(int index)
	{
		throw null;
	}

	// Token: 0x06000DED RID: 3565 RVA: 0x0002450C File Offset: 0x0002270C
	[global::Cpp2ILInjected.Token(Token = "0x6000F11")]
	[global::Cpp2ILInjected.Address(RVA = "0xA2062C", Offset = "0xA2062C", Length = "0xC0")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_mouseLeft", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_mouseLeftRelease", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
	private void WorldOver(int index)
	{
		throw null;
	}

	// Token: 0x06000DEE RID: 3566 RVA: 0x0002450F File Offset: 0x0002270F
	[global::Cpp2ILInjected.Token(Token = "0x6000F12")]
	[global::Cpp2ILInjected.Address(RVA = "0xA205B0", Offset = "0xA205B0", Length = "0x74")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureInfo), Member = "get_CurrentCulture", ReturnType = typeof(CultureInfo))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIWorldSelectMenu), Member = "CompareNatural", MemberParameters = new object[]
	{
		typeof(string),
		typeof(string),
		typeof(CultureInfo),
		typeof(CompareOptions)
	}, ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
	public int CompareNatural(string strA, string strB)
	{
		throw null;
	}

	// Token: 0x06000DEF RID: 3567 RVA: 0x00024512 File Offset: 0x00022712
	[global::Cpp2ILInjected.Token(Token = "0x6000F13")]
	[global::Cpp2ILInjected.Address(RVA = "0xA206EC", Offset = "0xA206EC", Length = "0x794")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIWorldSelectMenu), Member = "CompareNatural", MemberParameters = new object[]
	{
		typeof(string),
		typeof(string)
	}, ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(char))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(char), Member = "IsDigit", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(char), Member = "GetNumericValue", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(double))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Substring", MemberParameters = new object[]
	{
		typeof(int),
		typeof(int)
	}, ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
	{
		typeof(string),
		typeof(string)
	}, ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 12)]
	public int CompareNatural(string strA, string strB, CultureInfo culture, CompareOptions options)
	{
		throw null;
	}

	// Token: 0x06000DF0 RID: 3568 RVA: 0x00024515 File Offset: 0x00022715
	[global::Cpp2ILInjected.Token(Token = "0x6000F14")]
	[global::Cpp2ILInjected.Address(RVA = "0xA20E80", Offset = "0xA20E80", Length = "0x18C")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIInstance), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerWorldSelect), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 12)]
	public GUIWorldSelectMenu()
	{
		throw null;
	}

	// Token: 0x040015FF RID: 5631
	[global::Cpp2ILInjected.Token(Token = "0x4001B1D")]
	private const double DOUBLE_CLICK_TIME = 500.0;

	// Token: 0x04001600 RID: 5632
	[global::Cpp2ILInjected.Token(Token = "0x4001B1E")]
	private const double SINGLE_CLICK_TIME = 350.0;

	// Token: 0x04001601 RID: 5633
	[global::Cpp2ILInjected.Token(Token = "0x4001B1F")]
	private const float SINGLE_CLICK_DISTANCE = 30f;

	// Token: 0x04001602 RID: 5634
	[global::Cpp2ILInjected.Token(Token = "0x4001B20")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
	private float TitleScale;

	// Token: 0x04001603 RID: 5635
	[global::Cpp2ILInjected.Token(Token = "0x4001B21")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
	private float BackScale;

	// Token: 0x04001604 RID: 5636
	[global::Cpp2ILInjected.Token(Token = "0x4001B22")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
	private float NewScale;

	// Token: 0x04001605 RID: 5637
	[global::Cpp2ILInjected.Token(Token = "0x4001B23")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C")]
	private float PlayScale;

	// Token: 0x04001606 RID: 5638
	[global::Cpp2ILInjected.Token(Token = "0x4001B24")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	private float DeleteScale;

	// Token: 0x04001607 RID: 5639
	[global::Cpp2ILInjected.Token(Token = "0x4001B25")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x24")]
	private float FavoriteScale;

	// Token: 0x04001608 RID: 5640
	[global::Cpp2ILInjected.Token(Token = "0x4001B26")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
	private float OptionsScale;

	// Token: 0x04001609 RID: 5641
	[global::Cpp2ILInjected.Token(Token = "0x4001B27")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x2C")]
	private float RenameScale;

	// Token: 0x0400160A RID: 5642
	[global::Cpp2ILInjected.Token(Token = "0x4001B28")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
	private float SeedDisplayScale;

	// Token: 0x0400160B RID: 5643
	[global::Cpp2ILInjected.Token(Token = "0x4001B29")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x34")]
	public float ScrollOffset;

	// Token: 0x0400160C RID: 5644
	[global::Cpp2ILInjected.Token(Token = "0x4001B2A")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
	private float ScrollMomentum;

	// Token: 0x0400160D RID: 5645
	[global::Cpp2ILInjected.Token(Token = "0x4001B2B")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x3C")]
	private int ScrollDragging;

	// Token: 0x0400160E RID: 5646
	[global::Cpp2ILInjected.Token(Token = "0x4001B2C")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
	private Microsoft.Xna.Framework.Vector2 DragOffset;

	// Token: 0x0400160F RID: 5647
	[global::Cpp2ILInjected.Token(Token = "0x4001B2D")]
	public static Microsoft.Xna.Framework.Graphics.Texture2D _dividerTexture;

	// Token: 0x04001610 RID: 5648
	[global::Cpp2ILInjected.Token(Token = "0x4001B2E")]
	public static Microsoft.Xna.Framework.Graphics.Texture2D _buttonCloudActiveTexture;

	// Token: 0x04001611 RID: 5649
	[global::Cpp2ILInjected.Token(Token = "0x4001B2F")]
	public static Microsoft.Xna.Framework.Graphics.Texture2D _buttonCloudInactiveTexture;

	// Token: 0x04001612 RID: 5650
	[global::Cpp2ILInjected.Token(Token = "0x4001B30")]
	public static Microsoft.Xna.Framework.Graphics.Texture2D _buttonFavoriteActiveTexture;

	// Token: 0x04001613 RID: 5651
	[global::Cpp2ILInjected.Token(Token = "0x4001B31")]
	public static Microsoft.Xna.Framework.Graphics.Texture2D _buttonFavoriteInactiveTexture;

	// Token: 0x04001614 RID: 5652
	[global::Cpp2ILInjected.Token(Token = "0x4001B32")]
	public static Microsoft.Xna.Framework.Graphics.Texture2D _buttonPlayTexture;

	// Token: 0x04001615 RID: 5653
	[global::Cpp2ILInjected.Token(Token = "0x4001B33")]
	public static Microsoft.Xna.Framework.Graphics.Texture2D _buttonDeleteTexture;

	// Token: 0x04001616 RID: 5654
	[global::Cpp2ILInjected.Token(Token = "0x4001B34")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
	private int _worldCount;

	// Token: 0x04001617 RID: 5655
	[global::Cpp2ILInjected.Token(Token = "0x4001B35")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
	public List<WorldFileData> SortedWorldData;

	// Token: 0x04001618 RID: 5656
	[global::Cpp2ILInjected.Token(Token = "0x4001B36")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
	private bool SeedVersionToggle;

	// Token: 0x04001619 RID: 5657
	[global::Cpp2ILInjected.Token(Token = "0x4001B37")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x5C")]
	public int SelectedItem;

	// Token: 0x0400161A RID: 5658
	[global::Cpp2ILInjected.Token(Token = "0x4001B38")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
	private int LastSelectedItem;

	// Token: 0x0400161B RID: 5659
	[global::Cpp2ILInjected.Token(Token = "0x4001B39")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x68")]
	public string SelectedItemWorld;

	// Token: 0x0400161C RID: 5660
	[global::Cpp2ILInjected.Token(Token = "0x4001B3A")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x70")]
	private DateTime LastSelectTime;

	// Token: 0x0400161D RID: 5661
	[global::Cpp2ILInjected.Token(Token = "0x4001B3B")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x78")]
	private DateTime LastTouchTime;

	// Token: 0x0400161E RID: 5662
	[global::Cpp2ILInjected.Token(Token = "0x4001B3C")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x80")]
	private Microsoft.Xna.Framework.Vector2 LastTouchMouse;

	// Token: 0x0400161F RID: 5663
	[global::Cpp2ILInjected.Token(Token = "0x4001B3D")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x88")]
	public bool SyncingWorlds;

	// Token: 0x04001620 RID: 5664
	[global::Cpp2ILInjected.Token(Token = "0x4001B3E")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x90")]
	private GUIControllerWorldSelect _controllerInput;

	// Token: 0x04001621 RID: 5665
	[global::Cpp2ILInjected.Token(Token = "0x4001B3F")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x98")]
	private GUIContollerTransactionButtonList _worldListOptionsController;

	// Token: 0x04001622 RID: 5666
	[global::Cpp2ILInjected.Token(Token = "0x4001B40")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xA0")]
	private Microsoft.Xna.Framework.Graphics.Texture2D everythingAnimatedIcon;

	// Token: 0x04001623 RID: 5667
	[global::Cpp2ILInjected.Token(Token = "0x4001B41")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xA8")]
	private bool allowItemClicking;

	// Token: 0x04001624 RID: 5668
	[global::Cpp2ILInjected.Token(Token = "0x4001B42")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xAC")]
	private Rectangle fullClipRegion;

	// Token: 0x04001625 RID: 5669
	[global::Cpp2ILInjected.Token(Token = "0x4001B43")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xBC")]
	private Rectangle dragClipRegion;

	// Token: 0x04001626 RID: 5670
	[global::Cpp2ILInjected.Token(Token = "0x4001B44")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xCC")]
	private int worldOver;

	// Token: 0x02000801 RID: 2049
	[global::Cpp2ILInjected.Token(Token = "0x200028B")]
	public enum WorldRenameOption
	{
		// Token: 0x04007CE9 RID: 31977
		[global::Cpp2ILInjected.Token(Token = "0x4001B46")]
		DontRenameOldFormatWorlds,
		// Token: 0x04007CEA RID: 31978
		[global::Cpp2ILInjected.Token(Token = "0x4001B47")]
		RenameOldFormatWithLoadSave,
		// Token: 0x04007CEB RID: 31979
		[global::Cpp2ILInjected.Token(Token = "0x4001B48")]
		RenameAllFormatsWithLoadSave
	}
}
