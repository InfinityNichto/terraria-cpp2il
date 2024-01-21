using System.Collections.Generic;
using System.Globalization;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;

namespace Terraria.Localization;

[Cpp2IlInjected.Token(Token = "0x20003B5")]
public class GameCulture
{
	[Cpp2IlInjected.Token(Token = "0x20008E6")]
	public enum CultureName
	{
		[Cpp2IlInjected.Token(Token = "0x4008130")]
		English = 1,
		[Cpp2IlInjected.Token(Token = "0x4008131")]
		German = 2,
		[Cpp2IlInjected.Token(Token = "0x4008132")]
		Italian = 3,
		[Cpp2IlInjected.Token(Token = "0x4008133")]
		French = 4,
		[Cpp2IlInjected.Token(Token = "0x4008134")]
		Spanish = 5,
		[Cpp2IlInjected.Token(Token = "0x4008135")]
		Russian = 6,
		[Cpp2IlInjected.Token(Token = "0x4008136")]
		Chinese = 7,
		[Cpp2IlInjected.Token(Token = "0x4008137")]
		Portuguese = 8,
		[Cpp2IlInjected.Token(Token = "0x4008138")]
		Polish = 9,
		[Cpp2IlInjected.Token(Token = "0x4008139")]
		Japanese = 10,
		[Cpp2IlInjected.Token(Token = "0x400813A")]
		Korean = 11,
		[Cpp2IlInjected.Token(Token = "0x400813B")]
		ChineseTraditional = 12,
		[Cpp2IlInjected.Token(Token = "0x400813C")]
		Unknown = 9999
	}

	[Cpp2IlInjected.Token(Token = "0x4003267")]
	private static Dictionary<CultureName, GameCulture> _NamedCultures;

	[Cpp2IlInjected.Token(Token = "0x4003269")]
	private static Dictionary<int, GameCulture> _legacyCultures;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400326A")]
	public readonly CultureInfo CultureInfo;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400326B")]
	public readonly int LegacyId;

	[Cpp2IlInjected.Token(Token = "0x170005ED")]
	public static GameCulture DefaultCulture
	{
		[Cpp2IlInjected.Token(Token = "0x6002ECD")]
		[Cpp2IlInjected.Address(RVA = "0x474804", Offset = "0x474804", VA = "0x474804")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6002ECE")]
		[Cpp2IlInjected.Address(RVA = "0x47487C", Offset = "0x47487C", VA = "0x47487C")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170005EE")]
	public bool IsActive
	{
		[Cpp2IlInjected.Token(Token = "0x6002ECF")]
		[Cpp2IlInjected.Address(RVA = "0x4748F8", Offset = "0x4748F8", VA = "0x4748F8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170005EF")]
	public string Name
	{
		[Cpp2IlInjected.Token(Token = "0x6002ED0")]
		[Cpp2IlInjected.Address(RVA = "0x474994", Offset = "0x474994", VA = "0x474994")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6002ED1")]
	[Cpp2IlInjected.Address(RVA = "0x4749A8", Offset = "0x4749A8", VA = "0x4749A8")]
	public static GameCulture FromCultureName(CultureName name)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6002ED2")]
	[Cpp2IlInjected.Address(RVA = "0x474B0C", Offset = "0x474B0C", VA = "0x474B0C")]
	public static GameCulture FromLegacyId(int id)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6002ED3")]
	[Cpp2IlInjected.Address(RVA = "0x474C78", Offset = "0x474C78", VA = "0x474C78")]
	public static GameCulture FromName(string name)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6002ED4")]
	[Cpp2IlInjected.Address(RVA = "0x474E24", Offset = "0x474E24", VA = "0x474E24")]
	static GameCulture()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002ED5")]
	[Cpp2IlInjected.Address(RVA = "0x475210", Offset = "0x475210", VA = "0x475210")]
	public GameCulture(string name, int legacyId)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002ED6")]
	[Cpp2IlInjected.Address(RVA = "0x4752CC", Offset = "0x4752CC", VA = "0x4752CC")]
	private static void RegisterLegacyCulture(GameCulture culture, int legacyId)
	{
	}
}
