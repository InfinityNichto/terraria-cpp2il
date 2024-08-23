using System;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.Serialization;
using System.Security.Principal;
using System.Threading;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Security.Claims
{
	// Token: 0x02000290 RID: 656
	[global::Cpp2ILInjected.Token(Token = "0x200032D")]
	[global::System.Serializable]
	public class Claim
	{
		// Token: 0x06001956 RID: 6486 RVA: 0x00018C32 File Offset: 0x00016E32
		[global::Cpp2ILInjected.Token(Token = "0x6001B70")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B1EDEC", Offset = "0x1B1EDEC", Length = "0x20")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Claim), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string),
			typeof(string),
			typeof(string),
			typeof(ClaimsIdentity),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		public Claim(string type, string value, string valueType, string issuer, string originalIssuer, ClaimsIdentity subject)
		{
			throw null;
		}

		// Token: 0x06001957 RID: 6487 RVA: 0x00018C35 File Offset: 0x00016E35
		[global::Cpp2ILInjected.Token(Token = "0x6001B71")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B1FCC4", Offset = "0x1B1FCC4", Length = "0x244")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Security.Principal.GenericIdentity), Member = "AddNameClaim", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Claim), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string),
			typeof(string),
			typeof(string),
			typeof(ClaimsIdentity)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ClaimsIdentity), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(global::System.Security.Principal.IIdentity),
			typeof(global::System.Collections.Generic.IEnumerable<Claim>),
			typeof(string),
			typeof(string),
			typeof(string),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Claim), Member = "get_Properties", ReturnType = typeof(global::System.Collections.Generic.IDictionary<string, string>))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 14)]
		internal Claim(string type, string value, string valueType, string issuer, string originalIssuer, ClaimsIdentity subject, string propertyKey, string propertyValue)
		{
			throw null;
		}

		// Token: 0x06001958 RID: 6488 RVA: 0x00018C38 File Offset: 0x00016E38
		[global::Cpp2ILInjected.Token(Token = "0x6001B72")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B20034", Offset = "0x1B20034", Length = "0x2D4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Claim), Member = "Clone", MemberParameters = new object[] { typeof(ClaimsIdentity) }, ReturnType = typeof(Claim))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Collections.Generic.Dictionary<object, object>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Collections.Generic.Dictionary<object, object>), Member = "get_Keys", ReturnType = "KeyCollection<TKey, TValue>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Collections.Generic.Dictionary<object, object>.KeyCollection), Member = "GetEnumerator", ReturnType = "Enumerator<TKey, TValue>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Collections.Generic.Dictionary<object, object>.KeyCollection.Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Collections.Generic.Dictionary<object, object>), Member = "get_Item", MemberParameters = new object[] { typeof(object) }, ReturnType = "TValue")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Collections.Generic.Dictionary<object, object>), Member = "Add", MemberParameters = new object[]
		{
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Collections.Generic.Dictionary<object, object>.KeyCollection.Enumerator), Member = "Dispose", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array), Member = "Clone", ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 26)]
		protected Claim(Claim other, ClaimsIdentity subject)
		{
			throw null;
		}

		// Token: 0x06001959 RID: 6489 RVA: 0x00018C3B File Offset: 0x00016E3B
		[global::System.Runtime.Serialization.OnDeserialized]
		[global::Cpp2ILInjected.Token(Token = "0x6001B73")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B20308", Offset = "0x1B20308", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private void OnDeserializedMethod(global::System.Runtime.Serialization.StreamingContext context)
		{
			throw null;
		}

		// Token: 0x170002C0 RID: 704
		// (get) Token: 0x0600195A RID: 6490 RVA: 0x00018C3E File Offset: 0x00016E3E
		[global::Cpp2ILInjected.Token(Token = "0x17000316")]
		public global::System.Collections.Generic.IDictionary<string, string> Properties
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001B74")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B1FF08", Offset = "0x1B1FF08", Length = "0x12C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Claim), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(string),
				typeof(string),
				typeof(string),
				typeof(string),
				typeof(string),
				typeof(ClaimsIdentity),
				typeof(string),
				typeof(string)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Monitor), Member = "Enter", MemberParameters = new object[]
			{
				typeof(object),
				typeof(ref bool)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Collections.Generic.Dictionary<object, object>), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170002C1 RID: 705
		// (get) Token: 0x0600195B RID: 6491 RVA: 0x00018C41 File Offset: 0x00016E41
		// (set) Token: 0x0600195C RID: 6492 RVA: 0x00018C44 File Offset: 0x00016E44
		[global::Cpp2ILInjected.Token(Token = "0x17000317")]
		public ClaimsIdentity Subject
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001B75")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B20360", Offset = "0x1B20360", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6001B76")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B20368", Offset = "0x1B20368", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			internal set
			{
				throw null;
			}
		}

		// Token: 0x170002C2 RID: 706
		// (get) Token: 0x0600195D RID: 6493 RVA: 0x00018C47 File Offset: 0x00016E47
		[global::Cpp2ILInjected.Token(Token = "0x17000318")]
		public string Type
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001B77")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B20370", Offset = "0x1B20370", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170002C3 RID: 707
		// (get) Token: 0x0600195E RID: 6494 RVA: 0x00018C4A File Offset: 0x00016E4A
		[global::Cpp2ILInjected.Token(Token = "0x17000319")]
		public string Value
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001B78")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B20378", Offset = "0x1B20378", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600195F RID: 6495 RVA: 0x00018C4D File Offset: 0x00016E4D
		[global::Cpp2ILInjected.Token(Token = "0x6001B79")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B20380", Offset = "0x1B20380", Length = "0x68")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Claim), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Claim),
			typeof(ClaimsIdentity)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public virtual Claim Clone(ClaimsIdentity identity)
		{
			throw null;
		}

		// Token: 0x06001960 RID: 6496 RVA: 0x00018C50 File Offset: 0x00016E50
		[global::Cpp2ILInjected.Token(Token = "0x6001B7A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B203E8", Offset = "0x1B203E8", Length = "0x78")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Globalization.CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(global::System.Globalization.CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Format", MemberParameters = new object[]
		{
			typeof(global::System.IFormatProvider),
			typeof(string),
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public override string ToString()
		{
			throw null;
		}

		// Token: 0x04000B1D RID: 2845
		[global::Cpp2ILInjected.Token(Token = "0x4000DF7")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private string m_issuer;

		// Token: 0x04000B1E RID: 2846
		[global::Cpp2ILInjected.Token(Token = "0x4000DF8")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private string m_originalIssuer;

		// Token: 0x04000B1F RID: 2847
		[global::Cpp2ILInjected.Token(Token = "0x4000DF9")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private string m_type;

		// Token: 0x04000B20 RID: 2848
		[global::Cpp2ILInjected.Token(Token = "0x4000DFA")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private string m_value;

		// Token: 0x04000B21 RID: 2849
		[global::Cpp2ILInjected.Token(Token = "0x4000DFB")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private string m_valueType;

		// Token: 0x04000B22 RID: 2850
		[global::Cpp2ILInjected.Token(Token = "0x4000DFC")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		[global::System.NonSerialized]
		private byte[] m_userSerializationData;

		// Token: 0x04000B23 RID: 2851
		[global::Cpp2ILInjected.Token(Token = "0x4000DFD")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		private global::System.Collections.Generic.Dictionary<string, string> m_properties;

		// Token: 0x04000B24 RID: 2852
		[global::Cpp2ILInjected.Token(Token = "0x4000DFE")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
		[global::System.NonSerialized]
		private object m_propertyLock;

		// Token: 0x04000B25 RID: 2853
		[global::Cpp2ILInjected.Token(Token = "0x4000DFF")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
		[global::System.NonSerialized]
		private ClaimsIdentity m_subject;
	}
}
