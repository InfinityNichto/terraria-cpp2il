using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Serialization;
using Newtonsoft.Json.Shims;
using Newtonsoft.Json.Utilities;
using UnityEngine;

namespace Newtonsoft.Json.Linq
{
	// Token: 0x0200009B RID: 155
	[Preserve]
	[global::Cpp2ILInjected.Token(Token = "0x20000CF")]
	public class JObject : JContainer, IDictionary<string, JToken>, ICollection<KeyValuePair<string, JToken>>, IEnumerable<KeyValuePair<string, JToken>>, IEnumerable, INotifyPropertyChanged, ICustomTypeDescriptor, global::System.ComponentModel.INotifyPropertyChanging
	{
		// Token: 0x17000169 RID: 361
		// (get) Token: 0x06000708 RID: 1800 RVA: 0x0000351B File Offset: 0x0000171B
		[global::Cpp2ILInjected.Token(Token = "0x17000177")]
		protected override IList<JToken> ChildrenTokens
		{
			[global::Cpp2ILInjected.Token(Token = "0x60007AE")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D0B0A8", Offset = "0x1D0B0A8", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x14000007 RID: 7
		// (add) Token: 0x06000709 RID: 1801 RVA: 0x0000351E File Offset: 0x0000171E
		// (remove) Token: 0x0600070A RID: 1802 RVA: 0x00003521 File Offset: 0x00001721
		[global::Cpp2ILInjected.Token(Token = "0x14000007")]
		public event PropertyChangedEventHandler PropertyChanged
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60007AF")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D0B0B0", Offset = "0x1D0B0B0", Length = "0x9C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new object[]
			{
				typeof(Delegate),
				typeof(Delegate)
			}, ReturnType = typeof(Delegate))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			add
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60007B0")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D0B14C", Offset = "0x1D0B14C", Length = "0x9C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new object[]
			{
				typeof(Delegate),
				typeof(Delegate)
			}, ReturnType = typeof(Delegate))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			remove
			{
				throw null;
			}
		}

		// Token: 0x14000008 RID: 8
		// (add) Token: 0x0600070B RID: 1803 RVA: 0x00003524 File Offset: 0x00001724
		// (remove) Token: 0x0600070C RID: 1804 RVA: 0x00003527 File Offset: 0x00001727
		[global::Cpp2ILInjected.Token(Token = "0x14000008")]
		public event global::System.ComponentModel.PropertyChangingEventHandler PropertyChanging
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60007B1")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D0B1E8", Offset = "0x1D0B1E8", Length = "0x9C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new object[]
			{
				typeof(Delegate),
				typeof(Delegate)
			}, ReturnType = typeof(Delegate))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			add
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60007B2")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D0B284", Offset = "0x1D0B284", Length = "0x9C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new object[]
			{
				typeof(Delegate),
				typeof(Delegate)
			}, ReturnType = typeof(Delegate))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			remove
			{
				throw null;
			}
		}

		// Token: 0x0600070D RID: 1805 RVA: 0x0000352A File Offset: 0x0000172A
		[global::Cpp2ILInjected.Token(Token = "0x60007B3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D09FEC", Offset = "0x1D09FEC", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.WorldBuilding.WorldGenConfiguration", Member = ".ctor", MemberParameters = new object[] { typeof(JObject) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.WorldBuilding.WorldGenConfiguration", Member = "GetPassConfiguration", MemberParameters = new object[] { typeof(string) }, ReturnType = "Terraria.IO.GameConfiguration")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JContainer), Member = "ReadContentFrom", MemberParameters = new object[]
		{
			typeof(JsonReader),
			typeof(JsonLoadSettings)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JObject), Member = "Load", MemberParameters = new object[]
		{
			typeof(JsonReader),
			typeof(JsonLoadSettings)
		}, ReturnType = typeof(JObject))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JTokenWriter), Member = "WriteStartObject", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JPropertyKeyedCollection), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JContainer), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public JObject()
		{
			throw null;
		}

		// Token: 0x0600070E RID: 1806 RVA: 0x0000352D File Offset: 0x0000172D
		[global::Cpp2ILInjected.Token(Token = "0x60007B4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D0B320", Offset = "0x1D0B320", Length = "0x68")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JObject), Member = "CloneToken", ReturnType = typeof(JToken))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JPropertyKeyedCollection), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JContainer), Member = ".ctor", MemberParameters = new object[] { typeof(JContainer) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public JObject(JObject other)
		{
			throw null;
		}

		// Token: 0x0600070F RID: 1807 RVA: 0x00003530 File Offset: 0x00001730
		[global::Cpp2ILInjected.Token(Token = "0x60007B5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D0B388", Offset = "0x1D0B388", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallAnalysisNotSupported]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public JObject(params object[] content)
		{
			throw null;
		}

		// Token: 0x06000710 RID: 1808 RVA: 0x00003533 File Offset: 0x00001733
		[global::Cpp2ILInjected.Token(Token = "0x60007B6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D0B38C", Offset = "0x1D0B38C", Length = "0x7C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JPropertyKeyedCollection), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JContainer), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public JObject(object content)
		{
			throw null;
		}

		// Token: 0x06000711 RID: 1809 RVA: 0x00003536 File Offset: 0x00001736
		[global::Cpp2ILInjected.Token(Token = "0x60007B7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D0B408", Offset = "0x1D0B408", Length = "0x8C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JPropertyKeyedCollection), Member = "Compare", MemberParameters = new object[] { typeof(JPropertyKeyedCollection) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		internal override bool DeepEquals(JToken node)
		{
			throw null;
		}

		// Token: 0x06000712 RID: 1810 RVA: 0x00003539 File Offset: 0x00001739
		[global::Cpp2ILInjected.Token(Token = "0x60007B8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D0B494", Offset = "0x1D0B494", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JPropertyKeyedCollection), Member = "IndexOfReference", MemberParameters = new object[] { typeof(JToken) }, ReturnType = typeof(int))]
		internal override int IndexOfItem(JToken item)
		{
			throw null;
		}

		// Token: 0x06000713 RID: 1811 RVA: 0x0000353C File Offset: 0x0000173C
		[global::Cpp2ILInjected.Token(Token = "0x60007B9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D0B49C", Offset = "0x1D0B49C", Length = "0x6C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JContainer), Member = "InsertItem", MemberParameters = new object[]
		{
			typeof(int),
			typeof(JToken),
			typeof(bool)
		}, ReturnType = typeof(void))]
		internal override void InsertItem(int index, JToken item, bool skipParentCheck)
		{
			throw null;
		}

		// Token: 0x06000714 RID: 1812 RVA: 0x0000353F File Offset: 0x0000173F
		[global::Cpp2ILInjected.Token(Token = "0x60007BA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D0B508", Offset = "0x1D0B508", Length = "0x200")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ValidationUtils), Member = "ArgumentNotNull", MemberParameters = new object[]
		{
			typeof(object),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JPropertyKeyedCollection), Member = "TryGetValue", MemberParameters = new object[]
		{
			typeof(string),
			typeof(ref JToken)
		}, ReturnType = typeof(bool))]
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
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 13)]
		internal override void ValidateToken(JToken o, JToken existing)
		{
			throw null;
		}

		// Token: 0x06000715 RID: 1813 RVA: 0x00003542 File Offset: 0x00001742
		[global::Cpp2ILInjected.Token(Token = "0x60007BB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D0B708", Offset = "0x1D0B708", Length = "0x410")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JObject), Member = "GetEnumerator", ReturnType = typeof(IEnumerator<KeyValuePair<string, JToken>>))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JObject), Member = "Property", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(JProperty))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JProperty), Member = "get_Value", ReturnType = typeof(JToken))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JProperty), Member = "set_Value", MemberParameters = new object[] { typeof(JToken) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JObject), Member = "Add", MemberParameters = new object[]
		{
			typeof(string),
			typeof(JToken)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 17)]
		internal override void MergeItem(object content, JsonMergeSettings settings)
		{
			throw null;
		}

		// Token: 0x06000716 RID: 1814 RVA: 0x00003545 File Offset: 0x00001745
		[global::Cpp2ILInjected.Token(Token = "0x60007BC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D0BBF8", Offset = "0x1D0BBF8", Length = "0xC0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JProperty), Member = "SetItem", MemberParameters = new object[]
		{
			typeof(int),
			typeof(JToken)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ListChangedEventArgs), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(ListChangedType),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		internal void InternalPropertyChanged(JProperty childProperty)
		{
			throw null;
		}

		// Token: 0x06000717 RID: 1815 RVA: 0x00003548 File Offset: 0x00001748
		[global::Cpp2ILInjected.Token(Token = "0x60007BD")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D0BCB8", Offset = "0x1D0BCB8", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JProperty), Member = "SetItem", MemberParameters = new object[]
		{
			typeof(int),
			typeof(JToken)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		internal void InternalPropertyChanging(JProperty childProperty)
		{
			throw null;
		}

		// Token: 0x06000718 RID: 1816 RVA: 0x0000354B File Offset: 0x0000174B
		[global::Cpp2ILInjected.Token(Token = "0x60007BE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D0BCCC", Offset = "0x1D0BCCC", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JObject), Member = ".ctor", MemberParameters = new object[] { typeof(JObject) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal override JToken CloneToken()
		{
			throw null;
		}

		// Token: 0x1700016A RID: 362
		// (get) Token: 0x06000719 RID: 1817 RVA: 0x0000354E File Offset: 0x0000174E
		[global::Cpp2ILInjected.Token(Token = "0x17000178")]
		public override JTokenType Type
		{
			[global::Cpp2ILInjected.Token(Token = "0x60007BF")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D0BD24", Offset = "0x1D0BD24", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600071A RID: 1818 RVA: 0x00003551 File Offset: 0x00001751
		[global::Cpp2ILInjected.Token(Token = "0x60007C0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D04CDC", Offset = "0x1D04CDC", Length = "0x48")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JObject), Member = "PropertyValues", ReturnType = typeof(JEnumerable<JToken>))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(QuaternionConverter), Member = "ReadJson", MemberParameters = new object[]
		{
			typeof(JsonReader),
			typeof(Type),
			typeof(object),
			typeof(JsonSerializer)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Enumerable[]), Member = "Cast", MemberTypeParameters = new object[] { typeof(object) }, MemberParameters = new object[] { typeof(IEnumerable) }, ReturnType = "System.Collections.Generic.IEnumerable`1<TResult>")]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public IEnumerable<JProperty> Properties()
		{
			throw null;
		}

		// Token: 0x0600071B RID: 1819 RVA: 0x00003554 File Offset: 0x00001754
		[global::Cpp2ILInjected.Token(Token = "0x60007C1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D0A044", Offset = "0x1D0A044", Length = "0xA0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JContainer), Member = "ReadContentFrom", MemberParameters = new object[]
		{
			typeof(JsonReader),
			typeof(JsonLoadSettings)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JObject), Member = "MergeItem", MemberParameters = new object[]
		{
			typeof(object),
			typeof(JsonMergeSettings)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JObject), Member = "get_Item", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(JToken))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JObject), Member = "set_Item", MemberParameters = new object[]
		{
			typeof(string),
			typeof(JToken)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JObject), Member = "GetValue", MemberParameters = new object[]
		{
			typeof(string),
			typeof(StringComparison)
		}, ReturnType = typeof(JToken))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JObject), Member = "Remove", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JObject), Member = "TryGetValue", MemberParameters = new object[]
		{
			typeof(string),
			typeof(ref JToken)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JObject), Member = "System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,Newtonsoft.Json.Linq.JToken>>.Contains", MemberParameters = new object[] { typeof(KeyValuePair<string, JToken>) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 8)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JPropertyKeyedCollection), Member = "TryGetValue", MemberParameters = new object[]
		{
			typeof(string),
			typeof(ref JToken)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public JProperty Property(string name)
		{
			throw null;
		}

		// Token: 0x0600071C RID: 1820 RVA: 0x00003557 File Offset: 0x00001757
		[global::Cpp2ILInjected.Token(Token = "0x60007C2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D0BD2C", Offset = "0x1D0BD2C", Length = "0x144")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JObject), Member = "Properties", ReturnType = typeof(IEnumerable<JProperty>))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Func<object, object>), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Enumerable[]), Member = "Select", MemberTypeParameters = new object[]
		{
			typeof(object),
			typeof(object)
		}, MemberParameters = new object[]
		{
			typeof(IEnumerable<object>),
			typeof(Func<object, object>)
		}, ReturnType = "System.Collections.Generic.IEnumerable`1<TResult>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JEnumerable<>), Member = ".ctor", MemberParameters = new object[] { "System.Collections.Generic.IEnumerable`1<T>" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		public JEnumerable<JToken> PropertyValues()
		{
			throw null;
		}

		// Token: 0x1700016B RID: 363
		[global::Cpp2ILInjected.Token(Token = "0x17000179")]
		public override JToken this[object key]
		{
			[global::Cpp2ILInjected.Token(Token = "0x60007C3")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D0BE70", Offset = "0x1D0BE70", Length = "0x110")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ValidationUtils), Member = "ArgumentNotNull", MemberParameters = new object[]
			{
				typeof(object),
				typeof(string)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JObject), Member = "get_Item", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(JToken))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MiscellaneousUtils), Member = "ToString", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringUtils), Member = "FormatWith", MemberParameters = new object[]
			{
				typeof(string),
				typeof(IFormatProvider),
				typeof(object)
			}, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x60007C4")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D0BF80", Offset = "0x1D0BF80", Length = "0x118")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ValidationUtils), Member = "ArgumentNotNull", MemberParameters = new object[]
			{
				typeof(object),
				typeof(string)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JObject), Member = "set_Item", MemberParameters = new object[]
			{
				typeof(string),
				typeof(JToken)
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
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
			set
			{
				throw null;
			}
		}

		// Token: 0x1700016C RID: 364
		[global::Cpp2ILInjected.Token(Token = "0x1700017A")]
		public JToken this[string propertyName]
		{
			[global::Cpp2ILInjected.Token(Token = "0x60007C5")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D03080", Offset = "0x1D03080", Length = "0x80")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.WorldBuilding.WorldGenConfiguration", Member = ".ctor", MemberParameters = new object[] { typeof(JObject) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.IO.GameConfiguration", Member = "Get", MemberTypeParameters = new object[] { "T" }, MemberParameters = new object[] { typeof(string) }, ReturnType = "T")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.IO.ResourcePack", Member = "LoadManifest", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Achievements.AchievementCondition", Member = "Load", MemberParameters = new object[] { typeof(JObject) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.GameContent.Achievements.CustomFloatCondition", Member = "Load", MemberParameters = new object[] { typeof(JObject) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.GameContent.Achievements.CustomIntCondition", Member = "Load", MemberParameters = new object[] { typeof(JObject) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonSerializerInternalReader), Member = "ReadMetadataPropertiesToken", MemberParameters = new object[]
			{
				typeof(JTokenReader),
				typeof(ref Type),
				typeof(ref JsonContract),
				typeof(JsonProperty),
				typeof(JsonContainerContract),
				typeof(JsonProperty),
				typeof(object),
				typeof(ref object),
				typeof(ref string)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JObject), Member = "get_Item", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(JToken))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Linq.JsonPath.FieldFilter.<ExecuteFilter>d__4", Member = "MoveNext", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Linq.JsonPath.FieldMultipleFilter.<ExecuteFilter>d__4", Member = "MoveNext", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ColorConverter), Member = "ReadJson", MemberParameters = new object[]
			{
				typeof(JsonReader),
				typeof(Type),
				typeof(object),
				typeof(JsonSerializer)
			}, ReturnType = typeof(object))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Matrix4x4Converter), Member = "ReadJson", MemberParameters = new object[]
			{
				typeof(JsonReader),
				typeof(Type),
				typeof(object),
				typeof(JsonSerializer)
			}, ReturnType = typeof(object))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(QuaternionConverter), Member = "ReadJson", MemberParameters = new object[]
			{
				typeof(JsonReader),
				typeof(Type),
				typeof(object),
				typeof(JsonSerializer)
			}, ReturnType = typeof(object))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ResolutionConverter), Member = "ReadJson", MemberParameters = new object[]
			{
				typeof(JsonReader),
				typeof(Type),
				typeof(object),
				typeof(JsonSerializer)
			}, ReturnType = typeof(object))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(VectorConverter), Member = "PopulateVector2", MemberParameters = new object[] { typeof(JsonReader) }, ReturnType = typeof(Vector2))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(VectorConverter), Member = "PopulateVector3", MemberParameters = new object[] { typeof(JsonReader) }, ReturnType = typeof(Vector3))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(VectorConverter), Member = "PopulateVector4", MemberParameters = new object[] { typeof(JsonReader) }, ReturnType = typeof(Vector4))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 54)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ValidationUtils), Member = "ArgumentNotNull", MemberParameters = new object[]
			{
				typeof(object),
				typeof(string)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JObject), Member = "Property", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(JProperty))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JProperty), Member = "get_Value", ReturnType = typeof(JToken))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x60007C6")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D031E0", Offset = "0x1D031E0", Length = "0xD8")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JObject), Member = "set_Item", MemberParameters = new object[]
			{
				typeof(object),
				typeof(JToken)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JObject), Member = "Property", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(JProperty))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JProperty), Member = "set_Value", MemberParameters = new object[] { typeof(JToken) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JProperty), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(string),
				typeof(object)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			set
			{
				throw null;
			}
		}

		// Token: 0x06000721 RID: 1825 RVA: 0x00003566 File Offset: 0x00001766
		[global::Cpp2ILInjected.Token(Token = "0x60007C7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D0C098", Offset = "0x1D0C098", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ColorConverter), Member = "ReadJson", MemberParameters = new object[]
		{
			typeof(JsonReader),
			typeof(Type),
			typeof(object),
			typeof(JsonSerializer)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(EnumerableVectorConverter<>), Member = "ReadJson", MemberParameters = new object[]
		{
			typeof(JsonReader),
			typeof(Type),
			typeof(object),
			typeof(JsonSerializer)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Matrix4x4Converter), Member = "ReadJson", MemberParameters = new object[]
		{
			typeof(JsonReader),
			typeof(Type),
			typeof(object),
			typeof(JsonSerializer)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(QuaternionConverter), Member = "ReadJson", MemberParameters = new object[]
		{
			typeof(JsonReader),
			typeof(Type),
			typeof(object),
			typeof(JsonSerializer)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ResolutionConverter), Member = "ReadJson", MemberParameters = new object[]
		{
			typeof(JsonReader),
			typeof(Type),
			typeof(object),
			typeof(JsonSerializer)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(VectorConverter), Member = "PopulateVector2", MemberParameters = new object[] { typeof(JsonReader) }, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(VectorConverter), Member = "PopulateVector3", MemberParameters = new object[] { typeof(JsonReader) }, ReturnType = typeof(Vector3))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(VectorConverter), Member = "PopulateVector4", MemberParameters = new object[] { typeof(JsonReader) }, ReturnType = typeof(Vector4))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 8)]
		public new static JObject Load(JsonReader reader)
		{
			throw null;
		}

		// Token: 0x06000722 RID: 1826 RVA: 0x00003569 File Offset: 0x00001769
		[global::Cpp2ILInjected.Token(Token = "0x60007C8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D0C0A0", Offset = "0x1D0C0A0", Length = "0x1B0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JObject), Member = "Parse", MemberParameters = new object[]
		{
			typeof(string),
			typeof(JsonLoadSettings)
		}, ReturnType = typeof(JObject))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JToken), Member = "ReadFrom", MemberParameters = new object[]
		{
			typeof(JsonReader),
			typeof(JsonLoadSettings)
		}, ReturnType = typeof(JToken))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ValidationUtils), Member = "ArgumentNotNull", MemberParameters = new object[]
		{
			typeof(object),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonReader), Member = "MoveToContent", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JObject), Member = ".ctor", ReturnType = typeof(void))]
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
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 13)]
		public new static JObject Load(JsonReader reader, JsonLoadSettings settings)
		{
			throw null;
		}

		// Token: 0x06000723 RID: 1827 RVA: 0x0000356C File Offset: 0x0000176C
		[global::Cpp2ILInjected.Token(Token = "0x60007C9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D0C250", Offset = "0x1D0C250", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.IO.ResourcePack", Member = "LoadManifest", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		public new static JObject Parse(string json)
		{
			throw null;
		}

		// Token: 0x06000724 RID: 1828 RVA: 0x0000356F File Offset: 0x0000176F
		[global::Cpp2ILInjected.Token(Token = "0x60007CA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D0C258", Offset = "0x1D0C258", Length = "0x23C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringReader), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonTextReader), Member = ".ctor", MemberParameters = new object[] { typeof(TextReader) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JObject), Member = "Load", MemberParameters = new object[]
		{
			typeof(JsonReader),
			typeof(JsonLoadSettings)
		}, ReturnType = typeof(JObject))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonReaderException), Member = "Create", MemberParameters = new object[]
		{
			typeof(JsonReader),
			typeof(string)
		}, ReturnType = typeof(JsonReaderException))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 16)]
		public new static JObject Parse(string json, JsonLoadSettings settings)
		{
			throw null;
		}

		// Token: 0x06000725 RID: 1829 RVA: 0x00003572 File Offset: 0x00001772
		[global::Cpp2ILInjected.Token(Token = "0x60007CB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D0C494", Offset = "0x1D0C494", Length = "0x20")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonSerializer), Member = "CreateDefault", ReturnType = typeof(JsonSerializer))]
		public new static JObject FromObject(object o)
		{
			throw null;
		}

		// Token: 0x06000726 RID: 1830 RVA: 0x00003575 File Offset: 0x00001775
		[global::Cpp2ILInjected.Token(Token = "0x60007CC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D0C4B4", Offset = "0x1D0C4B4", Length = "0x17C")]
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
		public new static JObject FromObject(object o, JsonSerializer jsonSerializer)
		{
			throw null;
		}

		// Token: 0x06000727 RID: 1831 RVA: 0x00003578 File Offset: 0x00001778
		[global::Cpp2ILInjected.Token(Token = "0x60007CD")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D0C834", Offset = "0x1D0C834", Length = "0xE0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Collection<>), Member = "get_Count", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Collection<>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public override void WriteTo(JsonWriter writer, params JsonConverter[] converters)
		{
			throw null;
		}

		// Token: 0x06000728 RID: 1832 RVA: 0x0000357B File Offset: 0x0000177B
		[global::Cpp2ILInjected.Token(Token = "0x60007CE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D0C914", Offset = "0x1D0C914", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public JToken GetValue(string propertyName)
		{
			throw null;
		}

		// Token: 0x06000729 RID: 1833 RVA: 0x0000357E File Offset: 0x0000177E
		[global::Cpp2ILInjected.Token(Token = "0x60007CF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D0C91C", Offset = "0x1D0C91C", Length = "0x364")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JObject), Member = "TryGetValue", MemberParameters = new object[]
		{
			typeof(string),
			typeof(StringComparison),
			typeof(ref JToken)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JObject), Member = "Property", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(JProperty))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JProperty), Member = "get_Value", ReturnType = typeof(JToken))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Collection<>), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.IEnumerator`1<T>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Equals", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(StringComparison)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 16)]
		public JToken GetValue(string propertyName, StringComparison comparison)
		{
			throw null;
		}

		// Token: 0x0600072A RID: 1834 RVA: 0x00003581 File Offset: 0x00001781
		[global::Cpp2ILInjected.Token(Token = "0x60007D0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D0CC80", Offset = "0x1D0CC80", Length = "0x24")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JObject), Member = "GetValue", MemberParameters = new object[]
		{
			typeof(string),
			typeof(StringComparison)
		}, ReturnType = typeof(JToken))]
		public bool TryGetValue(string propertyName, StringComparison comparison, out JToken value)
		{
			throw null;
		}

		// Token: 0x0600072B RID: 1835 RVA: 0x00003584 File Offset: 0x00001784
		[global::Cpp2ILInjected.Token(Token = "0x60007D1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D0BB78", Offset = "0x1D0BB78", Length = "0x80")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JObject), Member = "MergeItem", MemberParameters = new object[]
		{
			typeof(object),
			typeof(JsonMergeSettings)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JProperty), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public void Add(string propertyName, JToken value)
		{
			throw null;
		}

		// Token: 0x0600072C RID: 1836 RVA: 0x00003587 File Offset: 0x00001787
		[global::Cpp2ILInjected.Token(Token = "0x60007D2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D0CCA4", Offset = "0x1D0CCA4", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JPropertyKeyedCollection), Member = "Contains", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		private bool Method_Private_Virtual_Final_New_Boolean_String_0(string key)
		{
			throw null;
		}

		// Token: 0x1700016D RID: 365
		// (get) Token: 0x0600072D RID: 1837 RVA: 0x0000358A File Offset: 0x0000178A
		[global::Cpp2ILInjected.Token(Token = "0x1700017B")]
		private ICollection<string> prop_ICollection_1_String_0
		{
			[global::Cpp2ILInjected.Token(Token = "0x60007D3")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D0CCAC", Offset = "0x1D0CCAC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JPropertyKeyedCollection), Member = "get_Keys", ReturnType = typeof(ICollection<string>))]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600072E RID: 1838 RVA: 0x0000358D File Offset: 0x0000178D
		[global::Cpp2ILInjected.Token(Token = "0x60007D4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D0CCB4", Offset = "0x1D0CCB4", Length = "0x1C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JTokenWriter), Member = "WritePropertyName", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JObject), Member = "Property", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(JProperty))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JToken), Member = "Remove", ReturnType = typeof(void))]
		public bool Remove(string propertyName)
		{
			throw null;
		}

		// Token: 0x0600072F RID: 1839 RVA: 0x00003590 File Offset: 0x00001790
		[global::Cpp2ILInjected.Token(Token = "0x60007D5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D0CD3C", Offset = "0x1D0CD3C", Length = "0x34")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.WorldBuilding.WorldGenConfiguration", Member = "CreateBiome", MemberTypeParameters = new object[] { "T" }, MemberParameters = new object[] { typeof(string) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.WorldBuilding.WorldGenConfiguration", Member = "GetPassConfiguration", MemberParameters = new object[] { typeof(string) }, ReturnType = "Terraria.IO.GameConfiguration")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JObject), Member = "Property", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(JProperty))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JProperty), Member = "get_Value", ReturnType = typeof(JToken))]
		public bool TryGetValue(string propertyName, out JToken value)
		{
			throw null;
		}

		// Token: 0x1700016E RID: 366
		// (get) Token: 0x06000730 RID: 1840 RVA: 0x00003593 File Offset: 0x00001793
		[global::Cpp2ILInjected.Token(Token = "0x1700017C")]
		private ICollection<JToken> prop_ICollection_1_JToken_0
		{
			[global::Cpp2ILInjected.Token(Token = "0x60007D6")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D0CD70", Offset = "0x1D0CD70", Length = "0x38")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NotImplementedException), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06000731 RID: 1841 RVA: 0x00003596 File Offset: 0x00001796
		[global::Cpp2ILInjected.Token(Token = "0x60007D7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D0CDA8", Offset = "0x1D0CDA8", Length = "0x98")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JProperty), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		private void Method_Private_Virtual_Final_New_Void_KeyValuePair_2_String_JToken_0(KeyValuePair<string, JToken> item)
		{
			throw null;
		}

		// Token: 0x06000732 RID: 1842 RVA: 0x00003599 File Offset: 0x00001799
		[global::Cpp2ILInjected.Token(Token = "0x60007D8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D0CE40", Offset = "0x1D0CE40", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		private void Method_Private_Virtual_Final_New_Void_0()
		{
			throw null;
		}

		// Token: 0x06000733 RID: 1843 RVA: 0x0000359C File Offset: 0x0000179C
		[global::Cpp2ILInjected.Token(Token = "0x60007D9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D0CE50", Offset = "0x1D0CE50", Length = "0x74")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JObject), Member = "Property", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(JProperty))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JProperty), Member = "get_Value", ReturnType = typeof(JToken))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private bool Method_Private_Virtual_Final_New_Boolean_KeyValuePair_2_String_JToken_0(KeyValuePair<string, JToken> item)
		{
			throw null;
		}

		// Token: 0x06000734 RID: 1844 RVA: 0x0000359F File Offset: 0x0000179F
		[global::Cpp2ILInjected.Token(Token = "0x60007DA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D0CEC4", Offset = "0x1D0CEC4", Length = "0x444")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JContainer), Member = "get_Count", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Collection<>), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.IEnumerator`1<T>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JProperty), Member = "get_Value", ReturnType = typeof(JToken))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(KeyValuePair<object, object>), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 31)]
		private void Method_Private_Virtual_Final_New_Void_KeyValuePair_2_String_JToken_Int32_0(KeyValuePair<string, JToken>[] array, int arrayIndex)
		{
			throw null;
		}

		// Token: 0x1700016F RID: 367
		// (get) Token: 0x06000735 RID: 1845 RVA: 0x000035A2 File Offset: 0x000017A2
		[global::Cpp2ILInjected.Token(Token = "0x1700017D")]
		private bool prop_Boolean_0
		{
			[global::Cpp2ILInjected.Token(Token = "0x60007DB")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D0D308", Offset = "0x1D0D308", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06000736 RID: 1846 RVA: 0x000035A5 File Offset: 0x000017A5
		[global::Cpp2ILInjected.Token(Token = "0x60007DC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D0D310", Offset = "0x1D0D310", Length = "0x144")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		private bool Method_Private_Virtual_Final_New_Boolean_KeyValuePair_2_String_JToken_1(KeyValuePair<string, JToken> item)
		{
			throw null;
		}

		// Token: 0x06000737 RID: 1847 RVA: 0x000035A8 File Offset: 0x000017A8
		[global::Cpp2ILInjected.Token(Token = "0x60007DD")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D0D454", Offset = "0x1D0D454", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JContainer), Member = "ContentsHashCode", ReturnType = typeof(int))]
		internal override int GetDeepHashCode()
		{
			throw null;
		}

		// Token: 0x06000738 RID: 1848 RVA: 0x000035AB File Offset: 0x000017AB
		[global::Cpp2ILInjected.Token(Token = "0x60007DE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D0BB18", Offset = "0x1D0BB18", Length = "0x60")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JObject), Member = "MergeItem", MemberParameters = new object[]
		{
			typeof(object),
			typeof(JsonMergeSettings)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JObject), Member = "System.ComponentModel.ICustomTypeDescriptor.GetProperties", MemberParameters = new object[] { typeof(Attribute[]) }, ReturnType = typeof(PropertyDescriptorCollection))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Linq.JsonPath.FieldFilter.<ExecuteFilter>d__4", Member = "MoveNext", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public IEnumerator<KeyValuePair<string, JToken>> GetEnumerator()
		{
			throw null;
		}

		// Token: 0x06000739 RID: 1849 RVA: 0x000035AE File Offset: 0x000017AE
		[global::Cpp2ILInjected.Token(Token = "0x60007DF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D0D480", Offset = "0x1D0D480", Length = "0x90")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PropertyChangedEventArgs), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		protected virtual void OnPropertyChanged(string propertyName)
		{
			throw null;
		}

		// Token: 0x0600073A RID: 1850 RVA: 0x000035B1 File Offset: 0x000017B1
		[global::Cpp2ILInjected.Token(Token = "0x60007E0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D0D510", Offset = "0x1D0D510", Length = "0x90")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ComponentModel.PropertyChangingEventArgs), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		protected virtual void OnPropertyChanging(string propertyName)
		{
			throw null;
		}

		// Token: 0x0600073B RID: 1851 RVA: 0x000035B4 File Offset: 0x000017B4
		[global::Cpp2ILInjected.Token(Token = "0x60007E1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D0D5A0", Offset = "0x1D0D5A0", Length = "0x9C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		private PropertyDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetProperties()
		{
			throw null;
		}

		// Token: 0x0600073C RID: 1852 RVA: 0x000035B7 File Offset: 0x000017B7
		[global::Cpp2ILInjected.Token(Token = "0x60007E2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D0D63C", Offset = "0x1D0D63C", Length = "0x2DC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PropertyDescriptorCollection), Member = ".ctor", MemberParameters = new object[] { typeof(PropertyDescriptor[]) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JObject), Member = "GetEnumerator", ReturnType = typeof(IEnumerator<KeyValuePair<string, JToken>>))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PropertyDescriptor), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(Attribute[])
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PropertyDescriptorCollection), Member = "Add", MemberParameters = new object[] { typeof(PropertyDescriptor) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 18)]
		private PropertyDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetProperties(Attribute[] attributes)
		{
			throw null;
		}

		// Token: 0x0600073D RID: 1853 RVA: 0x000035BA File Offset: 0x000017BA
		[global::Cpp2ILInjected.Token(Token = "0x60007E3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D0D918", Offset = "0x1D0D918", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private AttributeCollection System.ComponentModel.ICustomTypeDescriptor.GetAttributes()
		{
			throw null;
		}

		// Token: 0x0600073E RID: 1854 RVA: 0x000035BD File Offset: 0x000017BD
		[global::Cpp2ILInjected.Token(Token = "0x60007E4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D0D970", Offset = "0x1D0D970", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private string System.ComponentModel.ICustomTypeDescriptor.GetClassName()
		{
			throw null;
		}

		// Token: 0x0600073F RID: 1855 RVA: 0x000035C0 File Offset: 0x000017C0
		[global::Cpp2ILInjected.Token(Token = "0x60007E5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D0D978", Offset = "0x1D0D978", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private string System.ComponentModel.ICustomTypeDescriptor.GetComponentName()
		{
			throw null;
		}

		// Token: 0x06000740 RID: 1856 RVA: 0x000035C3 File Offset: 0x000017C3
		[global::Cpp2ILInjected.Token(Token = "0x60007E6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D0D980", Offset = "0x1D0D980", Length = "0x54")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TypeConverter), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private TypeConverter System.ComponentModel.ICustomTypeDescriptor.GetConverter()
		{
			throw null;
		}

		// Token: 0x06000741 RID: 1857 RVA: 0x000035C6 File Offset: 0x000017C6
		[global::Cpp2ILInjected.Token(Token = "0x60007E7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D0D9D4", Offset = "0x1D0D9D4", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private EventDescriptor System.ComponentModel.ICustomTypeDescriptor.GetDefaultEvent()
		{
			throw null;
		}

		// Token: 0x06000742 RID: 1858 RVA: 0x000035C9 File Offset: 0x000017C9
		[global::Cpp2ILInjected.Token(Token = "0x60007E8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D0D9DC", Offset = "0x1D0D9DC", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private PropertyDescriptor System.ComponentModel.ICustomTypeDescriptor.GetDefaultProperty()
		{
			throw null;
		}

		// Token: 0x06000743 RID: 1859 RVA: 0x000035CC File Offset: 0x000017CC
		[global::Cpp2ILInjected.Token(Token = "0x60007E9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D0D9E4", Offset = "0x1D0D9E4", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private object System.ComponentModel.ICustomTypeDescriptor.GetEditor(Type editorBaseType)
		{
			throw null;
		}

		// Token: 0x06000744 RID: 1860 RVA: 0x000035CF File Offset: 0x000017CF
		[global::Cpp2ILInjected.Token(Token = "0x60007EA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D0D9EC", Offset = "0x1D0D9EC", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private EventDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetEvents(Attribute[] attributes)
		{
			throw null;
		}

		// Token: 0x06000745 RID: 1861 RVA: 0x000035D2 File Offset: 0x000017D2
		[global::Cpp2ILInjected.Token(Token = "0x60007EB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D0DA44", Offset = "0x1D0DA44", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private EventDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetEvents()
		{
			throw null;
		}

		// Token: 0x06000746 RID: 1862 RVA: 0x000035D5 File Offset: 0x000017D5
		[global::Cpp2ILInjected.Token(Token = "0x60007EC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D0DA9C", Offset = "0x1D0DA9C", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private object System.ComponentModel.ICustomTypeDescriptor.GetPropertyOwner(PropertyDescriptor pd)
		{
			throw null;
		}

		// Token: 0x04000292 RID: 658
		[global::Cpp2ILInjected.Token(Token = "0x400032A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
		private readonly JPropertyKeyedCollection _properties;

		// Token: 0x04000293 RID: 659
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x400032B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
		private PropertyChangedEventHandler PropertyChanged;

		// Token: 0x04000294 RID: 660
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x400032C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
		private global::System.ComponentModel.PropertyChangingEventHandler PropertyChanging;

		// Token: 0x02000125 RID: 293
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x20000D0")]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06000B25 RID: 2853 RVA: 0x000040EB File Offset: 0x000022EB
			// Note: this type is marked as 'beforefieldinit'.
			[global::Cpp2ILInjected.Token(Token = "0x60007ED")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D0DAA4", Offset = "0x1D0DAA4", Length = "0x5C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			static <>c()
			{
				throw null;
			}

			// Token: 0x06000B26 RID: 2854 RVA: 0x000040EE File Offset: 0x000022EE
			[global::Cpp2ILInjected.Token(Token = "0x60007EE")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D0DB00", Offset = "0x1D0DB00", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public <>c()
			{
				throw null;
			}

			// Token: 0x06000B27 RID: 2855 RVA: 0x000040F1 File Offset: 0x000022F1
			[global::Cpp2ILInjected.Token(Token = "0x60007EF")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D0DB08", Offset = "0x1D0DB08", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JProperty), Member = "get_Value", ReturnType = typeof(JToken))]
			internal JToken <PropertyValues>b__25_0(JProperty p)
			{
				throw null;
			}

			// Token: 0x040003F8 RID: 1016
			[global::Cpp2ILInjected.Token(Token = "0x400032D")]
			public static readonly JObject.<>c <>9;

			// Token: 0x040003F9 RID: 1017
			[global::Cpp2ILInjected.Token(Token = "0x400032E")]
			public static Func<JProperty, JToken> <>9__25_0;
		}

		// Token: 0x02000126 RID: 294
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x20000D1")]
		private sealed class <GetEnumerator>d__58 : IEnumerator<KeyValuePair<string, JToken>>, IDisposable, IEnumerator
		{
			// Token: 0x06000B28 RID: 2856 RVA: 0x000040F4 File Offset: 0x000022F4
			[DebuggerHidden]
			[global::Cpp2ILInjected.Token(Token = "0x60007F0")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D0D458", Offset = "0x1D0D458", Length = "0x28")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public <GetEnumerator>d__58(int <>1__state)
			{
				throw null;
			}

			// Token: 0x06000B29 RID: 2857 RVA: 0x000040F7 File Offset: 0x000022F7
			[DebuggerHidden]
			[global::Cpp2ILInjected.Token(Token = "0x60007F1")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D0DB14", Offset = "0x1D0DB14", Length = "0x1C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JObject.<GetEnumerator>d__58), Member = "<>m__Finally1", ReturnType = typeof(void))]
			private void System.IDisposable.Dispose()
			{
				throw null;
			}

			// Token: 0x06000B2A RID: 2858 RVA: 0x000040FA File Offset: 0x000022FA
			[global::Cpp2ILInjected.Token(Token = "0x60007F2")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D0DB30", Offset = "0x1D0DB30", Length = "0x2A8")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Collection<>), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.IEnumerator`1<T>")]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JObject.<GetEnumerator>d__58), Member = "<>m__Finally1", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JProperty), Member = "get_Value", ReturnType = typeof(JToken))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(KeyValuePair<object, object>), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(object),
				typeof(object)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 15)]
			private bool MoveNext()
			{
				throw null;
			}

			// Token: 0x06000B2B RID: 2859 RVA: 0x000040FD File Offset: 0x000022FD
			[global::Cpp2ILInjected.Token(Token = "0x60007F3")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D0DDD8", Offset = "0x1D0DDD8", Length = "0xB0")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JObject.<GetEnumerator>d__58), Member = "System.IDisposable.Dispose", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JObject.<GetEnumerator>d__58), Member = "MoveNext", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			private void <>m__Finally1()
			{
				throw null;
			}

			// Token: 0x17000220 RID: 544
			// (get) Token: 0x06000B2C RID: 2860 RVA: 0x00004100 File Offset: 0x00002300
			[global::Cpp2ILInjected.Token(Token = "0x1700017E")]
			private KeyValuePair<string, JToken> prop_KeyValuePair_2_String_JToken_0
			{
				[DebuggerHidden]
				[global::Cpp2ILInjected.Token(Token = "0x60007F4")]
				[global::Cpp2ILInjected.Address(RVA = "0x1D0DE88", Offset = "0x1D0DE88", Length = "0xC")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				get
				{
					throw null;
				}
			}

			// Token: 0x06000B2D RID: 2861 RVA: 0x00004103 File Offset: 0x00002303
			[DebuggerHidden]
			[global::Cpp2ILInjected.Token(Token = "0x60007F5")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D0DE94", Offset = "0x1D0DE94", Length = "0x38")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			private void System.Collections.IEnumerator.Reset()
			{
				throw null;
			}

			// Token: 0x17000221 RID: 545
			// (get) Token: 0x06000B2E RID: 2862 RVA: 0x00004106 File Offset: 0x00002306
			[global::Cpp2ILInjected.Token(Token = "0x1700017F")]
			private object System.Collections.IEnumerator.Current
			{
				[DebuggerHidden]
				[global::Cpp2ILInjected.Token(Token = "0x60007F6")]
				[global::Cpp2ILInjected.Address(RVA = "0x1D0DECC", Offset = "0x1D0DECC", Length = "0x5C")]
				[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
				get
				{
					throw null;
				}
			}

			// Token: 0x040003FA RID: 1018
			[global::Cpp2ILInjected.Token(Token = "0x400032F")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			// Token: 0x040003FB RID: 1019
			[global::Cpp2ILInjected.Token(Token = "0x4000330")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
			private KeyValuePair<string, JToken> <>2__current;

			// Token: 0x040003FC RID: 1020
			[global::Cpp2ILInjected.Token(Token = "0x4000331")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
			public JObject <>4__this;

			// Token: 0x040003FD RID: 1021
			[global::Cpp2ILInjected.Token(Token = "0x4000332")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
			private IEnumerator<JToken> <>7__wrap1;
		}
	}
}
