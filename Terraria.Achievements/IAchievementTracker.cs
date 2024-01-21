using Cpp2IlInjected;

namespace Terraria.Achievements;

[Cpp2IlInjected.Token(Token = "0x2000498")]
public interface IAchievementTracker
{
	[Cpp2IlInjected.Token(Token = "0x6003377")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void ReportAs(string name);

	[Cpp2IlInjected.Token(Token = "0x6003378")]
	[Cpp2IlInjected.Address(Slot = "1")]
	TrackerType GetTrackerType();

	[Cpp2IlInjected.Token(Token = "0x6003379")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void Load();

	[Cpp2IlInjected.Token(Token = "0x600337A")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void Clear();
}
