﻿using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Terraria;

[global::Cpp2ILInjected.Token(Token = "0x20000F1")]
public class GUIPlayerCreateController_HairStyle : GUIControllerItem
{
	[global::Cpp2ILInjected.Token(Token = "0x6000657")]
	[global::Cpp2ILInjected.Address(RVA = "0xD16D60", Offset = "0xD16D60", Length = "0x30")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
	public GUIPlayerCreateController_HairStyle(GUIPlayerCreateController controller)
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000658")]
	[global::Cpp2ILInjected.Address(RVA = "0xD174CC", Offset = "0xD174CC", Length = "0x108")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIPlayerCreateController_Tabs), Member = "NavigateIntoCurrentPage", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(GUIControllerItem))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIPlayerCreateMenu), Member = "DrawHairGrid", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIPlayerCreateMenu), Member = "DrawCategoryButtons", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_PendingPlayer", ReturnType = typeof(Player))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<int>), Member = "IndexOf", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPlayerCreateController_HairStyle), Member = "UpdateScroll", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
	public void Activate()
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000659")]
	[global::Cpp2ILInjected.Address(RVA = "0xD177F0", Offset = "0xD177F0", Length = "0x8")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	public int GetNavigationOutDirs()
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x600065A")]
	[global::Cpp2ILInjected.Address(RVA = "0xD177F8", Offset = "0xD177F8", Length = "0x11C")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPlayerCreateController_HairStyle), Member = "UpdateScroll", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPlayerCreateController_Tabs), Member = "Activate", ReturnType = typeof(void))]
	public GUIControllerItem Navigate(Vector2 navigationVector)
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x600065B")]
	[global::Cpp2ILInjected.Address(RVA = "0xD175D4", Offset = "0xD175D4", Length = "0x21C")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIPlayerCreateController_HairStyle), Member = "Activate", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIPlayerCreateController_HairStyle), Member = "Navigate", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(GUIControllerItem))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIPlayerCreateController_MainButtons), Member = "NavigateIntoCurrentPage", ReturnType = typeof(GUIControllerItem))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIPlayerCreateController_Tabs), Member = "NavigateIntoCurrentPage", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(GUIControllerItem))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LayoutCalculator), Member = "GetAnchoredPosition", MemberParameters = new object[]
	{
		typeof(ControlAnchor.ControlId),
		typeof(LayoutCalculator.AnchorType),
		typeof(Vector2)
	}, ReturnType = typeof(Vector2))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Subtraction", MemberParameters = new object[]
	{
		typeof(Vector2),
		typeof(Vector2)
	}, ReturnType = typeof(Vector2))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(float),
		typeof(float)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Multiply", MemberParameters = new object[]
	{
		typeof(Vector2),
		typeof(float)
	}, ReturnType = typeof(Vector2))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
	public void UpdateScroll()
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x170000CD")]
	public int currentScrollOffset
	{
		[global::Cpp2ILInjected.Token(Token = "0x600065C")]
		[global::Cpp2ILInjected.Address(RVA = "0xD17914", Offset = "0xD17914", Length = "0x160")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIPlayerCreateController_Tabs), Member = "NavigateIntoCurrentPage", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(GUIControllerItem))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Multiply", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(float)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		get
		{
			throw null;
		}
	}

	[global::Cpp2ILInjected.Token(Token = "0x600065D")]
	[global::Cpp2ILInjected.Address(RVA = "0xD17A74", Offset = "0xD17A74", Length = "0x218")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(float),
		typeof(float)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Multiply", MemberParameters = new object[]
	{
		typeof(Vector2),
		typeof(float)
	}, ReturnType = typeof(Vector2))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LayoutCalculator), Member = "GetAnchoredPosition", MemberParameters = new object[]
	{
		typeof(ControlAnchor.ControlId),
		typeof(LayoutCalculator.AnchorType),
		typeof(Vector2)
	}, ReturnType = typeof(Vector2))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(int),
		typeof(int),
		typeof(int),
		typeof(int)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
	public Rectangle GetSelectedItemRegion()
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x40004E7")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
	private readonly GUIPlayerCreateController _controller;

	[global::Cpp2ILInjected.Token(Token = "0x40004E8")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
	public int maxRowIndex;

	[global::Cpp2ILInjected.Token(Token = "0x40004E9")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C")]
	public int maxRowColumn;

	[global::Cpp2ILInjected.Token(Token = "0x40004EA")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	public int itemRow;

	[global::Cpp2ILInjected.Token(Token = "0x40004EB")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x24")]
	public int itemColumn;
}
