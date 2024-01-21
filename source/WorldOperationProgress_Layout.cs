using Cpp2IlInjected;
using UnityEngine;

[Cpp2IlInjected.Token(Token = "0x20001C0")]
public class WorldOperationProgress_Layout : LayoutDefinition
{
	[Cpp2IlInjected.Token(Token = "0x40013BC")]
	public static WorldOperationProgress_Layout Instance;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40013BD")]
	public bool Enabled;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD")]
	[Cpp2IlInjected.Token(Token = "0x40013BE")]
	public bool FullHMStatus;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40013BF")]
	public Panel_Layout Backing;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x40013C0")]
	public Button_Layout ProgressIcon;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40013C1")]
	public AnimationCurve HMIconScale;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40013C2")]
	public AnimationCurve HMIconAlpha;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40013C3")]
	public TransactionButton_Layout HMConversionIcon;

	[Cpp2IlInjected.Token(Token = "0x6000C4E")]
	[Cpp2IlInjected.Address(RVA = "0x14FB29C", Offset = "0x14FB29C", VA = "0x14FB29C")]
	private void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C4F")]
	[Cpp2IlInjected.Address(RVA = "0x14FB2F8", Offset = "0x14FB2F8", VA = "0x14FB2F8")]
	public WorldOperationProgress_Layout()
	{
	}
}
