using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

[Cpp2IlInjected.Token(Token = "0x200011D")]
public class Buffs_Layout : LayoutDefinition
{
	[Cpp2IlInjected.Token(Token = "0x400096C")]
	public static Buffs_Layout InstanceNormal;

	[Cpp2IlInjected.Token(Token = "0x400096D")]
	public static Buffs_Layout Instance4Page;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400096E")]
	public ItemGrid_Layout BuffsGrid;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400096F")]
	public ItemGrid_Layout HorizontalBuffsGrid;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000970")]
	public float ItemScale;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000971")]
	public float SelectedScale;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000972")]
	public float BaseTextScale;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000973")]
	public Vector2 TextOffset;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000974")]
	public Color SelectedColour;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000975")]
	public Color NormalColour;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000976")]
	public Color SelectedTextColour;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000977")]
	public Color NormalTextColour;

	[Cpp2IlInjected.Token(Token = "0x170000FA")]
	public static Buffs_Layout Instance
	{
		[Cpp2IlInjected.Token(Token = "0x6000A59")]
		[Cpp2IlInjected.Address(RVA = "0x12019C8", Offset = "0x12019C8", VA = "0x12019C8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000A5A")]
	[Cpp2IlInjected.Address(RVA = "0x1201A48", Offset = "0x1201A48", VA = "0x1201A48")]
	private void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A5B")]
	[Cpp2IlInjected.Address(RVA = "0x1201AC8", Offset = "0x1201AC8", VA = "0x1201AC8")]
	public Buffs_Layout()
	{
	}
}
