using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

// Token: 0x020001AA RID: 426
[global::Cpp2ILInjected.Token(Token = "0x2000239")]
public class RubbleMakerUI_Layout : LayoutDefinition
{
	// Token: 0x17000146 RID: 326
	// (get) Token: 0x06000BF4 RID: 3060 RVA: 0x00023F21 File Offset: 0x00022121
	[global::Cpp2ILInjected.Token(Token = "0x1700016D")]
	public static RubbleMakerUI_Layout Instance
	{
		[global::Cpp2ILInjected.Token(Token = "0x6000D0E")]
		[global::Cpp2ILInjected.Address(RVA = "0x9D2120", Offset = "0x9D2120", Length = "0x7C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerRubbleMaker), Member = "Navigate", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(GUIControllerItem))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerRubbleMaker), Member = "ClampMaterialGrid", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerRubbleMaker), Member = "ClampRubbleGrid", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerRubbleMaker), Member = "GetSelectedItemRegion", ReturnType = typeof(Rectangle))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIRubbleMaker), Member = "PlayerMenuDisplayToggle", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIRubbleMaker), Member = "ClampPositionToScreen", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(VirtualControlsHardwareConfigurationMapping_Layout)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIRubbleMaker), Member = "MaterialItemScale", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIRubbleMaker), Member = "RubbleItemScale", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIRubbleMaker), Member = "MaterialItemDraw", MemberParameters = new object[]
		{
			typeof(ItemGrid_Layout),
			typeof(int),
			typeof(Vector2),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIRubbleMaker), Member = "RubbleItemDraw", MemberParameters = new object[]
		{
			typeof(ItemGrid_Layout),
			typeof(int),
			typeof(Vector2),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIRubbleMaker), Member = "DrawOverlay", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIRubbleMaker), Member = "IsOver", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIRubbleMaker), Member = "CalculateMaterialRegion", ReturnType = typeof(Rectangle))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIRubbleMaker), Member = "CalculateRegion", ReturnType = typeof(Rectangle))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 42)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		get
		{
			throw null;
		}
	}

	// Token: 0x06000BF5 RID: 3061 RVA: 0x00023F24 File Offset: 0x00022124
	[global::Cpp2ILInjected.Token(Token = "0x6000D0F")]
	[global::Cpp2ILInjected.Address(RVA = "0x9D219C", Offset = "0x9D219C", Length = "0x84")]
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

	// Token: 0x06000BF6 RID: 3062 RVA: 0x00023F27 File Offset: 0x00022127
	[global::Cpp2ILInjected.Token(Token = "0x6000D10")]
	[global::Cpp2ILInjected.Address(RVA = "0x9D2220", Offset = "0x9D2220", Length = "0x14C")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Texture_Layout), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(float),
		typeof(float)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
	public RubbleMakerUI_Layout()
	{
		throw null;
	}

	// Token: 0x0400129C RID: 4764
	[global::Cpp2ILInjected.Token(Token = "0x4001751")]
	public static RubbleMakerUI_Layout InstanceNormal;

	// Token: 0x0400129D RID: 4765
	[global::Cpp2ILInjected.Token(Token = "0x4001752")]
	public static RubbleMakerUI_Layout Instance4Page;

	// Token: 0x0400129E RID: 4766
	[global::Cpp2ILInjected.Token(Token = "0x4001753")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
	public Panel_Layout Backing;

	// Token: 0x0400129F RID: 4767
	[global::Cpp2ILInjected.Token(Token = "0x4001754")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	public ItemGrid_Layout MaterialOptions;

	// Token: 0x040012A0 RID: 4768
	[global::Cpp2ILInjected.Token(Token = "0x4001755")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
	public ItemGrid_Layout RubbleOptions;

	// Token: 0x040012A1 RID: 4769
	[global::Cpp2ILInjected.Token(Token = "0x4001756")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
	public Panel_Layout MenuDivider;

	// Token: 0x040012A2 RID: 4770
	[global::Cpp2ILInjected.Token(Token = "0x4001757")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
	public bool DrawEmptySlots;

	// Token: 0x040012A3 RID: 4771
	[global::Cpp2ILInjected.Token(Token = "0x4001758")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
	public Texture_Layout DisabledBacking;

	// Token: 0x040012A4 RID: 4772
	[global::Cpp2ILInjected.Token(Token = "0x4001759")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
	public Color DisabledBackingColor;

	// Token: 0x040012A5 RID: 4773
	[global::Cpp2ILInjected.Token(Token = "0x400175A")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
	public Texture_Layout DisabledBackingIcon;

	// Token: 0x040012A6 RID: 4774
	[global::Cpp2ILInjected.Token(Token = "0x400175B")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
	public Color DisabledBackingIconColor;

	// Token: 0x040012A7 RID: 4775
	[global::Cpp2ILInjected.Token(Token = "0x400175C")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x5C")]
	public Vector2 TouchPanelOffset;

	// Token: 0x040012A8 RID: 4776
	[global::Cpp2ILInjected.Token(Token = "0x400175D")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x68")]
	public TransactionButton_Layout SizeToggle;

	// Token: 0x040012A9 RID: 4777
	[global::Cpp2ILInjected.Token(Token = "0x400175E")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x70")]
	public TransactionButton_Layout MaterialToggle;

	// Token: 0x040012AA RID: 4778
	[global::Cpp2ILInjected.Token(Token = "0x400175F")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x78")]
	public float MaterialScale;

	// Token: 0x040012AB RID: 4779
	[global::Cpp2ILInjected.Token(Token = "0x4001760")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x7C")]
	public float HighlightedMaterialScale;

	// Token: 0x040012AC RID: 4780
	[global::Cpp2ILInjected.Token(Token = "0x4001761")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x80")]
	public float RubbleScale;

	// Token: 0x040012AD RID: 4781
	[global::Cpp2ILInjected.Token(Token = "0x4001762")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x84")]
	public float HighlightedRubbleScale;

	// Token: 0x040012AE RID: 4782
	[global::Cpp2ILInjected.Token(Token = "0x4001763")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x88")]
	public Vector2 SmallRubblePreviewScaleOffset;

	// Token: 0x040012AF RID: 4783
	[global::Cpp2ILInjected.Token(Token = "0x4001764")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x90")]
	public float SmallRubblePreviewScale;

	// Token: 0x040012B0 RID: 4784
	[global::Cpp2ILInjected.Token(Token = "0x4001765")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x94")]
	public Vector2 MediumRubblePreviewScaleOffset;

	// Token: 0x040012B1 RID: 4785
	[global::Cpp2ILInjected.Token(Token = "0x4001766")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x9C")]
	public float MediumRubblePreviewScale;

	// Token: 0x040012B2 RID: 4786
	[global::Cpp2ILInjected.Token(Token = "0x4001767")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xA0")]
	public Vector2 LargeRubblePreviewScaleOffset;

	// Token: 0x040012B3 RID: 4787
	[global::Cpp2ILInjected.Token(Token = "0x4001768")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xA8")]
	public float LargeRubblePreviewScale;

	// Token: 0x040012B4 RID: 4788
	[global::Cpp2ILInjected.Token(Token = "0x4001769")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xB0")]
	public Panel_Layout MaterialBacking;

	// Token: 0x040012B5 RID: 4789
	[global::Cpp2ILInjected.Token(Token = "0x400176A")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xB8")]
	public Vector2 MaterialBackingTLOffset;

	// Token: 0x040012B6 RID: 4790
	[global::Cpp2ILInjected.Token(Token = "0x400176B")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xC0")]
	public Vector2 MaterialBackingBROffset;

	// Token: 0x040012B7 RID: 4791
	[global::Cpp2ILInjected.Token(Token = "0x400176C")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xC8")]
	public FadeString_Layout TooltipDisplay;
}
