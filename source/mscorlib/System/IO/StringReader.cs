using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Mono.Xml;

namespace System.IO
{
	// Token: 0x02000490 RID: 1168
	[global::System.Runtime.InteropServices.ComVisible(true)]
	[global::Cpp2ILInjected.Token(Token = "0x2000563")]
	[global::System.Serializable]
	public class StringReader : TextReader
	{
		// Token: 0x06002645 RID: 9797 RVA: 0x0001AFB7 File Offset: 0x000191B7
		[global::Cpp2ILInjected.Token(Token = "0x6002956")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BC89F4", Offset = "0x1BC89F4", Length = "0xC0")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "ReLogic.Text.WrappedTextBuilder", Member = "Append", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Mono.Xml.SecurityParser), Member = "LoadXml", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.MonoChunkParser", Member = "ReadTrailer", MemberParameters = new object[]
		{
			"System.Byte[]",
			typeof(ref int),
			typeof(int)
		}, ReturnType = "System.Net.MonoChunkParser.State")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Xml.XmlDocument", Member = "LoadXml", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.JsonConvert", Member = "DeserializeObject", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.Type),
			"Newtonsoft.Json.JsonSerializerSettings"
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.JsonConvert", Member = "PopulateObject", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object),
			"Newtonsoft.Json.JsonSerializerSettings"
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Linq.JObject", Member = "Parse", MemberParameters = new object[]
		{
			typeof(string),
			"Newtonsoft.Json.Linq.JsonLoadSettings"
		}, ReturnType = "Newtonsoft.Json.Linq.JObject")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Linq.JArray", Member = "Parse", MemberParameters = new object[]
		{
			typeof(string),
			"Newtonsoft.Json.Linq.JsonLoadSettings"
		}, ReturnType = "Newtonsoft.Json.Linq.JArray")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Linq.JToken", Member = "Parse", MemberParameters = new object[]
		{
			typeof(string),
			"Newtonsoft.Json.Linq.JsonLoadSettings"
		}, ReturnType = "Newtonsoft.Json.Linq.JToken")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 9)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TextReader), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public StringReader(string s)
		{
			throw null;
		}

		// Token: 0x06002646 RID: 9798 RVA: 0x0001AFBA File Offset: 0x000191BA
		[global::Cpp2ILInjected.Token(Token = "0x6002957")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BC8AB4", Offset = "0x1BC8AB4", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override void Close()
		{
			throw null;
		}

		// Token: 0x06002647 RID: 9799 RVA: 0x0001AFBD File Offset: 0x000191BD
		[global::Cpp2ILInjected.Token(Token = "0x6002958")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BC8AC4", Offset = "0x1BC8AC4", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TextReader), Member = "Dispose", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		protected override void Dispose(bool disposing)
		{
			throw null;
		}

		// Token: 0x06002648 RID: 9800 RVA: 0x0001AFC0 File Offset: 0x000191C0
		[global::Cpp2ILInjected.Token(Token = "0x6002959")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BC8AD4", Offset = "0x1BC8AD4", Length = "0x3C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(__Error), Member = "ReaderClosed", ReturnType = typeof(void))]
		public override int Peek()
		{
			throw null;
		}

		// Token: 0x06002649 RID: 9801 RVA: 0x0001AFC3 File Offset: 0x000191C3
		[global::Cpp2ILInjected.Token(Token = "0x600295A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BC8B10", Offset = "0x1BC8B10", Length = "0x44")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(__Error), Member = "ReaderClosed", ReturnType = typeof(void))]
		public override int Read()
		{
			throw null;
		}

		// Token: 0x0600264A RID: 9802 RVA: 0x0001AFC6 File Offset: 0x000191C6
		[global::Cpp2ILInjected.Token(Token = "0x600295B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BC8B54", Offset = "0x1BC8B54", Length = "0x1A8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "CopyTo", MemberParameters = new object[]
		{
			typeof(int),
			typeof(char[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
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
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(__Error), Member = "ReaderClosed", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 16)]
		public override int Read([global::System.Runtime.InteropServices.In] [global::System.Runtime.InteropServices.Out] char[] buffer, int index, int count)
		{
			throw null;
		}

		// Token: 0x0600264B RID: 9803 RVA: 0x0001AFC9 File Offset: 0x000191C9
		[global::Cpp2ILInjected.Token(Token = "0x600295C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BC8CFC", Offset = "0x1BC8CFC", Length = "0x3C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Substring", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(__Error), Member = "ReaderClosed", ReturnType = typeof(void))]
		public override string ReadToEnd()
		{
			throw null;
		}

		// Token: 0x0600264C RID: 9804 RVA: 0x0001AFCC File Offset: 0x000191CC
		[global::Cpp2ILInjected.Token(Token = "0x600295D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BC8D38", Offset = "0x1BC8D38", Length = "0xFC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Substring", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(__Error), Member = "ReaderClosed", ReturnType = typeof(void))]
		public override string ReadLine()
		{
			throw null;
		}

		// Token: 0x040012E5 RID: 4837
		[global::Cpp2ILInjected.Token(Token = "0x4001631")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private string _s;

		// Token: 0x040012E6 RID: 4838
		[global::Cpp2ILInjected.Token(Token = "0x4001632")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private int _pos;

		// Token: 0x040012E7 RID: 4839
		[global::Cpp2ILInjected.Token(Token = "0x4001633")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x24")]
		private int _length;
	}
}
