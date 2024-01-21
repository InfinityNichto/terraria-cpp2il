using System;
using Cpp2IlInjected;

namespace Microsoft.Xna.Framework;

[Cpp2IlInjected.Token(Token = "0x2000277")]
public class GameTime
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4001CDC")]
	private TimeSpan elapsedGameTime;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4001CDD")]
	private TimeSpan elapsedRealTime;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4001CDE")]
	private bool isRunningSlowly;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4001CDF")]
	private TimeSpan totalGameTime;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4001CE0")]
	private TimeSpan totalRealTime;

	[Cpp2IlInjected.Token(Token = "0x170001DE")]
	public TimeSpan ElapsedGameTime
	{
		[Cpp2IlInjected.Token(Token = "0x6001374")]
		[Cpp2IlInjected.Address(RVA = "0x13940E0", Offset = "0x13940E0", VA = "0x13940E0")]
		get
		{
			return default(TimeSpan);
		}
		[Cpp2IlInjected.Token(Token = "0x6001375")]
		[Cpp2IlInjected.Address(RVA = "0x13940EC", Offset = "0x13940EC", VA = "0x13940EC")]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001DF")]
	public TimeSpan ElapsedRealTime
	{
		[Cpp2IlInjected.Token(Token = "0x6001376")]
		[Cpp2IlInjected.Address(RVA = "0x13940FC", Offset = "0x13940FC", VA = "0x13940FC")]
		get
		{
			return default(TimeSpan);
		}
		[Cpp2IlInjected.Token(Token = "0x6001377")]
		[Cpp2IlInjected.Address(RVA = "0x1394108", Offset = "0x1394108", VA = "0x1394108")]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001E0")]
	public bool IsRunningSlowly
	{
		[Cpp2IlInjected.Token(Token = "0x6001378")]
		[Cpp2IlInjected.Address(RVA = "0x1394118", Offset = "0x1394118", VA = "0x1394118")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6001379")]
		[Cpp2IlInjected.Address(RVA = "0x1394120", Offset = "0x1394120", VA = "0x1394120")]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001E1")]
	public TimeSpan TotalGameTime
	{
		[Cpp2IlInjected.Token(Token = "0x600137A")]
		[Cpp2IlInjected.Address(RVA = "0x1394128", Offset = "0x1394128", VA = "0x1394128")]
		get
		{
			return default(TimeSpan);
		}
		[Cpp2IlInjected.Token(Token = "0x600137B")]
		[Cpp2IlInjected.Address(RVA = "0x1394134", Offset = "0x1394134", VA = "0x1394134")]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001E2")]
	public TimeSpan TotalRealTime
	{
		[Cpp2IlInjected.Token(Token = "0x600137C")]
		[Cpp2IlInjected.Address(RVA = "0x1394144", Offset = "0x1394144", VA = "0x1394144")]
		get
		{
			return default(TimeSpan);
		}
		[Cpp2IlInjected.Token(Token = "0x600137D")]
		[Cpp2IlInjected.Address(RVA = "0x1394150", Offset = "0x1394150", VA = "0x1394150")]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6001371")]
	[Cpp2IlInjected.Address(RVA = "0x13932DC", Offset = "0x13932DC", VA = "0x13932DC")]
	public GameTime()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001372")]
	[Cpp2IlInjected.Address(RVA = "0x13917BC", Offset = "0x13917BC", VA = "0x13917BC")]
	public GameTime(TimeSpan totalRealTime, TimeSpan elapsedRealTime, TimeSpan totalGameTime, TimeSpan elapsedGameTime)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001373")]
	[Cpp2IlInjected.Address(RVA = "0x1394080", Offset = "0x1394080", VA = "0x1394080")]
	public GameTime(TimeSpan totalRealTime, TimeSpan elapsedRealTime, TimeSpan totalGameTime, TimeSpan elapsedGameTime, bool isRunningSlowly)
	{
	}
}
