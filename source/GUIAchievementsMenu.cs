﻿using System;
using System.Collections.Generic;
using Controller;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.Achievements;
using Terraria.Audio;
using Terraria.Graphics;
using Terraria.Localization;
using Terraria.UI;
using Terraria.UI.Chat;
using UnityEngine;

// Token: 0x020001C1 RID: 449
[global::Cpp2ILInjected.Token(Token = "0x2000256")]
public class GUIAchievementsMenu
{
	// Token: 0x1700014D RID: 333
	// (get) Token: 0x06000C3F RID: 3135 RVA: 0x00024002 File Offset: 0x00022202
	[global::Cpp2ILInjected.Token(Token = "0x17000174")]
	private GUIContollerTransactionButtonList FilterListOptionsController
	{
		[global::Cpp2ILInjected.Token(Token = "0x6000D5A")]
		[global::Cpp2ILInjected.Address(RVA = "0x9D76D4", Offset = "0x9D76D4", Length = "0x170")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIAchievementsMenu), Member = "Draw", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIContollerTransactionButtonList), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(bool),
			typeof(bool),
			typeof(TransactionButton_Layout[]),
			typeof(GUIContollerTransactionButtonList.SetupRegions)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
		get
		{
			throw null;
		}
	}

	// Token: 0x06000C40 RID: 3136 RVA: 0x00024005 File Offset: 0x00022205
	[global::Cpp2ILInjected.Token(Token = "0x6000D5B")]
	[global::Cpp2ILInjected.Address(RVA = "0x9D7844", Offset = "0x9D7844", Length = "0xF4")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(IngameFancyUI), Member = "OpenAchievementsAndGoto", MemberParameters = new object[] { typeof(Achievement) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
	public void GotoAchievement(Achievement achievement)
	{
		throw null;
	}

	// Token: 0x1700014E RID: 334
	// (get) Token: 0x06000C41 RID: 3137 RVA: 0x00024008 File Offset: 0x00022208
	[global::Cpp2ILInjected.Token(Token = "0x17000175")]
	private List<Achievement> Achievements
	{
		[global::Cpp2ILInjected.Token(Token = "0x6000D5C")]
		[global::Cpp2ILInjected.Address(RVA = "0x9D7938", Offset = "0x9D7938", Length = "0x6C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIAchievementsMenu), Member = "SortAndFilderAchievements", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_Achievements", ReturnType = typeof(AchievementManager))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AchievementManager), Member = "CreateAchievementsList", ReturnType = typeof(List<Achievement>))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		get
		{
			throw null;
		}
	}

	// Token: 0x06000C42 RID: 3138 RVA: 0x0002400B File Offset: 0x0002220B
	[global::Cpp2ILInjected.Token(Token = "0x6000D5D")]
	[global::Cpp2ILInjected.Address(RVA = "0x9D79A4", Offset = "0x9D79A4", Length = "0x274")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUISettingsPauseMenu), Member = "Draw", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIMainMenu), Member = "Draw", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(IngameFancyUI), Member = "OpenAchievements", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "set_menuMode", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "set_inFancyUI", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Microsoft.Xna.Framework.Vector2), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(float),
		typeof(float)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<bool>), Member = "set_Item", MemberParameters = new object[]
	{
		typeof(int),
		typeof(bool)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIAchievementsMenu), Member = "LoadContent", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIAchievementsMenu), Member = "UpdateAchievements", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
	public void Open(int backTo, int selected = -1)
	{
		throw null;
	}

	// Token: 0x06000C43 RID: 3139 RVA: 0x0002400E File Offset: 0x0002220E
	[global::Cpp2ILInjected.Token(Token = "0x6000D5E")]
	[global::Cpp2ILInjected.Address(RVA = "0x9D7DD8", Offset = "0x9D7DD8", Length = "0x2D4")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIAchievementsMenu), Member = "Draw", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<bool>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
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
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Language), Member = "GetTextValue", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUITransactionButton), Member = "Draw", MemberParameters = new object[]
	{
		typeof(TransactionButton_Layout),
		typeof(Microsoft.Xna.Framework.Graphics.Texture2D),
		typeof(Rectangle),
		typeof(string),
		typeof(bool),
		typeof(ref float),
		typeof(Microsoft.Xna.Framework.Graphics.Color?),
		typeof(bool),
		typeof(bool),
		typeof(bool),
		typeof(bool)
	}, ReturnType = typeof(GUITransactionButton.InputState))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<bool>), Member = "set_Item", MemberParameters = new object[]
	{
		typeof(int),
		typeof(bool)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIAchievementsMenu), Member = "UpdateAchievements", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SoundEngine), Member = "PlaySound", MemberParameters = new object[]
	{
		typeof(int),
		typeof(int),
		typeof(int),
		typeof(int),
		typeof(float),
		typeof(float)
	}, ReturnType = typeof(SoundEffectInstance))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
	private void DrawFilters()
	{
		throw null;
	}

	// Token: 0x06000C44 RID: 3140 RVA: 0x00024011 File Offset: 0x00022211
	[global::Cpp2ILInjected.Token(Token = "0x6000D5F")]
	[global::Cpp2ILInjected.Address(RVA = "0x9D80AC", Offset = "0x9D80AC", Length = "0x5F4")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUISettingsOverlay), Member = "Draw", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DrawMenu", MemberParameters = new object[] { typeof(GameTime) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIAchievementsMenu), Member = "get_FilterListOptionsController", ReturnType = typeof(GUIContollerTransactionButtonList))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerNavigationController), Member = "set_CurrentNavigationItem", MemberParameters = new object[] { typeof(GUIControllerItem) }, ReturnType = typeof(void))]
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
		typeof(Microsoft.Xna.Framework.Vector2),
		typeof(bool),
		typeof(bool),
		typeof(bool)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIAchievementsMenu), Member = "DrawFilters", ReturnType = typeof(void))]
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
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerNavigationController), Member = "PressedReleased", MemberParameters = new object[] { typeof(GUIControllerInputButton.LinkedControlType) }, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SoundEngine), Member = "PlaySound", MemberParameters = new object[]
	{
		typeof(int),
		typeof(int),
		typeof(int),
		typeof(int),
		typeof(float),
		typeof(float)
	}, ReturnType = typeof(SoundEffectInstance))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIAchievementsMenu), Member = "Back", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(KeyboardInput), Member = "GetKeyUp", MemberParameters = new object[] { typeof(KeyCode) }, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIKeyboardMappings), Member = "DisableEscapeKeyUsage", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 22)]
	public void Draw()
	{
		throw null;
	}

	// Token: 0x06000C45 RID: 3141 RVA: 0x00024014 File Offset: 0x00022214
	[global::Cpp2ILInjected.Token(Token = "0x6000D60")]
	[global::Cpp2ILInjected.Address(RVA = "0x9D86A0", Offset = "0x9D86A0", Length = "0x1CC")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUISettings), Member = "Draw", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIAchievementsMenu), Member = "Draw", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUISettingsOverlay), Member = "Shutdown", ReturnType = typeof(void))]
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
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "set_menuMode", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "set_inFancyUI", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(IngameFancyUI), Member = "Close", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
	public void Back()
	{
		throw null;
	}

	// Token: 0x06000C46 RID: 3142 RVA: 0x00024017 File Offset: 0x00022217
	[global::Cpp2ILInjected.Token(Token = "0x6000D61")]
	[global::Cpp2ILInjected.Address(RVA = "0x9D886C", Offset = "0x9D886C", Length = "0xE08")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tuple), Member = "Create", MemberTypeParameters = new object[] { "T1", "T2" }, MemberParameters = new object[] { "T1", "T2" }, ReturnType = "System.Tuple`2<T1, T2>")]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_Achievements", ReturnType = typeof(AchievementManager))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AchievementManager), Member = "GetIconIndex", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Achievement), Member = "get_IsCompleted", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Achievement), Member = "get_HasTracker", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(decimal), Member = "op_Implicit", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(decimal))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(decimal), Member = "op_Explicit", MemberParameters = new object[] { typeof(double) }, ReturnType = typeof(decimal))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(decimal), Member = "op_Equality", MemberParameters = new object[]
	{
		typeof(decimal),
		typeof(decimal)
	}, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(decimal), Member = "op_Explicit", MemberParameters = new object[] { typeof(decimal) }, ReturnType = typeof(float))]
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
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Microsoft.Xna.Framework.Vector2), Member = "op_Addition", MemberParameters = new object[]
	{
		typeof(Microsoft.Xna.Framework.Vector2),
		typeof(Microsoft.Xna.Framework.Vector2)
	}, ReturnType = typeof(Microsoft.Xna.Framework.Vector2))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIString), Member = "Draw", MemberParameters = new object[]
	{
		typeof(String_Layout),
		typeof(string)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPanel), Member = "Draw", MemberParameters = new object[]
	{
		typeof(Panel_Layout),
		typeof(bool),
		typeof(Microsoft.Xna.Framework.Graphics.Color?),
		typeof(Microsoft.Xna.Framework.Graphics.Color?),
		typeof(Microsoft.Xna.Framework.Graphics.Color?)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(String_Layout), Member = "GetFont", ReturnType = typeof(SpriteFont))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Microsoft.Xna.Framework.Vector2), Member = ".ctor", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ChatManager), Member = "DrawStringWithShadow", MemberParameters = new object[]
	{
		typeof(SpriteBatch),
		typeof(SpriteFont),
		typeof(string),
		typeof(Microsoft.Xna.Framework.Vector2),
		typeof(Microsoft.Xna.Framework.Graphics.Color),
		typeof(float),
		typeof(Microsoft.Xna.Framework.Vector2),
		typeof(Microsoft.Xna.Framework.Vector2),
		typeof(float),
		typeof(float),
		typeof(int)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Microsoft.Xna.Framework.Graphics.Color), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(int),
		typeof(int),
		typeof(int)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(decimal), Member = "ToString", ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
	{
		typeof(string),
		typeof(string),
		typeof(string)
	}, ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Microsoft.Xna.Framework.Vector4), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(float),
		typeof(float),
		typeof(float),
		typeof(float)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Microsoft.Xna.Framework.Graphics.Color), Member = ".ctor", MemberParameters = new object[] { typeof(Microsoft.Xna.Framework.Vector4) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "MultiplyRGBA", MemberParameters = new object[]
	{
		typeof(Microsoft.Xna.Framework.Graphics.Color),
		typeof(Microsoft.Xna.Framework.Graphics.Color)
	}, ReturnType = typeof(Microsoft.Xna.Framework.Graphics.Color))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIAchievementsMenu), Member = "DrawProgressBar", MemberParameters = new object[]
	{
		typeof(SpriteBatch),
		typeof(float),
		typeof(Microsoft.Xna.Framework.Vector2),
		typeof(float),
		typeof(Microsoft.Xna.Framework.Graphics.Color),
		typeof(Microsoft.Xna.Framework.Graphics.Color),
		typeof(Microsoft.Xna.Framework.Graphics.Color)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle?), Member = ".ctor", MemberParameters = new object[] { typeof(Rectangle) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Microsoft.Xna.Framework.Graphics.Color), Member = "op_Multiply", MemberParameters = new object[]
	{
		typeof(Microsoft.Xna.Framework.Graphics.Color),
		typeof(float)
	}, ReturnType = typeof(Microsoft.Xna.Framework.Graphics.Color))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteBatch), Member = "Draw", MemberParameters = new object[]
	{
		typeof(Microsoft.Xna.Framework.Graphics.Texture2D),
		typeof(Microsoft.Xna.Framework.Vector2),
		typeof(Rectangle?),
		typeof(Microsoft.Xna.Framework.Graphics.Color),
		typeof(float),
		typeof(Microsoft.Xna.Framework.Vector2),
		typeof(float),
		typeof(SpriteEffects),
		typeof(float)
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
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Microsoft.Xna.Framework.Vector2), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(float),
		typeof(float)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 50)]
	private void AchievementDraw(ItemGrid_Layout gridLayout, int index, Microsoft.Xna.Framework.Vector2 position, float scale)
	{
		throw null;
	}

	// Token: 0x06000C47 RID: 3143 RVA: 0x0002401A File Offset: 0x0002221A
	[global::Cpp2ILInjected.Token(Token = "0x6000D62")]
	[global::Cpp2ILInjected.Address(RVA = "0x9D9FB4", Offset = "0x9D9FB4", Length = "0x8")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	private float AchievementScale(int index)
	{
		throw null;
	}

	// Token: 0x06000C48 RID: 3144 RVA: 0x0002401D File Offset: 0x0002221D
	[global::Cpp2ILInjected.Token(Token = "0x6000D63")]
	[global::Cpp2ILInjected.Address(RVA = "0x9D9FBC", Offset = "0x9D9FBC", Length = "0x360")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_mouseLeft", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_mouseLeftRelease", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTime), Member = "op_Equality", MemberParameters = new object[]
	{
		typeof(DateTime),
		typeof(DateTime)
	}, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTime), Member = "get_Now", ReturnType = typeof(DateTime))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_mouseX", ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_mouseY", ReturnType = typeof(int))]
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
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTime), Member = "op_Subtraction", MemberParameters = new object[]
	{
		typeof(DateTime),
		typeof(DateTime)
	}, ReturnType = typeof(TimeSpan))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TimeSpan), Member = "get_TotalMilliseconds", ReturnType = typeof(double))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Microsoft.Xna.Framework.Vector2), Member = "Distance", MemberParameters = new object[]
	{
		typeof(Microsoft.Xna.Framework.Vector2),
		typeof(Microsoft.Xna.Framework.Vector2)
	}, ReturnType = typeof(float))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 20)]
	private void AchievementOver(int index)
	{
		throw null;
	}

	// Token: 0x06000C49 RID: 3145 RVA: 0x00024020 File Offset: 0x00022220
	[global::Cpp2ILInjected.Token(Token = "0x6000D64")]
	[global::Cpp2ILInjected.Address(RVA = "0x9D7C18", Offset = "0x9D7C18", Length = "0xF0")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIAchievementsMenu), Member = "Open", MemberParameters = new object[]
	{
		typeof(int),
		typeof(int)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TextureManager), Member = "Load", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(Microsoft.Xna.Framework.Graphics.Texture2D))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
	public static void LoadContent()
	{
		throw null;
	}

	// Token: 0x06000C4A RID: 3146 RVA: 0x00024023 File Offset: 0x00022223
	[global::Cpp2ILInjected.Token(Token = "0x6000D65")]
	[global::Cpp2ILInjected.Address(RVA = "0x9D7D08", Offset = "0x9D7D08", Length = "0xD0")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIAchievementsMenu), Member = "Open", MemberParameters = new object[]
	{
		typeof(int),
		typeof(int)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIAchievementsMenu), Member = "DrawFilters", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIAchievementsMenu), Member = "SortAndFilderAchievements", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
	public void UpdateAchievements()
	{
		throw null;
	}

	// Token: 0x06000C4B RID: 3147 RVA: 0x00024026 File Offset: 0x00022226
	[global::Cpp2ILInjected.Token(Token = "0x6000D66")]
	[global::Cpp2ILInjected.Address(RVA = "0x9DA31C", Offset = "0x9DA31C", Length = "0x1F0")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIAchievementsMenu), Member = "UpdateAchievements", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new object[]
	{
		typeof(Array),
		typeof(int),
		typeof(int)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIAchievementsMenu), Member = "get_Achievements", ReturnType = typeof(List<Achievement>))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<bool>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Comparison<object>), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(object),
		typeof(IntPtr)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "Sort", MemberParameters = new object[] { typeof(Comparison<object>) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
	public void SortAndFilderAchievements()
	{
		throw null;
	}

	// Token: 0x06000C4C RID: 3148 RVA: 0x00024029 File Offset: 0x00022229
	[global::Cpp2ILInjected.Token(Token = "0x6000D67")]
	[global::Cpp2ILInjected.Address(RVA = "0x9DA50C", Offset = "0x9DA50C", Length = "0x88")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Achievement), Member = "get_IsCompleted", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(int), Member = "CompareTo", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
	private int SortEntry(Achievement a, Achievement b)
	{
		throw null;
	}

	// Token: 0x06000C4D RID: 3149 RVA: 0x0002402C File Offset: 0x0002222C
	[global::Cpp2ILInjected.Token(Token = "0x6000D68")]
	[global::Cpp2ILInjected.Address(RVA = "0x9D9674", Offset = "0x9D9674", Length = "0x940")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIAchievementsMenu), Member = "AchievementDraw", MemberParameters = new object[]
	{
		typeof(ItemGrid_Layout),
		typeof(int),
		typeof(Microsoft.Xna.Framework.Vector2),
		typeof(float)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Microsoft.Xna.Framework.Graphics.Color), Member = "op_Equality", MemberParameters = new object[]
	{
		typeof(Microsoft.Xna.Framework.Graphics.Color),
		typeof(Microsoft.Xna.Framework.Graphics.Color)
	}, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Microsoft.Xna.Framework.Graphics.Color), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(int),
		typeof(int),
		typeof(int),
		typeof(int)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Microsoft.Xna.Framework.Graphics.Color), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(int),
		typeof(int),
		typeof(int)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MathHelper), Member = "Clamp", MemberParameters = new object[]
	{
		typeof(float),
		typeof(float),
		typeof(float)
	}, ReturnType = typeof(float))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Microsoft.Xna.Framework.Vector2), Member = "op_Multiply", MemberParameters = new object[]
	{
		typeof(Microsoft.Xna.Framework.Vector2),
		typeof(float)
	}, ReturnType = typeof(Microsoft.Xna.Framework.Vector2))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Microsoft.Xna.Framework.Vector2), Member = "op_Addition", MemberParameters = new object[]
	{
		typeof(Microsoft.Xna.Framework.Vector2),
		typeof(Microsoft.Xna.Framework.Vector2)
	}, ReturnType = typeof(Microsoft.Xna.Framework.Vector2))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(int),
		typeof(int),
		typeof(int),
		typeof(int)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle?), Member = ".ctor", MemberParameters = new object[] { typeof(Rectangle) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Microsoft.Xna.Framework.Vector2), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(float),
		typeof(float)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteBatch), Member = "Draw", MemberParameters = new object[]
	{
		typeof(Microsoft.Xna.Framework.Graphics.Texture2D),
		typeof(Microsoft.Xna.Framework.Vector2),
		typeof(Rectangle?),
		typeof(Microsoft.Xna.Framework.Graphics.Color),
		typeof(float),
		typeof(Microsoft.Xna.Framework.Vector2),
		typeof(Microsoft.Xna.Framework.Vector2),
		typeof(SpriteEffects),
		typeof(float)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 26)]
	private void DrawProgressBar(SpriteBatch spriteBatch, float progress, Microsoft.Xna.Framework.Vector2 spot, float Width = 169f, Microsoft.Xna.Framework.Graphics.Color BackColor = default(Microsoft.Xna.Framework.Graphics.Color), Microsoft.Xna.Framework.Graphics.Color FillingColor = default(Microsoft.Xna.Framework.Graphics.Color), Microsoft.Xna.Framework.Graphics.Color BlipColor = default(Microsoft.Xna.Framework.Graphics.Color))
	{
		throw null;
	}

	// Token: 0x06000C4E RID: 3150 RVA: 0x0002402F File Offset: 0x0002222F
	[global::Cpp2ILInjected.Token(Token = "0x6000D69")]
	[global::Cpp2ILInjected.Address(RVA = "0x9DA594", Offset = "0x9DA594", Length = "0x238")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIInstance), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerAchievements), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Microsoft.Xna.Framework.Vector2), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(float),
		typeof(float)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<bool>), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 17)]
	public GUIAchievementsMenu()
	{
		throw null;
	}

	// Token: 0x040013CC RID: 5068
	[global::Cpp2ILInjected.Token(Token = "0x40018B9")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
	private GUIControllerAchievements _controllerInput;

	// Token: 0x040013CD RID: 5069
	[global::Cpp2ILInjected.Token(Token = "0x40018BA")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
	private GUIContollerTransactionButtonList _filterListOptionsController;

	// Token: 0x040013CE RID: 5070
	[global::Cpp2ILInjected.Token(Token = "0x40018BB")]
	private const double SINGLE_CLICK_TIME = 350.0;

	// Token: 0x040013CF RID: 5071
	[global::Cpp2ILInjected.Token(Token = "0x40018BC")]
	private const float SINGLE_CLICK_DISTANCE = 30f;

	// Token: 0x040013D0 RID: 5072
	[global::Cpp2ILInjected.Token(Token = "0x40018BD")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	private DateTime LastTouchTime;

	// Token: 0x040013D1 RID: 5073
	[global::Cpp2ILInjected.Token(Token = "0x40018BE")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
	private Microsoft.Xna.Framework.Vector2 LastTouchMouse;

	// Token: 0x040013D2 RID: 5074
	[global::Cpp2ILInjected.Token(Token = "0x40018BF")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
	private int _source;

	// Token: 0x040013D3 RID: 5075
	[global::Cpp2ILInjected.Token(Token = "0x40018C0")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x34")]
	private bool allowItemClicking;

	// Token: 0x040013D4 RID: 5076
	[global::Cpp2ILInjected.Token(Token = "0x40018C1")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
	private float TitleScale;

	// Token: 0x040013D5 RID: 5077
	[global::Cpp2ILInjected.Token(Token = "0x40018C2")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x3C")]
	private float BackScale;

	// Token: 0x040013D6 RID: 5078
	[global::Cpp2ILInjected.Token(Token = "0x40018C3")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
	public float ScrollOffset;

	// Token: 0x040013D7 RID: 5079
	[global::Cpp2ILInjected.Token(Token = "0x40018C4")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x44")]
	private float ScrollMomentum;

	// Token: 0x040013D8 RID: 5080
	[global::Cpp2ILInjected.Token(Token = "0x40018C5")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
	private int ScrollDragging;

	// Token: 0x040013D9 RID: 5081
	[global::Cpp2ILInjected.Token(Token = "0x40018C6")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x4C")]
	private Microsoft.Xna.Framework.Vector2 DragOffset;

	// Token: 0x040013DA RID: 5082
	[global::Cpp2ILInjected.Token(Token = "0x40018C7")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x54")]
	public int SelectedItem;

	// Token: 0x040013DB RID: 5083
	[global::Cpp2ILInjected.Token(Token = "0x40018C8")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
	public int SelectedItemId;

	// Token: 0x040013DC RID: 5084
	[global::Cpp2ILInjected.Token(Token = "0x40018C9")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x5C")]
	private Microsoft.Xna.Framework.Vector2 InGameWindowShift;

	// Token: 0x040013DD RID: 5085
	[global::Cpp2ILInjected.Token(Token = "0x40018CA")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x68")]
	private List<bool> catButtonsActive;

	// Token: 0x040013DE RID: 5086
	[global::Cpp2ILInjected.Token(Token = "0x40018CB")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x70")]
	private List<Achievement> _achievements;

	// Token: 0x040013DF RID: 5087
	[global::Cpp2ILInjected.Token(Token = "0x40018CC")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x78")]
	public List<Achievement> SortedAchievementsData;

	// Token: 0x040013E0 RID: 5088
	[global::Cpp2ILInjected.Token(Token = "0x40018CD")]
	private static Microsoft.Xna.Framework.Graphics.Texture2D AchievementsIcons;

	// Token: 0x040013E1 RID: 5089
	[global::Cpp2ILInjected.Token(Token = "0x40018CE")]
	private static Microsoft.Xna.Framework.Graphics.Texture2D AchievementsCategories;

	// Token: 0x040013E2 RID: 5090
	[global::Cpp2ILInjected.Token(Token = "0x40018CF")]
	private static Microsoft.Xna.Framework.Graphics.Texture2D AchievementsIconBorder;

	// Token: 0x040013E3 RID: 5091
	[global::Cpp2ILInjected.Token(Token = "0x40018D0")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x80")]
	private string _tooltip;

	// Token: 0x040013E4 RID: 5092
	[global::Cpp2ILInjected.Token(Token = "0x40018D1")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x88")]
	private bool _tooltipShow;

	// Token: 0x040013E5 RID: 5093
	[global::Cpp2ILInjected.Token(Token = "0x40018D2")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x8C")]
	private Microsoft.Xna.Framework.Vector2 _tooltipLocation;

	// Token: 0x040013E6 RID: 5094
	[global::Cpp2ILInjected.Token(Token = "0x40018D3")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x98")]
	private DateTime _tooltipTime;

	// Token: 0x040013E7 RID: 5095
	[global::Cpp2ILInjected.Token(Token = "0x40018D4")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xA0")]
	private Microsoft.Xna.Framework.Vector2 startPoint;

	// Token: 0x040013E8 RID: 5096
	[global::Cpp2ILInjected.Token(Token = "0x40018D5")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xA8")]
	private float[] catScale;

	// Token: 0x040013E9 RID: 5097
	[global::Cpp2ILInjected.Token(Token = "0x40018D6")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xB0")]
	private bool displayFilters;

	// Token: 0x040013EA RID: 5098
	[global::Cpp2ILInjected.Token(Token = "0x40018D7")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xB4")]
	private float filtersScale;

	// Token: 0x040013EB RID: 5099
	[global::Cpp2ILInjected.Token(Token = "0x40018D8")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xB8")]
	private int achievementOver;

	// Token: 0x020007F6 RID: 2038
	[global::Cpp2ILInjected.Token(Token = "0x2000257")]
	public class AchievementFileData
	{
		// Token: 0x060048EE RID: 18670 RVA: 0x0002EF1F File Offset: 0x0002D11F
		[global::Cpp2ILInjected.Token(Token = "0x6000D6A")]
		[global::Cpp2ILInjected.Address(RVA = "0x9DA7CC", Offset = "0x9DA7CC", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public AchievementFileData()
		{
			throw null;
		}

		// Token: 0x04007CB7 RID: 31927
		[global::Cpp2ILInjected.Token(Token = "0x40018D9")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		public string Name;
	}
}