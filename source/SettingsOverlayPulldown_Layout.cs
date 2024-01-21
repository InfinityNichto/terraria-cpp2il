using System;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

[Serializable]
[Cpp2IlInjected.Token(Token = "0x200018D")]
public class SettingsOverlayPulldown_Layout
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4001012")]
	public TransactionButton_Layout PulldownButton;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4001013")]
	public String_Layout PulldownTitle;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4001014")]
	public Color DisabledPulldownLabelColour;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4001015")]
	public Panel_Layout PulldownGreyout;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4001016")]
	public Panel_Layout PulldownBacking;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4001017")]
	public Vector2 PulldownBackingTLOffset;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4001018")]
	public Vector2 PulldownBackingBROffset;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4001019")]
	public float PulldownButtonExtraPadding;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400101A")]
	public TransactionButton_Layout Option1;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x400101B")]
	public TransactionButton_Layout Option2;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400101C")]
	public TransactionButton_Layout Option3;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x400101D")]
	public TransactionButton_Layout Option4;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400101E")]
	public TransactionButton_Layout Option5;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x400101F")]
	public TransactionButton_Layout Option6;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4001020")]
	public TransactionButton_Layout Option7;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x4001021")]
	public TransactionButton_Layout Option8;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4001022")]
	public TransactionButton_Layout Option9;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4001023")]
	public TransactionButton_Layout Option10;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4001024")]
	public TransactionButton_Layout Option11;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x4001025")]
	public TransactionButton_Layout Option12;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4001026")]
	public float ElementSpacing;

	[Cpp2IlInjected.Token(Token = "0x6000BC3")]
	[Cpp2IlInjected.Address(RVA = "0x105F530", Offset = "0x105F530", VA = "0x105F530")]
	public TransactionButton_Layout GetOption(int index)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000BC4")]
	[Cpp2IlInjected.Address(RVA = "0x105F5DC", Offset = "0x105F5DC", VA = "0x105F5DC")]
	public SettingsOverlayPulldown_Layout()
	{
	}
}
