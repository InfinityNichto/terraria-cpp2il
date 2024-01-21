using Cpp2IlInjected;
using Microsoft.Xna.Framework.Graphics;

[Cpp2IlInjected.Token(Token = "0x2000196")]
public class WorldGenerateMenu_Layout : LayoutDefinition
{
	[Cpp2IlInjected.Token(Token = "0x40010C0")]
	public static WorldGenerateMenu_Layout Instance;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40010C1")]
	public String_Layout Status;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40010C2")]
	public ProgressBar_Layout Progress;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x40010C3")]
	public ProgressBar_Layout StageProgress;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40010C4")]
	public Texture_Layout BackingCorrupt;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40010C5")]
	public Texture_Layout BackingCrimson;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40010C6")]
	public Color FillingColorCorrupt;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x40010C7")]
	public Color FillingColorCrimson;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40010C8")]
	public String_Layout GameTip;

	[Cpp2IlInjected.Token(Token = "0x6000BD2")]
	[Cpp2IlInjected.Address(RVA = "0x14FB040", Offset = "0x14FB040", VA = "0x14FB040")]
	private void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000BD3")]
	[Cpp2IlInjected.Address(RVA = "0x14FB09C", Offset = "0x14FB09C", VA = "0x14FB09C")]
	public WorldGenerateMenu_Layout()
	{
	}
}
