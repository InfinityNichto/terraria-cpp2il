using System;
using System.Collections.Generic;
using System.Globalization;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Newtonsoft.Json.Shims;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json.Linq
{
	// Token: 0x02000098 RID: 152
	[Preserve]
	[global::Cpp2ILInjected.Token(Token = "0x20000CB")]
	public class JConstructor : JContainer
	{
		// Token: 0x1700014F RID: 335
		// (get) Token: 0x06000690 RID: 1680 RVA: 0x000033BC File Offset: 0x000015BC
		[global::Cpp2ILInjected.Token(Token = "0x1700015B")]
		protected override IList<JToken> ChildrenTokens
		{
			[global::Cpp2ILInjected.Token(Token = "0x600072C")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D04D24", Offset = "0x1D04D24", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06000691 RID: 1681 RVA: 0x000033BF File Offset: 0x000015BF
		[global::Cpp2ILInjected.Token(Token = "0x600072D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D04D2C", Offset = "0x1D04D2C", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CollectionUtils), Member = "IndexOfReference", MemberTypeParameters = new object[] { "T" }, MemberParameters = new object[] { "System.Collections.Generic.List`1<T>", "T" }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		internal override int IndexOfItem(JToken item)
		{
			throw null;
		}

		// Token: 0x06000692 RID: 1682 RVA: 0x000033C2 File Offset: 0x000015C2
		[global::Cpp2ILInjected.Token(Token = "0x600072E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D04D84", Offset = "0x1D04D84", Length = "0xA8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		internal override void MergeItem(object content, JsonMergeSettings settings)
		{
			throw null;
		}

		// Token: 0x17000150 RID: 336
		// (get) Token: 0x06000693 RID: 1683 RVA: 0x000033C5 File Offset: 0x000015C5
		// (set) Token: 0x06000694 RID: 1684 RVA: 0x000033C8 File Offset: 0x000015C8
		[global::Cpp2ILInjected.Token(Token = "0x1700015C")]
		public string Name
		{
			[global::Cpp2ILInjected.Token(Token = "0x600072F")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D05B7C", Offset = "0x1D05B7C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000730")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D05B84", Offset = "0x1D05B84", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000151 RID: 337
		// (get) Token: 0x06000695 RID: 1685 RVA: 0x000033CB File Offset: 0x000015CB
		[global::Cpp2ILInjected.Token(Token = "0x1700015D")]
		public override JTokenType Type
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000731")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D05B8C", Offset = "0x1D05B8C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06000696 RID: 1686 RVA: 0x000033CE File Offset: 0x000015CE
		[global::Cpp2ILInjected.Token(Token = "0x6000732")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D05B94", Offset = "0x1D05B94", Length = "0x78")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public JConstructor()
		{
			throw null;
		}

		// Token: 0x06000697 RID: 1687 RVA: 0x000033D1 File Offset: 0x000015D1
		[global::Cpp2ILInjected.Token(Token = "0x6000733")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D05C64", Offset = "0x1D05C64", Length = "0x8C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JConstructor), Member = "CloneToken", ReturnType = typeof(JToken))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JContainer), Member = ".ctor", MemberParameters = new object[] { typeof(JContainer) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public JConstructor(JConstructor other)
		{
			throw null;
		}

		// Token: 0x06000698 RID: 1688 RVA: 0x000033D4 File Offset: 0x000015D4
		[global::Cpp2ILInjected.Token(Token = "0x6000734")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D05FF4", Offset = "0x1D05FF4", Length = "0x34")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JConstructor), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public JConstructor(string name, params object[] content)
		{
			throw null;
		}

		// Token: 0x06000699 RID: 1689 RVA: 0x000033D7 File Offset: 0x000015D7
		[global::Cpp2ILInjected.Token(Token = "0x6000735")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D06028", Offset = "0x1D06028", Length = "0x34")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JConstructor), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public JConstructor(string name, object content)
		{
			throw null;
		}

		// Token: 0x0600069A RID: 1690 RVA: 0x000033DA File Offset: 0x000015DA
		[global::Cpp2ILInjected.Token(Token = "0x6000736")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D0605C", Offset = "0x1D0605C", Length = "0x120")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JConstructor), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object[])
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JConstructor), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JConstructor), Member = "Load", MemberParameters = new object[]
		{
			typeof(JsonReader),
			typeof(JsonLoadSettings)
		}, ReturnType = typeof(JConstructor))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JContainer), Member = "ReadContentFrom", MemberParameters = new object[]
		{
			typeof(JsonReader),
			typeof(JsonLoadSettings)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JTokenWriter), Member = "WriteStartConstructor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JContainer), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 12)]
		public JConstructor(string name)
		{
			throw null;
		}

		// Token: 0x0600069B RID: 1691 RVA: 0x000033DD File Offset: 0x000015DD
		[global::Cpp2ILInjected.Token(Token = "0x6000737")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D0617C", Offset = "0x1D0617C", Length = "0xA4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		internal override bool DeepEquals(JToken node)
		{
			throw null;
		}

		// Token: 0x0600069C RID: 1692 RVA: 0x000033E0 File Offset: 0x000015E0
		[global::Cpp2ILInjected.Token(Token = "0x6000738")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D064C4", Offset = "0x1D064C4", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JConstructor), Member = ".ctor", MemberParameters = new object[] { typeof(JConstructor) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal override JToken CloneToken()
		{
			throw null;
		}

		// Token: 0x0600069D RID: 1693 RVA: 0x000033E3 File Offset: 0x000015E3
		[global::Cpp2ILInjected.Token(Token = "0x6000739")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D0651C", Offset = "0x1D0651C", Length = "0x2D4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JEnumerable<>), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.IEnumerator`1<T>")]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 14)]
		public override void WriteTo(JsonWriter writer, params JsonConverter[] converters)
		{
			throw null;
		}

		// Token: 0x17000152 RID: 338
		[global::Cpp2ILInjected.Token(Token = "0x1700015E")]
		public override JToken this[object key]
		{
			[global::Cpp2ILInjected.Token(Token = "0x600073A")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D067F0", Offset = "0x1D067F0", Length = "0x124")]
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
			[global::Cpp2ILInjected.Token(Token = "0x600073B")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D06914", Offset = "0x1D06914", Length = "0x12C")]
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

		// Token: 0x060006A0 RID: 1696 RVA: 0x000033EC File Offset: 0x000015EC
		[global::Cpp2ILInjected.Token(Token = "0x600073C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D06A40", Offset = "0x1D06A40", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JContainer), Member = "ContentsHashCode", ReturnType = typeof(int))]
		internal override int GetDeepHashCode()
		{
			throw null;
		}

		// Token: 0x060006A1 RID: 1697 RVA: 0x000033EF File Offset: 0x000015EF
		[global::Cpp2ILInjected.Token(Token = "0x600073D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D06D58", Offset = "0x1D06D58", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public new static JConstructor Load(JsonReader reader)
		{
			throw null;
		}

		// Token: 0x060006A2 RID: 1698 RVA: 0x000033F2 File Offset: 0x000015F2
		[global::Cpp2ILInjected.Token(Token = "0x600073E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D06D60", Offset = "0x1D06D60", Length = "0x1E4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JToken), Member = "ReadFrom", MemberParameters = new object[]
		{
			typeof(JsonReader),
			typeof(JsonLoadSettings)
		}, ReturnType = typeof(JToken))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonReader), Member = "MoveToContent", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JConstructor), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
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
		public new static JConstructor Load(JsonReader reader, JsonLoadSettings settings)
		{
			throw null;
		}

		// Token: 0x0400028A RID: 650
		[global::Cpp2ILInjected.Token(Token = "0x4000319")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
		private string _name;

		// Token: 0x0400028B RID: 651
		[global::Cpp2ILInjected.Token(Token = "0x400031A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
		private readonly List<JToken> _values;
	}
}
