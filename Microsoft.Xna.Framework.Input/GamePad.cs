using Cpp2IlInjected;

namespace Microsoft.Xna.Framework.Input;

[Cpp2IlInjected.Token(Token = "0x2000283")]
public static class GamePad
{
	[Cpp2IlInjected.Token(Token = "0x170001F8")]
	public static int MaximumGamePadCount
	{
		[Cpp2IlInjected.Token(Token = "0x60013DB")]
		[Cpp2IlInjected.Address(RVA = "0x154FCEC", Offset = "0x154FCEC", VA = "0x154FCEC")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60013D1")]
	[Cpp2IlInjected.Address(RVA = "0x154FAAC", Offset = "0x154FAAC", VA = "0x154FAAC")]
	public static GamePadCapabilities GetCapabilities(PlayerIndex playerIndex)
	{
		return default(GamePadCapabilities);
	}

	[Cpp2IlInjected.Token(Token = "0x60013D2")]
	[Cpp2IlInjected.Address(RVA = "0x154FAD0", Offset = "0x154FAD0", VA = "0x154FAD0")]
	public static GamePadCapabilities GetCapabilities(int index)
	{
		return default(GamePadCapabilities);
	}

	[Cpp2IlInjected.Token(Token = "0x60013D3")]
	[Cpp2IlInjected.Address(RVA = "0x154FAF4", Offset = "0x154FAF4", VA = "0x154FAF4")]
	public static GamePadState GetState(PlayerIndex playerIndex)
	{
		return default(GamePadState);
	}

	[Cpp2IlInjected.Token(Token = "0x60013D4")]
	[Cpp2IlInjected.Address(RVA = "0x154FB98", Offset = "0x154FB98", VA = "0x154FB98")]
	public static GamePadState GetState(int index)
	{
		return default(GamePadState);
	}

	[Cpp2IlInjected.Token(Token = "0x60013D5")]
	[Cpp2IlInjected.Address(RVA = "0x154FBAC", Offset = "0x154FBAC", VA = "0x154FBAC")]
	public static GamePadState GetState(PlayerIndex playerIndex, GamePadDeadZone deadZoneMode)
	{
		return default(GamePadState);
	}

	[Cpp2IlInjected.Token(Token = "0x60013D6")]
	[Cpp2IlInjected.Address(RVA = "0x154FB08", Offset = "0x154FB08", VA = "0x154FB08")]
	public static GamePadState GetState(int index, GamePadDeadZone deadZoneMode)
	{
		return default(GamePadState);
	}

	[Cpp2IlInjected.Token(Token = "0x60013D7")]
	[Cpp2IlInjected.Address(RVA = "0x154FBBC", Offset = "0x154FBBC", VA = "0x154FBBC")]
	public static GamePadState GetState(PlayerIndex playerIndex, GamePadDeadZone leftDeadZoneMode, GamePadDeadZone rightDeadZoneMode)
	{
		return default(GamePadState);
	}

	[Cpp2IlInjected.Token(Token = "0x60013D8")]
	[Cpp2IlInjected.Address(RVA = "0x154FC4C", Offset = "0x154FC4C", VA = "0x154FC4C")]
	public static GamePadState GetState(int index, GamePadDeadZone leftDeadZoneMode, GamePadDeadZone rightDeadZoneMode)
	{
		return default(GamePadState);
	}

	[Cpp2IlInjected.Token(Token = "0x60013D9")]
	[Cpp2IlInjected.Address(RVA = "0x154FCDC", Offset = "0x154FCDC", VA = "0x154FCDC")]
	public static bool SetVibration(PlayerIndex playerIndex, float leftMotor, float rightMotor)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60013DA")]
	[Cpp2IlInjected.Address(RVA = "0x154FCE4", Offset = "0x154FCE4", VA = "0x154FCE4")]
	public static bool SetVibration(int index, float leftMotor, float rightMotor)
	{
		return default(bool);
	}
}
