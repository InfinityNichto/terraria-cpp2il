using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework.Graphics;

[global::Cpp2ILInjected.Token(Token = "0x2000210")]
public class SafeRegionEdit_Layout : LayoutDefinition
{
	[global::Cpp2ILInjected.Token(Token = "0x6000CBE")]
	[global::Cpp2ILInjected.Address(RVA = "0x9CFDF8", Offset = "0x9CFDF8", Length = "0x4C")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	private void Awake()
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000CBF")]
	[global::Cpp2ILInjected.Address(RVA = "0x9CFE44", Offset = "0x9CFE44", Length = "0x70")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
	public SafeRegionEdit_Layout()
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x40013A5")]
	public static SafeRegionEdit_Layout Instance;

	[global::Cpp2ILInjected.Token(Token = "0x40013A6")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
	public float ButtonEdgeInset;

	[global::Cpp2ILInjected.Token(Token = "0x40013A7")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C")]
	public float MaxEdgeMovementScale;

	[global::Cpp2ILInjected.Token(Token = "0x40013A8")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	public float ControllerDragSpeed;

	[global::Cpp2ILInjected.Token(Token = "0x40013A9")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x24")]
	public Color DefaultLinkColor;

	[global::Cpp2ILInjected.Token(Token = "0x40013AA")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
	public Color DraggingLinkColor;

	[global::Cpp2ILInjected.Token(Token = "0x40013AB")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
	public Panel_Layout ScreenBacking;

	[global::Cpp2ILInjected.Token(Token = "0x40013AC")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
	public Panel_Layout ScreenEdge;

	[global::Cpp2ILInjected.Token(Token = "0x40013AD")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
	public Panel_Layout ScreenEdgeTop;

	[global::Cpp2ILInjected.Token(Token = "0x40013AE")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
	public Panel_Layout ScreenEdgeLeft;

	[global::Cpp2ILInjected.Token(Token = "0x40013AF")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
	public Panel_Layout ScreenEdgeRight;

	[global::Cpp2ILInjected.Token(Token = "0x40013B0")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
	public Panel_Layout ScreenEdgeBottom;

	[global::Cpp2ILInjected.Token(Token = "0x40013B1")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
	public TransactionButton_Layout Left;

	[global::Cpp2ILInjected.Token(Token = "0x40013B2")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x68")]
	public Panel_Layout LeftLink;

	[global::Cpp2ILInjected.Token(Token = "0x40013B3")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x70")]
	public TransactionButton_Layout Right;

	[global::Cpp2ILInjected.Token(Token = "0x40013B4")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x78")]
	public Panel_Layout RightLink;

	[global::Cpp2ILInjected.Token(Token = "0x40013B5")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x80")]
	public TransactionButton_Layout Top;

	[global::Cpp2ILInjected.Token(Token = "0x40013B6")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x88")]
	public Panel_Layout TopLink;

	[global::Cpp2ILInjected.Token(Token = "0x40013B7")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x90")]
	public TransactionButton_Layout Bottom;

	[global::Cpp2ILInjected.Token(Token = "0x40013B8")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x98")]
	public Panel_Layout BottomLink;

	[global::Cpp2ILInjected.Token(Token = "0x40013B9")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xA0")]
	public TransactionButton_Layout Finish;

	[global::Cpp2ILInjected.Token(Token = "0x40013BA")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xA8")]
	public TransactionButton_Layout Reset;
}
