using Cpp2IlInjected;

namespace Terraria.Achievements;

[Cpp2IlInjected.Token(Token = "0x2000493")]
public abstract class AchievementTracker<T> : IAchievementTracker
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4006533")]
	protected T _value;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4006534")]
	protected T _maxValue;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4006535")]
	protected string _name;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4006536")]
	private TrackerType _type;

	[Cpp2IlInjected.Token(Token = "0x1700064D")]
	public T Value
	{
		[Cpp2IlInjected.Token(Token = "0x6003360")]
		[Cpp2IlInjected.Address(RVA = "0x163BA40", Offset = "0x163BA40", VA = "0x163BA40")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700064E")]
	public T MaxValue
	{
		[Cpp2IlInjected.Token(Token = "0x6003361")]
		[Cpp2IlInjected.Address(RVA = "0x163BA48", Offset = "0x163BA48", VA = "0x163BA48")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6003362")]
	[Cpp2IlInjected.Address(RVA = "0x163BA50", Offset = "0x163BA50", VA = "0x163BA50")]
	protected AchievementTracker(TrackerType type)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003363")]
	[Cpp2IlInjected.Address(RVA = "0x163BA70", Offset = "0x163BA70", VA = "0x163BA70", Slot = "4")]
	void IAchievementTracker.ReportAs(string name)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003364")]
	[Cpp2IlInjected.Address(RVA = "0x163BA78", Offset = "0x163BA78", VA = "0x163BA78", Slot = "5")]
	TrackerType IAchievementTracker.GetTrackerType()
	{
		return default(TrackerType);
	}

	[Cpp2IlInjected.Token(Token = "0x6003365")]
	[Cpp2IlInjected.Address(RVA = "0x163BA80", Offset = "0x163BA80", VA = "0x163BA80", Slot = "7")]
	void IAchievementTracker.Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003366")]
	[Cpp2IlInjected.Address(RVA = "0x163BA9C", Offset = "0x163BA9C", VA = "0x163BA9C")]
	public void SetValue(T newValue, bool reportUpdate = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003367")]
	[Cpp2IlInjected.Address(Slot = "8")]
	public abstract void ReportUpdate();

	[Cpp2IlInjected.Token(Token = "0x6003368")]
	[Cpp2IlInjected.Address(Slot = "9")]
	protected abstract void Load();

	[Cpp2IlInjected.Token(Token = "0x6003369")]
	[Cpp2IlInjected.Address(RVA = "0x163BB98", Offset = "0x163BB98", VA = "0x163BB98", Slot = "6")]
	void IAchievementTracker.Load()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600336A")]
	[Cpp2IlInjected.Address(RVA = "0x163BBA8", Offset = "0x163BBA8", VA = "0x163BBA8")]
	protected void OnComplete()
	{
	}
}
