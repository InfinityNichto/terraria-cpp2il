using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq.JsonPath;
using Newtonsoft.Json.Shims;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json.Linq
{
	// Token: 0x0200009C RID: 156
	[Preserve]
	[global::Cpp2ILInjected.Token(Token = "0x20000D2")]
	public class JArray : JContainer, IList<JToken>, ICollection<JToken>, IEnumerable<JToken>, IEnumerable
	{
		// Token: 0x17000170 RID: 368
		// (get) Token: 0x06000747 RID: 1863 RVA: 0x000035D8 File Offset: 0x000017D8
		[global::Cpp2ILInjected.Token(Token = "0x17000180")]
		protected override IList<JToken> ChildrenTokens
		{
			[global::Cpp2ILInjected.Token(Token = "0x60007F7")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D0DF28", Offset = "0x1D0DF28", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000171 RID: 369
		// (get) Token: 0x06000748 RID: 1864 RVA: 0x000035DB File Offset: 0x000017DB
		[global::Cpp2ILInjected.Token(Token = "0x17000181")]
		public override JTokenType Type
		{
			[global::Cpp2ILInjected.Token(Token = "0x60007F8")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D0DF30", Offset = "0x1D0DF30", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06000749 RID: 1865 RVA: 0x000035DE File Offset: 0x000017DE
		[global::Cpp2ILInjected.Token(Token = "0x60007F9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D09F74", Offset = "0x1D09F74", Length = "0x78")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JContainer), Member = "ReadContentFrom", MemberParameters = new object[]
		{
			typeof(JsonReader),
			typeof(JsonLoadSettings)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JArray), Member = "Load", MemberParameters = new object[]
		{
			typeof(JsonReader),
			typeof(JsonLoadSettings)
		}, ReturnType = typeof(JArray))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JTokenWriter), Member = "WriteStartArray", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JContainer), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public JArray()
		{
			throw null;
		}

		// Token: 0x0600074A RID: 1866 RVA: 0x000035E1 File Offset: 0x000017E1
		[global::Cpp2ILInjected.Token(Token = "0x60007FA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D0DF38", Offset = "0x1D0DF38", Length = "0x80")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JArray), Member = "CloneToken", ReturnType = typeof(JToken))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JContainer), Member = ".ctor", MemberParameters = new object[] { typeof(JContainer) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public JArray(JArray other)
		{
			throw null;
		}

		// Token: 0x0600074B RID: 1867 RVA: 0x000035E4 File Offset: 0x000017E4
		[global::Cpp2ILInjected.Token(Token = "0x60007FB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D0DFB8", Offset = "0x1D0DFB8", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallAnalysisNotSupported]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public JArray(params object[] content)
		{
			throw null;
		}

		// Token: 0x0600074C RID: 1868 RVA: 0x000035E7 File Offset: 0x000017E7
		[global::Cpp2ILInjected.Token(Token = "0x60007FC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D0DFBC", Offset = "0x1D0DFBC", Length = "0x94")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JProperty), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JContainer), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public JArray(object content)
		{
			throw null;
		}

		// Token: 0x0600074D RID: 1869 RVA: 0x000035EA File Offset: 0x000017EA
		[global::Cpp2ILInjected.Token(Token = "0x60007FD")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D0E050", Offset = "0x1D0E050", Length = "0x8C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JContainer), Member = "ContentsEqual", MemberParameters = new object[] { typeof(JContainer) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		internal override bool DeepEquals(JToken node)
		{
			throw null;
		}

		// Token: 0x0600074E RID: 1870 RVA: 0x000035ED File Offset: 0x000017ED
		[global::Cpp2ILInjected.Token(Token = "0x60007FE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D0E0DC", Offset = "0x1D0E0DC", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JArray), Member = ".ctor", MemberParameters = new object[] { typeof(JArray) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal override JToken CloneToken()
		{
			throw null;
		}

		// Token: 0x0600074F RID: 1871 RVA: 0x000035F0 File Offset: 0x000017F0
		[global::Cpp2ILInjected.Token(Token = "0x60007FF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D0E134", Offset = "0x1D0E134", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HashSetConverter), Member = "ReadJson", MemberParameters = new object[]
		{
			typeof(JsonReader),
			typeof(Type),
			typeof(object),
			typeof(JsonSerializer)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		public new static JArray Load(JsonReader reader)
		{
			throw null;
		}

		// Token: 0x06000750 RID: 1872 RVA: 0x000035F3 File Offset: 0x000017F3
		[global::Cpp2ILInjected.Token(Token = "0x6000800")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D0E13C", Offset = "0x1D0E13C", Length = "0x18C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JArray), Member = "Parse", MemberParameters = new object[]
		{
			typeof(string),
			typeof(JsonLoadSettings)
		}, ReturnType = typeof(JArray))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JToken), Member = "ReadFrom", MemberParameters = new object[]
		{
			typeof(JsonReader),
			typeof(JsonLoadSettings)
		}, ReturnType = typeof(JToken))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonReader), Member = "MoveToContent", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JArray), Member = ".ctor", ReturnType = typeof(void))]
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
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 12)]
		public new static JArray Load(JsonReader reader, JsonLoadSettings settings)
		{
			throw null;
		}

		// Token: 0x06000751 RID: 1873 RVA: 0x000035F6 File Offset: 0x000017F6
		[global::Cpp2ILInjected.Token(Token = "0x6000801")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D0E2C8", Offset = "0x1D0E2C8", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public new static JArray Parse(string json)
		{
			throw null;
		}

		// Token: 0x06000752 RID: 1874 RVA: 0x000035F9 File Offset: 0x000017F9
		[global::Cpp2ILInjected.Token(Token = "0x6000802")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D0E2D0", Offset = "0x1D0E2D0", Length = "0x23C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringReader), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonTextReader), Member = ".ctor", MemberParameters = new object[] { typeof(TextReader) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JArray), Member = "Load", MemberParameters = new object[]
		{
			typeof(JsonReader),
			typeof(JsonLoadSettings)
		}, ReturnType = typeof(JArray))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonReaderException), Member = "Create", MemberParameters = new object[]
		{
			typeof(JsonReader),
			typeof(string)
		}, ReturnType = typeof(JsonReaderException))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 16)]
		public new static JArray Parse(string json, JsonLoadSettings settings)
		{
			throw null;
		}

		// Token: 0x06000753 RID: 1875 RVA: 0x000035FC File Offset: 0x000017FC
		[global::Cpp2ILInjected.Token(Token = "0x6000803")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D0E50C", Offset = "0x1D0E50C", Length = "0x20")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonSerializer), Member = "CreateDefault", ReturnType = typeof(JsonSerializer))]
		public new static JArray FromObject(object o)
		{
			throw null;
		}

		// Token: 0x06000754 RID: 1876 RVA: 0x000035FF File Offset: 0x000017FF
		[global::Cpp2ILInjected.Token(Token = "0x6000804")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D0E52C", Offset = "0x1D0E52C", Length = "0x178")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JToken), Member = "FromObjectInternal", MemberParameters = new object[]
		{
			typeof(object),
			typeof(JsonSerializer)
		}, ReturnType = typeof(JToken))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringUtils), Member = "FormatWith", MemberParameters = new object[]
		{
			typeof(string),
			typeof(IFormatProvider),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 13)]
		public new static JArray FromObject(object o, JsonSerializer jsonSerializer)
		{
			throw null;
		}

		// Token: 0x06000755 RID: 1877 RVA: 0x00003602 File Offset: 0x00001802
		[global::Cpp2ILInjected.Token(Token = "0x6000805")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D0E6A4", Offset = "0x1D0E6A4", Length = "0xC4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public override void WriteTo(JsonWriter writer, params JsonConverter[] converters)
		{
			throw null;
		}

		// Token: 0x17000172 RID: 370
		[global::Cpp2ILInjected.Token(Token = "0x17000182")]
		public override JToken this[object key]
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000806")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D0E768", Offset = "0x1D0E768", Length = "0x124")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ValidationUtils), Member = "ArgumentNotNull", MemberParameters = new object[]
			{
				typeof(object),
				typeof(string)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MiscellaneousUtils), Member = "ToString", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringUtils), Member = "FormatWith", MemberParameters = new object[]
			{
				typeof(string),
				typeof(IFormatProvider),
				typeof(object)
			}, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000807")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D0E88C", Offset = "0x1D0E88C", Length = "0x12C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ValidationUtils), Member = "ArgumentNotNull", MemberParameters = new object[]
			{
				typeof(object),
				typeof(string)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MiscellaneousUtils), Member = "ToString", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringUtils), Member = "FormatWith", MemberParameters = new object[]
			{
				typeof(string),
				typeof(IFormatProvider),
				typeof(object)
			}, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000173 RID: 371
		[global::Cpp2ILInjected.Token(Token = "0x17000183")]
		public JToken this[int index]
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000808")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D0E9B8", Offset = "0x1D0E9B8", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Linq.JsonPath.ArraySliceFilter.<ExecuteFilter>d__12", Member = "MoveNext", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PathFilter), Member = "GetTokenIndex", MemberParameters = new object[]
			{
				typeof(JToken),
				typeof(bool),
				typeof(int)
			}, ReturnType = typeof(JToken))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HashSetConverter), Member = "ReadJson", MemberParameters = new object[]
			{
				typeof(JsonReader),
				typeof(Type),
				typeof(object),
				typeof(JsonSerializer)
			}, ReturnType = typeof(object))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000809")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D0E9C8", Offset = "0x1D0E9C8", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			set
			{
				throw null;
			}
		}

		// Token: 0x0600075A RID: 1882 RVA: 0x00003611 File Offset: 0x00001811
		[global::Cpp2ILInjected.Token(Token = "0x600080A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D0E9D8", Offset = "0x1D0E9D8", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CollectionUtils), Member = "IndexOfReference", MemberTypeParameters = new object[] { "T" }, MemberParameters = new object[] { "System.Collections.Generic.List`1<T>", "T" }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		internal override int IndexOfItem(JToken item)
		{
			throw null;
		}

		// Token: 0x0600075B RID: 1883 RVA: 0x00003614 File Offset: 0x00001814
		[global::Cpp2ILInjected.Token(Token = "0x600080B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D0EA30", Offset = "0x1D0EA30", Length = "0xE0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JContainer), Member = "IsMultiContent", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JContainer), Member = "MergeEnumerableContent", MemberParameters = new object[]
		{
			typeof(JContainer),
			typeof(IEnumerable),
			typeof(JsonMergeSettings)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		internal override void MergeItem(object content, JsonMergeSettings settings)
		{
			throw null;
		}

		// Token: 0x0600075C RID: 1884 RVA: 0x00003617 File Offset: 0x00001817
		[global::Cpp2ILInjected.Token(Token = "0x600080C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D0EB10", Offset = "0x1D0EB10", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public int IndexOf(JToken item)
		{
			throw null;
		}

		// Token: 0x0600075D RID: 1885 RVA: 0x0000361A File Offset: 0x0000181A
		[global::Cpp2ILInjected.Token(Token = "0x600080D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D0EB20", Offset = "0x1D0EB20", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public void Insert(int index, JToken item)
		{
			throw null;
		}

		// Token: 0x0600075E RID: 1886 RVA: 0x0000361D File Offset: 0x0000181D
		[global::Cpp2ILInjected.Token(Token = "0x600080E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D0EB34", Offset = "0x1D0EB34", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public void RemoveAt(int index)
		{
			throw null;
		}

		// Token: 0x0600075F RID: 1887 RVA: 0x00003620 File Offset: 0x00001820
		[global::Cpp2ILInjected.Token(Token = "0x600080F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D0EB44", Offset = "0x1D0EB44", Length = "0x70")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JEnumerable<>), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.IEnumerator`1<T>")]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public IEnumerator<JToken> GetEnumerator()
		{
			throw null;
		}

		// Token: 0x06000760 RID: 1888 RVA: 0x00003623 File Offset: 0x00001823
		[global::Cpp2ILInjected.Token(Token = "0x6000810")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D0EBB4", Offset = "0x1D0EBB4", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public void Add(JToken item)
		{
			throw null;
		}

		// Token: 0x06000761 RID: 1889 RVA: 0x00003626 File Offset: 0x00001826
		[global::Cpp2ILInjected.Token(Token = "0x6000811")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D0EBC4", Offset = "0x1D0EBC4", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public void Clear()
		{
			throw null;
		}

		// Token: 0x06000762 RID: 1890 RVA: 0x00003629 File Offset: 0x00001829
		[global::Cpp2ILInjected.Token(Token = "0x6000812")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D0EBD4", Offset = "0x1D0EBD4", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public bool Contains(JToken item)
		{
			throw null;
		}

		// Token: 0x06000763 RID: 1891 RVA: 0x0000362C File Offset: 0x0000182C
		[global::Cpp2ILInjected.Token(Token = "0x6000813")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D0EBE4", Offset = "0x1D0EBE4", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public void CopyTo(JToken[] array, int arrayIndex)
		{
			throw null;
		}

		// Token: 0x17000174 RID: 372
		// (get) Token: 0x06000764 RID: 1892 RVA: 0x0000362F File Offset: 0x0000182F
		[global::Cpp2ILInjected.Token(Token = "0x17000184")]
		public bool IsReadOnly
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000814")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D0EBF4", Offset = "0x1D0EBF4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06000765 RID: 1893 RVA: 0x00003632 File Offset: 0x00001832
		[global::Cpp2ILInjected.Token(Token = "0x6000815")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D0EBFC", Offset = "0x1D0EBFC", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public bool Remove(JToken item)
		{
			throw null;
		}

		// Token: 0x06000766 RID: 1894 RVA: 0x00003635 File Offset: 0x00001835
		[global::Cpp2ILInjected.Token(Token = "0x6000816")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D0EC0C", Offset = "0x1D0EC0C", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JContainer), Member = "ContentsHashCode", ReturnType = typeof(int))]
		internal override int GetDeepHashCode()
		{
			throw null;
		}

		// Token: 0x04000295 RID: 661
		[global::Cpp2ILInjected.Token(Token = "0x4000333")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
		private readonly List<JToken> _values;
	}
}
