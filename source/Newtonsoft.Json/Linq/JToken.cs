﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Runtime.CompilerServices;
using System.Threading;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq.JsonPath;
using Newtonsoft.Json.Serialization;
using Newtonsoft.Json.Shims;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json.Linq
{
	[Preserve]
	[global::Cpp2ILInjected.Token(Token = "0x20000D5")]
	public abstract class JToken : IJEnumerable<JToken>, IEnumerable<JToken>, IEnumerable, IJsonLineInfo, ICloneable
	{
		[global::Cpp2ILInjected.Token(Token = "0x1700018B")]
		public static JTokenEqualityComparer EqualityComparer
		{
			[global::Cpp2ILInjected.Token(Token = "0x600084F")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D0A878", Offset = "0x1D0A878", Length = "0xBC")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JContainer), Member = "MergeEnumerableContent", MemberParameters = new object[]
			{
				typeof(JContainer),
				typeof(IEnumerable),
				typeof(JsonMergeSettings)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x1700018C")]
		public JContainer Parent
		{
			[DebuggerStepThrough]
			[global::Cpp2ILInjected.Token(Token = "0x6000850")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D10CFC", Offset = "0x1D10CFC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000851")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D10D04", Offset = "0x1D10D04", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			internal set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x1700018D")]
		public JToken Root
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000852")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D07F3C", Offset = "0x1D07F3C", Length = "0x18")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000853")]
		internal abstract JToken CloneToken();

		[global::Cpp2ILInjected.Token(Token = "0x6000854")]
		internal abstract bool DeepEquals(JToken node);

		[global::Cpp2ILInjected.Token(Token = "0x1700018E")]
		public abstract JTokenType Type
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000855")]
			get;
		}

		[global::Cpp2ILInjected.Token(Token = "0x1700018F")]
		public abstract bool HasValues
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000856")]
			get;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000857")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D04A34", Offset = "0x1D04A34", Length = "0x2C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public static bool DeepEquals(JToken t1, JToken t2)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000190")]
		public JToken Next
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000858")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D10D0C", Offset = "0x1D10D0C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000859")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D10D14", Offset = "0x1D10D14", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			internal set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000191")]
		public JToken Previous
		{
			[global::Cpp2ILInjected.Token(Token = "0x600085A")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D10D1C", Offset = "0x1D10D1C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x600085B")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D10D24", Offset = "0x1D10D24", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			internal set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000192")]
		public string Path
		{
			[global::Cpp2ILInjected.Token(Token = "0x600085C")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D0F84C", Offset = "0x1D0F84C", Length = "0x33C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
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
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JTokenReader), Member = "get_Path", ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<JsonPosition>), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonPosition), Member = ".ctor", MemberParameters = new object[] { typeof(JsonContainerType) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<JsonPosition>), Member = "Reverse", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonPosition), Member = "BuildPath", MemberParameters = new object[]
			{
				typeof(List<JsonPosition>),
				typeof(JsonPosition?)
			}, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 16)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x600085D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D07420", Offset = "0x1D07420", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JValue), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(JTokenType)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		internal JToken()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600085E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D10D2C", Offset = "0x1D10D2C", Length = "0x94")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JContainer), Member = "AddInternal", MemberParameters = new object[]
		{
			typeof(int),
			typeof(object),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public void AddAfterSelf(object content)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600085F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D10DC0", Offset = "0x1D10DC0", Length = "0x94")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JContainer), Member = "AddInternal", MemberParameters = new object[]
		{
			typeof(int),
			typeof(object),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public void AddBeforeSelf(object content)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000860")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D10E54", Offset = "0x1D10E54", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Linq.Extensions.<>c__0`1", Member = "<Ancestors>b__0_0", MemberParameters = new object[] { "T" }, ReturnType = typeof(IEnumerable<JToken>))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		public IEnumerable<JToken> Ancestors()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000861")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D10EC8", Offset = "0x1D10EC8", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Linq.Extensions.<>c__1`1", Member = "<AncestorsAndSelf>b__1_0", MemberParameters = new object[] { "T" }, ReturnType = typeof(IEnumerable<JToken>))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JToken), Member = "GetAncestors", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(IEnumerable<JToken>))]
		public IEnumerable<JToken> AncestorsAndSelf()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000862")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D10E5C", Offset = "0x1D10E5C", Length = "0x6C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JToken), Member = "AncestorsAndSelf", ReturnType = typeof(IEnumerable<JToken>))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JToken.<GetAncestors>d__41), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal IEnumerable<JToken> GetAncestors(bool self)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000863")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D10F0C", Offset = "0x1D10F0C", Length = "0x60")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JToken.<AfterSelf>d__42), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public IEnumerable<JToken> AfterSelf()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000864")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D10F6C", Offset = "0x1D10F6C", Length = "0x60")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JToken.<BeforeSelf>d__43), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public IEnumerable<JToken> BeforeSelf()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000193")]
		public virtual JToken this[object key]
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000865")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D10FCC", Offset = "0x1D10FCC", Length = "0x90")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
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
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000866")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D1105C", Offset = "0x1D1105C", Length = "0x90")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
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
			set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000867")]
		[global::Cpp2ILInjected.Address(RVA = "0x158C64C", Offset = "0x158C64C", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public virtual T Value<T>(object key)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000194")]
		public virtual JToken First
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000868")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D110EC", Offset = "0x1D110EC", Length = "0x90")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
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
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000195")]
		public virtual JToken Last
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000869")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D1117C", Offset = "0x1D1117C", Length = "0x90")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
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
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x600086A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D1120C", Offset = "0x1D1120C", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public virtual JEnumerable<JToken> Children()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600086B")]
		[global::Cpp2ILInjected.Address(RVA = "0x158C07C", Offset = "0x158C07C", Length = "0xA4")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JEnumerable<>), Member = ".ctor", MemberParameters = new object[] { "System.Collections.Generic.IEnumerable`1<T>" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public JEnumerable<T> Children<T>() where T : JToken
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600086C")]
		[global::Cpp2ILInjected.Address(RVA = "0x158C684", Offset = "0x158C684", Length = "0x90")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
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
		public virtual IEnumerable<T> Values<T>()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600086D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D0CCD0", Offset = "0x1D0CCD0", Length = "0x6C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JObject), Member = "Remove", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public void Remove()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600086E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D0A0E4", Offset = "0x1D0A0E4", Length = "0x74")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JContainer), Member = "ReadContentFrom", MemberParameters = new object[]
		{
			typeof(JsonReader),
			typeof(JsonLoadSettings)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public void Replace(JToken value)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600086F")]
		public abstract void WriteTo(JsonWriter writer, params JsonConverter[] converters);

		[global::Cpp2ILInjected.Token(Token = "0x6000870")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D11264", Offset = "0x1D11264", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public override string ToString()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000871")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D112BC", Offset = "0x1D112BC", Length = "0x248")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringWriter), Member = ".ctor", MemberParameters = new object[] { typeof(IFormatProvider) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonTextWriter), Member = ".ctor", MemberParameters = new object[] { typeof(TextWriter) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonWriter), Member = "set_Formatting", MemberParameters = new object[] { typeof(Formatting) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 15)]
		public string ToString(Formatting formatting, params JsonConverter[] converters)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000872")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D11504", Offset = "0x1D11504", Length = "0x114")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JToken), Member = "op_Explicit", MemberParameters = new object[] { typeof(JToken) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JToken), Member = "op_Explicit", MemberParameters = new object[] { typeof(JToken) }, ReturnType = typeof(DateTimeOffset))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JToken), Member = "op_Explicit", MemberParameters = new object[] { typeof(JToken) }, ReturnType = typeof(bool?))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JToken), Member = "op_Explicit", MemberParameters = new object[] { typeof(JToken) }, ReturnType = typeof(long))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JToken), Member = "op_Explicit", MemberParameters = new object[] { typeof(JToken) }, ReturnType = typeof(DateTime?))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JToken), Member = "op_Explicit", MemberParameters = new object[] { typeof(JToken) }, ReturnType = typeof(DateTimeOffset?))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JToken), Member = "op_Explicit", MemberParameters = new object[] { typeof(JToken) }, ReturnType = typeof(decimal?))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JToken), Member = "op_Explicit", MemberParameters = new object[] { typeof(JToken) }, ReturnType = typeof(double?))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JToken), Member = "op_Explicit", MemberParameters = new object[] { typeof(JToken) }, ReturnType = typeof(char?))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JToken), Member = "op_Explicit", MemberParameters = new object[] { typeof(JToken) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JToken), Member = "op_Explicit", MemberParameters = new object[] { typeof(JToken) }, ReturnType = typeof(short))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JToken), Member = "op_Explicit", MemberParameters = new object[] { typeof(JToken) }, ReturnType = typeof(ushort))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JToken), Member = "op_Explicit", MemberParameters = new object[] { typeof(JToken) }, ReturnType = typeof(char))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JToken), Member = "op_Explicit", MemberParameters = new object[] { typeof(JToken) }, ReturnType = typeof(byte))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JToken), Member = "op_Explicit", MemberParameters = new object[] { typeof(JToken) }, ReturnType = typeof(sbyte))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JToken), Member = "op_Explicit", MemberParameters = new object[] { typeof(JToken) }, ReturnType = typeof(int?))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JToken), Member = "op_Explicit", MemberParameters = new object[] { typeof(JToken) }, ReturnType = typeof(short?))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JToken), Member = "op_Explicit", MemberParameters = new object[] { typeof(JToken) }, ReturnType = typeof(ushort?))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JToken), Member = "op_Explicit", MemberParameters = new object[] { typeof(JToken) }, ReturnType = typeof(byte?))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JToken), Member = "op_Explicit", MemberParameters = new object[] { typeof(JToken) }, ReturnType = typeof(sbyte?))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JToken), Member = "op_Explicit", MemberParameters = new object[] { typeof(JToken) }, ReturnType = typeof(DateTime))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JToken), Member = "op_Explicit", MemberParameters = new object[] { typeof(JToken) }, ReturnType = typeof(long?))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JToken), Member = "op_Explicit", MemberParameters = new object[] { typeof(JToken) }, ReturnType = typeof(float?))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JToken), Member = "op_Explicit", MemberParameters = new object[] { typeof(JToken) }, ReturnType = typeof(decimal))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JToken), Member = "op_Explicit", MemberParameters = new object[] { typeof(JToken) }, ReturnType = typeof(uint?))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JToken), Member = "op_Explicit", MemberParameters = new object[] { typeof(JToken) }, ReturnType = typeof(ulong?))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JToken), Member = "op_Explicit", MemberParameters = new object[] { typeof(JToken) }, ReturnType = typeof(double))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JToken), Member = "op_Explicit", MemberParameters = new object[] { typeof(JToken) }, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JToken), Member = "op_Explicit", MemberParameters = new object[] { typeof(JToken) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JToken), Member = "op_Explicit", MemberParameters = new object[] { typeof(JToken) }, ReturnType = typeof(uint))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JToken), Member = "op_Explicit", MemberParameters = new object[] { typeof(JToken) }, ReturnType = typeof(ulong))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JToken), Member = "op_Explicit", MemberParameters = new object[] { typeof(JToken) }, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JToken), Member = "op_Explicit", MemberParameters = new object[] { typeof(JToken) }, ReturnType = typeof(Guid))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JToken), Member = "op_Explicit", MemberParameters = new object[] { typeof(JToken) }, ReturnType = typeof(Guid?))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JToken), Member = "op_Explicit", MemberParameters = new object[] { typeof(JToken) }, ReturnType = typeof(TimeSpan))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JToken), Member = "op_Explicit", MemberParameters = new object[] { typeof(JToken) }, ReturnType = typeof(TimeSpan?))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JToken), Member = "op_Explicit", MemberParameters = new object[] { typeof(JToken) }, ReturnType = typeof(Uri))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 37)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JProperty), Member = "get_Value", ReturnType = typeof(JToken))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		private static JValue EnsureValue(JToken value)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000873")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D11618", Offset = "0x1D11618", Length = "0xF0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JToken), Member = "op_Explicit", MemberParameters = new object[] { typeof(JToken) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JToken), Member = "op_Explicit", MemberParameters = new object[] { typeof(JToken) }, ReturnType = typeof(DateTimeOffset))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JToken), Member = "op_Explicit", MemberParameters = new object[] { typeof(JToken) }, ReturnType = typeof(bool?))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JToken), Member = "op_Explicit", MemberParameters = new object[] { typeof(JToken) }, ReturnType = typeof(long))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JToken), Member = "op_Explicit", MemberParameters = new object[] { typeof(JToken) }, ReturnType = typeof(DateTime?))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JToken), Member = "op_Explicit", MemberParameters = new object[] { typeof(JToken) }, ReturnType = typeof(DateTimeOffset?))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JToken), Member = "op_Explicit", MemberParameters = new object[] { typeof(JToken) }, ReturnType = typeof(decimal?))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JToken), Member = "op_Explicit", MemberParameters = new object[] { typeof(JToken) }, ReturnType = typeof(double?))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JToken), Member = "op_Explicit", MemberParameters = new object[] { typeof(JToken) }, ReturnType = typeof(char?))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JToken), Member = "op_Explicit", MemberParameters = new object[] { typeof(JToken) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JToken), Member = "op_Explicit", MemberParameters = new object[] { typeof(JToken) }, ReturnType = typeof(short))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JToken), Member = "op_Explicit", MemberParameters = new object[] { typeof(JToken) }, ReturnType = typeof(ushort))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JToken), Member = "op_Explicit", MemberParameters = new object[] { typeof(JToken) }, ReturnType = typeof(char))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JToken), Member = "op_Explicit", MemberParameters = new object[] { typeof(JToken) }, ReturnType = typeof(byte))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JToken), Member = "op_Explicit", MemberParameters = new object[] { typeof(JToken) }, ReturnType = typeof(sbyte))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JToken), Member = "op_Explicit", MemberParameters = new object[] { typeof(JToken) }, ReturnType = typeof(int?))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JToken), Member = "op_Explicit", MemberParameters = new object[] { typeof(JToken) }, ReturnType = typeof(short?))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JToken), Member = "op_Explicit", MemberParameters = new object[] { typeof(JToken) }, ReturnType = typeof(ushort?))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JToken), Member = "op_Explicit", MemberParameters = new object[] { typeof(JToken) }, ReturnType = typeof(byte?))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JToken), Member = "op_Explicit", MemberParameters = new object[] { typeof(JToken) }, ReturnType = typeof(sbyte?))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JToken), Member = "op_Explicit", MemberParameters = new object[] { typeof(JToken) }, ReturnType = typeof(DateTime))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JToken), Member = "op_Explicit", MemberParameters = new object[] { typeof(JToken) }, ReturnType = typeof(long?))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JToken), Member = "op_Explicit", MemberParameters = new object[] { typeof(JToken) }, ReturnType = typeof(float?))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JToken), Member = "op_Explicit", MemberParameters = new object[] { typeof(JToken) }, ReturnType = typeof(decimal))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JToken), Member = "op_Explicit", MemberParameters = new object[] { typeof(JToken) }, ReturnType = typeof(uint?))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JToken), Member = "op_Explicit", MemberParameters = new object[] { typeof(JToken) }, ReturnType = typeof(ulong?))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JToken), Member = "op_Explicit", MemberParameters = new object[] { typeof(JToken) }, ReturnType = typeof(double))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JToken), Member = "op_Explicit", MemberParameters = new object[] { typeof(JToken) }, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JToken), Member = "op_Explicit", MemberParameters = new object[] { typeof(JToken) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JToken), Member = "op_Explicit", MemberParameters = new object[] { typeof(JToken) }, ReturnType = typeof(uint))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JToken), Member = "op_Explicit", MemberParameters = new object[] { typeof(JToken) }, ReturnType = typeof(ulong))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JToken), Member = "op_Explicit", MemberParameters = new object[] { typeof(JToken) }, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JToken), Member = "op_Explicit", MemberParameters = new object[] { typeof(JToken) }, ReturnType = typeof(Guid))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JToken), Member = "op_Explicit", MemberParameters = new object[] { typeof(JToken) }, ReturnType = typeof(Guid?))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JToken), Member = "op_Explicit", MemberParameters = new object[] { typeof(JToken) }, ReturnType = typeof(TimeSpan))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JToken), Member = "op_Explicit", MemberParameters = new object[] { typeof(JToken) }, ReturnType = typeof(TimeSpan?))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JToken), Member = "op_Explicit", MemberParameters = new object[] { typeof(JToken) }, ReturnType = typeof(Uri))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 37)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ValidationUtils), Member = "ArgumentNotNull", MemberParameters = new object[]
		{
			typeof(object),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JProperty), Member = "get_Value", ReturnType = typeof(JToken))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Enum), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		private static string GetType(JToken token)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000874")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D11708", Offset = "0x1D11708", Length = "0xC4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JToken), Member = "op_Explicit", MemberParameters = new object[] { typeof(JToken) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JToken), Member = "op_Explicit", MemberParameters = new object[] { typeof(JToken) }, ReturnType = typeof(DateTimeOffset))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JToken), Member = "op_Explicit", MemberParameters = new object[] { typeof(JToken) }, ReturnType = typeof(bool?))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JToken), Member = "op_Explicit", MemberParameters = new object[] { typeof(JToken) }, ReturnType = typeof(long))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JToken), Member = "op_Explicit", MemberParameters = new object[] { typeof(JToken) }, ReturnType = typeof(DateTime?))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JToken), Member = "op_Explicit", MemberParameters = new object[] { typeof(JToken) }, ReturnType = typeof(DateTimeOffset?))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JToken), Member = "op_Explicit", MemberParameters = new object[] { typeof(JToken) }, ReturnType = typeof(decimal?))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JToken), Member = "op_Explicit", MemberParameters = new object[] { typeof(JToken) }, ReturnType = typeof(double?))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JToken), Member = "op_Explicit", MemberParameters = new object[] { typeof(JToken) }, ReturnType = typeof(char?))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JToken), Member = "op_Explicit", MemberParameters = new object[] { typeof(JToken) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JToken), Member = "op_Explicit", MemberParameters = new object[] { typeof(JToken) }, ReturnType = typeof(short))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JToken), Member = "op_Explicit", MemberParameters = new object[] { typeof(JToken) }, ReturnType = typeof(ushort))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JToken), Member = "op_Explicit", MemberParameters = new object[] { typeof(JToken) }, ReturnType = typeof(char))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JToken), Member = "op_Explicit", MemberParameters = new object[] { typeof(JToken) }, ReturnType = typeof(byte))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JToken), Member = "op_Explicit", MemberParameters = new object[] { typeof(JToken) }, ReturnType = typeof(sbyte))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JToken), Member = "op_Explicit", MemberParameters = new object[] { typeof(JToken) }, ReturnType = typeof(int?))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JToken), Member = "op_Explicit", MemberParameters = new object[] { typeof(JToken) }, ReturnType = typeof(short?))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JToken), Member = "op_Explicit", MemberParameters = new object[] { typeof(JToken) }, ReturnType = typeof(ushort?))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JToken), Member = "op_Explicit", MemberParameters = new object[] { typeof(JToken) }, ReturnType = typeof(byte?))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JToken), Member = "op_Explicit", MemberParameters = new object[] { typeof(JToken) }, ReturnType = typeof(sbyte?))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JToken), Member = "op_Explicit", MemberParameters = new object[] { typeof(JToken) }, ReturnType = typeof(DateTime))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JToken), Member = "op_Explicit", MemberParameters = new object[] { typeof(JToken) }, ReturnType = typeof(long?))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JToken), Member = "op_Explicit", MemberParameters = new object[] { typeof(JToken) }, ReturnType = typeof(float?))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JToken), Member = "op_Explicit", MemberParameters = new object[] { typeof(JToken) }, ReturnType = typeof(decimal))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JToken), Member = "op_Explicit", MemberParameters = new object[] { typeof(JToken) }, ReturnType = typeof(uint?))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JToken), Member = "op_Explicit", MemberParameters = new object[] { typeof(JToken) }, ReturnType = typeof(ulong?))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JToken), Member = "op_Explicit", MemberParameters = new object[] { typeof(JToken) }, ReturnType = typeof(double))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JToken), Member = "op_Explicit", MemberParameters = new object[] { typeof(JToken) }, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JToken), Member = "op_Explicit", MemberParameters = new object[] { typeof(JToken) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JToken), Member = "op_Explicit", MemberParameters = new object[] { typeof(JToken) }, ReturnType = typeof(uint))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JToken), Member = "op_Explicit", MemberParameters = new object[] { typeof(JToken) }, ReturnType = typeof(ulong))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JToken), Member = "op_Explicit", MemberParameters = new object[] { typeof(JToken) }, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JToken), Member = "op_Explicit", MemberParameters = new object[] { typeof(JToken) }, ReturnType = typeof(Guid))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JToken), Member = "op_Explicit", MemberParameters = new object[] { typeof(JToken) }, ReturnType = typeof(Guid?))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JToken), Member = "op_Explicit", MemberParameters = new object[] { typeof(JToken) }, ReturnType = typeof(TimeSpan))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JToken), Member = "op_Explicit", MemberParameters = new object[] { typeof(JToken) }, ReturnType = typeof(TimeSpan?))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JToken), Member = "op_Explicit", MemberParameters = new object[] { typeof(JToken) }, ReturnType = typeof(Uri))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 37)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Array[]), Member = "IndexOf", MemberTypeParameters = new object[] { "System.Int32Enum" }, MemberParameters = new object[]
		{
			typeof(Int32Enum[]),
			"System.Int32Enum"
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		private static bool ValidateToken(JToken o, JTokenType[] validTypes, bool nullable)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000875")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D117CC", Offset = "0x1D117CC", Length = "0x184")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Achievements.AchievementCondition", Member = "Load", MemberParameters = new object[] { typeof(JObject) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JToken), Member = "ToObject", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JValue), Member = "System.IConvertible.ToBoolean", MemberParameters = new object[] { typeof(IFormatProvider) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JToken), Member = "EnsureValue", MemberParameters = new object[] { typeof(JToken) }, ReturnType = typeof(JValue))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JToken), Member = "ValidateToken", MemberParameters = new object[]
		{
			typeof(JToken),
			typeof(JTokenType[]),
			typeof(bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Convert), Member = "ToBoolean", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IFormatProvider)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JToken), Member = "GetType", MemberParameters = new object[] { typeof(JToken) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringUtils), Member = "FormatWith", MemberParameters = new object[]
		{
			typeof(string),
			typeof(IFormatProvider),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 16)]
		public static explicit operator bool(JToken value)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000876")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D11950", Offset = "0x1D11950", Length = "0x260")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JToken), Member = "ToObject", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JToken), Member = "EnsureValue", MemberParameters = new object[] { typeof(JToken) }, ReturnType = typeof(JValue))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JToken), Member = "ValidateToken", MemberParameters = new object[]
		{
			typeof(JToken),
			typeof(JTokenType[]),
			typeof(bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Convert), Member = "ToDateTime", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IFormatProvider)
		}, ReturnType = typeof(DateTime))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTimeOffset), Member = ".ctor", MemberParameters = new object[] { typeof(DateTime) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTimeOffset), Member = "Parse", MemberParameters = new object[]
		{
			typeof(string),
			typeof(IFormatProvider)
		}, ReturnType = typeof(DateTimeOffset))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JToken), Member = "GetType", MemberParameters = new object[] { typeof(JToken) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringUtils), Member = "FormatWith", MemberParameters = new object[]
		{
			typeof(string),
			typeof(IFormatProvider),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 21)]
		public static explicit operator DateTimeOffset(JToken value)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000877")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D11BB0", Offset = "0x1D11BB0", Length = "0x1D0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JToken), Member = "ToObject", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JToken), Member = "EnsureValue", MemberParameters = new object[] { typeof(JToken) }, ReturnType = typeof(JValue))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JToken), Member = "ValidateToken", MemberParameters = new object[]
		{
			typeof(JToken),
			typeof(JTokenType[]),
			typeof(bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Convert), Member = "ToBoolean", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IFormatProvider)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Nullable<>), Member = ".ctor", MemberParameters = new object[] { "T" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JToken), Member = "GetType", MemberParameters = new object[] { typeof(JToken) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringUtils), Member = "FormatWith", MemberParameters = new object[]
		{
			typeof(string),
			typeof(IFormatProvider),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 17)]
		public static explicit operator bool?(JToken value)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000878")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D11D80", Offset = "0x1D11D80", Length = "0x184")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JToken), Member = "ToObject", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JValue), Member = "System.IConvertible.ToInt64", MemberParameters = new object[] { typeof(IFormatProvider) }, ReturnType = typeof(long))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JToken), Member = "EnsureValue", MemberParameters = new object[] { typeof(JToken) }, ReturnType = typeof(JValue))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JToken), Member = "ValidateToken", MemberParameters = new object[]
		{
			typeof(JToken),
			typeof(JTokenType[]),
			typeof(bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Convert), Member = "ToInt64", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IFormatProvider)
		}, ReturnType = typeof(long))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JToken), Member = "GetType", MemberParameters = new object[] { typeof(JToken) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringUtils), Member = "FormatWith", MemberParameters = new object[]
		{
			typeof(string),
			typeof(IFormatProvider),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 16)]
		public static explicit operator long(JToken value)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000879")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D11F04", Offset = "0x1D11F04", Length = "0x214")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JToken), Member = "ToObject", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JToken), Member = "EnsureValue", MemberParameters = new object[] { typeof(JToken) }, ReturnType = typeof(JValue))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JToken), Member = "ValidateToken", MemberParameters = new object[]
		{
			typeof(JToken),
			typeof(JTokenType[]),
			typeof(bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Convert), Member = "ToDateTime", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IFormatProvider)
		}, ReturnType = typeof(DateTime))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTimeOffset), Member = "get_DateTime", ReturnType = typeof(DateTime))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTime?), Member = ".ctor", MemberParameters = new object[] { typeof(DateTime) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JToken), Member = "GetType", MemberParameters = new object[] { typeof(JToken) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringUtils), Member = "FormatWith", MemberParameters = new object[]
		{
			typeof(string),
			typeof(IFormatProvider),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 19)]
		public static explicit operator DateTime?(JToken value)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600087A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D12118", Offset = "0x1D12118", Length = "0x30C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JToken), Member = "ToObject", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JToken), Member = "EnsureValue", MemberParameters = new object[] { typeof(JToken) }, ReturnType = typeof(JValue))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JToken), Member = "ValidateToken", MemberParameters = new object[]
		{
			typeof(JToken),
			typeof(JTokenType[]),
			typeof(bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Convert), Member = "ToDateTime", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IFormatProvider)
		}, ReturnType = typeof(DateTime))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTimeOffset), Member = ".ctor", MemberParameters = new object[] { typeof(DateTime) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTimeOffset), Member = "Parse", MemberParameters = new object[]
		{
			typeof(string),
			typeof(IFormatProvider)
		}, ReturnType = typeof(DateTimeOffset))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTimeOffset?), Member = ".ctor", MemberParameters = new object[] { typeof(DateTimeOffset) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JToken), Member = "GetType", MemberParameters = new object[] { typeof(JToken) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringUtils), Member = "FormatWith", MemberParameters = new object[]
		{
			typeof(string),
			typeof(IFormatProvider),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 24)]
		public static explicit operator DateTimeOffset?(JToken value)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600087B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D12424", Offset = "0x1D12424", Length = "0x1E8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JToken), Member = "ToObject", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JToken), Member = "EnsureValue", MemberParameters = new object[] { typeof(JToken) }, ReturnType = typeof(JValue))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JToken), Member = "ValidateToken", MemberParameters = new object[]
		{
			typeof(JToken),
			typeof(JTokenType[]),
			typeof(bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Convert), Member = "ToDecimal", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IFormatProvider)
		}, ReturnType = typeof(decimal))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(decimal?), Member = ".ctor", MemberParameters = new object[] { typeof(decimal) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JToken), Member = "GetType", MemberParameters = new object[] { typeof(JToken) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringUtils), Member = "FormatWith", MemberParameters = new object[]
		{
			typeof(string),
			typeof(IFormatProvider),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 17)]
		public static explicit operator decimal?(JToken value)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600087C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D1260C", Offset = "0x1D1260C", Length = "0x1C8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JToken), Member = "ToObject", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JToken), Member = "EnsureValue", MemberParameters = new object[] { typeof(JToken) }, ReturnType = typeof(JValue))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JToken), Member = "ValidateToken", MemberParameters = new object[]
		{
			typeof(JToken),
			typeof(JTokenType[]),
			typeof(bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Convert), Member = "ToDouble", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IFormatProvider)
		}, ReturnType = typeof(double))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(double?), Member = ".ctor", MemberParameters = new object[] { typeof(double) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JToken), Member = "GetType", MemberParameters = new object[] { typeof(JToken) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringUtils), Member = "FormatWith", MemberParameters = new object[]
		{
			typeof(string),
			typeof(IFormatProvider),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 17)]
		public static explicit operator double?(JToken value)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600087D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D127D4", Offset = "0x1D127D4", Length = "0x1D0")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JToken), Member = "ToObject", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JToken), Member = "EnsureValue", MemberParameters = new object[] { typeof(JToken) }, ReturnType = typeof(JValue))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JToken), Member = "ValidateToken", MemberParameters = new object[]
		{
			typeof(JToken),
			typeof(JTokenType[]),
			typeof(bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Convert), Member = "ToChar", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IFormatProvider)
		}, ReturnType = typeof(char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(char?), Member = ".ctor", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JToken), Member = "GetType", MemberParameters = new object[] { typeof(JToken) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringUtils), Member = "FormatWith", MemberParameters = new object[]
		{
			typeof(string),
			typeof(IFormatProvider),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 17)]
		public static explicit operator char?(JToken value)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600087E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D129A4", Offset = "0x1D129A4", Length = "0x184")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.GameContent.Achievements.CustomIntCondition", Member = "Load", MemberParameters = new object[] { typeof(JObject) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JToken), Member = "ToObject", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JValue), Member = "System.IConvertible.ToInt32", MemberParameters = new object[] { typeof(IFormatProvider) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ResolutionConverter), Member = "ReadJson", MemberParameters = new object[]
		{
			typeof(JsonReader),
			typeof(Type),
			typeof(object),
			typeof(JsonSerializer)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JToken), Member = "EnsureValue", MemberParameters = new object[] { typeof(JToken) }, ReturnType = typeof(JValue))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JToken), Member = "ValidateToken", MemberParameters = new object[]
		{
			typeof(JToken),
			typeof(JTokenType[]),
			typeof(bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Convert), Member = "ToInt32", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IFormatProvider)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JToken), Member = "GetType", MemberParameters = new object[] { typeof(JToken) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringUtils), Member = "FormatWith", MemberParameters = new object[]
		{
			typeof(string),
			typeof(IFormatProvider),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 16)]
		public static explicit operator int(JToken value)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600087F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D12B28", Offset = "0x1D12B28", Length = "0x184")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JToken), Member = "ToObject", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JValue), Member = "System.IConvertible.ToInt16", MemberParameters = new object[] { typeof(IFormatProvider) }, ReturnType = typeof(short))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JToken), Member = "EnsureValue", MemberParameters = new object[] { typeof(JToken) }, ReturnType = typeof(JValue))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JToken), Member = "ValidateToken", MemberParameters = new object[]
		{
			typeof(JToken),
			typeof(JTokenType[]),
			typeof(bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Convert), Member = "ToInt16", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IFormatProvider)
		}, ReturnType = typeof(short))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JToken), Member = "GetType", MemberParameters = new object[] { typeof(JToken) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringUtils), Member = "FormatWith", MemberParameters = new object[]
		{
			typeof(string),
			typeof(IFormatProvider),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 16)]
		public static explicit operator short(JToken value)
		{
			throw null;
		}

		[CLSCompliant(false)]
		[global::Cpp2ILInjected.Token(Token = "0x6000880")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D12CAC", Offset = "0x1D12CAC", Length = "0x184")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JToken), Member = "ToObject", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JValue), Member = "System.IConvertible.ToUInt16", MemberParameters = new object[] { typeof(IFormatProvider) }, ReturnType = typeof(ushort))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JToken), Member = "EnsureValue", MemberParameters = new object[] { typeof(JToken) }, ReturnType = typeof(JValue))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JToken), Member = "ValidateToken", MemberParameters = new object[]
		{
			typeof(JToken),
			typeof(JTokenType[]),
			typeof(bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Convert), Member = "ToUInt16", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IFormatProvider)
		}, ReturnType = typeof(ushort))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JToken), Member = "GetType", MemberParameters = new object[] { typeof(JToken) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringUtils), Member = "FormatWith", MemberParameters = new object[]
		{
			typeof(string),
			typeof(IFormatProvider),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 16)]
		public static explicit operator ushort(JToken value)
		{
			throw null;
		}

		[CLSCompliant(false)]
		[global::Cpp2ILInjected.Token(Token = "0x6000881")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D12E30", Offset = "0x1D12E30", Length = "0x184")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JToken), Member = "ToObject", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JValue), Member = "System.IConvertible.ToChar", MemberParameters = new object[] { typeof(IFormatProvider) }, ReturnType = typeof(char))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JToken), Member = "EnsureValue", MemberParameters = new object[] { typeof(JToken) }, ReturnType = typeof(JValue))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JToken), Member = "ValidateToken", MemberParameters = new object[]
		{
			typeof(JToken),
			typeof(JTokenType[]),
			typeof(bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Convert), Member = "ToChar", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IFormatProvider)
		}, ReturnType = typeof(char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JToken), Member = "GetType", MemberParameters = new object[] { typeof(JToken) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringUtils), Member = "FormatWith", MemberParameters = new object[]
		{
			typeof(string),
			typeof(IFormatProvider),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 16)]
		public static explicit operator char(JToken value)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000882")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D12FB4", Offset = "0x1D12FB4", Length = "0x184")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JToken), Member = "ToObject", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JValue), Member = "System.IConvertible.ToByte", MemberParameters = new object[] { typeof(IFormatProvider) }, ReturnType = typeof(byte))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ColorConverter), Member = "ReadJson", MemberParameters = new object[]
		{
			typeof(JsonReader),
			typeof(Type),
			typeof(object),
			typeof(JsonSerializer)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JToken), Member = "EnsureValue", MemberParameters = new object[] { typeof(JToken) }, ReturnType = typeof(JValue))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JToken), Member = "ValidateToken", MemberParameters = new object[]
		{
			typeof(JToken),
			typeof(JTokenType[]),
			typeof(bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Convert), Member = "ToByte", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IFormatProvider)
		}, ReturnType = typeof(byte))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JToken), Member = "GetType", MemberParameters = new object[] { typeof(JToken) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringUtils), Member = "FormatWith", MemberParameters = new object[]
		{
			typeof(string),
			typeof(IFormatProvider),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 16)]
		public static explicit operator byte(JToken value)
		{
			throw null;
		}

		[CLSCompliant(false)]
		[global::Cpp2ILInjected.Token(Token = "0x6000883")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D13138", Offset = "0x1D13138", Length = "0x184")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JToken), Member = "ToObject", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JValue), Member = "System.IConvertible.ToSByte", MemberParameters = new object[] { typeof(IFormatProvider) }, ReturnType = typeof(sbyte))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JToken), Member = "EnsureValue", MemberParameters = new object[] { typeof(JToken) }, ReturnType = typeof(JValue))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JToken), Member = "ValidateToken", MemberParameters = new object[]
		{
			typeof(JToken),
			typeof(JTokenType[]),
			typeof(bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Convert), Member = "ToSByte", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IFormatProvider)
		}, ReturnType = typeof(sbyte))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JToken), Member = "GetType", MemberParameters = new object[] { typeof(JToken) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringUtils), Member = "FormatWith", MemberParameters = new object[]
		{
			typeof(string),
			typeof(IFormatProvider),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 16)]
		public static explicit operator sbyte(JToken value)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000884")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D132BC", Offset = "0x1D132BC", Length = "0x1D0")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JToken), Member = "ToObject", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JToken), Member = "EnsureValue", MemberParameters = new object[] { typeof(JToken) }, ReturnType = typeof(JValue))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JToken), Member = "ValidateToken", MemberParameters = new object[]
		{
			typeof(JToken),
			typeof(JTokenType[]),
			typeof(bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Convert), Member = "ToInt32", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IFormatProvider)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(int?), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JToken), Member = "GetType", MemberParameters = new object[] { typeof(JToken) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringUtils), Member = "FormatWith", MemberParameters = new object[]
		{
			typeof(string),
			typeof(IFormatProvider),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 17)]
		public static explicit operator int?(JToken value)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000885")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D1348C", Offset = "0x1D1348C", Length = "0x1D0")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JToken), Member = "ToObject", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JToken), Member = "EnsureValue", MemberParameters = new object[] { typeof(JToken) }, ReturnType = typeof(JValue))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JToken), Member = "ValidateToken", MemberParameters = new object[]
		{
			typeof(JToken),
			typeof(JTokenType[]),
			typeof(bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Convert), Member = "ToInt16", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IFormatProvider)
		}, ReturnType = typeof(short))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(short?), Member = ".ctor", MemberParameters = new object[] { typeof(short) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JToken), Member = "GetType", MemberParameters = new object[] { typeof(JToken) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringUtils), Member = "FormatWith", MemberParameters = new object[]
		{
			typeof(string),
			typeof(IFormatProvider),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 17)]
		public static explicit operator short?(JToken value)
		{
			throw null;
		}

		[CLSCompliant(false)]
		[global::Cpp2ILInjected.Token(Token = "0x6000886")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D1365C", Offset = "0x1D1365C", Length = "0x1D0")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JToken), Member = "ToObject", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JToken), Member = "EnsureValue", MemberParameters = new object[] { typeof(JToken) }, ReturnType = typeof(JValue))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JToken), Member = "ValidateToken", MemberParameters = new object[]
		{
			typeof(JToken),
			typeof(JTokenType[]),
			typeof(bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Convert), Member = "ToUInt16", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IFormatProvider)
		}, ReturnType = typeof(ushort))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ushort?), Member = ".ctor", MemberParameters = new object[] { typeof(ushort) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JToken), Member = "GetType", MemberParameters = new object[] { typeof(JToken) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringUtils), Member = "FormatWith", MemberParameters = new object[]
		{
			typeof(string),
			typeof(IFormatProvider),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 17)]
		public static explicit operator ushort?(JToken value)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000887")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D1382C", Offset = "0x1D1382C", Length = "0x1D0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JToken), Member = "ToObject", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JToken), Member = "EnsureValue", MemberParameters = new object[] { typeof(JToken) }, ReturnType = typeof(JValue))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JToken), Member = "ValidateToken", MemberParameters = new object[]
		{
			typeof(JToken),
			typeof(JTokenType[]),
			typeof(bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Convert), Member = "ToByte", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IFormatProvider)
		}, ReturnType = typeof(byte))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(byte?), Member = ".ctor", MemberParameters = new object[] { typeof(byte) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JToken), Member = "GetType", MemberParameters = new object[] { typeof(JToken) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringUtils), Member = "FormatWith", MemberParameters = new object[]
		{
			typeof(string),
			typeof(IFormatProvider),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 17)]
		public static explicit operator byte?(JToken value)
		{
			throw null;
		}

		[CLSCompliant(false)]
		[global::Cpp2ILInjected.Token(Token = "0x6000888")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D139FC", Offset = "0x1D139FC", Length = "0x1D0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JToken), Member = "ToObject", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JToken), Member = "EnsureValue", MemberParameters = new object[] { typeof(JToken) }, ReturnType = typeof(JValue))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JToken), Member = "ValidateToken", MemberParameters = new object[]
		{
			typeof(JToken),
			typeof(JTokenType[]),
			typeof(bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Convert), Member = "ToSByte", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IFormatProvider)
		}, ReturnType = typeof(sbyte))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(sbyte?), Member = ".ctor", MemberParameters = new object[] { typeof(sbyte) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JToken), Member = "GetType", MemberParameters = new object[] { typeof(JToken) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringUtils), Member = "FormatWith", MemberParameters = new object[]
		{
			typeof(string),
			typeof(IFormatProvider),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 17)]
		public static explicit operator sbyte?(JToken value)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000889")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D13BCC", Offset = "0x1D13BCC", Length = "0x1DC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JToken), Member = "ToObject", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JValue), Member = "System.IConvertible.ToDateTime", MemberParameters = new object[] { typeof(IFormatProvider) }, ReturnType = typeof(DateTime))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JToken), Member = "EnsureValue", MemberParameters = new object[] { typeof(JToken) }, ReturnType = typeof(JValue))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JToken), Member = "ValidateToken", MemberParameters = new object[]
		{
			typeof(JToken),
			typeof(JTokenType[]),
			typeof(bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Convert), Member = "ToDateTime", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IFormatProvider)
		}, ReturnType = typeof(DateTime))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTimeOffset), Member = "get_DateTime", ReturnType = typeof(DateTime))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JToken), Member = "GetType", MemberParameters = new object[] { typeof(JToken) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringUtils), Member = "FormatWith", MemberParameters = new object[]
		{
			typeof(string),
			typeof(IFormatProvider),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 18)]
		public static explicit operator DateTime(JToken value)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600088A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D13DA8", Offset = "0x1D13DA8", Length = "0x1CC")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JToken), Member = "ToObject", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JToken), Member = "EnsureValue", MemberParameters = new object[] { typeof(JToken) }, ReturnType = typeof(JValue))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JToken), Member = "ValidateToken", MemberParameters = new object[]
		{
			typeof(JToken),
			typeof(JTokenType[]),
			typeof(bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Convert), Member = "ToInt64", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IFormatProvider)
		}, ReturnType = typeof(long))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(long?), Member = ".ctor", MemberParameters = new object[] { typeof(long) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JToken), Member = "GetType", MemberParameters = new object[] { typeof(JToken) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringUtils), Member = "FormatWith", MemberParameters = new object[]
		{
			typeof(string),
			typeof(IFormatProvider),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 17)]
		public static explicit operator long?(JToken value)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600088B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D13F74", Offset = "0x1D13F74", Length = "0x1CC")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JToken), Member = "ToObject", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JToken), Member = "EnsureValue", MemberParameters = new object[] { typeof(JToken) }, ReturnType = typeof(JValue))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JToken), Member = "ValidateToken", MemberParameters = new object[]
		{
			typeof(JToken),
			typeof(JTokenType[]),
			typeof(bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Convert), Member = "ToSingle", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IFormatProvider)
		}, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(float?), Member = ".ctor", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JToken), Member = "GetType", MemberParameters = new object[] { typeof(JToken) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringUtils), Member = "FormatWith", MemberParameters = new object[]
		{
			typeof(string),
			typeof(IFormatProvider),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 17)]
		public static explicit operator float?(JToken value)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600088C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D14140", Offset = "0x1D14140", Length = "0x184")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JToken), Member = "ToObject", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JValue), Member = "System.IConvertible.ToDecimal", MemberParameters = new object[] { typeof(IFormatProvider) }, ReturnType = typeof(decimal))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JToken), Member = "EnsureValue", MemberParameters = new object[] { typeof(JToken) }, ReturnType = typeof(JValue))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JToken), Member = "ValidateToken", MemberParameters = new object[]
		{
			typeof(JToken),
			typeof(JTokenType[]),
			typeof(bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Convert), Member = "ToDecimal", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IFormatProvider)
		}, ReturnType = typeof(decimal))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JToken), Member = "GetType", MemberParameters = new object[] { typeof(JToken) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringUtils), Member = "FormatWith", MemberParameters = new object[]
		{
			typeof(string),
			typeof(IFormatProvider),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 16)]
		public static explicit operator decimal(JToken value)
		{
			throw null;
		}

		[CLSCompliant(false)]
		[global::Cpp2ILInjected.Token(Token = "0x600088D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D142C4", Offset = "0x1D142C4", Length = "0x1D0")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JToken), Member = "ToObject", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JToken), Member = "EnsureValue", MemberParameters = new object[] { typeof(JToken) }, ReturnType = typeof(JValue))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JToken), Member = "ValidateToken", MemberParameters = new object[]
		{
			typeof(JToken),
			typeof(JTokenType[]),
			typeof(bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Convert), Member = "ToUInt32", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IFormatProvider)
		}, ReturnType = typeof(uint))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(uint?), Member = ".ctor", MemberParameters = new object[] { typeof(uint) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JToken), Member = "GetType", MemberParameters = new object[] { typeof(JToken) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringUtils), Member = "FormatWith", MemberParameters = new object[]
		{
			typeof(string),
			typeof(IFormatProvider),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 17)]
		public static explicit operator uint?(JToken value)
		{
			throw null;
		}

		[CLSCompliant(false)]
		[global::Cpp2ILInjected.Token(Token = "0x600088E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D14494", Offset = "0x1D14494", Length = "0x1CC")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JToken), Member = "ToObject", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JToken), Member = "EnsureValue", MemberParameters = new object[] { typeof(JToken) }, ReturnType = typeof(JValue))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JToken), Member = "ValidateToken", MemberParameters = new object[]
		{
			typeof(JToken),
			typeof(JTokenType[]),
			typeof(bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Convert), Member = "ToUInt64", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IFormatProvider)
		}, ReturnType = typeof(ulong))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ulong?), Member = ".ctor", MemberParameters = new object[] { typeof(ulong) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JToken), Member = "GetType", MemberParameters = new object[] { typeof(JToken) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringUtils), Member = "FormatWith", MemberParameters = new object[]
		{
			typeof(string),
			typeof(IFormatProvider),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 17)]
		public static explicit operator ulong?(JToken value)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600088F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D14660", Offset = "0x1D14660", Length = "0x184")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JToken), Member = "ToObject", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JValue), Member = "System.IConvertible.ToDouble", MemberParameters = new object[] { typeof(IFormatProvider) }, ReturnType = typeof(double))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JToken), Member = "EnsureValue", MemberParameters = new object[] { typeof(JToken) }, ReturnType = typeof(JValue))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JToken), Member = "ValidateToken", MemberParameters = new object[]
		{
			typeof(JToken),
			typeof(JTokenType[]),
			typeof(bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Convert), Member = "ToDouble", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IFormatProvider)
		}, ReturnType = typeof(double))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JToken), Member = "GetType", MemberParameters = new object[] { typeof(JToken) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringUtils), Member = "FormatWith", MemberParameters = new object[]
		{
			typeof(string),
			typeof(IFormatProvider),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 16)]
		public static explicit operator double(JToken value)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000890")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D147E4", Offset = "0x1D147E4", Length = "0x184")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.GameContent.Achievements.CustomFloatCondition", Member = "Load", MemberParameters = new object[] { typeof(JObject) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JToken), Member = "ToObject", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JValue), Member = "System.IConvertible.ToSingle", MemberParameters = new object[] { typeof(IFormatProvider) }, ReturnType = typeof(float))]
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
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 26)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JToken), Member = "EnsureValue", MemberParameters = new object[] { typeof(JToken) }, ReturnType = typeof(JValue))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JToken), Member = "ValidateToken", MemberParameters = new object[]
		{
			typeof(JToken),
			typeof(JTokenType[]),
			typeof(bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Convert), Member = "ToSingle", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IFormatProvider)
		}, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JToken), Member = "GetType", MemberParameters = new object[] { typeof(JToken) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringUtils), Member = "FormatWith", MemberParameters = new object[]
		{
			typeof(string),
			typeof(IFormatProvider),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 16)]
		public static explicit operator float(JToken value)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000891")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D14968", Offset = "0x1D14968", Length = "0x21C")]
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
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JToken), Member = "ToObject", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JToken), Member = "EnsureValue", MemberParameters = new object[] { typeof(JToken) }, ReturnType = typeof(JValue))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JToken), Member = "ValidateToken", MemberParameters = new object[]
		{
			typeof(JToken),
			typeof(JTokenType[]),
			typeof(bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Convert), Member = "ToString", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IFormatProvider)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Convert), Member = "ToBase64String", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JToken), Member = "GetType", MemberParameters = new object[] { typeof(JToken) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringUtils), Member = "FormatWith", MemberParameters = new object[]
		{
			typeof(string),
			typeof(IFormatProvider),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 21)]
		public static explicit operator string(JToken value)
		{
			throw null;
		}

		[CLSCompliant(false)]
		[global::Cpp2ILInjected.Token(Token = "0x6000892")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D14B84", Offset = "0x1D14B84", Length = "0x184")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JToken), Member = "ToObject", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JValue), Member = "System.IConvertible.ToUInt32", MemberParameters = new object[] { typeof(IFormatProvider) }, ReturnType = typeof(uint))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JToken), Member = "EnsureValue", MemberParameters = new object[] { typeof(JToken) }, ReturnType = typeof(JValue))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JToken), Member = "ValidateToken", MemberParameters = new object[]
		{
			typeof(JToken),
			typeof(JTokenType[]),
			typeof(bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Convert), Member = "ToUInt32", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IFormatProvider)
		}, ReturnType = typeof(uint))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JToken), Member = "GetType", MemberParameters = new object[] { typeof(JToken) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringUtils), Member = "FormatWith", MemberParameters = new object[]
		{
			typeof(string),
			typeof(IFormatProvider),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 16)]
		public static explicit operator uint(JToken value)
		{
			throw null;
		}

		[CLSCompliant(false)]
		[global::Cpp2ILInjected.Token(Token = "0x6000893")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D14D08", Offset = "0x1D14D08", Length = "0x184")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JToken), Member = "ToObject", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JValue), Member = "System.IConvertible.ToUInt64", MemberParameters = new object[] { typeof(IFormatProvider) }, ReturnType = typeof(ulong))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JToken), Member = "EnsureValue", MemberParameters = new object[] { typeof(JToken) }, ReturnType = typeof(JValue))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JToken), Member = "ValidateToken", MemberParameters = new object[]
		{
			typeof(JToken),
			typeof(JTokenType[]),
			typeof(bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Convert), Member = "ToUInt64", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IFormatProvider)
		}, ReturnType = typeof(ulong))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JToken), Member = "GetType", MemberParameters = new object[] { typeof(JToken) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringUtils), Member = "FormatWith", MemberParameters = new object[]
		{
			typeof(string),
			typeof(IFormatProvider),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 16)]
		public static explicit operator ulong(JToken value)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000894")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D14E8C", Offset = "0x1D14E8C", Length = "0x220")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JToken), Member = "EnsureValue", MemberParameters = new object[] { typeof(JToken) }, ReturnType = typeof(JValue))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JToken), Member = "ValidateToken", MemberParameters = new object[]
		{
			typeof(JToken),
			typeof(JTokenType[]),
			typeof(bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Convert), Member = "ToString", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IFormatProvider)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Convert), Member = "FromBase64String", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JToken), Member = "GetType", MemberParameters = new object[] { typeof(JToken) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringUtils), Member = "FormatWith", MemberParameters = new object[]
		{
			typeof(string),
			typeof(IFormatProvider),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 21)]
		public static explicit operator byte[](JToken value)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000895")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D150AC", Offset = "0x1D150AC", Length = "0x248")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JToken), Member = "ToObject", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JToken), Member = "EnsureValue", MemberParameters = new object[] { typeof(JToken) }, ReturnType = typeof(JValue))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JToken), Member = "ValidateToken", MemberParameters = new object[]
		{
			typeof(JToken),
			typeof(JTokenType[]),
			typeof(bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Convert), Member = "ToString", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IFormatProvider)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Guid), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Guid), Member = ".ctor", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JToken), Member = "GetType", MemberParameters = new object[] { typeof(JToken) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringUtils), Member = "FormatWith", MemberParameters = new object[]
		{
			typeof(string),
			typeof(IFormatProvider),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 22)]
		public static explicit operator Guid(JToken value)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000896")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D152F4", Offset = "0x1D152F4", Length = "0x28C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JToken), Member = "ToObject", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JToken), Member = "EnsureValue", MemberParameters = new object[] { typeof(JToken) }, ReturnType = typeof(JValue))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JToken), Member = "ValidateToken", MemberParameters = new object[]
		{
			typeof(JToken),
			typeof(JTokenType[]),
			typeof(bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Convert), Member = "ToString", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IFormatProvider)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Guid), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Guid), Member = ".ctor", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Guid?), Member = ".ctor", MemberParameters = new object[] { typeof(Guid) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JToken), Member = "GetType", MemberParameters = new object[] { typeof(JToken) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringUtils), Member = "FormatWith", MemberParameters = new object[]
		{
			typeof(string),
			typeof(IFormatProvider),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 23)]
		public static explicit operator Guid?(JToken value)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000897")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D15580", Offset = "0x1D15580", Length = "0x1FC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JToken), Member = "ToObject", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JToken), Member = "EnsureValue", MemberParameters = new object[] { typeof(JToken) }, ReturnType = typeof(JValue))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JToken), Member = "ValidateToken", MemberParameters = new object[]
		{
			typeof(JToken),
			typeof(JTokenType[]),
			typeof(bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Convert), Member = "ToString", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IFormatProvider)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ConvertUtils), Member = "ParseTimeSpan", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(TimeSpan))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JToken), Member = "GetType", MemberParameters = new object[] { typeof(JToken) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringUtils), Member = "FormatWith", MemberParameters = new object[]
		{
			typeof(string),
			typeof(IFormatProvider),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 20)]
		public static explicit operator TimeSpan(JToken value)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000898")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D1577C", Offset = "0x1D1577C", Length = "0x240")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JToken), Member = "ToObject", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JToken), Member = "EnsureValue", MemberParameters = new object[] { typeof(JToken) }, ReturnType = typeof(JValue))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JToken), Member = "ValidateToken", MemberParameters = new object[]
		{
			typeof(JToken),
			typeof(JTokenType[]),
			typeof(bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Convert), Member = "ToString", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IFormatProvider)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ConvertUtils), Member = "ParseTimeSpan", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(TimeSpan))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TimeSpan?), Member = ".ctor", MemberParameters = new object[] { typeof(TimeSpan) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JToken), Member = "GetType", MemberParameters = new object[] { typeof(JToken) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringUtils), Member = "FormatWith", MemberParameters = new object[]
		{
			typeof(string),
			typeof(IFormatProvider),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 21)]
		public static explicit operator TimeSpan?(JToken value)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000899")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D159BC", Offset = "0x1D159BC", Length = "0x1FC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JToken), Member = "ToObject", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JToken), Member = "EnsureValue", MemberParameters = new object[] { typeof(JToken) }, ReturnType = typeof(JValue))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JToken), Member = "ValidateToken", MemberParameters = new object[]
		{
			typeof(JToken),
			typeof(JTokenType[]),
			typeof(bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Convert), Member = "ToString", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IFormatProvider)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Uri), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JToken), Member = "GetType", MemberParameters = new object[] { typeof(JToken) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringUtils), Member = "FormatWith", MemberParameters = new object[]
		{
			typeof(string),
			typeof(IFormatProvider),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 18)]
		public static explicit operator Uri(JToken value)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600089A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D15BB8", Offset = "0x1D15BB8", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JValue), Member = ".ctor", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static implicit operator JToken(bool value)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600089B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D15C14", Offset = "0x1D15C14", Length = "0x6C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JValue), Member = ".ctor", MemberParameters = new object[] { typeof(DateTimeOffset) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static implicit operator JToken(DateTimeOffset value)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600089C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D15C80", Offset = "0x1D15C80", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JValue), Member = ".ctor", MemberParameters = new object[] { typeof(long) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static implicit operator JToken(byte value)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600089D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D15CDC", Offset = "0x1D15CDC", Length = "0x90")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JValue), Member = ".ctor", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public static implicit operator JToken(byte? value)
		{
			throw null;
		}

		[CLSCompliant(false)]
		[global::Cpp2ILInjected.Token(Token = "0x600089E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D15D6C", Offset = "0x1D15D6C", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JValue), Member = ".ctor", MemberParameters = new object[] { typeof(long) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static implicit operator JToken(sbyte value)
		{
			throw null;
		}

		[CLSCompliant(false)]
		[global::Cpp2ILInjected.Token(Token = "0x600089F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D15DC8", Offset = "0x1D15DC8", Length = "0x90")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JValue), Member = ".ctor", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public static implicit operator JToken(sbyte? value)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60008A0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D15E58", Offset = "0x1D15E58", Length = "0x90")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JValue), Member = ".ctor", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public static implicit operator JToken(bool? value)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60008A1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D15EE8", Offset = "0x1D15EE8", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JValue), Member = ".ctor", MemberParameters = new object[] { typeof(long) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static implicit operator JToken(long value)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60008A2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D15F44", Offset = "0x1D15F44", Length = "0x9C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JValue), Member = ".ctor", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public static implicit operator JToken(DateTime? value)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60008A3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D15FE0", Offset = "0x1D15FE0", Length = "0xA4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JValue), Member = ".ctor", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public static implicit operator JToken(DateTimeOffset? value)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60008A4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D16084", Offset = "0x1D16084", Length = "0xC4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JValue), Member = ".ctor", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public static implicit operator JToken(decimal? value)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60008A5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D16148", Offset = "0x1D16148", Length = "0x9C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JValue), Member = ".ctor", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public static implicit operator JToken(double? value)
		{
			throw null;
		}

		[CLSCompliant(false)]
		[global::Cpp2ILInjected.Token(Token = "0x60008A6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D161E4", Offset = "0x1D161E4", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JValue), Member = ".ctor", MemberParameters = new object[] { typeof(long) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static implicit operator JToken(short value)
		{
			throw null;
		}

		[CLSCompliant(false)]
		[global::Cpp2ILInjected.Token(Token = "0x60008A7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D16240", Offset = "0x1D16240", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JValue), Member = ".ctor", MemberParameters = new object[] { typeof(long) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static implicit operator JToken(ushort value)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60008A8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D1629C", Offset = "0x1D1629C", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JValue), Member = ".ctor", MemberParameters = new object[] { typeof(long) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static implicit operator JToken(int value)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60008A9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D162F8", Offset = "0x1D162F8", Length = "0x90")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JValue), Member = ".ctor", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public static implicit operator JToken(int? value)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60008AA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D16388", Offset = "0x1D16388", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JValue), Member = ".ctor", MemberParameters = new object[] { typeof(DateTime) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static implicit operator JToken(DateTime value)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60008AB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D163E4", Offset = "0x1D163E4", Length = "0x9C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JValue), Member = ".ctor", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public static implicit operator JToken(long? value)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60008AC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D16480", Offset = "0x1D16480", Length = "0x90")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JValue), Member = ".ctor", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public static implicit operator JToken(float? value)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60008AD")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D16510", Offset = "0x1D16510", Length = "0x6C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JValue), Member = ".ctor", MemberParameters = new object[] { typeof(decimal) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static implicit operator JToken(decimal value)
		{
			throw null;
		}

		[CLSCompliant(false)]
		[global::Cpp2ILInjected.Token(Token = "0x60008AE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D1657C", Offset = "0x1D1657C", Length = "0x90")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JValue), Member = ".ctor", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public static implicit operator JToken(short? value)
		{
			throw null;
		}

		[CLSCompliant(false)]
		[global::Cpp2ILInjected.Token(Token = "0x60008AF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D1660C", Offset = "0x1D1660C", Length = "0x90")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JValue), Member = ".ctor", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public static implicit operator JToken(ushort? value)
		{
			throw null;
		}

		[CLSCompliant(false)]
		[global::Cpp2ILInjected.Token(Token = "0x60008B0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D1669C", Offset = "0x1D1669C", Length = "0x90")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JValue), Member = ".ctor", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public static implicit operator JToken(uint? value)
		{
			throw null;
		}

		[CLSCompliant(false)]
		[global::Cpp2ILInjected.Token(Token = "0x60008B1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D1672C", Offset = "0x1D1672C", Length = "0x9C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JValue), Member = ".ctor", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public static implicit operator JToken(ulong? value)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60008B2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D167C8", Offset = "0x1D167C8", Length = "0x64")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JValue), Member = ".ctor", MemberParameters = new object[] { typeof(double) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static implicit operator JToken(double value)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60008B3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D1682C", Offset = "0x1D1682C", Length = "0x64")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JValue), Member = ".ctor", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static implicit operator JToken(float value)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60008B4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D16890", Offset = "0x1D16890", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JValue), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static implicit operator JToken(string value)
		{
			throw null;
		}

		[CLSCompliant(false)]
		[global::Cpp2ILInjected.Token(Token = "0x60008B5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D168EC", Offset = "0x1D168EC", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JValue), Member = ".ctor", MemberParameters = new object[] { typeof(long) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static implicit operator JToken(uint value)
		{
			throw null;
		}

		[CLSCompliant(false)]
		[global::Cpp2ILInjected.Token(Token = "0x60008B6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D16948", Offset = "0x1D16948", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JValue), Member = ".ctor", MemberParameters = new object[] { typeof(ulong) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static implicit operator JToken(ulong value)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60008B7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D169A4", Offset = "0x1D169A4", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JValue), Member = ".ctor", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static implicit operator JToken(byte[] value)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60008B8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D16A00", Offset = "0x1D16A00", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JValue), Member = ".ctor", MemberParameters = new object[] { typeof(Uri) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static implicit operator JToken(Uri value)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60008B9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D16A5C", Offset = "0x1D16A5C", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JValue), Member = ".ctor", MemberParameters = new object[] { typeof(TimeSpan) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static implicit operator JToken(TimeSpan value)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60008BA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D16AB8", Offset = "0x1D16AB8", Length = "0x9C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JValue), Member = ".ctor", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public static implicit operator JToken(TimeSpan? value)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60008BB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D16B54", Offset = "0x1D16B54", Length = "0x6C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JValue), Member = ".ctor", MemberParameters = new object[] { typeof(Guid) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static implicit operator JToken(Guid value)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60008BC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D16BC0", Offset = "0x1D16BC0", Length = "0xA4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JValue), Member = ".ctor", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public static implicit operator JToken(Guid? value)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60008BD")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D16C64", Offset = "0x1D16C64", Length = "0x94")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		private IEnumerator System.Collections.IEnumerable.GetEnumerator()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60008BE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D16CF8", Offset = "0x1D16CF8", Length = "0x70")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JEnumerable<>), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.IEnumerator`1<T>")]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		private IEnumerator<JToken> System.Collections.Generic.IEnumerable<Newtonsoft.Json.Linq.JToken>.GetEnumerator()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60008BF")]
		internal abstract int GetDeepHashCode();

		[global::Cpp2ILInjected.Token(Token = "0x17000196")]
		private IJEnumerable<JToken> Newtonsoft.Json.Linq.IJEnumerable<Newtonsoft.Json.Linq.JToken>.Item
		{
			[global::Cpp2ILInjected.Token(Token = "0x60008C0")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D16D68", Offset = "0x1D16D68", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x60008C1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D16D78", Offset = "0x1D16D78", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonSerializerInternalReader), Member = "CreateObject", MemberParameters = new object[]
		{
			typeof(JsonReader),
			typeof(Type),
			typeof(JsonContract),
			typeof(JsonProperty),
			typeof(JsonContainerContract),
			typeof(JsonProperty),
			typeof(object)
		}, ReturnType = typeof(object))]
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
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonSerializerInternalReader), Member = "CreateISerializableItem", MemberParameters = new object[]
		{
			typeof(JToken),
			typeof(Type),
			typeof(JsonISerializableContract),
			typeof(JsonProperty)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HashSetConverter), Member = "ReadJson", MemberParameters = new object[]
		{
			typeof(JsonReader),
			typeof(Type),
			typeof(object),
			typeof(JsonSerializer)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JTokenReader), Member = ".ctor", MemberParameters = new object[] { typeof(JToken) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public JsonReader CreateReader()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60008C2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D0C630", Offset = "0x1D0C630", Length = "0x204")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JObject), Member = "FromObject", MemberParameters = new object[]
		{
			typeof(object),
			typeof(JsonSerializer)
		}, ReturnType = typeof(JObject))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JArray), Member = "FromObject", MemberParameters = new object[]
		{
			typeof(object),
			typeof(JsonSerializer)
		}, ReturnType = typeof(JArray))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JToken), Member = "FromObject", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(JToken))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JToken), Member = "FromObject", MemberParameters = new object[]
		{
			typeof(object),
			typeof(JsonSerializer)
		}, ReturnType = typeof(JToken))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ValidationUtils), Member = "ArgumentNotNull", MemberParameters = new object[]
		{
			typeof(object),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JTokenWriter), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonSerializer), Member = "Serialize", MemberParameters = new object[]
		{
			typeof(JsonWriter),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 13)]
		internal static JToken FromObjectInternal(object o, JsonSerializer jsonSerializer)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60008C3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D16DD0", Offset = "0x1D16DD0", Length = "0x68")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonSerializer), Member = "CreateDefault", ReturnType = typeof(JsonSerializer))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JToken), Member = "FromObjectInternal", MemberParameters = new object[]
		{
			typeof(object),
			typeof(JsonSerializer)
		}, ReturnType = typeof(JToken))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static JToken FromObject(object o)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60008C4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D16E38", Offset = "0x1D16E38", Length = "0x64")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JToken), Member = "FromObjectInternal", MemberParameters = new object[]
		{
			typeof(object),
			typeof(JsonSerializer)
		}, ReturnType = typeof(JToken))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static JToken FromObject(object o, JsonSerializer jsonSerializer)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60008C5")]
		[global::Cpp2ILInjected.Address(RVA = "0x158C270", Offset = "0x158C270", Length = "0xC4")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(RuntimeTypeHandle) }, ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JToken), Member = "ToObject", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public T ToObject<T>()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60008C6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D16E9C", Offset = "0x1D16E9C", Length = "0xAD4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JToken), Member = "ToObject", MemberTypeParameters = new object[] { "T" }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JValue), Member = "System.IConvertible.ToType", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(IFormatProvider)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonSerializer), Member = "CreateDefault", ReturnType = typeof(JsonSerializer))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JToken), Member = "ToObject", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(JsonSerializer)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ConvertUtils), Member = "GetTypeCode", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(ref bool)
		}, ReturnType = typeof(PrimitiveTypeCode))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TypeExtensions), Member = "IsEnum", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Nullable), Member = "GetUnderlyingType", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Enum), Member = "ToObject", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(object)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JToken), Member = "op_Explicit", MemberParameters = new object[] { typeof(JToken) }, ReturnType = typeof(char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JToken), Member = "op_Explicit", MemberParameters = new object[] { typeof(JToken) }, ReturnType = typeof(ulong))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JToken), Member = "op_Explicit", MemberParameters = new object[] { typeof(JToken) }, ReturnType = typeof(float?))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JToken), Member = "op_Explicit", MemberParameters = new object[] { typeof(JToken) }, ReturnType = typeof(byte?))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JToken), Member = "op_Explicit", MemberParameters = new object[] { typeof(JToken) }, ReturnType = typeof(DateTime?))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JToken), Member = "op_Explicit", MemberParameters = new object[] { typeof(JToken) }, ReturnType = typeof(double?))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JToken), Member = "op_Explicit", MemberParameters = new object[] { typeof(JToken) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JToken), Member = "op_Explicit", MemberParameters = new object[] { typeof(JToken) }, ReturnType = typeof(TimeSpan?))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JToken), Member = "op_Explicit", MemberParameters = new object[] { typeof(JToken) }, ReturnType = typeof(decimal))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JToken), Member = "op_Explicit", MemberParameters = new object[] { typeof(JToken) }, ReturnType = typeof(double))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JToken), Member = "op_Explicit", MemberParameters = new object[] { typeof(JToken) }, ReturnType = typeof(byte))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JToken), Member = "op_Explicit", MemberParameters = new object[] { typeof(JToken) }, ReturnType = typeof(ulong?))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JToken), Member = "op_Explicit", MemberParameters = new object[] { typeof(JToken) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JToken), Member = "op_Explicit", MemberParameters = new object[] { typeof(JToken) }, ReturnType = typeof(decimal?))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JToken), Member = "op_Explicit", MemberParameters = new object[] { typeof(JToken) }, ReturnType = typeof(Guid?))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JToken), Member = "op_Explicit", MemberParameters = new object[] { typeof(JToken) }, ReturnType = typeof(sbyte))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JToken), Member = "op_Explicit", MemberParameters = new object[] { typeof(JToken) }, ReturnType = typeof(int?))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JToken), Member = "op_Explicit", MemberParameters = new object[] { typeof(JToken) }, ReturnType = typeof(DateTime))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JToken), Member = "op_Explicit", MemberParameters = new object[] { typeof(JToken) }, ReturnType = typeof(char?))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JToken), Member = "op_Explicit", MemberParameters = new object[] { typeof(JToken) }, ReturnType = typeof(short))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JToken), Member = "op_Explicit", MemberParameters = new object[] { typeof(JToken) }, ReturnType = typeof(short?))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JToken), Member = "op_Explicit", MemberParameters = new object[] { typeof(JToken) }, ReturnType = typeof(uint))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JToken), Member = "op_Explicit", MemberParameters = new object[] { typeof(JToken) }, ReturnType = typeof(uint?))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JToken), Member = "op_Explicit", MemberParameters = new object[] { typeof(JToken) }, ReturnType = typeof(Guid))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JToken), Member = "op_Explicit", MemberParameters = new object[] { typeof(JToken) }, ReturnType = typeof(bool?))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JToken), Member = "op_Explicit", MemberParameters = new object[] { typeof(JToken) }, ReturnType = typeof(sbyte?))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JToken), Member = "op_Explicit", MemberParameters = new object[] { typeof(JToken) }, ReturnType = typeof(ushort?))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JToken), Member = "op_Explicit", MemberParameters = new object[] { typeof(JToken) }, ReturnType = typeof(ushort))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JToken), Member = "op_Explicit", MemberParameters = new object[] { typeof(JToken) }, ReturnType = typeof(long?))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JToken), Member = "op_Explicit", MemberParameters = new object[] { typeof(JToken) }, ReturnType = typeof(Uri))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JToken), Member = "op_Explicit", MemberParameters = new object[] { typeof(JToken) }, ReturnType = typeof(long))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JToken), Member = "op_Explicit", MemberParameters = new object[] { typeof(JToken) }, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JToken), Member = "op_Explicit", MemberParameters = new object[] { typeof(JToken) }, ReturnType = typeof(DateTimeOffset?))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JToken), Member = "op_Explicit", MemberParameters = new object[] { typeof(JToken) }, ReturnType = typeof(DateTimeOffset))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JToken), Member = "op_Explicit", MemberParameters = new object[] { typeof(JToken) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JToken), Member = "op_Explicit", MemberParameters = new object[] { typeof(JToken) }, ReturnType = typeof(TimeSpan))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringUtils), Member = "FormatWith", MemberParameters = new object[]
		{
			typeof(string),
			typeof(IFormatProvider),
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(Exception)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 102)]
		public object ToObject(Type objectType)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60008C7")]
		[global::Cpp2ILInjected.Address(RVA = "0x158C580", Offset = "0x158C580", Length = "0xCC")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(RuntimeTypeHandle) }, ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JToken), Member = "ToObject", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(JsonSerializer)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public T ToObject<T>(JsonSerializer jsonSerializer)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60008C8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D17970", Offset = "0x1D17970", Length = "0x1D8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JToken), Member = "ToObject", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JToken), Member = "ToObject", MemberTypeParameters = new object[] { "T" }, MemberParameters = new object[] { typeof(JsonSerializer) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ValidationUtils), Member = "ArgumentNotNull", MemberParameters = new object[]
		{
			typeof(object),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JTokenReader), Member = ".ctor", MemberParameters = new object[] { typeof(JToken) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonSerializer), Member = "Deserialize", MemberParameters = new object[]
		{
			typeof(JsonReader),
			typeof(Type)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 12)]
		public object ToObject(Type objectType, JsonSerializer jsonSerializer)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60008C9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D17B48", Offset = "0x1D17B48", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonSerializerInternalReader), Member = "CreateObject", MemberParameters = new object[]
		{
			typeof(JsonReader),
			typeof(Type),
			typeof(JsonContract),
			typeof(JsonProperty),
			typeof(JsonContainerContract),
			typeof(JsonProperty),
			typeof(object)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonSerializerInternalReader), Member = "CreateISerializable", MemberParameters = new object[]
		{
			typeof(JsonReader),
			typeof(JsonISerializableContract),
			typeof(JsonProperty),
			typeof(string)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonSerializerInternalReader), Member = "ReadExtensionDataValue", MemberParameters = new object[]
		{
			typeof(JsonObjectContract),
			typeof(JsonProperty),
			typeof(JsonReader)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static JToken ReadFrom(JsonReader reader)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60008CA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D17BA0", Offset = "0x1D17BA0", Length = "0x2A8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JToken), Member = "Load", MemberParameters = new object[]
		{
			typeof(JsonReader),
			typeof(JsonLoadSettings)
		}, ReturnType = typeof(JToken))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ValidationUtils), Member = "ArgumentNotNull", MemberParameters = new object[]
		{
			typeof(object),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JValue), Member = ".ctor", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JToken), Member = "SetLineInfo", MemberParameters = new object[]
		{
			typeof(IJsonLineInfo),
			typeof(JsonLoadSettings)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonReader), Member = "ReadAndMoveToContent", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JValue), Member = "CreateNull", ReturnType = typeof(JValue))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JValue), Member = "CreateUndefined", ReturnType = typeof(JValue))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JArray), Member = "Load", MemberParameters = new object[]
		{
			typeof(JsonReader),
			typeof(JsonLoadSettings)
		}, ReturnType = typeof(JArray))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JObject), Member = "Load", MemberParameters = new object[]
		{
			typeof(JsonReader),
			typeof(JsonLoadSettings)
		}, ReturnType = typeof(JObject))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JConstructor), Member = "Load", MemberParameters = new object[]
		{
			typeof(JsonReader),
			typeof(JsonLoadSettings)
		}, ReturnType = typeof(JConstructor))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JProperty), Member = "Load", MemberParameters = new object[]
		{
			typeof(JsonReader),
			typeof(JsonLoadSettings)
		}, ReturnType = typeof(JProperty))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JValue), Member = "CreateComment", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(JValue))]
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
		public static JToken ReadFrom(JsonReader reader, JsonLoadSettings settings)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60008CB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D17E48", Offset = "0x1D17E48", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static JToken Parse(string json)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60008CC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D17EA0", Offset = "0x1D17EA0", Length = "0x26C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringReader), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonTextReader), Member = ".ctor", MemberParameters = new object[] { typeof(TextReader) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JToken), Member = "Load", MemberParameters = new object[]
		{
			typeof(JsonReader),
			typeof(JsonLoadSettings)
		}, ReturnType = typeof(JToken))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonReaderException), Member = "Create", MemberParameters = new object[]
		{
			typeof(JsonReader),
			typeof(string)
		}, ReturnType = typeof(JsonReaderException))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 18)]
		public static JToken Parse(string json, JsonLoadSettings settings)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60008CD")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D1810C", Offset = "0x1D1810C", Length = "0x64")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JToken), Member = "Parse", MemberParameters = new object[]
		{
			typeof(string),
			typeof(JsonLoadSettings)
		}, ReturnType = typeof(JToken))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JToken), Member = "Load", MemberParameters = new object[] { typeof(JsonReader) }, ReturnType = typeof(JToken))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JToken), Member = "ReadFrom", MemberParameters = new object[]
		{
			typeof(JsonReader),
			typeof(JsonLoadSettings)
		}, ReturnType = typeof(JToken))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static JToken Load(JsonReader reader, JsonLoadSettings settings)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60008CE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D18170", Offset = "0x1D18170", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JToken), Member = "Load", MemberParameters = new object[]
		{
			typeof(JsonReader),
			typeof(JsonLoadSettings)
		}, ReturnType = typeof(JToken))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static JToken Load(JsonReader reader)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60008CF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D06F44", Offset = "0x1D06F44", Length = "0x1A0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
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
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JToken), Member = "ReadFrom", MemberParameters = new object[]
		{
			typeof(JsonReader),
			typeof(JsonLoadSettings)
		}, ReturnType = typeof(JToken))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JProperty), Member = "Load", MemberParameters = new object[]
		{
			typeof(JsonReader),
			typeof(JsonLoadSettings)
		}, ReturnType = typeof(JProperty))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 11)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JToken), Member = "SetLineInfo", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		internal void SetLineInfo(IJsonLineInfo lineInfo, JsonLoadSettings settings)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60008D0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D181C8", Offset = "0x1D181C8", Length = "0x70")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JToken), Member = "SetLineInfo", MemberParameters = new object[]
		{
			typeof(IJsonLineInfo),
			typeof(JsonLoadSettings)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JToken), Member = "AddAnnotation", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal void SetLineInfo(int lineNumber, int linePosition)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60008D1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D1843C", Offset = "0x1D1843C", Length = "0x54")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JToken), Member = "Annotation", MemberTypeParameters = new object[] { "T" }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		private bool Newtonsoft.Json.IJsonLineInfo.HasLineInfo()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000197")]
		private int Newtonsoft.Json.IJsonLineInfo.LineNumber
		{
			[global::Cpp2ILInjected.Token(Token = "0x60008D2")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D18490", Offset = "0x1D18490", Length = "0x54")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JToken), Member = "Annotation", MemberTypeParameters = new object[] { "T" }, ReturnType = "T")]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000198")]
		private int Newtonsoft.Json.IJsonLineInfo.LinePosition
		{
			[global::Cpp2ILInjected.Token(Token = "0x60008D3")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D184E4", Offset = "0x1D184E4", Length = "0x54")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JToken), Member = "Annotation", MemberTypeParameters = new object[] { "T" }, ReturnType = "T")]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x60008D4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D18538", Offset = "0x1D18538", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public JToken SelectToken(string path)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60008D5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D18540", Offset = "0x1D18540", Length = "0x358")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JPath), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JPath), Member = "Evaluate", MemberParameters = new object[]
		{
			typeof(JToken),
			typeof(bool)
		}, ReturnType = typeof(IEnumerable<JToken>))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 22)]
		public JToken SelectToken(string path, bool errorWhenNoMatch)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60008D6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D18898", Offset = "0x1D18898", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public IEnumerable<JToken> SelectTokens(string path)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60008D7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D188A0", Offset = "0x1D188A0", Length = "0x78")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JPath), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JPath), Member = "Evaluate", MemberParameters = new object[]
		{
			typeof(JToken),
			typeof(bool)
		}, ReturnType = typeof(IEnumerable<JToken>))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public IEnumerable<JToken> SelectTokens(string path, bool errorWhenNoMatch)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60008D8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D18918", Offset = "0x1D18918", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		private object System.ICloneable.Clone()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60008D9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D18924", Offset = "0x1D18924", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public JToken DeepClone()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60008DA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D18264", Offset = "0x1D18264", Length = "0x1D8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JToken), Member = "SetLineInfo", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Array[]), Member = "Resize", MemberTypeParameters = new object[] { typeof(object) }, MemberParameters = new object[]
		{
			typeof(ref object[]),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 17)]
		public void AddAnnotation(object annotation)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60008DB")]
		[global::Cpp2ILInjected.Address(RVA = "0x158BEB0", Offset = "0x158BEB0", Length = "0x16C")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JToken), Member = "Newtonsoft.Json.IJsonLineInfo.HasLineInfo", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JToken), Member = "Newtonsoft.Json.IJsonLineInfo.get_LineNumber", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JToken), Member = "Newtonsoft.Json.IJsonLineInfo.get_LinePosition", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 12)]
		public T Annotation<T>() where T : class
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60008DC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D18930", Offset = "0x1D18930", Length = "0x128")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public object Annotation(Type type)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60008DD")]
		[global::Cpp2ILInjected.Address(RVA = "0x158C01C", Offset = "0x158C01C", Length = "0x60")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public IEnumerable<T> Annotations<T>() where T : class
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60008DE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D18A58", Offset = "0x1D18A58", Length = "0x6C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JToken.<Annotations>d__172), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public IEnumerable<object> Annotations(Type type)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60008DF")]
		[global::Cpp2ILInjected.Address(RVA = "0x158C120", Offset = "0x158C120", Length = "0x150")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		public void RemoveAnnotations<T>() where T : class
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60008E0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D18AC4", Offset = "0x1D18AC4", Length = "0x180")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
		public void RemoveAnnotations(Type type)
		{
			throw null;
		}

		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x60008E1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D18C44", Offset = "0x1D18C44", Length = "0x1E4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
		static JToken()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x400033C")]
		private static JTokenEqualityComparer _equalityComparer;

		[global::Cpp2ILInjected.Token(Token = "0x400033D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private JContainer _parent;

		[global::Cpp2ILInjected.Token(Token = "0x400033E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private JToken _previous;

		[global::Cpp2ILInjected.Token(Token = "0x400033F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private JToken _next;

		[global::Cpp2ILInjected.Token(Token = "0x4000340")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private object _annotations;

		[global::Cpp2ILInjected.Token(Token = "0x4000341")]
		private static readonly JTokenType[] BooleanTypes;

		[global::Cpp2ILInjected.Token(Token = "0x4000342")]
		private static readonly JTokenType[] NumberTypes;

		[global::Cpp2ILInjected.Token(Token = "0x4000343")]
		private static readonly JTokenType[] StringTypes;

		[global::Cpp2ILInjected.Token(Token = "0x4000344")]
		private static readonly JTokenType[] GuidTypes;

		[global::Cpp2ILInjected.Token(Token = "0x4000345")]
		private static readonly JTokenType[] TimeSpanTypes;

		[global::Cpp2ILInjected.Token(Token = "0x4000346")]
		private static readonly JTokenType[] UriTypes;

		[global::Cpp2ILInjected.Token(Token = "0x4000347")]
		private static readonly JTokenType[] CharTypes;

		[global::Cpp2ILInjected.Token(Token = "0x4000348")]
		private static readonly JTokenType[] DateTimeTypes;

		[global::Cpp2ILInjected.Token(Token = "0x4000349")]
		private static readonly JTokenType[] BytesTypes;

		[global::Cpp2ILInjected.Token(Token = "0x20000D6")]
		private class LineInfoAnnotation
		{
			[global::Cpp2ILInjected.Token(Token = "0x60008E2")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D18238", Offset = "0x1D18238", Length = "0x2C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public LineInfoAnnotation(int lineNumber, int linePosition)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x400034A")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			internal readonly int LineNumber;

			[global::Cpp2ILInjected.Token(Token = "0x400034B")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
			internal readonly int LinePosition;
		}

		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x20000D7")]
		private sealed class <GetAncestors>d__41 : IEnumerable<JToken>, IEnumerable, IEnumerator<JToken>, IDisposable, IEnumerator
		{
			[DebuggerHidden]
			[global::Cpp2ILInjected.Token(Token = "0x60008E3")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D10ED0", Offset = "0x1D10ED0", Length = "0x3C")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JToken.<GetAncestors>d__41), Member = "System.Collections.Generic.IEnumerable<Newtonsoft.Json.Linq.JToken>.GetEnumerator", ReturnType = typeof(IEnumerator<JToken>))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JToken), Member = "GetAncestors", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(IEnumerable<JToken>))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Thread), Member = "get_CurrentThread", ReturnType = typeof(Thread))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Thread), Member = "get_ManagedThreadId", ReturnType = typeof(int))]
			public <GetAncestors>d__41(int <>1__state)
			{
				throw null;
			}

			[DebuggerHidden]
			[global::Cpp2ILInjected.Token(Token = "0x60008E4")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D18E28", Offset = "0x1D18E28", Length = "0x4")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			private void System.IDisposable.Dispose()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x60008E5")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D18E2C", Offset = "0x1D18E2C", Length = "0x70")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			private bool MoveNext()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x17000199")]
			private JToken System.Collections.Generic.IEnumerator<Newtonsoft.Json.Linq.JToken>.Current
			{
				[DebuggerHidden]
				[global::Cpp2ILInjected.Token(Token = "0x60008E6")]
				[global::Cpp2ILInjected.Address(RVA = "0x1D18E9C", Offset = "0x1D18E9C", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				get
				{
					throw null;
				}
			}

			[DebuggerHidden]
			[global::Cpp2ILInjected.Token(Token = "0x60008E7")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D18EA4", Offset = "0x1D18EA4", Length = "0x38")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			private void System.Collections.IEnumerator.Reset()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x1700019A")]
			private object System.Collections.IEnumerator.Current
			{
				[DebuggerHidden]
				[global::Cpp2ILInjected.Token(Token = "0x60008E8")]
				[global::Cpp2ILInjected.Address(RVA = "0x1D18EDC", Offset = "0x1D18EDC", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				get
				{
					throw null;
				}
			}

			[DebuggerHidden]
			[global::Cpp2ILInjected.Token(Token = "0x60008E9")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D18EE4", Offset = "0x1D18EE4", Length = "0x9C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JToken.<GetAncestors>d__41), Member = "System.Collections.IEnumerable.GetEnumerator", ReturnType = typeof(IEnumerator))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Thread), Member = "get_CurrentThread", ReturnType = typeof(Thread))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Thread), Member = "get_ManagedThreadId", ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JToken.<GetAncestors>d__41), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			private IEnumerator<JToken> System.Collections.Generic.IEnumerable<Newtonsoft.Json.Linq.JToken>.GetEnumerator()
			{
				throw null;
			}

			[DebuggerHidden]
			[global::Cpp2ILInjected.Token(Token = "0x60008EA")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D18F80", Offset = "0x1D18F80", Length = "0x1004")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JToken.<GetAncestors>d__41), Member = "System.Collections.Generic.IEnumerable<Newtonsoft.Json.Linq.JToken>.GetEnumerator", ReturnType = typeof(IEnumerator<JToken>))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			private IEnumerator System.Collections.IEnumerable.GetEnumerator()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x400034C")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[global::Cpp2ILInjected.Token(Token = "0x400034D")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
			private JToken <>2__current;

			[global::Cpp2ILInjected.Token(Token = "0x400034E")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
			private int <>l__initialThreadId;

			[global::Cpp2ILInjected.Token(Token = "0x400034F")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x24")]
			private bool self;

			[global::Cpp2ILInjected.Token(Token = "0x4000350")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x25")]
			public bool <>3__self;

			[global::Cpp2ILInjected.Token(Token = "0x4000351")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
			public JToken <>4__this;

			[global::Cpp2ILInjected.Token(Token = "0x4000352")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
			private JToken <current>5__1;
		}

		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x20000D8")]
		private sealed class <AfterSelf>d__42 : IEnumerable<JToken>, IEnumerable, IEnumerator<JToken>, IDisposable, IEnumerator
		{
			[DebuggerHidden]
			[global::Cpp2ILInjected.Token(Token = "0x60008EB")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D19F84", Offset = "0x1D19F84", Length = "0x3C")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JToken.<AfterSelf>d__42), Member = "System.Collections.Generic.IEnumerable<Newtonsoft.Json.Linq.JToken>.GetEnumerator", ReturnType = typeof(IEnumerator<JToken>))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JToken), Member = "AfterSelf", ReturnType = typeof(IEnumerable<JToken>))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Thread), Member = "get_CurrentThread", ReturnType = typeof(Thread))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Thread), Member = "get_ManagedThreadId", ReturnType = typeof(int))]
			public <AfterSelf>d__42(int <>1__state)
			{
				throw null;
			}

			[DebuggerHidden]
			[global::Cpp2ILInjected.Token(Token = "0x60008EC")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D19FC0", Offset = "0x1D19FC0", Length = "0x4")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			private void System.IDisposable.Dispose()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x60008ED")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D19FC4", Offset = "0x1D19FC4", Length = "0x6C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			private bool MoveNext()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x1700019B")]
			private JToken System.Collections.Generic.IEnumerator<Newtonsoft.Json.Linq.JToken>.Current
			{
				[DebuggerHidden]
				[global::Cpp2ILInjected.Token(Token = "0x60008EE")]
				[global::Cpp2ILInjected.Address(RVA = "0x1D1A030", Offset = "0x1D1A030", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				get
				{
					throw null;
				}
			}

			[DebuggerHidden]
			[global::Cpp2ILInjected.Token(Token = "0x60008EF")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D1A038", Offset = "0x1D1A038", Length = "0x38")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			private void System.Collections.IEnumerator.Reset()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x1700019C")]
			private object System.Collections.IEnumerator.Current
			{
				[DebuggerHidden]
				[global::Cpp2ILInjected.Token(Token = "0x60008F0")]
				[global::Cpp2ILInjected.Address(RVA = "0x1D1A070", Offset = "0x1D1A070", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				get
				{
					throw null;
				}
			}

			[DebuggerHidden]
			[global::Cpp2ILInjected.Token(Token = "0x60008F1")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D1A078", Offset = "0x1D1A078", Length = "0x94")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JToken.<AfterSelf>d__42), Member = "System.Collections.IEnumerable.GetEnumerator", ReturnType = typeof(IEnumerator))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Thread), Member = "get_CurrentThread", ReturnType = typeof(Thread))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Thread), Member = "get_ManagedThreadId", ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JToken.<AfterSelf>d__42), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			private IEnumerator<JToken> System.Collections.Generic.IEnumerable<Newtonsoft.Json.Linq.JToken>.GetEnumerator()
			{
				throw null;
			}

			[DebuggerHidden]
			[global::Cpp2ILInjected.Token(Token = "0x60008F2")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D1A10C", Offset = "0x1D1A10C", Length = "0x4")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JToken.<AfterSelf>d__42), Member = "System.Collections.Generic.IEnumerable<Newtonsoft.Json.Linq.JToken>.GetEnumerator", ReturnType = typeof(IEnumerator<JToken>))]
			private IEnumerator System.Collections.IEnumerable.GetEnumerator()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x4000353")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[global::Cpp2ILInjected.Token(Token = "0x4000354")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
			private JToken <>2__current;

			[global::Cpp2ILInjected.Token(Token = "0x4000355")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
			private int <>l__initialThreadId;

			[global::Cpp2ILInjected.Token(Token = "0x4000356")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
			public JToken <>4__this;

			[global::Cpp2ILInjected.Token(Token = "0x4000357")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
			private JToken <o>5__1;
		}

		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x20000D9")]
		private sealed class <BeforeSelf>d__43 : IEnumerable<JToken>, IEnumerable, IEnumerator<JToken>, IDisposable, IEnumerator
		{
			[DebuggerHidden]
			[global::Cpp2ILInjected.Token(Token = "0x60008F3")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D1A110", Offset = "0x1D1A110", Length = "0x3C")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JToken.<BeforeSelf>d__43), Member = "System.Collections.Generic.IEnumerable<Newtonsoft.Json.Linq.JToken>.GetEnumerator", ReturnType = typeof(IEnumerator<JToken>))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JToken), Member = "BeforeSelf", ReturnType = typeof(IEnumerable<JToken>))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Thread), Member = "get_CurrentThread", ReturnType = typeof(Thread))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Thread), Member = "get_ManagedThreadId", ReturnType = typeof(int))]
			public <BeforeSelf>d__43(int <>1__state)
			{
				throw null;
			}

			[DebuggerHidden]
			[global::Cpp2ILInjected.Token(Token = "0x60008F4")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D1A14C", Offset = "0x1D1A14C", Length = "0x4")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			private void System.IDisposable.Dispose()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x60008F5")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D1A150", Offset = "0x1D1A150", Length = "0x84")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			private bool MoveNext()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x1700019D")]
			private JToken System.Collections.Generic.IEnumerator<Newtonsoft.Json.Linq.JToken>.Current
			{
				[DebuggerHidden]
				[global::Cpp2ILInjected.Token(Token = "0x60008F6")]
				[global::Cpp2ILInjected.Address(RVA = "0x1D1A1D4", Offset = "0x1D1A1D4", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				get
				{
					throw null;
				}
			}

			[DebuggerHidden]
			[global::Cpp2ILInjected.Token(Token = "0x60008F7")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D1A1DC", Offset = "0x1D1A1DC", Length = "0x38")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			private void System.Collections.IEnumerator.Reset()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x1700019E")]
			private object System.Collections.IEnumerator.Current
			{
				[DebuggerHidden]
				[global::Cpp2ILInjected.Token(Token = "0x60008F8")]
				[global::Cpp2ILInjected.Address(RVA = "0x1D1A214", Offset = "0x1D1A214", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				get
				{
					throw null;
				}
			}

			[DebuggerHidden]
			[global::Cpp2ILInjected.Token(Token = "0x60008F9")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D1A21C", Offset = "0x1D1A21C", Length = "0x94")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JToken.<BeforeSelf>d__43), Member = "System.Collections.IEnumerable.GetEnumerator", ReturnType = typeof(IEnumerator))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Thread), Member = "get_CurrentThread", ReturnType = typeof(Thread))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Thread), Member = "get_ManagedThreadId", ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JToken.<BeforeSelf>d__43), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			private IEnumerator<JToken> System.Collections.Generic.IEnumerable<Newtonsoft.Json.Linq.JToken>.GetEnumerator()
			{
				throw null;
			}

			[DebuggerHidden]
			[global::Cpp2ILInjected.Token(Token = "0x60008FA")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D1A2B0", Offset = "0x1D1A2B0", Length = "0x4")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JToken.<BeforeSelf>d__43), Member = "System.Collections.Generic.IEnumerable<Newtonsoft.Json.Linq.JToken>.GetEnumerator", ReturnType = typeof(IEnumerator<JToken>))]
			private IEnumerator System.Collections.IEnumerable.GetEnumerator()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x4000358")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[global::Cpp2ILInjected.Token(Token = "0x4000359")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
			private JToken <>2__current;

			[global::Cpp2ILInjected.Token(Token = "0x400035A")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
			private int <>l__initialThreadId;

			[global::Cpp2ILInjected.Token(Token = "0x400035B")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
			public JToken <>4__this;

			[global::Cpp2ILInjected.Token(Token = "0x400035C")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
			private JToken <o>5__1;
		}

		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x20000DA")]
		private sealed class <Annotations>d__171<T> : IEnumerable<T>, IEnumerable, IEnumerator<T>, IDisposable, IEnumerator where T : class
		{
			[DebuggerHidden]
			[global::Cpp2ILInjected.Token(Token = "0x60008FB")]
			[global::Cpp2ILInjected.Address(RVA = "0x15B6A98", Offset = "0x15B6A98", Length = "0x3C")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Thread), Member = "get_CurrentThread", ReturnType = typeof(Thread))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Thread), Member = "get_ManagedThreadId", ReturnType = typeof(int))]
			public <Annotations>d__171(int <>1__state)
			{
				throw null;
			}

			[DebuggerHidden]
			[global::Cpp2ILInjected.Token(Token = "0x60008FC")]
			[global::Cpp2ILInjected.Address(RVA = "0x15B6AD4", Offset = "0x15B6AD4", Length = "0x4")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			private void System.IDisposable.Dispose()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x60008FD")]
			[global::Cpp2ILInjected.Address(RVA = "0x15B6AD8", Offset = "0x15B6AD8", Length = "0x1F8")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 13)]
			private bool MoveNext()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x1700019F")]
			private T System.Collections.Generic.IEnumerator<T>.Current
			{
				[DebuggerHidden]
				[global::Cpp2ILInjected.Token(Token = "0x60008FE")]
				[global::Cpp2ILInjected.Address(RVA = "0x15B6CD0", Offset = "0x15B6CD0", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				get
				{
					throw null;
				}
			}

			[DebuggerHidden]
			[global::Cpp2ILInjected.Token(Token = "0x60008FF")]
			[global::Cpp2ILInjected.Address(RVA = "0x15B6CD8", Offset = "0x15B6CD8", Length = "0x38")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			private void System.Collections.IEnumerator.Reset()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x170001A0")]
			private object System.Collections.IEnumerator.Current
			{
				[DebuggerHidden]
				[global::Cpp2ILInjected.Token(Token = "0x6000900")]
				[global::Cpp2ILInjected.Address(RVA = "0x15B6D10", Offset = "0x15B6D10", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				get
				{
					throw null;
				}
			}

			[DebuggerHidden]
			[global::Cpp2ILInjected.Token(Token = "0x6000901")]
			[global::Cpp2ILInjected.Address(RVA = "0x15B6D18", Offset = "0x15B6D18", Length = "0x94")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Thread), Member = "get_CurrentThread", ReturnType = typeof(Thread))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Thread), Member = "get_ManagedThreadId", ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			private IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator()
			{
				throw null;
			}

			[DebuggerHidden]
			[global::Cpp2ILInjected.Token(Token = "0x6000902")]
			[global::Cpp2ILInjected.Address(RVA = "0x15B6DAC", Offset = "0x15B6DAC", Length = "0x14")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			private IEnumerator System.Collections.IEnumerable.GetEnumerator()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x400035D")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			private int <>1__state;

			[global::Cpp2ILInjected.Token(Token = "0x400035E")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			private T <>2__current;

			[global::Cpp2ILInjected.Token(Token = "0x400035F")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			private int <>l__initialThreadId;

			[global::Cpp2ILInjected.Token(Token = "0x4000360")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			public JToken <>4__this;

			[global::Cpp2ILInjected.Token(Token = "0x4000361")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			private object[] <annotations>5__1;

			[global::Cpp2ILInjected.Token(Token = "0x4000362")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			private int <i>5__2;
		}

		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x20000DB")]
		private sealed class <Annotations>d__172 : IEnumerable<object>, IEnumerable, IEnumerator<object>, IDisposable, IEnumerator
		{
			[DebuggerHidden]
			[global::Cpp2ILInjected.Token(Token = "0x6000903")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D1A2B4", Offset = "0x1D1A2B4", Length = "0x3C")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JToken.<Annotations>d__172), Member = "System.Collections.Generic.IEnumerable<System.Object>.GetEnumerator", ReturnType = typeof(IEnumerator<object>))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JToken), Member = "Annotations", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(IEnumerable<object>))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Thread), Member = "get_CurrentThread", ReturnType = typeof(Thread))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Thread), Member = "get_ManagedThreadId", ReturnType = typeof(int))]
			public <Annotations>d__172(int <>1__state)
			{
				throw null;
			}

			[DebuggerHidden]
			[global::Cpp2ILInjected.Token(Token = "0x6000904")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D1A2F0", Offset = "0x1D1A2F0", Length = "0x4")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			private void System.IDisposable.Dispose()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6000905")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D1A2F4", Offset = "0x1D1A2F4", Length = "0x1A0")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
			private bool MoveNext()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x170001A1")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[DebuggerHidden]
				[global::Cpp2ILInjected.Token(Token = "0x6000906")]
				[global::Cpp2ILInjected.Address(RVA = "0x1D1A494", Offset = "0x1D1A494", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				get
				{
					throw null;
				}
			}

			[DebuggerHidden]
			[global::Cpp2ILInjected.Token(Token = "0x6000907")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D1A49C", Offset = "0x1D1A49C", Length = "0x38")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			private void System.Collections.IEnumerator.Reset()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x170001A2")]
			private object System.Collections.IEnumerator.Current
			{
				[DebuggerHidden]
				[global::Cpp2ILInjected.Token(Token = "0x6000908")]
				[global::Cpp2ILInjected.Address(RVA = "0x1D1A4D4", Offset = "0x1D1A4D4", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				get
				{
					throw null;
				}
			}

			[DebuggerHidden]
			[global::Cpp2ILInjected.Token(Token = "0x6000909")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D1A4DC", Offset = "0x1D1A4DC", Length = "0x9C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JToken.<Annotations>d__172), Member = "System.Collections.IEnumerable.GetEnumerator", ReturnType = typeof(IEnumerator))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Thread), Member = "get_CurrentThread", ReturnType = typeof(Thread))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Thread), Member = "get_ManagedThreadId", ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JToken.<Annotations>d__172), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			private IEnumerator<object> System.Collections.Generic.IEnumerable<System.Object>.GetEnumerator()
			{
				throw null;
			}

			[DebuggerHidden]
			[global::Cpp2ILInjected.Token(Token = "0x600090A")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D1A578", Offset = "0x1D1A578", Length = "0x4")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JToken.<Annotations>d__172), Member = "System.Collections.Generic.IEnumerable<System.Object>.GetEnumerator", ReturnType = typeof(IEnumerator<object>))]
			private IEnumerator System.Collections.IEnumerable.GetEnumerator()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x4000363")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[global::Cpp2ILInjected.Token(Token = "0x4000364")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[global::Cpp2ILInjected.Token(Token = "0x4000365")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
			private int <>l__initialThreadId;

			[global::Cpp2ILInjected.Token(Token = "0x4000366")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
			private Type type;

			[global::Cpp2ILInjected.Token(Token = "0x4000367")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
			public Type <>3__type;

			[global::Cpp2ILInjected.Token(Token = "0x4000368")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
			public JToken <>4__this;

			[global::Cpp2ILInjected.Token(Token = "0x4000369")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
			private object[] <annotations>5__1;

			[global::Cpp2ILInjected.Token(Token = "0x400036A")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
			private int <i>5__2;
		}
	}
}
