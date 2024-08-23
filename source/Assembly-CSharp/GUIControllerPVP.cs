using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;

// Token: 0x0200009A RID: 154
[global::Cpp2ILInjected.Token(Token = "0x20000D4")]
public class GUIControllerPVP : GUIPageContentController
{
	// Token: 0x060004C9 RID: 1225 RVA: 0x000229A0 File Offset: 0x00020BA0
	[global::Cpp2ILInjected.Token(Token = "0x6000563")]
	[global::Cpp2ILInjected.Address(RVA = "0xB203FC", Offset = "0xB203FC", Length = "0x24")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
	public GUIControllerPVP()
	{
		throw null;
	}

	// Token: 0x060004CA RID: 1226 RVA: 0x000229A3 File Offset: 0x00020BA3
	[global::Cpp2ILInjected.Token(Token = "0x6000564")]
	[global::Cpp2ILInjected.Address(RVA = "0xB20538", Offset = "0xB20538", Length = "0x60")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	public override void Activate()
	{
		throw null;
	}

	// Token: 0x060004CB RID: 1227 RVA: 0x000229A6 File Offset: 0x00020BA6
	[global::Cpp2ILInjected.Token(Token = "0x6000565")]
	[global::Cpp2ILInjected.Address(RVA = "0xB20598", Offset = "0xB20598", Length = "0x8")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	public virtual bool IsInMenu()
	{
		throw null;
	}

	// Token: 0x1700007D RID: 125
	// (get) Token: 0x060004CC RID: 1228 RVA: 0x000229A9 File Offset: 0x00020BA9
	[global::Cpp2ILInjected.Token(Token = "0x170000A2")]
	public int MaxRow
	{
		[global::Cpp2ILInjected.Token(Token = "0x6000566")]
		[global::Cpp2ILInjected.Address(RVA = "0xB205A0", Offset = "0xB205A0", Length = "0x68")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		get
		{
			throw null;
		}
	}

	// Token: 0x1700007E RID: 126
	// (get) Token: 0x060004CD RID: 1229 RVA: 0x000229AC File Offset: 0x00020BAC
	[global::Cpp2ILInjected.Token(Token = "0x170000A3")]
	public int MaxColumns
	{
		[global::Cpp2ILInjected.Token(Token = "0x6000567")]
		[global::Cpp2ILInjected.Address(RVA = "0xB20608", Offset = "0xB20608", Length = "0x64")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		get
		{
			throw null;
		}
	}

	// Token: 0x060004CE RID: 1230 RVA: 0x000229AF File Offset: 0x00020BAF
	[global::Cpp2ILInjected.Token(Token = "0x6000568")]
	[global::Cpp2ILInjected.Address(RVA = "0xB2066C", Offset = "0xB2066C", Length = "0xE8")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
	protected virtual void ClampPosition()
	{
		throw null;
	}

	// Token: 0x060004CF RID: 1231 RVA: 0x000229B2 File Offset: 0x00020BB2
	[global::Cpp2ILInjected.Token(Token = "0x6000569")]
	[global::Cpp2ILInjected.Address(RVA = "0xB20754", Offset = "0xB20754", Length = "0x24")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	private int SideToRow(int side)
	{
		throw null;
	}

	// Token: 0x060004D0 RID: 1232 RVA: 0x000229B5 File Offset: 0x00020BB5
	[global::Cpp2ILInjected.Token(Token = "0x600056A")]
	[global::Cpp2ILInjected.Address(RVA = "0xB20778", Offset = "0xB20778", Length = "0x24")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	private int RowToSide(int row)
	{
		throw null;
	}

	// Token: 0x060004D1 RID: 1233 RVA: 0x000229B8 File Offset: 0x00020BB8
	[global::Cpp2ILInjected.Token(Token = "0x600056B")]
	[global::Cpp2ILInjected.Address(RVA = "0xB2079C", Offset = "0xB2079C", Length = "0x20C")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerPageRedirect), Member = "NavigateIntoRight", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(GUIControllerItem))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
	public override GUIControllerItem Navigate(Vector2 navigationVector)
	{
		throw null;
	}

	// Token: 0x060004D2 RID: 1234 RVA: 0x000229BB File Offset: 0x00020BBB
	[global::Cpp2ILInjected.Token(Token = "0x600056C")]
	[global::Cpp2ILInjected.Address(RVA = "0xB209A8", Offset = "0xB209A8", Length = "0x4B4")]
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
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PVPIcons_Layout), Member = "get_TeamGridLayout", ReturnType = typeof(ItemGrid_Layout))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LayoutCalculator), Member = "GetAnchoredPosition", MemberParameters = new object[]
	{
		typeof(ControlAnchor.ControlId),
		typeof(LayoutCalculator.AnchorType),
		typeof(Vector2)
	}, ReturnType = typeof(Vector2))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PVPIcons_Layout), Member = "get_Grid", ReturnType = typeof(DraggableItemGrid_Layout))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(int),
		typeof(int),
		typeof(int),
		typeof(int)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 16)]
	public override Rectangle GetSelectedItemRegion()
	{
		throw null;
	}

	// Token: 0x0400031A RID: 794
	[global::Cpp2ILInjected.Token(Token = "0x40004A4")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C")]
	public bool insideSideIcons;

	// Token: 0x0400031B RID: 795
	[global::Cpp2ILInjected.Token(Token = "0x40004A5")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	public int itemRow;

	// Token: 0x0400031C RID: 796
	[global::Cpp2ILInjected.Token(Token = "0x40004A6")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x24")]
	public int itemColumn;

	// Token: 0x0400031D RID: 797
	[global::Cpp2ILInjected.Token(Token = "0x40004A7")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
	public int sideRow;
}
