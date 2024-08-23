using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Newtonsoft.Json.Shims;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json.Linq
{
	// Token: 0x0200009D RID: 157
	[Preserve]
	[global::Cpp2ILInjected.Token(Token = "0x20000D3")]
	public class JTokenReader : JsonReader, IJsonLineInfo
	{
		// Token: 0x17000175 RID: 373
		// (get) Token: 0x06000767 RID: 1895 RVA: 0x00003638 File Offset: 0x00001838
		[global::Cpp2ILInjected.Token(Token = "0x17000185")]
		public JToken CurrentToken
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000817")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D0EC10", Offset = "0x1D0EC10", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06000768 RID: 1896 RVA: 0x0000363B File Offset: 0x0000183B
		[global::Cpp2ILInjected.Token(Token = "0x6000818")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D0EC18", Offset = "0x1D0EC18", Length = "0x6C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JTokenReader), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(JToken),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JToken), Member = "CreateReader", ReturnType = typeof(JsonReader))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JToken), Member = "ToObject", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(JsonSerializer)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonReader), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ValidationUtils), Member = "ArgumentNotNull", MemberParameters = new object[]
		{
			typeof(object),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public JTokenReader(JToken token)
		{
			throw null;
		}

		// Token: 0x06000769 RID: 1897 RVA: 0x0000363E File Offset: 0x0000183E
		[global::Cpp2ILInjected.Token(Token = "0x6000819")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D0EC84", Offset = "0x1D0EC84", Length = "0x24")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JTokenReader), Member = ".ctor", MemberParameters = new object[] { typeof(JToken) }, ReturnType = typeof(void))]
		internal JTokenReader(JToken token, string initialPath)
		{
			throw null;
		}

		// Token: 0x0600076A RID: 1898 RVA: 0x00003641 File Offset: 0x00001841
		[global::Cpp2ILInjected.Token(Token = "0x600081A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D0ECA8", Offset = "0x1D0ECA8", Length = "0xC4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JTokenReader), Member = "ReadOver", MemberParameters = new object[] { typeof(JToken) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JTokenReader), Member = "SetToken", MemberParameters = new object[] { typeof(JToken) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override bool Read()
		{
			throw null;
		}

		// Token: 0x0600076B RID: 1899 RVA: 0x00003644 File Offset: 0x00001844
		[global::Cpp2ILInjected.Token(Token = "0x600081B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D0EDCC", Offset = "0x1D0EDCC", Length = "0xA8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JTokenReader), Member = "Read", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JTokenReader), Member = "SetEnd", MemberParameters = new object[] { typeof(JContainer) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JTokenReader), Member = "SetToken", MemberParameters = new object[] { typeof(JToken) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JTokenReader), Member = "SetEnd", MemberParameters = new object[] { typeof(JContainer) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonReader), Member = "SetToken", MemberParameters = new object[] { typeof(JsonToken) }, ReturnType = typeof(void))]
		private bool ReadOver(JToken t)
		{
			throw null;
		}

		// Token: 0x0600076C RID: 1900 RVA: 0x00003647 File Offset: 0x00001847
		[global::Cpp2ILInjected.Token(Token = "0x600081C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D0F348", Offset = "0x1D0F348", Length = "0x20")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonReader), Member = "SetToken", MemberParameters = new object[] { typeof(JsonToken) }, ReturnType = typeof(void))]
		private bool ReadToEnd()
		{
			throw null;
		}

		// Token: 0x0600076D RID: 1901 RVA: 0x0000364A File Offset: 0x0000184A
		[global::Cpp2ILInjected.Token(Token = "0x600081D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D0F3EC", Offset = "0x1D0F3EC", Length = "0x140")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JTokenReader), Member = "SetEnd", MemberParameters = new object[] { typeof(JContainer) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Int32Enum?), Member = ".ctor", MemberParameters = new object[] { "System.Int32Enum" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MiscellaneousUtils), Member = "CreateArgumentOutOfRangeException", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object),
			typeof(string)
		}, ReturnType = typeof(ArgumentOutOfRangeException))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		private JsonToken? GetEndToken(JContainer c)
		{
			throw null;
		}

		// Token: 0x0600076E RID: 1902 RVA: 0x0000364D File Offset: 0x0000184D
		[global::Cpp2ILInjected.Token(Token = "0x600081E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D0ED6C", Offset = "0x1D0ED6C", Length = "0x60")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JTokenReader), Member = "SetToken", MemberParameters = new object[] { typeof(JToken) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JTokenReader), Member = "SetEnd", MemberParameters = new object[] { typeof(JContainer) }, ReturnType = typeof(bool))]
		private bool ReadInto(JContainer c)
		{
			throw null;
		}

		// Token: 0x0600076F RID: 1903 RVA: 0x00003650 File Offset: 0x00001850
		[global::Cpp2ILInjected.Token(Token = "0x600081F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D0F368", Offset = "0x1D0F368", Length = "0x84")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JTokenReader), Member = "ReadOver", MemberParameters = new object[] { typeof(JToken) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JTokenReader), Member = "ReadInto", MemberParameters = new object[] { typeof(JContainer) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JTokenReader), Member = "GetEndToken", MemberParameters = new object[] { typeof(JContainer) }, ReturnType = typeof(JsonToken?))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonReader), Member = "SetToken", MemberParameters = new object[] { typeof(JsonToken) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JTokenReader), Member = "ReadOver", MemberParameters = new object[] { typeof(JToken) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private bool SetEnd(JContainer c)
		{
			throw null;
		}

		// Token: 0x06000770 RID: 1904 RVA: 0x00003653 File Offset: 0x00001853
		[global::Cpp2ILInjected.Token(Token = "0x6000820")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D0EE74", Offset = "0x1D0EE74", Length = "0x4D4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JTokenReader), Member = "Read", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JTokenReader), Member = "ReadOver", MemberParameters = new object[] { typeof(JToken) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JTokenReader), Member = "ReadInto", MemberParameters = new object[] { typeof(JContainer) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonReader), Member = "SetToken", MemberParameters = new object[] { typeof(JsonToken) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonReader), Member = "SetToken", MemberParameters = new object[]
		{
			typeof(JsonToken),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Uri), Member = "get_OriginalString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MiscellaneousUtils), Member = "CreateArgumentOutOfRangeException", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object),
			typeof(string)
		}, ReturnType = typeof(ArgumentOutOfRangeException))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 12)]
		private void SetToken(JToken token)
		{
			throw null;
		}

		// Token: 0x06000771 RID: 1905 RVA: 0x00003656 File Offset: 0x00001856
		[global::Cpp2ILInjected.Token(Token = "0x6000821")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D0F52C", Offset = "0x1D0F52C", Length = "0x20")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		private string SafeToString(object value)
		{
			throw null;
		}

		// Token: 0x06000772 RID: 1906 RVA: 0x00003659 File Offset: 0x00001859
		[global::Cpp2ILInjected.Token(Token = "0x6000822")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D0F54C", Offset = "0x1D0F54C", Length = "0xB4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		private bool Newtonsoft.Json.IJsonLineInfo.HasLineInfo()
		{
			throw null;
		}

		// Token: 0x17000176 RID: 374
		// (get) Token: 0x06000773 RID: 1907 RVA: 0x0000365C File Offset: 0x0000185C
		[global::Cpp2ILInjected.Token(Token = "0x17000186")]
		private int Newtonsoft.Json.IJsonLineInfo.LineNumber
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000823")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D0F600", Offset = "0x1D0F600", Length = "0xB8")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000177 RID: 375
		// (get) Token: 0x06000774 RID: 1908 RVA: 0x0000365F File Offset: 0x0000185F
		[global::Cpp2ILInjected.Token(Token = "0x17000187")]
		private int Newtonsoft.Json.IJsonLineInfo.LinePosition
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000824")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D0F6B8", Offset = "0x1D0F6B8", Length = "0xB8")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000178 RID: 376
		// (get) Token: 0x06000775 RID: 1909 RVA: 0x00003662 File Offset: 0x00001862
		[global::Cpp2ILInjected.Token(Token = "0x17000188")]
		public override string Path
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000825")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D0F770", Offset = "0x1D0F770", Length = "0xDC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonReader), Member = "get_Path", ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JToken), Member = "get_Path", ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringUtils), Member = "StartsWith", MemberParameters = new object[]
			{
				typeof(string),
				typeof(char)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
			{
				typeof(string),
				typeof(string)
			}, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
			{
				typeof(string),
				typeof(string),
				typeof(string)
			}, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x04000296 RID: 662
		[global::Cpp2ILInjected.Token(Token = "0x4000334")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x78")]
		private readonly JToken _root;

		// Token: 0x04000297 RID: 663
		[global::Cpp2ILInjected.Token(Token = "0x4000335")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x80")]
		private string _initialPath;

		// Token: 0x04000298 RID: 664
		[global::Cpp2ILInjected.Token(Token = "0x4000336")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x88")]
		private JToken _parent;

		// Token: 0x04000299 RID: 665
		[global::Cpp2ILInjected.Token(Token = "0x4000337")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x90")]
		private JToken _current;
	}
}
