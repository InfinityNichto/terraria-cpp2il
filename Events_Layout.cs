using Cpp2IlInjected;
using Microsoft.Xna.Framework.Graphics;

[Cpp2IlInjected.Token(Token = "0x2000150")]
public class Events_Layout : LayoutDefinition
{
	[Cpp2IlInjected.Token(Token = "0x4000CB8")]
	public static Events_Layout _instance;

	[Cpp2IlInjected.Token(Token = "0x4000CB9")]
	public static Events_Layout _instanceMobile;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000CBA")]
	public Panel_Layout Backing;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000CBB")]
	public String_Layout InvasionTitle;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000CBC")]
	public TransactionButton_Layout InvasionIcon;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000CBD")]
	public Panel_Layout BarBacking;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000CBE")]
	public Panel_Layout BarFill;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000CBF")]
	public Panel_Layout InfiniteBarBacking;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000CC0")]
	public Panel_Layout InfiniteBarFill;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000CC1")]
	public String_Layout Waves;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000CC2")]
	public Color MaxWaveColour;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000CC3")]
	public String_Layout Progress;

	[Cpp2IlInjected.Token(Token = "0x1700012B")]
	public static Events_Layout Instance
	{
		[Cpp2IlInjected.Token(Token = "0x6000B09")]
		[Cpp2IlInjected.Address(RVA = "0x20D2444", Offset = "0x20D2444", VA = "0x20D2444")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000B0A")]
	[Cpp2IlInjected.Address(RVA = "0x20D24C8", Offset = "0x20D24C8", VA = "0x20D24C8")]
	private void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B0B")]
	[Cpp2IlInjected.Address(RVA = "0x20D2548", Offset = "0x20D2548", VA = "0x20D2548")]
	public Events_Layout()
	{
	}
}
