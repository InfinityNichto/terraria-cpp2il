using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Terraria.Achievements;

[Cpp2IlInjected.Token(Token = "0x2000492")]
public class AchievementManager
{
	[Cpp2IlInjected.Token(Token = "0x2000932")]
	private class StoredAchievement
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4008AC8")]
		[JsonProperty]
		public Dictionary<string, JObject> Conditions;

		[Cpp2IlInjected.Token(Token = "0x6004CE1")]
		[Cpp2IlInjected.Address(RVA = "0x106D18C", Offset = "0x106D18C", VA = "0x106D18C")]
		public StoredAchievement()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400652A")]
	private string _savePath;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400652B")]
	private bool _isCloudSave;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400652C")]
	private LocalUser User;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400652E")]
	private Dictionary<string, Achievement> _achievements;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400652F")]
	private readonly JsonSerializerSettings _serializerSettings;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4006530")]
	private byte[] _cryptoKey;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4006531")]
	private Dictionary<string, int> _achievementIconIndexes;

	[Cpp2IlInjected.Token(Token = "0x4006532")]
	private static object _ioLock;

	[Cpp2IlInjected.Token(Token = "0x1400003D")]
	public event Achievement.AchievementCompleted OnAchievementCompleted
	{
		[Cpp2IlInjected.Token(Token = "0x600334D")]
		[Cpp2IlInjected.Address(RVA = "0x106B314", Offset = "0x106B314", VA = "0x106B314")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600334E")]
		[Cpp2IlInjected.Address(RVA = "0x106B3C4", Offset = "0x106B3C4", VA = "0x106B3C4")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600334F")]
	[Cpp2IlInjected.Address(RVA = "0x106B474", Offset = "0x106B474", VA = "0x106B474")]
	public AchievementManager(LocalUser user)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003350")]
	[Cpp2IlInjected.Address(RVA = "0x106B6E8", Offset = "0x106B6E8", VA = "0x106B6E8")]
	public void Save()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003351")]
	[Cpp2IlInjected.Address(RVA = "0x106B71C", Offset = "0x106B71C", VA = "0x106B71C")]
	private void Save(string path, bool cloud)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003352")]
	[Cpp2IlInjected.Address(RVA = "0x106BF10", Offset = "0x106BF10", VA = "0x106BF10")]
	public List<Achievement> CreateAchievementsList()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6003353")]
	[Cpp2IlInjected.Address(RVA = "0x106BF80", Offset = "0x106BF80", VA = "0x106BF80")]
	public void Load()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003354")]
	[Cpp2IlInjected.Address(RVA = "0x106BFB4", Offset = "0x106BFB4", VA = "0x106BFB4")]
	private void Load(string path, bool cloud)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003355")]
	[Cpp2IlInjected.Address(RVA = "0x106CB44", Offset = "0x106CB44", VA = "0x106CB44")]
	public void ClearAll()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003356")]
	[Cpp2IlInjected.Address(RVA = "0x106CCA8", Offset = "0x106CCA8", VA = "0x106CCA8")]
	public void Shutdown()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003357")]
	[Cpp2IlInjected.Address(RVA = "0x106CDC4", Offset = "0x106CDC4", VA = "0x106CDC4")]
	private void AchievementCompleted(Achievement achievement)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003358")]
	[Cpp2IlInjected.Address(RVA = "0x106CDF4", Offset = "0x106CDF4", VA = "0x106CDF4")]
	public void Register(Achievement achievement)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003359")]
	[Cpp2IlInjected.Address(RVA = "0x106CE9C", Offset = "0x106CE9C", VA = "0x106CE9C")]
	public void RegisterIconIndex(string achievementName, int iconIndex)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600335A")]
	[Cpp2IlInjected.Address(RVA = "0x106CF08", Offset = "0x106CF08", VA = "0x106CF08")]
	public void RegisterAchievementCategory(string achievementName, AchievementCategory category)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600335B")]
	[Cpp2IlInjected.Address(RVA = "0x106CF74", Offset = "0x106CF74", VA = "0x106CF74")]
	public Achievement GetAchievement(string achievementName)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600335C")]
	[Cpp2IlInjected.Address(RVA = "0x15F0000", Offset = "0x15F0000", VA = "0x15F0000")]
	public T GetCondition<T>(string achievementName, string conditionName) where T : AchievementCondition
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600335D")]
	[Cpp2IlInjected.Address(RVA = "0x106CFF8", Offset = "0x106CFF8", VA = "0x106CFF8")]
	public AchievementCondition GetCondition(string achievementName, string conditionName)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600335E")]
	[Cpp2IlInjected.Address(RVA = "0x106D090", Offset = "0x106D090", VA = "0x106D090")]
	public int GetIconIndex(string achievementName)
	{
		return default(int);
	}
}
