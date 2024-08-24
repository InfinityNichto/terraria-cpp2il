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
using Terraria.DataStructures;
using Terraria.Graphics;
using Terraria.ID;
using Terraria.Initializers;
using Terraria.IO;
using Terraria.Localization;
using Terraria.Social.iOS;
using UnityEngine;

// Token: 0x020001DD RID: 477
[global::Cpp2ILInjected.Token(Token = "0x2000279")]
public class GUIPlayerSelectMenu
{
	// Token: 0x06000D24 RID: 3364 RVA: 0x000242B1 File Offset: 0x000224B1
	[global::Cpp2ILInjected.Token(Token = "0x6000E43")]
	[global::Cpp2ILInjected.Address(RVA = "0x9FAD04", Offset = "0x9FAD04", Length = "0x8")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	private bool IsOverOptions(Microsoft.Xna.Framework.Vector2 cursorPosition)
	{
		throw null;
	}

	// Token: 0x06000D25 RID: 3365 RVA: 0x000242B4 File Offset: 0x000224B4
	[global::Cpp2ILInjected.Token(Token = "0x6000E44")]
	[global::Cpp2ILInjected.Address(RVA = "0x9FAD0C", Offset = "0x9FAD0C", Length = "0x1C4")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Initializers.AssetInitializer.<LoadAssetsWhileInInitialBlackScreen_InSteps>d__3", Member = "MoveNext", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AssetInitializer), Member = "LoadAssetsWhileInInitialBlackScreen", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ContentManager), Member = "Load", MemberTypeParameters = new object[] { "T1" }, MemberParameters = new object[] { typeof(string) }, ReturnType = "T1")]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
	public static void LoadContent(ContentManager content)
	{
		throw null;
	}

	// Token: 0x06000D26 RID: 3366 RVA: 0x000242B7 File Offset: 0x000224B7
	[global::Cpp2ILInjected.Token(Token = "0x6000E45")]
	[global::Cpp2ILInjected.Address(RVA = "0x9FAED0", Offset = "0x9FAED0", Length = "0x80")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPlayerCreateMenu), Member = "Setup", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "set_menuMode", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
	public void ActionNew()
	{
		throw null;
	}

	// Token: 0x17000153 RID: 339
	// (get) Token: 0x06000D27 RID: 3367 RVA: 0x000242BA File Offset: 0x000224BA
	[global::Cpp2ILInjected.Token(Token = "0x1700017B")]
	private GUIContollerTransactionButtonList PlayerListOptionsController
	{
		[global::Cpp2ILInjected.Token(Token = "0x6000E46")]
		[global::Cpp2ILInjected.Address(RVA = "0x9FAF50", Offset = "0x9FAF50", Length = "0x118")]
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

	// Token: 0x06000D28 RID: 3368 RVA: 0x000242BD File Offset: 0x000224BD
	[global::Cpp2ILInjected.Token(Token = "0x6000E47")]
	[global::Cpp2ILInjected.Address(RVA = "0x9FB068", Offset = "0x9FB068", Length = "0x238")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIPlayerSelectMenu), Member = "Draw", ReturnType = typeof(void))]
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
	private void DrawPlayerSync()
	{
		throw null;
	}

	// Token: 0x06000D29 RID: 3369 RVA: 0x000242C0 File Offset: 0x000224C0
	[global::Cpp2ILInjected.Token(Token = "0x6000E48")]
	[global::Cpp2ILInjected.Address(RVA = "0x9FB2A0", Offset = "0x9FB2A0", Length = "0x160")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIPlayerSelectMenu), Member = "Draw", ReturnType = typeof(void))]
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

	// Token: 0x06000D2A RID: 3370 RVA: 0x000242C3 File Offset: 0x000224C3
	[global::Cpp2ILInjected.Token(Token = "0x6000E49")]
	[global::Cpp2ILInjected.Address(RVA = "0x9FB400", Offset = "0x9FB400", Length = "0x58")]
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

	// Token: 0x06000D2B RID: 3371 RVA: 0x000242C6 File Offset: 0x000224C6
	[global::Cpp2ILInjected.Token(Token = "0x6000E4A")]
	[global::Cpp2ILInjected.Address(RVA = "0x9FB458", Offset = "0x9FB458", Length = "0x74")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	public Microsoft.Xna.Framework.Vector2 ItemSize(int index)
	{
		throw null;
	}

	// Token: 0x06000D2C RID: 3372 RVA: 0x000242C9 File Offset: 0x000224C9
	[global::Cpp2ILInjected.Token(Token = "0x6000E4B")]
	[global::Cpp2ILInjected.Address(RVA = "0x9FB4CC", Offset = "0x9FB4CC", Length = "0x178")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIPlayerCreateMenu), Member = "CreateAndSave", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CacheFileManager), Member = "CleanPath", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Equality", MemberParameters = new object[]
	{
		typeof(string),
		typeof(string)
	}, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
	public void SelectAndHighlight(PlayerFileData playerData)
	{
		throw null;
	}

	// Token: 0x06000D2D RID: 3373 RVA: 0x000242CC File Offset: 0x000224CC
	[global::Cpp2ILInjected.Token(Token = "0x6000E4C")]
	[global::Cpp2ILInjected.Address(RVA = "0x9FB644", Offset = "0x9FB644", Length = "0x1068")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DrawMenu", MemberParameters = new object[] { typeof(GameTime) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerNavigationController), Member = "set_CurrentNavigationItem", MemberParameters = new object[] { typeof(GUIControllerItem) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerNavigationController), Member = "UpdateCursorPosition", ReturnType = typeof(void))]
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
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPlayerSelectMenu), Member = "DrawPlayerSync", ReturnType = typeof(void))]
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
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPlayerSelectMenu), Member = "Back", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlayerSelectMenu_Layout), Member = "get_PlatformMaxPlayers", ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Language), Member = "GetTextValue", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPlayerSelectMenu), Member = "CloseNameEditIf", ReturnType = typeof(bool))]
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
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPlayerSelectMenu), Member = "DrawMenuButton", MemberParameters = new object[]
	{
		typeof(string),
		typeof(TransactionButton_Layout),
		typeof(ref float),
		typeof(bool)
	}, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPlayerAndGameModeMismatch), Member = "CheckMismatch", MemberParameters = new object[]
	{
		typeof(int),
		typeof(int)
	}, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "SelectPlayer", MemberParameters = new object[] { typeof(PlayerFileData) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPlayerSelectMenu), Member = "CloseNameEditAndSave", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerPlayerSelect), Member = "Activate", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPlayerSelectMenu), Member = "OpenNameEdit", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_PlayerList", ReturnType = typeof(List<PlayerFileData>))]
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
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CloudSocialModule), Member = "IsAvailable", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CloudSocialModule), Member = "IsRequired", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControllerActionButton), Member = "get_RequiredState", ReturnType = typeof(ControllerActionButton.RequiredButtonState))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIStringButton), Member = "DrawButton", MemberParameters = new object[]
	{
		typeof(StringButton_Layout),
		typeof(string),
		typeof(ref float),
		typeof(bool),
		typeof(bool)
	}, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CloudSocialModule), Member = "IsConnected", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 57)]
	public void Draw()
	{
		throw null;
	}

	// Token: 0x06000D2E RID: 3374 RVA: 0x000242CF File Offset: 0x000224CF
	[global::Cpp2ILInjected.Token(Token = "0x6000E4D")]
	[global::Cpp2ILInjected.Address(RVA = "0x9FC6AC", Offset = "0x9FC6AC", Length = "0x17C")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIPlayerCreateMenu), Member = "Back", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIPlayerSelectMenu), Member = "Draw", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIPS4MultiplayerChecks), Member = "Complete", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPlayerSelectMenu), Member = "CloseNameEditIf", ReturnType = typeof(bool))]
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
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "set_menuMode", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MPSessionManager), Member = "CancelPending", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UserManagement), Member = "UserSignedOut", MemberParameters = new object[] { typeof(PlatformUser) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
	public void Back()
	{
		throw null;
	}

	// Token: 0x06000D2F RID: 3375 RVA: 0x000242D2 File Offset: 0x000224D2
	[global::Cpp2ILInjected.Token(Token = "0x6000E4E")]
	[global::Cpp2ILInjected.Address(RVA = "0x9FCA48", Offset = "0x9FCA48", Length = "0x194")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIPlayerSelectMenu), Member = "DrawPlayer", MemberParameters = new object[]
	{
		typeof(Player),
		typeof(Projectile),
		typeof(bool)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "ToInt", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Player), Member = "WingFrame", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
	private void UpdateAnim(Player player, bool animated)
	{
		throw null;
	}

	// Token: 0x06000D30 RID: 3376 RVA: 0x000242D5 File Offset: 0x000224D5
	[global::Cpp2ILInjected.Token(Token = "0x6000E4F")]
	[global::Cpp2ILInjected.Address(RVA = "0x9FCBDC", Offset = "0x9FCBDC", Length = "0x1DC")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIPlayerSelectMenu), Member = "PlayerDraw", MemberParameters = new object[]
	{
		typeof(ItemGrid_Layout),
		typeof(int),
		typeof(Microsoft.Xna.Framework.Vector2),
		typeof(float)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Player), Member = "PlayerFrame", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPlayerSelectMenu), Member = "UpdateAnim", MemberParameters = new object[]
	{
		typeof(Player),
		typeof(bool)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LayoutCalculator), Member = "GetAnchoredPosition", MemberParameters = new object[]
	{
		typeof(ControlAnchor.ControlId),
		typeof(LayoutCalculator.AnchorType),
		typeof(Microsoft.Xna.Framework.Vector2)
	}, ReturnType = typeof(Microsoft.Xna.Framework.Vector2))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPanel), Member = "Draw", MemberParameters = new object[]
	{
		typeof(Panel_Layout),
		typeof(bool),
		typeof(Microsoft.Xna.Framework.Graphics.Color?),
		typeof(Microsoft.Xna.Framework.Graphics.Color?),
		typeof(Microsoft.Xna.Framework.Graphics.Color?)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Microsoft.Xna.Framework.Vector2), Member = "op_Addition", MemberParameters = new object[]
	{
		typeof(Microsoft.Xna.Framework.Vector2),
		typeof(Microsoft.Xna.Framework.Vector2)
	}, ReturnType = typeof(Microsoft.Xna.Framework.Vector2))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Microsoft.Xna.Framework.Vector2), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(float),
		typeof(float)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPlayerSelectMenu), Member = "DrawPet", MemberParameters = new object[]
	{
		typeof(Player),
		typeof(Projectile),
		typeof(Microsoft.Xna.Framework.Vector2),
		typeof(bool)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPlayerSelectMenu), Member = "DrawPlayerUI", MemberParameters = new object[]
	{
		typeof(Player),
		typeof(Microsoft.Xna.Framework.Vector2),
		typeof(Microsoft.Xna.Framework.Vector2)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
	private void DrawPlayer(Player player, Projectile pet, bool animated)
	{
		throw null;
	}

	// Token: 0x06000D31 RID: 3377 RVA: 0x000242D8 File Offset: 0x000224D8
	[global::Cpp2ILInjected.Token(Token = "0x6000E50")]
	[global::Cpp2ILInjected.Address(RVA = "0x9FCDB8", Offset = "0x9FCDB8", Length = "0x324")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIPlayerSelectMenu), Member = "DrawPlayer", MemberParameters = new object[]
	{
		typeof(Player),
		typeof(Projectile),
		typeof(bool)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Microsoft.Xna.Framework.Vector2), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(float),
		typeof(float)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Microsoft.Xna.Framework.Vector2), Member = "op_Addition", MemberParameters = new object[]
	{
		typeof(Microsoft.Xna.Framework.Vector2),
		typeof(Microsoft.Xna.Framework.Vector2)
	}, ReturnType = typeof(Microsoft.Xna.Framework.Vector2))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_screenPosition", ReturnType = typeof(Microsoft.Xna.Framework.Vector2))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_myPlayer", ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SettingsForCharacterPreview), Member = "ApplyTo", MemberParameters = new object[]
	{
		typeof(Projectile),
		typeof(bool)
	}, ReturnType = typeof(void))]
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
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "DrawProjDirect", MemberParameters = new object[]
	{
		typeof(Projectile),
		typeof(int)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
	public void DrawPet(Player player, Projectile proj, Microsoft.Xna.Framework.Vector2 playerPosition, bool animated)
	{
		throw null;
	}

	// Token: 0x06000D32 RID: 3378 RVA: 0x000242DB File Offset: 0x000224DB
	[global::Cpp2ILInjected.Token(Token = "0x6000E51")]
	[global::Cpp2ILInjected.Address(RVA = "0x9FD0DC", Offset = "0x9FD0DC", Length = "0x524")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIClothesWindow), Member = "DrawPlayer", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIClothesWindow), Member = "StyleDraw", MemberParameters = new object[]
	{
		typeof(ItemGrid_Layout),
		typeof(int),
		typeof(Microsoft.Xna.Framework.Vector2),
		typeof(float)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIHairWindow), Member = "DrawPlayer", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIPVPIcons), Member = "DrawSelectedPlayerImage", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIPlayerCreateMenu), Member = "DrawPlayer", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIPlayerCreateMenu), Member = "StyleDraw", MemberParameters = new object[]
	{
		typeof(ItemGrid_Layout),
		typeof(int),
		typeof(Microsoft.Xna.Framework.Vector2),
		typeof(float)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIPlayerCreateMenu), Member = "DrawSelectedPlayer", MemberParameters = new object[]
	{
		typeof(Microsoft.Xna.Framework.Vector2),
		typeof(float)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIPlayerSelectMenu), Member = "DrawPlayer", MemberParameters = new object[]
	{
		typeof(Player),
		typeof(Projectile),
		typeof(bool)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUISaveSynchronisation_FileList), Member = "DrawPlayer", MemberParameters = new object[]
	{
		typeof(Player),
		typeof(bool)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 9)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Microsoft.Xna.Framework.Vector2), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(float),
		typeof(float)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Microsoft.Xna.Framework.Vector2), Member = "op_Addition", MemberParameters = new object[]
	{
		typeof(Microsoft.Xna.Framework.Vector2),
		typeof(Microsoft.Xna.Framework.Vector2)
	}, ReturnType = typeof(Microsoft.Xna.Framework.Vector2))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Player), Member = "UpdateDyes", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Player), Member = "get_Male", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArmorIDs.Body.Sets.IncludeCapeFrontAndBackInfo), Member = "get_Invalid", ReturnType = typeof(bool))]
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
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_Camera", ReturnType = typeof(global::Terraria.Graphics.Camera))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_screenPosition", ReturnType = typeof(Microsoft.Xna.Framework.Vector2))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 17)]
	public void DrawPlayerUI(Player player, Microsoft.Xna.Framework.Vector2 origin, Microsoft.Xna.Framework.Vector2 size)
	{
		throw null;
	}

	// Token: 0x06000D33 RID: 3379 RVA: 0x000242DE File Offset: 0x000224DE
	[global::Cpp2ILInjected.Token(Token = "0x6000E52")]
	[global::Cpp2ILInjected.Address(RVA = "0x9FD600", Offset = "0x9FD600", Length = "0x124")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUINetPlayStatusMenu), Member = "QuitCallBack", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_ActivePlayerFileData", ReturnType = typeof(PlayerFileData))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FileData), Member = "GetFileName", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "LoadPlayers", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Equality", MemberParameters = new object[]
	{
		typeof(string),
		typeof(string)
	}, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "SelectPlayer", MemberParameters = new object[] { typeof(PlayerFileData) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
	public void RefreshPlayers()
	{
		throw null;
	}

	// Token: 0x06000D34 RID: 3380 RVA: 0x000242E1 File Offset: 0x000224E1
	[global::Cpp2ILInjected.Token(Token = "0x6000E53")]
	[global::Cpp2ILInjected.Address(RVA = "0x9FC88C", Offset = "0x9FC88C", Length = "0x98")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIPlayerSelectMenu), Member = "Draw", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIMenuNameEdit), Member = "Enable", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
	private void OpenNameEdit()
	{
		throw null;
	}

	// Token: 0x06000D35 RID: 3381 RVA: 0x000242E4 File Offset: 0x000224E4
	[global::Cpp2ILInjected.Token(Token = "0x6000E54")]
	[global::Cpp2ILInjected.Address(RVA = "0x9FC924", Offset = "0x9FC924", Length = "0x124")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIPlayerSelectMenu), Member = "Draw", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIPlayerSelectMenu), Member = "PlayerDraw", MemberParameters = new object[]
	{
		typeof(ItemGrid_Layout),
		typeof(int),
		typeof(Microsoft.Xna.Framework.Vector2),
		typeof(float)
	}, ReturnType = typeof(void))]
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
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Trim", ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Player), Member = "SavePlayer", MemberParameters = new object[]
	{
		typeof(PlayerFileData),
		typeof(bool),
		typeof(bool)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPlayerSelectMenu), Member = "CloseNameEdit", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
	private void CloseNameEditAndSave()
	{
		throw null;
	}

	// Token: 0x06000D36 RID: 3382 RVA: 0x000242E7 File Offset: 0x000224E7
	[global::Cpp2ILInjected.Token(Token = "0x6000E55")]
	[global::Cpp2ILInjected.Address(RVA = "0x9FC828", Offset = "0x9FC828", Length = "0x64")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIPlayerSelectMenu), Member = "Draw", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIPlayerSelectMenu), Member = "Back", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIPlayerSelectMenu), Member = "PlayerDraw", MemberParameters = new object[]
	{
		typeof(ItemGrid_Layout),
		typeof(int),
		typeof(Microsoft.Xna.Framework.Vector2),
		typeof(float)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 7)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPlayerSelectMenu), Member = "CloseNameEdit", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	private bool CloseNameEditIf()
	{
		throw null;
	}

	// Token: 0x06000D37 RID: 3383 RVA: 0x000242EA File Offset: 0x000224EA
	[global::Cpp2ILInjected.Token(Token = "0x6000E56")]
	[global::Cpp2ILInjected.Address(RVA = "0x9FD724", Offset = "0x9FD724", Length = "0x54")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIPlayerSelectMenu), Member = "CloseNameEditAndSave", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIPlayerSelectMenu), Member = "CloseNameEditIf", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIPlayerSelectMenu), Member = "PlayerDraw", MemberParameters = new object[]
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

	// Token: 0x06000D38 RID: 3384 RVA: 0x000242ED File Offset: 0x000224ED
	[global::Cpp2ILInjected.Token(Token = "0x6000E57")]
	[global::Cpp2ILInjected.Address(RVA = "0x9FD778", Offset = "0x9FD778", Length = "0x11E8")]
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
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPanel), Member = "DrawAtPosition", MemberParameters = new object[]
	{
		typeof(Panel_Layout),
		typeof(Microsoft.Xna.Framework.Vector2),
		typeof(Microsoft.Xna.Framework.Vector2),
		typeof(bool)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
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
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteBatch), Member = "End", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteBatchItem), Member = "PushClippedImageRegion", MemberParameters = new object[]
	{
		typeof(Rectangle),
		typeof(SpriteBatch),
		typeof(bool),
		typeof(Microsoft.Xna.Framework.Vector2),
		typeof(float)
	}, ReturnType = typeof(void))]
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
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPlayerSelectMenu), Member = "DrawPlayer", MemberParameters = new object[]
	{
		typeof(Player),
		typeof(Projectile),
		typeof(bool)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteBatchItem), Member = "PopClippedImageRegion", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIString), Member = "Draw", MemberParameters = new object[]
	{
		typeof(String_Layout),
		typeof(string),
		typeof(Microsoft.Xna.Framework.Graphics.Color),
		typeof(bool)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPlayerSelectMenu), Member = "CloseNameEdit", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUITransactionButton), Member = "GetPickRegion", MemberParameters = new object[] { typeof(TransactionButton_Layout) }, ReturnType = typeof(Rectangle))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIMenuNameEdit), Member = "GetInputText", MemberParameters = new object[]
	{
		typeof(Rectangle),
		typeof(int)
	}, ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPlayerSelectMenu), Member = "CloseNameEditIf", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPlayerSelectMenu), Member = "CloseNameEditAndSave", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIString), Member = "Draw", MemberParameters = new object[]
	{
		typeof(String_Layout),
		typeof(string)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(int), Member = "ToString", ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Language), Member = "GetTextValue", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
	{
		typeof(string),
		typeof(string)
	}, ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlayerFileData), Member = "GetPlayTime", ReturnType = typeof(TimeSpan))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TimeSpan), Member = "get_Days", ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TimeSpan), Member = "get_Hours", ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TimeSpan), Member = "ToString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
	{
		typeof(string),
		typeof(string),
		typeof(string)
	}, ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_mouseX", ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_mouseY", ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle), Member = "Contains", MemberParameters = new object[]
	{
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
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPlayerAndGameModeMismatch), Member = "CheckMismatch", MemberParameters = new object[]
	{
		typeof(int),
		typeof(int)
	}, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "SelectPlayer", MemberParameters = new object[] { typeof(PlayerFileData) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SoundEngine), Member = "PlaySound", MemberParameters = new object[]
	{
		typeof(int),
		typeof(int),
		typeof(int),
		typeof(int),
		typeof(float),
		typeof(float)
	}, ReturnType = typeof(SoundEffectInstance))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerNavigationController), Member = "UpdateCursorPosition", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 80)]
	private void PlayerDraw(ItemGrid_Layout gridLayout, int index, Microsoft.Xna.Framework.Vector2 position, float scale)
	{
		throw null;
	}

	// Token: 0x06000D39 RID: 3385 RVA: 0x000242F0 File Offset: 0x000224F0
	[global::Cpp2ILInjected.Token(Token = "0x6000E58")]
	[global::Cpp2ILInjected.Address(RVA = "0x9FE960", Offset = "0x9FE960", Length = "0x2B8")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "LoadPlayers", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new object[]
	{
		typeof(Array),
		typeof(int),
		typeof(int)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_PlayerList", ReturnType = typeof(List<PlayerFileData>))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "AddRange", MemberParameters = new object[] { typeof(IEnumerable<object>) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Comparison<object>), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(object),
		typeof(IntPtr)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "Sort", MemberParameters = new object[] { typeof(Comparison<object>) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "GetEnumerator", ReturnType = "Enumerator<T>")]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>.Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlayerFileData), Member = "PreparePetProjectiles", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>.Enumerator), Member = "Dispose", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlayerSelectMenu_Layout), Member = "get_PlatformMaxPlayers", ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Math), Member = "Min", MemberParameters = new object[]
	{
		typeof(int),
		typeof(int)
	}, ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 22)]
	public void SortPlayers()
	{
		throw null;
	}

	// Token: 0x06000D3A RID: 3386 RVA: 0x000242F3 File Offset: 0x000224F3
	[global::Cpp2ILInjected.Token(Token = "0x6000E59")]
	[global::Cpp2ILInjected.Address(RVA = "0x9FEC18", Offset = "0x9FEC18", Length = "0x30")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	private int SortEntry(PlayerFileData a, PlayerFileData b)
	{
		throw null;
	}

	// Token: 0x06000D3B RID: 3387 RVA: 0x000242F6 File Offset: 0x000224F6
	[global::Cpp2ILInjected.Token(Token = "0x6000E5A")]
	[global::Cpp2ILInjected.Address(RVA = "0x9FECBC", Offset = "0x9FECBC", Length = "0x8")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	private float PlayerScale(int index)
	{
		throw null;
	}

	// Token: 0x06000D3C RID: 3388 RVA: 0x000242F9 File Offset: 0x000224F9
	[global::Cpp2ILInjected.Token(Token = "0x6000E5B")]
	[global::Cpp2ILInjected.Address(RVA = "0x9FECC4", Offset = "0x9FECC4", Length = "0xC0")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_mouseLeft", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_mouseLeftRelease", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
	private void PlayerOver(int index)
	{
		throw null;
	}

	// Token: 0x06000D3D RID: 3389 RVA: 0x000242FC File Offset: 0x000224FC
	[global::Cpp2ILInjected.Token(Token = "0x6000E5C")]
	[global::Cpp2ILInjected.Address(RVA = "0x9FEC48", Offset = "0x9FEC48", Length = "0x74")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureInfo), Member = "get_CurrentCulture", ReturnType = typeof(CultureInfo))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPlayerSelectMenu), Member = "CompareNatural", MemberParameters = new object[]
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

	// Token: 0x06000D3E RID: 3390 RVA: 0x000242FF File Offset: 0x000224FF
	[global::Cpp2ILInjected.Token(Token = "0x6000E5D")]
	[global::Cpp2ILInjected.Address(RVA = "0x9FED84", Offset = "0x9FED84", Length = "0x794")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIPlayerSelectMenu), Member = "CompareNatural", MemberParameters = new object[]
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

	// Token: 0x06000D3F RID: 3391 RVA: 0x00024302 File Offset: 0x00022502
	[global::Cpp2ILInjected.Token(Token = "0x6000E5E")]
	[global::Cpp2ILInjected.Address(RVA = "0x9FF518", Offset = "0x9FF518", Length = "0x1CC")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIInstance), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerPlayerSelect), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Microsoft.Xna.Framework.Vector2), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(float),
		typeof(float)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Item), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 14)]
	public GUIPlayerSelectMenu()
	{
		throw null;
	}

	// Token: 0x040014F9 RID: 5369
	[global::Cpp2ILInjected.Token(Token = "0x4001A0E")]
	private const double DOUBLE_CLICK_TIME = 500.0;

	// Token: 0x040014FA RID: 5370
	[global::Cpp2ILInjected.Token(Token = "0x4001A0F")]
	private const double SINGLE_CLICK_TIME = 350.0;

	// Token: 0x040014FB RID: 5371
	[global::Cpp2ILInjected.Token(Token = "0x4001A10")]
	private const float SINGLE_CLICK_DISTANCE = 30f;

	// Token: 0x040014FC RID: 5372
	[global::Cpp2ILInjected.Token(Token = "0x4001A11")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
	private float TitleScale;

	// Token: 0x040014FD RID: 5373
	[global::Cpp2ILInjected.Token(Token = "0x4001A12")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
	private float BackScale;

	// Token: 0x040014FE RID: 5374
	[global::Cpp2ILInjected.Token(Token = "0x4001A13")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
	private float NewScale;

	// Token: 0x040014FF RID: 5375
	[global::Cpp2ILInjected.Token(Token = "0x4001A14")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C")]
	private float PlayScale;

	// Token: 0x04001500 RID: 5376
	[global::Cpp2ILInjected.Token(Token = "0x4001A15")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	private float EditNameScale;

	// Token: 0x04001501 RID: 5377
	[global::Cpp2ILInjected.Token(Token = "0x4001A16")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x24")]
	private float OptionsScale;

	// Token: 0x04001502 RID: 5378
	[global::Cpp2ILInjected.Token(Token = "0x4001A17")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
	private float DeleteScale;

	// Token: 0x04001503 RID: 5379
	[global::Cpp2ILInjected.Token(Token = "0x4001A18")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x2C")]
	private float FavoriteScale;

	// Token: 0x04001504 RID: 5380
	[global::Cpp2ILInjected.Token(Token = "0x4001A19")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
	public float ScrollOffset;

	// Token: 0x04001505 RID: 5381
	[global::Cpp2ILInjected.Token(Token = "0x4001A1A")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x34")]
	private float ScrollMomentum;

	// Token: 0x04001506 RID: 5382
	[global::Cpp2ILInjected.Token(Token = "0x4001A1B")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
	private int ScrollDragging;

	// Token: 0x04001507 RID: 5383
	[global::Cpp2ILInjected.Token(Token = "0x4001A1C")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x3C")]
	private Microsoft.Xna.Framework.Vector2 DragOffset;

	// Token: 0x04001508 RID: 5384
	[global::Cpp2ILInjected.Token(Token = "0x4001A1D")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x44")]
	public bool SyncingPlayers;

	// Token: 0x04001509 RID: 5385
	[global::Cpp2ILInjected.Token(Token = "0x4001A1E")]
	private static Microsoft.Xna.Framework.Graphics.Texture2D _dividerTexture;

	// Token: 0x0400150A RID: 5386
	[global::Cpp2ILInjected.Token(Token = "0x4001A1F")]
	private static Microsoft.Xna.Framework.Graphics.Texture2D _buttonCloudActiveTexture;

	// Token: 0x0400150B RID: 5387
	[global::Cpp2ILInjected.Token(Token = "0x4001A20")]
	private static Microsoft.Xna.Framework.Graphics.Texture2D _buttonCloudInactiveTexture;

	// Token: 0x0400150C RID: 5388
	[global::Cpp2ILInjected.Token(Token = "0x4001A21")]
	private static Microsoft.Xna.Framework.Graphics.Texture2D _buttonFavoriteActiveTexture;

	// Token: 0x0400150D RID: 5389
	[global::Cpp2ILInjected.Token(Token = "0x4001A22")]
	private static Microsoft.Xna.Framework.Graphics.Texture2D _buttonFavoriteInactiveTexture;

	// Token: 0x0400150E RID: 5390
	[global::Cpp2ILInjected.Token(Token = "0x4001A23")]
	private static Microsoft.Xna.Framework.Graphics.Texture2D _buttonPlayTexture;

	// Token: 0x0400150F RID: 5391
	[global::Cpp2ILInjected.Token(Token = "0x4001A24")]
	private static Microsoft.Xna.Framework.Graphics.Texture2D _buttonDeleteTexture;

	// Token: 0x04001510 RID: 5392
	[global::Cpp2ILInjected.Token(Token = "0x4001A25")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
	private int _playerCount;

	// Token: 0x04001511 RID: 5393
	[global::Cpp2ILInjected.Token(Token = "0x4001A26")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
	public List<PlayerFileData> SortedPlayerData;

	// Token: 0x04001512 RID: 5394
	[global::Cpp2ILInjected.Token(Token = "0x4001A27")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
	private Rectangle SelectedItemRegion;

	// Token: 0x04001513 RID: 5395
	[global::Cpp2ILInjected.Token(Token = "0x4001A28")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x68")]
	public int SelectedItem;

	// Token: 0x04001514 RID: 5396
	[global::Cpp2ILInjected.Token(Token = "0x4001A29")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x70")]
	public string SelectedItemPlayer;

	// Token: 0x04001515 RID: 5397
	[global::Cpp2ILInjected.Token(Token = "0x4001A2A")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x78")]
	private DateTime LastSelectTime;

	// Token: 0x04001516 RID: 5398
	[global::Cpp2ILInjected.Token(Token = "0x4001A2B")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x80")]
	private DateTime LastTouchTime;

	// Token: 0x04001517 RID: 5399
	[global::Cpp2ILInjected.Token(Token = "0x4001A2C")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x88")]
	private Microsoft.Xna.Framework.Vector2 LastTouchMouse;

	// Token: 0x04001518 RID: 5400
	[global::Cpp2ILInjected.Token(Token = "0x4001A2D")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x90")]
	private float NameScale;

	// Token: 0x04001519 RID: 5401
	[global::Cpp2ILInjected.Token(Token = "0x4001A2E")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x94")]
	public bool allowItemClicking;

	// Token: 0x0400151A RID: 5402
	[global::Cpp2ILInjected.Token(Token = "0x4001A2F")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x98")]
	private GUIControllerPlayerSelect _controllerInput;

	// Token: 0x0400151B RID: 5403
	[global::Cpp2ILInjected.Token(Token = "0x4001A30")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xA0")]
	private GUIContollerTransactionButtonList _playerListOptionsController;

	// Token: 0x0400151C RID: 5404
	[global::Cpp2ILInjected.Token(Token = "0x4001A31")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xA8")]
	private Rectangle fullClipRegion;

	// Token: 0x0400151D RID: 5405
	[global::Cpp2ILInjected.Token(Token = "0x4001A32")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xB8")]
	private Rectangle dragClipRegion;

	// Token: 0x0400151E RID: 5406
	[global::Cpp2ILInjected.Token(Token = "0x4001A33")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xC8")]
	private Microsoft.Xna.Framework.Vector2 CharacterOffset;

	// Token: 0x0400151F RID: 5407
	[global::Cpp2ILInjected.Token(Token = "0x4001A34")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xD0")]
	private Item _blankItem;

	// Token: 0x04001520 RID: 5408
	[global::Cpp2ILInjected.Token(Token = "0x4001A35")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xD8")]
	private int SelectedItemForTextEdit;

	// Token: 0x04001521 RID: 5409
	[global::Cpp2ILInjected.Token(Token = "0x4001A36")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xDC")]
	private int playerOver;
}
