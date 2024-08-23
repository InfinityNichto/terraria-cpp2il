using System;
using System.Text;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Xml
{
	// Token: 0x02000075 RID: 117
	[global::Cpp2ILInjected.Token(Token = "0x200009C")]
	internal class UTF16Decoder : Decoder
	{
		// Token: 0x060006BD RID: 1725 RVA: 0x000042E6 File Offset: 0x000024E6
		[global::Cpp2ILInjected.Token(Token = "0x6000746")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DAD84C", Offset = "0x1DAD84C", Length = "0x30")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "SetupEncoding", MemberParameters = new object[] { typeof(Encoding) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Decoder), Member = ".ctor", ReturnType = typeof(void))]
		public UTF16Decoder(bool bigEndian)
		{
			throw null;
		}

		// Token: 0x060006BE RID: 1726 RVA: 0x000042E9 File Offset: 0x000024E9
		[global::Cpp2ILInjected.Token(Token = "0x6000747")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DAD87C", Offset = "0x1DAD87C", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override int GetCharCount(byte[] bytes, int index, int count)
		{
			throw null;
		}

		// Token: 0x060006BF RID: 1727 RVA: 0x000042EC File Offset: 0x000024EC
		[global::Cpp2ILInjected.Token(Token = "0x6000748")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DAD88C", Offset = "0x1DAD88C", Length = "0xD0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Res), Member = "GetString", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object[])
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		public override int GetCharCount(byte[] bytes, int index, int count, bool flush)
		{
			throw null;
		}

		// Token: 0x060006C0 RID: 1728 RVA: 0x000042EF File Offset: 0x000024EF
		[global::Cpp2ILInjected.Token(Token = "0x6000749")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DAD95C", Offset = "0x1DAD95C", Length = "0x1A4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsInvalidInstructions]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Buffer), Member = "BlockCopy", MemberParameters = new object[]
		{
			typeof(Array),
			typeof(int),
			typeof(Array),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public override int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex)
		{
			throw null;
		}

		// Token: 0x060006C1 RID: 1729 RVA: 0x000042F2 File Offset: 0x000024F2
		[global::Cpp2ILInjected.Token(Token = "0x600074A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DADB00", Offset = "0x1DADB00", Length = "0x208")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsInvalidInstructions]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Buffer), Member = "BlockCopy", MemberParameters = new object[]
		{
			typeof(Array),
			typeof(int),
			typeof(Array),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public override void Convert(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex, int charCount, bool flush, out int bytesUsed, out int charsUsed, out bool completed)
		{
			throw null;
		}

		// Token: 0x0400024F RID: 591
		[global::Cpp2ILInjected.Token(Token = "0x40003B7")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private bool bigEndian;

		// Token: 0x04000250 RID: 592
		[global::Cpp2ILInjected.Token(Token = "0x40003B8")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x24")]
		private int lastByte;
	}
}
