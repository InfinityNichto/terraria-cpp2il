﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

// Token: 0x02000034 RID: 52
[global::Cpp2ILInjected.Token(Token = "0x2000054")]
public class CSVReader
{
	// Token: 0x06000139 RID: 313 RVA: 0x00021F23 File Offset: 0x00020123
	[global::Cpp2ILInjected.Token(Token = "0x60001C3")]
	[global::Cpp2ILInjected.Address(RVA = "0x707FB8", Offset = "0x707FB8", Length = "0x60")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CSVReader), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CSVReader), Member = "Begin", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
	public static CSVReader Load(string file)
	{
		throw null;
	}

	// Token: 0x0600013A RID: 314 RVA: 0x00021F26 File Offset: 0x00020126
	[global::Cpp2ILInjected.Token(Token = "0x60001C4")]
	[global::Cpp2ILInjected.Address(RVA = "0x708178", Offset = "0x708178", Length = "0x74")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CSVReader), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(File), Member = "ReadAllBytes", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(byte[]))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CSVReader), Member = "ReadLine", ReturnType = typeof(string[]))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
	public static CSVReader LoadFromFile(string file)
	{
		throw null;
	}

	// Token: 0x0600013B RID: 315 RVA: 0x00021F29 File Offset: 0x00020129
	[global::Cpp2ILInjected.Token(Token = "0x60001C5")]
	[global::Cpp2ILInjected.Address(RVA = "0x70820C", Offset = "0x70820C", Length = "0x68")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CSVReader), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CSVReader), Member = "ReadLine", ReturnType = typeof(string[]))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
	public static CSVReader Load(byte[] fileData)
	{
		throw null;
	}

	// Token: 0x0600013C RID: 316 RVA: 0x00021F2C File Offset: 0x0002012C
	[global::Cpp2ILInjected.Token(Token = "0x60001C6")]
	[global::Cpp2ILInjected.Address(RVA = "0x708018", Offset = "0x708018", Length = "0x7C")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CSVReader), Member = "Load", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(CSVReader))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CSVReader), Member = "LoadFromFile", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(CSVReader))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CSVReader), Member = "Load", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(CSVReader))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
	public CSVReader()
	{
		throw null;
	}

	// Token: 0x0600013D RID: 317 RVA: 0x00021F2F File Offset: 0x0002012F
	[global::Cpp2ILInjected.Token(Token = "0x60001C7")]
	[global::Cpp2ILInjected.Address(RVA = "0x708094", Offset = "0x708094", Length = "0xE4")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CSVReader), Member = "Load", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(CSVReader))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Resources), Member = "Load", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(global::UnityEngine.Object))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::UnityEngine.Object), Member = "op_Inequality", MemberParameters = new object[]
	{
		typeof(global::UnityEngine.Object),
		typeof(global::UnityEngine.Object)
	}, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TextAsset), Member = "get_bytes", ReturnType = typeof(byte[]))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CSVReader), Member = "ReadLine", ReturnType = typeof(string[]))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
	public void Begin(string file)
	{
		throw null;
	}

	// Token: 0x0600013E RID: 318 RVA: 0x00021F32 File Offset: 0x00020132
	[global::Cpp2ILInjected.Token(Token = "0x60001C8")]
	[global::Cpp2ILInjected.Address(RVA = "0x7081EC", Offset = "0x7081EC", Length = "0x20")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CSVReader), Member = "ReadLine", ReturnType = typeof(string[]))]
	public void Begin(byte[] fileData)
	{
		throw null;
	}

	// Token: 0x0600013F RID: 319 RVA: 0x00021F35 File Offset: 0x00020135
	[global::Cpp2ILInjected.Token(Token = "0x60001C9")]
	[global::Cpp2ILInjected.Address(RVA = "0x7083C0", Offset = "0x7083C0", Length = "0x8")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "Finalize", ReturnType = typeof(void))]
	protected override void Finalize()
	{
		throw null;
	}

	// Token: 0x06000140 RID: 320 RVA: 0x00021F38 File Offset: 0x00020138
	[global::Cpp2ILInjected.Token(Token = "0x60001CA")]
	[global::Cpp2ILInjected.Address(RVA = "0x7083C8", Offset = "0x7083C8", Length = "0x12C")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CSVReader), Member = "ReadLine", ReturnType = typeof(string[]))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = "set_Length", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Encoding), Member = "get_UTF8", ReturnType = typeof(Encoding))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
	public string GetRawLine()
	{
		throw null;
	}

	// Token: 0x06000141 RID: 321 RVA: 0x00021F3B File Offset: 0x0002013B
	[global::Cpp2ILInjected.Token(Token = "0x60001CB")]
	[global::Cpp2ILInjected.Address(RVA = "0x708274", Offset = "0x708274", Length = "0x14C")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CSVReader), Member = "LoadFromFile", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(CSVReader))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CSVReader), Member = "Load", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(CSVReader))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CSVReader), Member = "Begin", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CSVReader), Member = "Begin", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CSVReader), Member = "GetRawLine", ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CSVReader), Member = "DecodeLine", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string[]))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "IndexOf", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Replace", MemberParameters = new object[]
	{
		typeof(string),
		typeof(string)
	}, ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
	public string[] ReadLine()
	{
		throw null;
	}

	// Token: 0x06000142 RID: 322 RVA: 0x00021F3E File Offset: 0x0002013E
	[global::Cpp2ILInjected.Token(Token = "0x60001CC")]
	[global::Cpp2ILInjected.Address(RVA = "0x7084F4", Offset = "0x7084F4", Length = "0x540")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CSVReader), Member = "ReadLine", ReturnType = typeof(string[]))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new object[]
	{
		typeof(Array),
		typeof(int),
		typeof(int)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(char))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "IndexOf", MemberParameters = new object[]
	{
		typeof(char),
		typeof(int)
	}, ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Substring", MemberParameters = new object[]
	{
		typeof(int),
		typeof(int)
	}, ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Substring", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
	{
		typeof(string),
		typeof(string),
		typeof(string),
		typeof(string)
	}, ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "ToArray", ReturnType = "T[]")]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 22)]
	private string[] DecodeLine(string line)
	{
		throw null;
	}

	// Token: 0x06000143 RID: 323 RVA: 0x00021F41 File Offset: 0x00020141
	// Note: this type is marked as 'beforefieldinit'.
	[global::Cpp2ILInjected.Token(Token = "0x60001CD")]
	[global::Cpp2ILInjected.Address(RVA = "0x708A34", Offset = "0x708A34", Length = "0x70")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
	static CSVReader()
	{
		throw null;
	}

	// Token: 0x040000DB RID: 219
	[global::Cpp2ILInjected.Token(Token = "0x4000134")]
	private static StringBuilder builder;

	// Token: 0x040000DC RID: 220
	[global::Cpp2ILInjected.Token(Token = "0x4000135")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
	private byte[] _fileData;

	// Token: 0x040000DD RID: 221
	[global::Cpp2ILInjected.Token(Token = "0x4000136")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
	private int _fileOffset;

	// Token: 0x040000DE RID: 222
	[global::Cpp2ILInjected.Token(Token = "0x4000137")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	private string _filename;

	// Token: 0x040000DF RID: 223
	[global::Cpp2ILInjected.Token(Token = "0x4000138")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
	private List<string> _tokens;

	// Token: 0x040000E0 RID: 224
	[global::Cpp2ILInjected.Token(Token = "0x4000139")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
	public string[] Headers;
}