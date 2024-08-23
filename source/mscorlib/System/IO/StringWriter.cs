﻿using System;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Text;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.IO
{
	// Token: 0x02000491 RID: 1169
	[global::System.Runtime.InteropServices.ComVisible(true)]
	[global::Cpp2ILInjected.Token(Token = "0x2000564")]
	[global::System.Serializable]
	public class StringWriter : TextWriter
	{
		// Token: 0x0600264D RID: 9805 RVA: 0x0001AFCF File Offset: 0x000191CF
		[global::Cpp2ILInjected.Token(Token = "0x600295E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BC8E34", Offset = "0x1BC8E34", Length = "0x94")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Text.StringBuilder), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Globalization.CultureInfo), Member = "get_CurrentCulture", ReturnType = typeof(global::System.Globalization.CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public StringWriter()
		{
			throw null;
		}

		// Token: 0x0600264E RID: 9806 RVA: 0x0001AFD2 File Offset: 0x000191D2
		[global::Cpp2ILInjected.Token(Token = "0x600295F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BC8FAC", Offset = "0x1BC8FAC", Length = "0x6C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.WebUtility", Member = "HtmlEncode", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.WebUtility", Member = "HtmlDecode", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Serialization.TraceJsonReader", Member = ".ctor", MemberParameters = new object[] { "Newtonsoft.Json.JsonReader" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Serialization.TraceJsonWriter", Member = ".ctor", MemberParameters = new object[] { "Newtonsoft.Json.JsonWriter" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Serialization.JsonSerializerInternalWriter", Member = "GetPropertyName", MemberParameters = new object[]
		{
			"Newtonsoft.Json.JsonWriter",
			typeof(object),
			"Newtonsoft.Json.Serialization.JsonContract",
			typeof(ref bool)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Linq.JRaw", Member = "Create", MemberParameters = new object[] { "Newtonsoft.Json.JsonReader" }, ReturnType = "Newtonsoft.Json.Linq.JRaw")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Linq.JToken", Member = "ToString", MemberParameters = new object[] { "Newtonsoft.Json.Formatting", "Newtonsoft.Json.JsonConverter[]" }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Xml.Linq.XAttribute", Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Xml.Linq.XNode", Member = "GetXmlString", MemberParameters = new object[] { "System.Xml.Linq.SaveOptions" }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 10)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Text.StringBuilder), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringWriter), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(global::System.Text.StringBuilder),
			typeof(global::System.IFormatProvider)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public StringWriter(global::System.IFormatProvider formatProvider)
		{
			throw null;
		}

		// Token: 0x0600264F RID: 9807 RVA: 0x0001AFD5 File Offset: 0x000191D5
		[global::Cpp2ILInjected.Token(Token = "0x6002960")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BC8EC8", Offset = "0x1BC8EC8", Length = "0xE4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(StringWriter), Member = ".ctor", MemberParameters = new object[] { typeof(global::System.IFormatProvider) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.JsonConvert", Member = "SerializeObjectInternal", MemberParameters = new object[]
		{
			typeof(object),
			typeof(global::System.Type),
			"Newtonsoft.Json.JsonSerializer"
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Utilities.StringUtils", Member = "CreateStringWriter", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(StringWriter))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TextWriter), Member = ".ctor", MemberParameters = new object[] { typeof(global::System.IFormatProvider) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Environment), Member = "GetResourceString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		public StringWriter(global::System.Text.StringBuilder sb, global::System.IFormatProvider formatProvider)
		{
			throw null;
		}

		// Token: 0x06002650 RID: 9808 RVA: 0x0001AFD8 File Offset: 0x000191D8
		[global::Cpp2ILInjected.Token(Token = "0x6002961")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BC9018", Offset = "0x1BC9018", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override void Close()
		{
			throw null;
		}

		// Token: 0x06002651 RID: 9809 RVA: 0x0001AFDB File Offset: 0x000191DB
		[global::Cpp2ILInjected.Token(Token = "0x6002962")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BC9028", Offset = "0x1BC9028", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TextWriter), Member = "Dispose", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		protected override void Dispose(bool disposing)
		{
			throw null;
		}

		// Token: 0x1700056C RID: 1388
		// (get) Token: 0x06002652 RID: 9810 RVA: 0x0001AFDE File Offset: 0x000191DE
		[global::Cpp2ILInjected.Token(Token = "0x170005F4")]
		public override global::System.Text.Encoding Encoding
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002963")]
			[global::Cpp2ILInjected.Address(RVA = "0x1BC9038", Offset = "0x1BC9038", Length = "0xA4")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Text.UnicodeEncoding), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(bool),
				typeof(bool)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06002653 RID: 9811 RVA: 0x0001AFE1 File Offset: 0x000191E1
		[global::Cpp2ILInjected.Token(Token = "0x6002964")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BC90DC", Offset = "0x1BC90DC", Length = "0x20")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Text.StringBuilder), Member = "Append", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(global::System.Text.StringBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(__Error), Member = "WriterClosed", ReturnType = typeof(void))]
		public override void Write(char value)
		{
			throw null;
		}

		// Token: 0x06002654 RID: 9812 RVA: 0x0001AFE4 File Offset: 0x000191E4
		[global::Cpp2ILInjected.Token(Token = "0x6002965")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BC90FC", Offset = "0x1BC90FC", Length = "0x16C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Text.StringBuilder), Member = "Append", MemberParameters = new object[]
		{
			typeof(char[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(global::System.Text.StringBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Environment), Member = "GetResourceString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(__Error), Member = "WriterClosed", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 16)]
		public override void Write(char[] buffer, int index, int count)
		{
			throw null;
		}

		// Token: 0x06002655 RID: 9813 RVA: 0x0001AFE7 File Offset: 0x000191E7
		[global::Cpp2ILInjected.Token(Token = "0x6002966")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BC9268", Offset = "0x1BC9268", Length = "0x2C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Text.StringBuilder), Member = "Append", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(global::System.Text.StringBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(__Error), Member = "WriterClosed", ReturnType = typeof(void))]
		public override void Write(string value)
		{
			throw null;
		}

		// Token: 0x06002656 RID: 9814 RVA: 0x0001AFEA File Offset: 0x000191EA
		[global::Cpp2ILInjected.Token(Token = "0x6002967")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BC9294", Offset = "0x1BC9294", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override string ToString()
		{
			throw null;
		}

		// Token: 0x040012E8 RID: 4840
		[global::Cpp2ILInjected.Token(Token = "0x4001634")]
		private static global::System.Text.UnicodeEncoding m_encoding;

		// Token: 0x040012E9 RID: 4841
		[global::Cpp2ILInjected.Token(Token = "0x4001635")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private global::System.Text.StringBuilder _sb;

		// Token: 0x040012EA RID: 4842
		[global::Cpp2ILInjected.Token(Token = "0x4001636")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		private bool _isOpen;
	}
}