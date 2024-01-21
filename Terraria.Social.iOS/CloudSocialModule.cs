using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using Cpp2IlInjected;
using Terraria.Social.Base;

namespace Terraria.Social.iOS;

[Cpp2IlInjected.Token(Token = "0x2000385")]
public class CloudSocialModule : Terraria.Social.Base.CloudSocialModule
{
	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40031B6")]
	private string editorRemoteCache;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40031B7")]
	private string cacheFolder;

	[Cpp2IlInjected.Token(Token = "0x40031B8")]
	private static Regex FileNameRegex;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x40031B9")]
	private string SyncPath;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40031BA")]
	private DateTime SyncStarted;

	[Cpp2IlInjected.Token(Token = "0x6002D4B")]
	[Cpp2IlInjected.Address(RVA = "0x14E5DAC", Offset = "0x14E5DAC", VA = "0x14E5DAC", Slot = "6")]
	public override void Initialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002D4C")]
	[Cpp2IlInjected.Address(RVA = "0x14E5DC0", Offset = "0x14E5DC0", VA = "0x14E5DC0", Slot = "7")]
	public override void Shutdown()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002D4D")]
	[Cpp2IlInjected.Address(RVA = "0x14E5DC4", Offset = "0x14E5DC4", VA = "0x14E5DC4")]
	public void SyncFiles(string path)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002D4E")]
	[Cpp2IlInjected.Address(RVA = "0x14E5DD4", Offset = "0x14E5DD4", VA = "0x14E5DD4")]
	public bool HasFinishedSync()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6002D4F")]
	[Cpp2IlInjected.Address(RVA = "0x14E5DB8", Offset = "0x14E5DB8", VA = "0x14E5DB8")]
	public bool IsRequired()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6002D50")]
	[Cpp2IlInjected.Address(RVA = "0x14E5F1C", Offset = "0x14E5F1C", VA = "0x14E5F1C")]
	public bool IsAvailable()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6002D51")]
	[Cpp2IlInjected.Address(RVA = "0x14E5F24", Offset = "0x14E5F24", VA = "0x14E5F24")]
	public bool IsConnected()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6002D52")]
	[Cpp2IlInjected.Address(RVA = "0x14E5F2C", Offset = "0x14E5F2C", VA = "0x14E5F2C", Slot = "8")]
	public override IEnumerable<string> GetFiles()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6002D53")]
	[Cpp2IlInjected.Address(RVA = "0x14E5E18", Offset = "0x14E5E18", VA = "0x14E5E18")]
	public static string GetParentFolderPath(string path, bool includeExtension = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6002D54")]
	[Cpp2IlInjected.Address(RVA = "0x14E6028", Offset = "0x14E6028", VA = "0x14E6028", Slot = "9")]
	public override bool Write(string path, byte[] data, int length)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6002D55")]
	[Cpp2IlInjected.Address(RVA = "0x14E6150", Offset = "0x14E6150", VA = "0x14E6150", Slot = "10")]
	public override void Read(string path, byte[] buffer, int length)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002D56")]
	[Cpp2IlInjected.Address(RVA = "0x14E621C", Offset = "0x14E621C", VA = "0x14E621C", Slot = "11")]
	public override bool HasFile(string path)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6002D57")]
	[Cpp2IlInjected.Address(RVA = "0x14E627C", Offset = "0x14E627C", VA = "0x14E627C", Slot = "12")]
	public override int GetFileSize(string path)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6002D58")]
	[Cpp2IlInjected.Address(RVA = "0x14E62A0", Offset = "0x14E62A0", VA = "0x14E62A0", Slot = "13")]
	public override bool Delete(string path)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6002D59")]
	[Cpp2IlInjected.Address(RVA = "0x14E62C4", Offset = "0x14E62C4", VA = "0x14E62C4", Slot = "14")]
	public override bool Forget(string path)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6002D5A")]
	[Cpp2IlInjected.Address(RVA = "0x14E62CC", Offset = "0x14E62CC", VA = "0x14E62CC")]
	public CloudSocialModule()
	{
	}
}
