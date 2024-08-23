using System;
using System.Globalization;
using System.Runtime.Serialization;
using System.Text;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Xml
{
	// Token: 0x02000081 RID: 129
	[global::Cpp2ILInjected.Token(Token = "0x20000A8")]
	[Serializable]
	public class XmlException : SystemException
	{
		// Token: 0x060006F0 RID: 1776 RVA: 0x0000437C File Offset: 0x0000257C
		[global::Cpp2ILInjected.Token(Token = "0x6000779")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DAEDD4", Offset = "0x1DAEDD4", Length = "0x3BC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SystemException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(SerializationInfo),
			typeof(StreamingContext)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(RuntimeTypeHandle) }, ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SerializationInfo), Member = "GetValue", MemberParameters = new object[]
		{
			typeof(string),
			typeof(Type)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SerializationInfo), Member = "GetEnumerator", ReturnType = typeof(SerializationInfoEnumerator))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SerializationInfoEnumerator), Member = "MoveNext", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SerializationInfoEnumerator), Member = "get_Current", ReturnType = typeof(SerializationEntry))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlException), Member = "CreateMessage", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 20)]
		protected XmlException(SerializationInfo info, StreamingContext context)
		{
			throw null;
		}

		// Token: 0x060006F1 RID: 1777 RVA: 0x0000437F File Offset: 0x0000257F
		[global::Cpp2ILInjected.Token(Token = "0x600077A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DAF400", Offset = "0x1DAF400", Length = "0x170")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Exception), Member = "GetObjectData", MemberParameters = new object[]
		{
			typeof(SerializationInfo),
			typeof(StreamingContext)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SerializationInfo), Member = "AddValue", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SerializationInfo), Member = "AddValue", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public override void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			throw null;
		}

		// Token: 0x060006F2 RID: 1778 RVA: 0x00004382 File Offset: 0x00002582
		[global::Cpp2ILInjected.Token(Token = "0x600077B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DAF570", Offset = "0x1DAF570", Length = "0x18")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(Exception),
			typeof(int),
			typeof(int),
			typeof(string)
		}, ReturnType = typeof(void))]
		public XmlException()
		{
			throw null;
		}

		// Token: 0x060006F3 RID: 1779 RVA: 0x00004385 File Offset: 0x00002585
		[global::Cpp2ILInjected.Token(Token = "0x600077C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DAF588", Offset = "0x1DAF588", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(Exception),
			typeof(int),
			typeof(int),
			typeof(string)
		}, ReturnType = typeof(void))]
		public XmlException(string message)
		{
			throw null;
		}

		// Token: 0x060006F4 RID: 1780 RVA: 0x00004388 File Offset: 0x00002588
		[global::Cpp2ILInjected.Token(Token = "0x600077D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DAF59C", Offset = "0x1DAF59C", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public XmlException(string message, Exception innerException, int lineNumber, int linePosition)
		{
			throw null;
		}

		// Token: 0x060006F5 RID: 1781 RVA: 0x0000438B File Offset: 0x0000258B
		[global::Cpp2ILInjected.Token(Token = "0x600077E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DAF5A4", Offset = "0x1DAF5A4", Length = "0x120")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ReThrow", MemberParameters = new object[]
		{
			typeof(Exception),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlException), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlException), Member = "FormatUserMessage", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SystemException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(Exception)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		internal XmlException(string message, Exception innerException, int lineNumber, int linePosition, string sourceUri)
		{
			throw null;
		}

		// Token: 0x060006F6 RID: 1782 RVA: 0x0000438E File Offset: 0x0000258E
		[global::Cpp2ILInjected.Token(Token = "0x600077F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DA6094", Offset = "0x1DA6094", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlWellFormedWriter), Member = "PushNamespaceImplicit", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlWellFormedWriter), Member = "PushNamespaceExplicit", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlDocument), Member = "CheckName", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ValidateNames), Member = "ThrowInvalidName", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ValidateNames), Member = "GetInvalidNameException", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(Exception))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlConvert), Member = "TryVerifyName", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(Exception))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlConvert), Member = "TryVerifyNMTOKEN", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(Exception))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 7)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlException), Member = "CreateMessage", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SystemException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(Exception)
		}, ReturnType = typeof(void))]
		internal XmlException(string res, string[] args)
		{
			throw null;
		}

		// Token: 0x060006F7 RID: 1783 RVA: 0x00004391 File Offset: 0x00002591
		[global::Cpp2ILInjected.Token(Token = "0x6000780")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DA5EEC", Offset = "0x1DA5EEC", Length = "0xC4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 28)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlException), Member = "CreateMessage", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SystemException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(Exception)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		internal XmlException(string res, string arg)
		{
			throw null;
		}

		// Token: 0x060006F8 RID: 1784 RVA: 0x00004394 File Offset: 0x00002594
		[global::Cpp2ILInjected.Token(Token = "0x6000781")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DAF828", Offset = "0x1DAF828", Length = "0xD0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ThrowWithoutLineInfo", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ThrowWithoutLineInfo", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlException), Member = "CreateMessage", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SystemException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(Exception)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		internal XmlException(string res, string arg, string sourceUri)
		{
			throw null;
		}

		// Token: 0x060006F9 RID: 1785 RVA: 0x00004397 File Offset: 0x00002597
		[global::Cpp2ILInjected.Token(Token = "0x6000782")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DAB820", Offset = "0x1DAB820", Length = "0xD8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlConvert), Member = "CreateException", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(ExceptionType),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(Exception))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlException), Member = "CreateMessage", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SystemException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(Exception)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		internal XmlException(string res, string arg, int lineNumber, int linePosition)
		{
			throw null;
		}

		// Token: 0x060006FA RID: 1786 RVA: 0x0000439A File Offset: 0x0000259A
		[global::Cpp2ILInjected.Token(Token = "0x6000783")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DAF8F8", Offset = "0x1DAF8F8", Length = "0xE4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "Throw", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "Throw", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "Throw", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DtdParser), Member = "Throw", MemberParameters = new object[]
		{
			typeof(int),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DtdParser), Member = "Throw", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlException), Member = "CreateMessage", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SystemException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(Exception)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		internal XmlException(string res, string arg, int lineNumber, int linePosition, string sourceUri)
		{
			throw null;
		}

		// Token: 0x060006FB RID: 1787 RVA: 0x0000439D File Offset: 0x0000259D
		[global::Cpp2ILInjected.Token(Token = "0x6000784")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DAB96C", Offset = "0x1DAB96C", Length = "0x70")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlConvert), Member = "CreateException", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string[]),
			typeof(ExceptionType),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(Exception))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlException), Member = "CreateMessage", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SystemException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(Exception)
		}, ReturnType = typeof(void))]
		internal XmlException(string res, string[] args, int lineNumber, int linePosition)
		{
			throw null;
		}

		// Token: 0x060006FC RID: 1788 RVA: 0x000043A0 File Offset: 0x000025A0
		[global::Cpp2ILInjected.Token(Token = "0x6000785")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DAF9DC", Offset = "0x1DAF9DC", Length = "0x7C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "Throw", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string[])
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DtdParser), Member = "Throw", MemberParameters = new object[]
		{
			typeof(int),
			typeof(string),
			typeof(string[])
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlException), Member = "CreateMessage", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SystemException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(Exception)
		}, ReturnType = typeof(void))]
		internal XmlException(string res, string[] args, int lineNumber, int linePosition, string sourceUri)
		{
			throw null;
		}

		// Token: 0x060006FD RID: 1789 RVA: 0x000043A3 File Offset: 0x000025A3
		[global::Cpp2ILInjected.Token(Token = "0x6000786")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DAFA58", Offset = "0x1DAFA58", Length = "0x7C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "PushExternalEntityOrSubset", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(Uri),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlException), Member = "CreateMessage", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SystemException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(Exception)
		}, ReturnType = typeof(void))]
		internal XmlException(string res, string[] args, Exception innerException, int lineNumber, int linePosition)
		{
			throw null;
		}

		// Token: 0x060006FE RID: 1790 RVA: 0x000043A6 File Offset: 0x000025A6
		[global::Cpp2ILInjected.Token(Token = "0x6000787")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DAF7A8", Offset = "0x1DAF7A8", Length = "0x80")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "Throw", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string[]),
			typeof(Exception)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ThrowWithoutLineInfo", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string[]),
			typeof(Exception)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlException), Member = "CreateMessage", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SystemException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(Exception)
		}, ReturnType = typeof(void))]
		internal XmlException(string res, string[] args, Exception innerException, int lineNumber, int linePosition, string sourceUri)
		{
			throw null;
		}

		// Token: 0x060006FF RID: 1791 RVA: 0x000043A9 File Offset: 0x000025A9
		[global::Cpp2ILInjected.Token(Token = "0x6000788")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DAF6C4", Offset = "0x1DAF6C4", Length = "0xE4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(Exception),
			typeof(int),
			typeof(int),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlException), Member = "CreateMessage", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		private static string FormatUserMessage(string message, int lineNumber, int linePosition)
		{
			throw null;
		}

		// Token: 0x06000700 RID: 1792 RVA: 0x000043AC File Offset: 0x000025AC
		[global::Cpp2ILInjected.Token(Token = "0x6000789")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DAF190", Offset = "0x1DAF190", Length = "0x270")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(SerializationInfo),
			typeof(StreamingContext)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string[])
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(int),
			typeof(int),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string[]),
			typeof(int),
			typeof(int),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string[]),
			typeof(Exception),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string[]),
			typeof(Exception),
			typeof(int),
			typeof(int),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlException), Member = "FormatUserMessage", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 11)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(int), Member = "ToString", MemberParameters = new object[] { typeof(IFormatProvider) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SR), Member = "GetString", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object[])
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 25)]
		private static string CreateMessage(string res, string[] args, int lineNumber, int linePosition)
		{
			throw null;
		}

		// Token: 0x06000701 RID: 1793 RVA: 0x000043AF File Offset: 0x000025AF
		[global::Cpp2ILInjected.Token(Token = "0x600078A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DA6040", Offset = "0x1DA6040", Length = "0x54")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlEncodedRawTextWriter), Member = "ValidateContentChars", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlUtf8RawTextWriter), Member = "ValidateContentChars", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlWellFormedWriter), Member = "WriteDocType", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlWellFormedWriter), Member = "InvalidCharsException", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int)
		}, ReturnType = typeof(Exception))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlDocument), Member = "CheckName", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DtdParser), Member = "ThrowInvalidChar", MemberParameters = new object[]
		{
			typeof(int),
			typeof(string),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ValidateNames), Member = "ThrowInvalidName", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ValidateNames), Member = "GetInvalidNameException", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(Exception))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlConvert), Member = "TryVerifyName", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(Exception))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlConvert), Member = "VerifyQName", MemberParameters = new object[]
		{
			typeof(string),
			typeof(ExceptionType)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlConvert), Member = "TryVerifyNMTOKEN", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(Exception))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlConvert), Member = "CreateInvalidNameCharException", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int),
			typeof(ExceptionType)
		}, ReturnType = typeof(Exception))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 15)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlException), Member = "BuildCharExceptionArgs", MemberParameters = new object[]
		{
			typeof(char),
			typeof(char)
		}, ReturnType = typeof(string[]))]
		internal static string[] BuildCharExceptionArgs(string data, int invCharIndex)
		{
			throw null;
		}

		// Token: 0x06000702 RID: 1794 RVA: 0x000043B2 File Offset: 0x000025B2
		[global::Cpp2ILInjected.Token(Token = "0x600078B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DAFAD4", Offset = "0x1DAFAD4", Length = "0x2C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ThrowInvalidChar", MemberParameters = new object[]
		{
			typeof(char[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseElement", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseAttributes", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParsePI", MemberParameters = new object[] { typeof(StringBuilder) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseQName", MemberParameters = new object[]
		{
			typeof(bool),
			typeof(int),
			typeof(ref int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DtdParser), Member = "ScanQName", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DtdParser), Member = "ScanNmtoken", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DtdParser), Member = "ThrowInvalidChar", MemberParameters = new object[]
		{
			typeof(char[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 8)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlException), Member = "BuildCharExceptionArgs", MemberParameters = new object[]
		{
			typeof(char),
			typeof(char)
		}, ReturnType = typeof(string[]))]
		internal static string[] BuildCharExceptionArgs(char[] data, int length, int invCharIndex)
		{
			throw null;
		}

		// Token: 0x06000703 RID: 1795 RVA: 0x000043B5 File Offset: 0x000025B5
		[global::Cpp2ILInjected.Token(Token = "0x600078C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DABF0C", Offset = "0x1DABF0C", Length = "0x25C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseElement", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseAttributes", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseAttributeValueSlow", MemberParameters = new object[]
		{
			typeof(int),
			typeof(char),
			"System.Xml.XmlTextReaderImpl.NodeData"
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseNumericCharRefInline", MemberParameters = new object[]
		{
			typeof(int),
			typeof(bool),
			typeof(StringBuilder),
			typeof(ref int),
			typeof(ref XmlTextReaderImpl.EntityType)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseQName", MemberParameters = new object[]
		{
			typeof(bool),
			typeof(int),
			typeof(ref int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseAttributeValueChunk", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DtdParser), Member = "ScanLiteral", MemberParameters = new object[] { "System.Xml.DtdParser.LiteralType" }, ReturnType = "System.Xml.DtdParser.Token")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DtdParser), Member = "ScanQName", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlConvert), Member = "CreateInvalidCharException", MemberParameters = new object[]
		{
			typeof(char),
			typeof(char),
			typeof(ExceptionType)
		}, ReturnType = typeof(Exception))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlException), Member = "BuildCharExceptionArgs", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int)
		}, ReturnType = typeof(string[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlException), Member = "BuildCharExceptionArgs", MemberParameters = new object[]
		{
			typeof(char[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(string[]))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 12)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "CreateString", MemberParameters = new object[] { typeof(char[]) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(char), Member = "ToString", MemberParameters = new object[] { typeof(IFormatProvider) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Format", MemberParameters = new object[]
		{
			typeof(IFormatProvider),
			typeof(string),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 18)]
		internal static string[] BuildCharExceptionArgs(char invChar, char nextChar)
		{
			throw null;
		}

		// Token: 0x170001A4 RID: 420
		// (get) Token: 0x06000704 RID: 1796 RVA: 0x000043B8 File Offset: 0x000025B8
		[global::Cpp2ILInjected.Token(Token = "0x170001C8")]
		public int LineNumber
		{
			[global::Cpp2ILInjected.Token(Token = "0x600078D")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DAFB00", Offset = "0x1DAFB00", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170001A5 RID: 421
		// (get) Token: 0x06000705 RID: 1797 RVA: 0x000043BB File Offset: 0x000025BB
		[global::Cpp2ILInjected.Token(Token = "0x170001C9")]
		public int LinePosition
		{
			[global::Cpp2ILInjected.Token(Token = "0x600078E")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DAFB08", Offset = "0x1DAFB08", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170001A6 RID: 422
		// (get) Token: 0x06000706 RID: 1798 RVA: 0x000043BE File Offset: 0x000025BE
		[global::Cpp2ILInjected.Token(Token = "0x170001CA")]
		public override string Message
		{
			[global::Cpp2ILInjected.Token(Token = "0x600078F")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DAFB10", Offset = "0x1DAFB10", Length = "0x18")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Exception), Member = "get_Message", ReturnType = typeof(string))]
			get
			{
				throw null;
			}
		}

		// Token: 0x170001A7 RID: 423
		// (get) Token: 0x06000707 RID: 1799 RVA: 0x000043C1 File Offset: 0x000025C1
		[global::Cpp2ILInjected.Token(Token = "0x170001CB")]
		internal string ResString
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000790")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DAFB28", Offset = "0x1DAFB28", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x04000254 RID: 596
		[global::Cpp2ILInjected.Token(Token = "0x40003BC")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x90")]
		private string res;

		// Token: 0x04000255 RID: 597
		[global::Cpp2ILInjected.Token(Token = "0x40003BD")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x98")]
		private string[] args;

		// Token: 0x04000256 RID: 598
		[global::Cpp2ILInjected.Token(Token = "0x40003BE")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xA0")]
		private int lineNumber;

		// Token: 0x04000257 RID: 599
		[global::Cpp2ILInjected.Token(Token = "0x40003BF")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xA4")]
		private int linePosition;

		// Token: 0x04000258 RID: 600
		[OptionalField]
		[global::Cpp2ILInjected.Token(Token = "0x40003C0")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xA8")]
		private string sourceUri;

		// Token: 0x04000259 RID: 601
		[global::Cpp2ILInjected.Token(Token = "0x40003C1")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xB0")]
		private string message;
	}
}
