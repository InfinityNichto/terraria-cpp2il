using Cpp2IlInjected;
using Microsoft.Xna.Framework;

[Cpp2IlInjected.Token(Token = "0x20001AA")]
public class RightSideHUDAnchor_Layouts : LayoutDefinition
{
	[Cpp2IlInjected.Token(Token = "0x4001299")]
	public static RightSideHUDAnchor_Layouts Instance;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400129A")]
	public Anchor_Layout StartAnchor;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400129B")]
	public Anchor_Layout StartAnchor2;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400129C")]
	public Anchor_Layout StartAnchorHorizontalBars;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400129D")]
	public Anchor_Layout StartAnchorHorizontalBars2;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400129E")]
	public Vector2 NonMapSpacing;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400129F")]
	public float MapSpacing;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40012A0")]
	public float MapSpacingLarge;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x40012A1")]
	public float EvemtSpacing;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40012A2")]
	public float BossBarSpacing;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x40012A3")]
	public float StatusIndicatorSpacing;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40012A4")]
	public bool AllowMapMovement;

	[Cpp2IlInjected.Token(Token = "0x6000C05")]
	[Cpp2IlInjected.Address(RVA = "0xF9BB70", Offset = "0xF9BB70", VA = "0xF9BB70")]
	private void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C06")]
	[Cpp2IlInjected.Address(RVA = "0xF9BBCC", Offset = "0xF9BBCC", VA = "0xF9BBCC")]
	public RightSideHUDAnchor_Layouts()
	{
	}
}
