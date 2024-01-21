using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Terraria.Localization;

namespace Terraria.Achievements;

[Cpp2IlInjected.Token(Token = "0x200048F")]
[JsonObject]
public class Achievement
{
	[Cpp2IlInjected.Token(Token = "0x2000930")]
	public delegate void AchievementCompleted(Achievement achievement);

	[Cpp2IlInjected.Token(Token = "0x4006516")]
	private static int _totalAchievements;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4006517")]
	public readonly string Name;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4006518")]
	public readonly LocalizedText FriendlyName;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4006519")]
	public readonly LocalizedText Description;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400651A")]
	public readonly int Id;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400651B")]
	private AchievementCategory _category;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400651C")]
	private IAchievementTracker _tracker;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400651E")]
	[JsonProperty]
	private Dictionary<string, AchievementCondition> _conditions;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400651F")]
	private int _completedCount;

	[Cpp2IlInjected.Token(Token = "0x17000649")]
	public AchievementCategory Category
	{
		[Cpp2IlInjected.Token(Token = "0x600332E")]
		[Cpp2IlInjected.Address(RVA = "0x1068B58", Offset = "0x1068B58", VA = "0x1068B58")]
		get
		{
			return default(AchievementCategory);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700064A")]
	public bool HasTracker
	{
		[Cpp2IlInjected.Token(Token = "0x6003331")]
		[Cpp2IlInjected.Address(RVA = "0x1068CC0", Offset = "0x1068CC0", VA = "0x1068CC0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700064B")]
	public bool IsCompleted
	{
		[Cpp2IlInjected.Token(Token = "0x6003333")]
		[Cpp2IlInjected.Address(RVA = "0x1068CD8", Offset = "0x1068CD8", VA = "0x1068CD8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400003B")]
	public event AchievementCompleted OnCompleted
	{
		[Cpp2IlInjected.Token(Token = "0x600332F")]
		[Cpp2IlInjected.Address(RVA = "0x1068B60", Offset = "0x1068B60", VA = "0x1068B60")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6003330")]
		[Cpp2IlInjected.Address(RVA = "0x1068C10", Offset = "0x1068C10", VA = "0x1068C10")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6003332")]
	[Cpp2IlInjected.Address(RVA = "0x1068CD0", Offset = "0x1068CD0", VA = "0x1068CD0")]
	public IAchievementTracker GetTracker()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6003334")]
	[Cpp2IlInjected.Address(RVA = "0x1068D44", Offset = "0x1068D44", VA = "0x1068D44")]
	public Achievement(string name)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003335")]
	[Cpp2IlInjected.Address(RVA = "0x1068E58", Offset = "0x1068E58", VA = "0x1068E58")]
	public void ClearProgress()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003336")]
	[Cpp2IlInjected.Address(RVA = "0x1069008", Offset = "0x1069008", VA = "0x1069008")]
	public void Shutdown()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003337")]
	[Cpp2IlInjected.Address(RVA = "0x1069130", Offset = "0x1069130", VA = "0x1069130")]
	public void Load(Dictionary<string, JObject> conditions)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003338")]
	[Cpp2IlInjected.Address(RVA = "0x1069E04", Offset = "0x1069E04", VA = "0x1069E04")]
	public void AddCondition(AchievementCondition condition)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003339")]
	[Cpp2IlInjected.Address(RVA = "0x1069F70", Offset = "0x1069F70", VA = "0x1069F70")]
	private void OnConditionComplete(AchievementCondition condition)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600333A")]
	[Cpp2IlInjected.Address(RVA = "0x106A6E0", Offset = "0x106A6E0", VA = "0x106A6E0")]
	private void UseTracker(IAchievementTracker tracker)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600333B")]
	[Cpp2IlInjected.Address(RVA = "0x106A7C8", Offset = "0x106A7C8", VA = "0x106A7C8")]
	public void UseTrackerFromCondition(string conditionName)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600333C")]
	[Cpp2IlInjected.Address(RVA = "0x106A878", Offset = "0x106A878", VA = "0x106A878")]
	public void UseConditionsCompletedTracker()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600333D")]
	[Cpp2IlInjected.Address(RVA = "0x106AAF0", Offset = "0x106AAF0", VA = "0x106AAF0")]
	public void UseConditionsCompletedTracker(params string[] conditions)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600333E")]
	[Cpp2IlInjected.Address(RVA = "0x106ABAC", Offset = "0x106ABAC", VA = "0x106ABAC")]
	public void ClearTracker()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600333F")]
	[Cpp2IlInjected.Address(RVA = "0x106A7E8", Offset = "0x106A7E8", VA = "0x106A7E8")]
	private IAchievementTracker GetConditionTracker(string name)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6003340")]
	[Cpp2IlInjected.Address(RVA = "0x106ABEC", Offset = "0x106ABEC", VA = "0x106ABEC")]
	public void AddConditions(params AchievementCondition[] conditions)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003341")]
	[Cpp2IlInjected.Address(RVA = "0x106AC30", Offset = "0x106AC30", VA = "0x106AC30")]
	public AchievementCondition GetCondition(string conditionName)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6003342")]
	[Cpp2IlInjected.Address(RVA = "0x106ACB4", Offset = "0x106ACB4", VA = "0x106ACB4")]
	public void SetCategory(AchievementCategory category)
	{
	}
}
