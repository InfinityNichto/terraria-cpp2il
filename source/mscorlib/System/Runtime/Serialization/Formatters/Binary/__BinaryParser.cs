using System;
using System.Globalization;
using System.IO;
using System.Reflection;
using System.Runtime.Remoting.Messaging;
using System.Text;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Runtime.Serialization.Formatters.Binary
{
	// Token: 0x02000378 RID: 888
	[global::Cpp2ILInjected.Token(Token = "0x2000422")]
	internal sealed class __BinaryParser
	{
		// Token: 0x06001EAE RID: 7854 RVA: 0x00019B11 File Offset: 0x00017D11
		[global::Cpp2ILInjected.Token(Token = "0x60020EF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B6B768", Offset = "0x1B6B768", Length = "0x100")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BinaryFormatter), Member = "Deserialize", MemberParameters = new object[]
		{
			typeof(global::System.IO.Stream),
			typeof(global::System.Runtime.Remoting.Messaging.HeaderHandler),
			typeof(bool)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SerStack), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.IO.BinaryReader), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(global::System.IO.Stream),
			typeof(global::System.Text.Encoding)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		internal __BinaryParser(global::System.IO.Stream stream, ObjectReader objectReader)
		{
			throw null;
		}

		// Token: 0x170003EF RID: 1007
		// (get) Token: 0x06001EAF RID: 7855 RVA: 0x00019B14 File Offset: 0x00017D14
		[global::Cpp2ILInjected.Token(Token = "0x1700044D")]
		internal BinaryAssemblyInfo SystemAssemblyInfo
		{
			[global::Cpp2ILInjected.Token(Token = "0x60020F0")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B6B868", Offset = "0x1B6B868", Length = "0xA4")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(__BinaryParser), Member = "ReadObjectWithMap", MemberParameters = new object[] { typeof(BinaryObjectWithMap) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(__BinaryParser), Member = "ReadObjectWithMapTyped", MemberParameters = new object[] { typeof(BinaryObjectWithMapTyped) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(__BinaryParser), Member = "ReadArray", MemberParameters = new object[] { typeof(BinaryHeaderEnum) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BinaryAssemblyInfo), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(string),
				typeof(global::System.Reflection.Assembly)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170003F0 RID: 1008
		// (get) Token: 0x06001EB0 RID: 7856 RVA: 0x00019B17 File Offset: 0x00017D17
		[global::Cpp2ILInjected.Token(Token = "0x1700044E")]
		internal SizedArray ObjectMapIdTable
		{
			[global::Cpp2ILInjected.Token(Token = "0x60020F1")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B6B90C", Offset = "0x1B6B90C", Length = "0x60")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(__BinaryParser), Member = "ReadObject", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(__BinaryParser), Member = "ReadObjectWithMap", MemberParameters = new object[] { typeof(BinaryObjectWithMap) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(__BinaryParser), Member = "ReadObjectWithMapTyped", MemberParameters = new object[] { typeof(BinaryObjectWithMapTyped) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SizedArray), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170003F1 RID: 1009
		// (get) Token: 0x06001EB1 RID: 7857 RVA: 0x00019B1A File Offset: 0x00017D1A
		[global::Cpp2ILInjected.Token(Token = "0x1700044F")]
		internal SizedArray AssemIdToAssemblyTable
		{
			[global::Cpp2ILInjected.Token(Token = "0x60020F2")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B6B9D8", Offset = "0x1B6B9D8", Length = "0x64")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(__BinaryParser), Member = "ReadAssembly", MemberParameters = new object[] { typeof(BinaryHeaderEnum) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(__BinaryParser), Member = "ReadObjectWithMap", MemberParameters = new object[] { typeof(BinaryObjectWithMap) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(__BinaryParser), Member = "ReadObjectWithMapTyped", MemberParameters = new object[] { typeof(BinaryObjectWithMapTyped) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(__BinaryParser), Member = "ReadArray", MemberParameters = new object[] { typeof(BinaryHeaderEnum) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SizedArray), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170003F2 RID: 1010
		// (get) Token: 0x06001EB2 RID: 7858 RVA: 0x00019B1D File Offset: 0x00017D1D
		[global::Cpp2ILInjected.Token(Token = "0x17000450")]
		internal ParseRecord prs
		{
			[global::Cpp2ILInjected.Token(Token = "0x60020F3")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B6BAB4", Offset = "0x1B6BAB4", Length = "0x64")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(__BinaryParser), Member = "Run", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(__BinaryParser), Member = "ReadObjectString", MemberParameters = new object[] { typeof(BinaryHeaderEnum) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(__BinaryParser), Member = "ReadMemberPrimitiveTyped", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(__BinaryParser), Member = "ReadMemberPrimitiveUnTyped", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(__BinaryParser), Member = "ReadMemberReference", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(__BinaryParser), Member = "ReadObjectNull", MemberParameters = new object[] { typeof(BinaryHeaderEnum) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 66)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06001EB3 RID: 7859 RVA: 0x00019B20 File Offset: 0x00017D20
		[global::Cpp2ILInjected.Token(Token = "0x60020F4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B658B0", Offset = "0x1B658B0", Length = "0x528")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ObjectReader), Member = "Deserialize", MemberParameters = new object[]
		{
			typeof(global::System.Runtime.Remoting.Messaging.HeaderHandler),
			typeof(__BinaryParser),
			typeof(bool)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(__BinaryParser), Member = "ReadSerializationHeaderRecord", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(__BinaryParser), Member = "ReadArray", MemberParameters = new object[] { typeof(BinaryHeaderEnum) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(__BinaryParser), Member = "ReadMemberPrimitiveUnTyped", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(__BinaryParser), Member = "ReadObjectNull", MemberParameters = new object[] { typeof(BinaryHeaderEnum) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(__BinaryParser), Member = "ReadAssembly", MemberParameters = new object[] { typeof(BinaryHeaderEnum) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(__BinaryParser), Member = "ReadObjectWithMap", MemberParameters = new object[] { typeof(BinaryHeaderEnum) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(__BinaryParser), Member = "ReadObjectString", MemberParameters = new object[] { typeof(BinaryHeaderEnum) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ObjectProgress), Member = "GetNext", MemberParameters = new object[]
		{
			typeof(ref BinaryTypeEnum),
			typeof(ref object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(__BinaryParser), Member = "get_prs", ReturnType = typeof(ParseRecord))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ObjectReader), Member = "Parse", MemberParameters = new object[] { typeof(ParseRecord) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(__BinaryParser), Member = "PutOp", MemberParameters = new object[] { typeof(ObjectProgress) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(__BinaryParser), Member = "ReadObjectWithMapTyped", MemberParameters = new object[] { typeof(BinaryHeaderEnum) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(__BinaryParser), Member = "ReadMemberPrimitiveTyped", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(__BinaryParser), Member = "ReadCrossAppDomainMap", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(__BinaryParser), Member = "ReadObject", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(__BinaryParser), Member = "ReadMessageEnd", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(__BinaryParser), Member = "ReadMemberReference", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Environment), Member = "GetResourceString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SerializationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Environment), Member = "GetResourceString", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object[])
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 34)]
		internal void Run()
		{
			throw null;
		}

		// Token: 0x06001EB4 RID: 7860 RVA: 0x00019B23 File Offset: 0x00017D23
		[global::Cpp2ILInjected.Token(Token = "0x60020F5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B6BB20", Offset = "0x1B6BB20", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		internal void ReadBegin()
		{
			throw null;
		}

		// Token: 0x06001EB5 RID: 7861 RVA: 0x00019B26 File Offset: 0x00017D26
		[global::Cpp2ILInjected.Token(Token = "0x60020F6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B6D5E4", Offset = "0x1B6D5E4", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		internal void ReadEnd()
		{
			throw null;
		}

		// Token: 0x06001EB6 RID: 7862 RVA: 0x00019B29 File Offset: 0x00017D29
		[global::Cpp2ILInjected.Token(Token = "0x60020F7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B6D938", Offset = "0x1B6D938", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		internal bool ReadBoolean()
		{
			throw null;
		}

		// Token: 0x06001EB7 RID: 7863 RVA: 0x00019B2C File Offset: 0x00017D2C
		[global::Cpp2ILInjected.Token(Token = "0x60020F8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B6D948", Offset = "0x1B6D948", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BinaryConverter), Member = "ReadTypeInfo", MemberParameters = new object[]
		{
			typeof(BinaryTypeEnum),
			typeof(__BinaryParser),
			typeof(ref int)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MemberPrimitiveTyped), Member = "Read", MemberParameters = new object[] { typeof(__BinaryParser) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BinaryObjectWithMapTyped), Member = "Read", MemberParameters = new object[] { typeof(__BinaryParser) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BinaryArray), Member = "Read", MemberParameters = new object[] { typeof(__BinaryParser) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ObjectNull), Member = "Read", MemberParameters = new object[]
		{
			typeof(__BinaryParser),
			typeof(BinaryHeaderEnum)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 7)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		internal byte ReadByte()
		{
			throw null;
		}

		// Token: 0x06001EB8 RID: 7864 RVA: 0x00019B2F File Offset: 0x00017D2F
		[global::Cpp2ILInjected.Token(Token = "0x60020F9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B6D958", Offset = "0x1B6D958", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SerializationHeaderRecord), Member = "Read", MemberParameters = new object[] { typeof(__BinaryParser) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		internal byte[] ReadBytes(int length)
		{
			throw null;
		}

		// Token: 0x06001EB9 RID: 7865 RVA: 0x00019B32 File Offset: 0x00017D32
		[global::Cpp2ILInjected.Token(Token = "0x60020FA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B6D96C", Offset = "0x1B6D96C", Length = "0x74")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(__BinaryParser), Member = "ReadArrayAsBytes", MemberParameters = new object[] { typeof(ParseRecord) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.IO.__Error), Member = "EndOfFile", ReturnType = typeof(void))]
		internal void ReadBytes(byte[] byteA, int offset, int size)
		{
			throw null;
		}

		// Token: 0x06001EBA RID: 7866 RVA: 0x00019B35 File Offset: 0x00017D35
		[global::Cpp2ILInjected.Token(Token = "0x60020FB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B6D9E0", Offset = "0x1B6D9E0", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		internal char ReadChar()
		{
			throw null;
		}

		// Token: 0x06001EBB RID: 7867 RVA: 0x00019B38 File Offset: 0x00017D38
		[global::Cpp2ILInjected.Token(Token = "0x60020FC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B6D9F0", Offset = "0x1B6D9F0", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		internal char[] ReadChars(int length)
		{
			throw null;
		}

		// Token: 0x06001EBC RID: 7868 RVA: 0x00019B3B File Offset: 0x00017D3B
		[global::Cpp2ILInjected.Token(Token = "0x60020FD")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B6DA04", Offset = "0x1B6DA04", Length = "0xAC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(__BinaryParser), Member = "ReadValue", MemberParameters = new object[] { typeof(InternalPrimitiveTypeE) }, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Globalization.CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(global::System.Globalization.CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(decimal), Member = "Parse", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.IFormatProvider)
		}, ReturnType = typeof(decimal))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		internal decimal ReadDecimal()
		{
			throw null;
		}

		// Token: 0x06001EBD RID: 7869 RVA: 0x00019B3E File Offset: 0x00017D3E
		[global::Cpp2ILInjected.Token(Token = "0x60020FE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B6DAB0", Offset = "0x1B6DAB0", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		internal float ReadSingle()
		{
			throw null;
		}

		// Token: 0x06001EBE RID: 7870 RVA: 0x00019B41 File Offset: 0x00017D41
		[global::Cpp2ILInjected.Token(Token = "0x60020FF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B6DAC4", Offset = "0x1B6DAC4", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		internal double ReadDouble()
		{
			throw null;
		}

		// Token: 0x06001EBF RID: 7871 RVA: 0x00019B44 File Offset: 0x00017D44
		[global::Cpp2ILInjected.Token(Token = "0x6002100")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B6DAD8", Offset = "0x1B6DAD8", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		internal short ReadInt16()
		{
			throw null;
		}

		// Token: 0x06001EC0 RID: 7872 RVA: 0x00019B47 File Offset: 0x00017D47
		[global::Cpp2ILInjected.Token(Token = "0x6002101")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B6DAEC", Offset = "0x1B6DAEC", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BinaryConverter), Member = "ReadTypeInfo", MemberParameters = new object[]
		{
			typeof(BinaryTypeEnum),
			typeof(__BinaryParser),
			typeof(ref int)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BinaryAssembly), Member = "Read", MemberParameters = new object[] { typeof(__BinaryParser) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BinaryCrossAppDomainAssembly), Member = "Read", MemberParameters = new object[] { typeof(__BinaryParser) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BinaryObject), Member = "Read", MemberParameters = new object[] { typeof(__BinaryParser) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BinaryObjectString), Member = "Read", MemberParameters = new object[] { typeof(__BinaryParser) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BinaryCrossAppDomainString), Member = "Read", MemberParameters = new object[] { typeof(__BinaryParser) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BinaryCrossAppDomainMap), Member = "Read", MemberParameters = new object[] { typeof(__BinaryParser) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BinaryObjectWithMap), Member = "Read", MemberParameters = new object[] { typeof(__BinaryParser) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BinaryObjectWithMapTyped), Member = "Read", MemberParameters = new object[] { typeof(__BinaryParser) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BinaryArray), Member = "Read", MemberParameters = new object[] { typeof(__BinaryParser) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MemberReference), Member = "Read", MemberParameters = new object[] { typeof(__BinaryParser) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ObjectNull), Member = "Read", MemberParameters = new object[]
		{
			typeof(__BinaryParser),
			typeof(BinaryHeaderEnum)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 28)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		internal int ReadInt32()
		{
			throw null;
		}

		// Token: 0x06001EC1 RID: 7873 RVA: 0x00019B4A File Offset: 0x00017D4A
		[global::Cpp2ILInjected.Token(Token = "0x6002102")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B6DB00", Offset = "0x1B6DB00", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		internal long ReadInt64()
		{
			throw null;
		}

		// Token: 0x06001EC2 RID: 7874 RVA: 0x00019B4D File Offset: 0x00017D4D
		[global::Cpp2ILInjected.Token(Token = "0x6002103")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B6DB14", Offset = "0x1B6DB14", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		internal sbyte ReadSByte()
		{
			throw null;
		}

		// Token: 0x06001EC3 RID: 7875 RVA: 0x00019B50 File Offset: 0x00017D50
		[global::Cpp2ILInjected.Token(Token = "0x6002104")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B6DB24", Offset = "0x1B6DB24", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BinaryConverter), Member = "ReadTypeInfo", MemberParameters = new object[]
		{
			typeof(BinaryTypeEnum),
			typeof(__BinaryParser),
			typeof(ref int)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BinaryAssembly), Member = "Read", MemberParameters = new object[] { typeof(__BinaryParser) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BinaryObjectString), Member = "Read", MemberParameters = new object[] { typeof(__BinaryParser) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BinaryObjectWithMap), Member = "Read", MemberParameters = new object[] { typeof(__BinaryParser) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BinaryObjectWithMapTyped), Member = "Read", MemberParameters = new object[] { typeof(__BinaryParser) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 8)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		internal string ReadString()
		{
			throw null;
		}

		// Token: 0x06001EC4 RID: 7876 RVA: 0x00019B53 File Offset: 0x00017D53
		[global::Cpp2ILInjected.Token(Token = "0x6002105")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B6DB38", Offset = "0x1B6DB38", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		internal global::System.TimeSpan ReadTimeSpan()
		{
			throw null;
		}

		// Token: 0x06001EC5 RID: 7877 RVA: 0x00019B56 File Offset: 0x00017D56
		[global::Cpp2ILInjected.Token(Token = "0x6002106")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B6DB4C", Offset = "0x1B6DB4C", Length = "0x74")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(__BinaryParser), Member = "ReadValue", MemberParameters = new object[] { typeof(InternalPrimitiveTypeE) }, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTime), Member = "FromBinaryRaw", MemberParameters = new object[] { typeof(long) }, ReturnType = typeof(global::System.DateTime))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal global::System.DateTime ReadDateTime()
		{
			throw null;
		}

		// Token: 0x06001EC6 RID: 7878 RVA: 0x00019B59 File Offset: 0x00017D59
		[global::Cpp2ILInjected.Token(Token = "0x6002107")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B6DBC0", Offset = "0x1B6DBC0", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		internal ushort ReadUInt16()
		{
			throw null;
		}

		// Token: 0x06001EC7 RID: 7879 RVA: 0x00019B5C File Offset: 0x00017D5C
		[global::Cpp2ILInjected.Token(Token = "0x6002108")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B6DBD4", Offset = "0x1B6DBD4", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		internal uint ReadUInt32()
		{
			throw null;
		}

		// Token: 0x06001EC8 RID: 7880 RVA: 0x00019B5F File Offset: 0x00017D5F
		[global::Cpp2ILInjected.Token(Token = "0x6002109")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B6DBE8", Offset = "0x1B6DBE8", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		internal ulong ReadUInt64()
		{
			throw null;
		}

		// Token: 0x06001EC9 RID: 7881 RVA: 0x00019B62 File Offset: 0x00017D62
		[global::Cpp2ILInjected.Token(Token = "0x600210A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B6BB24", Offset = "0x1B6BB24", Length = "0xA8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(__BinaryParser), Member = "Run", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SerializationHeaderRecord), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SerializationHeaderRecord), Member = "Read", MemberParameters = new object[] { typeof(__BinaryParser) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SerializationHeaderRecord), Member = "Dump", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ObjectReader), Member = "GetId", MemberParameters = new object[] { typeof(long) }, ReturnType = typeof(long))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal void ReadSerializationHeaderRecord()
		{
			throw null;
		}

		// Token: 0x06001ECA RID: 7882 RVA: 0x00019B65 File Offset: 0x00017D65
		[global::Cpp2ILInjected.Token(Token = "0x600210B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B6BBCC", Offset = "0x1B6BBCC", Length = "0x230")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(__BinaryParser), Member = "Run", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BinaryAssembly), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BinaryCrossAppDomainAssembly), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BinaryCrossAppDomainAssembly), Member = "Read", MemberParameters = new object[] { typeof(__BinaryParser) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BinaryCrossAppDomainAssembly), Member = "Dump", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BinaryAssembly), Member = "Read", MemberParameters = new object[] { typeof(__BinaryParser) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BinaryAssembly), Member = "Dump", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(__BinaryParser), Member = "get_AssemIdToAssemblyTable", ReturnType = typeof(SizedArray))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BinaryAssemblyInfo), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SizedArray), Member = "set_Item", MemberParameters = new object[]
		{
			typeof(int),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Environment), Member = "GetResourceString", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object[])
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SerializationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 20)]
		internal void ReadAssembly(BinaryHeaderEnum binaryHeaderEnum)
		{
			throw null;
		}

		// Token: 0x06001ECB RID: 7883 RVA: 0x00019B68 File Offset: 0x00017D68
		[global::Cpp2ILInjected.Token(Token = "0x600210C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B6BDFC", Offset = "0x1B6BDFC", Length = "0x350")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(__BinaryParser), Member = "Run", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BinaryObject), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BinaryObject), Member = "Read", MemberParameters = new object[] { typeof(__BinaryParser) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BinaryObject), Member = "Dump", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(__BinaryParser), Member = "get_ObjectMapIdTable", ReturnType = typeof(SizedArray))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(__BinaryParser), Member = "GetOp", ReturnType = typeof(ObjectProgress))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SerStack), Member = "Push", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ObjectReader), Member = "GetId", MemberParameters = new object[] { typeof(long) }, ReturnType = typeof(long))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ObjectMap), Member = "CreateObjectInfo", MemberParameters = new object[]
		{
			typeof(ref SerializationInfo),
			typeof(ref object[])
		}, ReturnType = typeof(ReadObjectInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ObjectReader), Member = "Parse", MemberParameters = new object[] { typeof(ParseRecord) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Environment), Member = "GetResourceString", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object[])
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SerializationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Enum), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 21)]
		private void ReadObject()
		{
			throw null;
		}

		// Token: 0x06001ECC RID: 7884 RVA: 0x00019B6B File Offset: 0x00017D6B
		[global::Cpp2ILInjected.Token(Token = "0x600210D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B6C14C", Offset = "0x1B6C14C", Length = "0x198")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(__BinaryParser), Member = "Run", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BinaryCrossAppDomainMap), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BinaryCrossAppDomainMap), Member = "Read", MemberParameters = new object[] { typeof(__BinaryParser) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BinaryCrossAppDomainMap), Member = "Dump", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(__BinaryParser), Member = "ReadObjectWithMapTyped", MemberParameters = new object[] { typeof(BinaryObjectWithMapTyped) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BinaryObjectWithMap), Member = "Dump", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(__BinaryParser), Member = "ReadObjectWithMap", MemberParameters = new object[] { typeof(BinaryObjectWithMap) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Environment), Member = "GetResourceString", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object[])
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SerializationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 15)]
		internal void ReadCrossAppDomainMap()
		{
			throw null;
		}

		// Token: 0x06001ECD RID: 7885 RVA: 0x00019B6E File Offset: 0x00017D6E
		[global::Cpp2ILInjected.Token(Token = "0x600210E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B6C2E4", Offset = "0x1B6C2E4", Length = "0x94")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(__BinaryParser), Member = "Run", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BinaryObjectWithMap), Member = ".ctor", MemberParameters = new object[] { typeof(BinaryHeaderEnum) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BinaryObjectWithMap), Member = "Read", MemberParameters = new object[] { typeof(__BinaryParser) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BinaryObjectWithMap), Member = "Dump", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(__BinaryParser), Member = "ReadObjectWithMap", MemberParameters = new object[] { typeof(BinaryObjectWithMap) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal void ReadObjectWithMap(BinaryHeaderEnum binaryHeaderEnum)
		{
			throw null;
		}

		// Token: 0x06001ECE RID: 7886 RVA: 0x00019B71 File Offset: 0x00017D71
		[global::Cpp2ILInjected.Token(Token = "0x600210F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B6DDE8", Offset = "0x1B6DDE8", Length = "0x3C4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(__BinaryParser), Member = "ReadCrossAppDomainMap", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(__BinaryParser), Member = "ReadObjectWithMap", MemberParameters = new object[] { typeof(BinaryHeaderEnum) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(__BinaryParser), Member = "GetOp", ReturnType = typeof(ObjectProgress))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SerStack), Member = "Push", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(__BinaryParser), Member = "get_AssemIdToAssemblyTable", ReturnType = typeof(SizedArray))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(__BinaryParser), Member = "get_SystemAssemblyInfo", ReturnType = typeof(BinaryAssemblyInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ObjectReader), Member = "GetType", MemberParameters = new object[]
		{
			typeof(BinaryAssemblyInfo),
			typeof(string)
		}, ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ObjectMap), Member = "Create", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.Type),
			typeof(string[]),
			typeof(ObjectReader),
			typeof(int),
			typeof(BinaryAssemblyInfo)
		}, ReturnType = typeof(ObjectMap))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(__BinaryParser), Member = "get_ObjectMapIdTable", ReturnType = typeof(SizedArray))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SizedArray), Member = "set_Item", MemberParameters = new object[]
		{
			typeof(int),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ObjectReader), Member = "GetId", MemberParameters = new object[] { typeof(long) }, ReturnType = typeof(long))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ObjectMap), Member = "CreateObjectInfo", MemberParameters = new object[]
		{
			typeof(ref SerializationInfo),
			typeof(ref object[])
		}, ReturnType = typeof(ReadObjectInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ObjectReader), Member = "Parse", MemberParameters = new object[] { typeof(ParseRecord) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(int), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Environment), Member = "GetResourceString", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object[])
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SerializationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Enum), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 21)]
		private void ReadObjectWithMap(BinaryObjectWithMap record)
		{
			throw null;
		}

		// Token: 0x06001ECF RID: 7887 RVA: 0x00019B74 File Offset: 0x00017D74
		[global::Cpp2ILInjected.Token(Token = "0x6002110")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B6C378", Offset = "0x1B6C378", Length = "0x88")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(__BinaryParser), Member = "Run", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BinaryObjectWithMapTyped), Member = ".ctor", MemberParameters = new object[] { typeof(BinaryHeaderEnum) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BinaryObjectWithMapTyped), Member = "Read", MemberParameters = new object[] { typeof(__BinaryParser) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(__BinaryParser), Member = "ReadObjectWithMapTyped", MemberParameters = new object[] { typeof(BinaryObjectWithMapTyped) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal void ReadObjectWithMapTyped(BinaryHeaderEnum binaryHeaderEnum)
		{
			throw null;
		}

		// Token: 0x06001ED0 RID: 7888 RVA: 0x00019B77 File Offset: 0x00017D77
		[global::Cpp2ILInjected.Token(Token = "0x6002111")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B6E1AC", Offset = "0x1B6E1AC", Length = "0x3E8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(__BinaryParser), Member = "ReadCrossAppDomainMap", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(__BinaryParser), Member = "ReadObjectWithMapTyped", MemberParameters = new object[] { typeof(BinaryHeaderEnum) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(__BinaryParser), Member = "GetOp", ReturnType = typeof(ObjectProgress))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SerStack), Member = "Push", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(__BinaryParser), Member = "get_AssemIdToAssemblyTable", ReturnType = typeof(SizedArray))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(__BinaryParser), Member = "get_SystemAssemblyInfo", ReturnType = typeof(BinaryAssemblyInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ObjectMap), Member = "Create", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string[]),
			typeof(BinaryTypeEnum[]),
			typeof(object[]),
			typeof(int[]),
			typeof(ObjectReader),
			typeof(int),
			typeof(BinaryAssemblyInfo),
			typeof(SizedArray)
		}, ReturnType = typeof(ObjectMap))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(__BinaryParser), Member = "get_ObjectMapIdTable", ReturnType = typeof(SizedArray))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SizedArray), Member = "set_Item", MemberParameters = new object[]
		{
			typeof(int),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ObjectMap), Member = "CreateObjectInfo", MemberParameters = new object[]
		{
			typeof(ref SerializationInfo),
			typeof(ref object[])
		}, ReturnType = typeof(ReadObjectInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ObjectReader), Member = "GetId", MemberParameters = new object[] { typeof(long) }, ReturnType = typeof(long))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ObjectReader), Member = "Parse", MemberParameters = new object[] { typeof(ParseRecord) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(int), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Environment), Member = "GetResourceString", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object[])
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SerializationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Enum), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 21)]
		private void ReadObjectWithMapTyped(BinaryObjectWithMapTyped record)
		{
			throw null;
		}

		// Token: 0x06001ED1 RID: 7889 RVA: 0x00019B7A File Offset: 0x00017D7A
		[global::Cpp2ILInjected.Token(Token = "0x6002112")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B6C400", Offset = "0x1B6C400", Length = "0x4C8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(__BinaryParser), Member = "Run", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BinaryObjectString), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BinaryObjectString), Member = "Read", MemberParameters = new object[] { typeof(__BinaryParser) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BinaryObjectString), Member = "Dump", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BinaryCrossAppDomainString), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BinaryCrossAppDomainString), Member = "Read", MemberParameters = new object[] { typeof(__BinaryParser) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BinaryCrossAppDomainString), Member = "Dump", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(__BinaryParser), Member = "get_prs", ReturnType = typeof(ParseRecord))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ObjectReader), Member = "GetId", MemberParameters = new object[] { typeof(long) }, ReturnType = typeof(long))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ObjectReader), Member = "Parse", MemberParameters = new object[] { typeof(ParseRecord) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Enum), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Environment), Member = "GetResourceString", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object[])
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SerializationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 29)]
		private void ReadObjectString(BinaryHeaderEnum binaryHeaderEnum)
		{
			throw null;
		}

		// Token: 0x06001ED2 RID: 7890 RVA: 0x00019B7D File Offset: 0x00017D7D
		[global::Cpp2ILInjected.Token(Token = "0x6002113")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B6CDB8", Offset = "0x1B6CDB8", Length = "0x33C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(__BinaryParser), Member = "Run", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MemberPrimitiveTyped), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MemberPrimitiveTyped), Member = "Read", MemberParameters = new object[] { typeof(__BinaryParser) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MemberPrimitiveTyped), Member = "Dump", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(__BinaryParser), Member = "get_prs", ReturnType = typeof(ParseRecord))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Converter), Member = "ToComType", MemberParameters = new object[] { typeof(InternalPrimitiveTypeE) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Converter), Member = "ToType", MemberParameters = new object[] { typeof(InternalPrimitiveTypeE) }, ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ObjectReader), Member = "Parse", MemberParameters = new object[] { typeof(ParseRecord) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Enum), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Environment), Member = "GetResourceString", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object[])
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SerializationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 17)]
		private void ReadMemberPrimitiveTyped()
		{
			throw null;
		}

		// Token: 0x06001ED3 RID: 7891 RVA: 0x00019B80 File Offset: 0x00017D80
		[global::Cpp2ILInjected.Token(Token = "0x6002114")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B6C8C8", Offset = "0x1B6C8C8", Length = "0x4F0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(__BinaryParser), Member = "Run", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BinaryArray), Member = ".ctor", MemberParameters = new object[] { typeof(BinaryHeaderEnum) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BinaryArray), Member = "Read", MemberParameters = new object[] { typeof(__BinaryParser) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(__BinaryParser), Member = "get_AssemIdToAssemblyTable", ReturnType = typeof(SizedArray))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(__BinaryParser), Member = "get_SystemAssemblyInfo", ReturnType = typeof(BinaryAssemblyInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(__BinaryParser), Member = "GetOp", ReturnType = typeof(ObjectProgress))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ObjectReader), Member = "GetId", MemberParameters = new object[] { typeof(long) }, ReturnType = typeof(long))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BinaryConverter), Member = "TypeFromInfo", MemberParameters = new object[]
		{
			typeof(BinaryTypeEnum),
			typeof(object),
			typeof(ObjectReader),
			typeof(BinaryAssemblyInfo),
			typeof(ref InternalPrimitiveTypeE),
			typeof(ref string),
			typeof(ref global::System.Type),
			typeof(ref bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Converter), Member = "IsWriteAsByteArray", MemberParameters = new object[] { typeof(InternalPrimitiveTypeE) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(__BinaryParser), Member = "ReadArrayAsBytes", MemberParameters = new object[] { typeof(ParseRecord) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(__BinaryParser), Member = "PutOp", MemberParameters = new object[] { typeof(ObjectProgress) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ObjectReader), Member = "Parse", MemberParameters = new object[] { typeof(ParseRecord) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SerStack), Member = "Push", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Enum), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Environment), Member = "GetResourceString", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object[])
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SerializationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 28)]
		private void ReadArray(BinaryHeaderEnum binaryHeaderEnum)
		{
			throw null;
		}

		// Token: 0x06001ED4 RID: 7892 RVA: 0x00019B83 File Offset: 0x00017D83
		[global::Cpp2ILInjected.Token(Token = "0x6002115")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B6E594", Offset = "0x1B6E594", Length = "0x2D0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(__BinaryParser), Member = "ReadArray", MemberParameters = new object[] { typeof(BinaryHeaderEnum) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Converter), Member = "TypeLength", MemberParameters = new object[] { typeof(InternalPrimitiveTypeE) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Converter), Member = "CreatePrimitiveArray", MemberParameters = new object[]
		{
			typeof(InternalPrimitiveTypeE),
			typeof(int)
		}, ReturnType = typeof(global::System.Array))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array), Member = "get_Length", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Math), Member = "Min", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(__BinaryParser), Member = "ReadBytes", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Buffer), Member = "InternalBlockCopy", MemberParameters = new object[]
		{
			typeof(global::System.Array),
			typeof(int),
			typeof(global::System.Array),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		private void ReadArrayAsBytes(ParseRecord pr)
		{
			throw null;
		}

		// Token: 0x06001ED5 RID: 7893 RVA: 0x00019B86 File Offset: 0x00017D86
		[global::Cpp2ILInjected.Token(Token = "0x6002116")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B6D5E8", Offset = "0x1B6D5E8", Length = "0x278")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(__BinaryParser), Member = "Run", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MemberPrimitiveUnTyped), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MemberPrimitiveUnTyped), Member = "Read", MemberParameters = new object[] { typeof(__BinaryParser) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MemberPrimitiveUnTyped), Member = "Dump", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(__BinaryParser), Member = "get_prs", ReturnType = typeof(ParseRecord))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Converter), Member = "ToType", MemberParameters = new object[] { typeof(InternalPrimitiveTypeE) }, ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ObjectReader), Member = "Parse", MemberParameters = new object[] { typeof(ParseRecord) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		private void ReadMemberPrimitiveUnTyped()
		{
			throw null;
		}

		// Token: 0x06001ED6 RID: 7894 RVA: 0x00019B89 File Offset: 0x00017D89
		[global::Cpp2ILInjected.Token(Token = "0x6002117")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B6D0F4", Offset = "0x1B6D0F4", Length = "0x1C4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(__BinaryParser), Member = "Run", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MemberReference), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MemberReference), Member = "Read", MemberParameters = new object[] { typeof(__BinaryParser) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MemberReference), Member = "Dump", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(__BinaryParser), Member = "get_prs", ReturnType = typeof(ParseRecord))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ObjectReader), Member = "GetId", MemberParameters = new object[] { typeof(long) }, ReturnType = typeof(long))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ObjectReader), Member = "Parse", MemberParameters = new object[] { typeof(ParseRecord) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		private void ReadMemberReference()
		{
			throw null;
		}

		// Token: 0x06001ED7 RID: 7895 RVA: 0x00019B8C File Offset: 0x00017D8C
		[global::Cpp2ILInjected.Token(Token = "0x6002118")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B6D2B8", Offset = "0x1B6D2B8", Length = "0x1D0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(__BinaryParser), Member = "Run", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ObjectNull), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ObjectNull), Member = "Read", MemberParameters = new object[]
		{
			typeof(__BinaryParser),
			typeof(BinaryHeaderEnum)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ObjectNull), Member = "Dump", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(__BinaryParser), Member = "get_prs", ReturnType = typeof(ParseRecord))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ObjectProgress), Member = "ArrayCountIncrement", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ObjectReader), Member = "Parse", MemberParameters = new object[] { typeof(ParseRecord) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		private void ReadObjectNull(BinaryHeaderEnum binaryHeaderEnum)
		{
			throw null;
		}

		// Token: 0x06001ED8 RID: 7896 RVA: 0x00019B8F File Offset: 0x00017D8F
		[global::Cpp2ILInjected.Token(Token = "0x6002119")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B6D488", Offset = "0x1B6D488", Length = "0x15C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(__BinaryParser), Member = "Run", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MessageEnd), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MessageEnd), Member = "Read", MemberParameters = new object[] { typeof(__BinaryParser) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MessageEnd), Member = "Dump", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Environment), Member = "GetResourceString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SerializationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 15)]
		private void ReadMessageEnd()
		{
			throw null;
		}

		// Token: 0x06001ED9 RID: 7897 RVA: 0x00019B92 File Offset: 0x00017D92
		[global::Cpp2ILInjected.Token(Token = "0x600211A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B6E864", Offset = "0x1B6E864", Length = "0x3CC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MemberPrimitiveTyped), Member = "Read", MemberParameters = new object[] { typeof(__BinaryParser) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MemberPrimitiveUnTyped), Member = "Read", MemberParameters = new object[] { typeof(__BinaryParser) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(__BinaryParser), Member = "ReadDateTime", ReturnType = typeof(global::System.DateTime))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(__BinaryParser), Member = "ReadDecimal", ReturnType = typeof(decimal))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Enum), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Environment), Member = "GetResourceString", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object[])
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SerializationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 28)]
		internal object ReadValue(InternalPrimitiveTypeE code)
		{
			throw null;
		}

		// Token: 0x06001EDA RID: 7898 RVA: 0x00019B95 File Offset: 0x00017D95
		[global::Cpp2ILInjected.Token(Token = "0x600211B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B6DD14", Offset = "0x1B6DD14", Length = "0xB0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(__BinaryParser), Member = "ReadObject", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(__BinaryParser), Member = "ReadObjectWithMap", MemberParameters = new object[] { typeof(BinaryObjectWithMap) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(__BinaryParser), Member = "ReadObjectWithMapTyped", MemberParameters = new object[] { typeof(BinaryObjectWithMapTyped) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(__BinaryParser), Member = "ReadArray", MemberParameters = new object[] { typeof(BinaryHeaderEnum) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ObjectProgress), Member = "Init", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ObjectProgress), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		private ObjectProgress GetOp()
		{
			throw null;
		}

		// Token: 0x06001EDB RID: 7899 RVA: 0x00019B98 File Offset: 0x00017D98
		[global::Cpp2ILInjected.Token(Token = "0x600211C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B6D8B8", Offset = "0x1B6D8B8", Length = "0x80")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(__BinaryParser), Member = "Run", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(__BinaryParser), Member = "ReadArray", MemberParameters = new object[] { typeof(BinaryHeaderEnum) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SerStack), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SerStack), Member = "Push", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		private void PutOp(ObjectProgress op)
		{
			throw null;
		}

		// Token: 0x06001EDC RID: 7900 RVA: 0x00019B9B File Offset: 0x00017D9B
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x600211D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B6EC30", Offset = "0x1B6EC30", Length = "0x78")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Text.UTF8Encoding), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		static __BinaryParser()
		{
			throw null;
		}

		// Token: 0x04000E76 RID: 3702
		[global::Cpp2ILInjected.Token(Token = "0x400116B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		internal ObjectReader objectReader;

		// Token: 0x04000E77 RID: 3703
		[global::Cpp2ILInjected.Token(Token = "0x400116C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		internal global::System.IO.Stream input;

		// Token: 0x04000E78 RID: 3704
		[global::Cpp2ILInjected.Token(Token = "0x400116D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		internal long topId;

		// Token: 0x04000E79 RID: 3705
		[global::Cpp2ILInjected.Token(Token = "0x400116E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		internal long headerId;

		// Token: 0x04000E7A RID: 3706
		[global::Cpp2ILInjected.Token(Token = "0x400116F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		internal SizedArray objectMapIdTable;

		// Token: 0x04000E7B RID: 3707
		[global::Cpp2ILInjected.Token(Token = "0x4001170")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		internal SizedArray assemIdToAssemblyTable;

		// Token: 0x04000E7C RID: 3708
		[global::Cpp2ILInjected.Token(Token = "0x4001171")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		internal SerStack stack;

		// Token: 0x04000E7D RID: 3709
		[global::Cpp2ILInjected.Token(Token = "0x4001172")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
		internal BinaryTypeEnum expectedType;

		// Token: 0x04000E7E RID: 3710
		[global::Cpp2ILInjected.Token(Token = "0x4001173")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
		internal object expectedTypeInformation;

		// Token: 0x04000E7F RID: 3711
		[global::Cpp2ILInjected.Token(Token = "0x4001174")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
		internal ParseRecord PRS;

		// Token: 0x04000E80 RID: 3712
		[global::Cpp2ILInjected.Token(Token = "0x4001175")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
		private BinaryAssemblyInfo systemAssemblyInfo;

		// Token: 0x04000E81 RID: 3713
		[global::Cpp2ILInjected.Token(Token = "0x4001176")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x68")]
		private global::System.IO.BinaryReader dataReader;

		// Token: 0x04000E82 RID: 3714
		[global::Cpp2ILInjected.Token(Token = "0x4001177")]
		private static global::System.Text.Encoding encoding;

		// Token: 0x04000E83 RID: 3715
		[global::Cpp2ILInjected.Token(Token = "0x4001178")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x70")]
		private SerStack opPool;

		// Token: 0x04000E84 RID: 3716
		[global::Cpp2ILInjected.Token(Token = "0x4001179")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x78")]
		private BinaryObject binaryObject;

		// Token: 0x04000E85 RID: 3717
		[global::Cpp2ILInjected.Token(Token = "0x400117A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x80")]
		private BinaryObjectWithMap bowm;

		// Token: 0x04000E86 RID: 3718
		[global::Cpp2ILInjected.Token(Token = "0x400117B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x88")]
		private BinaryObjectWithMapTyped bowmt;

		// Token: 0x04000E87 RID: 3719
		[global::Cpp2ILInjected.Token(Token = "0x400117C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x90")]
		internal BinaryObjectString objectString;

		// Token: 0x04000E88 RID: 3720
		[global::Cpp2ILInjected.Token(Token = "0x400117D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x98")]
		internal BinaryCrossAppDomainString crossAppDomainString;

		// Token: 0x04000E89 RID: 3721
		[global::Cpp2ILInjected.Token(Token = "0x400117E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xA0")]
		internal MemberPrimitiveTyped memberPrimitiveTyped;

		// Token: 0x04000E8A RID: 3722
		[global::Cpp2ILInjected.Token(Token = "0x400117F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xA8")]
		private byte[] byteBuffer;

		// Token: 0x04000E8B RID: 3723
		[global::Cpp2ILInjected.Token(Token = "0x4001180")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xB0")]
		internal MemberPrimitiveUnTyped memberPrimitiveUnTyped;

		// Token: 0x04000E8C RID: 3724
		[global::Cpp2ILInjected.Token(Token = "0x4001181")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xB8")]
		internal MemberReference memberReference;

		// Token: 0x04000E8D RID: 3725
		[global::Cpp2ILInjected.Token(Token = "0x4001182")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xC0")]
		internal ObjectNull objectNull;

		// Token: 0x04000E8E RID: 3726
		[global::Cpp2ILInjected.Token(Token = "0x4001183")]
		internal static MessageEnd messageEnd;
	}
}
