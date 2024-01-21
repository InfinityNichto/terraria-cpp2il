using Cpp2IlInjected;

namespace Terraria.Social.Base;

[Cpp2IlInjected.Token(Token = "0x2000390")]
public abstract class AchievementsSocialModule : ISocialModule
{
	[Cpp2IlInjected.Token(Token = "0x6002D96")]
	[Cpp2IlInjected.Address(Slot = "6")]
	public abstract void Initialize();

	[Cpp2IlInjected.Token(Token = "0x6002D97")]
	[Cpp2IlInjected.Address(Slot = "7")]
	public abstract void Shutdown();

	[Cpp2IlInjected.Token(Token = "0x6002D98")]
	[Cpp2IlInjected.Address(Slot = "8")]
	public abstract byte[] GetEncryptionKey();

	[Cpp2IlInjected.Token(Token = "0x6002D99")]
	[Cpp2IlInjected.Address(Slot = "9")]
	public abstract string GetSavePath();

	[Cpp2IlInjected.Token(Token = "0x6002D9A")]
	[Cpp2IlInjected.Address(Slot = "10")]
	public abstract void UpdateIntStat(string name, int value);

	[Cpp2IlInjected.Token(Token = "0x6002D9B")]
	[Cpp2IlInjected.Address(Slot = "11")]
	public abstract void UpdateFloatStat(string name, float value);

	[Cpp2IlInjected.Token(Token = "0x6002D9C")]
	[Cpp2IlInjected.Address(Slot = "12")]
	public abstract void CompleteAchievement(string name);

	[Cpp2IlInjected.Token(Token = "0x6002D9D")]
	[Cpp2IlInjected.Address(Slot = "13")]
	public abstract bool IsAchievementCompleted(string name);

	[Cpp2IlInjected.Token(Token = "0x6002D9E")]
	[Cpp2IlInjected.Address(Slot = "14")]
	public abstract void StoreStats();

	[Cpp2IlInjected.Token(Token = "0x6002D9F")]
	[Cpp2IlInjected.Address(RVA = "0x14DF95C", Offset = "0x14DF95C", VA = "0x14DF95C")]
	protected AchievementsSocialModule()
	{
	}
}
