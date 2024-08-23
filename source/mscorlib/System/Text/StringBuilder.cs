using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security;
using System.Security.Cryptography.X509Certificates;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Mono.Security;
using Mono.Security.Cryptography;

namespace System.Text
{
	// Token: 0x020001F3 RID: 499
	[global::Cpp2ILInjected.Token(Token = "0x2000278")]
	[global::System.Serializable]
	[StructLayout(0)]
	public sealed class StringBuilder : global::System.Runtime.Serialization.ISerializable
	{
		// Token: 0x0600138A RID: 5002 RVA: 0x00017BCD File Offset: 0x00015DCD
		[global::Cpp2ILInjected.Token(Token = "0x6001544")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AD3EF0", Offset = "0x1AD3EF0", Length = "0x64")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 120)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public StringBuilder()
		{
			throw null;
		}

		// Token: 0x0600138B RID: 5003 RVA: 0x00017BD0 File Offset: 0x00015DD0
		[global::Cpp2ILInjected.Token(Token = "0x6001545")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AD3F54", Offset = "0x1AD3F54", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 54)]
		public StringBuilder(int capacity)
		{
			throw null;
		}

		// Token: 0x0600138C RID: 5004 RVA: 0x00017BD3 File Offset: 0x00015DD3
		[global::Cpp2ILInjected.Token(Token = "0x6001546")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AD4124", Offset = "0x1AD4124", Length = "0x1C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TypeSpec), Member = "GetDisplayFullName", MemberParameters = new object[] { typeof(global::System.TypeSpec.DisplayNameFormat) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Security.SecurityElement), Member = "Unescape", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Serialization.FormatterServices), Member = "GetClrTypeFullNameForArray", MemberParameters = new object[] { typeof(global::System.Type) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Serialization.FormatterServices), Member = "GetClrTypeFullNameForNonArrayTypes", MemberParameters = new object[] { typeof(global::System.Type) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Reflection.MethodBase), Member = "FormatNameAndSig", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Reflection.ReflectionTypeLoadException), Member = "CreateString", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Reflection.RuntimeMethodInfo), Member = "FormatNameAndSig", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Reflection.RuntimePropertyInfo), Member = "FormatNameAndSig", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Text.RegularExpressions.RegexCharClass", Member = "ParseRecursive", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int)
		}, ReturnType = "System.Text.RegularExpressions.RegexCharClass")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Security.Cryptography.X509Certificates.X500DistinguishedName", Member = "Canonize", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.HttpWebRequest", Member = "GenerateConnectionGroup", MemberParameters = new object[]
		{
			typeof(string),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(StringBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Collections.Specialized.NameValueCollection", Member = "GetAsOneString", MemberParameters = new object[] { typeof(global::System.Collections.ArrayList) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Xml.XmlWellFormedWriter.AttributeValueCache", Member = "Trim", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Xml.XmlDeclaration", Member = "get_InnerText", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.EventSystems.PointerInputModule", Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Mono.Security.X509.X509Store", Member = "GetUniqueName", MemberParameters = new object[]
		{
			typeof(string),
			"System.Byte[]",
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 16)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		public StringBuilder(string value)
		{
			throw null;
		}

		// Token: 0x0600138D RID: 5005 RVA: 0x00017BD6 File Offset: 0x00015DD6
		[global::Cpp2ILInjected.Token(Token = "0x6001547")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AD4140", Offset = "0x1AD4140", Length = "0x1C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.WebHeaderCollection", Member = "ParseHeadersStrict", MemberParameters = new object[]
		{
			"System.Byte[]",
			typeof(int),
			typeof(ref int),
			typeof(ref int),
			typeof(int),
			"System.Net.WebParseError&"
		}, ReturnType = "System.Net.DataParseStatus")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		public StringBuilder(string value, int capacity)
		{
			throw null;
		}

		// Token: 0x0600138E RID: 5006 RVA: 0x00017BD9 File Offset: 0x00015DD9
		[global::Cpp2ILInjected.Token(Token = "0x6001548")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AD415C", Offset = "0x1AD415C", Length = "0x254")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(StringBuilder), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Globalization.CultureData), Member = "UnescapeNlsString", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Math), Member = "Max", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.CompilerServices.RuntimeHelpers), Member = "get_OffsetToStringData", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::SR), Member = "Format", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 22)]
		public StringBuilder(string value, int startIndex, int length, int capacity)
		{
			throw null;
		}

		// Token: 0x0600138F RID: 5007 RVA: 0x00017BDC File Offset: 0x00015DDC
		[global::Cpp2ILInjected.Token(Token = "0x6001549")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AD3F5C", Offset = "0x1AD3F5C", Length = "0x1C8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(StringBuilderCache), Member = "Acquire", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(StringBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Math), Member = "Min", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::SR), Member = "Format", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 20)]
		public StringBuilder(int capacity, int maxCapacity)
		{
			throw null;
		}

		// Token: 0x06001390 RID: 5008 RVA: 0x00017BDF File Offset: 0x00015DDF
		[global::Cpp2ILInjected.Token(Token = "0x600154A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AD4464", Offset = "0x1AD4464", Length = "0x2E4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.Serialization.SerializationInfo), Member = "GetEnumerator", ReturnType = typeof(global::System.Runtime.Serialization.SerializationInfoEnumerator))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.Serialization.SerializationInfoEnumerator), Member = "MoveNext", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.Serialization.SerializationInfoEnumerator), Member = "get_Name", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.Serialization.SerializationInfo), Member = "GetInt32", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.Serialization.SerializationInfo), Member = "GetString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Math), Member = "Max", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Math), Member = "Min", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "CopyTo", MemberParameters = new object[]
		{
			typeof(int),
			typeof(char[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.Serialization.SerializationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 18)]
		private StringBuilder(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			throw null;
		}

		// Token: 0x06001391 RID: 5009 RVA: 0x00017BE2 File Offset: 0x00015DE2
		[global::Cpp2ILInjected.Token(Token = "0x600154B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AD4748", Offset = "0x1AD4748", Length = "0x13C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.Serialization.SerializationInfo), Member = "AddValue", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.Serialization.SerializationInfo), Member = "AddValue", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		private void System.Runtime.Serialization.ISerializable.GetObjectData(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			throw null;
		}

		// Token: 0x170001DF RID: 479
		// (get) Token: 0x06001392 RID: 5010 RVA: 0x00017BE5 File Offset: 0x00015DE5
		// (set) Token: 0x06001393 RID: 5011 RVA: 0x00017BE8 File Offset: 0x00015DE8
		[global::Cpp2ILInjected.Token(Token = "0x17000222")]
		public int Capacity
		{
			[global::Cpp2ILInjected.Token(Token = "0x600154C")]
			[global::Cpp2ILInjected.Address(RVA = "0x1AD4884", Offset = "0x1AD4884", Length = "0x14")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "ReLogic.Text.WrappedTextBuilder", Member = "Append", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Text.StringBuilderCache", Member = "Acquire", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(StringBuilder))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Text.StringBuilderCache", Member = "Release", MemberParameters = new object[] { typeof(StringBuilder) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x600154D")]
			[global::Cpp2ILInjected.Address(RVA = "0x1AD4898", Offset = "0x1AD4898", Length = "0x168")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(StringBuilder), Member = "EnsureCapacity", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.ComponentModel.MaskedTextProvider", Member = "Initialize", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array), Member = "Copy", MemberParameters = new object[]
			{
				typeof(global::System.Array),
				typeof(int),
				typeof(global::System.Array),
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(string),
				typeof(string)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 14)]
			set
			{
				throw null;
			}
		}

		// Token: 0x170001E0 RID: 480
		// (get) Token: 0x06001394 RID: 5012 RVA: 0x00017BEB File Offset: 0x00015DEB
		[global::Cpp2ILInjected.Token(Token = "0x17000223")]
		public int MaxCapacity
		{
			[global::Cpp2ILInjected.Token(Token = "0x600154E")]
			[global::Cpp2ILInjected.Address(RVA = "0x1AD4A0C", Offset = "0x1AD4A0C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06001395 RID: 5013 RVA: 0x00017BEE File Offset: 0x00015DEE
		[global::Cpp2ILInjected.Token(Token = "0x600154F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AD4A14", Offset = "0x1AD4A14", Length = "0xA8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "ReLogic.Text.WrappedTextBuilder", Member = "Append", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = "set_Capacity", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public int EnsureCapacity(int capacity)
		{
			throw null;
		}

		// Token: 0x06001396 RID: 5014 RVA: 0x00017BF1 File Offset: 0x00015DF1
		[global::Cpp2ILInjected.Token(Token = "0x6001550")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AD4ABC", Offset = "0x1AD4ABC", Length = "0x128")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "FastAllocateString", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.CompilerServices.RuntimeHelpers), Member = "get_OffsetToStringData", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "wstrcpy", MemberParameters = new object[]
		{
			typeof(char*),
			typeof(char*),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public unsafe override string ToString()
		{
			throw null;
		}

		// Token: 0x06001397 RID: 5015 RVA: 0x00017BF4 File Offset: 0x00015DF4
		[global::Cpp2ILInjected.Token(Token = "0x6001551")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AD4BE4", Offset = "0x1AD4BE4", Length = "0x1C4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(StringBuilder), Member = "AppendCore", MemberParameters = new object[]
		{
			typeof(StringBuilder),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(StringBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.ComponentModel.MaskedTextProvider", Member = "ToString", MemberParameters = new object[]
		{
			typeof(bool),
			typeof(bool),
			typeof(bool),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Xml.XmlTextReaderImpl", Member = "ParseAttributeValueSlow", MemberParameters = new object[]
		{
			typeof(int),
			typeof(char),
			"System.Xml.XmlTextReaderImpl.NodeData"
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "FastAllocateString", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.CompilerServices.RuntimeHelpers), Member = "get_OffsetToStringData", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = "CopyTo", MemberParameters = new object[]
		{
			typeof(int),
			typeof(global::System.Span<char>),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 17)]
		public string ToString(int startIndex, int length)
		{
			throw null;
		}

		// Token: 0x06001398 RID: 5016 RVA: 0x00017BF7 File Offset: 0x00015DF7
		[global::Cpp2ILInjected.Token(Token = "0x6001552")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AD4F70", Offset = "0x1AD4F70", Length = "0x1C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 34)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = "set_Length", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		public StringBuilder Clear()
		{
			throw null;
		}

		// Token: 0x170001E1 RID: 481
		// (get) Token: 0x06001399 RID: 5017 RVA: 0x00017BFA File Offset: 0x00015DFA
		// (set) Token: 0x0600139A RID: 5018 RVA: 0x00017BFD File Offset: 0x00015DFD
		[global::Cpp2ILInjected.Token(Token = "0x17000224")]
		public int Length
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001553")]
			[global::Cpp2ILInjected.Address(RVA = "0x1AD4A00", Offset = "0x1AD4A00", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 195)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6001554")]
			[global::Cpp2ILInjected.Address(RVA = "0x1AD4F8C", Offset = "0x1AD4F8C", Length = "0x230")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 43)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Math), Member = "Max", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Math), Member = "Min", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array), Member = "Copy", MemberParameters = new object[]
			{
				typeof(global::System.Array),
				typeof(int),
				typeof(global::System.Array),
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(string),
				typeof(string)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 13)]
			set
			{
				throw null;
			}
		}

		// Token: 0x170001E2 RID: 482
		[global::Cpp2ILInjected.Token(Token = "0x17000225")]
		[IndexerName("Chars")]
		public char this[int index]
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001555")]
			[global::Cpp2ILInjected.Address(RVA = "0x1AD52F8", Offset = "0x1AD52F8", Length = "0x6C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 38)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.IndexOutOfRangeException), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6001556")]
			[global::Cpp2ILInjected.Address(RVA = "0x1AD5364", Offset = "0x1AD5364", Length = "0x9C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Normalization), Member = "CombineHangul", MemberParameters = new object[]
			{
				typeof(StringBuilder),
				typeof(string),
				typeof(int)
			}, ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Normalization), Member = "TryComposeWithPreviousStarter", MemberParameters = new object[]
			{
				typeof(StringBuilder),
				typeof(string),
				typeof(int)
			}, ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Normalization), Member = "ReorderCanonical", MemberParameters = new object[]
			{
				typeof(string),
				typeof(ref StringBuilder),
				typeof(int)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Text.RegularExpressions.RegexCharClass", Member = "ToStringClass", ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.ComponentModel.MaskedTextProvider", Member = "set_PromptChar", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.ComponentModel.MaskedTextProvider", Member = "ResetChar", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.ComponentModel.MaskedTextProvider", Member = "SetChar", MemberParameters = new object[]
			{
				typeof(char),
				typeof(int),
				"System.ComponentModel.MaskedTextProvider.CharDescriptor"
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Xml.Schema.XsdDuration", Member = "ToString", MemberParameters = new object[] { "System.Xml.Schema.XsdDuration.DurationType" }, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 9)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(string),
				typeof(string)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
			set
			{
				throw null;
			}
		}

		// Token: 0x0600139D RID: 5021 RVA: 0x00017C06 File Offset: 0x00015E06
		[global::Cpp2ILInjected.Token(Token = "0x6001557")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AD51BC", Offset = "0x1AD51BC", Length = "0x124")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.ArraySpec), Member = "Append", MemberParameters = new object[] { typeof(StringBuilder) }, ReturnType = typeof(StringBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.PointerSpec), Member = "Append", MemberParameters = new object[] { typeof(StringBuilder) }, ReturnType = typeof(StringBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.PointerSpec), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(StringBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(StringBuilder), Member = "AppendFormatHelper", MemberParameters = new object[]
		{
			typeof(global::System.IFormatProvider),
			typeof(string),
			typeof(global::System.ParamsArray)
		}, ReturnType = typeof(StringBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.PasteArguments", Member = "AppendArgument", MemberParameters = new object[]
		{
			typeof(StringBuilder),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "InControl.Internal.CodeWriter", Member = "Append", MemberParameters = new object[]
		{
			typeof(bool),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "InControl.Internal.CodeWriter", Member = "AppendLine", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 12)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = "ExpandByABlock", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		public StringBuilder Append(char value, int repeatCount)
		{
			throw null;
		}

		// Token: 0x0600139E RID: 5022 RVA: 0x00017C09 File Offset: 0x00015E09
		[global::Cpp2ILInjected.Token(Token = "0x6001558")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AD55A4", Offset = "0x1AD55A4", Length = "0x130")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 42)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new object[]
		{
			typeof(char*),
			typeof(int)
		}, ReturnType = typeof(StringBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 14)]
		public unsafe StringBuilder Append(char[] value, int startIndex, int charCount)
		{
			throw null;
		}

		// Token: 0x0600139F RID: 5023 RVA: 0x00017C0C File Offset: 0x00015E0C
		[global::Cpp2ILInjected.Token(Token = "0x6001559")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AD5818", Offset = "0x1AD5818", Length = "0xD4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 695)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.CompilerServices.RuntimeHelpers), Member = "get_OffsetToStringData", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "wstrcpy", MemberParameters = new object[]
		{
			typeof(char*),
			typeof(char*),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = "AppendHelper", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(char))]
		public unsafe StringBuilder Append(string value)
		{
			throw null;
		}

		// Token: 0x060013A0 RID: 5024 RVA: 0x00017C0F File Offset: 0x00015E0F
		[global::Cpp2ILInjected.Token(Token = "0x600155A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AD58EC", Offset = "0x1AD58EC", Length = "0x3C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(StringBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.CompilerServices.RuntimeHelpers), Member = "get_OffsetToStringData", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new object[]
		{
			typeof(char*),
			typeof(int)
		}, ReturnType = typeof(StringBuilder))]
		private unsafe void AppendHelper(string value)
		{
			throw null;
		}

		// Token: 0x060013A1 RID: 5025 RVA: 0x00017C12 File Offset: 0x00015E12
		[global::Cpp2ILInjected.Token(Token = "0x600155B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AD5928", Offset = "0x1AD5928", Length = "0x138")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Environment), Member = "ExpandEnvironmentVariables", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(StringBuilder), Member = "AppendFormatHelper", MemberParameters = new object[]
		{
			typeof(global::System.IFormatProvider),
			typeof(string),
			typeof(global::System.ParamsArray)
		}, ReturnType = typeof(StringBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Normalization), Member = "Decompose", MemberParameters = new object[]
		{
			typeof(string),
			typeof(ref StringBuilder),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Normalization), Member = "ReorderCanonical", MemberParameters = new object[]
		{
			typeof(string),
			typeof(ref StringBuilder),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Normalization), Member = "DecomposeChar", MemberParameters = new object[]
		{
			typeof(ref StringBuilder),
			typeof(ref int[]),
			typeof(string),
			typeof(int),
			typeof(int),
			typeof(ref int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Globalization.Bootstring), Member = "Decode", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Text.RegularExpressions.Regex", Member = "Replace", MemberParameters = new object[]
		{
			"System.Text.RegularExpressions.MatchEvaluator",
			"System.Text.RegularExpressions.Regex",
			typeof(string),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Text.RegularExpressions.RegexParser", Member = "Escape", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Text.RegularExpressions.RegexReplacement", Member = "Replace", MemberParameters = new object[]
		{
			"System.Text.RegularExpressions.Regex",
			typeof(string),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Xml.XmlTextReaderImpl.NodeData", Member = "CopyTo", MemberParameters = new object[]
		{
			typeof(int),
			typeof(StringBuilder)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Xml.XmlTextReaderImpl", Member = "StripSpaces", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Xml.DtdParser", Member = "StripSpaces", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Xml.XmlComplianceUtil", Member = "NonCDataNormalize", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Xml.XmlComplianceUtil", Member = "CDataNormalize", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Xml.XmlConvert", Member = "DecodeName", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Xml.XmlConvert", Member = "EncodeName", MemberParameters = new object[]
		{
			typeof(string),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 30)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.CompilerServices.RuntimeHelpers), Member = "get_OffsetToStringData", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new object[]
		{
			typeof(char*),
			typeof(int)
		}, ReturnType = typeof(StringBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 12)]
		public unsafe StringBuilder Append(string value, int startIndex, int count)
		{
			throw null;
		}

		// Token: 0x060013A2 RID: 5026 RVA: 0x00017C15 File Offset: 0x00015E15
		[global::Cpp2ILInjected.Token(Token = "0x600155C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AD5A60", Offset = "0x1AD5A60", Length = "0x1C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "ReLogic.Text.WrappedTextBuilder", Member = "CommitWorkingLine", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Text.RegularExpressions.RegexCharClass", Member = "ToStringClass", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		public StringBuilder Append(StringBuilder value)
		{
			throw null;
		}

		// Token: 0x060013A3 RID: 5027 RVA: 0x00017C18 File Offset: 0x00015E18
		[global::Cpp2ILInjected.Token(Token = "0x600155D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AD5A7C", Offset = "0x1AD5A7C", Length = "0x238")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Math), Member = "Min", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = "ExpandByABlock", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = "CopyTo", MemberParameters = new object[]
		{
			typeof(int),
			typeof(global::System.Span<char>),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = "ToString", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(StringBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
		private StringBuilder AppendCore(StringBuilder value, int startIndex, int count)
		{
			throw null;
		}

		// Token: 0x060013A4 RID: 5028 RVA: 0x00017C1B File Offset: 0x00015E1B
		[global::Cpp2ILInjected.Token(Token = "0x600155E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AD5CB4", Offset = "0x1AD5CB4", Length = "0x20")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.TimeLogger", Member = "EndDrawFrame", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.AggregateException), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Security.Cryptography.X509Certificates.X509Certificate), Member = "ToString", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Reflection.ReflectionTypeLoadException), Member = "CreateString", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Security.Cryptography.X509Certificates.X509Certificate2", Member = "ToString", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Security.Cryptography.X509Certificates.X509Certificate2ImplUnix", Member = "AppendPrivateKeyInfo", MemberParameters = new object[] { typeof(StringBuilder) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.Sockets.SafeSocketHandle", Member = "ReleaseHandle", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Serialization.MemoryTraceWriter", Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.EventSystems.EventSystem", Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.EventSystems.PointerInputModule", Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 45)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Environment), Member = "get_NewLine", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(StringBuilder))]
		public StringBuilder AppendLine()
		{
			throw null;
		}

		// Token: 0x060013A5 RID: 5029 RVA: 0x00017C1E File Offset: 0x00015E1E
		[global::Cpp2ILInjected.Token(Token = "0x600155F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AD5CD4", Offset = "0x1AD5CD4", Length = "0x24")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "GUICraftGuidePopup", Member = "UpdateText", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "VirtualControllerInputState", Member = "SaveCodeArrayCategories", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.MessageBuffer", Member = "ProcessData", MemberParameters = new object[]
		{
			"System.Byte[]",
			typeof(int),
			typeof(ref int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.NetMessage", Member = "SendData", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			"Terraria.Localization.NetworkText",
			typeof(int),
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.TimeLogger", Member = "NewDrawFrame", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.TimeLogger", Member = "EndDrawFrame", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.TimeLogger", Member = "UpdateTime", MemberParameters = new object[]
		{
			"TimeLogData[]",
			typeof(int),
			typeof(double)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.TimeLogger", Member = "MenuDrawTime", MemberParameters = new object[] { typeof(double) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.TimeLogger", Member = "SplashDrawTime", MemberParameters = new object[] { typeof(double) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.TimeLogger", Member = "MapDrawTime", MemberParameters = new object[] { typeof(double) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.TimeLogger", Member = "DrawException", MemberParameters = new object[] { typeof(global::System.Exception) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Security.Cryptography.X509Certificates.X509Certificate), Member = "ToString", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Security.Cryptography.X509Certificates.X509Certificate2", Member = "ToString", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Security.Cryptography.X509Certificates.X509Certificate2ImplUnix", Member = "AppendPrivateKeyInfo", MemberParameters = new object[] { typeof(StringBuilder) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.Sockets.SafeSocketHandle", Member = "ReleaseHandle", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.EventSystems.PointerEventData", Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.EventSystems.EventSystem", Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.EventSystems.PointerInputModule", Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.EventSystems.TouchInputModule", Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 71)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(StringBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Environment), Member = "get_NewLine", ReturnType = typeof(string))]
		public StringBuilder AppendLine(string value)
		{
			throw null;
		}

		// Token: 0x060013A6 RID: 5030 RVA: 0x00017C21 File Offset: 0x00015E21
		[global::Cpp2ILInjected.Token(Token = "0x6001560")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AD4DA8", Offset = "0x1AD4DA8", Length = "0x1C8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeFormat), Member = "TryFormat", MemberParameters = new object[]
		{
			typeof(global::System.DateTime),
			typeof(global::System.Span<char>),
			typeof(ref int),
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.IFormatProvider),
			typeof(global::System.TimeSpan)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Version), Member = "TryFormat", MemberParameters = new object[]
		{
			typeof(global::System.Span<char>),
			typeof(int),
			typeof(ref int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(StringBuilder), Member = "ToString", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(StringBuilder), Member = "AppendCore", MemberParameters = new object[]
		{
			typeof(StringBuilder),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(StringBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Globalization.TimeSpanFormat), Member = "TryFormat", MemberParameters = new object[]
		{
			typeof(global::System.TimeSpan),
			typeof(global::System.Span<char>),
			typeof(ref int),
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.IFormatProvider)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.IPAddressParser", Member = "IPv6AddressToString", MemberParameters = new object[]
		{
			"System.UInt16[]",
			typeof(uint),
			"System.Span`1<Char>",
			typeof(ref int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Math), Member = "Min", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = "ThreadSafeCopy", MemberParameters = new object[]
		{
			typeof(char[]),
			typeof(int),
			typeof(global::System.Span<char>),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 14)]
		public void CopyTo(int sourceIndex, global::System.Span<char> destination, int count)
		{
			throw null;
		}

		// Token: 0x060013A7 RID: 5031 RVA: 0x00017C24 File Offset: 0x00015E24
		[global::Cpp2ILInjected.Token(Token = "0x6001561")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AD5E4C", Offset = "0x1AD5E4C", Length = "0x134")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "GUIControlsBanner", Member = "AddAction", MemberParameters = new object[]
		{
			"GUIControlsBanner.Action",
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "GUIControlsBanner", Member = "AddMore", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "GUICraftGuidePopup", Member = "UpdateText", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeFormat), Member = "FormatCustomized", MemberParameters = new object[]
		{
			typeof(global::System.DateTime),
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.Globalization.DateTimeFormatInfo),
			typeof(global::System.TimeSpan),
			typeof(StringBuilder)
		}, ReturnType = typeof(StringBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Normalization), Member = "CombineHangul", MemberParameters = new object[]
		{
			typeof(StringBuilder),
			typeof(string),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Normalization), Member = "TryComposeWithPreviousStarter", MemberParameters = new object[]
		{
			typeof(StringBuilder),
			typeof(string),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Serialization.FormatterServices), Member = "GetClrTypeFullNameForNonArrayTypes", MemberParameters = new object[] { typeof(global::System.Type) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 7)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = "set_Length", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = "Remove", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(ref StringBuilder),
			typeof(ref int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 12)]
		public StringBuilder Remove(int startIndex, int length)
		{
			throw null;
		}

		// Token: 0x060013A8 RID: 5032 RVA: 0x00017C27 File Offset: 0x00015E27
		[global::Cpp2ILInjected.Token(Token = "0x6001562")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AD60C0", Offset = "0x1AD60C0", Length = "0x3C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 220)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new object[]
		{
			typeof(char),
			typeof(int)
		}, ReturnType = typeof(StringBuilder))]
		public StringBuilder Append(char value)
		{
			throw null;
		}

		// Token: 0x060013A9 RID: 5033 RVA: 0x00017C2A File Offset: 0x00015E2A
		[global::Cpp2ILInjected.Token(Token = "0x6001563")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AD60FC", Offset = "0x1AD60FC", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Security.Cryptography.DerSequenceReader", Member = "ReadOidAsString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.FtpControlStream", Member = "FormatAddress", MemberParameters = new object[]
		{
			"System.Net.IPAddress",
			typeof(int)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = "AppendSpanFormattable", MemberTypeParameters = new object[] { "T" }, MemberParameters = new object[] { "T" }, ReturnType = typeof(StringBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public StringBuilder Append(byte value)
		{
			throw null;
		}

		// Token: 0x060013AA RID: 5034 RVA: 0x00017C2D File Offset: 0x00015E2D
		[global::Cpp2ILInjected.Token(Token = "0x6001564")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AD6154", Offset = "0x1AD6154", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "GUIBestiary", Member = "NPCDraw", MemberParameters = new object[]
		{
			"ItemGrid_Layout",
			typeof(int),
			"Microsoft.Xna.Framework.Vector2",
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "GUIBossBar", Member = "Draw", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float),
			"Microsoft.Xna.Framework.Graphics.Texture2D",
			"Microsoft.Xna.Framework.Rectangle",
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "GUIResearch", Member = "DrawItemProgress", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "GUIVirtualInputController", Member = "Draw", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Microsoft.Xna.Framework.Input.JoystickState", Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Version), Member = "ToCachedStringBuilder", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(StringBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.ParameterizedStrings), Member = "EvaluateInternal", MemberParameters = new object[]
		{
			typeof(string),
			typeof(ref int),
			typeof(global::System.ParameterizedStrings.FormatParam[]),
			"System.ParameterizedStrings.LowLevelStack",
			typeof(ref global::System.ParameterizedStrings.FormatParam[]),
			typeof(ref global::System.ParameterizedStrings.FormatParam[])
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Globalization.TimeSpanFormat), Member = "FormatStandard", MemberParameters = new object[]
		{
			typeof(global::System.TimeSpan),
			typeof(bool),
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.Globalization.TimeSpanFormat.Pattern)
		}, ReturnType = typeof(StringBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Diagnostics.StackFrame), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Security.Cryptography.X509Certificates.X509BasicConstraintsExtension", Member = "ToString", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Security.Cryptography.X509Certificates.X509Certificate2", Member = "ToString", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.FtpControlStream", Member = "FormatAddress", MemberParameters = new object[]
		{
			"System.Net.IPAddress",
			typeof(int)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.CookieContainer", Member = "Add", MemberParameters = new object[] { "System.Net.Cookie" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.HttpListenerResponse", Member = "CookieToClientString", MemberParameters = new object[] { "System.Net.Cookie" }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.WebConnectionTunnel.<Initialize>d__42", Member = "MoveNext", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.JsonPosition", Member = "WriteTo", MemberParameters = new object[] { typeof(StringBuilder) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 29)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder[]), Member = "AppendSpanFormattable", MemberTypeParameters = new object[] { typeof(int) }, MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(StringBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public StringBuilder Append(int value)
		{
			throw null;
		}

		// Token: 0x060013AB RID: 5035 RVA: 0x00017C30 File Offset: 0x00015E30
		[global::Cpp2ILInjected.Token(Token = "0x6001565")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AD61AC", Offset = "0x1AD61AC", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.IPv6AddressFormatter", Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder[]), Member = "AppendSpanFormattable", MemberTypeParameters = new object[] { typeof(long) }, MemberParameters = new object[] { typeof(long) }, ReturnType = typeof(StringBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public StringBuilder Append(long value)
		{
			throw null;
		}

		// Token: 0x060013AC RID: 5036 RVA: 0x00017C33 File Offset: 0x00015E33
		[global::Cpp2ILInjected.Token(Token = "0x6001566")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AD6204", Offset = "0x1AD6204", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Microsoft.Xna.Framework.Quaternion", Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Microsoft.Xna.Framework.Vector2", Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Microsoft.Xna.Framework.Vector3", Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Microsoft.Xna.Framework.Vector4", Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 13)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder[]), Member = "AppendSpanFormattable", MemberTypeParameters = new object[] { typeof(float) }, MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(StringBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public StringBuilder Append(float value)
		{
			throw null;
		}

		// Token: 0x060013AD RID: 5037 RVA: 0x00017C36 File Offset: 0x00015E36
		[global::System.CLSCompliant(false)]
		[global::Cpp2ILInjected.Token(Token = "0x6001567")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AD625C", Offset = "0x1AD625C", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.IPAddressParser", Member = "IPv6AddressToStringHelper", MemberParameters = new object[]
		{
			"System.UInt16[]",
			typeof(uint)
		}, ReturnType = typeof(StringBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder[]), Member = "AppendSpanFormattable", MemberTypeParameters = new object[] { typeof(uint) }, MemberParameters = new object[] { typeof(uint) }, ReturnType = typeof(StringBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public StringBuilder Append(uint value)
		{
			throw null;
		}

		// Token: 0x060013AE RID: 5038 RVA: 0x00017C39 File Offset: 0x00015E39
		[global::Cpp2ILInjected.Token(Token = "0x6001568")]
		[global::Cpp2ILInjected.Address(RVA = "0x159F7DC", Offset = "0x159F7DC", Length = "0x90")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new object[] { typeof(byte) }, ReturnType = typeof(StringBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Globalization.CultureInfo), Member = "get_CurrentCulture", ReturnType = typeof(global::System.Globalization.CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(byte), Member = "ToString", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.IFormatProvider)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(StringBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private StringBuilder AppendSpanFormattable<T>(T value) where T : global::System.IFormattable
		{
			throw null;
		}

		// Token: 0x060013AF RID: 5039 RVA: 0x00017C3C File Offset: 0x00015E3C
		[global::Cpp2ILInjected.Token(Token = "0x6001569")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AD62B4", Offset = "0x1AD62B4", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.GameInput.PlayerInput", Member = "InvalidateKeyboardSwap", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.GameInput.PlayerInput", Member = "ResetInputsOnActiveStateChange", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Tuple<, >), Member = "System.ITupleInternal.ToString", MemberParameters = new object[] { typeof(StringBuilder) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Tuple<, , >), Member = "System.ITupleInternal.ToString", MemberParameters = new object[] { typeof(StringBuilder) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Tuple<, , , >), Member = "System.ITupleInternal.ToString", MemberParameters = new object[] { typeof(StringBuilder) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Collections.Generic.KeyValuePair), Member = "PairToString", MemberParameters = new object[]
		{
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Security.Cryptography.DerSequenceReader", Member = "ReadOidAsString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 14)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(StringBuilder))]
		public StringBuilder Append(object value)
		{
			throw null;
		}

		// Token: 0x060013B0 RID: 5040 RVA: 0x00017C3F File Offset: 0x00015E3F
		[global::Cpp2ILInjected.Token(Token = "0x600156A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AD62EC", Offset = "0x1AD62EC", Length = "0x20")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Security.Cryptography.X509Certificates.X509Certificate), Member = "ToString", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Xml.Schema.XsdDateTime", Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Xml.Schema.XsdDateTime", Member = "PrintDate", MemberParameters = new object[] { typeof(StringBuilder) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Xml.Schema.XsdDateTime", Member = "PrintTime", MemberParameters = new object[] { typeof(StringBuilder) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Xml.Schema.XsdDateTime", Member = "PrintZone", MemberParameters = new object[] { typeof(StringBuilder) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 7)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new object[]
		{
			typeof(char*),
			typeof(int)
		}, ReturnType = typeof(StringBuilder))]
		public unsafe StringBuilder Append(char[] value)
		{
			throw null;
		}

		// Token: 0x060013B1 RID: 5041 RVA: 0x00017C42 File Offset: 0x00015E42
		[global::Cpp2ILInjected.Token(Token = "0x600156B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AD630C", Offset = "0x1AD630C", Length = "0x88")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Text.RegularExpressions.RegexReplacement", Member = "ReplacementImpl", MemberParameters = new object[]
		{
			typeof(StringBuilder),
			"System.Text.RegularExpressions.Match"
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.InteropServices.MemoryMarshal[]), Member = "GetReference", MemberTypeParameters = new object[] { typeof(char) }, MemberParameters = new object[] { typeof(global::System.ReadOnlySpan<char>) }, ReturnType = "T&")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new object[]
		{
			typeof(char*),
			typeof(int)
		}, ReturnType = typeof(StringBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public unsafe StringBuilder Append(global::System.ReadOnlySpan<char> value)
		{
			throw null;
		}

		// Token: 0x060013B2 RID: 5042 RVA: 0x00017C45 File Offset: 0x00015E45
		[global::Cpp2ILInjected.Token(Token = "0x600156C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AD6394", Offset = "0x1AD6394", Length = "0xB0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Enum), Member = "InternalFlagsFormat", MemberParameters = new object[]
		{
			typeof(global::System.RuntimeType),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.CompilerServices.RuntimeHelpers), Member = "get_OffsetToStringData", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = "Insert", MemberParameters = new object[]
		{
			typeof(int),
			typeof(char*),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public unsafe StringBuilder Insert(int index, string value)
		{
			throw null;
		}

		// Token: 0x060013B3 RID: 5043 RVA: 0x00017C48 File Offset: 0x00015E48
		[global::Cpp2ILInjected.Token(Token = "0x600156D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AD6514", Offset = "0x1AD6514", Length = "0x2C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Globalization.HebrewNumber), Member = "ToString", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Globalization.Bootstring), Member = "Decode", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = "Insert", MemberParameters = new object[]
		{
			typeof(int),
			typeof(char*),
			typeof(int)
		}, ReturnType = typeof(void))]
		public unsafe StringBuilder Insert(int index, char value)
		{
			throw null;
		}

		// Token: 0x060013B4 RID: 5044 RVA: 0x00017C4B File Offset: 0x00015E4B
		[global::Cpp2ILInjected.Token(Token = "0x600156E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AD6540", Offset = "0x1AD6540", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Mono.Security.ASN1), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Mono.Security.Cryptography.KeyPairPersistence), Member = "ToXml", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Diagnostics.StackTrace), Member = "AddFrames", MemberParameters = new object[]
		{
			typeof(StringBuilder),
			typeof(bool),
			typeof(ref bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Security.Cryptography.AsnEncodedData", Member = "NetscapeCertType", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.DigestSession", Member = "Authenticate", MemberParameters = new object[] { "System.Net.WebRequest", "System.Net.ICredentials" }, ReturnType = "System.Net.Authorization")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.IPv6AddressFormatter", Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Mono.Security.ASN1", Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 18)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ParamsArray), Member = ".ctor", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = "AppendFormatHelper", MemberParameters = new object[]
		{
			typeof(global::System.IFormatProvider),
			typeof(string),
			typeof(global::System.ParamsArray)
		}, ReturnType = typeof(StringBuilder))]
		public StringBuilder AppendFormat(string format, object arg0)
		{
			throw null;
		}

		// Token: 0x060013B5 RID: 5045 RVA: 0x00017C4E File Offset: 0x00015E4E
		[global::Cpp2ILInjected.Token(Token = "0x600156F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AD70C0", Offset = "0x1AD70C0", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Mono.Security.ASN1), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Mono.Security.Cryptography.KeyPairPersistence), Member = "ToXml", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Diagnostics.StackFrame), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Diagnostics.StackTrace), Member = "AddFrames", MemberParameters = new object[]
		{
			typeof(StringBuilder),
			typeof(bool),
			typeof(ref bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Mono.Security.ASN1", Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 10)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ParamsArray), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = "AppendFormatHelper", MemberParameters = new object[]
		{
			typeof(global::System.IFormatProvider),
			typeof(string),
			typeof(global::System.ParamsArray)
		}, ReturnType = typeof(StringBuilder))]
		public StringBuilder AppendFormat(string format, object arg0, object arg1)
		{
			throw null;
		}

		// Token: 0x060013B6 RID: 5046 RVA: 0x00017C51 File Offset: 0x00015E51
		[global::Cpp2ILInjected.Token(Token = "0x6001570")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AD711C", Offset = "0x1AD711C", Length = "0xB4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Mono.Security.ASN1), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Reflection.CustomAttributeData), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.HttpWebRequest", Member = "GetRequestHeaders", ReturnType = "System.Byte[]")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Mono.Security.ASN1", Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ParamsArray), Member = ".ctor", MemberParameters = new object[] { typeof(object[]) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = "AppendFormatHelper", MemberParameters = new object[]
		{
			typeof(global::System.IFormatProvider),
			typeof(string),
			typeof(global::System.ParamsArray)
		}, ReturnType = typeof(StringBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public StringBuilder AppendFormat(string format, params object[] args)
		{
			throw null;
		}

		// Token: 0x060013B7 RID: 5047 RVA: 0x00017C54 File Offset: 0x00015E54
		[global::Cpp2ILInjected.Token(Token = "0x6001571")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AD71D0", Offset = "0x1AD71D0", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.AggregateException), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeFormat), Member = "FormatCustomizedTimeZone", MemberParameters = new object[]
		{
			typeof(global::System.DateTime),
			typeof(global::System.TimeSpan),
			typeof(global::System.ReadOnlySpan<char>),
			typeof(int),
			typeof(bool),
			typeof(StringBuilder)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DecoderFallbackBuffer), Member = "ThrowLastBytesRecursive", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ParamsArray), Member = ".ctor", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = "AppendFormatHelper", MemberParameters = new object[]
		{
			typeof(global::System.IFormatProvider),
			typeof(string),
			typeof(global::System.ParamsArray)
		}, ReturnType = typeof(StringBuilder))]
		public StringBuilder AppendFormat(global::System.IFormatProvider provider, string format, object arg0)
		{
			throw null;
		}

		// Token: 0x060013B8 RID: 5048 RVA: 0x00017C57 File Offset: 0x00015E57
		[global::Cpp2ILInjected.Token(Token = "0x6001572")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AD722C", Offset = "0x1AD722C", Length = "0x4C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(StringBuilder), Member = "AppendFormatHelper", MemberParameters = new object[]
		{
			typeof(global::System.IFormatProvider),
			typeof(string),
			typeof(global::System.ParamsArray)
		}, ReturnType = typeof(StringBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.FormatException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		private static void FormatError()
		{
			throw null;
		}

		// Token: 0x060013B9 RID: 5049 RVA: 0x00017C5A File Offset: 0x00015E5A
		[global::Cpp2ILInjected.Token(Token = "0x6001573")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AD6598", Offset = "0x1AD6598", Length = "0xB28")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(string), Member = "FormatHelper", MemberParameters = new object[]
		{
			typeof(global::System.IFormatProvider),
			typeof(string),
			typeof(global::System.ParamsArray)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(StringBuilder), Member = "AppendFormat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object)
		}, ReturnType = typeof(StringBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(StringBuilder), Member = "AppendFormat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(StringBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(StringBuilder), Member = "AppendFormat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object[])
		}, ReturnType = typeof(StringBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(StringBuilder), Member = "AppendFormat", MemberParameters = new object[]
		{
			typeof(global::System.IFormatProvider),
			typeof(string),
			typeof(object)
		}, ReturnType = typeof(StringBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(global::System.RuntimeTypeHandle) }, ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(StringBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ParamsArray), Member = "get_Length", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ParamsArray), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(StringBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException", MemberParameters = new object[] { typeof(global::System.ExceptionArgument) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(ref char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = "set_Length", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "CreateString", MemberParameters = new object[] { typeof(global::System.ReadOnlySpan<char>) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new object[]
		{
			typeof(char),
			typeof(int)
		}, ReturnType = typeof(StringBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(StringBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = "FormatError", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.FormatException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 31)]
		internal StringBuilder AppendFormatHelper(global::System.IFormatProvider provider, string format, global::System.ParamsArray args)
		{
			throw null;
		}

		// Token: 0x060013BA RID: 5050 RVA: 0x00017C5D File Offset: 0x00015E5D
		[global::Cpp2ILInjected.Token(Token = "0x6001574")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AD7278", Offset = "0x1AD7278", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Localization.LocalizedText", Member = "FormatWith", MemberParameters = new object[]
		{
			typeof(object),
			typeof(StringBuilder)
		}, ReturnType = typeof(StringBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Security.SecurityElement), Member = "Unescape", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
		public StringBuilder Replace(string oldValue, string newValue)
		{
			throw null;
		}

		// Token: 0x060013BB RID: 5051 RVA: 0x00017C60 File Offset: 0x00015E60
		[global::Cpp2ILInjected.Token(Token = "0x6001575")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AD7288", Offset = "0x1AD7288", Length = "0x308")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = "StartsWith", MemberParameters = new object[]
		{
			typeof(StringBuilder),
			typeof(int),
			typeof(int),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array[]), Member = "Resize", MemberTypeParameters = new object[] { typeof(int) }, MemberParameters = new object[]
		{
			typeof(ref int[]),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = "ReplaceAllInChunk", MemberParameters = new object[]
		{
			typeof(int[]),
			typeof(int),
			typeof(StringBuilder),
			typeof(int),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 19)]
		public StringBuilder Replace(string oldValue, string newValue, int startIndex, int count)
		{
			throw null;
		}

		// Token: 0x060013BC RID: 5052 RVA: 0x00017C63 File Offset: 0x00015E63
		[global::System.CLSCompliant(false)]
		[global::Cpp2ILInjected.Token(Token = "0x6001576")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AD56D4", Offset = "0x1AD56D4", Length = "0x144")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeFormat), Member = "FormatDigits", MemberParameters = new object[]
		{
			typeof(StringBuilder),
			typeof(int),
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new object[]
		{
			typeof(char[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(StringBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(StringBuilder), Member = "AppendHelper", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(StringBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new object[] { typeof(char[]) }, ReturnType = typeof(StringBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new object[] { typeof(global::System.ReadOnlySpan<char>) }, ReturnType = typeof(StringBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.IPAddressParser", Member = "IPv4AddressToString", MemberParameters = new object[]
		{
			typeof(uint),
			typeof(StringBuilder)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.IPAddressParser", Member = "IPv6AddressToStringHelper", MemberParameters = new object[]
		{
			"System.UInt16[]",
			typeof(uint)
		}, ReturnType = typeof(StringBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.IPAddressParser", Member = "AppendHex", MemberParameters = new object[]
		{
			typeof(ushort),
			typeof(StringBuilder)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 9)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = "ThreadSafeCopy", MemberParameters = new object[]
		{
			typeof(char*),
			typeof(char[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = "ExpandByABlock", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		public unsafe StringBuilder Append(char* value, int valueCount)
		{
			throw null;
		}

		// Token: 0x060013BD RID: 5053 RVA: 0x00017C66 File Offset: 0x00015E66
		[global::Cpp2ILInjected.Token(Token = "0x6001577")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AD6444", Offset = "0x1AD6444", Length = "0xD0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(StringBuilder), Member = "Insert", MemberParameters = new object[]
		{
			typeof(int),
			typeof(string)
		}, ReturnType = typeof(StringBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(StringBuilder), Member = "Insert", MemberParameters = new object[]
		{
			typeof(int),
			typeof(char)
		}, ReturnType = typeof(StringBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = "MakeRoom", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(ref StringBuilder),
			typeof(ref int),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = "ReplaceInPlaceAtChunk", MemberParameters = new object[]
		{
			typeof(ref StringBuilder),
			typeof(ref int),
			typeof(char*),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		private unsafe void Insert(int index, char* value, int valueCount)
		{
			throw null;
		}

		// Token: 0x060013BE RID: 5054 RVA: 0x00017C69 File Offset: 0x00015E69
		[global::Cpp2ILInjected.Token(Token = "0x6001578")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AD7674", Offset = "0x1AD7674", Length = "0x168")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(StringBuilder), Member = "Replace", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(StringBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.CompilerServices.RuntimeHelpers), Member = "get_OffsetToStringData", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = "MakeRoom", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(ref StringBuilder),
			typeof(ref int),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = "ReplaceInPlaceAtChunk", MemberParameters = new object[]
		{
			typeof(ref StringBuilder),
			typeof(ref int),
			typeof(char*),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = "Remove", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(ref StringBuilder),
			typeof(ref int)
		}, ReturnType = typeof(void))]
		private unsafe void ReplaceAllInChunk(int[] replacements, int replacementsCount, StringBuilder sourceChunk, int removeCount, string value)
		{
			throw null;
		}

		// Token: 0x060013BF RID: 5055 RVA: 0x00017C6C File Offset: 0x00015E6C
		[global::Cpp2ILInjected.Token(Token = "0x6001579")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AD7590", Offset = "0x1AD7590", Length = "0xE4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(StringBuilder), Member = "Replace", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(StringBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(char))]
		private bool StartsWith(StringBuilder chunk, int indexInChunk, int count, string value)
		{
			throw null;
		}

		// Token: 0x060013C0 RID: 5056 RVA: 0x00017C6F File Offset: 0x00015E6F
		[global::Cpp2ILInjected.Token(Token = "0x600157A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AD7A54", Offset = "0x1AD7A54", Length = "0x128")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(StringBuilder), Member = "Insert", MemberParameters = new object[]
		{
			typeof(int),
			typeof(char*),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(StringBuilder), Member = "ReplaceAllInChunk", MemberParameters = new object[]
		{
			typeof(int[]),
			typeof(int),
			typeof(StringBuilder),
			typeof(int),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Math), Member = "Min", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = "ThreadSafeCopy", MemberParameters = new object[]
		{
			typeof(char*),
			typeof(char[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private unsafe void ReplaceInPlaceAtChunk(ref StringBuilder chunk, ref int indexInChunk, char* value, int count)
		{
			throw null;
		}

		// Token: 0x060013C1 RID: 5057 RVA: 0x00017C72 File Offset: 0x00015E72
		[global::Cpp2ILInjected.Token(Token = "0x600157B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AD43B0", Offset = "0x1AD43B0", Length = "0xB4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new object[]
		{
			typeof(char*),
			typeof(int)
		}, ReturnType = typeof(StringBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(StringBuilder), Member = "ReplaceInPlaceAtChunk", MemberParameters = new object[]
		{
			typeof(ref StringBuilder),
			typeof(ref int),
			typeof(char*),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(StringBuilder), Member = "MakeRoom", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(ref StringBuilder),
			typeof(ref int),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "wstrcpy", MemberParameters = new object[]
		{
			typeof(char*),
			typeof(char*),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		private unsafe static void ThreadSafeCopy(char* sourcePtr, char[] destination, int destinationIndex, int count)
		{
			throw null;
		}

		// Token: 0x060013C2 RID: 5058 RVA: 0x00017C75 File Offset: 0x00015E75
		[global::Cpp2ILInjected.Token(Token = "0x600157C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AD5CF8", Offset = "0x1AD5CF8", Length = "0x154")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(StringBuilder), Member = "CopyTo", MemberParameters = new object[]
		{
			typeof(int),
			typeof(global::System.Span<char>),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(StringBuilder), Member = "Remove", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(ref StringBuilder),
			typeof(ref int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.InteropServices.MemoryMarshal[]), Member = "GetReference", MemberTypeParameters = new object[] { typeof(char) }, MemberParameters = new object[] { typeof(global::System.Span<char>) }, ReturnType = "T&")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "wstrcpy", MemberParameters = new object[]
		{
			typeof(char*),
			typeof(char*),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		private unsafe static void ThreadSafeCopy(char[] source, int sourceIndex, global::System.Span<char> destination, int destinationIndex, int count)
		{
			throw null;
		}

		// Token: 0x060013C3 RID: 5059 RVA: 0x00017C78 File Offset: 0x00015E78
		[global::Cpp2ILInjected.Token(Token = "0x600157D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AD52E0", Offset = "0x1AD52E0", Length = "0x18")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private StringBuilder FindChunkForIndex(int index)
		{
			throw null;
		}

		// Token: 0x170001E3 RID: 483
		// (get) Token: 0x060013C4 RID: 5060 RVA: 0x00017C7B File Offset: 0x00015E7B
		[global::Cpp2ILInjected.Token(Token = "0x17000226")]
		private global::System.Span<char> RemainingCurrentChunk
		{
			[global::Cpp2ILInjected.Token(Token = "0x600157E")]
			[global::Cpp2ILInjected.Address(RVA = "0x1AD7BB4", Offset = "0x1AD7BB4", Length = "0xBC")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			[MethodImpl(256)]
			get
			{
				throw null;
			}
		}

		// Token: 0x060013C5 RID: 5061 RVA: 0x00017C7E File Offset: 0x00015E7E
		[global::Cpp2ILInjected.Token(Token = "0x600157F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AD7B7C", Offset = "0x1AD7B7C", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private StringBuilder Next(StringBuilder chunk)
		{
			throw null;
		}

		// Token: 0x060013C6 RID: 5062 RVA: 0x00017C81 File Offset: 0x00015E81
		[global::Cpp2ILInjected.Token(Token = "0x6001580")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AD5400", Offset = "0x1AD5400", Length = "0x1A4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new object[]
		{
			typeof(char),
			typeof(int)
		}, ReturnType = typeof(StringBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(StringBuilder), Member = "AppendCore", MemberParameters = new object[]
		{
			typeof(StringBuilder),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(StringBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new object[]
		{
			typeof(char*),
			typeof(int)
		}, ReturnType = typeof(StringBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Math), Member = "Min", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Math), Member = "Max", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.OutOfMemoryException), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 14)]
		private unsafe void ExpandByABlock(int minBlockCharCount)
		{
			throw null;
		}

		// Token: 0x060013C7 RID: 5063 RVA: 0x00017C84 File Offset: 0x00015E84
		[global::Cpp2ILInjected.Token(Token = "0x6001581")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AD7C70", Offset = "0x1AD7C70", Length = "0x3C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		private StringBuilder(StringBuilder from)
		{
			throw null;
		}

		// Token: 0x060013C8 RID: 5064 RVA: 0x00017C87 File Offset: 0x00015E87
		[global::Cpp2ILInjected.Token(Token = "0x6001582")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AD77DC", Offset = "0x1AD77DC", Length = "0x278")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(StringBuilder), Member = "Insert", MemberParameters = new object[]
		{
			typeof(int),
			typeof(char*),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(StringBuilder), Member = "ReplaceAllInChunk", MemberParameters = new object[]
		{
			typeof(int[]),
			typeof(int),
			typeof(StringBuilder),
			typeof(int),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Math), Member = "Max", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(StringBuilder)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Math), Member = "Min", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = "ThreadSafeCopy", MemberParameters = new object[]
		{
			typeof(char*),
			typeof(char[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		private unsafe void MakeRoom(int index, int count, out StringBuilder chunk, out int indexInChunk, bool doNotMoveFollowingChars)
		{
			throw null;
		}

		// Token: 0x060013C9 RID: 5065 RVA: 0x00017C8A File Offset: 0x00015E8A
		[global::Cpp2ILInjected.Token(Token = "0x6001583")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AD7CAC", Offset = "0x1AD7CAC", Length = "0x8C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(StringBuilder), Member = "MakeRoom", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(ref StringBuilder),
			typeof(ref int),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private StringBuilder(int size, int maxCapacity, StringBuilder previousBlock)
		{
			throw null;
		}

		// Token: 0x060013CA RID: 5066 RVA: 0x00017C8D File Offset: 0x00015E8D
		[global::Cpp2ILInjected.Token(Token = "0x6001584")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AD5F80", Offset = "0x1AD5F80", Length = "0x140")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(StringBuilder), Member = "Remove", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(StringBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(StringBuilder), Member = "ReplaceAllInChunk", MemberParameters = new object[]
		{
			typeof(int[]),
			typeof(int),
			typeof(StringBuilder),
			typeof(int),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Span<char>), Member = "op_Implicit", MemberParameters = new object[] { typeof(char[]) }, ReturnType = "System.Span`1<T>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = "ThreadSafeCopy", MemberParameters = new object[]
		{
			typeof(char[]),
			typeof(int),
			typeof(global::System.Span<char>),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		private void Remove(int startIndex, int count, out StringBuilder chunk, out int indexInChunk)
		{
			throw null;
		}

		// Token: 0x040008B8 RID: 2232
		[global::Cpp2ILInjected.Token(Token = "0x4000B24")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		internal char[] m_ChunkChars;

		// Token: 0x040008B9 RID: 2233
		[global::Cpp2ILInjected.Token(Token = "0x4000B25")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		internal StringBuilder m_ChunkPrevious;

		// Token: 0x040008BA RID: 2234
		[global::Cpp2ILInjected.Token(Token = "0x4000B26")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		internal int m_ChunkLength;

		// Token: 0x040008BB RID: 2235
		[global::Cpp2ILInjected.Token(Token = "0x4000B27")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x24")]
		internal int m_ChunkOffset;

		// Token: 0x040008BC RID: 2236
		[global::Cpp2ILInjected.Token(Token = "0x4000B28")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		internal int m_MaxCapacity;

		// Token: 0x040008BD RID: 2237
		[global::Cpp2ILInjected.Token(Token = "0x4000B29")]
		internal const int DefaultCapacity = 16;

		// Token: 0x040008BE RID: 2238
		[global::Cpp2ILInjected.Token(Token = "0x4000B2A")]
		private const string CapacityField = "Capacity";

		// Token: 0x040008BF RID: 2239
		[global::Cpp2ILInjected.Token(Token = "0x4000B2B")]
		private const string MaxCapacityField = "m_MaxCapacity";

		// Token: 0x040008C0 RID: 2240
		[global::Cpp2ILInjected.Token(Token = "0x4000B2C")]
		private const string StringValueField = "m_StringValue";

		// Token: 0x040008C1 RID: 2241
		[global::Cpp2ILInjected.Token(Token = "0x4000B2D")]
		private const string ThreadIDField = "m_currentThread";

		// Token: 0x040008C2 RID: 2242
		[global::Cpp2ILInjected.Token(Token = "0x4000B2E")]
		internal const int MaxChunkSize = 8000;

		// Token: 0x040008C3 RID: 2243
		[global::Cpp2ILInjected.Token(Token = "0x4000B2F")]
		private const int IndexLimit = 1000000;

		// Token: 0x040008C4 RID: 2244
		[global::Cpp2ILInjected.Token(Token = "0x4000B30")]
		private const int WidthLimit = 1000000;
	}
}
