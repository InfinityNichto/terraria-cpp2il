using System;
using Cpp2IlInjected;

[Cpp2IlInjected.Token(Token = "0x2000233")]
public static class nativefiledialog
{
	[Cpp2IlInjected.Token(Token = "0x2000808")]
	public enum nfdresult_t
	{
		[Cpp2IlInjected.Token(Token = "0x4007D39")]
		NFD_ERROR,
		[Cpp2IlInjected.Token(Token = "0x4007D3A")]
		NFD_OKAY,
		[Cpp2IlInjected.Token(Token = "0x4007D3B")]
		NFD_CANCEL
	}

	[Cpp2IlInjected.Token(Token = "0x2000809")]
	public struct nfdpathset_t
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4007D3C")]
		private IntPtr buf;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4007D3D")]
		private IntPtr indices;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4007D3E")]
		private IntPtr count;
	}

	[Cpp2IlInjected.Token(Token = "0x4001B5E")]
	private const string nativeLibName = "nfd";

	[Cpp2IlInjected.Token(Token = "0x6000FE2")]
	[Cpp2IlInjected.Address(RVA = "0x15063EC", Offset = "0x15063EC", VA = "0x15063EC")]
	private static int Utf8Size(string str)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000FE3")]
	[Cpp2IlInjected.Address(RVA = "0x15063FC", Offset = "0x15063FC", VA = "0x15063FC")]
	private unsafe static byte* Utf8EncodeNullable(string str)
	{
		//IL_0002: Expected I, but got O
		return (byte*)unchecked((nint)null);
	}

	[Cpp2IlInjected.Token(Token = "0x6000FE4")]
	[Cpp2IlInjected.Address(RVA = "0x15064E8", Offset = "0x15064E8", VA = "0x15064E8")]
	private static string UTF8_ToManaged(IntPtr s, bool freePtr = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000FE5")]
	[Cpp2IlInjected.Address(RVA = "0x1506648", Offset = "0x1506648", VA = "0x1506648")]
	private static extern void free(IntPtr ptr);

	[Cpp2IlInjected.Token(Token = "0x6000FE6")]
	[Cpp2IlInjected.Address(RVA = "0x15066E8", Offset = "0x15066E8", VA = "0x15066E8")]
	private unsafe static extern nfdresult_t INTERNAL_NFD_OpenDialog(byte* filterList, byte* defaultPath, out IntPtr outPath);

	[Cpp2IlInjected.Token(Token = "0x6000FE7")]
	[Cpp2IlInjected.Address(RVA = "0x1506798", Offset = "0x1506798", VA = "0x1506798")]
	public static nfdresult_t NFD_OpenDialog(string filterList, string defaultPath, out string outPath)
	{
		return default(nfdresult_t);
	}

	[Cpp2IlInjected.Token(Token = "0x6000FE8")]
	[Cpp2IlInjected.Address(RVA = "0x1506890", Offset = "0x1506890", VA = "0x1506890")]
	private unsafe static extern nfdresult_t INTERNAL_NFD_OpenDialogMultiple(byte* filterList, byte* defaultPath, out nfdpathset_t outPaths);

	[Cpp2IlInjected.Token(Token = "0x6000FE9")]
	[Cpp2IlInjected.Address(RVA = "0x1506940", Offset = "0x1506940", VA = "0x1506940")]
	public static nfdresult_t NFD_OpenDialogMultiple(string filterList, string defaultPath, out nfdpathset_t outPaths)
	{
		return default(nfdresult_t);
	}

	[Cpp2IlInjected.Token(Token = "0x6000FEA")]
	[Cpp2IlInjected.Address(RVA = "0x1506A18", Offset = "0x1506A18", VA = "0x1506A18")]
	private unsafe static extern nfdresult_t INTERNAL_NFD_SaveDialog(byte* filterList, byte* defaultPath, out IntPtr outPath);

	[Cpp2IlInjected.Token(Token = "0x6000FEB")]
	[Cpp2IlInjected.Address(RVA = "0x1506AC8", Offset = "0x1506AC8", VA = "0x1506AC8")]
	public static nfdresult_t NFD_SaveDialog(string filterList, string defaultPath, out string outPath)
	{
		return default(nfdresult_t);
	}

	[Cpp2IlInjected.Token(Token = "0x6000FEC")]
	[Cpp2IlInjected.Address(RVA = "0x1506BC0", Offset = "0x1506BC0", VA = "0x1506BC0")]
	private unsafe static extern nfdresult_t INTERNAL_NFD_PickFolder(byte* defaultPath, out IntPtr outPath);

	[Cpp2IlInjected.Token(Token = "0x6000FED")]
	[Cpp2IlInjected.Address(RVA = "0x1506C68", Offset = "0x1506C68", VA = "0x1506C68")]
	public static nfdresult_t NFD_PickFolder(string defaultPath, out string outPath)
	{
		return default(nfdresult_t);
	}

	[Cpp2IlInjected.Token(Token = "0x6000FEE")]
	[Cpp2IlInjected.Address(RVA = "0x1506D38", Offset = "0x1506D38", VA = "0x1506D38")]
	private static extern IntPtr INTERNAL_NFD_GetError();

	[Cpp2IlInjected.Token(Token = "0x6000FEF")]
	[Cpp2IlInjected.Address(RVA = "0x1506DD0", Offset = "0x1506DD0", VA = "0x1506DD0")]
	public static string NFD_GetError()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000FF0")]
	[Cpp2IlInjected.Address(RVA = "0x1506DE8", Offset = "0x1506DE8", VA = "0x1506DE8")]
	public static extern IntPtr NFD_PathSet_GetCount(ref nfdpathset_t pathset);

	[Cpp2IlInjected.Token(Token = "0x6000FF1")]
	[Cpp2IlInjected.Address(RVA = "0x1506E88", Offset = "0x1506E88", VA = "0x1506E88")]
	private static extern IntPtr INTERNAL_NFD_PathSet_GetPath(ref nfdpathset_t pathset, IntPtr index);

	[Cpp2IlInjected.Token(Token = "0x6000FF2")]
	[Cpp2IlInjected.Address(RVA = "0x1506F30", Offset = "0x1506F30", VA = "0x1506F30")]
	public static string NFD_PathSet_GetPath(ref nfdpathset_t pathset, IntPtr index)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000FF3")]
	[Cpp2IlInjected.Address(RVA = "0x1506F48", Offset = "0x1506F48", VA = "0x1506F48")]
	public static extern void NFD_PathSet_Free(ref nfdpathset_t pathset);
}
