using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using Newtonsoft.Json;
using Terraria.GameContent.Biomes.CaveHouse;
using Terraria.WorldBuilding;

namespace Terraria.GameContent.Biomes;

[Cpp2IlInjected.Token(Token = "0x20005F3")]
public class CaveHouseBiome : MicroBiome
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4006BEE")]
	private readonly HouseBuilderContext _builderContext;

	[Cpp2IlInjected.Token(Token = "0x1700073D")]
	[JsonProperty]
	public double IceChestChance
	{
		[Cpp2IlInjected.Token(Token = "0x6003D90")]
		[Cpp2IlInjected.Address(RVA = "0x1452B3C", Offset = "0x1452B3C", VA = "0x1452B3C")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
		[Cpp2IlInjected.Token(Token = "0x6003D91")]
		[Cpp2IlInjected.Address(RVA = "0x1452B48", Offset = "0x1452B48", VA = "0x1452B48")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700073E")]
	[JsonProperty]
	public double JungleChestChance
	{
		[Cpp2IlInjected.Token(Token = "0x6003D92")]
		[Cpp2IlInjected.Address(RVA = "0x1452B58", Offset = "0x1452B58", VA = "0x1452B58")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
		[Cpp2IlInjected.Token(Token = "0x6003D93")]
		[Cpp2IlInjected.Address(RVA = "0x1452B64", Offset = "0x1452B64", VA = "0x1452B64")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700073F")]
	[JsonProperty]
	public double GoldChestChance
	{
		[Cpp2IlInjected.Token(Token = "0x6003D94")]
		[Cpp2IlInjected.Address(RVA = "0x1452B74", Offset = "0x1452B74", VA = "0x1452B74")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
		[Cpp2IlInjected.Token(Token = "0x6003D95")]
		[Cpp2IlInjected.Address(RVA = "0x1452B80", Offset = "0x1452B80", VA = "0x1452B80")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000740")]
	[JsonProperty]
	public double GraniteChestChance
	{
		[Cpp2IlInjected.Token(Token = "0x6003D96")]
		[Cpp2IlInjected.Address(RVA = "0x1452B90", Offset = "0x1452B90", VA = "0x1452B90")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
		[Cpp2IlInjected.Token(Token = "0x6003D97")]
		[Cpp2IlInjected.Address(RVA = "0x1452B9C", Offset = "0x1452B9C", VA = "0x1452B9C")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000741")]
	[JsonProperty]
	public double MarbleChestChance
	{
		[Cpp2IlInjected.Token(Token = "0x6003D98")]
		[Cpp2IlInjected.Address(RVA = "0x1452BAC", Offset = "0x1452BAC", VA = "0x1452BAC")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
		[Cpp2IlInjected.Token(Token = "0x6003D99")]
		[Cpp2IlInjected.Address(RVA = "0x1452BB8", Offset = "0x1452BB8", VA = "0x1452BB8")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000742")]
	[JsonProperty]
	public double MushroomChestChance
	{
		[Cpp2IlInjected.Token(Token = "0x6003D9A")]
		[Cpp2IlInjected.Address(RVA = "0x1452BC8", Offset = "0x1452BC8", VA = "0x1452BC8")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
		[Cpp2IlInjected.Token(Token = "0x6003D9B")]
		[Cpp2IlInjected.Address(RVA = "0x1452BD4", Offset = "0x1452BD4", VA = "0x1452BD4")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000743")]
	[JsonProperty]
	public double DesertChestChance
	{
		[Cpp2IlInjected.Token(Token = "0x6003D9C")]
		[Cpp2IlInjected.Address(RVA = "0x1452BE4", Offset = "0x1452BE4", VA = "0x1452BE4")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
		[Cpp2IlInjected.Token(Token = "0x6003D9D")]
		[Cpp2IlInjected.Address(RVA = "0x1452BF0", Offset = "0x1452BF0", VA = "0x1452BF0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6003D9E")]
	[Cpp2IlInjected.Address(RVA = "0x1452C00", Offset = "0x1452C00", VA = "0x1452C00", Slot = "4")]
	public override bool Place(Point origin, StructureMap structures)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6003D9F")]
	[Cpp2IlInjected.Address(RVA = "0x1452EA0", Offset = "0x1452EA0", VA = "0x1452EA0")]
	private void ApplyConfigurationToBuilder(HouseBuilder builder)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003DA0")]
	[Cpp2IlInjected.Address(RVA = "0x1452F14", Offset = "0x1452F14", VA = "0x1452F14")]
	public CaveHouseBiome()
	{
	}
}
