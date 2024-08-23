using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Net
{
	// Token: 0x020000D6 RID: 214
	[global::Cpp2ILInjected.Token(Token = "0x200013B")]
	internal sealed class TrackingValidationObjectDictionary : StringDictionary
	{
		// Token: 0x060006BE RID: 1726 RVA: 0x0000418D File Offset: 0x0000238D
		[global::Cpp2ILInjected.Token(Token = "0x600077F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EE7FEC", Offset = "0x1EE7FEC", Length = "0x2C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringDictionary), Member = ".ctor", ReturnType = typeof(void))]
		internal TrackingValidationObjectDictionary(Dictionary<string, TrackingValidationObjectDictionary.ValidateAndParseValue> validators)
		{
			throw null;
		}

		// Token: 0x060006BF RID: 1727 RVA: 0x00004190 File Offset: 0x00002390
		[global::Cpp2ILInjected.Token(Token = "0x6000780")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EE8018", Offset = "0x1EE8018", Length = "0x1C0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TrackingValidationObjectDictionary), Member = "set_Item", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TrackingValidationObjectDictionary), Member = "Add", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "ToLowerInvariant", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>), Member = "TryGetValue", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>), Member = "Add", MemberParameters = new object[]
		{
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringDictionary), Member = "Add", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>), Member = "set_Item", MemberParameters = new object[]
		{
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringDictionary), Member = "set_Item", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		private void PersistValue(string key, string value, bool addValue)
		{
			throw null;
		}

		// Token: 0x17000186 RID: 390
		// (get) Token: 0x060006C0 RID: 1728 RVA: 0x00004193 File Offset: 0x00002393
		// (set) Token: 0x060006C1 RID: 1729 RVA: 0x00004196 File Offset: 0x00002396
		[global::Cpp2ILInjected.Token(Token = "0x17000190")]
		internal bool IsChanged
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6000781")]
			[global::Cpp2ILInjected.Address(RVA = "0x1EE81D8", Offset = "0x1EE81D8", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6000782")]
			[global::Cpp2ILInjected.Address(RVA = "0x1EE81E0", Offset = "0x1EE81E0", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x060006C2 RID: 1730 RVA: 0x00004199 File Offset: 0x00002399
		[global::Cpp2ILInjected.Token(Token = "0x6000783")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EE81EC", Offset = "0x1EE81EC", Length = "0x84")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>), Member = "TryGetValue", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringDictionary), Member = "get_Item", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		internal object InternalGet(string key)
		{
			throw null;
		}

		// Token: 0x060006C3 RID: 1731 RVA: 0x0000419C File Offset: 0x0000239C
		[global::Cpp2ILInjected.Token(Token = "0x6000784")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EE8270", Offset = "0x1EE8270", Length = "0xD8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>), Member = "set_Item", MemberParameters = new object[]
		{
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringDictionary), Member = "set_Item", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		internal void InternalSet(string key, object value)
		{
			throw null;
		}

		// Token: 0x17000187 RID: 391
		[global::Cpp2ILInjected.Token(Token = "0x17000191")]
		public override string this[string key]
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000785")]
			[global::Cpp2ILInjected.Address(RVA = "0x1EE8348", Offset = "0x1EE8348", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringDictionary), Member = "get_Item", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000786")]
			[global::Cpp2ILInjected.Address(RVA = "0x1EE8350", Offset = "0x1EE8350", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TrackingValidationObjectDictionary), Member = "PersistValue", MemberParameters = new object[]
			{
				typeof(string),
				typeof(string),
				typeof(bool)
			}, ReturnType = typeof(void))]
			set
			{
				throw null;
			}
		}

		// Token: 0x060006C6 RID: 1734 RVA: 0x000041A5 File Offset: 0x000023A5
		[global::Cpp2ILInjected.Token(Token = "0x6000787")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EE8358", Offset = "0x1EE8358", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TrackingValidationObjectDictionary), Member = "PersistValue", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(bool)
		}, ReturnType = typeof(void))]
		public override void Add(string key, string value)
		{
			throw null;
		}

		// Token: 0x060006C7 RID: 1735 RVA: 0x000041A8 File Offset: 0x000023A8
		[global::Cpp2ILInjected.Token(Token = "0x6000788")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EE8360", Offset = "0x1EE8360", Length = "0x64")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>), Member = "Clear", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringDictionary), Member = "Clear", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override void Clear()
		{
			throw null;
		}

		// Token: 0x060006C8 RID: 1736 RVA: 0x000041AB File Offset: 0x000023AB
		[global::Cpp2ILInjected.Token(Token = "0x6000789")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EE83C4", Offset = "0x1EE83C4", Length = "0x70")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>), Member = "Remove", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringDictionary), Member = "Remove", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override void Remove(string key)
		{
			throw null;
		}

		// Token: 0x04000469 RID: 1129
		[global::Cpp2ILInjected.Token(Token = "0x40005EF")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private readonly Dictionary<string, TrackingValidationObjectDictionary.ValidateAndParseValue> _validators;

		// Token: 0x0400046A RID: 1130
		[global::Cpp2ILInjected.Token(Token = "0x40005F0")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private Dictionary<string, object> _internalObjects;

		// Token: 0x0400046B RID: 1131
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x40005F1")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private bool <IsChanged>k__BackingField;

		// Token: 0x020003CD RID: 973
		// (Invoke) Token: 0x06001D66 RID: 7526
		[global::Cpp2ILInjected.Token(Token = "0x200013C")]
		internal delegate object ValidateAndParseValue(object valueToValidate);
	}
}
