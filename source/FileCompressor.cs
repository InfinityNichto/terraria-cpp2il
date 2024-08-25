using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Ionic.Zlib;
using UnityEngine;

[global::Cpp2ILInjected.Token(Token = "0x200006E")]
public static class FileCompressor
{
	[global::Cpp2ILInjected.Token(Token = "0x6000268")]
	[global::Cpp2ILInjected.Address(RVA = "0x70F514", Offset = "0x70F514", Length = "0xAC")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FileCompressor), Member = "CompressFile", MemberParameters = new object[]
	{
		typeof(string),
		typeof(byte[]),
		typeof(ref int)
	}, ReturnType = typeof(byte[]))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FileCompressor), Member = "DecompressFile", MemberParameters = new object[]
	{
		typeof(string),
		typeof(byte[])
	}, ReturnType = typeof(byte[]))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "EndsWith", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
	private static bool CanCompress(string filename)
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000269")]
	[global::Cpp2ILInjected.Address(RVA = "0x70F5C0", Offset = "0x70F5C0", Length = "0xBC")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FileCompressor), Member = "DecompressFile", MemberParameters = new object[]
	{
		typeof(string),
		typeof(byte[])
	}, ReturnType = typeof(byte[]))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BitConverter), Member = "ToInt32", MemberParameters = new object[]
	{
		typeof(byte[]),
		typeof(int)
	}, ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
	private static bool HasCompressionHeader(byte[] inputData, out int decompressedLength)
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x600026A")]
	[global::Cpp2ILInjected.Address(RVA = "0x70F67C", Offset = "0x70F67C", Length = "0x194")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FileCompressor), Member = "DecompressFile", MemberParameters = new object[]
	{
		typeof(string),
		typeof(byte[])
	}, ReturnType = typeof(byte[]))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZlibCodec), Member = ".ctor", MemberParameters = new object[] { typeof(CompressionMode) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZlibCodec), Member = "Inflate", MemberParameters = new object[] { typeof(FlushType) }, ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new object[]
	{
		typeof(Array),
		typeof(Array),
		typeof(int)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 18)]
	private static byte[] Decompress(byte[] inputData, int outputSize)
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x600026B")]
	[global::Cpp2ILInjected.Address(RVA = "0x70F810", Offset = "0x70F810", Length = "0x168")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FileCompressor), Member = "CompressFile", MemberParameters = new object[]
	{
		typeof(string),
		typeof(byte[]),
		typeof(ref int)
	}, ReturnType = typeof(byte[]))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZlibCodec), Member = ".ctor", MemberParameters = new object[] { typeof(CompressionMode) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZlibCodec), Member = "Deflate", MemberParameters = new object[] { typeof(FlushType) }, ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BitConverter), Member = "GetBytes", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(byte[]))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new object[]
	{
		typeof(Array),
		typeof(int),
		typeof(Array),
		typeof(int),
		typeof(int)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
	private static byte[] Compress(byte[] inputData, int fileLength)
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x600026C")]
	[global::Cpp2ILInjected.Address(RVA = "0x70F978", Offset = "0x70F978", Length = "0xC8")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FileCompressor), Member = "CanCompress", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FileCompressor), Member = "Compress", MemberParameters = new object[]
	{
		typeof(byte[]),
		typeof(int)
	}, ReturnType = typeof(byte[]))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
	{
		typeof(string),
		typeof(string)
	}, ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
	public static byte[] CompressFile(string filename, byte[] inputFile, ref int fileLength)
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x600026D")]
	[global::Cpp2ILInjected.Address(RVA = "0x70FA40", Offset = "0x70FA40", Length = "0x48")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FileCompressor), Member = "CanCompress", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FileCompressor), Member = "HasCompressionHeader", MemberParameters = new object[]
	{
		typeof(byte[]),
		typeof(ref int)
	}, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FileCompressor), Member = "Decompress", MemberParameters = new object[]
	{
		typeof(byte[]),
		typeof(int)
	}, ReturnType = typeof(byte[]))]
	public static byte[] DecompressFile(string filename, byte[] inputFile)
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x400021A")]
	public static bool Disable;
}
