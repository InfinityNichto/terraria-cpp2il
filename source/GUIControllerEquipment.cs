using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Terraria;

// Token: 0x0200008B RID: 139
[global::Cpp2ILInjected.Token(Token = "0x20000C4")]
public class GUIControllerEquipment : GUIPageContentController
{
	// Token: 0x06000426 RID: 1062 RVA: 0x000227B7 File Offset: 0x000209B7
	[global::Cpp2ILInjected.Token(Token = "0x60004C0")]
	[global::Cpp2ILInjected.Address(RVA = "0xA8C514", Offset = "0xA8C514", Length = "0xC")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerEquipment4Page), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerPageRedirect), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPageContentController), Member = ".ctor", MemberParameters = new object[] { typeof(GUIPageIcons.Category) }, ReturnType = typeof(void))]
	public GUIControllerEquipment()
	{
		throw null;
	}

	// Token: 0x06000427 RID: 1063 RVA: 0x000227BA File Offset: 0x000209BA
	[global::Cpp2ILInjected.Token(Token = "0x60004C1")]
	[global::Cpp2ILInjected.Address(RVA = "0xA8C520", Offset = "0xA8C520", Length = "0x4")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	public override void Activate()
	{
		throw null;
	}

	// Token: 0x06000428 RID: 1064 RVA: 0x000227BD File Offset: 0x000209BD
	[global::Cpp2ILInjected.Token(Token = "0x60004C2")]
	[global::Cpp2ILInjected.Address(RVA = "0xA8C524", Offset = "0xA8C524", Length = "0x4")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	public virtual void NavigateInto(Vector2 source, Vector2 navigationVector)
	{
		throw null;
	}

	// Token: 0x06000429 RID: 1065 RVA: 0x000227C0 File Offset: 0x000209C0
	[global::Cpp2ILInjected.Token(Token = "0x60004C3")]
	[global::Cpp2ILInjected.Address(RVA = "0xA8C528", Offset = "0xA8C528", Length = "0x1DC")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerEquipment), Member = "get_MinColumnAccesories", ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerPageRedirect), Member = "NavigateIntoLeft", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(GUIControllerItem))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_myPlayer", ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
	public override GUIControllerItem Navigate(Vector2 navigationVector)
	{
		throw null;
	}

	// Token: 0x17000060 RID: 96
	// (get) Token: 0x0600042A RID: 1066 RVA: 0x000227C3 File Offset: 0x000209C3
	[global::Cpp2ILInjected.Token(Token = "0x17000085")]
	private int MinColumnAccesories
	{
		[global::Cpp2ILInjected.Token(Token = "0x60004C4")]
		[global::Cpp2ILInjected.Address(RVA = "0xA8C704", Offset = "0xA8C704", Length = "0x74")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerEquipment), Member = "Navigate", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(GUIControllerItem))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerEquipment), Member = "ClampAccessories", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17000061 RID: 97
	// (get) Token: 0x0600042B RID: 1067 RVA: 0x000227C6 File Offset: 0x000209C6
	[global::Cpp2ILInjected.Token(Token = "0x17000086")]
	private int MinRowLastColumnAccesories
	{
		[global::Cpp2ILInjected.Token(Token = "0x60004C5")]
		[global::Cpp2ILInjected.Address(RVA = "0xA8C778", Offset = "0xA8C778", Length = "0x7C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerEquipment), Member = "ClampAccessories", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		get
		{
			throw null;
		}
	}

	// Token: 0x0600042C RID: 1068 RVA: 0x000227C9 File Offset: 0x000209C9
	[global::Cpp2ILInjected.Token(Token = "0x60004C6")]
	[global::Cpp2ILInjected.Address(RVA = "0xA8C7F4", Offset = "0xA8C7F4", Length = "0x90")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerEquipment), Member = "get_MinColumnAccesories", ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerEquipment), Member = "get_MinRowLastColumnAccesories", ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	public virtual void ClampAccessories()
	{
		throw null;
	}

	// Token: 0x0600042D RID: 1069 RVA: 0x000227CC File Offset: 0x000209CC
	[global::Cpp2ILInjected.Token(Token = "0x60004C7")]
	[global::Cpp2ILInjected.Address(RVA = "0xA8C884", Offset = "0xA8C884", Length = "0x370")]
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
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Equipment_Layout), Member = "get_DisplayInfoAccessories", ReturnType = typeof(ItemGrid_Layout))]
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
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 12)]
	public override Rectangle GetSelectedItemRegion()
	{
		throw null;
	}

	// Token: 0x040002D4 RID: 724
	[global::Cpp2ILInjected.Token(Token = "0x4000458")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C")]
	public int itemRow;

	// Token: 0x040002D5 RID: 725
	[global::Cpp2ILInjected.Token(Token = "0x4000459")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	public int itemColumn;

	// Token: 0x040002D6 RID: 726
	[global::Cpp2ILInjected.Token(Token = "0x400045A")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x24")]
	public bool inAccessories;

	// Token: 0x040002D7 RID: 727
	[global::Cpp2ILInjected.Token(Token = "0x400045B")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x25")]
	public bool inLoadout;
}
