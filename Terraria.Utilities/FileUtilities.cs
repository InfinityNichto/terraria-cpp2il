using System.IO;
using System.Text.RegularExpressions;
using Cpp2IlInjected;

namespace Terraria.Utilities;

[Cpp2IlInjected.Token(Token = "0x2000377")]
public static class FileUtilities
{
	[Cpp2IlInjected.Token(Token = "0x400318D")]
	private static Regex FileNameRegex;

	[Cpp2IlInjected.Token(Token = "0x6002CF4")]
	[Cpp2IlInjected.Address(RVA = "0x10DAB3C", Offset = "0x10DAB3C", VA = "0x10DAB3C")]
	public static string WildcardToRegex(string pattern)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6002CF5")]
	[Cpp2IlInjected.Address(RVA = "0x10DAC34", Offset = "0x10DAC34", VA = "0x10DAC34")]
	public static string CleanSwitchPath(string path)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6002CF6")]
	[Cpp2IlInjected.Address(RVA = "0x10DACC4", Offset = "0x10DACC4", VA = "0x10DACC4")]
	public static string[] GetFiles(string path, string searchPattern)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6002CF7")]
	[Cpp2IlInjected.Address(RVA = "0x10DACCC", Offset = "0x10DACCC", VA = "0x10DACCC")]
	public static void SetAttributes(string path, FileAttributes fileAttributes)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002CF8")]
	[Cpp2IlInjected.Address(RVA = "0x10DACD4", Offset = "0x10DACD4", VA = "0x10DACD4")]
	public static void CreateDirectory(string path)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002CF9")]
	[Cpp2IlInjected.Address(RVA = "0x10DACDC", Offset = "0x10DACDC", VA = "0x10DACDC")]
	public static bool Exists(string path, bool cloud = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6002CFA")]
	[Cpp2IlInjected.Address(RVA = "0x10DADC4", Offset = "0x10DADC4", VA = "0x10DADC4")]
	public static void Delete(string path, bool cloud = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002CFB")]
	[Cpp2IlInjected.Address(RVA = "0x10DAEA4", Offset = "0x10DAEA4", VA = "0x10DAEA4")]
	public static string GetFullPath(string path, bool cloud)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6002CFC")]
	[Cpp2IlInjected.Address(RVA = "0x10DAEA8", Offset = "0x10DAEA8", VA = "0x10DAEA8")]
	public static void Copy(string source, string destination, bool cloud = false, bool overwrite = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002CFD")]
	[Cpp2IlInjected.Address(RVA = "0x10DB1EC", Offset = "0x10DB1EC", VA = "0x10DB1EC")]
	public static void Move(string source, string destination, bool cloud, bool overwrite = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002CFE")]
	[Cpp2IlInjected.Address(RVA = "0x10DB290", Offset = "0x10DB290", VA = "0x10DB290")]
	public static void WriteAllText(string path, string data)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002CFF")]
	[Cpp2IlInjected.Address(RVA = "0x10DB334", Offset = "0x10DB334", VA = "0x10DB334")]
	public static string ReadAllText(string path)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6002D00")]
	[Cpp2IlInjected.Address(RVA = "0x10DB078", Offset = "0x10DB078", VA = "0x10DB078")]
	public static byte[] ReadAllBytes(string path, bool cloud = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6002D01")]
	[Cpp2IlInjected.Address(RVA = "0x10DB158", Offset = "0x10DB158", VA = "0x10DB158")]
	public static void WriteAllBytes(string path, byte[] data, bool cloud = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002D02")]
	[Cpp2IlInjected.Address(RVA = "0x10DB3D4", Offset = "0x10DB3D4", VA = "0x10DB3D4")]
	public static void Write(string path, byte[] data, int length, bool cloud)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002D03")]
	[Cpp2IlInjected.Address(RVA = "0x10DB750", Offset = "0x10DB750", VA = "0x10DB750")]
	public static bool MoveToCloud(string localPath, string cloudPath)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6002D04")]
	[Cpp2IlInjected.Address(RVA = "0x10DB83C", Offset = "0x10DB83C", VA = "0x10DB83C")]
	public static bool MoveToLocal(string cloudPath, string localPath)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6002D05")]
	[Cpp2IlInjected.Address(RVA = "0x10DB928", Offset = "0x10DB928", VA = "0x10DB928")]
	public static string GetFileName(string path, bool includeExtension = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6002D06")]
	[Cpp2IlInjected.Address(RVA = "0x10DB64C", Offset = "0x10DB64C", VA = "0x10DB64C")]
	public static string GetParentFolderPath(string path, bool includeExtension = true)
	{
		return null;
	}
}
