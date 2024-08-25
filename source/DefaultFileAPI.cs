using System;
using System.IO;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Terraria;
using UnityEngine;

[global::Cpp2ILInjected.Token(Token = "0x200006C")]
public class DefaultFileAPI : FileAPI
{
	[global::Cpp2ILInjected.Token(Token = "0x600024D")]
	[global::Cpp2ILInjected.Address(RVA = "0x70EFDC", Offset = "0x70EFDC", Length = "0x90")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FileManager), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(PlatformUser),
		typeof(bool)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Debug), Member = "Log", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
	public DefaultFileAPI(PlatformUser user)
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x600024E")]
	[global::Cpp2ILInjected.Address(RVA = "0x70F06C", Offset = "0x70F06C", Length = "0x4")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	public void Shutdown()
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x600024F")]
	[global::Cpp2ILInjected.Address(RVA = "0x70F070", Offset = "0x70F070", Length = "0x280")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Application), Member = "get_persistentDataPath", ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Debug), Member = "Log", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AndroidJavaClass), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AndroidJavaObject[]), Member = "GetStatic", MemberTypeParameters = new object[] { typeof(object) }, MemberParameters = new object[] { typeof(string) }, ReturnType = "FieldType")]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AndroidJavaObject[]), Member = "Call", MemberTypeParameters = new object[] { typeof(object) }, MemberParameters = new object[]
	{
		typeof(string),
		typeof(object[])
	}, ReturnType = "ReturnType")]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "LastIndexOf", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Substring", MemberParameters = new object[]
	{
		typeof(int),
		typeof(int)
	}, ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 19)]
	public string GetUserSavePath()
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000250")]
	[global::Cpp2ILInjected.Address(RVA = "0x70F2F0", Offset = "0x70F2F0", Length = "0x4")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	public void LegacySync()
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000251")]
	[global::Cpp2ILInjected.Address(RVA = "0x70F2F4", Offset = "0x70F2F4", Length = "0x6C")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_SavePath", ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
	public void Mount(bool forSync)
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000252")]
	[global::Cpp2ILInjected.Address(RVA = "0x70F360", Offset = "0x70F360", Length = "0x4")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	public void Unmount(bool forSync)
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000253")]
	[global::Cpp2ILInjected.Address(RVA = "0x70F364", Offset = "0x70F364", Length = "0xC")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Directory), Member = "CreateDirectory", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(DirectoryInfo))]
	public void CreateDirectory(string directory)
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000254")]
	[global::Cpp2ILInjected.Address(RVA = "0x70F370", Offset = "0x70F370", Length = "0x90")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Path), Member = "GetDirectoryName", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Directory), Member = "Exists", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Directory), Member = "CreateDirectory", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(DirectoryInfo))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(File), Member = "WriteAllBytes", MemberParameters = new object[]
	{
		typeof(string),
		typeof(byte[])
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
	public void WriteFile(string filename, byte[] fileData)
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000255")]
	[global::Cpp2ILInjected.Address(RVA = "0x70F400", Offset = "0x70F400", Length = "0xC")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(File), Member = "Delete", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
	public void Delete(string filename)
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000256")]
	[global::Cpp2ILInjected.Address(RVA = "0x70F40C", Offset = "0x70F40C", Length = "0xC")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(File), Member = "ReadAllBytes", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(byte[]))]
	public byte[] ReadFile(string filename)
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000257")]
	[global::Cpp2ILInjected.Address(RVA = "0x70F418", Offset = "0x70F418", Length = "0x74")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Directory), Member = "Exists", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Directory), Member = "GetFiles", MemberParameters = new object[]
	{
		typeof(string),
		typeof(string)
	}, ReturnType = typeof(string[]))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
	public string[] GetFiles(string path, string searchPattern)
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000258")]
	[global::Cpp2ILInjected.Address(RVA = "0x70F48C", Offset = "0x70F48C", Length = "0x6C")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Directory), Member = "Exists", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Directory), Member = "GetDirectories", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string[]))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
	public string[] GetFolders(string path)
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000259")]
	[global::Cpp2ILInjected.Address(RVA = "0x70F4F8", Offset = "0x70F4F8", Length = "0xC")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(File), Member = "Exists", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
	public bool Exists(string filename)
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x600025A")]
	[global::Cpp2ILInjected.Address(RVA = "0x70F504", Offset = "0x70F504", Length = "0x10")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(File), Member = "SetAttributes", MemberParameters = new object[]
	{
		typeof(string),
		typeof(FileAttributes)
	}, ReturnType = typeof(void))]
	public void SetAttributes(string filename, FileAttributes fileAttributes)
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x4000217")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
	private int mountCount;

	[global::Cpp2ILInjected.Token(Token = "0x4000218")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
	private string _userSavePath;

	[global::Cpp2ILInjected.Token(Token = "0x4000219")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	private PlatformUser platformUser;
}
