using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;

[global::Cpp2ILInjected.Token(Token = "0x20000D4")]
public class GUIControllerPVP : GUIPageContentController
{
	[global::Cpp2ILInjected.Token(Token = "0x6000563")]
	[global::Cpp2ILInjected.Address(RVA = "0xB203FC", Offset = "0xB203FC", Length = "0x24")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
	public GUIControllerPVP()
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000564")]
	[global::Cpp2ILInjected.Address(RVA = "0xB20538", Offset = "0xB20538", Length = "0x60")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	public override void Activate()
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000565")]
	[global::Cpp2ILInjected.Address(RVA = "0xB20598", Offset = "0xB20598", Length = "0x8")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	public virtual bool IsInMenu()
	{
		throw null;
	}

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

	[global::Cpp2ILInjected.Token(Token = "0x6000568")]
	[global::Cpp2ILInjected.Address(RVA = "0xB2066C", Offset = "0xB2066C", Length = "0xE8")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
	protected virtual void ClampPosition()
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000569")]
	[global::Cpp2ILInjected.Address(RVA = "0xB20754", Offset = "0xB20754", Length = "0x24")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	private int SideToRow(int side)
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x600056A")]
	[global::Cpp2ILInjected.Address(RVA = "0xB20778", Offset = "0xB20778", Length = "0x24")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	private int RowToSide(int row)
	{
		throw null;
	}

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

	[global::Cpp2ILInjected.Token(Token = "0x40004A4")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C")]
	public bool insideSideIcons;

	[global::Cpp2ILInjected.Token(Token = "0x40004A5")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	public int itemRow;

	[global::Cpp2ILInjected.Token(Token = "0x40004A6")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x24")]
	public int itemColumn;

	[global::Cpp2ILInjected.Token(Token = "0x40004A7")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
	public int sideRow;
}
