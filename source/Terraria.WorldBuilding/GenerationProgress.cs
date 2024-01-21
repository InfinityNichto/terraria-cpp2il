using Cpp2IlInjected;

namespace Terraria.WorldBuilding;

[Cpp2IlInjected.Token(Token = "0x2000368")]
public class GenerationProgress
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4003166")]
	private string _message;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4003167")]
	private double _value;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4003168")]
	private double _totalProgress;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4003169")]
	public double TotalWeight;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400316A")]
	public double CurrentPassWeight;

	[Cpp2IlInjected.Token(Token = "0x1700059A")]
	public string Message
	{
		[Cpp2IlInjected.Token(Token = "0x6002C80")]
		[Cpp2IlInjected.Address(RVA = "0x13010B4", Offset = "0x13010B4", VA = "0x13010B4")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6002C81")]
		[Cpp2IlInjected.Address(RVA = "0x1301134", Offset = "0x1301134", VA = "0x1301134")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700059B")]
	public double Value
	{
		[Cpp2IlInjected.Token(Token = "0x6002C83")]
		[Cpp2IlInjected.Address(RVA = "0x130126C", Offset = "0x130126C", VA = "0x130126C")]
		get
		{
			return default(double);
		}
		[Cpp2IlInjected.Token(Token = "0x6002C82")]
		[Cpp2IlInjected.Address(RVA = "0x13011AC", Offset = "0x13011AC", VA = "0x13011AC")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700059C")]
	public double TotalProgress
	{
		[Cpp2IlInjected.Token(Token = "0x6002C84")]
		[Cpp2IlInjected.Address(RVA = "0x1301278", Offset = "0x1301278", VA = "0x1301278")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6002C85")]
	[Cpp2IlInjected.Address(RVA = "0x13012A8", Offset = "0x13012A8", VA = "0x13012A8")]
	public void Set(double value)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002C86")]
	[Cpp2IlInjected.Address(RVA = "0x13012C0", Offset = "0x13012C0", VA = "0x13012C0")]
	public void Start(double weight)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002C87")]
	[Cpp2IlInjected.Address(RVA = "0x13012DC", Offset = "0x13012DC", VA = "0x13012DC")]
	public void End()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002C88")]
	[Cpp2IlInjected.Address(RVA = "0x13012FC", Offset = "0x13012FC", VA = "0x13012FC")]
	public GenerationProgress()
	{
	}
}
