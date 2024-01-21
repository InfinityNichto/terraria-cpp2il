using Cpp2IlInjected;

namespace Terraria.DataStructures;

[Cpp2IlInjected.Token(Token = "0x2000434")]
public struct NPCStrengthHelper
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40062FA")]
	private float _strengthOverride;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40062FB")]
	private float _gameModeDifficulty;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40062FC")]
	private GameModeData _gameModeData;

	[Cpp2IlInjected.Token(Token = "0x17000618")]
	public bool IsExpertMode
	{
		[Cpp2IlInjected.Token(Token = "0x600313C")]
		[Cpp2IlInjected.Address(RVA = "0x39B228", Offset = "0x39B228", VA = "0x39B228")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000619")]
	public bool IsMasterMode
	{
		[Cpp2IlInjected.Token(Token = "0x600313D")]
		[Cpp2IlInjected.Address(RVA = "0x39B25C", Offset = "0x39B25C", VA = "0x39B25C")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700061A")]
	public bool ExtraDamageForGetGoodWorld
	{
		[Cpp2IlInjected.Token(Token = "0x600313E")]
		[Cpp2IlInjected.Address(RVA = "0x39B290", Offset = "0x39B290", VA = "0x39B290")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600313F")]
	[Cpp2IlInjected.Address(RVA = "0x39B2C4", Offset = "0x39B2C4", VA = "0x39B2C4")]
	public NPCStrengthHelper(GameModeData data, float strength, bool isGetGoodWorld)
	{
	}
}
