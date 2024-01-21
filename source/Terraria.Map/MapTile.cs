using Cpp2IlInjected;

namespace Terraria.Map;

[Cpp2IlInjected.Token(Token = "0x20004AC")]
public struct MapTile
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40065A1")]
	public ushort Type;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x40065A2")]
	public byte Light;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x40065A3")]
	public byte _extraData;

	[Cpp2IlInjected.Token(Token = "0x17000654")]
	public bool IsChanged
	{
		[Cpp2IlInjected.Token(Token = "0x60033FB")]
		[Cpp2IlInjected.Address(RVA = "0x39A5A8", Offset = "0x39A5A8", VA = "0x39A5A8")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60033FC")]
		[Cpp2IlInjected.Address(RVA = "0x39A5BC", Offset = "0x39A5BC", VA = "0x39A5BC")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000655")]
	public byte Color
	{
		[Cpp2IlInjected.Token(Token = "0x60033FD")]
		[Cpp2IlInjected.Address(RVA = "0x39A5D4", Offset = "0x39A5D4", VA = "0x39A5D4")]
		get
		{
			return default(byte);
		}
		[Cpp2IlInjected.Token(Token = "0x60033FE")]
		[Cpp2IlInjected.Address(RVA = "0x39A5E0", Offset = "0x39A5E0", VA = "0x39A5E0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60033FF")]
	[Cpp2IlInjected.Address(RVA = "0x39A5F8", Offset = "0x39A5F8", VA = "0x39A5F8")]
	private MapTile(ushort type, byte light, byte extraData)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003400")]
	[Cpp2IlInjected.Address(RVA = "0x39A608", Offset = "0x39A608", VA = "0x39A608")]
	public bool Equals(ref MapTile other)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6003401")]
	[Cpp2IlInjected.Address(RVA = "0x39A64C", Offset = "0x39A64C", VA = "0x39A64C")]
	public bool EqualsWithoutLight(ref MapTile other)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6003402")]
	[Cpp2IlInjected.Address(RVA = "0x39A680", Offset = "0x39A680", VA = "0x39A680")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003403")]
	[Cpp2IlInjected.Address(RVA = "0x39A68C", Offset = "0x39A68C", VA = "0x39A68C")]
	public MapTile WithLight(byte light)
	{
		return default(MapTile);
	}

	[Cpp2IlInjected.Token(Token = "0x6003404")]
	[Cpp2IlInjected.Address(RVA = "0xE9C104", Offset = "0xE9C104", VA = "0xE9C104")]
	public static MapTile Create(ushort type, byte light, byte color)
	{
		return default(MapTile);
	}
}
