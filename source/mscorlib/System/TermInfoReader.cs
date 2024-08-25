using System;
using System.IO;
using System.Text;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System
{
	[global::Cpp2ILInjected.Token(Token = "0x2000193")]
	internal class TermInfoReader
	{
		[global::Cpp2ILInjected.Token(Token = "0x6000FB5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C8398C", Offset = "0x1C8398C", Length = "0x2AC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TermInfoDriver), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.IO.File), Member = "OpenRead", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(global::System.IO.FileStream))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.TermInfoReader), Member = "ReadHeader", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(ref int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.TermInfoReader), Member = "GetString", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Exception), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 21)]
		public TermInfoReader(string term, string filename)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000FB6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C83C38", Offset = "0x1C83C38", Length = "0x98")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TermInfoDriver), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.TermInfoReader), Member = "ReadHeader", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(ref int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.TermInfoReader), Member = "GetString", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public TermInfoReader(string term, byte[] buffer)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000FB7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C89468", Offset = "0x1C89468", Length = "0xA8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TermInfoReader), Member = "ReadHeader", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(ref int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Format", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Exception), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		private void DetermineVersion(short magic)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000FB8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C89354", Offset = "0x1C89354", Length = "0xE8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TermInfoReader), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TermInfoReader), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(byte[])
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.TermInfoReader), Member = "DetermineVersion", MemberParameters = new object[] { typeof(short) }, ReturnType = typeof(void))]
		private void ReadHeader(byte[] buffer, ref int position)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000FB9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C8943C", Offset = "0x1C8943C", Length = "0x2C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.TermInfoReader), Member = "GetString", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int)
		}, ReturnType = typeof(string))]
		private void ReadNames(byte[] buffer, ref int position)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000FBA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C84504", Offset = "0x1C84504", Length = "0x70")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TermInfoDriver), Member = "Init", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TermInfoDriver), Member = "CheckWindowDimensions", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		public int Get(global::System.TermInfoNumbers number)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000FBB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C8447C", Offset = "0x1C8447C", Length = "0x88")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TermInfoDriver), Member = "Init", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 14)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.TermInfoReader), Member = "GetString", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int)
		}, ReturnType = typeof(string))]
		public string Get(global::System.TermInfoStrings tstr)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000FBC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C88154", Offset = "0x1C88154", Length = "0x88")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TermInfoDriver), Member = "AddStringMapping", MemberParameters = new object[] { typeof(global::System.TermInfoStrings) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.TermInfoReader), Member = "GetStringBytes", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int)
		}, ReturnType = typeof(byte[]))]
		public byte[] GetStringBytes(global::System.TermInfoStrings tstr)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000FBD")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C89510", Offset = "0x1C89510", Length = "0x24")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private short GetInt16(byte[] buffer, int offset)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000FBE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C89534", Offset = "0x1C89534", Length = "0x6C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TermInfoReader), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TermInfoReader), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(byte[])
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TermInfoReader), Member = "ReadNames", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(ref int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TermInfoReader), Member = "Get", MemberParameters = new object[] { typeof(global::System.TermInfoStrings) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Text.Encoding), Member = "get_ASCII", ReturnType = typeof(global::System.Text.Encoding))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		private string GetString(byte[] buffer, int offset)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000FBF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C895A0", Offset = "0x1C895A0", Length = "0xA4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TermInfoReader), Member = "GetStringBytes", MemberParameters = new object[] { typeof(global::System.TermInfoStrings) }, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Buffer), Member = "InternalBlockCopy", MemberParameters = new object[]
		{
			typeof(global::System.Array),
			typeof(int),
			typeof(global::System.Array),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private byte[] GetStringBytes(byte[] buffer, int offset)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x40006EE")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private int boolSize;

		[global::Cpp2ILInjected.Token(Token = "0x40006EF")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
		private int numSize;

		[global::Cpp2ILInjected.Token(Token = "0x40006F0")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private int strOffsets;

		[global::Cpp2ILInjected.Token(Token = "0x40006F1")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private byte[] buffer;

		[global::Cpp2ILInjected.Token(Token = "0x40006F2")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private int booleansOffset;

		[global::Cpp2ILInjected.Token(Token = "0x40006F3")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x2C")]
		private int intOffset;
	}
}
