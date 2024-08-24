using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;

// Token: 0x02000094 RID: 148
[global::Cpp2ILInjected.Token(Token = "0x20000CE")]
public class GUIControllerItemDuplication : GUIPageContentController
{
	// Token: 0x0600047E RID: 1150 RVA: 0x000228BF File Offset: 0x00020ABF
	[global::Cpp2ILInjected.Token(Token = "0x6000518")]
	[global::Cpp2ILInjected.Address(RVA = "0xB1D434", Offset = "0xB1D434", Length = "0x24")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
	public GUIControllerItemDuplication()
	{
		throw null;
	}

	// Token: 0x0600047F RID: 1151 RVA: 0x000228C2 File Offset: 0x00020AC2
	[global::Cpp2ILInjected.Token(Token = "0x6000519")]
	[global::Cpp2ILInjected.Address(RVA = "0xB1D458", Offset = "0xB1D458", Length = "0x8")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	public virtual bool IsInMenu()
	{
		throw null;
	}

	// Token: 0x06000480 RID: 1152 RVA: 0x000228C5 File Offset: 0x00020AC5
	[global::Cpp2ILInjected.Token(Token = "0x600051A")]
	[global::Cpp2ILInjected.Address(RVA = "0xB1D460", Offset = "0xB1D460", Length = "0x104")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPageIcons), Member = "get_UseHorizontalPages", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
	public override void Activate()
	{
		throw null;
	}

	// Token: 0x06000481 RID: 1153 RVA: 0x000228C8 File Offset: 0x00020AC8
	[global::Cpp2ILInjected.Token(Token = "0x600051B")]
	[global::Cpp2ILInjected.Address(RVA = "0xB1D564", Offset = "0xB1D564", Length = "0x20C")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerItemDuplication), Member = "get_MinColumns", ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(float),
		typeof(float)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PageControllerLayoutDefinition<>), Member = "get_Instance", ReturnType = "T")]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Multiply", MemberParameters = new object[]
	{
		typeof(Vector2),
		typeof(float)
	}, ReturnType = typeof(Vector2))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
	public virtual void RefreshScrollOffset()
	{
		throw null;
	}

	// Token: 0x06000482 RID: 1154 RVA: 0x000228CB File Offset: 0x00020ACB
	[global::Cpp2ILInjected.Token(Token = "0x600051C")]
	[global::Cpp2ILInjected.Address(RVA = "0xB1D824", Offset = "0xB1D824", Length = "0x244")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerItemDuplication), Member = "get_MinColumns", ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(float),
		typeof(float)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PageControllerLayoutDefinition<>), Member = "get_Instance", ReturnType = "T")]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Multiply", MemberParameters = new object[]
	{
		typeof(Vector2),
		typeof(float)
	}, ReturnType = typeof(Vector2))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
	protected virtual void UpdateScroll()
	{
		throw null;
	}

	// Token: 0x1700006A RID: 106
	// (get) Token: 0x06000483 RID: 1155 RVA: 0x000228CE File Offset: 0x00020ACE
	[global::Cpp2ILInjected.Token(Token = "0x1700008F")]
	public int MinRow
	{
		[global::Cpp2ILInjected.Token(Token = "0x600051D")]
		[global::Cpp2ILInjected.Address(RVA = "0xB1DA68", Offset = "0xB1DA68", Length = "0x8C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerItemDuplication), Member = "ClampPosition", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		get
		{
			throw null;
		}
	}

	// Token: 0x1700006B RID: 107
	// (get) Token: 0x06000484 RID: 1156 RVA: 0x000228D1 File Offset: 0x00020AD1
	[global::Cpp2ILInjected.Token(Token = "0x17000090")]
	public int MinColumns
	{
		[global::Cpp2ILInjected.Token(Token = "0x600051E")]
		[global::Cpp2ILInjected.Address(RVA = "0xB1D770", Offset = "0xB1D770", Length = "0xB4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerItemDuplication), Member = "RefreshScrollOffset", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerItemDuplication), Member = "UpdateScroll", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerItemDuplication), Member = "Navigate", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(GUIControllerItem))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerItemDuplication), Member = "ClampPosition", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerPageRedirect), Member = "NavigateIntoRight", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(GUIControllerItem))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 13)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPageIcons), Member = "get_UseHorizontalPages", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		get
		{
			throw null;
		}
	}

	// Token: 0x06000485 RID: 1157 RVA: 0x000228D4 File Offset: 0x00020AD4
	[global::Cpp2ILInjected.Token(Token = "0x600051F")]
	[global::Cpp2ILInjected.Address(RVA = "0xB1DAF4", Offset = "0xB1DAF4", Length = "0xCC")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerItemDuplication), Member = "get_MinColumns", ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerPageRedirect), Member = "NavigateIntoLeft", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(GUIControllerItem))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	public override GUIControllerItem Navigate(Vector2 navigationVector)
	{
		throw null;
	}

	// Token: 0x06000486 RID: 1158 RVA: 0x000228D7 File Offset: 0x00020AD7
	[global::Cpp2ILInjected.Token(Token = "0x6000520")]
	[global::Cpp2ILInjected.Address(RVA = "0xB1DBC0", Offset = "0xB1DBC0", Length = "0x188")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerItemDuplication), Member = "get_MinColumns", ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPageIcons), Member = "get_UseHorizontalPages", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerItemDuplication), Member = "get_MinRow", ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
	protected virtual void ClampPosition()
	{
		throw null;
	}

	// Token: 0x06000487 RID: 1159 RVA: 0x000228DA File Offset: 0x00020ADA
	[global::Cpp2ILInjected.Token(Token = "0x6000521")]
	[global::Cpp2ILInjected.Address(RVA = "0xB1DD48", Offset = "0xB1DD48", Length = "0x23C")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(float),
		typeof(float)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PageControllerLayoutDefinition<>), Member = "get_Instance", ReturnType = "T")]
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
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
	public override Rectangle GetSelectedItemRegion()
	{
		throw null;
	}

	// Token: 0x040002EB RID: 747
	[global::Cpp2ILInjected.Token(Token = "0x4000475")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C")]
	public int itemRow;

	// Token: 0x040002EC RID: 748
	[global::Cpp2ILInjected.Token(Token = "0x4000476")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	public int itemColumn;

	// Token: 0x040002ED RID: 749
	[global::Cpp2ILInjected.Token(Token = "0x4000477")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x24")]
	public int scrollOffset;
}
