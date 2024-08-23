using System;
using System.Collections.Generic;
using System.Net;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Collections.Specialized
{
	// Token: 0x02000309 RID: 777
	[global::Cpp2ILInjected.Token(Token = "0x2000422")]
	[Serializable]
	public class StringDictionary : IEnumerable
	{
		// Token: 0x060019A7 RID: 6567 RVA: 0x00007652 File Offset: 0x00005852
		[global::Cpp2ILInjected.Token(Token = "0x6001CA4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E90F44", Offset = "0x1E90F44", Length = "0x60")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TrackingStringDictionary), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TrackingStringDictionary), Member = ".ctor", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TrackingValidationObjectDictionary), Member = ".ctor", MemberParameters = new object[] { typeof(Dictionary<string, TrackingValidationObjectDictionary.ValidateAndParseValue>) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CaseSensitiveStringDictionary), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Hashtable), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public StringDictionary()
		{
			throw null;
		}

		// Token: 0x1700061B RID: 1563
		[global::Cpp2ILInjected.Token(Token = "0x1700066C")]
		public virtual string this[string key]
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001CA5")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E90FA4", Offset = "0x1E90FA4", Length = "0xD0")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TrackingStringDictionary), Member = "get_Item", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TrackingValidationObjectDictionary), Member = "InternalGet", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(object))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TrackingValidationObjectDictionary), Member = "get_Item", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "ToLowerInvariant", ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6001CA6")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E91074", Offset = "0x1E91074", Length = "0x8C")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TrackingStringDictionary), Member = "set_Item", MemberParameters = new object[]
			{
				typeof(string),
				typeof(string)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TrackingValidationObjectDictionary), Member = "PersistValue", MemberParameters = new object[]
			{
				typeof(string),
				typeof(string),
				typeof(bool)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TrackingValidationObjectDictionary), Member = "InternalSet", MemberParameters = new object[]
			{
				typeof(string),
				typeof(object)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "ToLowerInvariant", ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
			set
			{
				throw null;
			}
		}

		// Token: 0x060019AA RID: 6570 RVA: 0x0000765B File Offset: 0x0000585B
		[global::Cpp2ILInjected.Token(Token = "0x6001CA7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E91100", Offset = "0x1E91100", Length = "0x8C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TrackingStringDictionary), Member = "Add", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TrackingValidationObjectDictionary), Member = "PersistValue", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "ToLowerInvariant", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public virtual void Add(string key, string value)
		{
			throw null;
		}

		// Token: 0x060019AB RID: 6571 RVA: 0x0000765E File Offset: 0x0000585E
		[global::Cpp2ILInjected.Token(Token = "0x6001CA8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E9118C", Offset = "0x1E9118C", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TrackingStringDictionary), Member = "Clear", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TrackingValidationObjectDictionary), Member = "Clear", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public virtual void Clear()
		{
			throw null;
		}

		// Token: 0x060019AC RID: 6572 RVA: 0x00007661 File Offset: 0x00005861
		[global::Cpp2ILInjected.Token(Token = "0x6001CA9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E911A0", Offset = "0x1E911A0", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public virtual IEnumerator GetEnumerator()
		{
			throw null;
		}

		// Token: 0x060019AD RID: 6573 RVA: 0x00007664 File Offset: 0x00005864
		[global::Cpp2ILInjected.Token(Token = "0x6001CAA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E911B4", Offset = "0x1E911B4", Length = "0x7C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TrackingStringDictionary), Member = "Remove", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TrackingValidationObjectDictionary), Member = "Remove", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "ToLowerInvariant", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public virtual void Remove(string key)
		{
			throw null;
		}

		// Token: 0x04000F64 RID: 3940
		[global::Cpp2ILInjected.Token(Token = "0x40013B7")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		internal Hashtable contents;
	}
}
