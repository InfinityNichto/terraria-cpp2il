using System;
using System.IO;
using System.Text;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System
{
	// Token: 0x0200014A RID: 330
	[global::Cpp2ILInjected.Token(Token = "0x2000193")]
	internal class TermInfoReader
	{
		// Token: 0x06000EC0 RID: 3776 RVA: 0x00016ECE File Offset: 0x000150CE
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

		// Token: 0x06000EC1 RID: 3777 RVA: 0x00016ED1 File Offset: 0x000150D1
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

		// Token: 0x06000EC2 RID: 3778 RVA: 0x00016ED4 File Offset: 0x000150D4
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

		// Token: 0x06000EC3 RID: 3779 RVA: 0x00016ED7 File Offset: 0x000150D7
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

		// Token: 0x06000EC4 RID: 3780 RVA: 0x00016EDA File Offset: 0x000150DA
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

		// Token: 0x06000EC5 RID: 3781 RVA: 0x00016EDD File Offset: 0x000150DD
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

		// Token: 0x06000EC6 RID: 3782 RVA: 0x00016EE0 File Offset: 0x000150E0
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

		// Token: 0x06000EC7 RID: 3783 RVA: 0x00016EE3 File Offset: 0x000150E3
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

		// Token: 0x06000EC8 RID: 3784 RVA: 0x00016EE6 File Offset: 0x000150E6
		[global::Cpp2ILInjected.Token(Token = "0x6000FBD")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C89510", Offset = "0x1C89510", Length = "0x24")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private short GetInt16(byte[] buffer, int offset)
		{
			throw null;
		}

		// Token: 0x06000EC9 RID: 3785 RVA: 0x00016EE9 File Offset: 0x000150E9
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

		// Token: 0x06000ECA RID: 3786 RVA: 0x00016EEC File Offset: 0x000150EC
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

		// Token: 0x04000519 RID: 1305
		[global::Cpp2ILInjected.Token(Token = "0x40006EE")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private int boolSize;

		// Token: 0x0400051A RID: 1306
		[global::Cpp2ILInjected.Token(Token = "0x40006EF")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
		private int numSize;

		// Token: 0x0400051B RID: 1307
		[global::Cpp2ILInjected.Token(Token = "0x40006F0")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private int strOffsets;

		// Token: 0x0400051C RID: 1308
		[global::Cpp2ILInjected.Token(Token = "0x40006F1")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private byte[] buffer;

		// Token: 0x0400051D RID: 1309
		[global::Cpp2ILInjected.Token(Token = "0x40006F2")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private int booleansOffset;

		// Token: 0x0400051E RID: 1310
		[global::Cpp2ILInjected.Token(Token = "0x40006F3")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x2C")]
		private int intOffset;
	}
}
