using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.GameInput;
using UnityEngine;

namespace Controller
{
	// Token: 0x02000753 RID: 1875
	[global::Cpp2ILInjected.Token(Token = "0x2000B57")]
	public class ControllerActionButton
	{
		// Token: 0x1700082A RID: 2090
		// (get) Token: 0x060047A8 RID: 18344 RVA: 0x0002EC91 File Offset: 0x0002CE91
		[global::Cpp2ILInjected.Token(Token = "0x1700092F")]
		public bool HasMapping
		{
			[global::Cpp2ILInjected.Token(Token = "0x6005467")]
			[global::Cpp2ILInjected.Address(RVA = "0x949F90", Offset = "0x949F90", Length = "0x48")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerMappingEntry), Member = "get_HasMapping", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerMappingEntry), Member = "Draw", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerMappingState), Member = "SetupWorldRequiredStateOverloads", MemberParameters = new object[] { typeof(GUIControllerMappingStateTable) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ControlsButtonTagHandler), Member = "DrawButtonControl", MemberParameters = new object[]
			{
				typeof(SpriteBatch),
				typeof(Microsoft.Xna.Framework.Vector2),
				typeof(Microsoft.Xna.Framework.Graphics.Color),
				typeof(float),
				typeof(ControllerActionButton),
				typeof(bool)
			}, ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ControlsKeyboardTagHandler), Member = "MeasureInlineMapping", MemberParameters = new object[]
			{
				typeof(SpriteFont),
				typeof(ref SpriteFont.CharacterSource),
				typeof(int),
				typeof(ref int),
				typeof(ref Microsoft.Xna.Framework.Vector2)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControlsBanner), Member = "ItemDraw", MemberParameters = new object[]
			{
				typeof(ItemGrid_Layout),
				typeof(int),
				typeof(Microsoft.Xna.Framework.Vector2),
				typeof(float)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControlsBanner), Member = "ItemRightDraw", MemberParameters = new object[]
			{
				typeof(ItemGrid_Layout),
				typeof(int),
				typeof(Microsoft.Xna.Framework.Vector2),
				typeof(float)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControlsBanner), Member = "GetControlTag", MemberParameters = new object[] { typeof(ControllerActionButton) }, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControlsBanner), Member = "ItemSize", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(Microsoft.Xna.Framework.Vector2))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControlsBanner), Member = "AddAction", MemberParameters = new object[]
			{
				typeof(GUIControlsBanner.Action),
				typeof(int)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControlsBanner), Member = "AddAction", MemberParameters = new object[]
			{
				typeof(GUIControlsBanner.ActionSource),
				typeof(ControllerActionButton),
				typeof(string),
				typeof(Microsoft.Xna.Framework.Graphics.Texture2D),
				typeof(Rectangle),
				typeof(TransactionButton_Layout),
				typeof(bool)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIInventory), Member = "DrawItem", MemberParameters = new object[]
			{
				typeof(SpriteBatch),
				typeof(ItemGrid_Layout),
				typeof(Item[]),
				typeof(int),
				typeof(Microsoft.Xna.Framework.Vector2),
				typeof(Microsoft.Xna.Framework.Graphics.Color),
				typeof(float)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(VirtualControllerInputState), Member = "get_AimAndUseEnabled", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Lang), Member = "CanSubstituteBindings", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 19)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700082B RID: 2091
		// (get) Token: 0x060047A9 RID: 18345 RVA: 0x0002EC94 File Offset: 0x0002CE94
		[global::Cpp2ILInjected.Token(Token = "0x17000930")]
		public ControllerActionButton.RequiredButtonState RequiredState
		{
			[global::Cpp2ILInjected.Token(Token = "0x6005468")]
			[global::Cpp2ILInjected.Address(RVA = "0x949FD8", Offset = "0x949FD8", Length = "0x54")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerMappingEntry), Member = "Draw", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerMappingState), Member = "SetupWorldRequiredStateOverloads", MemberParameters = new object[] { typeof(GUIControllerMappingStateTable) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControlsBanner.Action), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(GUIControlsBanner.ActionSource),
				typeof(ControllerActionButton),
				typeof(string),
				typeof(Microsoft.Xna.Framework.Graphics.Texture2D),
				typeof(Rectangle),
				typeof(TransactionButton_Layout),
				typeof(bool),
				typeof(int)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControlsBanner), Member = "ItemDraw", MemberParameters = new object[]
			{
				typeof(ItemGrid_Layout),
				typeof(int),
				typeof(Microsoft.Xna.Framework.Vector2),
				typeof(float)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControlsBanner), Member = "ItemRightDraw", MemberParameters = new object[]
			{
				typeof(ItemGrid_Layout),
				typeof(int),
				typeof(Microsoft.Xna.Framework.Vector2),
				typeof(float)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControlsBanner), Member = "ItemSize", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(Microsoft.Xna.Framework.Vector2))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControlsBanner), Member = "AddAction", MemberParameters = new object[]
			{
				typeof(GUIControlsBanner.ActionSource),
				typeof(ControllerActionButton),
				typeof(string),
				typeof(Microsoft.Xna.Framework.Graphics.Texture2D),
				typeof(Rectangle),
				typeof(TransactionButton_Layout),
				typeof(bool)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIPlayerSelectMenu), Member = "Draw", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIWorldSelectMenu), Member = "Draw", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 24)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700082C RID: 2092
		// (get) Token: 0x060047AA RID: 18346 RVA: 0x0002EC97 File Offset: 0x0002CE97
		[global::Cpp2ILInjected.Token(Token = "0x17000931")]
		public ControllerActionButton.Entry FirstEntry
		{
			[global::Cpp2ILInjected.Token(Token = "0x6005469")]
			[global::Cpp2ILInjected.Address(RVA = "0x94A02C", Offset = "0x94A02C", Length = "0x4C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 106)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x060047AB RID: 18347 RVA: 0x0002EC9A File Offset: 0x0002CE9A
		[global::Cpp2ILInjected.Token(Token = "0x600546A")]
		[global::Cpp2ILInjected.Address(RVA = "0x94A078", Offset = "0x94A078", Length = "0x78")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUISettings), Member = "Draw", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIKeyboardMappings), Member = "SetupEscapeKeySetting", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Lang), Member = "CreateDialogSubstitutionObject", MemberParameters = new object[] { typeof(NPC) }, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Lang), Member = "CanSubstituteBindings", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 14)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public ControllerActionButton.Entry GetEntry(int index)
		{
			throw null;
		}

		// Token: 0x060047AC RID: 18348 RVA: 0x0002EC9D File Offset: 0x0002CE9D
		[global::Cpp2ILInjected.Token(Token = "0x600546B")]
		[global::Cpp2ILInjected.Address(RVA = "0x94A0F0", Offset = "0x94A0F0", Length = "0x1BC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUITransactionButton), Member = "HandleControllerAction", MemberParameters = new object[]
		{
			typeof(TransactionButton_Layout),
			typeof(ControllerActionButton),
			typeof(string),
			typeof(bool),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(GUITransactionButton.InputState))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIItemFilter), Member = "DrawFilter", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIMultiplayerChat), Member = "DrawNotification", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIPageIconGrouping), Member = "DrawOptions", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIPageIcons), Member = "OnCategoryOpened", MemberParameters = new object[] { typeof(GUIPageIcons.Category) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIPageIcons), Member = "DrawLeftMenuButton", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIVirtualInputController), Member = "Update", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIPageOptions), Member = "DrawEquipButton", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 35)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControllerActionButton), Member = "get_FirstEntry", ReturnType = typeof(ControllerActionButton.Entry))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public bool Conflicts(ControllerActionButton other)
		{
			throw null;
		}

		// Token: 0x060047AD RID: 18349 RVA: 0x0002ECA0 File Offset: 0x0002CEA0
		[global::Cpp2ILInjected.Token(Token = "0x600546C")]
		[global::Cpp2ILInjected.Address(RVA = "0x94A2AC", Offset = "0x94A2AC", Length = "0xF4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ControllerActionButton), Member = "MapAxisButton", MemberParameters = new object[]
		{
			typeof(AxisButtons),
			typeof(ControllerActionButton.RequiredButtonState),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public void MapAxis(Axis axis, float threshold, ControllerActionButton.RequiredButtonState requiredButtonState = null, bool ignoreOthersIfExists = true)
		{
			throw null;
		}

		// Token: 0x060047AE RID: 18350 RVA: 0x0002ECA3 File Offset: 0x0002CEA3
		[global::Cpp2ILInjected.Token(Token = "0x600546D")]
		[global::Cpp2ILInjected.Address(RVA = "0x94A3A8", Offset = "0x94A3A8", Length = "0xEC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerMappingState), Member = "SetupMappings", MemberParameters = new object[] { typeof(GUIControllerMappingStateTable) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerNavigationController), Member = "SetupMappings", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 26)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public void MapButton(Buttons button, ControllerActionButton.RequiredButtonState requiredButtonState = null, bool ignoreOthersIfExists = true)
		{
			throw null;
		}

		// Token: 0x060047AF RID: 18351 RVA: 0x0002ECA6 File Offset: 0x0002CEA6
		[global::Cpp2ILInjected.Token(Token = "0x600546E")]
		[global::Cpp2ILInjected.Address(RVA = "0x94A494", Offset = "0x94A494", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerMappingState), Member = "SetupMappings", MemberParameters = new object[] { typeof(GUIControllerMappingStateTable) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControllerActionManager), Member = "GetAxisThreshold", MemberParameters = new object[]
		{
			typeof(AxisButtons),
			typeof(ref float)
		}, ReturnType = typeof(Axis))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControllerActionButton), Member = "MapAxis", MemberParameters = new object[]
		{
			typeof(Axis),
			typeof(float),
			typeof(ControllerActionButton.RequiredButtonState),
			typeof(bool)
		}, ReturnType = typeof(void))]
		public void MapAxisButton(AxisButtons button, ControllerActionButton.RequiredButtonState requiredButtonState = null, bool ignoreOthersIfExists = true)
		{
			throw null;
		}

		// Token: 0x060047B0 RID: 18352 RVA: 0x0002ECA9 File Offset: 0x0002CEA9
		[global::Cpp2ILInjected.Token(Token = "0x600546F")]
		[global::Cpp2ILInjected.Address(RVA = "0x94A4EC", Offset = "0x94A4EC", Length = "0xE4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIKeyboardMappings), Member = "CreateButtonMapping", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(ControllerActionButton))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIKeyboardMappings), Member = "SetupMappings", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public void MapKey(KeyCode key, bool ignoreOthersIfExists = false)
		{
			throw null;
		}

		// Token: 0x060047B1 RID: 18353 RVA: 0x0002ECAC File Offset: 0x0002CEAC
		[global::Cpp2ILInjected.Token(Token = "0x6005470")]
		[global::Cpp2ILInjected.Address(RVA = "0x94A5D0", Offset = "0x94A5D0", Length = "0xE8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControlsBanner), Member = "AddAction", MemberParameters = new object[]
		{
			typeof(GUIControlsBanner.ActionSource),
			typeof(ControllerActionButton),
			typeof(string),
			typeof(Microsoft.Xna.Framework.Graphics.Texture2D),
			typeof(Rectangle),
			typeof(TransactionButton_Layout),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControllerActionButton), Member = "get_FirstEntry", ReturnType = typeof(ControllerActionButton.Entry))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControllerDevice), Member = "HasAxis", MemberParameters = new object[] { typeof(Axis) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControllerDevice), Member = "GetAxisTime", MemberParameters = new object[] { typeof(Axis) }, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControllerDevice), Member = "HasButton", MemberParameters = new object[] { typeof(Buttons) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControllerDevice), Member = "ButtonTime", MemberParameters = new object[] { typeof(Buttons) }, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControllerActionButton.RequiredButtonState), Member = "Valid", MemberParameters = new object[]
		{
			typeof(ControllerDevice),
			typeof(float)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public bool RequiredStateValid(ControllerDevice controller)
		{
			throw null;
		}

		// Token: 0x060047B2 RID: 18354 RVA: 0x0002ECAF File Offset: 0x0002CEAF
		[global::Cpp2ILInjected.Token(Token = "0x6005471")]
		[global::Cpp2ILInjected.Address(RVA = "0x94A6B8", Offset = "0x94A6B8", Length = "0x528")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerNavigationController), Member = "UpdateUINavigation", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUITransactionButton), Member = "HandleControllerAction", MemberParameters = new object[]
		{
			typeof(TransactionButton_Layout),
			typeof(ControllerActionButton),
			typeof(string),
			typeof(bool),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(GUITransactionButton.InputState))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControlsBanner), Member = "ItemDraw", MemberParameters = new object[]
		{
			typeof(ItemGrid_Layout),
			typeof(int),
			typeof(Microsoft.Xna.Framework.Vector2),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControlsBanner), Member = "ItemRightDraw", MemberParameters = new object[]
		{
			typeof(ItemGrid_Layout),
			typeof(int),
			typeof(Microsoft.Xna.Framework.Vector2),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControlsBanner), Member = "DrawMoreOptionsBanner", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIMap), Member = "DrawMap", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIMultiplayerChat), Member = "DrawNotification", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIPageIcons), Member = "DrawLeftMenuButton", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIVirtualInputController), Member = "Update", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PlayerInput), Member = "UpdateInput", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 59)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControllerDevice), Member = "HasAxis", MemberParameters = new object[] { typeof(Axis) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControllerDevice), Member = "GetAxis", MemberParameters = new object[] { typeof(Axis) }, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControllerDevice), Member = "GetPreviousAxis", MemberParameters = new object[] { typeof(Axis) }, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_HasKeyboard", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(KeyboardInput), Member = "GetKey", MemberParameters = new object[] { typeof(KeyCode) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XNAUIInputLayer), Member = "GetUICursor", ReturnType = typeof(global::Cursor))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XNAUnityRunner), Member = "get_TouchInputKeyboardLocked", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(KeyboardInput), Member = "GetKeyUp", MemberParameters = new object[] { typeof(KeyCode) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControllerDevice), Member = "HasButton", MemberParameters = new object[] { typeof(Buttons) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControllerDevice), Member = "ButtonState", MemberParameters = new object[] { typeof(Buttons) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControllerDevice), Member = "PreviousButtonState", MemberParameters = new object[] { typeof(Buttons) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControllerDevice), Member = "ButtonTime", MemberParameters = new object[] { typeof(Buttons) }, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControllerDevice), Member = "GetAxisTime", MemberParameters = new object[] { typeof(Axis) }, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControllerActionButton.RequiredButtonState), Member = "Valid", MemberParameters = new object[]
		{
			typeof(ControllerDevice),
			typeof(float)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControllerActionButton.RequiredButtonState), Member = "ConsumeModifiers", MemberParameters = new object[] { typeof(ControllerDevice) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
		public bool GetButtonState(ControllerDevice controller)
		{
			throw null;
		}

		// Token: 0x060047B3 RID: 18355 RVA: 0x0002ECB2 File Offset: 0x0002CEB2
		[global::Cpp2ILInjected.Token(Token = "0x6005472")]
		[global::Cpp2ILInjected.Address(RVA = "0x94ABE0", Offset = "0x94ABE0", Length = "0x4A0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerNavigationController), Member = "NextPagePressed", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerNavigationController), Member = "PreviousPagePressed", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUITransactionButton), Member = "HandleControllerAction", MemberParameters = new object[]
		{
			typeof(TransactionButton_Layout),
			typeof(ControllerActionButton),
			typeof(string),
			typeof(bool),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(GUITransactionButton.InputState))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIAmmo), Member = "ItemOver", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIBuffs), Member = "UpdateBuffNavigation", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIChest), Member = "ItemOver", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUICoins), Member = "ItemOver", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIHotbar), Member = "UpdateHotbarKeybinds", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIInventory), Member = "ItemOver", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIInventory), Member = "Draw", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIItemDuplication), Member = "DrawCraftButton", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIVirtualInputController), Member = "Update", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 25)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControllerDevice), Member = "HasAxis", MemberParameters = new object[] { typeof(Axis) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControllerDevice), Member = "GetAxis", MemberParameters = new object[] { typeof(Axis) }, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControllerDevice), Member = "GetPreviousAxis", MemberParameters = new object[] { typeof(Axis) }, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(KeyboardInput), Member = "GetKeyDown", MemberParameters = new object[] { typeof(KeyCode) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_HasKeyboard", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XNAUnityRunner), Member = "get_TouchInputKeyboardLocked", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XNAUIInputLayer), Member = "GetUICursor", ReturnType = typeof(global::Cursor))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControllerDevice), Member = "HasButton", MemberParameters = new object[] { typeof(Buttons) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControllerDevice), Member = "ButtonDown", MemberParameters = new object[] { typeof(Buttons) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControllerDevice), Member = "ButtonTime", MemberParameters = new object[] { typeof(Buttons) }, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControllerDevice), Member = "GetAxisTime", MemberParameters = new object[] { typeof(Axis) }, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControllerActionButton.RequiredButtonState), Member = "Valid", MemberParameters = new object[]
		{
			typeof(ControllerDevice),
			typeof(float)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControllerActionButton.RequiredButtonState), Member = "ConsumeModifiers", MemberParameters = new object[] { typeof(ControllerDevice) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		public bool GetButtonDown(ControllerDevice controller)
		{
			throw null;
		}

		// Token: 0x060047B4 RID: 18356 RVA: 0x0002ECB5 File Offset: 0x0002CEB5
		[global::Cpp2ILInjected.Token(Token = "0x6005473")]
		[global::Cpp2ILInjected.Address(RVA = "0x94B080", Offset = "0x94B080", Length = "0x6C4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 61)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControllerDevice), Member = "HasAxis", MemberParameters = new object[] { typeof(Axis) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControllerDevice), Member = "GetAxis", MemberParameters = new object[] { typeof(Axis) }, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControllerDevice), Member = "GetPreviousAxis", MemberParameters = new object[] { typeof(Axis) }, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_HasKeyboard", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(KeyboardInput), Member = "GetKeyUp", MemberParameters = new object[] { typeof(KeyCode) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XNAUIInputLayer), Member = "GetUICursor", ReturnType = typeof(global::Cursor))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XNAUnityRunner), Member = "get_TouchInputKeyboardLocked", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(KeyboardInput), Member = "GetKey", MemberParameters = new object[] { typeof(KeyCode) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControllerDevice), Member = "HasButton", MemberParameters = new object[] { typeof(Buttons) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControllerDevice), Member = "ButtonUp", MemberParameters = new object[] { typeof(Buttons) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControllerDevice), Member = "ButtonTime", MemberParameters = new object[] { typeof(Buttons) }, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControllerDevice), Member = "ButtonConsumed", MemberParameters = new object[] { typeof(Buttons) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControllerDevice), Member = "GetAxisTime", MemberParameters = new object[] { typeof(Axis) }, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControllerDevice), Member = "PreviousButtonState", MemberParameters = new object[] { typeof(Buttons) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControllerDevice), Member = "ButtonState", MemberParameters = new object[] { typeof(Buttons) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControllerActionButton.RequiredButtonState), Member = "Valid", MemberParameters = new object[]
		{
			typeof(ControllerDevice),
			typeof(float)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControllerActionButton.RequiredButtonState), Member = "ConsumeModifiers", MemberParameters = new object[] { typeof(ControllerDevice) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 12)]
		public bool GetButtonUp(ControllerDevice controller)
		{
			throw null;
		}

		// Token: 0x060047B5 RID: 18357 RVA: 0x0002ECB8 File Offset: 0x0002CEB8
		[global::Cpp2ILInjected.Token(Token = "0x6005474")]
		[global::Cpp2ILInjected.Address(RVA = "0x94B744", Offset = "0x94B744", Length = "0x68")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerMappings), Member = "ClearWorldMappings", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerMappings), Member = "ClearInventoryMappings", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 80)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new object[]
		{
			typeof(Array),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public void Clear()
		{
			throw null;
		}

		// Token: 0x060047B6 RID: 18358 RVA: 0x0002ECBB File Offset: 0x0002CEBB
		[global::Cpp2ILInjected.Token(Token = "0x6005475")]
		[global::Cpp2ILInjected.Address(RVA = "0x94B7AC", Offset = "0x94B7AC", Length = "0x84")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ControllerActionManager), Member = "CreateButtonMapping", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(ControllerActionButton))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public ControllerActionButton()
		{
			throw null;
		}

		// Token: 0x0400738A RID: 29578
		[global::Cpp2ILInjected.Token(Token = "0x4008D3A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		public string Id;

		// Token: 0x0400738B RID: 29579
		[global::Cpp2ILInjected.Token(Token = "0x4008D3B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		public bool Enabled;

		// Token: 0x0400738C RID: 29580
		[global::Cpp2ILInjected.Token(Token = "0x4008D3C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x19")]
		public bool DisableUnitlClear;

		// Token: 0x0400738D RID: 29581
		[global::Cpp2ILInjected.Token(Token = "0x4008D3D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C")]
		public int DisplayPriority;

		// Token: 0x0400738E RID: 29582
		[global::Cpp2ILInjected.Token(Token = "0x4008D3E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		public ControllerActionButton LinkedAction;

		// Token: 0x0400738F RID: 29583
		[global::Cpp2ILInjected.Token(Token = "0x4008D3F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private List<ControllerActionButton.Entry> _entries;

		// Token: 0x02000ADF RID: 2783
		[global::Cpp2ILInjected.Token(Token = "0x2000B58")]
		public class RequiredButtonState
		{
			// Token: 0x060052EB RID: 21227 RVA: 0x00030A07 File Offset: 0x0002EC07
			[global::Cpp2ILInjected.Token(Token = "0x6005476")]
			[global::Cpp2ILInjected.Address(RVA = "0x94B830", Offset = "0x94B830", Length = "0x14")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerMappingState), Member = "SetupWorldRequiredStateOverloads", MemberParameters = new object[] { typeof(GUIControllerMappingStateTable) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerMappingState), Member = "SetupMappings", MemberParameters = new object[] { typeof(GUIControllerMappingStateTable) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerMappingStateTable), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 8)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public RequiredButtonState()
			{
				throw null;
			}

			// Token: 0x060052EC RID: 21228 RVA: 0x00030A0A File Offset: 0x0002EC0A
			[global::Cpp2ILInjected.Token(Token = "0x6005477")]
			[global::Cpp2ILInjected.Address(RVA = "0x94B844", Offset = "0x94B844", Length = "0x3C")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerNavigationController), Member = "SetupMappings", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public RequiredButtonState(Buttons button, bool requiredState)
			{
				throw null;
			}

			// Token: 0x060052ED RID: 21229 RVA: 0x00030A0D File Offset: 0x0002EC0D
			[global::Cpp2ILInjected.Token(Token = "0x6005478")]
			[global::Cpp2ILInjected.Address(RVA = "0x94B880", Offset = "0x94B880", Length = "0x54")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerMappings), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public RequiredButtonState(Buttons button, bool requiredState, Buttons button2, bool requiredState2)
			{
				throw null;
			}

			// Token: 0x060052EE RID: 21230 RVA: 0x00030A10 File Offset: 0x0002EC10
			[global::Cpp2ILInjected.Token(Token = "0x6005479")]
			[global::Cpp2ILInjected.Address(RVA = "0x9499D0", Offset = "0x9499D0", Length = "0xD0")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ControllerActionAxis), Member = "Active", MemberParameters = new object[] { typeof(ControllerDevice) }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControllerDevice), Member = "ButtonState", MemberParameters = new object[] { typeof(Buttons) }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControllerDevice), Member = "ButtonTime", MemberParameters = new object[] { typeof(Buttons) }, ReturnType = typeof(float))]
			public bool Active(ControllerDevice device, float buttonPressTime, float axisValue)
			{
				throw null;
			}

			// Token: 0x060052EF RID: 21231 RVA: 0x00030A13 File Offset: 0x0002EC13
			[global::Cpp2ILInjected.Token(Token = "0x600547A")]
			[global::Cpp2ILInjected.Address(RVA = "0x949320", Offset = "0x949320", Length = "0xF0")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ControllerActionAxis), Member = "RequiredStateValid", MemberParameters = new object[] { typeof(ControllerDevice) }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ControllerActionAxis), Member = "GetValue", MemberParameters = new object[] { typeof(ControllerDevice) }, ReturnType = typeof(float))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ControllerActionButton), Member = "RequiredStateValid", MemberParameters = new object[] { typeof(ControllerDevice) }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ControllerActionButton), Member = "GetButtonState", MemberParameters = new object[] { typeof(ControllerDevice) }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ControllerActionButton), Member = "GetButtonDown", MemberParameters = new object[] { typeof(ControllerDevice) }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ControllerActionButton), Member = "GetButtonUp", MemberParameters = new object[] { typeof(ControllerDevice) }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControllerDevice), Member = "ButtonState", MemberParameters = new object[] { typeof(Buttons) }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControllerDevice), Member = "ButtonTime", MemberParameters = new object[] { typeof(Buttons) }, ReturnType = typeof(float))]
			public bool Valid(ControllerDevice device, float buttonPressTime)
			{
				throw null;
			}

			// Token: 0x060052F0 RID: 21232 RVA: 0x00030A16 File Offset: 0x0002EC16
			[global::Cpp2ILInjected.Token(Token = "0x600547B")]
			[global::Cpp2ILInjected.Address(RVA = "0x949E34", Offset = "0x949E34", Length = "0x68")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ControllerActionAxis), Member = "GetValue", MemberParameters = new object[] { typeof(ControllerDevice) }, ReturnType = typeof(float))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ControllerActionButton), Member = "GetButtonState", MemberParameters = new object[] { typeof(ControllerDevice) }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ControllerActionButton), Member = "GetButtonDown", MemberParameters = new object[] { typeof(ControllerDevice) }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ControllerActionButton), Member = "GetButtonUp", MemberParameters = new object[] { typeof(ControllerDevice) }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControllerDevice), Member = "SetButtonConsumbed", MemberParameters = new object[] { typeof(Buttons) }, ReturnType = typeof(void))]
			public void ConsumeModifiers(ControllerDevice device)
			{
				throw null;
			}

			// Token: 0x04008FB7 RID: 36791
			[global::Cpp2ILInjected.Token(Token = "0x4008D40")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			public Buttons Button;

			// Token: 0x04008FB8 RID: 36792
			[global::Cpp2ILInjected.Token(Token = "0x4008D41")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
			public bool state;

			// Token: 0x04008FB9 RID: 36793
			[global::Cpp2ILInjected.Token(Token = "0x4008D42")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
			public Buttons Button2;

			// Token: 0x04008FBA RID: 36794
			[global::Cpp2ILInjected.Token(Token = "0x4008D43")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C")]
			public bool state2;
		}

		// Token: 0x02000AE0 RID: 2784
		[global::Cpp2ILInjected.Token(Token = "0x2000B59")]
		public class Entry
		{
			// Token: 0x060052F1 RID: 21233 RVA: 0x00030A19 File Offset: 0x0002EC19
			[global::Cpp2ILInjected.Token(Token = "0x600547C")]
			[global::Cpp2ILInjected.Address(RVA = "0x94A3A0", Offset = "0x94A3A0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public Entry()
			{
				throw null;
			}

			// Token: 0x04008FBB RID: 36795
			[global::Cpp2ILInjected.Token(Token = "0x4008D44")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			public ControllerActionButton.Entry.Type MappingType;

			// Token: 0x04008FBC RID: 36796
			[global::Cpp2ILInjected.Token(Token = "0x4008D45")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
			public Axis Axis0;

			// Token: 0x04008FBD RID: 36797
			[global::Cpp2ILInjected.Token(Token = "0x4008D46")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
			public float Threshold;

			// Token: 0x04008FBE RID: 36798
			[global::Cpp2ILInjected.Token(Token = "0x4008D47")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C")]
			public Buttons Button;

			// Token: 0x04008FBF RID: 36799
			[global::Cpp2ILInjected.Token(Token = "0x4008D48")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
			public KeyCode InputKey;

			// Token: 0x04008FC0 RID: 36800
			[global::Cpp2ILInjected.Token(Token = "0x4008D49")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x24")]
			public bool IgnoreOthersIfExists;

			// Token: 0x04008FC1 RID: 36801
			[global::Cpp2ILInjected.Token(Token = "0x4008D4A")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
			public ControllerActionButton.RequiredButtonState RequiredState;

			// Token: 0x02000BD4 RID: 3028
			[global::Cpp2ILInjected.Token(Token = "0x2000B5A")]
			public enum Type
			{
				// Token: 0x0400916C RID: 37228
				[global::Cpp2ILInjected.Token(Token = "0x4008D4C")]
				Axis,
				// Token: 0x0400916D RID: 37229
				[global::Cpp2ILInjected.Token(Token = "0x4008D4D")]
				Button,
				// Token: 0x0400916E RID: 37230
				[global::Cpp2ILInjected.Token(Token = "0x4008D4E")]
				InputKey
			}
		}
	}
}
