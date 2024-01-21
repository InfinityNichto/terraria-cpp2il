using System;
using System.Diagnostics;
using Cpp2IlInjected;

namespace Terraria.IO;

[Cpp2IlInjected.Token(Token = "0x20003CA")]
public class PlayerFileData : FileData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4003293")]
	private Player _player;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4003294")]
	private TimeSpan _playTime;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4003295")]
	private readonly Stopwatch _timer;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4003296")]
	private bool _isTimerActive;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4003297")]
	public Projectile UIPetProjectile;

	[Cpp2IlInjected.Token(Token = "0x170005F6")]
	public Player Player
	{
		[Cpp2IlInjected.Token(Token = "0x6002F89")]
		[Cpp2IlInjected.Address(RVA = "0xE41F08", Offset = "0xE41F08", VA = "0xE41F08")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6002F8A")]
		[Cpp2IlInjected.Address(RVA = "0xE41F10", Offset = "0xE41F10", VA = "0xE41F10")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6002F8B")]
	[Cpp2IlInjected.Address(RVA = "0xE41F24", Offset = "0xE41F24", VA = "0xE41F24")]
	public void PreparePetProjectiles()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002F8C")]
	[Cpp2IlInjected.Address(RVA = "0xE41FF4", Offset = "0xE41FF4", VA = "0xE41FF4")]
	public PlayerFileData()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002F8D")]
	[Cpp2IlInjected.Address(RVA = "0xE420B8", Offset = "0xE420B8", VA = "0xE420B8")]
	public PlayerFileData(string path, bool cloudSave)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002F8E")]
	[Cpp2IlInjected.Address(RVA = "0xE4218C", Offset = "0xE4218C", VA = "0xE4218C")]
	public static PlayerFileData CreateAndSave(Player player)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6002F8F")]
	[Cpp2IlInjected.Address(RVA = "0xE423A4", Offset = "0xE423A4", VA = "0xE423A4", Slot = "4")]
	public override void SetAsActive()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002F90")]
	[Cpp2IlInjected.Address(RVA = "0xE424D8", Offset = "0xE424D8", VA = "0xE424D8", Slot = "5")]
	public override void MoveToCloud()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002F91")]
	[Cpp2IlInjected.Address(RVA = "0xE4295C", Offset = "0xE4295C", VA = "0xE4295C", Slot = "6")]
	public override void MoveToLocal()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002F92")]
	[Cpp2IlInjected.Address(RVA = "0xE42F7C", Offset = "0xE42F7C", VA = "0xE42F7C")]
	private bool MapBelongsToPath(string mapPath, string filePath)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6002F93")]
	[Cpp2IlInjected.Address(RVA = "0xE4301C", Offset = "0xE4301C", VA = "0xE4301C")]
	public void UpdatePlayTimer()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002F94")]
	[Cpp2IlInjected.Address(RVA = "0xE431C8", Offset = "0xE431C8", VA = "0xE431C8")]
	public void OnLostFocus()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002F95")]
	[Cpp2IlInjected.Address(RVA = "0xE43190", Offset = "0xE43190", VA = "0xE43190")]
	public void StartPlayTimer()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002F96")]
	[Cpp2IlInjected.Address(RVA = "0xE431C4", Offset = "0xE431C4", VA = "0xE431C4")]
	public void PausePlayTimer()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002F97")]
	[Cpp2IlInjected.Address(RVA = "0xE432B8", Offset = "0xE432B8", VA = "0xE432B8")]
	public TimeSpan GetPlayTime()
	{
		return default(TimeSpan);
	}

	[Cpp2IlInjected.Token(Token = "0x6002F98")]
	[Cpp2IlInjected.Address(RVA = "0xE43388", Offset = "0xE43388", VA = "0xE43388")]
	public void UpdatePlayTimerAndKeepState()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002F99")]
	[Cpp2IlInjected.Address(RVA = "0xE431CC", Offset = "0xE431CC", VA = "0xE431CC")]
	public void StopPlayTimer()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002F9A")]
	[Cpp2IlInjected.Address(RVA = "0xE4346C", Offset = "0xE4346C", VA = "0xE4346C")]
	public void SetPlayTime(TimeSpan time)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002F9B")]
	[Cpp2IlInjected.Address(RVA = "0xE4347C", Offset = "0xE4347C", VA = "0xE4347C")]
	public void Rename(string newName)
	{
	}
}
