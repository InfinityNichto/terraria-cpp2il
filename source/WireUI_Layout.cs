using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

// Token: 0x020001BE RID: 446
[global::Cpp2ILInjected.Token(Token = "0x2000253")]
public class WireUI_Layout : LayoutDefinition
{
	// Token: 0x1700014C RID: 332
	// (get) Token: 0x06000C38 RID: 3128 RVA: 0x00023FED File Offset: 0x000221ED
	[global::Cpp2ILInjected.Token(Token = "0x17000173")]
	public static WireUI_Layout Instance
	{
		[global::Cpp2ILInjected.Token(Token = "0x6000D53")]
		[global::Cpp2ILInjected.Address(RVA = "0x9D7304", Offset = "0x9D7304", Length = "0x7C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerWiresUI), Member = "GetSelectedItemRegion", ReturnType = typeof(Rectangle))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIWiresUI), Member = "ClampPositionToScreen", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIWiresUI), Member = "ItemDraw", MemberParameters = new object[]
		{
			typeof(ItemGrid_Layout),
			typeof(int),
			typeof(Vector2),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIWiresUI), Member = "DrawOverlay", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIWiresUI), Member = "DrawCursorArea", MemberParameters = new object[] { typeof(SpriteBatch) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIWiresUI), Member = "CalculateRegion", ReturnType = typeof(Rectangle))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 22)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		get
		{
			throw null;
		}
	}

	// Token: 0x06000C39 RID: 3129 RVA: 0x00023FF0 File Offset: 0x000221F0
	[global::Cpp2ILInjected.Token(Token = "0x6000D54")]
	[global::Cpp2ILInjected.Address(RVA = "0x9D7380", Offset = "0x9D7380", Length = "0x84")]
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

	// Token: 0x06000C3A RID: 3130 RVA: 0x00023FF3 File Offset: 0x000221F3
	[global::Cpp2ILInjected.Token(Token = "0x6000D55")]
	[global::Cpp2ILInjected.Address(RVA = "0x9D7404", Offset = "0x9D7404", Length = "0xB4")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(float),
		typeof(float)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
	public WireUI_Layout()
	{
		throw null;
	}

	// Token: 0x040013A7 RID: 5031
	[global::Cpp2ILInjected.Token(Token = "0x4001894")]
	public static WireUI_Layout InstanceNormal;

	// Token: 0x040013A8 RID: 5032
	[global::Cpp2ILInjected.Token(Token = "0x4001895")]
	public static WireUI_Layout Instance4Page;

	// Token: 0x040013A9 RID: 5033
	[global::Cpp2ILInjected.Token(Token = "0x4001896")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
	public Vector2 BackingTLOffset;

	// Token: 0x040013AA RID: 5034
	[global::Cpp2ILInjected.Token(Token = "0x4001897")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	public Vector2 BackingBROffset;

	// Token: 0x040013AB RID: 5035
	[global::Cpp2ILInjected.Token(Token = "0x4001898")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
	public Panel_Layout Backing;

	// Token: 0x040013AC RID: 5036
	[global::Cpp2ILInjected.Token(Token = "0x4001899")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
	public Panel_Layout CutterBacking;

	// Token: 0x040013AD RID: 5037
	[global::Cpp2ILInjected.Token(Token = "0x400189A")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
	public ItemGrid_Layout ToolOptions;

	// Token: 0x040013AE RID: 5038
	[global::Cpp2ILInjected.Token(Token = "0x400189B")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
	public Vector2 CursorPanelOffset;

	// Token: 0x040013AF RID: 5039
	[global::Cpp2ILInjected.Token(Token = "0x400189C")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
	public Vector2 TouchPanelOffset;

	// Token: 0x040013B0 RID: 5040
	[global::Cpp2ILInjected.Token(Token = "0x400189D")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
	public TransactionButton_Layout PlacementBacking;

	// Token: 0x040013B1 RID: 5041
	[global::Cpp2ILInjected.Token(Token = "0x400189E")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
	public TransactionButton_Layout RemovalBacking;

	// Token: 0x040013B2 RID: 5042
	[global::Cpp2ILInjected.Token(Token = "0x400189F")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
	public FadeString_Layout TooltipDisplay;
}
