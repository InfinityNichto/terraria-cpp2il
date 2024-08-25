using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

[global::Cpp2ILInjected.Token(Token = "0x2000234")]
public class Reforge_Layout : PageControllerLayoutDefinition<Reforge_Layout>
{
	[global::Cpp2ILInjected.Token(Token = "0x1700016A")]
	public DraggableItemGrid_Layout DisplayItemGrid
	{
		[global::Cpp2ILInjected.Token(Token = "0x6000D03")]
		[global::Cpp2ILInjected.Address(RVA = "0x9D1A70", Offset = "0x9D1A70", Length = "0x9C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerReforge), Member = "GetSelectedItemRegion", ReturnType = typeof(Rectangle))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerReforge4Page), Member = "GetGrid", ReturnType = typeof(DraggableItemGrid_Layout))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIReforge), Member = "LoadPageRegion", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIReforge), Member = "Draw", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 10)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIReforge), Member = "get_Collapsed", ReturnType = typeof(bool))]
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

	[global::Cpp2ILInjected.Token(Token = "0x6000D04")]
	[global::Cpp2ILInjected.Address(RVA = "0x9D1B0C", Offset = "0x9D1B0C", Length = "0x1C0")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(float),
		typeof(float)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Texture_Layout), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PageControllerLayoutDefinition<>), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
	public Reforge_Layout()
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x4001701")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	public String_Layout Guide;

	[global::Cpp2ILInjected.Token(Token = "0x4001702")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
	public String_Layout Cost;

	[global::Cpp2ILInjected.Token(Token = "0x4001703")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
	public String_Layout ControllerCost;

	[global::Cpp2ILInjected.Token(Token = "0x4001704")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
	public Panel_Layout SavingsBacking;

	[global::Cpp2ILInjected.Token(Token = "0x4001705")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
	public String_Layout Savings;

	[global::Cpp2ILInjected.Token(Token = "0x4001706")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
	public String_Layout SavingsTitle;

	[global::Cpp2ILInjected.Token(Token = "0x4001707")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
	public Vector2 Savings1IconOffset;

	[global::Cpp2ILInjected.Token(Token = "0x4001708")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
	public Vector2 Savings2IconOffset;

	[global::Cpp2ILInjected.Token(Token = "0x4001709")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
	public Vector2 Savings3IconOffset;

	[global::Cpp2ILInjected.Token(Token = "0x400170A")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x68")]
	public Vector2 Savings4IconOffset;

	[global::Cpp2ILInjected.Token(Token = "0x400170B")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x70")]
	public String_Layout Title;

	[global::Cpp2ILInjected.Token(Token = "0x400170C")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x78")]
	public float ItemScale;

	[global::Cpp2ILInjected.Token(Token = "0x400170D")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x7C")]
	public float ItemHighlightScale;

	[global::Cpp2ILInjected.Token(Token = "0x400170E")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x80")]
	public bool DrawEmptySlots;

	[global::Cpp2ILInjected.Token(Token = "0x400170F")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x88")]
	public Texture_Layout DisabledBacking;

	[global::Cpp2ILInjected.Token(Token = "0x4001710")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x90")]
	public Color DisabledBackingColor;

	[global::Cpp2ILInjected.Token(Token = "0x4001711")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x98")]
	public Texture_Layout DisabledBackingIcon;

	[global::Cpp2ILInjected.Token(Token = "0x4001712")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xA0")]
	public Color DisabledBackingIconColor;

	[global::Cpp2ILInjected.Token(Token = "0x4001713")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xA8")]
	public DraggableItemGrid_Layout HorizontalReforgeItemGrid;

	[global::Cpp2ILInjected.Token(Token = "0x4001714")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xB0")]
	public DraggableItemGrid_Layout HorizontalReforgeItemGridCollapsed;

	[global::Cpp2ILInjected.Token(Token = "0x4001715")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xB8")]
	public DraggableItemGrid_Layout ReforgeItemGrid;

	[global::Cpp2ILInjected.Token(Token = "0x4001716")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xC0")]
	public DraggableItemGrid_Layout ReforgeItemGridCollapsed;

	[global::Cpp2ILInjected.Token(Token = "0x4001717")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xC8")]
	public TransactionButton_Layout ReforgeButton;
}
