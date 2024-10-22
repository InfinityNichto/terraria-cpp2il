﻿using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;

[global::Cpp2ILInjected.Token(Token = "0x20000AA")]
public class GUIControllerWorldSelect : GUIControllerItem
{
	[global::Cpp2ILInjected.Token(Token = "0x6000400")]
	[global::Cpp2ILInjected.Address(RVA = "0xA837E8", Offset = "0xA837E8", Length = "0x84")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIWorldSelectMenu), Member = "Draw", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
	public void Activate()
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000401")]
	[global::Cpp2ILInjected.Address(RVA = "0xA83A84", Offset = "0xA83A84", Length = "0x8")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	public int GetNavigationOutDirs()
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000402")]
	[global::Cpp2ILInjected.Address(RVA = "0xA8386C", Offset = "0xA8386C", Length = "0x218")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerWorldSelect), Member = "Navigate", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(GUIControllerItem))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
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
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(int),
		typeof(int),
		typeof(int),
		typeof(int)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
	private void UpdateScroll()
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000403")]
	[global::Cpp2ILInjected.Address(RVA = "0xA83A8C", Offset = "0xA83A8C", Length = "0x148")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerWorldSelect), Member = "UpdateScroll", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
	public GUIControllerItem Navigate(Vector2 navigationVector)
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000404")]
	[global::Cpp2ILInjected.Address(RVA = "0xA83BD4", Offset = "0xA83BD4", Length = "0x100")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUITransactionButton), Member = "GetRegion", MemberParameters = new object[] { typeof(TransactionButton_Layout) }, ReturnType = typeof(Rectangle))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
	public Rectangle GetSelectedItemRegion()
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000405")]
	[global::Cpp2ILInjected.Address(RVA = "0xA83CD4", Offset = "0xA83CD4", Length = "0x8")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIWorldSelectMenu), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
	public GUIControllerWorldSelect()
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x40003DA")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
	public int selectedControl;

	[global::Cpp2ILInjected.Token(Token = "0x20000AB")]
	public enum Controls
	{
		[global::Cpp2ILInjected.Token(Token = "0x40003DC")]
		Back,
		[global::Cpp2ILInjected.Token(Token = "0x40003DD")]
		Delete,
		[global::Cpp2ILInjected.Token(Token = "0x40003DE")]
		Favourite,
		[global::Cpp2ILInjected.Token(Token = "0x40003DF")]
		Rename,
		[global::Cpp2ILInjected.Token(Token = "0x40003E0")]
		SeedDisplay,
		[global::Cpp2ILInjected.Token(Token = "0x40003E1")]
		Play,
		[global::Cpp2ILInjected.Token(Token = "0x40003E2")]
		New
	}
}
