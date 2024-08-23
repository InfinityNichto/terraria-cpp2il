using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Newtonsoft.Json.Shims;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json.Linq
{
	// Token: 0x020000A0 RID: 160
	[Preserve]
	[global::Cpp2ILInjected.Token(Token = "0x20000DC")]
	public class JProperty : JContainer
	{
		// Token: 0x17000189 RID: 393
		// (get) Token: 0x06000832 RID: 2098 RVA: 0x00003887 File Offset: 0x00001A87
		[global::Cpp2ILInjected.Token(Token = "0x170001A3")]
		protected override IList<JToken> ChildrenTokens
		{
			[global::Cpp2ILInjected.Token(Token = "0x600090B")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D1A57C", Offset = "0x1D1A57C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700018A RID: 394
		// (get) Token: 0x06000833 RID: 2099 RVA: 0x0000388A File Offset: 0x00001A8A
		[global::Cpp2ILInjected.Token(Token = "0x170001A4")]
		public string Name
		{
			[DebuggerStepThrough]
			[global::Cpp2ILInjected.Token(Token = "0x600090C")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D1A584", Offset = "0x1D1A584", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700018B RID: 395
		// (get) Token: 0x06000834 RID: 2100 RVA: 0x0000388D File Offset: 0x00001A8D
		// (set) Token: 0x06000835 RID: 2101 RVA: 0x00003890 File Offset: 0x00001A90
		[global::Cpp2ILInjected.Token(Token = "0x170001A5")]
		public new JToken Value
		{
			[DebuggerStepThrough]
			[global::Cpp2ILInjected.Token(Token = "0x600090D")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D1A58C", Offset = "0x1D1A58C", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JPropertyKeyedCollection), Member = "Compare", MemberParameters = new object[] { typeof(JPropertyKeyedCollection) }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JContainer), Member = "ReadContentFrom", MemberParameters = new object[]
			{
				typeof(JsonReader),
				typeof(JsonLoadSettings)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Linq.JObject.<>c", Member = "<PropertyValues>b__25_0", MemberParameters = new object[] { typeof(JProperty) }, ReturnType = typeof(JToken))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Linq.JObject.<GetEnumerator>d__58", Member = "MoveNext", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JObject), Member = "MergeItem", MemberParameters = new object[]
			{
				typeof(object),
				typeof(JsonMergeSettings)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JObject), Member = "get_Item", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(JToken))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JObject), Member = "GetValue", MemberParameters = new object[]
			{
				typeof(string),
				typeof(StringComparison)
			}, ReturnType = typeof(JToken))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JObject), Member = "TryGetValue", MemberParameters = new object[]
			{
				typeof(string),
				typeof(ref JToken)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JObject), Member = "System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,Newtonsoft.Json.Linq.JToken>>.Contains", MemberParameters = new object[] { typeof(KeyValuePair<string, JToken>) }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JObject), Member = "System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,Newtonsoft.Json.Linq.JToken>>.CopyTo", MemberParameters = new object[]
			{
				typeof(KeyValuePair<string, JToken>[]),
				typeof(int)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JToken), Member = "EnsureValue", MemberParameters = new object[] { typeof(JToken) }, ReturnType = typeof(JValue))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JToken), Member = "GetType", MemberParameters = new object[] { typeof(JToken) }, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 16)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x600090E")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D1A598", Offset = "0x1D1A598", Length = "0x78")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JObject), Member = "MergeItem", MemberParameters = new object[]
			{
				typeof(object),
				typeof(JsonMergeSettings)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JObject), Member = "set_Item", MemberParameters = new object[]
			{
				typeof(string),
				typeof(JToken)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JProperty), Member = "MergeItem", MemberParameters = new object[]
			{
				typeof(object),
				typeof(JsonMergeSettings)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JProperty), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(string),
				typeof(object)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JContainer), Member = "CheckReentrancy", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JValue), Member = "CreateNull", ReturnType = typeof(JValue))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			set
			{
				throw null;
			}
		}

		// Token: 0x06000836 RID: 2102 RVA: 0x00003893 File Offset: 0x00001A93
		[global::Cpp2ILInjected.Token(Token = "0x600090F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D1A668", Offset = "0x1D1A668", Length = "0x7C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JProperty), Member = "CloneToken", ReturnType = typeof(JToken))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JContainer), Member = ".ctor", MemberParameters = new object[] { typeof(JContainer) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public JProperty(JProperty other)
		{
			throw null;
		}

		// Token: 0x06000837 RID: 2103 RVA: 0x00003896 File Offset: 0x00001A96
		[global::Cpp2ILInjected.Token(Token = "0x6000910")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D1A6EC", Offset = "0x1D1A6EC", Length = "0x4C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		internal override JToken GetItem(int index)
		{
			throw null;
		}

		// Token: 0x06000838 RID: 2104 RVA: 0x00003899 File Offset: 0x00001A99
		[global::Cpp2ILInjected.Token(Token = "0x6000911")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D1A738", Offset = "0x1D1A738", Length = "0x144")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JContainer), Member = "IsTokenUnchanged", MemberParameters = new object[]
		{
			typeof(JToken),
			typeof(JToken)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JObject), Member = "InternalPropertyChanging", MemberParameters = new object[] { typeof(JProperty) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JContainer), Member = "SetItem", MemberParameters = new object[]
		{
			typeof(int),
			typeof(JToken)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JObject), Member = "InternalPropertyChanged", MemberParameters = new object[] { typeof(JProperty) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		internal override void SetItem(int index, JToken item)
		{
			throw null;
		}

		// Token: 0x06000839 RID: 2105 RVA: 0x0000389C File Offset: 0x00001A9C
		[global::Cpp2ILInjected.Token(Token = "0x6000912")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D1A87C", Offset = "0x1D1A87C", Length = "0xAC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(RuntimeTypeHandle) }, ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringUtils), Member = "FormatWith", MemberParameters = new object[]
		{
			typeof(string),
			typeof(IFormatProvider),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		internal override bool RemoveItem(JToken item)
		{
			throw null;
		}

		// Token: 0x0600083A RID: 2106 RVA: 0x0000389F File Offset: 0x00001A9F
		[global::Cpp2ILInjected.Token(Token = "0x6000913")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D1A928", Offset = "0x1D1A928", Length = "0xAC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(RuntimeTypeHandle) }, ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringUtils), Member = "FormatWith", MemberParameters = new object[]
		{
			typeof(string),
			typeof(IFormatProvider),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		internal override void RemoveItemAt(int index)
		{
			throw null;
		}

		// Token: 0x0600083B RID: 2107 RVA: 0x000038A2 File Offset: 0x00001AA2
		[global::Cpp2ILInjected.Token(Token = "0x6000914")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D1A9D4", Offset = "0x1D1A9D4", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		internal override int IndexOfItem(JToken item)
		{
			throw null;
		}

		// Token: 0x0600083C RID: 2108 RVA: 0x000038A5 File Offset: 0x00001AA5
		[global::Cpp2ILInjected.Token(Token = "0x6000915")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D1A9F8", Offset = "0x1D1A9F8", Length = "0x10C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JContainer), Member = "InsertItem", MemberParameters = new object[]
		{
			typeof(int),
			typeof(JToken),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(RuntimeTypeHandle) }, ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringUtils), Member = "FormatWith", MemberParameters = new object[]
		{
			typeof(string),
			typeof(IFormatProvider),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		internal override void InsertItem(int index, JToken item, bool skipParentCheck)
		{
			throw null;
		}

		// Token: 0x0600083D RID: 2109 RVA: 0x000038A8 File Offset: 0x00001AA8
		[global::Cpp2ILInjected.Token(Token = "0x6000916")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D1AB04", Offset = "0x1D1AB04", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		internal override bool ContainsItem(JToken item)
		{
			throw null;
		}

		// Token: 0x0600083E RID: 2110 RVA: 0x000038AB File Offset: 0x00001AAB
		[global::Cpp2ILInjected.Token(Token = "0x6000917")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D1AB18", Offset = "0x1D1AB18", Length = "0xB0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JProperty), Member = "set_Value", MemberParameters = new object[] { typeof(JToken) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		internal override void MergeItem(object content, JsonMergeSettings settings)
		{
			throw null;
		}

		// Token: 0x0600083F RID: 2111 RVA: 0x000038AE File Offset: 0x00001AAE
		[global::Cpp2ILInjected.Token(Token = "0x6000918")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D1ABC8", Offset = "0x1D1ABC8", Length = "0xAC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(RuntimeTypeHandle) }, ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringUtils), Member = "FormatWith", MemberParameters = new object[]
		{
			typeof(string),
			typeof(IFormatProvider),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		internal override void ClearItems()
		{
			throw null;
		}

		// Token: 0x06000840 RID: 2112 RVA: 0x000038B1 File Offset: 0x00001AB1
		[global::Cpp2ILInjected.Token(Token = "0x6000919")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D1AC74", Offset = "0x1D1AC74", Length = "0xA8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JContainer), Member = "ContentsEqual", MemberParameters = new object[] { typeof(JContainer) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		internal override bool DeepEquals(JToken node)
		{
			throw null;
		}

		// Token: 0x06000841 RID: 2113 RVA: 0x000038B4 File Offset: 0x00001AB4
		[global::Cpp2ILInjected.Token(Token = "0x600091A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D1AD1C", Offset = "0x1D1AD1C", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JProperty), Member = ".ctor", MemberParameters = new object[] { typeof(JProperty) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal override JToken CloneToken()
		{
			throw null;
		}

		// Token: 0x1700018C RID: 396
		// (get) Token: 0x06000842 RID: 2114 RVA: 0x000038B7 File Offset: 0x00001AB7
		[global::Cpp2ILInjected.Token(Token = "0x170001A6")]
		public override JTokenType Type
		{
			[DebuggerStepThrough]
			[global::Cpp2ILInjected.Token(Token = "0x600091B")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D1AD74", Offset = "0x1D1AD74", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06000843 RID: 2115 RVA: 0x000038BA File Offset: 0x00001ABA
		[global::Cpp2ILInjected.Token(Token = "0x600091C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D1AD7C", Offset = "0x1D1AD7C", Length = "0x98")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JContainer), Member = "ReadContentFrom", MemberParameters = new object[]
		{
			typeof(JsonReader),
			typeof(JsonLoadSettings)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JTokenWriter), Member = "WritePropertyName", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JProperty), Member = "Load", MemberParameters = new object[]
		{
			typeof(JsonReader),
			typeof(JsonLoadSettings)
		}, ReturnType = typeof(JProperty))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JContainer), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ValidationUtils), Member = "ArgumentNotNull", MemberParameters = new object[]
		{
			typeof(object),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		internal JProperty(string name)
		{
			throw null;
		}

		// Token: 0x06000844 RID: 2116 RVA: 0x000038BD File Offset: 0x00001ABD
		[global::Cpp2ILInjected.Token(Token = "0x600091D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D1AE14", Offset = "0x1D1AE14", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallAnalysisNotSupported]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public JProperty(string name, params object[] content)
		{
			throw null;
		}

		// Token: 0x06000845 RID: 2117 RVA: 0x000038C0 File Offset: 0x00001AC0
		[global::Cpp2ILInjected.Token(Token = "0x600091E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D1AE18", Offset = "0x1D1AE18", Length = "0x100")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JObject), Member = "set_Item", MemberParameters = new object[]
		{
			typeof(string),
			typeof(JToken)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JObject), Member = "Add", MemberParameters = new object[]
		{
			typeof(string),
			typeof(JToken)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JObject), Member = "System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,Newtonsoft.Json.Linq.JToken>>.Add", MemberParameters = new object[] { typeof(KeyValuePair<string, JToken>) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JContainer), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ValidationUtils), Member = "ArgumentNotNull", MemberParameters = new object[]
		{
			typeof(object),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JContainer), Member = "IsMultiContent", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JArray), Member = ".ctor", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JContainer), Member = "CreateFromContent", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(JToken))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JProperty), Member = "set_Value", MemberParameters = new object[] { typeof(JToken) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public JProperty(string name, object content)
		{
			throw null;
		}

		// Token: 0x06000846 RID: 2118 RVA: 0x000038C3 File Offset: 0x00001AC3
		[global::Cpp2ILInjected.Token(Token = "0x600091F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D1AF18", Offset = "0x1D1AF18", Length = "0x78")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public override void WriteTo(JsonWriter writer, params JsonConverter[] converters)
		{
			throw null;
		}

		// Token: 0x06000847 RID: 2119 RVA: 0x000038C6 File Offset: 0x00001AC6
		[global::Cpp2ILInjected.Token(Token = "0x6000920")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D1AF90", Offset = "0x1D1AF90", Length = "0x50")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		internal override int GetDeepHashCode()
		{
			throw null;
		}

		// Token: 0x06000848 RID: 2120 RVA: 0x000038C9 File Offset: 0x00001AC9
		[global::Cpp2ILInjected.Token(Token = "0x6000921")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D1AFE0", Offset = "0x1D1AFE0", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public new static JProperty Load(JsonReader reader)
		{
			throw null;
		}

		// Token: 0x06000849 RID: 2121 RVA: 0x000038CC File Offset: 0x00001ACC
		[global::Cpp2ILInjected.Token(Token = "0x6000922")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D1AFE8", Offset = "0x1D1AFE8", Length = "0x1EC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JToken), Member = "ReadFrom", MemberParameters = new object[]
		{
			typeof(JsonReader),
			typeof(JsonLoadSettings)
		}, ReturnType = typeof(JToken))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonReader), Member = "MoveToContent", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JProperty), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JToken), Member = "SetLineInfo", MemberParameters = new object[]
		{
			typeof(IJsonLineInfo),
			typeof(JsonLoadSettings)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JContainer), Member = "ReadTokenFrom", MemberParameters = new object[]
		{
			typeof(JsonReader),
			typeof(JsonLoadSettings)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringUtils), Member = "FormatWith", MemberParameters = new object[]
		{
			typeof(string),
			typeof(IFormatProvider),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonReaderException), Member = "Create", MemberParameters = new object[]
		{
			typeof(JsonReader),
			typeof(string)
		}, ReturnType = typeof(JsonReaderException))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 14)]
		public new static JProperty Load(JsonReader reader, JsonLoadSettings settings)
		{
			throw null;
		}

		// Token: 0x040002AC RID: 684
		[global::Cpp2ILInjected.Token(Token = "0x400036B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
		private readonly JProperty.JPropertyList _content;

		// Token: 0x040002AD RID: 685
		[global::Cpp2ILInjected.Token(Token = "0x400036C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
		private readonly string _name;

		// Token: 0x0200012D RID: 301
		[global::Cpp2ILInjected.Token(Token = "0x20000DD")]
		private class JPropertyList : IList<JToken>, ICollection<JToken>, IEnumerable<JToken>, IEnumerable
		{
			// Token: 0x06000B58 RID: 2904 RVA: 0x00004184 File Offset: 0x00002384
			[global::Cpp2ILInjected.Token(Token = "0x6000923")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D1B1D4", Offset = "0x1D1B1D4", Length = "0x60")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JProperty.JPropertyList), Member = "System.Collections.IEnumerable.GetEnumerator", ReturnType = typeof(IEnumerator))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			public IEnumerator<JToken> GetEnumerator()
			{
				throw null;
			}

			// Token: 0x06000B59 RID: 2905 RVA: 0x00004187 File Offset: 0x00002387
			[global::Cpp2ILInjected.Token(Token = "0x6000924")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D1B25C", Offset = "0x1D1B25C", Length = "0x4")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JProperty.JPropertyList), Member = "GetEnumerator", ReturnType = typeof(IEnumerator<JToken>))]
			private IEnumerator System.Collections.IEnumerable.GetEnumerator()
			{
				throw null;
			}

			// Token: 0x06000B5A RID: 2906 RVA: 0x0000418A File Offset: 0x0000238A
			[global::Cpp2ILInjected.Token(Token = "0x6000925")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D1B260", Offset = "0x1D1B260", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public void Add(JToken item)
			{
				throw null;
			}

			// Token: 0x06000B5B RID: 2907 RVA: 0x0000418D File Offset: 0x0000238D
			[global::Cpp2ILInjected.Token(Token = "0x6000926")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D1B268", Offset = "0x1D1B268", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public void Clear()
			{
				throw null;
			}

			// Token: 0x06000B5C RID: 2908 RVA: 0x00004190 File Offset: 0x00002390
			[global::Cpp2ILInjected.Token(Token = "0x6000927")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D1B270", Offset = "0x1D1B270", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public bool Contains(JToken item)
			{
				throw null;
			}

			// Token: 0x06000B5D RID: 2909 RVA: 0x00004193 File Offset: 0x00002393
			[global::Cpp2ILInjected.Token(Token = "0x6000928")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D1B280", Offset = "0x1D1B280", Length = "0x4C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			public void CopyTo(JToken[] array, int arrayIndex)
			{
				throw null;
			}

			// Token: 0x06000B5E RID: 2910 RVA: 0x00004196 File Offset: 0x00002396
			[global::Cpp2ILInjected.Token(Token = "0x6000929")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D1B2CC", Offset = "0x1D1B2CC", Length = "0x20")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public bool Remove(JToken item)
			{
				throw null;
			}

			// Token: 0x1700022C RID: 556
			// (get) Token: 0x06000B5F RID: 2911 RVA: 0x00004199 File Offset: 0x00002399
			[global::Cpp2ILInjected.Token(Token = "0x170001A7")]
			public int Count
			{
				[global::Cpp2ILInjected.Token(Token = "0x600092A")]
				[global::Cpp2ILInjected.Address(RVA = "0x1D1B2EC", Offset = "0x1D1B2EC", Length = "0x10")]
				[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				get
				{
					throw null;
				}
			}

			// Token: 0x1700022D RID: 557
			// (get) Token: 0x06000B60 RID: 2912 RVA: 0x0000419C File Offset: 0x0000239C
			[global::Cpp2ILInjected.Token(Token = "0x170001A8")]
			public bool IsReadOnly
			{
				[global::Cpp2ILInjected.Token(Token = "0x600092B")]
				[global::Cpp2ILInjected.Address(RVA = "0x1D1B2FC", Offset = "0x1D1B2FC", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				get
				{
					throw null;
				}
			}

			// Token: 0x06000B61 RID: 2913 RVA: 0x0000419F File Offset: 0x0000239F
			[global::Cpp2ILInjected.Token(Token = "0x600092C")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D1A9E8", Offset = "0x1D1A9E8", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public int IndexOf(JToken item)
			{
				throw null;
			}

			// Token: 0x06000B62 RID: 2914 RVA: 0x000041A2 File Offset: 0x000023A2
			[global::Cpp2ILInjected.Token(Token = "0x600092D")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D1B304", Offset = "0x1D1B304", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public void Insert(int index, JToken item)
			{
				throw null;
			}

			// Token: 0x06000B63 RID: 2915 RVA: 0x000041A5 File Offset: 0x000023A5
			[global::Cpp2ILInjected.Token(Token = "0x600092E")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D1B314", Offset = "0x1D1B314", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public void RemoveAt(int index)
			{
				throw null;
			}

			// Token: 0x1700022E RID: 558
			[global::Cpp2ILInjected.Token(Token = "0x170001A9")]
			public JToken this[int index]
			{
				[global::Cpp2ILInjected.Token(Token = "0x600092F")]
				[global::Cpp2ILInjected.Address(RVA = "0x1D1B324", Offset = "0x1D1B324", Length = "0x14")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				get
				{
					throw null;
				}
				[global::Cpp2ILInjected.Token(Token = "0x6000930")]
				[global::Cpp2ILInjected.Address(RVA = "0x1D1B338", Offset = "0x1D1B338", Length = "0x10")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				set
				{
					throw null;
				}
			}

			// Token: 0x06000B66 RID: 2918 RVA: 0x000041AE File Offset: 0x000023AE
			[global::Cpp2ILInjected.Token(Token = "0x6000931")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D1A6E4", Offset = "0x1D1A6E4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public JPropertyList()
			{
				throw null;
			}

			// Token: 0x0400041F RID: 1055
			[global::Cpp2ILInjected.Token(Token = "0x400036D")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			internal JToken _token;

			// Token: 0x0200013F RID: 319
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x20000DE")]
			private sealed class <GetEnumerator>d__1 : IEnumerator<JToken>, IDisposable, IEnumerator
			{
				// Token: 0x06000BBD RID: 3005 RVA: 0x000042B3 File Offset: 0x000024B3
				[DebuggerHidden]
				[global::Cpp2ILInjected.Token(Token = "0x6000932")]
				[global::Cpp2ILInjected.Address(RVA = "0x1D1B234", Offset = "0x1D1B234", Length = "0x28")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
				public <GetEnumerator>d__1(int <>1__state)
				{
					throw null;
				}

				// Token: 0x06000BBE RID: 3006 RVA: 0x000042B6 File Offset: 0x000024B6
				[DebuggerHidden]
				[global::Cpp2ILInjected.Token(Token = "0x6000933")]
				[global::Cpp2ILInjected.Address(RVA = "0x1D1B348", Offset = "0x1D1B348", Length = "0x4")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				private void System.IDisposable.Dispose()
				{
					throw null;
				}

				// Token: 0x06000BBF RID: 3007 RVA: 0x000042B9 File Offset: 0x000024B9
				[global::Cpp2ILInjected.Token(Token = "0x6000934")]
				[global::Cpp2ILInjected.Address(RVA = "0x1D1B34C", Offset = "0x1D1B34C", Length = "0x50")]
				[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				private bool MoveNext()
				{
					throw null;
				}

				// Token: 0x1700023F RID: 575
				// (get) Token: 0x06000BC0 RID: 3008 RVA: 0x000042BC File Offset: 0x000024BC
				[global::Cpp2ILInjected.Token(Token = "0x170001AA")]
				private JToken System.Collections.Generic.IEnumerator<Newtonsoft.Json.Linq.JToken>.Current
				{
					[DebuggerHidden]
					[global::Cpp2ILInjected.Token(Token = "0x6000935")]
					[global::Cpp2ILInjected.Address(RVA = "0x1D1B39C", Offset = "0x1D1B39C", Length = "0x8")]
					[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
					get
					{
						throw null;
					}
				}

				// Token: 0x06000BC1 RID: 3009 RVA: 0x000042BF File Offset: 0x000024BF
				[DebuggerHidden]
				[global::Cpp2ILInjected.Token(Token = "0x6000936")]
				[global::Cpp2ILInjected.Address(RVA = "0x1D1B3A4", Offset = "0x1D1B3A4", Length = "0x38")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
				private void System.Collections.IEnumerator.Reset()
				{
					throw null;
				}

				// Token: 0x17000240 RID: 576
				// (get) Token: 0x06000BC2 RID: 3010 RVA: 0x000042C2 File Offset: 0x000024C2
				[global::Cpp2ILInjected.Token(Token = "0x170001AB")]
				private object System.Collections.IEnumerator.Current
				{
					[DebuggerHidden]
					[global::Cpp2ILInjected.Token(Token = "0x6000937")]
					[global::Cpp2ILInjected.Address(RVA = "0x1D1B3DC", Offset = "0x1D1B3DC", Length = "0x8")]
					[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
					get
					{
						throw null;
					}
				}

				// Token: 0x04000488 RID: 1160
				[global::Cpp2ILInjected.Token(Token = "0x400036E")]
				[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
				private int <>1__state;

				// Token: 0x04000489 RID: 1161
				[global::Cpp2ILInjected.Token(Token = "0x400036F")]
				[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
				private JToken <>2__current;

				// Token: 0x0400048A RID: 1162
				[global::Cpp2ILInjected.Token(Token = "0x4000370")]
				[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
				public JProperty.JPropertyList <>4__this;
			}
		}
	}
}
