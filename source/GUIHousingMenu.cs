﻿using System;
using System.Collections.Generic;
using Controller;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Terraria;
using Terraria.Audio;
using Terraria.GameContent;
using Terraria.UI;
using UnityEngine;

[global::Cpp2ILInjected.Token(Token = "0x2000149")]
public class GUIHousingMenu
{
	[global::Cpp2ILInjected.Token(Token = "0x170000DF")]
	public bool Visible
	{
		[global::Cpp2ILInjected.Token(Token = "0x60008EB")]
		[global::Cpp2ILInjected.Address(RVA = "0x809B7C", Offset = "0x809B7C", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		get
		{
			throw null;
		}
		[global::Cpp2ILInjected.Token(Token = "0x60008EC")]
		[global::Cpp2ILInjected.Address(RVA = "0x809B84", Offset = "0x809B84", Length = "0xAC")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIPageIconGrouping), Member = "set_SelectedCategory", MemberParameters = new object[] { typeof(GUIPageIcons.Category) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIPageIcons), Member = "OnCategoryClosed", MemberParameters = new object[] { typeof(GUIPageIcons.Category) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIPageIcons), Member = "DrawLeftMenuButton", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUISettings), Member = "Draw", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "set_mouseNPCType", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		set
		{
			throw null;
		}
	}

	[global::Cpp2ILInjected.Token(Token = "0x60008ED")]
	[global::Cpp2ILInjected.Address(RVA = "0x809C30", Offset = "0x809C30", Length = "0xEC")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIPageIconGrouping), Member = "LoadPageRegion", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PageControllerLayoutDefinition<>), Member = "get_Instance", ReturnType = "T")]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HousingMenu_Layout), Member = "get_DisplayNPCGrid", ReturnType = typeof(DraggableItemGrid_Layout))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIItemGrid.GetItemScaleHandler), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(object),
		typeof(IntPtr)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIItemGrid), Member = "CalculateRegion", MemberParameters = new object[]
	{
		typeof(ItemGrid_Layout),
		typeof(GUIItemGrid.GetItemScaleHandler),
		typeof(int),
		typeof(Microsoft.Xna.Framework.Graphics.Texture2D)
	}, ReturnType = typeof(Rectangle))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControlAnchor), Member = "set_PageContentRegion", MemberParameters = new object[] { typeof(Rectangle) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
	public void LoadPageRegion()
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x60008EE")]
	[global::Cpp2ILInjected.Address(RVA = "0x809D1C", Offset = "0x809D1C", Length = "0x38")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
	private void DrawPageIcons()
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x170000E0")]
	public bool collapsed
	{
		[global::Cpp2ILInjected.Token(Token = "0x60008EF")]
		[global::Cpp2ILInjected.Address(RVA = "0x809D54", Offset = "0x809D54", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HousingMenu_Layout), Member = "get_DisplayNPCGrid", ReturnType = typeof(DraggableItemGrid_Layout))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InterfaceStyles_Layout), Member = "get_Active", ReturnType = typeof(InterfaceProfile_Layout))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InterfaceProfile_Layout), Member = "IsCollapsed", MemberParameters = new object[] { typeof(GUIPageIcons.Category) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		get
		{
			throw null;
		}
	}

	[global::Cpp2ILInjected.Token(Token = "0x170000E1")]
	private Microsoft.Xna.Framework.Graphics.Texture2D _npcHeadTextureEmpty
	{
		[global::Cpp2ILInjected.Token(Token = "0x60008F0")]
		[global::Cpp2ILInjected.Address(RVA = "0x809DB0", Offset = "0x809DB0", Length = "0x50")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIHousingMenu), Member = "NPCDraw", MemberParameters = new object[]
		{
			typeof(ItemGrid_Layout),
			typeof(int),
			typeof(Microsoft.Xna.Framework.Vector2),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PageControllerLayoutDefinition<>), Member = "get_Instance", ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Texture_Layout), Member = "get_Texture", ReturnType = typeof(Microsoft.Xna.Framework.Graphics.Texture2D))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		get
		{
			throw null;
		}
	}

	[global::Cpp2ILInjected.Token(Token = "0x170000E2")]
	public bool HasFocus
	{
		[global::Cpp2ILInjected.Token(Token = "0x60008F1")]
		[global::Cpp2ILInjected.Address(RVA = "0x809E00", Offset = "0x809E00", Length = "0x94")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIVirtualInputController), Member = "AddInteractBanner", MemberParameters = new object[]
		{
			typeof(Player),
			typeof(Item)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DrPlatform), Member = "get_CurrentPlatform", ReturnType = typeof(DrPlatform.DrPlatformType))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerPageRedirect), Member = "get_Housing", ReturnType = typeof(GUIControllerHousing))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		get
		{
			throw null;
		}
	}

	[global::Cpp2ILInjected.Token(Token = "0x60008F2")]
	[global::Cpp2ILInjected.Address(RVA = "0x809E94", Offset = "0x809E94", Length = "0x3B8")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIHousingMenu), Member = "Draw", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TownNPCProfiles), Member = "GetProfile", MemberParameters = new object[]
	{
		typeof(int),
		typeof(ref ITownNPCProfile)
	}, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NPC), Member = "TypeToDefaultHeadIndex", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 17)]
	private void RefreshNPCEntries()
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x60008F3")]
	[global::Cpp2ILInjected.Address(RVA = "0x80A24C", Offset = "0x80A24C", Length = "0x48")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PageControllerLayoutDefinition<>), Member = "get_Instance", ReturnType = "T")]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	public float NPCScale(int index)
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x60008F4")]
	[global::Cpp2ILInjected.Address(RVA = "0x80A294", Offset = "0x80A294", Length = "0x59C")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemSlot), Member = "UpdateTooltipContext", MemberParameters = new object[]
	{
		typeof(int),
		typeof(int)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<int>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NPC), Member = "get_FullName", ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_mouseLeft", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_mouseItem", ReturnType = typeof(Item))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPageIcons), Member = "get_DisplayTouchOptions", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerPageRedirect), Member = "get_Housing", ReturnType = typeof(GUIControllerHousing))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerHousing4Page), Member = "get_GridNav", ReturnType = typeof(GUIControllerDynamicGridNavigator))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerDynamicGridNavigator), Member = "Activate", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerNavigationController), Member = "set_CurrentNavigationItem", MemberParameters = new object[] { typeof(GUIControllerItem) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerNavigationController), Member = "UpdateCursorPosition", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_mouseLeftRelease", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SoundEngine), Member = "PlaySound", MemberParameters = new object[]
	{
		typeof(int),
		typeof(int),
		typeof(int),
		typeof(int),
		typeof(float),
		typeof(float)
	}, ReturnType = typeof(SoundEffectInstance))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "SetMouseNPC", MemberParameters = new object[]
	{
		typeof(int),
		typeof(int)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "set_mouseLeftRelease", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "SetMouseNPC_ToHousingQuery", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Inequality", MemberParameters = new object[]
	{
		typeof(string),
		typeof(string)
	}, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 18)]
	public void NPCOver(int index)
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x60008F5")]
	[global::Cpp2ILInjected.Address(RVA = "0x80A830", Offset = "0x80A830", Length = "0xE90")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<int>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TownNPCProfiles), Member = "GetProfile", MemberParameters = new object[]
	{
		typeof(int),
		typeof(ref ITownNPCProfile)
	}, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NPC), Member = "TypeToDefaultHeadIndex", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIHousingMenu), Member = "get__npcHeadTextureEmpty", ReturnType = typeof(Microsoft.Xna.Framework.Graphics.Texture2D))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PageControllerLayoutDefinition<>), Member = "get_Instance", ReturnType = "T")]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_mouseNPCType", ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Texture_Layout), Member = "get_Texture", ReturnType = typeof(Microsoft.Xna.Framework.Graphics.Texture2D))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "set_inventoryScale", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "Size", MemberParameters = new object[] { typeof(Microsoft.Xna.Framework.Graphics.Texture2D) }, ReturnType = typeof(Microsoft.Xna.Framework.Vector2))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Microsoft.Xna.Framework.Vector2), Member = "op_Division", MemberParameters = new object[]
	{
		typeof(Microsoft.Xna.Framework.Vector2),
		typeof(float)
	}, ReturnType = typeof(Microsoft.Xna.Framework.Vector2))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Microsoft.Xna.Framework.Vector2), Member = "op_Multiply", MemberParameters = new object[]
	{
		typeof(Microsoft.Xna.Framework.Vector2),
		typeof(float)
	}, ReturnType = typeof(Microsoft.Xna.Framework.Vector2))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Microsoft.Xna.Framework.Vector2), Member = "op_Subtraction", MemberParameters = new object[]
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
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_inventoryScale", ReturnType = typeof(float))]
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
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XNAUIInputLayer), Member = "GetUICursor", ReturnType = typeof(global::Cursor))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteBatchItem), Member = "PushExpandedClippingRegion", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Microsoft.Xna.Framework.Vector2), Member = "op_Addition", MemberParameters = new object[]
	{
		typeof(Microsoft.Xna.Framework.Vector2),
		typeof(Microsoft.Xna.Framework.Vector2)
	}, ReturnType = typeof(Microsoft.Xna.Framework.Vector2))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteBatchItem), Member = "PopExpandedClippingRegion", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Microsoft.Xna.Framework.Vector2), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(float),
		typeof(float)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_mouseNPCIndex", ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 59)]
	public void NPCDraw(ItemGrid_Layout gridLayout, int index, Microsoft.Xna.Framework.Vector2 position, float scale)
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x60008F6")]
	[global::Cpp2ILInjected.Address(RVA = "0x80B6C0", Offset = "0x80B6C0", Length = "0x3D8")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIHousingMenu), Member = "Draw", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControllerActionManager), Member = "get_ActiveController", ReturnType = typeof(ControllerDevice))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControlsBanner), Member = "AddAction", MemberParameters = new object[]
	{
		typeof(GUIControlsBanner.ActionSource),
		typeof(ControllerActionButton),
		typeof(string)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControlsBanner), Member = "AddAction", MemberParameters = new object[]
	{
		typeof(GUIControlsBanner.ActionSource),
		typeof(ControllerActionVector),
		typeof(string)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControllerActionVector), Member = "Active", MemberParameters = new object[] { typeof(ControllerDevice) }, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControllerActionButton), Member = "GetButtonUp", MemberParameters = new object[] { typeof(ControllerDevice) }, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIHousingMenu), Member = "NextItem", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIHousingMenu), Member = "PreviousItem", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControllerActionVector), Member = "GetValue", MemberParameters = new object[] { typeof(ControllerDevice) }, ReturnType = typeof(global::UnityEngine.Vector2))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTime), Member = "get_Now", ReturnType = typeof(DateTime))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTime), Member = "op_Subtraction", MemberParameters = new object[]
	{
		typeof(DateTime),
		typeof(DateTime)
	}, ReturnType = typeof(TimeSpan))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TimeSpan), Member = "get_TotalSeconds", ReturnType = typeof(double))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerPageRedirect), Member = "get_Housing", ReturnType = typeof(GUIControllerHousing))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Microsoft.Xna.Framework.Vector2), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(float),
		typeof(float)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerNavigationController), Member = "set_CurrentNavigationItem", MemberParameters = new object[] { typeof(GUIControllerItem) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerNavigationController), Member = "UpdateCursorPosition", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Mouse), Member = "UpdateUICursorPoint", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIHousingMenu), Member = "UpdateHotbarScroll", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
	public void UpdateHotbarNavigation()
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x60008F7")]
	[global::Cpp2ILInjected.Address(RVA = "0x80BB98", Offset = "0x80BB98", Length = "0x100")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIHousingMenu), Member = "UpdateHotbarNavigation", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIHousingMenu), Member = "UpdateHotbarScroll", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerPageRedirect), Member = "get_Housing", ReturnType = typeof(GUIControllerHousing))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerNavigationController), Member = "set_CurrentNavigationItem", MemberParameters = new object[] { typeof(GUIControllerItem) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerNavigationController), Member = "UpdateCursorPosition", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Mouse), Member = "UpdateUICursorPoint", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
	private void PreviousItem()
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x60008F8")]
	[global::Cpp2ILInjected.Address(RVA = "0x80BA98", Offset = "0x80BA98", Length = "0x100")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIHousingMenu), Member = "UpdateHotbarNavigation", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIHousingMenu), Member = "UpdateHotbarScroll", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerPageRedirect), Member = "get_Housing", ReturnType = typeof(GUIControllerHousing))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerNavigationController), Member = "set_CurrentNavigationItem", MemberParameters = new object[] { typeof(GUIControllerItem) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerNavigationController), Member = "UpdateCursorPosition", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Mouse), Member = "UpdateUICursorPoint", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
	private void NextItem()
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x60008F9")]
	[global::Cpp2ILInjected.Address(RVA = "0x80BC98", Offset = "0x80BC98", Length = "0x168")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIHousingMenu), Member = "UpdateHotbarNavigation", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIScrollControl), Member = "IsGlobalScrollValid", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPageIcons), Member = "get_UseHorizontalPages", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XNAUnityRunner), Member = "GetMouseScrollDelta", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(float))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIHousingMenu), Member = "PreviousItem", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIHousingMenu), Member = "NextItem", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
	private void UpdateHotbarScroll()
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x60008FA")]
	[global::Cpp2ILInjected.Address(RVA = "0x80BE00", Offset = "0x80BE00", Length = "0x69C")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIPageIconGrouping), Member = "DrawPageContent", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIPageIcons), Member = "DrawInventoryItems", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPageIcons), Member = "get_UsingTouchUI", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PageControllerLayoutDefinition<>), Member = "get_Instance", ReturnType = "T")]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIString), Member = "Draw", MemberParameters = new object[]
	{
		typeof(String_Layout),
		typeof(string)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPageIcons), Member = "IsPageSelected", MemberParameters = new object[] { typeof(GUIPageIcons.Category) }, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_myPlayer", ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIHousingMenu), Member = "UpdateHotbarNavigation", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_mouseNPCType", ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "set_mouseNPCType", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIHousingMenu), Member = "RefreshNPCEntries", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Microsoft.Xna.Framework.Graphics.Color), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(int),
		typeof(int),
		typeof(int),
		typeof(int)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Microsoft.Xna.Framework.Graphics.Color), Member = "op_Multiply", MemberParameters = new object[]
	{
		typeof(Microsoft.Xna.Framework.Graphics.Color),
		typeof(float)
	}, ReturnType = typeof(Microsoft.Xna.Framework.Graphics.Color))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HousingMenu_Layout), Member = "get_DisplayNPCGrid", ReturnType = typeof(DraggableItemGrid_Layout))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIItemGrid.GetItemScaleHandler), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(object),
		typeof(IntPtr)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIItemGrid), Member = "CalculateRegion", MemberParameters = new object[]
	{
		typeof(ItemGrid_Layout),
		typeof(GUIItemGrid.GetItemScaleHandler),
		typeof(int),
		typeof(Microsoft.Xna.Framework.Graphics.Texture2D)
	}, ReturnType = typeof(Rectangle))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_mouseX", ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_mouseY", ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle), Member = "Contains", MemberParameters = new object[]
	{
		typeof(int),
		typeof(int)
	}, ReturnType = typeof(bool))]
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
		typeof(Microsoft.Xna.Framework.Graphics.Texture2D),
		typeof(bool),
		typeof(bool),
		typeof(bool)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerPageRedirect), Member = "get_Housing", ReturnType = typeof(GUIControllerHousing))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerHousing4Page), Member = "get_GridNav", ReturnType = typeof(GUIControllerDynamicGridNavigator))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerDynamicGridNavigator), Member = "DisableScrollUntilChange", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "MouseText", MemberParameters = new object[]
	{
		typeof(string),
		typeof(int),
		typeof(byte),
		typeof(int),
		typeof(int),
		typeof(int),
		typeof(int),
		typeof(int)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 33)]
	public void Draw()
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x60008FB")]
	[global::Cpp2ILInjected.Address(RVA = "0x80C49C", Offset = "0x80C49C", Length = "0x10BC")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIInstance), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<int>), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
	public GUIHousingMenu()
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x40007C0")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
	private bool _visible;

	[global::Cpp2ILInjected.Token(Token = "0x40007C1")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
	public int LastNPCHousingHover;

	[global::Cpp2ILInjected.Token(Token = "0x40007C2")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
	public int NPCHousingHover;

	[global::Cpp2ILInjected.Token(Token = "0x40007C3")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	public List<int> _activeNPCEntries;

	[global::Cpp2ILInjected.Token(Token = "0x40007C4")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
	public string npcString;

	[global::Cpp2ILInjected.Token(Token = "0x40007C5")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
	private int _lastNPCOVer;

	[global::Cpp2ILInjected.Token(Token = "0x40007C6")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x34")]
	private bool _npcOver;

	[global::Cpp2ILInjected.Token(Token = "0x40007C7")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
	private int over;

	[global::Cpp2ILInjected.Token(Token = "0x40007C8")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
	private Microsoft.Xna.Framework.Graphics.Texture2D _npcHeadTexture;

	[global::Cpp2ILInjected.Token(Token = "0x40007C9")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
	public float scrollOffset;

	[global::Cpp2ILInjected.Token(Token = "0x40007CA")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x4C")]
	private float scrollMomentum;

	[global::Cpp2ILInjected.Token(Token = "0x40007CB")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
	private int scrollDragging;

	[global::Cpp2ILInjected.Token(Token = "0x40007CC")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x54")]
	private Microsoft.Xna.Framework.Vector2 dragOffset;

	[global::Cpp2ILInjected.Token(Token = "0x40007CD")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x5C")]
	private float scrollDelay;

	[global::Cpp2ILInjected.Token(Token = "0x40007CE")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
	private int _npcCount;

	[global::Cpp2ILInjected.Token(Token = "0x40007CF")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x64")]
	public int ActiveNPCCount;

	[global::Cpp2ILInjected.Token(Token = "0x40007D0")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x68")]
	private float HousingQueryScale;

	[global::Cpp2ILInjected.Token(Token = "0x40007D1")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x6C")]
	public bool menuTogglePressed;

	[global::Cpp2ILInjected.Token(Token = "0x40007D2")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x70")]
	private DateTime NavigationTick;

	[global::Cpp2ILInjected.Token(Token = "0x40007D3")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x78")]
	private bool hotbarActive;

	[global::Cpp2ILInjected.Token(Token = "0x40007D4")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x7C")]
	private float ScrollAmount;
}
