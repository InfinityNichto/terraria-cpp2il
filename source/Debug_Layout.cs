using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

[Cpp2IlInjected.Token(Token = "0x200014C")]
public class Debug_Layout : LayoutDefinition
{
	[Cpp2IlInjected.Token(Token = "0x4000C47")]
	public static Debug_Layout Instance;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000C48")]
	public LayoutCalculator.AnchorType DebugAnchor;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000C49")]
	public Vector2 DebugIconLocation;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000C4A")]
	public float DebugIconScale;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000C4B")]
	public Vector2 DebugIconPickBorder;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000C4C")]
	public Color DebugIconColor;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000C4D")]
	public Panel_Layout Backing;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000C4E")]
	public TransactionButton_Layout Text;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000C4F")]
	public TransactionButton_Layout Send;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000C50")]
	public TransactionButton_Layout Close;

	[Cpp2IlInjected.Token(Token = "0x6000AFD")]
	[Cpp2IlInjected.Address(RVA = "0x20C922C", Offset = "0x20C922C", VA = "0x20C922C")]
	private void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AFE")]
	[Cpp2IlInjected.Address(RVA = "0x20C9288", Offset = "0x20C9288", VA = "0x20C9288")]
	public Debug_Layout()
	{
	}
}
