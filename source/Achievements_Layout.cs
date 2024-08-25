using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;

[global::Cpp2ILInjected.Token(Token = "0x200018D")]
public class Achievements_Layout : LayoutDefinition
{
	[global::Cpp2ILInjected.Token(Token = "0x6000B47")]
	[global::Cpp2ILInjected.Address(RVA = "0x9AB788", Offset = "0x9AB788", Length = "0x4C")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	private void Awake()
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000B48")]
	[global::Cpp2ILInjected.Address(RVA = "0x9AB7D4", Offset = "0x9AB7D4", Length = "0xB4")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(float),
		typeof(float)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LayoutDefinition), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
	public Achievements_Layout()
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x4000BF6")]
	public static Achievements_Layout Instance;

	[global::Cpp2ILInjected.Token(Token = "0x4000BF7")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
	public Panel_Layout Backing;

	[global::Cpp2ILInjected.Token(Token = "0x4000BF8")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	public DraggableItemGrid_Layout AchievementsGrid;

	[global::Cpp2ILInjected.Token(Token = "0x4000BF9")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
	public StringButton_Layout Title;

	[global::Cpp2ILInjected.Token(Token = "0x4000BFA")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
	public Panel_Layout MenuDivider;

	[global::Cpp2ILInjected.Token(Token = "0x4000BFB")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
	public Panel_Layout MenuDivider2;

	[global::Cpp2ILInjected.Token(Token = "0x4000BFC")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
	public TransactionButton_Layout Back;

	[global::Cpp2ILInjected.Token(Token = "0x4000BFD")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
	public Panel_Layout ItemBacking;

	[global::Cpp2ILInjected.Token(Token = "0x4000BFE")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
	public Panel_Layout ItemSelectedBacking;

	[global::Cpp2ILInjected.Token(Token = "0x4000BFF")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
	public Button_Layout ItemDivider;

	[global::Cpp2ILInjected.Token(Token = "0x4000C00")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
	public String_Layout ItemName;

	[global::Cpp2ILInjected.Token(Token = "0x4000C01")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x68")]
	public String_Layout ItemNameCompleted;

	[global::Cpp2ILInjected.Token(Token = "0x4000C02")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x70")]
	public Panel_Layout ItemNameDivider;

	[global::Cpp2ILInjected.Token(Token = "0x4000C03")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x78")]
	public String_Layout ItemDescription;

	[global::Cpp2ILInjected.Token(Token = "0x4000C04")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x80")]
	public int ItemDescWidth;

	[global::Cpp2ILInjected.Token(Token = "0x4000C05")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x88")]
	public AchievementIcon ItemIcon;

	[global::Cpp2ILInjected.Token(Token = "0x4000C06")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x90")]
	public Vector2 ItemCatIconsPosition;

	[global::Cpp2ILInjected.Token(Token = "0x4000C07")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x98")]
	public float ItemCatIconsScale;

	[global::Cpp2ILInjected.Token(Token = "0x4000C08")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xA0")]
	public String_Layout ProgressNumbers;

	[global::Cpp2ILInjected.Token(Token = "0x4000C09")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xA8")]
	public ProgressBar_Layout ProgressBar;

	[global::Cpp2ILInjected.Token(Token = "0x4000C0A")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xB0")]
	public Panel_Layout ItemInnerPanelTop;

	[global::Cpp2ILInjected.Token(Token = "0x4000C0B")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xB8")]
	public Panel_Layout ItemSelectedInnerPanelTop;

	[global::Cpp2ILInjected.Token(Token = "0x4000C0C")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xC0")]
	public Panel_Layout ItemInnerPanelBottom;

	[global::Cpp2ILInjected.Token(Token = "0x4000C0D")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xC8")]
	public Panel_Layout ItemSelectedInnerPanelBottom;

	[global::Cpp2ILInjected.Token(Token = "0x4000C0E")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xD0")]
	public Panel_Layout CategoryDivider;

	[global::Cpp2ILInjected.Token(Token = "0x4000C0F")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xD8")]
	public Vector2 InGameWindowShift;

	[global::Cpp2ILInjected.Token(Token = "0x4000C10")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xE0")]
	public TransactionButton_Layout Filters;

	[global::Cpp2ILInjected.Token(Token = "0x4000C11")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xE8")]
	public Panel_Layout FiltersBacking;

	[global::Cpp2ILInjected.Token(Token = "0x4000C12")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xF0")]
	public TransactionButton_Layout Slayer;

	[global::Cpp2ILInjected.Token(Token = "0x4000C13")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xF8")]
	public TransactionButton_Layout Collector;

	[global::Cpp2ILInjected.Token(Token = "0x4000C14")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x100")]
	public TransactionButton_Layout Explorer;

	[global::Cpp2ILInjected.Token(Token = "0x4000C15")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x108")]
	public TransactionButton_Layout Challenger;
}
