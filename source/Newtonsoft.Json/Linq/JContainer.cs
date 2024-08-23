using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Threading;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq.JsonPath;
using Newtonsoft.Json.Shims;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json.Linq
{
	// Token: 0x02000099 RID: 153
	[Preserve]
	[global::Cpp2ILInjected.Token(Token = "0x20000CC")]
	public abstract class JContainer : JToken, IList<JToken>, ICollection<JToken>, IEnumerable<JToken>, IEnumerable, ITypedList, IBindingList, IList, ICollection
	{
		// Token: 0x14000005 RID: 5
		// (add) Token: 0x060006A3 RID: 1699 RVA: 0x000033F5 File Offset: 0x000015F5
		// (remove) Token: 0x060006A4 RID: 1700 RVA: 0x000033F8 File Offset: 0x000015F8
		[global::Cpp2ILInjected.Token(Token = "0x14000005")]
		public event ListChangedEventHandler ListChanged
		{
			[global::Cpp2ILInjected.Token(Token = "0x600073F")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D07220", Offset = "0x1D07220", Length = "0x80")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new object[]
			{
				typeof(Delegate),
				typeof(Delegate)
			}, ReturnType = typeof(Delegate))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			add
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000740")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D072A0", Offset = "0x1D072A0", Length = "0x80")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new object[]
			{
				typeof(Delegate),
				typeof(Delegate)
			}, ReturnType = typeof(Delegate))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			remove
			{
				throw null;
			}
		}

		// Token: 0x14000006 RID: 6
		// (add) Token: 0x060006A5 RID: 1701 RVA: 0x000033FB File Offset: 0x000015FB
		// (remove) Token: 0x060006A6 RID: 1702 RVA: 0x000033FE File Offset: 0x000015FE
		[global::Cpp2ILInjected.Token(Token = "0x14000006")]
		public event global::System.ComponentModel.AddingNewEventHandler AddingNew
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000741")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D07320", Offset = "0x1D07320", Length = "0x80")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new object[]
			{
				typeof(Delegate),
				typeof(Delegate)
			}, ReturnType = typeof(Delegate))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			add
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000742")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D073A0", Offset = "0x1D073A0", Length = "0x80")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new object[]
			{
				typeof(Delegate),
				typeof(Delegate)
			}, ReturnType = typeof(Delegate))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			remove
			{
				throw null;
			}
		}

		// Token: 0x17000153 RID: 339
		// (get) Token: 0x060006A7 RID: 1703
		[global::Cpp2ILInjected.Token(Token = "0x1700015F")]
		protected abstract IList<JToken> ChildrenTokens
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000743")]
			get;
		}

		// Token: 0x060006A8 RID: 1704 RVA: 0x00003401 File Offset: 0x00001601
		[global::Cpp2ILInjected.Token(Token = "0x6000744")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D05C0C", Offset = "0x1D05C0C", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JConstructor), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JContainer), Member = ".ctor", MemberParameters = new object[] { typeof(JContainer) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JObject), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JObject), Member = ".ctor", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JArray), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JArray), Member = ".ctor", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JProperty), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JProperty), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 8)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal JContainer()
		{
			throw null;
		}

		// Token: 0x060006A9 RID: 1705 RVA: 0x00003404 File Offset: 0x00001604
		[global::Cpp2ILInjected.Token(Token = "0x6000745")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D05CF0", Offset = "0x1D05CF0", Length = "0x304")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JConstructor), Member = ".ctor", MemberParameters = new object[] { typeof(JConstructor) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JObject), Member = ".ctor", MemberParameters = new object[] { typeof(JObject) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JArray), Member = ".ctor", MemberParameters = new object[] { typeof(JArray) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JProperty), Member = ".ctor", MemberParameters = new object[] { typeof(JProperty) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JContainer), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ValidationUtils), Member = "ArgumentNotNull", MemberParameters = new object[]
		{
			typeof(object),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JContainer), Member = "AddInternal", MemberParameters = new object[]
		{
			typeof(int),
			typeof(object),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 16)]
		internal JContainer(JContainer other)
		{
			throw null;
		}

		// Token: 0x060006AA RID: 1706 RVA: 0x00003407 File Offset: 0x00001607
		[global::Cpp2ILInjected.Token(Token = "0x6000746")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D077B4", Offset = "0x1D077B4", Length = "0xA8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JContainer), Member = "InsertItem", MemberParameters = new object[]
		{
			typeof(int),
			typeof(JToken),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JContainer), Member = "RemoveItemAt", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JContainer), Member = "SetItem", MemberParameters = new object[]
		{
			typeof(int),
			typeof(JToken)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JContainer), Member = "ClearItems", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JProperty), Member = "set_Value", MemberParameters = new object[] { typeof(JToken) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringUtils), Member = "FormatWith", MemberParameters = new object[]
		{
			typeof(string),
			typeof(IFormatProvider),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		internal void CheckReentrancy()
		{
			throw null;
		}

		// Token: 0x060006AB RID: 1707 RVA: 0x0000340A File Offset: 0x0000160A
		[global::Cpp2ILInjected.Token(Token = "0x6000747")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D0785C", Offset = "0x1D0785C", Length = "0x68")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		internal virtual IList<JToken> CreateChildrenCollection()
		{
			throw null;
		}

		// Token: 0x060006AC RID: 1708 RVA: 0x0000340D File Offset: 0x0000160D
		[global::Cpp2ILInjected.Token(Token = "0x6000748")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D078C4", Offset = "0x1D078C4", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		protected virtual void OnAddingNew(global::System.ComponentModel.AddingNewEventArgs e)
		{
			throw null;
		}

		// Token: 0x060006AD RID: 1709 RVA: 0x00003410 File Offset: 0x00001610
		[global::Cpp2ILInjected.Token(Token = "0x6000749")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D078EC", Offset = "0x1D078EC", Length = "0x88")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		protected virtual void OnListChanged(ListChangedEventArgs e)
		{
			throw null;
		}

		// Token: 0x17000154 RID: 340
		// (get) Token: 0x060006AE RID: 1710 RVA: 0x00003413 File Offset: 0x00001613
		[global::Cpp2ILInjected.Token(Token = "0x17000160")]
		public override bool HasValues
		{
			[global::Cpp2ILInjected.Token(Token = "0x600074A")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D07974", Offset = "0x1D07974", Length = "0xB8")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x060006AF RID: 1711 RVA: 0x00003416 File Offset: 0x00001616
		[global::Cpp2ILInjected.Token(Token = "0x600074B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D06220", Offset = "0x1D06220", Length = "0x2A4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JArray), Member = "DeepEquals", MemberParameters = new object[] { typeof(JToken) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JProperty), Member = "DeepEquals", MemberParameters = new object[] { typeof(JToken) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		internal bool ContentsEqual(JContainer container)
		{
			throw null;
		}

		// Token: 0x17000155 RID: 341
		// (get) Token: 0x060006B0 RID: 1712 RVA: 0x00003419 File Offset: 0x00001619
		[global::Cpp2ILInjected.Token(Token = "0x17000161")]
		public override JToken First
		{
			[global::Cpp2ILInjected.Token(Token = "0x600074C")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D07A2C", Offset = "0x1D07A2C", Length = "0x134")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000156 RID: 342
		// (get) Token: 0x060006B1 RID: 1713 RVA: 0x0000341C File Offset: 0x0000161C
		[global::Cpp2ILInjected.Token(Token = "0x17000162")]
		public override JToken Last
		{
			[global::Cpp2ILInjected.Token(Token = "0x600074D")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D07B60", Offset = "0x1D07B60", Length = "0x134")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
			get
			{
				throw null;
			}
		}

		// Token: 0x060006B2 RID: 1714 RVA: 0x0000341F File Offset: 0x0000161F
		[global::Cpp2ILInjected.Token(Token = "0x600074E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D07C94", Offset = "0x1D07C94", Length = "0x74")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JEnumerable<>), Member = ".ctor", MemberParameters = new object[] { "System.Collections.Generic.IEnumerable`1<T>" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override JEnumerable<JToken> Children()
		{
			throw null;
		}

		// Token: 0x060006B3 RID: 1715 RVA: 0x00003422 File Offset: 0x00001622
		[global::Cpp2ILInjected.Token(Token = "0x600074F")]
		[global::Cpp2ILInjected.Address(RVA = "0x158BE80", Offset = "0x158BE80", Length = "0x30")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override IEnumerable<T> Values<T>()
		{
			throw null;
		}

		// Token: 0x060006B4 RID: 1716 RVA: 0x00003425 File Offset: 0x00001625
		[global::Cpp2ILInjected.Token(Token = "0x6000750")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D07D08", Offset = "0x1D07D08", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Linq.Extensions.<>c__2`1", Member = "<Descendants>b__2_0", MemberParameters = new object[] { "T" }, ReturnType = typeof(IEnumerable<JToken>))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		public IEnumerable<JToken> Descendants()
		{
			throw null;
		}

		// Token: 0x060006B5 RID: 1717 RVA: 0x00003428 File Offset: 0x00001628
		[global::Cpp2ILInjected.Token(Token = "0x6000751")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D07D7C", Offset = "0x1D07D7C", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Linq.Extensions.<>c__3`1", Member = "<DescendantsAndSelf>b__3_0", MemberParameters = new object[] { "T" }, ReturnType = typeof(IEnumerable<JToken>))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JContainer), Member = "GetDescendants", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(IEnumerable<JToken>))]
		public IEnumerable<JToken> DescendantsAndSelf()
		{
			throw null;
		}

		// Token: 0x060006B6 RID: 1718 RVA: 0x0000342B File Offset: 0x0000162B
		[global::Cpp2ILInjected.Token(Token = "0x6000752")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D07D10", Offset = "0x1D07D10", Length = "0x6C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JContainer.<GetDescendants>d__29), Member = "MoveNext", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JContainer), Member = "DescendantsAndSelf", ReturnType = typeof(IEnumerable<JToken>))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JContainer.<GetDescendants>d__29), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal IEnumerable<JToken> GetDescendants(bool self)
		{
			throw null;
		}

		// Token: 0x060006B7 RID: 1719 RVA: 0x0000342E File Offset: 0x0000162E
		[global::Cpp2ILInjected.Token(Token = "0x6000753")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D07DC0", Offset = "0x1D07DC0", Length = "0xE4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JContainer), Member = "AddInternal", MemberParameters = new object[]
		{
			typeof(int),
			typeof(object),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JArray), Member = "MergeItem", MemberParameters = new object[]
		{
			typeof(object),
			typeof(JsonMergeSettings)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JProperty), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		internal bool IsMultiContent(object content)
		{
			throw null;
		}

		// Token: 0x060006B8 RID: 1720 RVA: 0x00003431 File Offset: 0x00001631
		[global::Cpp2ILInjected.Token(Token = "0x6000754")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D07EA4", Offset = "0x1D07EA4", Length = "0x98")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JContainer), Member = "InsertItem", MemberParameters = new object[]
		{
			typeof(int),
			typeof(JToken),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JContainer), Member = "SetItem", MemberParameters = new object[]
		{
			typeof(int),
			typeof(JToken)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JValue), Member = "CreateNull", ReturnType = typeof(JValue))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		internal JToken EnsureParentToken(JToken item, bool skipParentCheck)
		{
			throw null;
		}

		// Token: 0x060006B9 RID: 1721
		[global::Cpp2ILInjected.Token(Token = "0x6000755")]
		internal abstract int IndexOfItem(JToken item);

		// Token: 0x060006BA RID: 1722 RVA: 0x00003434 File Offset: 0x00001634
		[global::Cpp2ILInjected.Token(Token = "0x6000756")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D07F54", Offset = "0x1D07F54", Length = "0x390")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JObject), Member = "InsertItem", MemberParameters = new object[]
		{
			typeof(int),
			typeof(JToken),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JProperty), Member = "InsertItem", MemberParameters = new object[]
		{
			typeof(int),
			typeof(JToken),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JContainer), Member = "CheckReentrancy", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JContainer), Member = "EnsureParentToken", MemberParameters = new object[]
		{
			typeof(JToken),
			typeof(bool)
		}, ReturnType = typeof(JToken))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ListChangedEventArgs), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(ListChangedType),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 16)]
		internal virtual void InsertItem(int index, JToken item, bool skipParentCheck)
		{
			throw null;
		}

		// Token: 0x060006BB RID: 1723 RVA: 0x00003437 File Offset: 0x00001637
		[global::Cpp2ILInjected.Token(Token = "0x6000757")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D082E4", Offset = "0x1D082E4", Length = "0x3F0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JContainer), Member = "CheckReentrancy", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ListChangedEventArgs), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(ListChangedType),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 20)]
		internal virtual void RemoveItemAt(int index)
		{
			throw null;
		}

		// Token: 0x060006BC RID: 1724 RVA: 0x0000343A File Offset: 0x0000163A
		[global::Cpp2ILInjected.Token(Token = "0x6000758")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D086D4", Offset = "0x1D086D4", Length = "0x48")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		internal virtual bool RemoveItem(JToken item)
		{
			throw null;
		}

		// Token: 0x060006BD RID: 1725 RVA: 0x0000343D File Offset: 0x0000163D
		[global::Cpp2ILInjected.Token(Token = "0x6000759")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D0871C", Offset = "0x1D0871C", Length = "0xBC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		internal virtual JToken GetItem(int index)
		{
			throw null;
		}

		// Token: 0x060006BE RID: 1726 RVA: 0x00003440 File Offset: 0x00001640
		[global::Cpp2ILInjected.Token(Token = "0x600075A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D087D8", Offset = "0x1D087D8", Length = "0x444")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JProperty), Member = "SetItem", MemberParameters = new object[]
		{
			typeof(int),
			typeof(JToken)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JContainer), Member = "IsTokenUnchanged", MemberParameters = new object[]
		{
			typeof(JToken),
			typeof(JToken)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JContainer), Member = "CheckReentrancy", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JContainer), Member = "EnsureParentToken", MemberParameters = new object[]
		{
			typeof(JToken),
			typeof(bool)
		}, ReturnType = typeof(JToken))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ListChangedEventArgs), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(ListChangedType),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 20)]
		internal virtual void SetItem(int index, JToken item)
		{
			throw null;
		}

		// Token: 0x060006BF RID: 1727 RVA: 0x00003443 File Offset: 0x00001643
		[global::Cpp2ILInjected.Token(Token = "0x600075B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D08CDC", Offset = "0x1D08CDC", Length = "0x3B8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JContainer), Member = "CheckReentrancy", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ListChangedEventArgs), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(ListChangedType),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 20)]
		internal virtual void ClearItems()
		{
			throw null;
		}

		// Token: 0x060006C0 RID: 1728 RVA: 0x00003446 File Offset: 0x00001646
		[global::Cpp2ILInjected.Token(Token = "0x600075C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D09094", Offset = "0x1D09094", Length = "0x64")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		internal virtual void ReplaceItem(JToken existing, JToken replacement)
		{
			throw null;
		}

		// Token: 0x060006C1 RID: 1729 RVA: 0x00003449 File Offset: 0x00001649
		[global::Cpp2ILInjected.Token(Token = "0x600075D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D090F8", Offset = "0x1D090F8", Length = "0x24")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		internal virtual bool ContainsItem(JToken item)
		{
			throw null;
		}

		// Token: 0x060006C2 RID: 1730 RVA: 0x0000344C File Offset: 0x0000164C
		[global::Cpp2ILInjected.Token(Token = "0x600075E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D0911C", Offset = "0x1D0911C", Length = "0x41C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Array), Member = "get_Length", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JContainer), Member = "get_Count", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Array), Member = "SetValue", MemberParameters = new object[]
		{
			typeof(object),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 29)]
		internal virtual void CopyItemsTo(Array array, int arrayIndex)
		{
			throw null;
		}

		// Token: 0x060006C3 RID: 1731 RVA: 0x0000344F File Offset: 0x0000164F
		[global::Cpp2ILInjected.Token(Token = "0x600075F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D08C1C", Offset = "0x1D08C1C", Length = "0xC0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JContainer), Member = "SetItem", MemberParameters = new object[]
		{
			typeof(int),
			typeof(JToken)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JProperty), Member = "SetItem", MemberParameters = new object[]
		{
			typeof(int),
			typeof(JToken)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal static bool IsTokenUnchanged(JToken currentValue, JToken newValue)
		{
			throw null;
		}

		// Token: 0x060006C4 RID: 1732 RVA: 0x00003452 File Offset: 0x00001652
		[global::Cpp2ILInjected.Token(Token = "0x6000760")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D095E4", Offset = "0x1D095E4", Length = "0x110")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ValidationUtils), Member = "ArgumentNotNull", MemberParameters = new object[]
		{
			typeof(object),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringUtils), Member = "FormatWith", MemberParameters = new object[]
		{
			typeof(string),
			typeof(IFormatProvider),
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		internal virtual void ValidateToken(JToken o, JToken existing)
		{
			throw null;
		}

		// Token: 0x060006C5 RID: 1733 RVA: 0x00003455 File Offset: 0x00001655
		[global::Cpp2ILInjected.Token(Token = "0x6000761")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D096F4", Offset = "0x1D096F4", Length = "0xCC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JContainer), Member = "AddInternal", MemberParameters = new object[]
		{
			typeof(int),
			typeof(object),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public virtual void Add(object content)
		{
			throw null;
		}

		// Token: 0x060006C6 RID: 1734 RVA: 0x00003458 File Offset: 0x00001658
		[global::Cpp2ILInjected.Token(Token = "0x6000762")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D097C0", Offset = "0x1D097C0", Length = "0xCC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JTokenWriter), Member = "WriteStartObject", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JTokenWriter), Member = "AddParent", MemberParameters = new object[] { typeof(JContainer) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JTokenWriter), Member = "WriteStartArray", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JTokenWriter), Member = "WriteStartConstructor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JTokenWriter), Member = "WritePropertyName", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JContainer), Member = "AddInternal", MemberParameters = new object[]
		{
			typeof(int),
			typeof(object),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal void AddAndSkipParentCheck(JToken token)
		{
			throw null;
		}

		// Token: 0x060006C7 RID: 1735 RVA: 0x0000345B File Offset: 0x0000165B
		[global::Cpp2ILInjected.Token(Token = "0x6000763")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D0988C", Offset = "0x1D0988C", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JContainer), Member = "AddInternal", MemberParameters = new object[]
		{
			typeof(int),
			typeof(object),
			typeof(bool)
		}, ReturnType = typeof(void))]
		public void AddFirst(object content)
		{
			throw null;
		}

		// Token: 0x060006C8 RID: 1736 RVA: 0x0000345E File Offset: 0x0000165E
		[global::Cpp2ILInjected.Token(Token = "0x6000764")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D07428", Offset = "0x1D07428", Length = "0x38C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JContainer), Member = ".ctor", MemberParameters = new object[] { typeof(JContainer) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JContainer), Member = "Add", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JContainer), Member = "AddAndSkipParentCheck", MemberParameters = new object[] { typeof(JToken) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JContainer), Member = "AddFirst", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JContainer), Member = "AddInternal", MemberParameters = new object[]
		{
			typeof(int),
			typeof(object),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JToken), Member = "AddAfterSelf", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JToken), Member = "AddBeforeSelf", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 7)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JContainer), Member = "IsMultiContent", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JContainer), Member = "AddInternal", MemberParameters = new object[]
		{
			typeof(int),
			typeof(object),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JContainer), Member = "CreateFromContent", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(JToken))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 20)]
		internal void AddInternal(int index, object content, bool skipParentCheck)
		{
			throw null;
		}

		// Token: 0x060006C9 RID: 1737 RVA: 0x00003461 File Offset: 0x00001661
		[global::Cpp2ILInjected.Token(Token = "0x6000765")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D0989C", Offset = "0x1D0989C", Length = "0xA4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JContainer), Member = "AddInternal", MemberParameters = new object[]
		{
			typeof(int),
			typeof(object),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JContainer), Member = "MergeEnumerableContent", MemberParameters = new object[]
		{
			typeof(JContainer),
			typeof(IEnumerable),
			typeof(JsonMergeSettings)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JProperty), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JValue), Member = ".ctor", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		internal static JToken CreateFromContent(object content)
		{
			throw null;
		}

		// Token: 0x060006CA RID: 1738 RVA: 0x00003464 File Offset: 0x00001664
		[global::Cpp2ILInjected.Token(Token = "0x6000766")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D09940", Offset = "0x1D09940", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JTokenWriter), Member = ".ctor", MemberParameters = new object[] { typeof(JContainer) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public JsonWriter CreateWriter()
		{
			throw null;
		}

		// Token: 0x060006CB RID: 1739 RVA: 0x00003467 File Offset: 0x00001667
		[global::Cpp2ILInjected.Token(Token = "0x6000767")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D09A28", Offset = "0x1D09A28", Length = "0x44")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public void ReplaceAll(object content)
		{
			throw null;
		}

		// Token: 0x060006CC RID: 1740 RVA: 0x0000346A File Offset: 0x0000166A
		[global::Cpp2ILInjected.Token(Token = "0x6000768")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D09A6C", Offset = "0x1D09A6C", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public void RemoveAll()
		{
			throw null;
		}

		// Token: 0x060006CD RID: 1741
		[global::Cpp2ILInjected.Token(Token = "0x6000769")]
		internal abstract void MergeItem(object content, JsonMergeSettings settings);

		// Token: 0x060006CE RID: 1742 RVA: 0x0000346D File Offset: 0x0000166D
		[global::Cpp2ILInjected.Token(Token = "0x600076A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D09A7C", Offset = "0x1D09A7C", Length = "0x78")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public void Merge(object content)
		{
			throw null;
		}

		// Token: 0x060006CF RID: 1743 RVA: 0x00003470 File Offset: 0x00001670
		[global::Cpp2ILInjected.Token(Token = "0x600076B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D09AF4", Offset = "0x1D09AF4", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public void Merge(object content, JsonMergeSettings settings)
		{
			throw null;
		}

		// Token: 0x060006D0 RID: 1744 RVA: 0x00003473 File Offset: 0x00001673
		[global::Cpp2ILInjected.Token(Token = "0x600076C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D070E4", Offset = "0x1D070E4", Length = "0x13C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JConstructor), Member = "Load", MemberParameters = new object[]
		{
			typeof(JsonReader),
			typeof(JsonLoadSettings)
		}, ReturnType = typeof(JConstructor))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JObject), Member = "Load", MemberParameters = new object[]
		{
			typeof(JsonReader),
			typeof(JsonLoadSettings)
		}, ReturnType = typeof(JObject))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JArray), Member = "Load", MemberParameters = new object[]
		{
			typeof(JsonReader),
			typeof(JsonLoadSettings)
		}, ReturnType = typeof(JArray))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JProperty), Member = "Load", MemberParameters = new object[]
		{
			typeof(JsonReader),
			typeof(JsonLoadSettings)
		}, ReturnType = typeof(JProperty))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JContainer), Member = "ReadContentFrom", MemberParameters = new object[]
		{
			typeof(JsonReader),
			typeof(JsonLoadSettings)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
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
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		internal void ReadTokenFrom(JsonReader reader, JsonLoadSettings options)
		{
			throw null;
		}

		// Token: 0x060006D1 RID: 1745 RVA: 0x00003476 File Offset: 0x00001676
		[global::Cpp2ILInjected.Token(Token = "0x600076D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D09B04", Offset = "0x1D09B04", Length = "0x470")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JContainer), Member = "ReadTokenFrom", MemberParameters = new object[]
		{
			typeof(JsonReader),
			typeof(JsonLoadSettings)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ValidationUtils), Member = "ArgumentNotNull", MemberParameters = new object[]
		{
			typeof(object),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JProperty), Member = "get_Value", ReturnType = typeof(JToken))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JValue), Member = ".ctor", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JToken), Member = "SetLineInfo", MemberParameters = new object[]
		{
			typeof(IJsonLineInfo),
			typeof(JsonLoadSettings)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JValue), Member = "CreateUndefined", ReturnType = typeof(JValue))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JValue), Member = "CreateComment", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(JValue))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JArray), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JProperty), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JObject), Member = "Property", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(JProperty))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JToken), Member = "Replace", MemberParameters = new object[] { typeof(JToken) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JConstructor), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JObject), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JValue), Member = "CreateNull", ReturnType = typeof(JValue))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringUtils), Member = "FormatWith", MemberParameters = new object[]
		{
			typeof(string),
			typeof(IFormatProvider),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 24)]
		internal void ReadContentFrom(JsonReader r, JsonLoadSettings settings)
		{
			throw null;
		}

		// Token: 0x060006D2 RID: 1746 RVA: 0x00003479 File Offset: 0x00001679
		[global::Cpp2ILInjected.Token(Token = "0x600076E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D06A78", Offset = "0x1D06A78", Length = "0x2E0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JConstructor), Member = "GetDeepHashCode", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JObject), Member = "GetDeepHashCode", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JArray), Member = "GetDeepHashCode", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 15)]
		internal int ContentsHashCode()
		{
			throw null;
		}

		// Token: 0x060006D3 RID: 1747 RVA: 0x0000347C File Offset: 0x0000167C
		[global::Cpp2ILInjected.Token(Token = "0x600076F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D0A158", Offset = "0x1D0A158", Length = "0x48")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		private string System.ComponentModel.ITypedList.GetListName(PropertyDescriptor[] listAccessors)
		{
			throw null;
		}

		// Token: 0x060006D4 RID: 1748 RVA: 0x0000347F File Offset: 0x0000167F
		[global::Cpp2ILInjected.Token(Token = "0x6000770")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D0A1A0", Offset = "0x1D0A1A0", Length = "0xC8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		private PropertyDescriptorCollection System.ComponentModel.ITypedList.GetItemProperties(PropertyDescriptor[] listAccessors)
		{
			throw null;
		}

		// Token: 0x060006D5 RID: 1749 RVA: 0x00003482 File Offset: 0x00001682
		[global::Cpp2ILInjected.Token(Token = "0x6000771")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D0A268", Offset = "0x1D0A268", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		private int System.Collections.Generic.IList<Newtonsoft.Json.Linq.JToken>.IndexOf(JToken item)
		{
			throw null;
		}

		// Token: 0x060006D6 RID: 1750 RVA: 0x00003485 File Offset: 0x00001685
		[global::Cpp2ILInjected.Token(Token = "0x6000772")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D0A278", Offset = "0x1D0A278", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		private void System.Collections.Generic.IList<Newtonsoft.Json.Linq.JToken>.Insert(int index, JToken item)
		{
			throw null;
		}

		// Token: 0x060006D7 RID: 1751 RVA: 0x00003488 File Offset: 0x00001688
		[global::Cpp2ILInjected.Token(Token = "0x6000773")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D0A28C", Offset = "0x1D0A28C", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		private void System.Collections.Generic.IList<Newtonsoft.Json.Linq.JToken>.RemoveAt(int index)
		{
			throw null;
		}

		// Token: 0x17000157 RID: 343
		// (get) Token: 0x060006D8 RID: 1752 RVA: 0x0000348B File Offset: 0x0000168B
		// (set) Token: 0x060006D9 RID: 1753 RVA: 0x0000348E File Offset: 0x0000168E
		[global::Cpp2ILInjected.Token(Token = "0x17000163")]
		private JToken System.Collections.Generic.IList<Newtonsoft.Json.Linq.JToken>.Item
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000774")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D0A29C", Offset = "0x1D0A29C", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000775")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D0A2AC", Offset = "0x1D0A2AC", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			set
			{
				throw null;
			}
		}

		// Token: 0x060006DA RID: 1754 RVA: 0x00003491 File Offset: 0x00001691
		[global::Cpp2ILInjected.Token(Token = "0x6000776")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D0A2BC", Offset = "0x1D0A2BC", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		private void System.Collections.Generic.ICollection<Newtonsoft.Json.Linq.JToken>.Add(JToken item)
		{
			throw null;
		}

		// Token: 0x060006DB RID: 1755 RVA: 0x00003494 File Offset: 0x00001694
		[global::Cpp2ILInjected.Token(Token = "0x6000777")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D0A2CC", Offset = "0x1D0A2CC", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		private void System.Collections.Generic.ICollection<Newtonsoft.Json.Linq.JToken>.Clear()
		{
			throw null;
		}

		// Token: 0x060006DC RID: 1756 RVA: 0x00003497 File Offset: 0x00001697
		[global::Cpp2ILInjected.Token(Token = "0x6000778")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D0A2DC", Offset = "0x1D0A2DC", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		private bool System.Collections.Generic.ICollection<Newtonsoft.Json.Linq.JToken>.Contains(JToken item)
		{
			throw null;
		}

		// Token: 0x060006DD RID: 1757 RVA: 0x0000349A File Offset: 0x0000169A
		[global::Cpp2ILInjected.Token(Token = "0x6000779")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D0A2EC", Offset = "0x1D0A2EC", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		private void System.Collections.Generic.ICollection<Newtonsoft.Json.Linq.JToken>.CopyTo(JToken[] array, int arrayIndex)
		{
			throw null;
		}

		// Token: 0x17000158 RID: 344
		// (get) Token: 0x060006DE RID: 1758 RVA: 0x0000349D File Offset: 0x0000169D
		[global::Cpp2ILInjected.Token(Token = "0x17000164")]
		private bool System.Collections.Generic.ICollection<Newtonsoft.Json.Linq.JToken>.IsReadOnly
		{
			[global::Cpp2ILInjected.Token(Token = "0x600077A")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D0A2FC", Offset = "0x1D0A2FC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x060006DF RID: 1759 RVA: 0x000034A0 File Offset: 0x000016A0
		[global::Cpp2ILInjected.Token(Token = "0x600077B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D0A304", Offset = "0x1D0A304", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		private bool System.Collections.Generic.ICollection<Newtonsoft.Json.Linq.JToken>.Remove(JToken item)
		{
			throw null;
		}

		// Token: 0x060006E0 RID: 1760 RVA: 0x000034A3 File Offset: 0x000016A3
		[global::Cpp2ILInjected.Token(Token = "0x600077C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D0A314", Offset = "0x1D0A314", Length = "0xBC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JContainer), Member = "System.Collections.IList.Add", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JContainer), Member = "System.Collections.IList.Contains", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JContainer), Member = "System.Collections.IList.IndexOf", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JContainer), Member = "System.Collections.IList.Insert", MemberParameters = new object[]
		{
			typeof(int),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JContainer), Member = "System.Collections.IList.Remove", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JContainer), Member = "System.Collections.IList.set_Item", MemberParameters = new object[]
		{
			typeof(int),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		private JToken EnsureValue(object value)
		{
			throw null;
		}

		// Token: 0x060006E1 RID: 1761 RVA: 0x000034A6 File Offset: 0x000016A6
		[global::Cpp2ILInjected.Token(Token = "0x600077D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D0A3D0", Offset = "0x1D0A3D0", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JContainer), Member = "EnsureValue", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(JToken))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JContainer), Member = "get_Count", ReturnType = typeof(int))]
		private int System.Collections.IList.Add(object value)
		{
			throw null;
		}

		// Token: 0x060006E2 RID: 1762 RVA: 0x000034A9 File Offset: 0x000016A9
		[global::Cpp2ILInjected.Token(Token = "0x600077E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D0A408", Offset = "0x1D0A408", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		private void System.Collections.IList.Clear()
		{
			throw null;
		}

		// Token: 0x060006E3 RID: 1763 RVA: 0x000034AC File Offset: 0x000016AC
		[global::Cpp2ILInjected.Token(Token = "0x600077F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D0A418", Offset = "0x1D0A418", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JContainer), Member = "EnsureValue", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(JToken))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		private bool System.Collections.IList.Contains(object value)
		{
			throw null;
		}

		// Token: 0x060006E4 RID: 1764 RVA: 0x000034AF File Offset: 0x000016AF
		[global::Cpp2ILInjected.Token(Token = "0x6000780")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D0A440", Offset = "0x1D0A440", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JContainer), Member = "EnsureValue", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(JToken))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		private int System.Collections.IList.IndexOf(object value)
		{
			throw null;
		}

		// Token: 0x060006E5 RID: 1765 RVA: 0x000034B2 File Offset: 0x000016B2
		[global::Cpp2ILInjected.Token(Token = "0x6000781")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D0A468", Offset = "0x1D0A468", Length = "0x40")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JContainer), Member = "EnsureValue", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(JToken))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		private void System.Collections.IList.Insert(int index, object value)
		{
			throw null;
		}

		// Token: 0x17000159 RID: 345
		// (get) Token: 0x060006E6 RID: 1766 RVA: 0x000034B5 File Offset: 0x000016B5
		[global::Cpp2ILInjected.Token(Token = "0x17000165")]
		private bool System.Collections.IList.IsFixedSize
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000782")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D0A4A8", Offset = "0x1D0A4A8", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700015A RID: 346
		// (get) Token: 0x060006E7 RID: 1767 RVA: 0x000034B8 File Offset: 0x000016B8
		[global::Cpp2ILInjected.Token(Token = "0x17000166")]
		private bool System.Collections.IList.IsReadOnly
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000783")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D0A4B0", Offset = "0x1D0A4B0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x060006E8 RID: 1768 RVA: 0x000034BB File Offset: 0x000016BB
		[global::Cpp2ILInjected.Token(Token = "0x6000784")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D0A4B8", Offset = "0x1D0A4B8", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JContainer), Member = "EnsureValue", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(JToken))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		private void System.Collections.IList.Remove(object value)
		{
			throw null;
		}

		// Token: 0x060006E9 RID: 1769 RVA: 0x000034BE File Offset: 0x000016BE
		[global::Cpp2ILInjected.Token(Token = "0x6000785")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D0A4E0", Offset = "0x1D0A4E0", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		private void System.Collections.IList.RemoveAt(int index)
		{
			throw null;
		}

		// Token: 0x1700015B RID: 347
		// (get) Token: 0x060006EA RID: 1770 RVA: 0x000034C1 File Offset: 0x000016C1
		// (set) Token: 0x060006EB RID: 1771 RVA: 0x000034C4 File Offset: 0x000016C4
		[global::Cpp2ILInjected.Token(Token = "0x17000167")]
		private object System.Collections.IList.Item
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000786")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D0A4F0", Offset = "0x1D0A4F0", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000787")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D0A500", Offset = "0x1D0A500", Length = "0x3C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JContainer), Member = "EnsureValue", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(JToken))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			set
			{
				throw null;
			}
		}

		// Token: 0x060006EC RID: 1772 RVA: 0x000034C7 File Offset: 0x000016C7
		[global::Cpp2ILInjected.Token(Token = "0x6000788")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D0A53C", Offset = "0x1D0A53C", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		private void System.Collections.ICollection.CopyTo(Array array, int index)
		{
			throw null;
		}

		// Token: 0x1700015C RID: 348
		// (get) Token: 0x060006ED RID: 1773 RVA: 0x000034CA File Offset: 0x000016CA
		[global::Cpp2ILInjected.Token(Token = "0x17000168")]
		public int Count
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000789")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D09538", Offset = "0x1D09538", Length = "0xAC")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JContainer), Member = "CopyItemsTo", MemberParameters = new object[]
			{
				typeof(Array),
				typeof(int)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JContainer), Member = "System.Collections.IList.Add", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JContainer), Member = "MergeEnumerableContent", MemberParameters = new object[]
			{
				typeof(JContainer),
				typeof(IEnumerable),
				typeof(JsonMergeSettings)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JObject), Member = "System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,Newtonsoft.Json.Linq.JToken>>.CopyTo", MemberParameters = new object[]
			{
				typeof(KeyValuePair<string, JToken>[]),
				typeof(int)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Linq.JsonPath.ArraySliceFilter.<ExecuteFilter>d__12", Member = "MoveNext", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PathFilter), Member = "GetTokenIndex", MemberParameters = new object[]
			{
				typeof(JToken),
				typeof(bool),
				typeof(int)
			}, ReturnType = typeof(JToken))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(EnumerableVectorConverter<>), Member = "ReadJson", MemberParameters = new object[]
			{
				typeof(JsonReader),
				typeof(Type),
				typeof(object),
				typeof(JsonSerializer)
			}, ReturnType = typeof(object))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HashSetConverter), Member = "ReadJson", MemberParameters = new object[]
			{
				typeof(JsonReader),
				typeof(Type),
				typeof(object),
				typeof(JsonSerializer)
			}, ReturnType = typeof(object))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 17)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700015D RID: 349
		// (get) Token: 0x060006EE RID: 1774 RVA: 0x000034CD File Offset: 0x000016CD
		[global::Cpp2ILInjected.Token(Token = "0x17000169")]
		private bool System.Collections.ICollection.IsSynchronized
		{
			[global::Cpp2ILInjected.Token(Token = "0x600078A")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D0A54C", Offset = "0x1D0A54C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700015E RID: 350
		// (get) Token: 0x060006EF RID: 1775 RVA: 0x000034D0 File Offset: 0x000016D0
		[global::Cpp2ILInjected.Token(Token = "0x1700016A")]
		private object System.Collections.ICollection.SyncRoot
		{
			[global::Cpp2ILInjected.Token(Token = "0x600078B")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D0A554", Offset = "0x1D0A554", Length = "0x74")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Interlocked), Member = "CompareExchange", MemberParameters = new object[]
			{
				typeof(ref object),
				typeof(object),
				typeof(object)
			}, ReturnType = typeof(object))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x060006F0 RID: 1776 RVA: 0x000034D3 File Offset: 0x000016D3
		[global::Cpp2ILInjected.Token(Token = "0x600078C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D0A5C8", Offset = "0x1D0A5C8", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private void System.ComponentModel.IBindingList.AddIndex(PropertyDescriptor property)
		{
			throw null;
		}

		// Token: 0x060006F1 RID: 1777 RVA: 0x000034D6 File Offset: 0x000016D6
		[global::Cpp2ILInjected.Token(Token = "0x600078D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D0A5CC", Offset = "0x1D0A5CC", Length = "0x1B8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ComponentModel.AddingNewEventArgs), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(RuntimeTypeHandle) }, ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringUtils), Member = "FormatWith", MemberParameters = new object[]
		{
			typeof(string),
			typeof(IFormatProvider),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 16)]
		private object System.ComponentModel.IBindingList.AddNew()
		{
			throw null;
		}

		// Token: 0x1700015F RID: 351
		// (get) Token: 0x060006F2 RID: 1778 RVA: 0x000034D9 File Offset: 0x000016D9
		[global::Cpp2ILInjected.Token(Token = "0x1700016B")]
		private bool System.ComponentModel.IBindingList.AllowEdit
		{
			[global::Cpp2ILInjected.Token(Token = "0x600078E")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D0A784", Offset = "0x1D0A784", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000160 RID: 352
		// (get) Token: 0x060006F3 RID: 1779 RVA: 0x000034DC File Offset: 0x000016DC
		[global::Cpp2ILInjected.Token(Token = "0x1700016C")]
		private bool System.ComponentModel.IBindingList.AllowNew
		{
			[global::Cpp2ILInjected.Token(Token = "0x600078F")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D0A78C", Offset = "0x1D0A78C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000161 RID: 353
		// (get) Token: 0x060006F4 RID: 1780 RVA: 0x000034DF File Offset: 0x000016DF
		[global::Cpp2ILInjected.Token(Token = "0x1700016D")]
		private bool System.ComponentModel.IBindingList.AllowRemove
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000790")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D0A794", Offset = "0x1D0A794", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x060006F5 RID: 1781 RVA: 0x000034E2 File Offset: 0x000016E2
		[global::Cpp2ILInjected.Token(Token = "0x6000791")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D0A79C", Offset = "0x1D0A79C", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		private void System.ComponentModel.IBindingList.ApplySort(PropertyDescriptor property, ListSortDirection direction)
		{
			throw null;
		}

		// Token: 0x060006F6 RID: 1782 RVA: 0x000034E5 File Offset: 0x000016E5
		[global::Cpp2ILInjected.Token(Token = "0x6000792")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D0A7D4", Offset = "0x1D0A7D4", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		private int System.ComponentModel.IBindingList.Find(PropertyDescriptor property, object key)
		{
			throw null;
		}

		// Token: 0x17000162 RID: 354
		// (get) Token: 0x060006F7 RID: 1783 RVA: 0x000034E8 File Offset: 0x000016E8
		[global::Cpp2ILInjected.Token(Token = "0x1700016E")]
		private bool System.ComponentModel.IBindingList.IsSorted
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000793")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D0A80C", Offset = "0x1D0A80C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x060006F8 RID: 1784 RVA: 0x000034EB File Offset: 0x000016EB
		[global::Cpp2ILInjected.Token(Token = "0x6000794")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D0A814", Offset = "0x1D0A814", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private void System.ComponentModel.IBindingList.RemoveIndex(PropertyDescriptor property)
		{
			throw null;
		}

		// Token: 0x060006F9 RID: 1785 RVA: 0x000034EE File Offset: 0x000016EE
		[global::Cpp2ILInjected.Token(Token = "0x6000795")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D0A818", Offset = "0x1D0A818", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		private void System.ComponentModel.IBindingList.RemoveSort()
		{
			throw null;
		}

		// Token: 0x17000163 RID: 355
		// (get) Token: 0x060006FA RID: 1786 RVA: 0x000034F1 File Offset: 0x000016F1
		[global::Cpp2ILInjected.Token(Token = "0x1700016F")]
		private ListSortDirection System.ComponentModel.IBindingList.SortDirection
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000796")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D0A850", Offset = "0x1D0A850", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000164 RID: 356
		// (get) Token: 0x060006FB RID: 1787 RVA: 0x000034F4 File Offset: 0x000016F4
		[global::Cpp2ILInjected.Token(Token = "0x17000170")]
		private PropertyDescriptor System.ComponentModel.IBindingList.SortProperty
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000797")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D0A858", Offset = "0x1D0A858", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000165 RID: 357
		// (get) Token: 0x060006FC RID: 1788 RVA: 0x000034F7 File Offset: 0x000016F7
		[global::Cpp2ILInjected.Token(Token = "0x17000171")]
		private bool System.ComponentModel.IBindingList.SupportsChangeNotification
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000798")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D0A860", Offset = "0x1D0A860", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000166 RID: 358
		// (get) Token: 0x060006FD RID: 1789 RVA: 0x000034FA File Offset: 0x000016FA
		[global::Cpp2ILInjected.Token(Token = "0x17000172")]
		private bool System.ComponentModel.IBindingList.SupportsSearching
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000799")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D0A868", Offset = "0x1D0A868", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000167 RID: 359
		// (get) Token: 0x060006FE RID: 1790 RVA: 0x000034FD File Offset: 0x000016FD
		[global::Cpp2ILInjected.Token(Token = "0x17000173")]
		private bool System.ComponentModel.IBindingList.SupportsSorting
		{
			[global::Cpp2ILInjected.Token(Token = "0x600079A")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D0A870", Offset = "0x1D0A870", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x060006FF RID: 1791 RVA: 0x00003500 File Offset: 0x00001700
		[global::Cpp2ILInjected.Token(Token = "0x600079B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D04E2C", Offset = "0x1D04E2C", Length = "0xD50")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JArray), Member = "MergeItem", MemberParameters = new object[]
		{
			typeof(object),
			typeof(JsonMergeSettings)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JToken), Member = "get_EqualityComparer", ReturnType = typeof(JTokenEqualityComparer))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HashSet<object>), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(IEnumerable<object>),
			typeof(IEqualityComparer<object>)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HashSet<object>), Member = "Add", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JContainer), Member = "get_Count", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JContainer), Member = "CreateFromContent", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(JToken))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 67)]
		internal static void MergeEnumerableContent(JContainer target, IEnumerable content, JsonMergeSettings settings)
		{
			throw null;
		}

		// Token: 0x0400028C RID: 652
		[global::Cpp2ILInjected.Token(Token = "0x400031B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		internal ListChangedEventHandler _listChanged;

		// Token: 0x0400028D RID: 653
		[global::Cpp2ILInjected.Token(Token = "0x400031C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		internal global::System.ComponentModel.AddingNewEventHandler _addingNew;

		// Token: 0x0400028E RID: 654
		[global::Cpp2ILInjected.Token(Token = "0x400031D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		private object _syncRoot;

		// Token: 0x0400028F RID: 655
		[global::Cpp2ILInjected.Token(Token = "0x400031E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
		private bool _busy;

		// Token: 0x02000124 RID: 292
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x20000CD")]
		private sealed class <GetDescendants>d__29 : IEnumerable<JToken>, IEnumerable, IEnumerator<JToken>, IDisposable, IEnumerator
		{
			// Token: 0x06000B1B RID: 2843 RVA: 0x000040CD File Offset: 0x000022CD
			[DebuggerHidden]
			[global::Cpp2ILInjected.Token(Token = "0x600079C")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D07D84", Offset = "0x1D07D84", Length = "0x3C")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JContainer.<GetDescendants>d__29), Member = "System.Collections.Generic.IEnumerable<Newtonsoft.Json.Linq.JToken>.GetEnumerator", ReturnType = typeof(IEnumerator<JToken>))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JContainer), Member = "GetDescendants", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(IEnumerable<JToken>))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Thread), Member = "get_CurrentThread", ReturnType = typeof(Thread))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Thread), Member = "get_ManagedThreadId", ReturnType = typeof(int))]
			public <GetDescendants>d__29(int <>1__state)
			{
				throw null;
			}

			// Token: 0x06000B1C RID: 2844 RVA: 0x000040D0 File Offset: 0x000022D0
			[DebuggerHidden]
			[global::Cpp2ILInjected.Token(Token = "0x600079D")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D0A934", Offset = "0x1D0A934", Length = "0xBC")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JContainer.<GetDescendants>d__29), Member = "MoveNext", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JContainer.<GetDescendants>d__29), Member = "<>m__Finally2", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JContainer.<GetDescendants>d__29), Member = "<>m__Finally1", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
			private void System.IDisposable.Dispose()
			{
				throw null;
			}

			// Token: 0x06000B1D RID: 2845 RVA: 0x000040D3 File Offset: 0x000022D3
			[global::Cpp2ILInjected.Token(Token = "0x600079E")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D0A9F0", Offset = "0x1D0A9F0", Length = "0x470")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JContainer), Member = "GetDescendants", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(IEnumerable<JToken>))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JContainer.<GetDescendants>d__29), Member = "<>m__Finally2", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JContainer.<GetDescendants>d__29), Member = "<>m__Finally1", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JContainer.<GetDescendants>d__29), Member = "System.IDisposable.Dispose", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 18)]
			private bool MoveNext()
			{
				throw null;
			}

			// Token: 0x06000B1E RID: 2846 RVA: 0x000040D6 File Offset: 0x000022D6
			[global::Cpp2ILInjected.Token(Token = "0x600079F")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D0AF10", Offset = "0x1D0AF10", Length = "0xB0")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JContainer.<GetDescendants>d__29), Member = "System.IDisposable.Dispose", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JContainer.<GetDescendants>d__29), Member = "MoveNext", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			private void <>m__Finally1()
			{
				throw null;
			}

			// Token: 0x06000B1F RID: 2847 RVA: 0x000040D9 File Offset: 0x000022D9
			[global::Cpp2ILInjected.Token(Token = "0x60007A0")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D0AE60", Offset = "0x1D0AE60", Length = "0xB0")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JContainer.<GetDescendants>d__29), Member = "System.IDisposable.Dispose", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JContainer.<GetDescendants>d__29), Member = "MoveNext", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			private void <>m__Finally2()
			{
				throw null;
			}

			// Token: 0x1700021E RID: 542
			// (get) Token: 0x06000B20 RID: 2848 RVA: 0x000040DC File Offset: 0x000022DC
			[global::Cpp2ILInjected.Token(Token = "0x17000174")]
			private JToken System.Collections.Generic.IEnumerator<Newtonsoft.Json.Linq.JToken>.Current
			{
				[DebuggerHidden]
				[global::Cpp2ILInjected.Token(Token = "0x60007A1")]
				[global::Cpp2ILInjected.Address(RVA = "0x1D0AFC0", Offset = "0x1D0AFC0", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				get
				{
					throw null;
				}
			}

			// Token: 0x06000B21 RID: 2849 RVA: 0x000040DF File Offset: 0x000022DF
			[DebuggerHidden]
			[global::Cpp2ILInjected.Token(Token = "0x60007A2")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D0AFC8", Offset = "0x1D0AFC8", Length = "0x38")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			private void System.Collections.IEnumerator.Reset()
			{
				throw null;
			}

			// Token: 0x1700021F RID: 543
			// (get) Token: 0x06000B22 RID: 2850 RVA: 0x000040E2 File Offset: 0x000022E2
			[global::Cpp2ILInjected.Token(Token = "0x17000175")]
			private object System.Collections.IEnumerator.Current
			{
				[DebuggerHidden]
				[global::Cpp2ILInjected.Token(Token = "0x60007A3")]
				[global::Cpp2ILInjected.Address(RVA = "0x1D0B000", Offset = "0x1D0B000", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				get
				{
					throw null;
				}
			}

			// Token: 0x06000B23 RID: 2851 RVA: 0x000040E5 File Offset: 0x000022E5
			[DebuggerHidden]
			[global::Cpp2ILInjected.Token(Token = "0x60007A4")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D0B008", Offset = "0x1D0B008", Length = "0x9C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JContainer.<GetDescendants>d__29), Member = "System.Collections.IEnumerable.GetEnumerator", ReturnType = typeof(IEnumerator))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Thread), Member = "get_CurrentThread", ReturnType = typeof(Thread))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Thread), Member = "get_ManagedThreadId", ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JContainer.<GetDescendants>d__29), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			private IEnumerator<JToken> System.Collections.Generic.IEnumerable<Newtonsoft.Json.Linq.JToken>.GetEnumerator()
			{
				throw null;
			}

			// Token: 0x06000B24 RID: 2852 RVA: 0x000040E8 File Offset: 0x000022E8
			[DebuggerHidden]
			[global::Cpp2ILInjected.Token(Token = "0x60007A5")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D0B0A4", Offset = "0x1D0B0A4", Length = "0x4")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JContainer.<GetDescendants>d__29), Member = "System.Collections.Generic.IEnumerable<Newtonsoft.Json.Linq.JToken>.GetEnumerator", ReturnType = typeof(IEnumerator<JToken>))]
			private IEnumerator System.Collections.IEnumerable.GetEnumerator()
			{
				throw null;
			}

			// Token: 0x040003EF RID: 1007
			[global::Cpp2ILInjected.Token(Token = "0x400031F")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			// Token: 0x040003F0 RID: 1008
			[global::Cpp2ILInjected.Token(Token = "0x4000320")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
			private JToken <>2__current;

			// Token: 0x040003F1 RID: 1009
			[global::Cpp2ILInjected.Token(Token = "0x4000321")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
			private int <>l__initialThreadId;

			// Token: 0x040003F2 RID: 1010
			[global::Cpp2ILInjected.Token(Token = "0x4000322")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x24")]
			private bool self;

			// Token: 0x040003F3 RID: 1011
			[global::Cpp2ILInjected.Token(Token = "0x4000323")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x25")]
			public bool <>3__self;

			// Token: 0x040003F4 RID: 1012
			[global::Cpp2ILInjected.Token(Token = "0x4000324")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
			public JContainer <>4__this;

			// Token: 0x040003F5 RID: 1013
			[global::Cpp2ILInjected.Token(Token = "0x4000325")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
			private JToken <o>5__1;

			// Token: 0x040003F6 RID: 1014
			[global::Cpp2ILInjected.Token(Token = "0x4000326")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
			private IEnumerator<JToken> <>7__wrap1;

			// Token: 0x040003F7 RID: 1015
			[global::Cpp2ILInjected.Token(Token = "0x4000327")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
			private IEnumerator<JToken> <>7__wrap2;
		}
	}
}
