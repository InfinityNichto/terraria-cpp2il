using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;

[global::Cpp2ILInjected.Token(Token = "0x2000236")]
public class Research_Layout : LayoutDefinition
{
	[global::Cpp2ILInjected.Token(Token = "0x1700016C")]
	public static Research_Layout Instance
	{
		[global::Cpp2ILInjected.Token(Token = "0x6000D07")]
		[global::Cpp2ILInjected.Address(RVA = "0x9D1E80", Offset = "0x9D1E80", Length = "0x7C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerResearchPage4Page), Member = "GetSelectedItemRegion", ReturnType = typeof(Rectangle))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIResearch), Member = "GetRegion", ReturnType = typeof(Rectangle))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIResearch), Member = "DrawInventoryResearchButton", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIResearch), Member = "IsOver", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIResearch), Member = "Draw", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIResearch), Member = "DrawMainButtons", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIResearch), Member = "BeginResearchAnimation", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIResearch), Member = "DrawBacking", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIResearch), Member = "DrawResearchBacking", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIResearch), Member = "DrawResearchCogs", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIResearch), Member = "DrawItemProgress", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIResearch), Member = "DrawResearchItem", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIVirtualInputController), Member = "IsOverGroupRegion", MemberParameters = new object[]
		{
			typeof(GUIPageIconGrouping),
			typeof(Point)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 16)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		get
		{
			throw null;
		}
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000D08")]
	[global::Cpp2ILInjected.Address(RVA = "0x9D1EFC", Offset = "0x9D1EFC", Length = "0x84")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Equality", MemberParameters = new object[]
	{
		typeof(string),
		typeof(string)
	}, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
	private void Awake()
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000D09")]
	[global::Cpp2ILInjected.Address(RVA = "0x9D1F80", Offset = "0x9D1F80", Length = "0x58")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
	public Research_Layout()
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x4001725")]
	public static Research_Layout InstanceNormal;

	[global::Cpp2ILInjected.Token(Token = "0x4001726")]
	public static Research_Layout Instance4Page;

	[global::Cpp2ILInjected.Token(Token = "0x4001727")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
	public TransactionButton_Layout InventoryResearch;

	[global::Cpp2ILInjected.Token(Token = "0x4001728")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	public TransactionButton_Layout InventoryResearchController;

	[global::Cpp2ILInjected.Token(Token = "0x4001729")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
	public Vector2 InventoryResearchControllerWiringOffset;

	[global::Cpp2ILInjected.Token(Token = "0x400172A")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
	public Panel_Layout Backing;

	[global::Cpp2ILInjected.Token(Token = "0x400172B")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
	public Panel_Layout BackingController;

	[global::Cpp2ILInjected.Token(Token = "0x400172C")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
	public Panel_Layout ImageBacking;

	[global::Cpp2ILInjected.Token(Token = "0x400172D")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
	public Panel_Layout ResearchItem;

	[global::Cpp2ILInjected.Token(Token = "0x400172E")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
	public Panel_Layout ResearchItemBacking;

	[global::Cpp2ILInjected.Token(Token = "0x400172F")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
	public Panel_Layout ResearchCogLeft1;

	[global::Cpp2ILInjected.Token(Token = "0x4001730")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
	public Panel_Layout ResearchCogLeft2;

	[global::Cpp2ILInjected.Token(Token = "0x4001731")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x68")]
	public Panel_Layout ResearchCogLeft3;

	[global::Cpp2ILInjected.Token(Token = "0x4001732")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x70")]
	public Panel_Layout ResearchCogRight1;

	[global::Cpp2ILInjected.Token(Token = "0x4001733")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x78")]
	public Panel_Layout ResearchCogRight2;

	[global::Cpp2ILInjected.Token(Token = "0x4001734")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x80")]
	public Panel_Layout ResearchCogRight3;

	[global::Cpp2ILInjected.Token(Token = "0x4001735")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x88")]
	public Panel_Layout Divider;

	[global::Cpp2ILInjected.Token(Token = "0x4001736")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x90")]
	public Panel_Layout Divider2;

	[global::Cpp2ILInjected.Token(Token = "0x4001737")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x98")]
	public TransactionButton_Layout Close;

	[global::Cpp2ILInjected.Token(Token = "0x4001738")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xA0")]
	public TransactionButton_Layout ActionResearch;

	[global::Cpp2ILInjected.Token(Token = "0x4001739")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xA8")]
	public String_Layout ItemName;

	[global::Cpp2ILInjected.Token(Token = "0x400173A")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xB0")]
	public String_Layout Description;

	[global::Cpp2ILInjected.Token(Token = "0x400173B")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xB8")]
	public Panel_Layout BarBacking;

	[global::Cpp2ILInjected.Token(Token = "0x400173C")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xC0")]
	public Panel_Layout CurrentProgress;

	[global::Cpp2ILInjected.Token(Token = "0x400173D")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xC8")]
	public Panel_Layout NewProgress;

	[global::Cpp2ILInjected.Token(Token = "0x400173E")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xD0")]
	public String_Layout Progress;

	[global::Cpp2ILInjected.Token(Token = "0x400173F")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xD8")]
	public String_Layout StackCount;
}
