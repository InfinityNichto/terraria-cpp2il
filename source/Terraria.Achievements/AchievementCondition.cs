using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Terraria.Achievements;

[Cpp2IlInjected.Token(Token = "0x2000491")]
[JsonObject]
public abstract class AchievementCondition
{
	[Cpp2IlInjected.Token(Token = "0x2000931")]
	public delegate void AchievementUpdate(AchievementCondition condition);

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4006526")]
	public readonly string Name;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4006528")]
	protected IAchievementTracker _tracker;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4006529")]
	[JsonProperty]
	private bool _isCompleted;

	[Cpp2IlInjected.Token(Token = "0x1700064C")]
	public bool IsCompleted
	{
		[Cpp2IlInjected.Token(Token = "0x6003345")]
		[Cpp2IlInjected.Address(RVA = "0x106ADB0", Offset = "0x106ADB0", VA = "0x106ADB0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400003C")]
	public event AchievementUpdate OnComplete
	{
		[Cpp2IlInjected.Token(Token = "0x6003343")]
		[Cpp2IlInjected.Address(RVA = "0x1069EC0", Offset = "0x1069EC0", VA = "0x1069EC0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6003344")]
		[Cpp2IlInjected.Address(RVA = "0x106AD00", Offset = "0x106AD00", VA = "0x106AD00")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6003346")]
	[Cpp2IlInjected.Address(RVA = "0x106ADB8", Offset = "0x106ADB8", VA = "0x106ADB8")]
	protected AchievementCondition(string name)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003347")]
	[Cpp2IlInjected.Address(RVA = "0x106ADD8", Offset = "0x106ADD8", VA = "0x106ADD8", Slot = "4")]
	public virtual void Load(JObject state)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003348")]
	[Cpp2IlInjected.Address(RVA = "0x106AE7C", Offset = "0x106AE7C", VA = "0x106AE7C", Slot = "5")]
	public virtual void Shutdown()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003349")]
	[Cpp2IlInjected.Address(RVA = "0x106AE80", Offset = "0x106AE80", VA = "0x106AE80", Slot = "6")]
	public virtual void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600334A")]
	[Cpp2IlInjected.Address(RVA = "0x106AE8C", Offset = "0x106AE8C", VA = "0x106AE8C", Slot = "7")]
	public virtual void Complete()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600334B")]
	[Cpp2IlInjected.Address(RVA = "0x106B2DC", Offset = "0x106B2DC", VA = "0x106B2DC", Slot = "8")]
	protected virtual IAchievementTracker CreateAchievementTracker()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600334C")]
	[Cpp2IlInjected.Address(RVA = "0x106ABB8", Offset = "0x106ABB8", VA = "0x106ABB8")]
	public IAchievementTracker GetAchievementTracker()
	{
		return null;
	}
}
