using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Xml.Schema
{
	// Token: 0x02000130 RID: 304
	[global::Cpp2ILInjected.Token(Token = "0x2000164")]
	internal class XmlUntypedConverter : XmlListConverter
	{
		// Token: 0x06000B83 RID: 2947 RVA: 0x00004FF7 File Offset: 0x000031F7
		[global::Cpp2ILInjected.Token(Token = "0x6000C1E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DE0B2C", Offset = "0x1DE0B2C", Length = "0x90")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlUntypedConverter), Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		protected XmlUntypedConverter()
		{
			throw null;
		}

		// Token: 0x06000B84 RID: 2948 RVA: 0x00004FFA File Offset: 0x000031FA
		[global::Cpp2ILInjected.Token(Token = "0x6000C1F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DE0C24", Offset = "0x1DE0C24", Length = "0x98")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlUntypedConverter), Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlListConverter), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(XmlBaseConverter),
			typeof(Type)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		protected XmlUntypedConverter(XmlUntypedConverter atomicConverter, bool allowListToList)
		{
			throw null;
		}

		// Token: 0x06000B85 RID: 2949 RVA: 0x00004FFD File Offset: 0x000031FD
		[global::Cpp2ILInjected.Token(Token = "0x6000C20")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DE0D34", Offset = "0x1DE0D34", Length = "0xA4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlConvert), Member = "ToBoolean", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public override bool ToBoolean(string value)
		{
			throw null;
		}

		// Token: 0x06000B86 RID: 2950 RVA: 0x00005000 File Offset: 0x00003200
		[global::Cpp2ILInjected.Token(Token = "0x6000C21")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DE0DD8", Offset = "0x1DE0DD8", Length = "0x1C4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(Type)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlConvert), Member = "ToBoolean", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlUntypedConverter), Member = "ChangeTypeWildcardDestination", MemberParameters = new object[]
		{
			typeof(object),
			typeof(Type),
			typeof(IXmlNamespaceResolver)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 16)]
		public override bool ToBoolean(object value)
		{
			throw null;
		}

		// Token: 0x06000B87 RID: 2951 RVA: 0x00005003 File Offset: 0x00003203
		[global::Cpp2ILInjected.Token(Token = "0x6000C22")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DE10D4", Offset = "0x1DE10D4", Length = "0xA4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlBaseConverter), Member = "UntypedAtomicToDateTime", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(DateTime))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public override DateTime ToDateTime(string value)
		{
			throw null;
		}

		// Token: 0x06000B88 RID: 2952 RVA: 0x00005006 File Offset: 0x00003206
		[global::Cpp2ILInjected.Token(Token = "0x6000C23")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DE1178", Offset = "0x1DE1178", Length = "0x1AC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(Type)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlBaseConverter), Member = "UntypedAtomicToDateTime", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(DateTime))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlUntypedConverter), Member = "ChangeTypeWildcardDestination", MemberParameters = new object[]
		{
			typeof(object),
			typeof(Type),
			typeof(IXmlNamespaceResolver)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 14)]
		public override DateTime ToDateTime(object value)
		{
			throw null;
		}

		// Token: 0x06000B89 RID: 2953 RVA: 0x00005009 File Offset: 0x00003209
		[global::Cpp2ILInjected.Token(Token = "0x6000C24")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DE1324", Offset = "0x1DE1324", Length = "0xA4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlBaseConverter), Member = "UntypedAtomicToDateTimeOffset", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(DateTimeOffset))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public override DateTimeOffset ToDateTimeOffset(string value)
		{
			throw null;
		}

		// Token: 0x06000B8A RID: 2954 RVA: 0x0000500C File Offset: 0x0000320C
		[global::Cpp2ILInjected.Token(Token = "0x6000C25")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DE13C8", Offset = "0x1DE13C8", Length = "0x1AC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(Type)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlBaseConverter), Member = "UntypedAtomicToDateTimeOffset", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(DateTimeOffset))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlUntypedConverter), Member = "ChangeTypeWildcardDestination", MemberParameters = new object[]
		{
			typeof(object),
			typeof(Type),
			typeof(IXmlNamespaceResolver)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 14)]
		public override DateTimeOffset ToDateTimeOffset(object value)
		{
			throw null;
		}

		// Token: 0x06000B8B RID: 2955 RVA: 0x0000500F File Offset: 0x0000320F
		[global::Cpp2ILInjected.Token(Token = "0x6000C26")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DE1574", Offset = "0x1DE1574", Length = "0xA4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlConvert), Member = "ToDecimal", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(decimal))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public override decimal ToDecimal(string value)
		{
			throw null;
		}

		// Token: 0x06000B8C RID: 2956 RVA: 0x00005012 File Offset: 0x00003212
		[global::Cpp2ILInjected.Token(Token = "0x6000C27")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DE1618", Offset = "0x1DE1618", Length = "0x1C4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(Type)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlConvert), Member = "ToDecimal", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(decimal))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlUntypedConverter), Member = "ChangeTypeWildcardDestination", MemberParameters = new object[]
		{
			typeof(object),
			typeof(Type),
			typeof(IXmlNamespaceResolver)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 16)]
		public override decimal ToDecimal(object value)
		{
			throw null;
		}

		// Token: 0x06000B8D RID: 2957 RVA: 0x00005015 File Offset: 0x00003215
		[global::Cpp2ILInjected.Token(Token = "0x6000C28")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DE17DC", Offset = "0x1DE17DC", Length = "0xA4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlConvert), Member = "ToDouble", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(double))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public override double ToDouble(string value)
		{
			throw null;
		}

		// Token: 0x06000B8E RID: 2958 RVA: 0x00005018 File Offset: 0x00003218
		[global::Cpp2ILInjected.Token(Token = "0x6000C29")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DE1880", Offset = "0x1DE1880", Length = "0x1C4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(Type)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlConvert), Member = "ToDouble", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(double))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlUntypedConverter), Member = "ChangeTypeWildcardDestination", MemberParameters = new object[]
		{
			typeof(object),
			typeof(Type),
			typeof(IXmlNamespaceResolver)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 16)]
		public override double ToDouble(object value)
		{
			throw null;
		}

		// Token: 0x06000B8F RID: 2959 RVA: 0x0000501B File Offset: 0x0000321B
		[global::Cpp2ILInjected.Token(Token = "0x6000C2A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DE1A44", Offset = "0x1DE1A44", Length = "0xA4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlConvert), Member = "ToInt32", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public override int ToInt32(string value)
		{
			throw null;
		}

		// Token: 0x06000B90 RID: 2960 RVA: 0x0000501E File Offset: 0x0000321E
		[global::Cpp2ILInjected.Token(Token = "0x6000C2B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DE1AE8", Offset = "0x1DE1AE8", Length = "0x1C4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(Type)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlConvert), Member = "ToInt32", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlUntypedConverter), Member = "ChangeTypeWildcardDestination", MemberParameters = new object[]
		{
			typeof(object),
			typeof(Type),
			typeof(IXmlNamespaceResolver)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 16)]
		public override int ToInt32(object value)
		{
			throw null;
		}

		// Token: 0x06000B91 RID: 2961 RVA: 0x00005021 File Offset: 0x00003221
		[global::Cpp2ILInjected.Token(Token = "0x6000C2C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DE1CAC", Offset = "0x1DE1CAC", Length = "0xA4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlConvert), Member = "ToInt64", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(long))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public override long ToInt64(string value)
		{
			throw null;
		}

		// Token: 0x06000B92 RID: 2962 RVA: 0x00005024 File Offset: 0x00003224
		[global::Cpp2ILInjected.Token(Token = "0x6000C2D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DE1D50", Offset = "0x1DE1D50", Length = "0x1C4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(Type)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlConvert), Member = "ToInt64", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(long))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlUntypedConverter), Member = "ChangeTypeWildcardDestination", MemberParameters = new object[]
		{
			typeof(object),
			typeof(Type),
			typeof(IXmlNamespaceResolver)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 16)]
		public override long ToInt64(object value)
		{
			throw null;
		}

		// Token: 0x06000B93 RID: 2963 RVA: 0x00005027 File Offset: 0x00003227
		[global::Cpp2ILInjected.Token(Token = "0x6000C2E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DE1F14", Offset = "0x1DE1F14", Length = "0xA4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlConvert), Member = "ToSingle", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public override float ToSingle(string value)
		{
			throw null;
		}

		// Token: 0x06000B94 RID: 2964 RVA: 0x0000502A File Offset: 0x0000322A
		[global::Cpp2ILInjected.Token(Token = "0x6000C2F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DE1FB8", Offset = "0x1DE1FB8", Length = "0x1C4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(Type)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlConvert), Member = "ToSingle", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlUntypedConverter), Member = "ChangeTypeWildcardDestination", MemberParameters = new object[]
		{
			typeof(object),
			typeof(Type),
			typeof(IXmlNamespaceResolver)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 16)]
		public override float ToSingle(object value)
		{
			throw null;
		}

		// Token: 0x06000B95 RID: 2965 RVA: 0x0000502D File Offset: 0x0000322D
		[global::Cpp2ILInjected.Token(Token = "0x6000C30")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DE217C", Offset = "0x1DE217C", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlConvert), Member = "ToString", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public override string ToString(bool value)
		{
			throw null;
		}

		// Token: 0x06000B96 RID: 2966 RVA: 0x00005030 File Offset: 0x00003230
		[global::Cpp2ILInjected.Token(Token = "0x6000C31")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DE21D4", Offset = "0x1DE21D4", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlBaseConverter), Member = "DateTimeToString", MemberParameters = new object[] { typeof(DateTime) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public override string ToString(DateTime value)
		{
			throw null;
		}

		// Token: 0x06000B97 RID: 2967 RVA: 0x00005033 File Offset: 0x00003233
		[global::Cpp2ILInjected.Token(Token = "0x6000C32")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DE222C", Offset = "0x1DE222C", Length = "0x68")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlBaseConverter), Member = "DateTimeOffsetToString", MemberParameters = new object[] { typeof(DateTimeOffset) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public override string ToString(DateTimeOffset value)
		{
			throw null;
		}

		// Token: 0x06000B98 RID: 2968 RVA: 0x00005036 File Offset: 0x00003236
		[global::Cpp2ILInjected.Token(Token = "0x6000C33")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DE2294", Offset = "0x1DE2294", Length = "0x68")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlConvert), Member = "ToString", MemberParameters = new object[] { typeof(decimal) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public override string ToString(decimal value)
		{
			throw null;
		}

		// Token: 0x06000B99 RID: 2969 RVA: 0x00005039 File Offset: 0x00003239
		[global::Cpp2ILInjected.Token(Token = "0x6000C34")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DE22FC", Offset = "0x1DE22FC", Length = "0x60")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlConvert), Member = "ToString", MemberParameters = new object[] { typeof(double) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public override string ToString(double value)
		{
			throw null;
		}

		// Token: 0x06000B9A RID: 2970 RVA: 0x0000503C File Offset: 0x0000323C
		[global::Cpp2ILInjected.Token(Token = "0x6000C35")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DE235C", Offset = "0x1DE235C", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlConvert), Member = "ToString", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public override string ToString(int value)
		{
			throw null;
		}

		// Token: 0x06000B9B RID: 2971 RVA: 0x0000503F File Offset: 0x0000323F
		[global::Cpp2ILInjected.Token(Token = "0x6000C36")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DE23B4", Offset = "0x1DE23B4", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlConvert), Member = "ToString", MemberParameters = new object[] { typeof(long) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public override string ToString(long value)
		{
			throw null;
		}

		// Token: 0x06000B9C RID: 2972 RVA: 0x00005042 File Offset: 0x00003242
		[global::Cpp2ILInjected.Token(Token = "0x6000C37")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DE240C", Offset = "0x1DE240C", Length = "0x60")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlConvert), Member = "ToString", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public override string ToString(float value)
		{
			throw null;
		}

		// Token: 0x06000B9D RID: 2973 RVA: 0x00005045 File Offset: 0x00003245
		[global::Cpp2ILInjected.Token(Token = "0x6000C38")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DE246C", Offset = "0x1DE246C", Length = "0xDA4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(Type)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlConvert), Member = "ToString", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlConvert), Member = "ToString", MemberParameters = new object[] { typeof(byte) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlBaseConverter), Member = "Base64BinaryToString", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlBaseConverter), Member = "DateTimeToString", MemberParameters = new object[] { typeof(DateTime) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlBaseConverter), Member = "DateTimeOffsetToString", MemberParameters = new object[] { typeof(DateTimeOffset) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlConvert), Member = "ToString", MemberParameters = new object[] { typeof(decimal) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlConvert), Member = "ToString", MemberParameters = new object[] { typeof(double) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlConvert), Member = "ToString", MemberParameters = new object[] { typeof(short) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlConvert), Member = "ToString", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlConvert), Member = "ToString", MemberParameters = new object[] { typeof(long) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlConvert), Member = "ToString", MemberParameters = new object[] { typeof(sbyte) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlConvert), Member = "ToString", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlBaseConverter), Member = "DurationToString", MemberParameters = new object[] { typeof(TimeSpan) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlConvert), Member = "ToString", MemberParameters = new object[] { typeof(ushort) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlConvert), Member = "ToString", MemberParameters = new object[] { typeof(uint) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlConvert), Member = "ToString", MemberParameters = new object[] { typeof(ulong) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlBaseConverter), Member = "IsDerivedFrom", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(Type)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlBaseConverter), Member = "AnyUriToString", MemberParameters = new object[] { typeof(Uri) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlBaseConverter), Member = "QNameToString", MemberParameters = new object[]
		{
			typeof(XmlQualifiedName),
			typeof(IXmlNamespaceResolver)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlUntypedConverter), Member = "ChangeTypeWildcardDestination", MemberParameters = new object[]
		{
			typeof(object),
			typeof(Type),
			typeof(IXmlNamespaceResolver)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 97)]
		public override string ToString(object value, IXmlNamespaceResolver nsResolver)
		{
			throw null;
		}

		// Token: 0x06000B9E RID: 2974 RVA: 0x00005048 File Offset: 0x00003248
		[global::Cpp2ILInjected.Token(Token = "0x6000C39")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DE3210", Offset = "0x1DE3210", Length = "0x1E0")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(Type)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlConvert), Member = "ToString", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlUntypedConverter), Member = "ChangeTypeWildcardSource", MemberParameters = new object[]
		{
			typeof(object),
			typeof(Type),
			typeof(IXmlNamespaceResolver)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 16)]
		public override object ChangeType(bool value, Type destinationType)
		{
			throw null;
		}

		// Token: 0x06000B9F RID: 2975 RVA: 0x0000504B File Offset: 0x0000324B
		[global::Cpp2ILInjected.Token(Token = "0x6000C3A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DE3580", Offset = "0x1DE3580", Length = "0x1C8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(Type)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlBaseConverter), Member = "DateTimeToString", MemberParameters = new object[] { typeof(DateTime) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlUntypedConverter), Member = "ChangeTypeWildcardSource", MemberParameters = new object[]
		{
			typeof(object),
			typeof(Type),
			typeof(IXmlNamespaceResolver)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 15)]
		public override object ChangeType(DateTime value, Type destinationType)
		{
			throw null;
		}

		// Token: 0x06000BA0 RID: 2976 RVA: 0x0000504E File Offset: 0x0000324E
		[global::Cpp2ILInjected.Token(Token = "0x6000C3B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DE3748", Offset = "0x1DE3748", Length = "0x208")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(Type)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlConvert), Member = "ToString", MemberParameters = new object[] { typeof(decimal) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlUntypedConverter), Member = "ChangeTypeWildcardSource", MemberParameters = new object[]
		{
			typeof(object),
			typeof(Type),
			typeof(IXmlNamespaceResolver)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 17)]
		public override object ChangeType(decimal value, Type destinationType)
		{
			throw null;
		}

		// Token: 0x06000BA1 RID: 2977 RVA: 0x00005051 File Offset: 0x00003251
		[global::Cpp2ILInjected.Token(Token = "0x6000C3C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DE3950", Offset = "0x1DE3950", Length = "0x1DC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(Type)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlConvert), Member = "ToString", MemberParameters = new object[] { typeof(double) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlUntypedConverter), Member = "ChangeTypeWildcardSource", MemberParameters = new object[]
		{
			typeof(object),
			typeof(Type),
			typeof(IXmlNamespaceResolver)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 16)]
		public override object ChangeType(double value, Type destinationType)
		{
			throw null;
		}

		// Token: 0x06000BA2 RID: 2978 RVA: 0x00005054 File Offset: 0x00003254
		[global::Cpp2ILInjected.Token(Token = "0x6000C3D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DE3B2C", Offset = "0x1DE3B2C", Length = "0x1DC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(Type)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlConvert), Member = "ToString", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlUntypedConverter), Member = "ChangeTypeWildcardSource", MemberParameters = new object[]
		{
			typeof(object),
			typeof(Type),
			typeof(IXmlNamespaceResolver)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 16)]
		public override object ChangeType(int value, Type destinationType)
		{
			throw null;
		}

		// Token: 0x06000BA3 RID: 2979 RVA: 0x00005057 File Offset: 0x00003257
		[global::Cpp2ILInjected.Token(Token = "0x6000C3E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DE3D08", Offset = "0x1DE3D08", Length = "0x1DC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(Type)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlConvert), Member = "ToString", MemberParameters = new object[] { typeof(long) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlUntypedConverter), Member = "ChangeTypeWildcardSource", MemberParameters = new object[]
		{
			typeof(object),
			typeof(Type),
			typeof(IXmlNamespaceResolver)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 16)]
		public override object ChangeType(long value, Type destinationType)
		{
			throw null;
		}

		// Token: 0x06000BA4 RID: 2980 RVA: 0x0000505A File Offset: 0x0000325A
		[global::Cpp2ILInjected.Token(Token = "0x6000C3F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DE3EE4", Offset = "0x1DE3EE4", Length = "0xBF8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(Type)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlConvert), Member = "ToBoolean", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlConvert), Member = "ToInt32", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlBaseConverter), Member = "Int32ToByte", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(byte))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlBaseConverter), Member = "StringToBase64Binary", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlBaseConverter), Member = "UntypedAtomicToDateTime", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(DateTime))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlBaseConverter), Member = "UntypedAtomicToDateTimeOffset", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(DateTimeOffset))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlConvert), Member = "ToDecimal", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(decimal))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlConvert), Member = "ToDouble", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(double))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlBaseConverter), Member = "Int32ToInt16", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(short))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlConvert), Member = "ToInt64", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(long))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlBaseConverter), Member = "Int32ToSByte", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(sbyte))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlConvert), Member = "ToSingle", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlBaseConverter), Member = "StringToDuration", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(TimeSpan))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlBaseConverter), Member = "Int32ToUInt16", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(ushort))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlBaseConverter), Member = "Int64ToUInt32", MemberParameters = new object[] { typeof(long) }, ReturnType = typeof(uint))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlBaseConverter), Member = "DecimalToUInt64", MemberParameters = new object[] { typeof(decimal) }, ReturnType = typeof(ulong))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlConvert), Member = "ToUri", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(Uri))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlBaseConverter), Member = "StringToQName", MemberParameters = new object[]
		{
			typeof(string),
			typeof(IXmlNamespaceResolver)
		}, ReturnType = typeof(XmlQualifiedName))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlAtomicValue), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(XmlSchemaType),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlUntypedConverter), Member = "ChangeTypeWildcardSource", MemberParameters = new object[]
		{
			typeof(object),
			typeof(Type),
			typeof(IXmlNamespaceResolver)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 93)]
		public override object ChangeType(string value, Type destinationType, IXmlNamespaceResolver nsResolver)
		{
			throw null;
		}

		// Token: 0x06000BA5 RID: 2981 RVA: 0x0000505D File Offset: 0x0000325D
		[global::Cpp2ILInjected.Token(Token = "0x6000C40")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DE4ADC", Offset = "0x1DE4ADC", Length = "0x14E8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(Type)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlConvert), Member = "ToBoolean", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlConvert), Member = "ToInt32", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlBaseConverter), Member = "Int32ToByte", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(byte))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlBaseConverter), Member = "StringToBase64Binary", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlBaseConverter), Member = "UntypedAtomicToDateTime", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(DateTime))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlBaseConverter), Member = "UntypedAtomicToDateTimeOffset", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(DateTimeOffset))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlConvert), Member = "ToDecimal", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(decimal))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlConvert), Member = "ToDouble", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(double))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlBaseConverter), Member = "Int32ToInt16", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(short))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlConvert), Member = "ToInt64", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(long))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlBaseConverter), Member = "Int32ToSByte", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(sbyte))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlConvert), Member = "ToSingle", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlBaseConverter), Member = "StringToDuration", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(TimeSpan))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlBaseConverter), Member = "Int32ToUInt16", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(ushort))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlBaseConverter), Member = "Int64ToUInt32", MemberParameters = new object[] { typeof(long) }, ReturnType = typeof(uint))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlBaseConverter), Member = "DecimalToUInt64", MemberParameters = new object[] { typeof(decimal) }, ReturnType = typeof(ulong))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlConvert), Member = "ToUri", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(Uri))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlBaseConverter), Member = "StringToQName", MemberParameters = new object[]
		{
			typeof(string),
			typeof(IXmlNamespaceResolver)
		}, ReturnType = typeof(XmlQualifiedName))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlAtomicValue), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(XmlSchemaType),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 151)]
		public override object ChangeType(object value, Type destinationType, IXmlNamespaceResolver nsResolver)
		{
			throw null;
		}

		// Token: 0x06000BA6 RID: 2982 RVA: 0x00005060 File Offset: 0x00003260
		[global::Cpp2ILInjected.Token(Token = "0x6000C41")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DE0F9C", Offset = "0x1DE0F9C", Length = "0x138")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlUntypedConverter), Member = "ToBoolean", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlUntypedConverter), Member = "ToDateTime", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(DateTime))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlUntypedConverter), Member = "ToDateTimeOffset", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(DateTimeOffset))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlUntypedConverter), Member = "ToDecimal", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(decimal))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlUntypedConverter), Member = "ToDouble", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(double))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlUntypedConverter), Member = "ToInt32", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlUntypedConverter), Member = "ToInt64", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(long))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlUntypedConverter), Member = "ToSingle", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlUntypedConverter), Member = "ToString", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IXmlNamespaceResolver)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 9)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(Type)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		private object ChangeTypeWildcardDestination(object value, Type destinationType, IXmlNamespaceResolver nsResolver)
		{
			throw null;
		}

		// Token: 0x06000BA7 RID: 2983 RVA: 0x00005063 File Offset: 0x00003263
		[global::Cpp2ILInjected.Token(Token = "0x6000C42")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DE33F0", Offset = "0x1DE33F0", Length = "0x190")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlUntypedConverter), Member = "ChangeType", MemberParameters = new object[]
		{
			typeof(bool),
			typeof(Type)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlUntypedConverter), Member = "ChangeType", MemberParameters = new object[]
		{
			typeof(DateTime),
			typeof(Type)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlUntypedConverter), Member = "ChangeType", MemberParameters = new object[]
		{
			typeof(decimal),
			typeof(Type)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlUntypedConverter), Member = "ChangeType", MemberParameters = new object[]
		{
			typeof(double),
			typeof(Type)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlUntypedConverter), Member = "ChangeType", MemberParameters = new object[]
		{
			typeof(int),
			typeof(Type)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlUntypedConverter), Member = "ChangeType", MemberParameters = new object[]
		{
			typeof(long),
			typeof(Type)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlUntypedConverter), Member = "ChangeType", MemberParameters = new object[]
		{
			typeof(string),
			typeof(Type),
			typeof(IXmlNamespaceResolver)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 7)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(Type)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlAtomicValue), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(XmlSchemaType),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		private object ChangeTypeWildcardSource(object value, Type destinationType, IXmlNamespaceResolver nsResolver)
		{
			throw null;
		}

		// Token: 0x06000BA8 RID: 2984 RVA: 0x00005066 File Offset: 0x00003266
		[global::Cpp2ILInjected.Token(Token = "0x6000C43")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DE5FC4", Offset = "0x1DE5FC4", Length = "0x298")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(Type)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlListConverter), Member = "ChangeListType", MemberParameters = new object[]
		{
			typeof(object),
			typeof(Type),
			typeof(IXmlNamespaceResolver)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlUntypedConverter), Member = "SupportsType", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlBaseConverter), Member = "get_XmlTypeName", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Res), Member = "GetString", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object[])
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InvalidCastException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlBaseConverter), Member = "CreateInvalidClrMappingException", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(Type)
		}, ReturnType = typeof(Exception))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 22)]
		protected override object ChangeListType(object value, Type destinationType, IXmlNamespaceResolver nsResolver)
		{
			throw null;
		}

		// Token: 0x06000BA9 RID: 2985 RVA: 0x00005069 File Offset: 0x00003269
		[global::Cpp2ILInjected.Token(Token = "0x6000C44")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DE625C", Offset = "0x1DE625C", Length = "0x530")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlUntypedConverter), Member = "ChangeListType", MemberParameters = new object[]
		{
			typeof(object),
			typeof(Type),
			typeof(IXmlNamespaceResolver)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(Type)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 38)]
		private bool SupportsType(Type clrType)
		{
			throw null;
		}

		// Token: 0x06000BAA RID: 2986 RVA: 0x0000506C File Offset: 0x0000326C
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x6000C45")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DE7584", Offset = "0x1DE7584", Length = "0xA4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlUntypedConverter), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlUntypedConverter), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(XmlUntypedConverter),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		static XmlUntypedConverter()
		{
			throw null;
		}

		// Token: 0x04000495 RID: 1173
		[global::Cpp2ILInjected.Token(Token = "0x4000628")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private bool allowListToList;

		// Token: 0x04000496 RID: 1174
		[global::Cpp2ILInjected.Token(Token = "0x4000629")]
		public static readonly XmlValueConverter Untyped;

		// Token: 0x04000497 RID: 1175
		[global::Cpp2ILInjected.Token(Token = "0x400062A")]
		public static readonly XmlValueConverter UntypedList;
	}
}
