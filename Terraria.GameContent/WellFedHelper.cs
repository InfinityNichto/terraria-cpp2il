using Cpp2IlInjected;

namespace Terraria.GameContent;

[Cpp2IlInjected.Token(Token = "0x2000579")]
public struct WellFedHelper
{
	[Cpp2IlInjected.Token(Token = "0x4006AD1")]
	private const int MAXIMUM_TIME_LEFT_PER_COUNTER = 72000;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4006AD2")]
	private int _timeLeftRank1;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4006AD3")]
	private int _timeLeftRank2;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4006AD4")]
	private int _timeLeftRank3;

	[Cpp2IlInjected.Token(Token = "0x17000724")]
	public int TimeLeft
	{
		[Cpp2IlInjected.Token(Token = "0x6003B0A")]
		[Cpp2IlInjected.Address(RVA = "0x399F44", Offset = "0x399F44", VA = "0x399F44")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000725")]
	public int Rank
	{
		[Cpp2IlInjected.Token(Token = "0x6003B0B")]
		[Cpp2IlInjected.Address(RVA = "0x399F5C", Offset = "0x399F5C", VA = "0x399F5C")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6003B0C")]
	[Cpp2IlInjected.Address(RVA = "0x399F98", Offset = "0x399F98", VA = "0x399F98")]
	public void Eat(int foodRank, int foodBuffTime)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003B0D")]
	[Cpp2IlInjected.Address(RVA = "0x399FA0", Offset = "0x399FA0", VA = "0x399FA0")]
	public void Update()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003B0E")]
	[Cpp2IlInjected.Address(RVA = "0x399FE0", Offset = "0x399FE0", VA = "0x399FE0")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003B0F")]
	[Cpp2IlInjected.Address(RVA = "0x399FF4", Offset = "0x399FF4", VA = "0x399FF4")]
	private void AddTimeTo(ref int foodTimeCounter, ref int timeLeftToAdd, int counterMaximumTime)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003B10")]
	[Cpp2IlInjected.Address(RVA = "0x39A030", Offset = "0x39A030", VA = "0x39A030")]
	private void ReduceTimeLeft()
	{
	}
}
