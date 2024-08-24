using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;

// Token: 0x02000090 RID: 144
[global::Cpp2ILInjected.Token(Token = "0x20000CA")]
public class GUIControllerHousing : GUIPageContentController
{
	// Token: 0x06000450 RID: 1104 RVA: 0x00022835 File Offset: 0x00020A35
	[global::Cpp2ILInjected.Token(Token = "0x60004EA")]
	[global::Cpp2ILInjected.Address(RVA = "0xB1A148", Offset = "0xB1A148", Length = "0x2C")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
	public GUIControllerHousing()
	{
		throw null;
	}

	// Token: 0x06000451 RID: 1105 RVA: 0x00022838 File Offset: 0x00020A38
	[global::Cpp2ILInjected.Token(Token = "0x60004EB")]
	[global::Cpp2ILInjected.Address(RVA = "0xB1A174", Offset = "0xB1A174", Length = "0x8")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	public virtual bool IsInMenu()
	{
		throw null;
	}

	// Token: 0x06000452 RID: 1106 RVA: 0x0002283B File Offset: 0x00020A3B
	[global::Cpp2ILInjected.Token(Token = "0x60004EC")]
	[global::Cpp2ILInjected.Address(RVA = "0xB1A17C", Offset = "0xB1A17C", Length = "0x4")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	public override void Activate()
	{
		throw null;
	}

	// Token: 0x06000453 RID: 1107 RVA: 0x0002283E File Offset: 0x00020A3E
	[global::Cpp2ILInjected.Token(Token = "0x60004ED")]
	[global::Cpp2ILInjected.Address(RVA = "0xB1A180", Offset = "0xB1A180", Length = "0x4")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	public virtual void NextItem()
	{
		throw null;
	}

	// Token: 0x06000454 RID: 1108 RVA: 0x00022841 File Offset: 0x00020A41
	[global::Cpp2ILInjected.Token(Token = "0x60004EE")]
	[global::Cpp2ILInjected.Address(RVA = "0xB1A184", Offset = "0xB1A184", Length = "0x4")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	public virtual void PreviousItem()
	{
		throw null;
	}

	// Token: 0x17000064 RID: 100
	// (get) Token: 0x06000455 RID: 1109 RVA: 0x00022844 File Offset: 0x00020A44
	[global::Cpp2ILInjected.Token(Token = "0x17000089")]
	public int MinRow
	{
		[global::Cpp2ILInjected.Token(Token = "0x60004EF")]
		[global::Cpp2ILInjected.Address(RVA = "0xB1A188", Offset = "0xB1A188", Length = "0x80")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerHousing), Member = "ClampPosition", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17000065 RID: 101
	// (get) Token: 0x06000456 RID: 1110 RVA: 0x00022847 File Offset: 0x00020A47
	[global::Cpp2ILInjected.Token(Token = "0x1700008A")]
	public int MaxColumns
	{
		[global::Cpp2ILInjected.Token(Token = "0x60004F0")]
		[global::Cpp2ILInjected.Address(RVA = "0xB1A208", Offset = "0xB1A208", Length = "0x6C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		get
		{
			throw null;
		}
	}

	// Token: 0x06000457 RID: 1111 RVA: 0x0002284A File Offset: 0x00020A4A
	[global::Cpp2ILInjected.Token(Token = "0x60004F1")]
	[global::Cpp2ILInjected.Address(RVA = "0xB1A274", Offset = "0xB1A274", Length = "0xB0")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerHousing), Member = "get_MinRow", ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	protected virtual void ClampPosition()
	{
		throw null;
	}

	// Token: 0x06000458 RID: 1112 RVA: 0x0002284D File Offset: 0x00020A4D
	[global::Cpp2ILInjected.Token(Token = "0x60004F2")]
	[global::Cpp2ILInjected.Address(RVA = "0xB1A324", Offset = "0xB1A324", Length = "0x128")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
	public override GUIControllerItem Navigate(Vector2 navigationVector)
	{
		throw null;
	}

	// Token: 0x06000459 RID: 1113 RVA: 0x00022850 File Offset: 0x00020A50
	[global::Cpp2ILInjected.Token(Token = "0x60004F3")]
	[global::Cpp2ILInjected.Address(RVA = "0xB1A938", Offset = "0xB1A938", Length = "0x24C")]
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
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HousingMenu_Layout), Member = "get_DisplayNPCGrid", ReturnType = typeof(DraggableItemGrid_Layout))]
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

	// Token: 0x040002E3 RID: 739
	[global::Cpp2ILInjected.Token(Token = "0x400046D")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C")]
	public int itemRow;

	// Token: 0x040002E4 RID: 740
	[global::Cpp2ILInjected.Token(Token = "0x400046E")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	public int itemColumn;
}
