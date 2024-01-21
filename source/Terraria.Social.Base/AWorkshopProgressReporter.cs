using Cpp2IlInjected;

namespace Terraria.Social.Base;

[Cpp2IlInjected.Token(Token = "0x200039B")]
public abstract class AWorkshopProgressReporter
{
	[Cpp2IlInjected.Token(Token = "0x170005B1")]
	public abstract bool HasOngoingTasks
	{
		[Cpp2IlInjected.Token(Token = "0x6002DF9")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6002DFA")]
	[Cpp2IlInjected.Address(Slot = "5")]
	public abstract bool TryGetProgress(out float progress);

	[Cpp2IlInjected.Token(Token = "0x6002DFB")]
	[Cpp2IlInjected.Address(RVA = "0x14DF76C", Offset = "0x14DF76C", VA = "0x14DF76C")]
	protected AWorkshopProgressReporter()
	{
	}
}
