using System;
using System.Xml.Schema;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Xml
{
	// Token: 0x02000067 RID: 103
	[global::Cpp2ILInjected.Token(Token = "0x2000086")]
	public class NameTable : XmlNameTable
	{
		// Token: 0x060005B9 RID: 1465 RVA: 0x00003FDA File Offset: 0x000021DA
		[global::Cpp2ILInjected.Token(Token = "0x600063B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D93404", Offset = "0x1D93404", Length = "0x70")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(XmlNodeType),
			typeof(XmlParserContext)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(XmlParserContext)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlImplementation), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlSchemaSet), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Converters.XmlNodeConverter", Member = "WriteJson", MemberParameters = new object[]
		{
			"Newtonsoft.Json.JsonWriter",
			typeof(object),
			"Newtonsoft.Json.JsonSerializer"
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Converters.XmlNodeConverter", Member = "ReadJson", MemberParameters = new object[]
		{
			"Newtonsoft.Json.JsonReader",
			typeof(Type),
			typeof(object),
			"Newtonsoft.Json.JsonSerializer"
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 7)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlNameTable), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Environment), Member = "get_TickCount", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public NameTable()
		{
			throw null;
		}

		// Token: 0x060005BA RID: 1466 RVA: 0x00003FDD File Offset: 0x000021DD
		[global::Cpp2ILInjected.Token(Token = "0x600063C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D9AFBC", Offset = "0x1D9AFBC", Length = "0x15C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Equals", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public override string Add(string key)
		{
			throw null;
		}

		// Token: 0x060005BB RID: 1467 RVA: 0x00003FE0 File Offset: 0x000021E0
		[global::Cpp2ILInjected.Token(Token = "0x600063D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D9B1F8", Offset = "0x1D9B1F8", Length = "0x144")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NameTable), Member = "TextEquals", MemberParameters = new object[]
		{
			typeof(string),
			typeof(char[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "CreateString", MemberParameters = new object[]
		{
			typeof(char[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NameTable), Member = "AddEntry", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override string Add(char[] key, int start, int len)
		{
			throw null;
		}

		// Token: 0x060005BC RID: 1468 RVA: 0x00003FE3 File Offset: 0x000021E3
		[global::Cpp2ILInjected.Token(Token = "0x600063E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D9B3BC", Offset = "0x1D9B3BC", Length = "0x148")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Equals", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public override string Get(string value)
		{
			throw null;
		}

		// Token: 0x060005BD RID: 1469 RVA: 0x00003FE6 File Offset: 0x000021E6
		[global::Cpp2ILInjected.Token(Token = "0x600063F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D9B118", Offset = "0x1D9B118", Length = "0xE0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NameTable), Member = "Add", MemberParameters = new object[]
		{
			typeof(char[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NameTable), Member = "Grow", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		private string AddEntry(string str, int hashCode)
		{
			throw null;
		}

		// Token: 0x060005BE RID: 1470 RVA: 0x00003FE9 File Offset: 0x000021E9
		[global::Cpp2ILInjected.Token(Token = "0x6000640")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D9B544", Offset = "0x1D9B544", Length = "0xF0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NameTable), Member = "AddEntry", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		private void Grow()
		{
			throw null;
		}

		// Token: 0x060005BF RID: 1471 RVA: 0x00003FEC File Offset: 0x000021EC
		[global::Cpp2ILInjected.Token(Token = "0x6000641")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D9B33C", Offset = "0x1D9B33C", Length = "0x80")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NameTable), Member = "Add", MemberParameters = new object[]
		{
			typeof(char[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(char))]
		private static bool TextEquals(string str1, char[] str2, int str2Start, int str2Length)
		{
			throw null;
		}

		// Token: 0x04000204 RID: 516
		[global::Cpp2ILInjected.Token(Token = "0x4000301")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private NameTable.Entry[] entries;

		// Token: 0x04000205 RID: 517
		[global::Cpp2ILInjected.Token(Token = "0x4000302")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private int count;

		// Token: 0x04000206 RID: 518
		[global::Cpp2ILInjected.Token(Token = "0x4000303")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C")]
		private int mask;

		// Token: 0x04000207 RID: 519
		[global::Cpp2ILInjected.Token(Token = "0x4000304")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private int hashCodeRandomizer;

		// Token: 0x02000165 RID: 357
		[global::Cpp2ILInjected.Token(Token = "0x2000087")]
		private class Entry
		{
			// Token: 0x06000CB5 RID: 3253 RVA: 0x00005381 File Offset: 0x00003581
			[global::Cpp2ILInjected.Token(Token = "0x6000642")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D9B504", Offset = "0x1D9B504", Length = "0x40")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			internal Entry(string str, int hashCode, NameTable.Entry next)
			{
				throw null;
			}

			// Token: 0x040005EB RID: 1515
			[global::Cpp2ILInjected.Token(Token = "0x4000305")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			internal string str;

			// Token: 0x040005EC RID: 1516
			[global::Cpp2ILInjected.Token(Token = "0x4000306")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
			internal int hashCode;

			// Token: 0x040005ED RID: 1517
			[global::Cpp2ILInjected.Token(Token = "0x4000307")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
			internal NameTable.Entry next;
		}
	}
}
