using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework.Graphics;

[global::Cpp2ILInjected.Token(Token = "0x2000235")]
public class ResearchPage_Layout : PageControllerLayoutDefinition<ResearchPage_Layout>
{
	[global::Cpp2ILInjected.Token(Token = "0x1700016B")]
	public DraggableItemGrid_Layout DisplayItemGrid
	{
		[global::Cpp2ILInjected.Token(Token = "0x6000D05")]
		[global::Cpp2ILInjected.Address(RVA = "0x9D1CCC", Offset = "0x9D1CCC", Length = "0x9C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerResearchPage4Page), Member = "GetGrid", ReturnType = typeof(DraggableItemGrid_Layout))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIResearchPage), Member = "LoadPageRegion", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIResearchPage), Member = "Draw", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIResearchPage), Member = "get_Collapsed", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PageIconsExtended_Layout), Member = "GetDisplayGrid", MemberParameters = new object[]
		{
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(DraggableItemGrid_Layout))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		get
		{
			throw null;
		}
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000D06")]
	[global::Cpp2ILInjected.Address(RVA = "0x9D1D68", Offset = "0x9D1D68", Length = "0x118")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Texture_Layout), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PageControllerLayoutDefinition<>), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
	public ResearchPage_Layout()
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x4001718")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	public String_Layout Title;

	[global::Cpp2ILInjected.Token(Token = "0x4001719")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
	public float ItemScale;

	[global::Cpp2ILInjected.Token(Token = "0x400171A")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x2C")]
	public float ItemHighlightScale;

	[global::Cpp2ILInjected.Token(Token = "0x400171B")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
	public bool DrawEmptySlots;

	[global::Cpp2ILInjected.Token(Token = "0x400171C")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
	public Texture_Layout DisabledBacking;

	[global::Cpp2ILInjected.Token(Token = "0x400171D")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
	public Color DisabledBackingColor;

	[global::Cpp2ILInjected.Token(Token = "0x400171E")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
	public Texture_Layout DisabledBackingIcon;

	[global::Cpp2ILInjected.Token(Token = "0x400171F")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
	public Color DisabledBackingIconColor;

	[global::Cpp2ILInjected.Token(Token = "0x4001720")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
	public DraggableItemGrid_Layout ResearchItemGrid;

	[global::Cpp2ILInjected.Token(Token = "0x4001721")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
	public DraggableItemGrid_Layout ResearchItemGridCollapsed;

	[global::Cpp2ILInjected.Token(Token = "0x4001722")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x68")]
	public DraggableItemGrid_Layout ResearchItemGrid_Horizontal;

	[global::Cpp2ILInjected.Token(Token = "0x4001723")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x70")]
	public DraggableItemGrid_Layout ResearchItemGridCollapsed_Horizontal;

	[global::Cpp2ILInjected.Token(Token = "0x4001724")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x78")]
	public TransactionButton_Layout ResearchButton;
}
