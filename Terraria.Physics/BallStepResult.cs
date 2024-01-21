using Cpp2IlInjected;

namespace Terraria.Physics;

[Cpp2IlInjected.Token(Token = "0x20003A6")]
public struct BallStepResult
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4003203")]
	public readonly BallState State;

	[Cpp2IlInjected.Token(Token = "0x6002E3E")]
	[Cpp2IlInjected.Address(RVA = "0x2AF620", Offset = "0x2AF620", VA = "0x2AF620")]
	private BallStepResult(BallState state)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002E3F")]
	[Cpp2IlInjected.Address(RVA = "0xB7A624", Offset = "0xB7A624", VA = "0xB7A624")]
	public static BallStepResult OutOfBounds()
	{
		return default(BallStepResult);
	}

	[Cpp2IlInjected.Token(Token = "0x6002E40")]
	[Cpp2IlInjected.Address(RVA = "0xB7AABC", Offset = "0xB7AABC", VA = "0xB7AABC")]
	public static BallStepResult Moving()
	{
		return default(BallStepResult);
	}

	[Cpp2IlInjected.Token(Token = "0x6002E41")]
	[Cpp2IlInjected.Address(RVA = "0xB7AAC4", Offset = "0xB7AAC4", VA = "0xB7AAC4")]
	public static BallStepResult Resting()
	{
		return default(BallStepResult);
	}
}
