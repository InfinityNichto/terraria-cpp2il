using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

[global::Cpp2ILInjected.Token(Token = "0x2000218")]
[Serializable]
public class SettingsOverlayPulldown_Layout
{
	[global::Cpp2ILInjected.Token(Token = "0x6000CC7")]
	[global::Cpp2ILInjected.Address(RVA = "0x9D032C", Offset = "0x9D032C", Length = "0x90")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerMappingOverlay), Member = "GetSelectedItemRegion", ReturnType = typeof(Rectangle))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerJourneyModeSettings), Member = "GetSelectedItemRegion", ReturnType = typeof(Rectangle))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerSettingsOverlay), Member = "GetSelectedItemRegion", ReturnType = typeof(Rectangle))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIPulldownSetting), Member = "RefreshInputRegion", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIPulldownSetting), Member = "Draw", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 11)]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	public TransactionButton_Layout GetOption(int index)
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000CC8")]
	[global::Cpp2ILInjected.Address(RVA = "0x9D03BC", Offset = "0x9D03BC", Length = "0x8")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
	public SettingsOverlayPulldown_Layout()
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x400146D")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
	public TransactionButton_Layout PulldownButton;

	[global::Cpp2ILInjected.Token(Token = "0x400146E")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
	public String_Layout PulldownTitle;

	[global::Cpp2ILInjected.Token(Token = "0x400146F")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	public Color DisabledPulldownLabelColour;

	[global::Cpp2ILInjected.Token(Token = "0x4001470")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
	public Panel_Layout PulldownGreyout;

	[global::Cpp2ILInjected.Token(Token = "0x4001471")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
	public Panel_Layout PulldownBacking;

	[global::Cpp2ILInjected.Token(Token = "0x4001472")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
	public Vector2 PulldownBackingTLOffset;

	[global::Cpp2ILInjected.Token(Token = "0x4001473")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
	public Vector2 PulldownBackingBROffset;

	[global::Cpp2ILInjected.Token(Token = "0x4001474")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
	public float PulldownButtonExtraPadding;

	[global::Cpp2ILInjected.Token(Token = "0x4001475")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
	public TransactionButton_Layout Option1;

	[global::Cpp2ILInjected.Token(Token = "0x4001476")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
	public TransactionButton_Layout Option2;

	[global::Cpp2ILInjected.Token(Token = "0x4001477")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
	public TransactionButton_Layout Option3;

	[global::Cpp2ILInjected.Token(Token = "0x4001478")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x68")]
	public TransactionButton_Layout Option4;

	[global::Cpp2ILInjected.Token(Token = "0x4001479")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x70")]
	public TransactionButton_Layout Option5;

	[global::Cpp2ILInjected.Token(Token = "0x400147A")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x78")]
	public TransactionButton_Layout Option6;

	[global::Cpp2ILInjected.Token(Token = "0x400147B")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x80")]
	public TransactionButton_Layout Option7;

	[global::Cpp2ILInjected.Token(Token = "0x400147C")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x88")]
	public TransactionButton_Layout Option8;

	[global::Cpp2ILInjected.Token(Token = "0x400147D")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x90")]
	public TransactionButton_Layout Option9;

	[global::Cpp2ILInjected.Token(Token = "0x400147E")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x98")]
	public TransactionButton_Layout Option10;

	[global::Cpp2ILInjected.Token(Token = "0x400147F")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xA0")]
	public TransactionButton_Layout Option11;

	[global::Cpp2ILInjected.Token(Token = "0x4001480")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xA8")]
	public TransactionButton_Layout Option12;

	[global::Cpp2ILInjected.Token(Token = "0x4001481")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xB0")]
	public float ElementSpacing;
}
