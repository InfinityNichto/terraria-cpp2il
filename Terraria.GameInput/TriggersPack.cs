using Cpp2IlInjected;

namespace Terraria.GameInput;

[Cpp2IlInjected.Token(Token = "0x20004BB")]
public class TriggersPack
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4006650")]
	public TriggersSet Current;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4006651")]
	public TriggersSet Old;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4006652")]
	public TriggersSet JustPressed;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4006653")]
	public TriggersSet JustReleased;

	[Cpp2IlInjected.Token(Token = "0x60034CD")]
	[Cpp2IlInjected.Address(RVA = "0x130790C", Offset = "0x130790C", VA = "0x130790C")]
	public void Initialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60034CE")]
	[Cpp2IlInjected.Address(RVA = "0x1307A30", Offset = "0x1307A30", VA = "0x1307A30")]
	public void Reset()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60034CF")]
	[Cpp2IlInjected.Address(RVA = "0x1307B20", Offset = "0x1307B20", VA = "0x1307B20")]
	public void Update()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60034D0")]
	[Cpp2IlInjected.Address(RVA = "0x1307B58", Offset = "0x1307B58", VA = "0x1307B58")]
	public void CompareDiffs(TriggersSet Bearer, TriggersSet oldset, TriggersSet newset)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60034D1")]
	[Cpp2IlInjected.Address(RVA = "0x1307BE8", Offset = "0x1307BE8", VA = "0x1307BE8")]
	public TriggersPack()
	{
	}
}
