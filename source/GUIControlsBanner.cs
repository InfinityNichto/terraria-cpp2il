using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Controller;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using UnityEngine;

// Token: 0x020000D4 RID: 212
[global::Cpp2ILInjected.Token(Token = "0x200012F")]
public class GUIControlsBanner
{
	// Token: 0x060006F2 RID: 1778 RVA: 0x0002301B File Offset: 0x0002121B
	[global::Cpp2ILInjected.Token(Token = "0x60007E5")]
	[global::Cpp2ILInjected.Address(RVA = "0x13ED088", Offset = "0x13ED088", Length = "0x8")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	private float ItemScale(int index)
	{
		throw null;
	}

	// Token: 0x060006F3 RID: 1779 RVA: 0x0002301E File Offset: 0x0002121E
	[global::Cpp2ILInjected.Token(Token = "0x60007E6")]
	[global::Cpp2ILInjected.Address(RVA = "0x13ED090", Offset = "0x13ED090", Length = "0x4")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	private void ItemOver(int index)
	{
		throw null;
	}

	// Token: 0x060006F4 RID: 1780 RVA: 0x00023021 File Offset: 0x00021221
	[global::Cpp2ILInjected.Token(Token = "0x60007E7")]
	[global::Cpp2ILInjected.Address(RVA = "0x13ED094", Offset = "0x13ED094", Length = "0x65C")]
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
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle), Member = "Union", MemberParameters = new object[]
	{
		typeof(Rectangle),
		typeof(Rectangle)
	}, ReturnType = typeof(Rectangle))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle), Member = "get_Center", ReturnType = typeof(Point))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControllerActionManager), Member = "get_ActiveController", ReturnType = typeof(ControllerDevice))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControllerActionVector), Member = "get_HasMapping", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControllerActionVector), Member = "get_RequiredState", ReturnType = typeof(ControllerActionButton.RequiredButtonState))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControllerActionVector), Member = "get_MappedX", ReturnType = typeof(ControllerActionAxis))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControllerActionAxis), Member = "get_FirstEntry", ReturnType = typeof(ControllerActionAxis.Entry))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControllerActionButton), Member = "get_HasMapping", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControllerActionButton), Member = "get_RequiredState", ReturnType = typeof(ControllerActionButton.RequiredButtonState))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControllerActionButton), Member = "get_FirstEntry", ReturnType = typeof(ControllerActionButton.Entry))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerInputButton), Member = "GetButtonTexureInformation", MemberParameters = new object[]
	{
		typeof(GUIControllerInputButton.LinkedControlType),
		typeof(ref Rectangle),
		typeof(int)
	}, ReturnType = typeof(Microsoft.Xna.Framework.Graphics.Texture2D))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControllerActionButton), Member = "GetButtonState", MemberParameters = new object[] { typeof(ControllerDevice) }, ReturnType = typeof(bool))]
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
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerInputButton), Member = "GetAxisTexureInformation", MemberParameters = new object[]
	{
		typeof(GUIControllerInputButton.AxisControl),
		typeof(ref Rectangle),
		typeof(int)
	}, ReturnType = typeof(Microsoft.Xna.Framework.Graphics.Texture2D))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControlsBanner), Member = "FromAxis", MemberParameters = new object[]
	{
		typeof(Axis),
		typeof(float)
	}, ReturnType = typeof(GUIControllerInputButton.AxisControl))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControllerActionVector), Member = "GetValue", MemberParameters = new object[] { typeof(ControllerDevice) }, ReturnType = typeof(global::UnityEngine.Vector2))]
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
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
	public void ItemDraw(ItemGrid_Layout gridLayout, int index, Microsoft.Xna.Framework.Vector2 position, float scale)
	{
		throw null;
	}

	// Token: 0x060006F5 RID: 1781 RVA: 0x00023024 File Offset: 0x00021224
	[global::Cpp2ILInjected.Token(Token = "0x60007E8")]
	[global::Cpp2ILInjected.Address(RVA = "0x13ED7E4", Offset = "0x13ED7E4", Length = "0x658")]
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
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControllerActionManager), Member = "get_ActiveController", ReturnType = typeof(ControllerDevice))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControllerActionVector), Member = "get_HasMapping", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControllerActionVector), Member = "get_RequiredState", ReturnType = typeof(ControllerActionButton.RequiredButtonState))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControllerActionVector), Member = "get_MappedX", ReturnType = typeof(ControllerActionAxis))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControllerActionAxis), Member = "get_FirstEntry", ReturnType = typeof(ControllerActionAxis.Entry))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControllerActionButton), Member = "get_HasMapping", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControllerActionButton), Member = "get_RequiredState", ReturnType = typeof(ControllerActionButton.RequiredButtonState))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControllerActionButton), Member = "get_FirstEntry", ReturnType = typeof(ControllerActionButton.Entry))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerInputButton), Member = "GetButtonTexureInformation", MemberParameters = new object[]
	{
		typeof(GUIControllerInputButton.LinkedControlType),
		typeof(ref Rectangle),
		typeof(int)
	}, ReturnType = typeof(Microsoft.Xna.Framework.Graphics.Texture2D))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControllerActionButton), Member = "GetButtonState", MemberParameters = new object[] { typeof(ControllerDevice) }, ReturnType = typeof(bool))]
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
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerInputButton), Member = "GetAxisTexureInformation", MemberParameters = new object[]
	{
		typeof(GUIControllerInputButton.AxisControl),
		typeof(ref Rectangle),
		typeof(int)
	}, ReturnType = typeof(Microsoft.Xna.Framework.Graphics.Texture2D))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControlsBanner), Member = "FromAxis", MemberParameters = new object[]
	{
		typeof(Axis),
		typeof(float)
	}, ReturnType = typeof(GUIControllerInputButton.AxisControl))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControllerActionVector), Member = "GetValue", MemberParameters = new object[] { typeof(ControllerDevice) }, ReturnType = typeof(global::UnityEngine.Vector2))]
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
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle), Member = "Union", MemberParameters = new object[]
	{
		typeof(Rectangle),
		typeof(Rectangle)
	}, ReturnType = typeof(Rectangle))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle), Member = "get_Center", ReturnType = typeof(Point))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
	public void ItemRightDraw(ItemGrid_Layout gridLayout, int index, Microsoft.Xna.Framework.Vector2 position, float scale)
	{
		throw null;
	}

	// Token: 0x060006F6 RID: 1782 RVA: 0x00023027 File Offset: 0x00021227
	[global::Cpp2ILInjected.Token(Token = "0x60007E9")]
	[global::Cpp2ILInjected.Address(RVA = "0x13ED6F0", Offset = "0x13ED6F0", Length = "0x1C")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerMappingEntry), Member = "Draw", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ControlsButtonTagHandler), Member = "DrawButtonControl", MemberParameters = new object[]
	{
		typeof(SpriteBatch),
		typeof(Microsoft.Xna.Framework.Vector2),
		typeof(Microsoft.Xna.Framework.Graphics.Color),
		typeof(float),
		typeof(ControllerActionButton),
		typeof(bool)
	}, ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ControlsButtonTagHandler), Member = "DrawAxisControl", MemberParameters = new object[]
	{
		typeof(SpriteBatch),
		typeof(Microsoft.Xna.Framework.Vector2),
		typeof(Microsoft.Xna.Framework.Graphics.Color),
		typeof(float),
		typeof(ControllerActionVector),
		typeof(bool)
	}, ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 9)]
	public static GUIControllerInputButton.LinkedControlType FromButton(Buttons button)
	{
		throw null;
	}

	// Token: 0x060006F7 RID: 1783 RVA: 0x0002302A File Offset: 0x0002122A
	[global::Cpp2ILInjected.Token(Token = "0x60007EA")]
	[global::Cpp2ILInjected.Address(RVA = "0x13EDE3C", Offset = "0x13EDE3C", Length = "0x208")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControlsBanner), Member = "AddAction", MemberParameters = new object[]
	{
		typeof(GUIControlsBanner.Action),
		typeof(int)
	}, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControllerActionVector), Member = "get_HasMapping", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControllerActionAxis), Member = "get_FirstEntry", ReturnType = typeof(ControllerActionAxis.Entry))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(int), Member = "ToString", ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
	{
		typeof(string),
		typeof(string),
		typeof(string),
		typeof(string)
	}, ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
	public string GetControlTag(ControllerActionVector action)
	{
		throw null;
	}

	// Token: 0x060006F8 RID: 1784 RVA: 0x0002302D File Offset: 0x0002122D
	[global::Cpp2ILInjected.Token(Token = "0x60007EB")]
	[global::Cpp2ILInjected.Address(RVA = "0x13EE044", Offset = "0x13EE044", Length = "0x204")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControlsBanner), Member = "AddAction", MemberParameters = new object[]
	{
		typeof(GUIControlsBanner.Action),
		typeof(int)
	}, ReturnType = typeof(bool))]
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
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Lang), Member = "CreateDialogSubstitutionObject", MemberParameters = new object[] { typeof(NPC) }, ReturnType = typeof(object))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 14)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControllerActionButton), Member = "get_HasMapping", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControllerActionButton), Member = "get_FirstEntry", ReturnType = typeof(ControllerActionButton.Entry))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(int), Member = "ToString", ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
	{
		typeof(string),
		typeof(string),
		typeof(string),
		typeof(string)
	}, ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControlsBanner), Member = "FromAxis", MemberParameters = new object[]
	{
		typeof(Axis),
		typeof(float)
	}, ReturnType = typeof(GUIControllerInputButton.AxisControl))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
	public string GetControlTag(ControllerActionButton action)
	{
		throw null;
	}

	// Token: 0x060006F9 RID: 1785 RVA: 0x00023030 File Offset: 0x00021230
	[global::Cpp2ILInjected.Token(Token = "0x60007EC")]
	[global::Cpp2ILInjected.Address(RVA = "0x13ED70C", Offset = "0x13ED70C", Length = "0xD8")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerMappingEntry), Member = "Draw", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ControlsButtonTagHandler), Member = "DrawButtonControl", MemberParameters = new object[]
	{
		typeof(SpriteBatch),
		typeof(Microsoft.Xna.Framework.Vector2),
		typeof(Microsoft.Xna.Framework.Graphics.Color),
		typeof(float),
		typeof(ControllerActionButton),
		typeof(bool)
	}, ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ControlsButtonTagHandler), Member = "DrawAxisControl", MemberParameters = new object[]
	{
		typeof(SpriteBatch),
		typeof(Microsoft.Xna.Framework.Vector2),
		typeof(Microsoft.Xna.Framework.Graphics.Color),
		typeof(float),
		typeof(ControllerActionVector),
		typeof(bool)
	}, ReturnType = typeof(int))]
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
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 11)]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	public static GUIControllerInputButton.AxisControl FromAxis(Axis axis, float threshold)
	{
		throw null;
	}

	// Token: 0x060006FA RID: 1786 RVA: 0x00023033 File Offset: 0x00021233
	[global::Cpp2ILInjected.Token(Token = "0x60007ED")]
	[global::Cpp2ILInjected.Address(RVA = "0x13EE248", Offset = "0x13EE248", Length = "0x1AC")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControllerActionVector), Member = "get_HasMapping", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControllerActionVector), Member = "get_RequiredState", ReturnType = typeof(ControllerActionButton.RequiredButtonState))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControllerActionButton), Member = "get_HasMapping", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControllerActionButton), Member = "get_RequiredState", ReturnType = typeof(ControllerActionButton.RequiredButtonState))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(String_Layout), Member = "GetFont", ReturnType = typeof(SpriteFont))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteFont), Member = "MeasureString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(Microsoft.Xna.Framework.Vector2))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Microsoft.Xna.Framework.Vector2), Member = "op_Multiply", MemberParameters = new object[]
	{
		typeof(Microsoft.Xna.Framework.Vector2),
		typeof(float)
	}, ReturnType = typeof(Microsoft.Xna.Framework.Vector2))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
	private Microsoft.Xna.Framework.Vector2 ItemSize(int index)
	{
		throw null;
	}

	// Token: 0x060006FB RID: 1787 RVA: 0x00023036 File Offset: 0x00021236
	[global::Cpp2ILInjected.Token(Token = "0x60007EE")]
	[global::Cpp2ILInjected.Address(RVA = "0x13EE3F4", Offset = "0x13EE3F4", Length = "0x9C")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIString), Member = "GetRegion", MemberParameters = new object[]
	{
		typeof(String_Layout),
		typeof(string)
	}, ReturnType = typeof(Rectangle))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
	private Rectangle ItemRightTextRegion(int index)
	{
		throw null;
	}

	// Token: 0x060006FC RID: 1788 RVA: 0x00023039 File Offset: 0x00021239
	[global::Cpp2ILInjected.Token(Token = "0x60007EF")]
	[global::Cpp2ILInjected.Address(RVA = "0x13EE490", Offset = "0x13EE490", Length = "0xBC")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControlsBanner), Member = "DrawControl", MemberParameters = new object[]
	{
		typeof(TransactionButton_Layout),
		typeof(ControlsBanner_Layout.ControlGroupingPosition),
		typeof(Microsoft.Xna.Framework.Vector2),
		typeof(GUIControlsBanner.Action),
		typeof(ref float)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Microsoft.Xna.Framework.Vector2), Member = "op_Addition", MemberParameters = new object[]
	{
		typeof(Microsoft.Xna.Framework.Vector2),
		typeof(Microsoft.Xna.Framework.Vector2)
	}, ReturnType = typeof(Microsoft.Xna.Framework.Vector2))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
	private void LoadControlPosition(TransactionButton_Layout layout, ControlsBanner_Layout.ControlGroupingPosition position, Microsoft.Xna.Framework.Vector2 offset)
	{
		throw null;
	}

	// Token: 0x060006FD RID: 1789 RVA: 0x0002303C File Offset: 0x0002123C
	[global::Cpp2ILInjected.Token(Token = "0x60007F0")]
	[global::Cpp2ILInjected.Address(RVA = "0x13EE54C", Offset = "0x13EE54C", Length = "0x114")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControlsBanner), Member = "LoadControlPosition", MemberParameters = new object[]
	{
		typeof(TransactionButton_Layout),
		typeof(ControlsBanner_Layout.ControlGroupingPosition),
		typeof(Microsoft.Xna.Framework.Vector2)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Texture_Layout), Member = "Copy", MemberParameters = new object[] { typeof(Texture_Layout) }, ReturnType = typeof(void))]
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
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	private void DrawControl(TransactionButton_Layout layout, ControlsBanner_Layout.ControlGroupingPosition position, Microsoft.Xna.Framework.Vector2 offset, GUIControlsBanner.Action action, ref float scale)
	{
		throw null;
	}

	// Token: 0x060006FE RID: 1790 RVA: 0x0002303F File Offset: 0x0002123F
	[global::Cpp2ILInjected.Token(Token = "0x60007F1")]
	[global::Cpp2ILInjected.Address(RVA = "0x13EE660", Offset = "0x13EE660", Length = "0x74")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControlsBanner), Member = "DrawControlsBanner", MemberParameters = new object[] { typeof(GUIControlsBanner.ActionSource) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LayoutCalculator), Member = "GetAnchoredPosition", MemberParameters = new object[]
	{
		typeof(ControlAnchor.ControlId),
		typeof(LayoutCalculator.AnchorType),
		typeof(Microsoft.Xna.Framework.Vector2)
	}, ReturnType = typeof(Microsoft.Xna.Framework.Vector2))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
	private Microsoft.Xna.Framework.Vector2 GetControlPoint(ControlsBanner_Layout.ControlGroupingPosition layoutItem)
	{
		throw null;
	}

	// Token: 0x060006FF RID: 1791 RVA: 0x00023042 File Offset: 0x00021242
	[global::Cpp2ILInjected.Token(Token = "0x60007F2")]
	[global::Cpp2ILInjected.Address(RVA = "0x13EE6D4", Offset = "0x13EE6D4", Length = "0x254")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControlsBanner), Member = "DrawHorizontalControlsBanner", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = "get_Length", ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControllerActionVector), Member = "get_HasMapping", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(StringBuilder))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControlsBanner), Member = "GetControlTag", MemberParameters = new object[] { typeof(ControllerActionVector) }, ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControllerActionButton), Member = "get_HasMapping", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControlsBanner), Member = "GetControlTag", MemberParameters = new object[] { typeof(ControllerActionButton) }, ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(String_Layout), Member = "GetFont", ReturnType = typeof(SpriteFont))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteFont), Member = "MeasureString", MemberParameters = new object[] { typeof(StringBuilder) }, ReturnType = typeof(Microsoft.Xna.Framework.Vector2))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = "Remove", MemberParameters = new object[]
	{
		typeof(int),
		typeof(int)
	}, ReturnType = typeof(StringBuilder))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
	private bool AddAction(GUIControlsBanner.Action action, int maxWidth)
	{
		throw null;
	}

	// Token: 0x06000700 RID: 1792 RVA: 0x00023045 File Offset: 0x00021245
	[global::Cpp2ILInjected.Token(Token = "0x60007F3")]
	[global::Cpp2ILInjected.Address(RVA = "0x13EE928", Offset = "0x13EE928", Length = "0x350")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControlsBanner), Member = "DrawHorizontalControlsBanner", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = "get_Length", ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(StringBuilder))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(int), Member = "ToString", ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
	{
		typeof(string),
		typeof(string),
		typeof(string)
	}, ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(String_Layout), Member = "GetFont", ReturnType = typeof(SpriteFont))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteFont), Member = "MeasureString", MemberParameters = new object[] { typeof(StringBuilder) }, ReturnType = typeof(Microsoft.Xna.Framework.Vector2))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = "Remove", MemberParameters = new object[]
	{
		typeof(int),
		typeof(int)
	}, ReturnType = typeof(StringBuilder))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 17)]
	private bool AddMore(int maxWidth)
	{
		throw null;
	}

	// Token: 0x06000701 RID: 1793 RVA: 0x00023048 File Offset: 0x00021248
	[global::Cpp2ILInjected.Token(Token = "0x60007F4")]
	[global::Cpp2ILInjected.Address(RVA = "0x13EEC78", Offset = "0x13EEC78", Length = "0x6C")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(int), Member = "CompareTo", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
	public int SortActionByDisplayPriority(GUIControlsBanner.Action x, GUIControlsBanner.Action y)
	{
		throw null;
	}

	// Token: 0x06000702 RID: 1794 RVA: 0x0002304B File Offset: 0x0002124B
	[global::Cpp2ILInjected.Token(Token = "0x60007F5")]
	[global::Cpp2ILInjected.Address(RVA = "0x13EECE4", Offset = "0x13EECE4", Length = "0x350")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControlsBanner), Member = "Draw", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = "Clear", ReturnType = typeof(StringBuilder))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Comparison<object>), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(object),
		typeof(IntPtr)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "Sort", MemberParameters = new object[] { typeof(Comparison<object>) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControlsBanner), Member = "AddAction", MemberParameters = new object[]
	{
		typeof(GUIControlsBanner.Action),
		typeof(int)
	}, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControlsBanner), Member = "AddMore", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIString), Member = "Draw", MemberParameters = new object[]
	{
		typeof(String_Layout),
		typeof(StringBuilder)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 17)]
	public void DrawHorizontalControlsBanner()
	{
		throw null;
	}

	// Token: 0x06000703 RID: 1795 RVA: 0x0002304E File Offset: 0x0002124E
	[global::Cpp2ILInjected.Token(Token = "0x60007F6")]
	[global::Cpp2ILInjected.Address(RVA = "0x13EF034", Offset = "0x13EF034", Length = "0x4BC")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Comparison<object>), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(object),
		typeof(IntPtr)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "Sort", MemberParameters = new object[] { typeof(Comparison<object>) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LayoutCalculator), Member = "GetAnchoredPosition", MemberParameters = new object[]
	{
		typeof(ControlAnchor.ControlId),
		typeof(LayoutCalculator.AnchorType),
		typeof(Microsoft.Xna.Framework.Vector2)
	}, ReturnType = typeof(Microsoft.Xna.Framework.Vector2))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(int),
		typeof(int),
		typeof(int),
		typeof(int)
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
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIItemGrid), Member = "Draw", MemberParameters = new object[]
	{
		typeof(ItemGrid_Layout),
		typeof(GUIItemGrid.GetItemScaleHandler),
		typeof(GUIItemGrid.CursorOver),
		typeof(GUIItemGrid.DrawItemHandler),
		typeof(int),
		typeof(Microsoft.Xna.Framework.Graphics.Texture2D)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "TopLeft", MemberParameters = new object[] { typeof(Rectangle) }, ReturnType = typeof(Microsoft.Xna.Framework.Vector2))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Microsoft.Xna.Framework.Vector2), Member = "op_Addition", MemberParameters = new object[]
	{
		typeof(Microsoft.Xna.Framework.Vector2),
		typeof(Microsoft.Xna.Framework.Vector2)
	}, ReturnType = typeof(Microsoft.Xna.Framework.Vector2))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "BottomRight", MemberParameters = new object[] { typeof(Rectangle) }, ReturnType = typeof(Microsoft.Xna.Framework.Vector2))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Microsoft.Xna.Framework.Vector2), Member = "op_Subtraction", MemberParameters = new object[]
	{
		typeof(Microsoft.Xna.Framework.Vector2),
		typeof(Microsoft.Xna.Framework.Vector2)
	}, ReturnType = typeof(Microsoft.Xna.Framework.Vector2))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPanel), Member = "DrawAtPosition", MemberParameters = new object[]
	{
		typeof(Panel_Layout),
		typeof(Microsoft.Xna.Framework.Vector2),
		typeof(Microsoft.Xna.Framework.Vector2),
		typeof(bool)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 30)]
	public void DrawLeftControlsBanner()
	{
		throw null;
	}

	// Token: 0x06000704 RID: 1796 RVA: 0x00023051 File Offset: 0x00021251
	[global::Cpp2ILInjected.Token(Token = "0x60007F7")]
	[global::Cpp2ILInjected.Address(RVA = "0x13EF4F0", Offset = "0x13EF4F0", Length = "0x4BC")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Comparison<object>), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(object),
		typeof(IntPtr)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "Sort", MemberParameters = new object[] { typeof(Comparison<object>) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LayoutCalculator), Member = "GetAnchoredPosition", MemberParameters = new object[]
	{
		typeof(ControlAnchor.ControlId),
		typeof(LayoutCalculator.AnchorType),
		typeof(Microsoft.Xna.Framework.Vector2)
	}, ReturnType = typeof(Microsoft.Xna.Framework.Vector2))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(int),
		typeof(int),
		typeof(int),
		typeof(int)
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
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIItemGrid), Member = "Draw", MemberParameters = new object[]
	{
		typeof(ItemGrid_Layout),
		typeof(GUIItemGrid.GetItemScaleHandler),
		typeof(GUIItemGrid.CursorOver),
		typeof(GUIItemGrid.DrawItemHandler),
		typeof(int),
		typeof(Microsoft.Xna.Framework.Graphics.Texture2D)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "TopLeft", MemberParameters = new object[] { typeof(Rectangle) }, ReturnType = typeof(Microsoft.Xna.Framework.Vector2))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Microsoft.Xna.Framework.Vector2), Member = "op_Addition", MemberParameters = new object[]
	{
		typeof(Microsoft.Xna.Framework.Vector2),
		typeof(Microsoft.Xna.Framework.Vector2)
	}, ReturnType = typeof(Microsoft.Xna.Framework.Vector2))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "BottomRight", MemberParameters = new object[] { typeof(Rectangle) }, ReturnType = typeof(Microsoft.Xna.Framework.Vector2))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Microsoft.Xna.Framework.Vector2), Member = "op_Subtraction", MemberParameters = new object[]
	{
		typeof(Microsoft.Xna.Framework.Vector2),
		typeof(Microsoft.Xna.Framework.Vector2)
	}, ReturnType = typeof(Microsoft.Xna.Framework.Vector2))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPanel), Member = "DrawAtPosition", MemberParameters = new object[]
	{
		typeof(Panel_Layout),
		typeof(Microsoft.Xna.Framework.Vector2),
		typeof(Microsoft.Xna.Framework.Vector2),
		typeof(bool)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 30)]
	public void DrawRightControlsBanner()
	{
		throw null;
	}

	// Token: 0x06000705 RID: 1797 RVA: 0x00023054 File Offset: 0x00021254
	[global::Cpp2ILInjected.Token(Token = "0x60007F8")]
	[global::Cpp2ILInjected.Address(RVA = "0x13EF9AC", Offset = "0x13EF9AC", Length = "0x744")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControlsBanner), Member = "AddAction", MemberParameters = new object[]
	{
		typeof(GUIControlsBanner.ActionSource),
		typeof(ControllerActionButton),
		typeof(string),
		typeof(Microsoft.Xna.Framework.Graphics.Texture2D),
		typeof(Rectangle),
		typeof(TransactionButton_Layout),
		typeof(bool)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControlsBanner), Member = "GetControlPoint", MemberParameters = new object[] { typeof(ControlsBanner_Layout.ControlGroupingPosition) }, ReturnType = typeof(Microsoft.Xna.Framework.Vector2))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUINPCDialogue), Member = "LoadRegion", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIClothesWindow), Member = "LoadRegion", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIHairWindow), Member = "LoadRegion", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LayoutCalculator), Member = "GetAnchoredPosition", MemberParameters = new object[]
	{
		typeof(ControlAnchor.ControlId),
		typeof(LayoutCalculator.AnchorType),
		typeof(Microsoft.Xna.Framework.Vector2)
	}, ReturnType = typeof(Microsoft.Xna.Framework.Vector2))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(int),
		typeof(int),
		typeof(int),
		typeof(int)
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
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIItemGrid.GetItemSizeHandler), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(object),
		typeof(IntPtr)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIItemGrid), Member = "Draw", MemberParameters = new object[]
	{
		typeof(ItemGrid_Layout),
		typeof(GUIItemGrid.GetItemScaleHandler),
		typeof(GUIItemGrid.CursorOver),
		typeof(GUIItemGrid.DrawItemHandler),
		typeof(GUIItemGrid.GetItemSizeHandler),
		typeof(int),
		typeof(int),
		typeof(int),
		typeof(int)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "TopLeft", MemberParameters = new object[] { typeof(Rectangle) }, ReturnType = typeof(Microsoft.Xna.Framework.Vector2))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Microsoft.Xna.Framework.Vector2), Member = "op_Addition", MemberParameters = new object[]
	{
		typeof(Microsoft.Xna.Framework.Vector2),
		typeof(Microsoft.Xna.Framework.Vector2)
	}, ReturnType = typeof(Microsoft.Xna.Framework.Vector2))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "BottomRight", MemberParameters = new object[] { typeof(Rectangle) }, ReturnType = typeof(Microsoft.Xna.Framework.Vector2))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Microsoft.Xna.Framework.Vector2), Member = "op_Subtraction", MemberParameters = new object[]
	{
		typeof(Microsoft.Xna.Framework.Vector2),
		typeof(Microsoft.Xna.Framework.Vector2)
	}, ReturnType = typeof(Microsoft.Xna.Framework.Vector2))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPanel), Member = "DrawAtPosition", MemberParameters = new object[]
	{
		typeof(Panel_Layout),
		typeof(Microsoft.Xna.Framework.Vector2),
		typeof(Microsoft.Xna.Framework.Vector2),
		typeof(bool)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 33)]
	public void DrawControlsBanner(GUIControlsBanner.ActionSource source)
	{
		throw null;
	}

	// Token: 0x06000706 RID: 1798 RVA: 0x00023057 File Offset: 0x00021257
	[global::Cpp2ILInjected.Token(Token = "0x60007F9")]
	[global::Cpp2ILInjected.Address(RVA = "0x13F00F0", Offset = "0x13F00F0", Length = "0x2D0")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIString), Member = "GetRegion", MemberParameters = new object[]
	{
		typeof(String_Layout),
		typeof(string)
	}, ReturnType = typeof(Rectangle))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControlAnchor), Member = "SetGridItemRegion", MemberParameters = new object[] { typeof(Rectangle) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPanel), Member = "Draw", MemberParameters = new object[]
	{
		typeof(Panel_Layout),
		typeof(bool),
		typeof(Microsoft.Xna.Framework.Graphics.Color?),
		typeof(Microsoft.Xna.Framework.Graphics.Color?),
		typeof(Microsoft.Xna.Framework.Graphics.Color?)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIString), Member = "Draw", MemberParameters = new object[]
	{
		typeof(String_Layout),
		typeof(string)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControllerActionManager), Member = "get_ActiveController", ReturnType = typeof(ControllerDevice))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerInputButton), Member = "GetButtonTexureInformation", MemberParameters = new object[]
	{
		typeof(GUIControllerInputButton.LinkedControlType),
		typeof(ref Rectangle),
		typeof(int)
	}, ReturnType = typeof(Microsoft.Xna.Framework.Graphics.Texture2D))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControllerActionButton), Member = "GetButtonState", MemberParameters = new object[] { typeof(ControllerDevice) }, ReturnType = typeof(bool))]
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
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
	public void DrawMoreOptionsBanner()
	{
		throw null;
	}

	// Token: 0x06000707 RID: 1799 RVA: 0x0002305A File Offset: 0x0002125A
	[global::Cpp2ILInjected.Token(Token = "0x60007FA")]
	[global::Cpp2ILInjected.Address(RVA = "0x13F03C0", Offset = "0x13F03C0", Length = "0x27C")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DoDraw", MemberParameters = new object[] { typeof(GameTime) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControllerActionManager), Member = "get_AnyControllerConnected", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_KeyboardIsActive", ReturnType = typeof(bool))]
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
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_gameMenu", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControlsBanner), Member = "DrawHorizontalControlsBanner", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteBatch), Member = "End", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "FlushBatches", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new object[]
	{
		typeof(Array),
		typeof(int),
		typeof(int)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
	public void Draw()
	{
		throw null;
	}

	// Token: 0x06000708 RID: 1800 RVA: 0x0002305D File Offset: 0x0002125D
	[global::Cpp2ILInjected.Token(Token = "0x60007FB")]
	[global::Cpp2ILInjected.Address(RVA = "0x13F063C", Offset = "0x13F063C", Length = "0x2C")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIHotbar), Member = "UpdateHotbarNavigation", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIHousingMenu), Member = "UpdateHotbarNavigation", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIInterfaceEdit), Member = "DrawGroupEditControls", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControlsBanner), Member = "AddAction", MemberParameters = new object[]
	{
		typeof(GUIControlsBanner.ActionSource),
		typeof(ControllerActionVector),
		typeof(string),
		typeof(Microsoft.Xna.Framework.Graphics.Texture2D),
		typeof(Rectangle),
		typeof(TransactionButton_Layout),
		typeof(bool)
	}, ReturnType = typeof(void))]
	public void AddAction(GUIControlsBanner.ActionSource source, ControllerActionVector action, string label)
	{
		throw null;
	}

	// Token: 0x06000709 RID: 1801 RVA: 0x00023060 File Offset: 0x00021260
	[global::Cpp2ILInjected.Token(Token = "0x60007FC")]
	[global::Cpp2ILInjected.Address(RVA = "0x13F0B6C", Offset = "0x13F0B6C", Length = "0xE8")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIVirtualInputController), Member = "Update", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUISafeRegionEdit), Member = "UpdateCursorDragging", MemberParameters = new object[] { typeof(ref Rect) }, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
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
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControlsBanner), Member = "AddAction", MemberParameters = new object[]
	{
		typeof(GUIControlsBanner.ActionSource),
		typeof(ControllerActionVector),
		typeof(string),
		typeof(Microsoft.Xna.Framework.Graphics.Texture2D),
		typeof(Rectangle),
		typeof(TransactionButton_Layout),
		typeof(bool)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
	public void AddAction(GUIControlsBanner.ActionSource source, ControllerActionVector action, string label, Microsoft.Xna.Framework.Graphics.Texture2D itemTexture, TransactionButton_Layout styleSource, bool disabled)
	{
		throw null;
	}

	// Token: 0x0600070A RID: 1802 RVA: 0x00023063 File Offset: 0x00021263
	[global::Cpp2ILInjected.Token(Token = "0x60007FD")]
	[global::Cpp2ILInjected.Address(RVA = "0x13F0668", Offset = "0x13F0668", Length = "0x504")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControlsBanner), Member = "AddAction", MemberParameters = new object[]
	{
		typeof(GUIControlsBanner.ActionSource),
		typeof(ControllerActionVector),
		typeof(string)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControlsBanner), Member = "AddAction", MemberParameters = new object[]
	{
		typeof(GUIControlsBanner.ActionSource),
		typeof(ControllerActionVector),
		typeof(string),
		typeof(Microsoft.Xna.Framework.Graphics.Texture2D),
		typeof(TransactionButton_Layout),
		typeof(bool)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControllerActionVector), Member = "get_HasMapping", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControllerActionManager), Member = "get_ActiveController", ReturnType = typeof(ControllerDevice))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControllerActionVector), Member = "get_RequiredState", ReturnType = typeof(ControllerActionButton.RequiredButtonState))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControllerActionVector), Member = "RequiredStateValid", MemberParameters = new object[] { typeof(ControllerDevice) }, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControlsBanner.Action), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(GUIControlsBanner.ActionSource),
		typeof(ControllerActionVector),
		typeof(string),
		typeof(Microsoft.Xna.Framework.Graphics.Texture2D),
		typeof(Rectangle),
		typeof(TransactionButton_Layout),
		typeof(bool),
		typeof(int)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 16)]
	public void AddAction(GUIControlsBanner.ActionSource source, ControllerActionVector action, string label, Microsoft.Xna.Framework.Graphics.Texture2D itemTexture, Rectangle srcRegion, TransactionButton_Layout styleSource, bool disabled)
	{
		throw null;
	}

	// Token: 0x0600070B RID: 1803 RVA: 0x00023066 File Offset: 0x00021266
	[global::Cpp2ILInjected.Token(Token = "0x60007FE")]
	[global::Cpp2ILInjected.Address(RVA = "0x13EAB80", Offset = "0x13EAB80", Length = "0x2C")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 100)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControlsBanner), Member = "AddAction", MemberParameters = new object[]
	{
		typeof(GUIControlsBanner.ActionSource),
		typeof(ControllerActionButton),
		typeof(string),
		typeof(Microsoft.Xna.Framework.Graphics.Texture2D),
		typeof(Rectangle),
		typeof(TransactionButton_Layout),
		typeof(bool)
	}, ReturnType = typeof(void))]
	public void AddAction(GUIControlsBanner.ActionSource source, ControllerActionButton action, string label)
	{
		throw null;
	}

	// Token: 0x0600070C RID: 1804 RVA: 0x00023069 File Offset: 0x00021269
	[global::Cpp2ILInjected.Token(Token = "0x60007FF")]
	[global::Cpp2ILInjected.Address(RVA = "0x13F1238", Offset = "0x13F1238", Length = "0xE8")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUITransactionButton), Member = "DrawWithBanner", MemberParameters = new object[]
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
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUITransactionButton), Member = "HandleControllerAction", MemberParameters = new object[]
	{
		typeof(TransactionButton_Layout),
		typeof(ControllerActionButton),
		typeof(string),
		typeof(bool),
		typeof(bool),
		typeof(bool)
	}, ReturnType = typeof(GUITransactionButton.InputState))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIBestiary), Member = "DrawOrders", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIBuffs), Member = "UpdateBuffNavigation", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIInventorySplitStack), Member = "Draw", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIMap), Member = "DrawMap", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIMultiplayerChat), Member = "DrawNotification", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIMultiplayerChat), Member = "Draw", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIResearch), Member = "DrawInventoryResearchBinding", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIResearch), Member = "DrawInventoryResearchButton", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIVirtualInputController), Member = "AddInteractBanner", MemberParameters = new object[]
	{
		typeof(Player),
		typeof(Item)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIVirtualInputController), Member = "Update", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIPlayerCreateMenu), Member = "DrawMenuButton", MemberParameters = new object[]
	{
		typeof(ControllerActionButton),
		typeof(string),
		typeof(TransactionButton_Layout),
		typeof(ref float),
		typeof(bool)
	}, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 30)]
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
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControlsBanner), Member = "AddAction", MemberParameters = new object[]
	{
		typeof(GUIControlsBanner.ActionSource),
		typeof(ControllerActionButton),
		typeof(string),
		typeof(Microsoft.Xna.Framework.Graphics.Texture2D),
		typeof(Rectangle),
		typeof(TransactionButton_Layout),
		typeof(bool)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
	public void AddAction(GUIControlsBanner.ActionSource source, ControllerActionButton action, string label, Microsoft.Xna.Framework.Graphics.Texture2D itemTexture, TransactionButton_Layout styleSource, bool disabled)
	{
		throw null;
	}

	// Token: 0x0600070D RID: 1805 RVA: 0x0002306C File Offset: 0x0002126C
	[global::Cpp2ILInjected.Token(Token = "0x6000800")]
	[global::Cpp2ILInjected.Address(RVA = "0x13F0D4C", Offset = "0x13F0D4C", Length = "0x4EC")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIClothesWindow), Member = "DrawCategoryButtons", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUICoins), Member = "ItemOver", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControlsBanner), Member = "DrawControlsBanner", MemberParameters = new object[] { typeof(GUIControlsBanner.ActionSource) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControlsBanner), Member = "AddAction", MemberParameters = new object[]
	{
		typeof(GUIControlsBanner.ActionSource),
		typeof(ControllerActionButton),
		typeof(string)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControlsBanner), Member = "AddAction", MemberParameters = new object[]
	{
		typeof(GUIControlsBanner.ActionSource),
		typeof(ControllerActionButton),
		typeof(string),
		typeof(Microsoft.Xna.Framework.Graphics.Texture2D),
		typeof(TransactionButton_Layout),
		typeof(bool)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 7)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControllerActionButton), Member = "get_HasMapping", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControllerActionManager), Member = "get_ActiveController", ReturnType = typeof(ControllerDevice))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControllerActionButton), Member = "get_RequiredState", ReturnType = typeof(ControllerActionButton.RequiredButtonState))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControllerActionButton), Member = "RequiredStateValid", MemberParameters = new object[] { typeof(ControllerDevice) }, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControlsBanner.Action), Member = ".ctor", MemberParameters = new object[]
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
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 16)]
	public void AddAction(GUIControlsBanner.ActionSource source, ControllerActionButton action, string label, Microsoft.Xna.Framework.Graphics.Texture2D itemTexture, Rectangle srcRegion, TransactionButton_Layout styleSource, bool disabled)
	{
		throw null;
	}

	// Token: 0x0600070E RID: 1806 RVA: 0x0002306F File Offset: 0x0002126F
	[global::Cpp2ILInjected.Token(Token = "0x6000801")]
	[global::Cpp2ILInjected.Address(RVA = "0x13F1568", Offset = "0x13F1568", Length = "0x128")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIInstance), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
	public GUIControlsBanner()
	{
		throw null;
	}

	// Token: 0x0400047B RID: 1147
	[global::Cpp2ILInjected.Token(Token = "0x400067F")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
	private Microsoft.Xna.Framework.Vector2 itemSize;

	// Token: 0x0400047C RID: 1148
	[global::Cpp2ILInjected.Token(Token = "0x4000680")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
	private List<GUIControlsBanner.Action> currentActions;

	// Token: 0x0400047D RID: 1149
	[global::Cpp2ILInjected.Token(Token = "0x4000681")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	private bool[] MoreLeftStateActions;

	// Token: 0x0400047E RID: 1150
	[global::Cpp2ILInjected.Token(Token = "0x4000682")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
	private bool[] MoreRightStateActions;

	// Token: 0x0400047F RID: 1151
	[global::Cpp2ILInjected.Token(Token = "0x4000683")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
	private List<GUIControlsBanner.Action>[] sourceActions;

	// Token: 0x04000480 RID: 1152
	[global::Cpp2ILInjected.Token(Token = "0x4000684")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
	private List<GUIControlsBanner.Action> AllActions;

	// Token: 0x04000481 RID: 1153
	[global::Cpp2ILInjected.Token(Token = "0x4000685")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
	private List<GUIControlsBanner.Action> LeftActions;

	// Token: 0x04000482 RID: 1154
	[global::Cpp2ILInjected.Token(Token = "0x4000686")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
	private List<GUIControlsBanner.Action> RightActions;

	// Token: 0x04000483 RID: 1155
	[global::Cpp2ILInjected.Token(Token = "0x4000687")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
	private bool MoreLeftActions;

	// Token: 0x04000484 RID: 1156
	[global::Cpp2ILInjected.Token(Token = "0x4000688")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x51")]
	private bool MoreRightActions;

	// Token: 0x04000485 RID: 1157
	[global::Cpp2ILInjected.Token(Token = "0x4000689")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x52")]
	public bool ShowBanner;

	// Token: 0x04000486 RID: 1158
	[global::Cpp2ILInjected.Token(Token = "0x400068A")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x53")]
	public bool DisplayingSecondLine;

	// Token: 0x04000487 RID: 1159
	[global::Cpp2ILInjected.Token(Token = "0x400068B")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x54")]
	private bool secondLine;

	// Token: 0x04000488 RID: 1160
	[global::Cpp2ILInjected.Token(Token = "0x400068C")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
	private Rectangle lastDrawRegion;

	// Token: 0x04000489 RID: 1161
	[global::Cpp2ILInjected.Token(Token = "0x400068D")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x68")]
	private Rectangle lastDrawRegion2;

	// Token: 0x0400048A RID: 1162
	[global::Cpp2ILInjected.Token(Token = "0x400068E")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x78")]
	private TransactionButton_Layout ActionStyle;

	// Token: 0x0400048B RID: 1163
	[global::Cpp2ILInjected.Token(Token = "0x400068F")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x80")]
	private TransactionButton_Layout ActionStyleMultiple;

	// Token: 0x0400048C RID: 1164
	[global::Cpp2ILInjected.Token(Token = "0x4000690")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x88")]
	private GUIControlsBanner.Action LTAction;

	// Token: 0x0400048D RID: 1165
	[global::Cpp2ILInjected.Token(Token = "0x4000691")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x90")]
	private GUIControlsBanner.Action LBAction;

	// Token: 0x0400048E RID: 1166
	[global::Cpp2ILInjected.Token(Token = "0x4000692")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x98")]
	private float ScaleLB;

	// Token: 0x0400048F RID: 1167
	[global::Cpp2ILInjected.Token(Token = "0x4000693")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xA0")]
	private GUIControlsBanner.Action RBAction;

	// Token: 0x04000490 RID: 1168
	[global::Cpp2ILInjected.Token(Token = "0x4000694")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xA8")]
	private GUIControlsBanner.Action RTAction;

	// Token: 0x04000491 RID: 1169
	[global::Cpp2ILInjected.Token(Token = "0x4000695")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xB0")]
	private float ScaleRB;

	// Token: 0x04000492 RID: 1170
	[global::Cpp2ILInjected.Token(Token = "0x4000696")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xB8")]
	private GUIControlsBanner.ActionGroup LSActions;

	// Token: 0x04000493 RID: 1171
	[global::Cpp2ILInjected.Token(Token = "0x4000697")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xC0")]
	private GUIControlsBanner.ActionGroup RSActions;

	// Token: 0x04000494 RID: 1172
	[global::Cpp2ILInjected.Token(Token = "0x4000698")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xC8")]
	private GUIControlsBanner.ActionGroup DPadActions;

	// Token: 0x04000495 RID: 1173
	[global::Cpp2ILInjected.Token(Token = "0x4000699")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xD0")]
	private GUIControlsBanner.ActionGroup ButtonActions;

	// Token: 0x04000496 RID: 1174
	[global::Cpp2ILInjected.Token(Token = "0x400069A")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xD8")]
	private int itemsDrawing;

	// Token: 0x04000497 RID: 1175
	[global::Cpp2ILInjected.Token(Token = "0x400069B")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xDC")]
	private float leftMoreScale;

	// Token: 0x04000498 RID: 1176
	[global::Cpp2ILInjected.Token(Token = "0x400069C")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xE0")]
	private float rightMoreScale;

	// Token: 0x020007BD RID: 1981
	[global::Cpp2ILInjected.Token(Token = "0x2000130")]
	public enum ActionSource
	{
		// Token: 0x040079EA RID: 31210
		[global::Cpp2ILInjected.Token(Token = "0x400069E")]
		MainMenu,
		// Token: 0x040079EB RID: 31211
		[global::Cpp2ILInjected.Token(Token = "0x400069F")]
		World,
		// Token: 0x040079EC RID: 31212
		[global::Cpp2ILInjected.Token(Token = "0x40006A0")]
		InterfaceLeft,
		// Token: 0x040079ED RID: 31213
		[global::Cpp2ILInjected.Token(Token = "0x40006A1")]
		InterfaceRight,
		// Token: 0x040079EE RID: 31214
		[global::Cpp2ILInjected.Token(Token = "0x40006A2")]
		NPCDialogue,
		// Token: 0x040079EF RID: 31215
		[global::Cpp2ILInjected.Token(Token = "0x40006A3")]
		Dresser,
		// Token: 0x040079F0 RID: 31216
		[global::Cpp2ILInjected.Token(Token = "0x40006A4")]
		HairStylist,
		// Token: 0x040079F1 RID: 31217
		[global::Cpp2ILInjected.Token(Token = "0x40006A5")]
		Map,
		// Token: 0x040079F2 RID: 31218
		[global::Cpp2ILInjected.Token(Token = "0x40006A6")]
		Count
	}

	// Token: 0x020007BE RID: 1982
	[global::Cpp2ILInjected.Token(Token = "0x2000131")]
	public class Action
	{
		// Token: 0x060048C6 RID: 18630 RVA: 0x0002EEB3 File Offset: 0x0002D0B3
		[global::Cpp2ILInjected.Token(Token = "0x6000802")]
		[global::Cpp2ILInjected.Address(RVA = "0x13F0C54", Offset = "0x13F0C54", Length = "0xF8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControlsBanner), Member = "AddAction", MemberParameters = new object[]
		{
			typeof(GUIControlsBanner.ActionSource),
			typeof(ControllerActionVector),
			typeof(string),
			typeof(Microsoft.Xna.Framework.Graphics.Texture2D),
			typeof(Rectangle),
			typeof(TransactionButton_Layout),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControllerActionAxis), Member = "get_RequiredState", ReturnType = typeof(ControllerActionButton.RequiredButtonState))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControllerActionManager), Member = "get_ActiveController", ReturnType = typeof(ControllerDevice))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControllerActionVector), Member = "get_MappedX", ReturnType = typeof(ControllerActionAxis))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControllerActionAxis), Member = "get_FirstEntry", ReturnType = typeof(ControllerActionAxis.Entry))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public Action(GUIControlsBanner.ActionSource source, ControllerActionVector action, string name, Microsoft.Xna.Framework.Graphics.Texture2D itemTexture, Rectangle srcRegion, TransactionButton_Layout style, bool disabled, int displayPriorityOffset)
		{
			throw null;
		}

		// Token: 0x060048C7 RID: 18631 RVA: 0x0002EEB6 File Offset: 0x0002D0B6
		[global::Cpp2ILInjected.Token(Token = "0x6000803")]
		[global::Cpp2ILInjected.Address(RVA = "0x13F1320", Offset = "0x13F1320", Length = "0x248")]
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
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControllerActionButton), Member = "get_RequiredState", ReturnType = typeof(ControllerActionButton.RequiredButtonState))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControllerActionManager), Member = "get_ActiveController", ReturnType = typeof(ControllerDevice))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControllerActionButton), Member = "get_FirstEntry", ReturnType = typeof(ControllerActionButton.Entry))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public Action(GUIControlsBanner.ActionSource source, ControllerActionButton action, string name, Microsoft.Xna.Framework.Graphics.Texture2D itemTexture, Rectangle srcRegion, TransactionButton_Layout styleSource, bool disabled, int displayPriorityOffset)
		{
			throw null;
		}

		// Token: 0x040079F3 RID: 31219
		[global::Cpp2ILInjected.Token(Token = "0x40006A7")]
		public const GUIControlsBanner.Action.ControlPriority MinRightControl = GUIControlsBanner.Action.ControlPriority.RightTrigger;

		// Token: 0x040079F4 RID: 31220
		[global::Cpp2ILInjected.Token(Token = "0x40006A8")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		public ControllerActionVector Axis;

		// Token: 0x040079F5 RID: 31221
		[global::Cpp2ILInjected.Token(Token = "0x40006A9")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		public ControllerActionButton Button;

		// Token: 0x040079F6 RID: 31222
		[global::Cpp2ILInjected.Token(Token = "0x40006AA")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		public TransactionButton_Layout ActionStyle;

		// Token: 0x040079F7 RID: 31223
		[global::Cpp2ILInjected.Token(Token = "0x40006AB")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		public Microsoft.Xna.Framework.Graphics.Texture2D ActionTexture;

		// Token: 0x040079F8 RID: 31224
		[global::Cpp2ILInjected.Token(Token = "0x40006AC")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		public Rectangle ActionTextureRegion;

		// Token: 0x040079F9 RID: 31225
		[global::Cpp2ILInjected.Token(Token = "0x40006AD")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		public string Name;

		// Token: 0x040079FA RID: 31226
		[global::Cpp2ILInjected.Token(Token = "0x40006AE")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
		public int InputPriority;

		// Token: 0x040079FB RID: 31227
		[global::Cpp2ILInjected.Token(Token = "0x40006AF")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x4C")]
		public bool Disabled;

		// Token: 0x040079FC RID: 31228
		[global::Cpp2ILInjected.Token(Token = "0x40006B0")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
		public int DisplayPriorityOffset;

		// Token: 0x02000B54 RID: 2900
		[global::Cpp2ILInjected.Token(Token = "0x2000132")]
		public enum ControlPriority
		{
			// Token: 0x04008FD4 RID: 36820
			[global::Cpp2ILInjected.Token(Token = "0x40006B2")]
			LeftTrigger,
			// Token: 0x04008FD5 RID: 36821
			[global::Cpp2ILInjected.Token(Token = "0x40006B3")]
			LeftShoulder,
			// Token: 0x04008FD6 RID: 36822
			[global::Cpp2ILInjected.Token(Token = "0x40006B4")]
			DPadDown,
			// Token: 0x04008FD7 RID: 36823
			[global::Cpp2ILInjected.Token(Token = "0x40006B5")]
			DPadUp,
			// Token: 0x04008FD8 RID: 36824
			[global::Cpp2ILInjected.Token(Token = "0x40006B6")]
			DPadLeft,
			// Token: 0x04008FD9 RID: 36825
			[global::Cpp2ILInjected.Token(Token = "0x40006B7")]
			DPadRight,
			// Token: 0x04008FDA RID: 36826
			[global::Cpp2ILInjected.Token(Token = "0x40006B8")]
			LSDown,
			// Token: 0x04008FDB RID: 36827
			[global::Cpp2ILInjected.Token(Token = "0x40006B9")]
			LSUp,
			// Token: 0x04008FDC RID: 36828
			[global::Cpp2ILInjected.Token(Token = "0x40006BA")]
			LSLeft,
			// Token: 0x04008FDD RID: 36829
			[global::Cpp2ILInjected.Token(Token = "0x40006BB")]
			LSRight,
			// Token: 0x04008FDE RID: 36830
			[global::Cpp2ILInjected.Token(Token = "0x40006BC")]
			LSClick,
			// Token: 0x04008FDF RID: 36831
			[global::Cpp2ILInjected.Token(Token = "0x40006BD")]
			ViewButton,
			// Token: 0x04008FE0 RID: 36832
			[global::Cpp2ILInjected.Token(Token = "0x40006BE")]
			LeftMore,
			// Token: 0x04008FE1 RID: 36833
			[global::Cpp2ILInjected.Token(Token = "0x40006BF")]
			RightTrigger,
			// Token: 0x04008FE2 RID: 36834
			[global::Cpp2ILInjected.Token(Token = "0x40006C0")]
			RightShoulder,
			// Token: 0x04008FE3 RID: 36835
			[global::Cpp2ILInjected.Token(Token = "0x40006C1")]
			Action2,
			// Token: 0x04008FE4 RID: 36836
			[global::Cpp2ILInjected.Token(Token = "0x40006C2")]
			Action4,
			// Token: 0x04008FE5 RID: 36837
			[global::Cpp2ILInjected.Token(Token = "0x40006C3")]
			Action3,
			// Token: 0x04008FE6 RID: 36838
			[global::Cpp2ILInjected.Token(Token = "0x40006C4")]
			Action1,
			// Token: 0x04008FE7 RID: 36839
			[global::Cpp2ILInjected.Token(Token = "0x40006C5")]
			RSDown,
			// Token: 0x04008FE8 RID: 36840
			[global::Cpp2ILInjected.Token(Token = "0x40006C6")]
			RSUp,
			// Token: 0x04008FE9 RID: 36841
			[global::Cpp2ILInjected.Token(Token = "0x40006C7")]
			RSLeft,
			// Token: 0x04008FEA RID: 36842
			[global::Cpp2ILInjected.Token(Token = "0x40006C8")]
			RSRight,
			// Token: 0x04008FEB RID: 36843
			[global::Cpp2ILInjected.Token(Token = "0x40006C9")]
			RSClick,
			// Token: 0x04008FEC RID: 36844
			[global::Cpp2ILInjected.Token(Token = "0x40006CA")]
			Settings,
			// Token: 0x04008FED RID: 36845
			[global::Cpp2ILInjected.Token(Token = "0x40006CB")]
			RightMore
		}
	}

	// Token: 0x020007BF RID: 1983
	[global::Cpp2ILInjected.Token(Token = "0x2000133")]
	private class ActionGroup
	{
		// Token: 0x060048C8 RID: 18632 RVA: 0x0002EEB9 File Offset: 0x0002D0B9
		[global::Cpp2ILInjected.Token(Token = "0x6000804")]
		[global::Cpp2ILInjected.Address(RVA = "0x13F1690", Offset = "0x13F1690", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public ActionGroup()
		{
			throw null;
		}

		// Token: 0x040079FD RID: 31229
		[global::Cpp2ILInjected.Token(Token = "0x40006CC")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		public GUIControlsBanner.Action ActionUp;

		// Token: 0x040079FE RID: 31230
		[global::Cpp2ILInjected.Token(Token = "0x40006CD")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		public GUIControlsBanner.Action ActionDown;

		// Token: 0x040079FF RID: 31231
		[global::Cpp2ILInjected.Token(Token = "0x40006CE")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		public GUIControlsBanner.Action ActionLeft;

		// Token: 0x04007A00 RID: 31232
		[global::Cpp2ILInjected.Token(Token = "0x40006CF")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		public GUIControlsBanner.Action ActionRight;

		// Token: 0x04007A01 RID: 31233
		[global::Cpp2ILInjected.Token(Token = "0x40006D0")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		public float ScaleUp;

		// Token: 0x04007A02 RID: 31234
		[global::Cpp2ILInjected.Token(Token = "0x40006D1")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x34")]
		public float ScaleDown;

		// Token: 0x04007A03 RID: 31235
		[global::Cpp2ILInjected.Token(Token = "0x40006D2")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		public float ScaleLeft;

		// Token: 0x04007A04 RID: 31236
		[global::Cpp2ILInjected.Token(Token = "0x40006D3")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x3C")]
		public float ScaleRight;
	}

	// Token: 0x020007C0 RID: 1984
	[CompilerGenerated]
	[global::Cpp2ILInjected.Token(Token = "0x2000134")]
	[Serializable]
	private sealed class <>c
	{
		// Token: 0x060048C9 RID: 18633 RVA: 0x0002EEBC File Offset: 0x0002D0BC
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x6000805")]
		[global::Cpp2ILInjected.Address(RVA = "0x13F1698", Offset = "0x13F1698", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		static <>c()
		{
			throw null;
		}

		// Token: 0x060048CA RID: 18634 RVA: 0x0002EEBF File Offset: 0x0002D0BF
		[global::Cpp2ILInjected.Token(Token = "0x6000806")]
		[global::Cpp2ILInjected.Address(RVA = "0x13F16F4", Offset = "0x13F16F4", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public <>c()
		{
			throw null;
		}

		// Token: 0x060048CB RID: 18635 RVA: 0x0002EEC2 File Offset: 0x0002D0C2
		[global::Cpp2ILInjected.Token(Token = "0x6000807")]
		[global::Cpp2ILInjected.Address(RVA = "0x13F16FC", Offset = "0x13F16FC", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(int), Member = "CompareTo", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
		internal int <DrawLeftControlsBanner>b__48_0(GUIControlsBanner.Action e1, GUIControlsBanner.Action e2)
		{
			throw null;
		}

		// Token: 0x060048CC RID: 18636 RVA: 0x0002EEC5 File Offset: 0x0002D0C5
		[global::Cpp2ILInjected.Token(Token = "0x6000808")]
		[global::Cpp2ILInjected.Address(RVA = "0x13F1710", Offset = "0x13F1710", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(int), Member = "CompareTo", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
		internal int <DrawRightControlsBanner>b__49_0(GUIControlsBanner.Action e1, GUIControlsBanner.Action e2)
		{
			throw null;
		}

		// Token: 0x04007A05 RID: 31237
		[global::Cpp2ILInjected.Token(Token = "0x40006D4")]
		public static readonly GUIControlsBanner.<>c <>9;

		// Token: 0x04007A06 RID: 31238
		[global::Cpp2ILInjected.Token(Token = "0x40006D5")]
		public static Comparison<GUIControlsBanner.Action> <>9__48_0;

		// Token: 0x04007A07 RID: 31239
		[global::Cpp2ILInjected.Token(Token = "0x40006D6")]
		public static Comparison<GUIControlsBanner.Action> <>9__49_0;
	}
}
