using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Terraria;

// Token: 0x02000083 RID: 131
[global::Cpp2ILInjected.Token(Token = "0x20000BA")]
public class GUIControllerCrafting : GUIPageContentController
{
	// Token: 0x060003D6 RID: 982 RVA: 0x000226C7 File Offset: 0x000208C7
	[global::Cpp2ILInjected.Token(Token = "0x6000470")]
	[global::Cpp2ILInjected.Address(RVA = "0xA897EC", Offset = "0xA897EC", Length = "0xC")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerPageRedirect), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPageContentController), Member = ".ctor", MemberParameters = new object[] { typeof(GUIPageIcons.Category) }, ReturnType = typeof(void))]
	public GUIControllerCrafting()
	{
		throw null;
	}

	// Token: 0x060003D7 RID: 983 RVA: 0x000226CA File Offset: 0x000208CA
	[global::Cpp2ILInjected.Token(Token = "0x6000471")]
	[global::Cpp2ILInjected.Address(RVA = "0xA897F8", Offset = "0xA897F8", Length = "0x8")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	public virtual bool IsInMenu()
	{
		throw null;
	}

	// Token: 0x060003D8 RID: 984 RVA: 0x000226CD File Offset: 0x000208CD
	[global::Cpp2ILInjected.Token(Token = "0x6000472")]
	[global::Cpp2ILInjected.Address(RVA = "0xA89800", Offset = "0xA89800", Length = "0x168")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_focusRecipe", ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<int>), Member = "IndexOf", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPageIcons), Member = "get_UseHorizontalPages", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
	public override void Activate()
	{
		throw null;
	}

	// Token: 0x060003D9 RID: 985 RVA: 0x000226D0 File Offset: 0x000208D0
	[global::Cpp2ILInjected.Token(Token = "0x6000473")]
	[global::Cpp2ILInjected.Address(RVA = "0xA89968", Offset = "0xA89968", Length = "0x20C")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerCrafting), Member = "get_MinColumns", ReturnType = typeof(int))]
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

	// Token: 0x060003DA RID: 986 RVA: 0x000226D3 File Offset: 0x000208D3
	[global::Cpp2ILInjected.Token(Token = "0x6000474")]
	[global::Cpp2ILInjected.Address(RVA = "0xA89C28", Offset = "0xA89C28", Length = "0x244")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerCrafting), Member = "get_MinColumns", ReturnType = typeof(int))]
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

	// Token: 0x1700005B RID: 91
	// (get) Token: 0x060003DB RID: 987 RVA: 0x000226D6 File Offset: 0x000208D6
	[global::Cpp2ILInjected.Token(Token = "0x17000080")]
	private int MinRow
	{
		[global::Cpp2ILInjected.Token(Token = "0x6000475")]
		[global::Cpp2ILInjected.Address(RVA = "0xA89E6C", Offset = "0xA89E6C", Length = "0x8C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerCrafting), Member = "ClampPosition", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		get
		{
			throw null;
		}
	}

	// Token: 0x1700005C RID: 92
	// (get) Token: 0x060003DC RID: 988 RVA: 0x000226D9 File Offset: 0x000208D9
	[global::Cpp2ILInjected.Token(Token = "0x17000081")]
	public int MinColumns
	{
		[global::Cpp2ILInjected.Token(Token = "0x6000476")]
		[global::Cpp2ILInjected.Address(RVA = "0xA89B74", Offset = "0xA89B74", Length = "0xB4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerCrafting), Member = "RefreshScrollOffset", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerCrafting), Member = "UpdateScroll", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerCrafting), Member = "Navigate", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(GUIControllerItem))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerCrafting), Member = "ClampPosition", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerPageRedirect), Member = "NavigateIntoRight", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(GUIControllerItem))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 13)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPageIcons), Member = "get_UseHorizontalPages", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		get
		{
			throw null;
		}
	}

	// Token: 0x060003DD RID: 989 RVA: 0x000226DC File Offset: 0x000208DC
	[global::Cpp2ILInjected.Token(Token = "0x6000477")]
	[global::Cpp2ILInjected.Address(RVA = "0xA89EF8", Offset = "0xA89EF8", Length = "0xE8")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerCrafting), Member = "get_MinColumns", ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerPageRedirect), Member = "NavigateIntoLeft", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(GUIControllerItem))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	public override GUIControllerItem Navigate(Vector2 navigationVector)
	{
		throw null;
	}

	// Token: 0x060003DE RID: 990 RVA: 0x000226DF File Offset: 0x000208DF
	[global::Cpp2ILInjected.Token(Token = "0x6000478")]
	[global::Cpp2ILInjected.Address(RVA = "0xA89FE0", Offset = "0xA89FE0", Length = "0x188")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerCrafting), Member = "get_MinColumns", ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPageIcons), Member = "get_UseHorizontalPages", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerCrafting), Member = "get_MinRow", ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
	protected virtual void ClampPosition()
	{
		throw null;
	}

	// Token: 0x060003DF RID: 991 RVA: 0x000226E2 File Offset: 0x000208E2
	[global::Cpp2ILInjected.Token(Token = "0x6000479")]
	[global::Cpp2ILInjected.Address(RVA = "0xA8A168", Offset = "0xA8A168", Length = "0x23C")]
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

	// Token: 0x040002C9 RID: 713
	[global::Cpp2ILInjected.Token(Token = "0x400043F")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C")]
	public int itemRow;

	// Token: 0x040002CA RID: 714
	[global::Cpp2ILInjected.Token(Token = "0x4000440")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	public int itemColumn;

	// Token: 0x040002CB RID: 715
	[global::Cpp2ILInjected.Token(Token = "0x4000441")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x24")]
	public int scrollOffset;
}
