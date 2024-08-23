﻿using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

// Token: 0x02000231 RID: 561
[global::Cpp2ILInjected.Token(Token = "0x20002E3")]
public static class nativefiledialog
{
	// Token: 0x06000FC9 RID: 4041 RVA: 0x00024A58 File Offset: 0x00022C58
	[global::Cpp2ILInjected.Token(Token = "0x6001112")]
	[global::Cpp2ILInjected.Address(RVA = "0xA676E0", Offset = "0xA676E0", Length = "0x10")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	private static int Utf8Size(string str)
	{
		throw null;
	}

	// Token: 0x06000FCA RID: 4042 RVA: 0x00024A5B File Offset: 0x00022C5B
	[global::Cpp2ILInjected.Token(Token = "0x6001113")]
	[global::Cpp2ILInjected.Address(RVA = "0xA676F0", Offset = "0xA676F0", Length = "0xC4")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(nativefiledialog), Member = "NFD_OpenDialog", MemberParameters = new object[]
	{
		typeof(string),
		typeof(string),
		typeof(ref string)
	}, ReturnType = typeof(nativefiledialog.nfdresult_t))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(nativefiledialog), Member = "NFD_OpenDialogMultiple", MemberParameters = new object[]
	{
		typeof(string),
		typeof(string),
		typeof(ref nativefiledialog.nfdpathset_t)
	}, ReturnType = typeof(nativefiledialog.nfdresult_t))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(nativefiledialog), Member = "NFD_SaveDialog", MemberParameters = new object[]
	{
		typeof(string),
		typeof(string),
		typeof(ref string)
	}, ReturnType = typeof(nativefiledialog.nfdresult_t))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(nativefiledialog), Member = "NFD_PickFolder", MemberParameters = new object[]
	{
		typeof(string),
		typeof(ref string)
	}, ReturnType = typeof(nativefiledialog.nfdresult_t))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 7)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Marshal), Member = "AllocHGlobal", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(IntPtr))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(IntPtr), Member = "op_Explicit", MemberParameters = new object[] { typeof(IntPtr) }, ReturnType = typeof(void*))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RuntimeHelpers), Member = "get_OffsetToStringData", ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Encoding), Member = "get_UTF8", ReturnType = typeof(Encoding))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
	private unsafe static byte* Utf8EncodeNullable(string str)
	{
		throw null;
	}

	// Token: 0x06000FCB RID: 4043 RVA: 0x00024A5E File Offset: 0x00022C5E
	[global::Cpp2ILInjected.Token(Token = "0x6001114")]
	[global::Cpp2ILInjected.Address(RVA = "0xA677B4", Offset = "0xA677B4", Length = "0x1A0")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(nativefiledialog), Member = "NFD_OpenDialog", MemberParameters = new object[]
	{
		typeof(string),
		typeof(string),
		typeof(ref string)
	}, ReturnType = typeof(nativefiledialog.nfdresult_t))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(nativefiledialog), Member = "NFD_SaveDialog", MemberParameters = new object[]
	{
		typeof(string),
		typeof(string),
		typeof(ref string)
	}, ReturnType = typeof(nativefiledialog.nfdresult_t))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(nativefiledialog), Member = "NFD_PickFolder", MemberParameters = new object[]
	{
		typeof(string),
		typeof(ref string)
	}, ReturnType = typeof(nativefiledialog.nfdresult_t))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(nativefiledialog), Member = "NFD_GetError", ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(nativefiledialog), Member = "NFD_PathSet_GetPath", MemberParameters = new object[]
	{
		typeof(ref nativefiledialog.nfdpathset_t),
		typeof(IntPtr)
	}, ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(IntPtr), Member = "op_Equality", MemberParameters = new object[]
	{
		typeof(IntPtr),
		typeof(IntPtr)
	}, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(IntPtr), Member = "op_Explicit", MemberParameters = new object[] { typeof(IntPtr) }, ReturnType = typeof(void*))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Encoding), Member = "get_UTF8", ReturnType = typeof(Encoding))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "CreateString", MemberParameters = new object[]
	{
		typeof(char*),
		typeof(int),
		typeof(int)
	}, ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(nativefiledialog), Member = "free", MemberParameters = new object[] { typeof(IntPtr) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
	private unsafe static string UTF8_ToManaged(IntPtr s, bool freePtr = false)
	{
		throw null;
	}

	// Token: 0x06000FCC RID: 4044
	[global::Cpp2ILInjected.Token(Token = "0x6001115")]
	[global::Cpp2ILInjected.Address(RVA = "0xA67954", Offset = "0xA67954", Length = "0x7C")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(nativefiledialog), Member = "UTF8_ToManaged", MemberParameters = new object[]
	{
		typeof(IntPtr),
		typeof(bool)
	}, ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	[PreserveSig]
	private static extern void free(IntPtr ptr);

	// Token: 0x06000FCD RID: 4045
	[global::Cpp2ILInjected.Token(Token = "0x6001116")]
	[global::Cpp2ILInjected.Address(RVA = "0xA679D0", Offset = "0xA679D0", Length = "0x94")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(nativefiledialog), Member = "NFD_OpenDialog", MemberParameters = new object[]
	{
		typeof(string),
		typeof(string),
		typeof(ref string)
	}, ReturnType = typeof(nativefiledialog.nfdresult_t))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	[PreserveSig]
	private unsafe static extern nativefiledialog.nfdresult_t INTERNAL_NFD_OpenDialog(byte* filterList, byte* defaultPath, out IntPtr outPath);

	// Token: 0x06000FCE RID: 4046 RVA: 0x00024A61 File Offset: 0x00022C61
	[global::Cpp2ILInjected.Token(Token = "0x6001117")]
	[global::Cpp2ILInjected.Address(RVA = "0xA67A64", Offset = "0xA67A64", Length = "0xE0")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(nativefiledialog), Member = "Utf8EncodeNullable", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(byte*))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(nativefiledialog), Member = "INTERNAL_NFD_OpenDialog", MemberParameters = new object[]
	{
		typeof(byte*),
		typeof(byte*),
		typeof(ref IntPtr)
	}, ReturnType = typeof(nativefiledialog.nfdresult_t))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(IntPtr), Member = "op_Explicit", MemberParameters = new object[] { typeof(void*) }, ReturnType = typeof(IntPtr))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Marshal), Member = "FreeHGlobal", MemberParameters = new object[] { typeof(IntPtr) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(nativefiledialog), Member = "UTF8_ToManaged", MemberParameters = new object[]
	{
		typeof(IntPtr),
		typeof(bool)
	}, ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
	public unsafe static nativefiledialog.nfdresult_t NFD_OpenDialog(string filterList, string defaultPath, out string outPath)
	{
		throw null;
	}

	// Token: 0x06000FCF RID: 4047
	[global::Cpp2ILInjected.Token(Token = "0x6001118")]
	[global::Cpp2ILInjected.Address(RVA = "0xA67B44", Offset = "0xA67B44", Length = "0x94")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(nativefiledialog), Member = "NFD_OpenDialogMultiple", MemberParameters = new object[]
	{
		typeof(string),
		typeof(string),
		typeof(ref nativefiledialog.nfdpathset_t)
	}, ReturnType = typeof(nativefiledialog.nfdresult_t))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	[PreserveSig]
	private unsafe static extern nativefiledialog.nfdresult_t INTERNAL_NFD_OpenDialogMultiple(byte* filterList, byte* defaultPath, out nativefiledialog.nfdpathset_t outPaths);

	// Token: 0x06000FD0 RID: 4048 RVA: 0x00024A64 File Offset: 0x00022C64
	[global::Cpp2ILInjected.Token(Token = "0x6001119")]
	[global::Cpp2ILInjected.Address(RVA = "0xA67BD8", Offset = "0xA67BD8", Length = "0xC4")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(nativefiledialog), Member = "Utf8EncodeNullable", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(byte*))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(nativefiledialog), Member = "INTERNAL_NFD_OpenDialogMultiple", MemberParameters = new object[]
	{
		typeof(byte*),
		typeof(byte*),
		typeof(ref nativefiledialog.nfdpathset_t)
	}, ReturnType = typeof(nativefiledialog.nfdresult_t))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(IntPtr), Member = "op_Explicit", MemberParameters = new object[] { typeof(void*) }, ReturnType = typeof(IntPtr))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Marshal), Member = "FreeHGlobal", MemberParameters = new object[] { typeof(IntPtr) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
	public unsafe static nativefiledialog.nfdresult_t NFD_OpenDialogMultiple(string filterList, string defaultPath, out nativefiledialog.nfdpathset_t outPaths)
	{
		throw null;
	}

	// Token: 0x06000FD1 RID: 4049
	[global::Cpp2ILInjected.Token(Token = "0x600111A")]
	[global::Cpp2ILInjected.Address(RVA = "0xA67C9C", Offset = "0xA67C9C", Length = "0x94")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(nativefiledialog), Member = "NFD_SaveDialog", MemberParameters = new object[]
	{
		typeof(string),
		typeof(string),
		typeof(ref string)
	}, ReturnType = typeof(nativefiledialog.nfdresult_t))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	[PreserveSig]
	private unsafe static extern nativefiledialog.nfdresult_t INTERNAL_NFD_SaveDialog(byte* filterList, byte* defaultPath, out IntPtr outPath);

	// Token: 0x06000FD2 RID: 4050 RVA: 0x00024A67 File Offset: 0x00022C67
	[global::Cpp2ILInjected.Token(Token = "0x600111B")]
	[global::Cpp2ILInjected.Address(RVA = "0xA67D30", Offset = "0xA67D30", Length = "0xE0")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(nativefiledialog), Member = "Utf8EncodeNullable", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(byte*))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(nativefiledialog), Member = "INTERNAL_NFD_SaveDialog", MemberParameters = new object[]
	{
		typeof(byte*),
		typeof(byte*),
		typeof(ref IntPtr)
	}, ReturnType = typeof(nativefiledialog.nfdresult_t))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(IntPtr), Member = "op_Explicit", MemberParameters = new object[] { typeof(void*) }, ReturnType = typeof(IntPtr))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Marshal), Member = "FreeHGlobal", MemberParameters = new object[] { typeof(IntPtr) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(nativefiledialog), Member = "UTF8_ToManaged", MemberParameters = new object[]
	{
		typeof(IntPtr),
		typeof(bool)
	}, ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
	public unsafe static nativefiledialog.nfdresult_t NFD_SaveDialog(string filterList, string defaultPath, out string outPath)
	{
		throw null;
	}

	// Token: 0x06000FD3 RID: 4051
	[global::Cpp2ILInjected.Token(Token = "0x600111C")]
	[global::Cpp2ILInjected.Address(RVA = "0xA67E10", Offset = "0xA67E10", Length = "0x84")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(nativefiledialog), Member = "NFD_PickFolder", MemberParameters = new object[]
	{
		typeof(string),
		typeof(ref string)
	}, ReturnType = typeof(nativefiledialog.nfdresult_t))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	[PreserveSig]
	private unsafe static extern nativefiledialog.nfdresult_t INTERNAL_NFD_PickFolder(byte* defaultPath, out IntPtr outPath);

	// Token: 0x06000FD4 RID: 4052 RVA: 0x00024A6A File Offset: 0x00022C6A
	[global::Cpp2ILInjected.Token(Token = "0x600111D")]
	[global::Cpp2ILInjected.Address(RVA = "0xA67E94", Offset = "0xA67E94", Length = "0xAC")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(nativefiledialog), Member = "Utf8EncodeNullable", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(byte*))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(nativefiledialog), Member = "INTERNAL_NFD_PickFolder", MemberParameters = new object[]
	{
		typeof(byte*),
		typeof(ref IntPtr)
	}, ReturnType = typeof(nativefiledialog.nfdresult_t))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(IntPtr), Member = "op_Explicit", MemberParameters = new object[] { typeof(void*) }, ReturnType = typeof(IntPtr))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Marshal), Member = "FreeHGlobal", MemberParameters = new object[] { typeof(IntPtr) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(nativefiledialog), Member = "UTF8_ToManaged", MemberParameters = new object[]
	{
		typeof(IntPtr),
		typeof(bool)
	}, ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
	public unsafe static nativefiledialog.nfdresult_t NFD_PickFolder(string defaultPath, out string outPath)
	{
		throw null;
	}

	// Token: 0x06000FD5 RID: 4053
	[global::Cpp2ILInjected.Token(Token = "0x600111E")]
	[global::Cpp2ILInjected.Address(RVA = "0xA67F40", Offset = "0xA67F40", Length = "0x68")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(nativefiledialog), Member = "NFD_GetError", ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	[PreserveSig]
	private static extern IntPtr INTERNAL_NFD_GetError();

	// Token: 0x06000FD6 RID: 4054 RVA: 0x00024A6D File Offset: 0x00022C6D
	[global::Cpp2ILInjected.Token(Token = "0x600111F")]
	[global::Cpp2ILInjected.Address(RVA = "0xA67FA8", Offset = "0xA67FA8", Length = "0x14")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(nativefiledialog), Member = "INTERNAL_NFD_GetError", ReturnType = typeof(IntPtr))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(nativefiledialog), Member = "UTF8_ToManaged", MemberParameters = new object[]
	{
		typeof(IntPtr),
		typeof(bool)
	}, ReturnType = typeof(string))]
	public static string NFD_GetError()
	{
		throw null;
	}

	// Token: 0x06000FD7 RID: 4055
	[global::Cpp2ILInjected.Token(Token = "0x6001120")]
	[global::Cpp2ILInjected.Address(RVA = "0xA67FBC", Offset = "0xA67FBC", Length = "0x7C")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	[PreserveSig]
	public static extern IntPtr NFD_PathSet_GetCount(ref nativefiledialog.nfdpathset_t pathset);

	// Token: 0x06000FD8 RID: 4056
	[global::Cpp2ILInjected.Token(Token = "0x6001121")]
	[global::Cpp2ILInjected.Address(RVA = "0xA68038", Offset = "0xA68038", Length = "0x84")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(nativefiledialog), Member = "NFD_PathSet_GetPath", MemberParameters = new object[]
	{
		typeof(ref nativefiledialog.nfdpathset_t),
		typeof(IntPtr)
	}, ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	[PreserveSig]
	private static extern IntPtr INTERNAL_NFD_PathSet_GetPath(ref nativefiledialog.nfdpathset_t pathset, IntPtr index);

	// Token: 0x06000FD9 RID: 4057 RVA: 0x00024A70 File Offset: 0x00022C70
	[global::Cpp2ILInjected.Token(Token = "0x6001122")]
	[global::Cpp2ILInjected.Address(RVA = "0xA680BC", Offset = "0xA680BC", Length = "0x14")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(nativefiledialog), Member = "INTERNAL_NFD_PathSet_GetPath", MemberParameters = new object[]
	{
		typeof(ref nativefiledialog.nfdpathset_t),
		typeof(IntPtr)
	}, ReturnType = typeof(IntPtr))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(nativefiledialog), Member = "UTF8_ToManaged", MemberParameters = new object[]
	{
		typeof(IntPtr),
		typeof(bool)
	}, ReturnType = typeof(string))]
	public static string NFD_PathSet_GetPath(ref nativefiledialog.nfdpathset_t pathset, IntPtr index)
	{
		throw null;
	}

	// Token: 0x06000FDA RID: 4058
	[global::Cpp2ILInjected.Token(Token = "0x6001123")]
	[global::Cpp2ILInjected.Address(RVA = "0xA680D0", Offset = "0xA680D0", Length = "0x7C")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	[PreserveSig]
	public static extern void NFD_PathSet_Free(ref nativefiledialog.nfdpathset_t pathset);

	// Token: 0x04001B55 RID: 6997
	[global::Cpp2ILInjected.Token(Token = "0x40020E2")]
	private const string nativeLibName = "nfd";

	// Token: 0x02000811 RID: 2065
	[global::Cpp2ILInjected.Token(Token = "0x20002E4")]
	public enum nfdresult_t
	{
		// Token: 0x04007D4C RID: 32076
		[global::Cpp2ILInjected.Token(Token = "0x40020E4")]
		NFD_ERROR,
		// Token: 0x04007D4D RID: 32077
		[global::Cpp2ILInjected.Token(Token = "0x40020E5")]
		NFD_OKAY,
		// Token: 0x04007D4E RID: 32078
		[global::Cpp2ILInjected.Token(Token = "0x40020E6")]
		NFD_CANCEL
	}

	// Token: 0x02000812 RID: 2066
	[global::Cpp2ILInjected.Token(Token = "0x20002E5")]
	public struct nfdpathset_t
	{
		// Token: 0x04007D4F RID: 32079
		[global::Cpp2ILInjected.Token(Token = "0x40020E7")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private IntPtr buf;

		// Token: 0x04007D50 RID: 32080
		[global::Cpp2ILInjected.Token(Token = "0x40020E8")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
		private IntPtr indices;

		// Token: 0x04007D51 RID: 32081
		[global::Cpp2ILInjected.Token(Token = "0x40020E9")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private IntPtr count;
	}
}