using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Messaging;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Security.Principal;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Security.Claims
{
	// Token: 0x02000291 RID: 657
	[global::System.Runtime.InteropServices.ComVisible(true)]
	[global::Cpp2ILInjected.Token(Token = "0x200032E")]
	[global::System.Serializable]
	public class ClaimsIdentity : global::System.Security.Principal.IIdentity
	{
		// Token: 0x06001961 RID: 6497 RVA: 0x00018C53 File Offset: 0x00016E53
		[global::Cpp2ILInjected.Token(Token = "0x6001B7B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B1E9E8", Offset = "0x1B1E9E8", Length = "0x1C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ClaimsIdentity), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(global::System.Security.Principal.IIdentity),
			typeof(global::System.Collections.Generic.IEnumerable<Claim>),
			typeof(string),
			typeof(string),
			typeof(string),
			typeof(bool)
		}, ReturnType = typeof(void))]
		public ClaimsIdentity()
		{
			throw null;
		}

		// Token: 0x06001962 RID: 6498 RVA: 0x00018C56 File Offset: 0x00016E56
		[global::Cpp2ILInjected.Token(Token = "0x6001B7C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B20460", Offset = "0x1B20460", Length = "0x1C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ClaimsIdentity), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(global::System.Security.Principal.IIdentity),
			typeof(global::System.Collections.Generic.IEnumerable<Claim>),
			typeof(string),
			typeof(string),
			typeof(string),
			typeof(bool)
		}, ReturnType = typeof(void))]
		public ClaimsIdentity(global::System.Collections.Generic.IEnumerable<Claim> claims)
		{
			throw null;
		}

		// Token: 0x06001963 RID: 6499 RVA: 0x00018C59 File Offset: 0x00016E59
		[global::Cpp2ILInjected.Token(Token = "0x6001B7D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B2047C", Offset = "0x1B2047C", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public ClaimsIdentity(global::System.Security.Principal.IIdentity identity, global::System.Collections.Generic.IEnumerable<Claim> claims, string authenticationType, string nameType, string roleType)
		{
			throw null;
		}

		// Token: 0x06001964 RID: 6500 RVA: 0x00018C5C File Offset: 0x00016E5C
		[global::Cpp2ILInjected.Token(Token = "0x6001B7E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B20484", Offset = "0x1B20484", Length = "0x658")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Security.Principal.GenericIdentity), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Security.Principal.GenericIdentity), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Security.Principal.WindowsIdentity), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(global::System.IntPtr),
			typeof(string),
			typeof(global::System.Security.Principal.WindowsAccountType),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Security.Principal.WindowsIdentity), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(global::System.Runtime.Serialization.SerializationInfo),
			typeof(global::System.Runtime.Serialization.StreamingContext)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ClaimsIdentity), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ClaimsIdentity), Member = ".ctor", MemberParameters = new object[] { typeof(global::System.Collections.Generic.IEnumerable<Claim>) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ClaimsIdentity), Member = "Clone", ReturnType = typeof(ClaimsIdentity))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 7)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Collections.Generic.List<object>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Collections.ObjectModel.Collection<>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Environment), Member = "GetResourceString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
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
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ClaimsIdentity), Member = "SafeAddClaim", MemberParameters = new object[] { typeof(Claim) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ClaimsIdentity), Member = "SafeAddClaims", MemberParameters = new object[] { typeof(global::System.Collections.Generic.IEnumerable<Claim>) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array), Member = "Clone", ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 38)]
		internal ClaimsIdentity(global::System.Security.Principal.IIdentity identity, global::System.Collections.Generic.IEnumerable<Claim> claims, string authenticationType, string nameType, string roleType, bool checkAuthType)
		{
			throw null;
		}

		// Token: 0x06001965 RID: 6501 RVA: 0x00018C5F File Offset: 0x00016E5F
		[global::Cpp2ILInjected.Token(Token = "0x6001B7F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B1EB18", Offset = "0x1B1EB18", Length = "0x1F0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Security.Principal.GenericIdentity), Member = ".ctor", MemberParameters = new object[] { typeof(global::System.Security.Principal.GenericIdentity) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Security.Principal.GenericIdentity), Member = "Clone", ReturnType = typeof(ClaimsIdentity))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Security.Principal.WindowsIdentity), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(ClaimsIdentity),
			typeof(global::System.IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Collections.Generic.List<object>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Collections.ObjectModel.Collection<>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array), Member = "Clone", ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ClaimsIdentity), Member = "SafeAddClaims", MemberParameters = new object[] { typeof(global::System.Collections.Generic.IEnumerable<Claim>) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 17)]
		protected ClaimsIdentity(ClaimsIdentity other)
		{
			throw null;
		}

		// Token: 0x06001966 RID: 6502 RVA: 0x00018C62 File Offset: 0x00016E62
		[global::Cpp2ILInjected.Token(Token = "0x6001B80")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B20FAC", Offset = "0x1B20FAC", Length = "0x194")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Collections.Generic.List<object>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Collections.ObjectModel.Collection<>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 14)]
		protected ClaimsIdentity(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			throw null;
		}

		// Token: 0x170002C4 RID: 708
		// (get) Token: 0x06001967 RID: 6503 RVA: 0x00018C65 File Offset: 0x00016E65
		[global::Cpp2ILInjected.Token(Token = "0x1700031A")]
		public virtual string AuthenticationType
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001B81")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B21924", Offset = "0x1B21924", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170002C5 RID: 709
		// (get) Token: 0x06001968 RID: 6504 RVA: 0x00018C68 File Offset: 0x00016E68
		// (set) Token: 0x06001969 RID: 6505 RVA: 0x00018C6B File Offset: 0x00016E6B
		[global::Cpp2ILInjected.Token(Token = "0x1700031B")]
		public ClaimsIdentity Actor
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001B82")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B2192C", Offset = "0x1B2192C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6001B83")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B21934", Offset = "0x1B21934", Length = "0x88")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ClaimsIdentity), Member = "Clone", ReturnType = typeof(ClaimsIdentity))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Environment), Member = "GetResourceString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
			set
			{
				throw null;
			}
		}

		// Token: 0x170002C6 RID: 710
		// (get) Token: 0x0600196A RID: 6506 RVA: 0x00018C6E File Offset: 0x00016E6E
		[global::Cpp2ILInjected.Token(Token = "0x1700031C")]
		public virtual global::System.Collections.Generic.IEnumerable<Claim> Claims
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001B84")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B1ED6C", Offset = "0x1B1ED6C", Length = "0x70")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Environment), Member = "get_CurrentManagedThreadId", ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170002C7 RID: 711
		// (get) Token: 0x0600196B RID: 6507 RVA: 0x00018C71 File Offset: 0x00016E71
		[global::Cpp2ILInjected.Token(Token = "0x1700031D")]
		public virtual string Name
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001B85")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B219F0", Offset = "0x1B219F0", Length = "0x24")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170002C8 RID: 712
		// (get) Token: 0x0600196C RID: 6508 RVA: 0x00018C74 File Offset: 0x00016E74
		[global::Cpp2ILInjected.Token(Token = "0x1700031E")]
		public string NameClaimType
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001B86")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B21A14", Offset = "0x1B21A14", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600196D RID: 6509 RVA: 0x00018C77 File Offset: 0x00016E77
		[global::Cpp2ILInjected.Token(Token = "0x6001B87")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B1FA34", Offset = "0x1B1FA34", Length = "0x140")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ClaimsPrincipal), Member = "SerializeIdentities", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ClaimsIdentity), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(global::System.Security.Principal.IIdentity),
			typeof(global::System.Collections.Generic.IEnumerable<Claim>),
			typeof(string),
			typeof(string),
			typeof(string),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Environment), Member = "GetResourceString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ClaimsIdentity), Member = "set_Actor", MemberParameters = new object[] { typeof(ClaimsIdentity) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		public virtual ClaimsIdentity Clone()
		{
			throw null;
		}

		// Token: 0x0600196E RID: 6510 RVA: 0x00018C7A File Offset: 0x00016E7A
		[global::Cpp2ILInjected.Token(Token = "0x6001B88")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B1EE0C", Offset = "0x1B1EE0C", Length = "0x160")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Security.Principal.GenericIdentity), Member = "AddNameClaim", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public virtual void AddClaim(Claim claim)
		{
			throw null;
		}

		// Token: 0x0600196F RID: 6511 RVA: 0x00018C7D File Offset: 0x00016E7D
		[global::Cpp2ILInjected.Token(Token = "0x6001B89")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B20B04", Offset = "0x1B20B04", Length = "0x394")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ClaimsIdentity), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(global::System.Security.Principal.IIdentity),
			typeof(global::System.Collections.Generic.IEnumerable<Claim>),
			typeof(string),
			typeof(string),
			typeof(string),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ClaimsIdentity), Member = ".ctor", MemberParameters = new object[] { typeof(ClaimsIdentity) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 16)]
		private void SafeAddClaims(global::System.Collections.Generic.IEnumerable<Claim> claims)
		{
			throw null;
		}

		// Token: 0x06001970 RID: 6512 RVA: 0x00018C80 File Offset: 0x00016E80
		[global::Cpp2ILInjected.Token(Token = "0x6001B8A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B20E98", Offset = "0x1B20E98", Length = "0x114")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ClaimsIdentity), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(global::System.Security.Principal.IIdentity),
			typeof(global::System.Collections.Generic.IEnumerable<Claim>),
			typeof(string),
			typeof(string),
			typeof(string),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private void SafeAddClaim(Claim claim)
		{
			throw null;
		}

		// Token: 0x06001971 RID: 6513 RVA: 0x00018C83 File Offset: 0x00016E83
		[global::Cpp2ILInjected.Token(Token = "0x6001B8B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B21A1C", Offset = "0x1B21A1C", Length = "0x364")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Equals", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(global::System.StringComparison)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 20)]
		public virtual Claim FindFirst(string type)
		{
			throw null;
		}

		// Token: 0x06001972 RID: 6514 RVA: 0x00018C86 File Offset: 0x00016E86
		[global::System.Runtime.Serialization.OnSerializing]
		[global::Cpp2ILInjected.Token(Token = "0x6001B8C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B21D80", Offset = "0x1B21D80", Length = "0x64")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ClaimsIdentity), Member = "SerializeClaims", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private void OnSerializingMethod(global::System.Runtime.Serialization.StreamingContext context)
		{
			throw null;
		}

		// Token: 0x06001973 RID: 6515 RVA: 0x00018C89 File Offset: 0x00016E89
		[global::System.Runtime.Serialization.OnDeserialized]
		[global::Cpp2ILInjected.Token(Token = "0x6001B8D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B22028", Offset = "0x1B22028", Length = "0xDC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ClaimsIdentity), Member = "DeserializeClaims", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		private void OnDeserializedMethod(global::System.Runtime.Serialization.StreamingContext context)
		{
			throw null;
		}

		// Token: 0x06001974 RID: 6516 RVA: 0x00018C8C File Offset: 0x00016E8C
		[global::System.Runtime.Serialization.OnDeserializing]
		[global::Cpp2ILInjected.Token(Token = "0x6001B8E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B22428", Offset = "0x1B22428", Length = "0xD8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Collections.Generic.List<object>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Collections.ObjectModel.Collection<>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		private void OnDeserializingMethod(global::System.Runtime.Serialization.StreamingContext context)
		{
			throw null;
		}

		// Token: 0x06001975 RID: 6517 RVA: 0x00018C8F File Offset: 0x00016E8F
		[global::Cpp2ILInjected.Token(Token = "0x6001B8F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B22500", Offset = "0x1B22500", Length = "0x5B0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.Serialization.Formatters.Binary.BinaryFormatter), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.Serialization.SerializationInfo), Member = "AddValue", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.IO.MemoryStream), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.Serialization.Formatters.Binary.BinaryFormatter), Member = "Serialize", MemberParameters = new object[]
		{
			typeof(global::System.IO.Stream),
			typeof(object),
			typeof(global::System.Runtime.Remoting.Messaging.Header[]),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Convert), Member = "ToBase64String", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ClaimsIdentity), Member = "SerializeClaims", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 36)]
		protected virtual void GetObjectData(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			throw null;
		}

		// Token: 0x06001976 RID: 6518 RVA: 0x00018C92 File Offset: 0x00016E92
		[global::Cpp2ILInjected.Token(Token = "0x6001B90")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B22104", Offset = "0x1B22104", Length = "0x324")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ClaimsIdentity), Member = "OnDeserializedMethod", MemberParameters = new object[] { typeof(global::System.Runtime.Serialization.StreamingContext) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ClaimsIdentity), Member = "Deserialize", MemberParameters = new object[]
		{
			typeof(global::System.Runtime.Serialization.SerializationInfo),
			typeof(global::System.Runtime.Serialization.StreamingContext),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Convert), Member = "FromBase64String", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.IO.MemoryStream), Member = ".ctor", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.Serialization.Formatters.Binary.BinaryFormatter), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.Serialization.Formatters.Binary.BinaryFormatter), Member = "Deserialize", MemberParameters = new object[]
		{
			typeof(global::System.IO.Stream),
			typeof(global::System.Runtime.Remoting.Messaging.HeaderHandler),
			typeof(bool)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Collections.Generic.List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Collections.Generic.List<object>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 22)]
		private void DeserializeClaims(string serializedClaims)
		{
			throw null;
		}

		// Token: 0x06001977 RID: 6519 RVA: 0x00018C95 File Offset: 0x00016E95
		[global::Cpp2ILInjected.Token(Token = "0x6001B91")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B21DE4", Offset = "0x1B21DE4", Length = "0x244")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ClaimsIdentity), Member = "OnSerializingMethod", MemberParameters = new object[] { typeof(global::System.Runtime.Serialization.StreamingContext) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ClaimsIdentity), Member = "GetObjectData", MemberParameters = new object[]
		{
			typeof(global::System.Runtime.Serialization.SerializationInfo),
			typeof(global::System.Runtime.Serialization.StreamingContext)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.IO.MemoryStream), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.Serialization.Formatters.Binary.BinaryFormatter), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.Serialization.Formatters.Binary.BinaryFormatter), Member = "Serialize", MemberParameters = new object[]
		{
			typeof(global::System.IO.Stream),
			typeof(object),
			typeof(global::System.Runtime.Remoting.Messaging.Header[]),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Convert), Member = "ToBase64String", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 15)]
		private string SerializeClaims()
		{
			throw null;
		}

		// Token: 0x06001978 RID: 6520 RVA: 0x00018C98 File Offset: 0x00016E98
		[global::Cpp2ILInjected.Token(Token = "0x6001B92")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B20ADC", Offset = "0x1B20ADC", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private bool IsCircular(ClaimsIdentity subject)
		{
			throw null;
		}

		// Token: 0x06001979 RID: 6521 RVA: 0x00018C9B File Offset: 0x00016E9B
		[global::Cpp2ILInjected.Token(Token = "0x6001B93")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B21140", Offset = "0x1B21140", Length = "0x7E4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.Serialization.Formatters.Binary.BinaryFormatter), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(global::System.Runtime.Serialization.ISurrogateSelector),
			typeof(global::System.Runtime.Serialization.StreamingContext)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.Serialization.Formatters.Binary.BinaryFormatter), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.Serialization.SerializationInfo), Member = "GetEnumerator", ReturnType = typeof(global::System.Runtime.Serialization.SerializationInfoEnumerator))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.Serialization.SerializationInfoEnumerator), Member = "MoveNext", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.Serialization.SerializationInfoEnumerator), Member = "get_Name", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::<PrivateImplementationDetails>), Member = "ComputeStringHash", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(uint))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.Serialization.SerializationInfo), Member = "GetString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Convert), Member = "FromBase64String", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.IO.MemoryStream), Member = ".ctor", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.Serialization.Formatters.Binary.BinaryFormatter), Member = "Deserialize", MemberParameters = new object[]
		{
			typeof(global::System.IO.Stream),
			typeof(global::System.Runtime.Remoting.Messaging.HeaderHandler),
			typeof(bool)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ClaimsIdentity), Member = "DeserializeClaims", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 38)]
		private void Deserialize(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context, bool useContext)
		{
			throw null;
		}

		// Token: 0x04000B26 RID: 2854
		[global::Cpp2ILInjected.Token(Token = "0x4000E00")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		[global::System.NonSerialized]
		private byte[] m_userSerializationData;

		// Token: 0x04000B27 RID: 2855
		[global::Cpp2ILInjected.Token(Token = "0x4000E01")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		[global::System.NonSerialized]
		private global::System.Collections.Generic.List<Claim> m_instanceClaims;

		// Token: 0x04000B28 RID: 2856
		[global::Cpp2ILInjected.Token(Token = "0x4000E02")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		[global::System.NonSerialized]
		private global::System.Collections.ObjectModel.Collection<global::System.Collections.Generic.IEnumerable<Claim>> m_externalClaims;

		// Token: 0x04000B29 RID: 2857
		[global::Cpp2ILInjected.Token(Token = "0x4000E03")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		[global::System.NonSerialized]
		private string m_nameType;

		// Token: 0x04000B2A RID: 2858
		[global::Cpp2ILInjected.Token(Token = "0x4000E04")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		[global::System.NonSerialized]
		private string m_roleType;

		// Token: 0x04000B2B RID: 2859
		[global::System.Runtime.Serialization.OptionalField(VersionAdded = 2)]
		[global::Cpp2ILInjected.Token(Token = "0x4000E05")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		private string m_version;

		// Token: 0x04000B2C RID: 2860
		[global::System.Runtime.Serialization.OptionalField(VersionAdded = 2)]
		[global::Cpp2ILInjected.Token(Token = "0x4000E06")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		private ClaimsIdentity m_actor;

		// Token: 0x04000B2D RID: 2861
		[global::System.Runtime.Serialization.OptionalField(VersionAdded = 2)]
		[global::Cpp2ILInjected.Token(Token = "0x4000E07")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
		private string m_authenticationType;

		// Token: 0x04000B2E RID: 2862
		[global::System.Runtime.Serialization.OptionalField(VersionAdded = 2)]
		[global::Cpp2ILInjected.Token(Token = "0x4000E08")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
		private object m_bootstrapContext;

		// Token: 0x04000B2F RID: 2863
		[global::System.Runtime.Serialization.OptionalField(VersionAdded = 2)]
		[global::Cpp2ILInjected.Token(Token = "0x4000E09")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
		private string m_label;

		// Token: 0x04000B30 RID: 2864
		[global::System.Runtime.Serialization.OptionalField(VersionAdded = 2)]
		[global::Cpp2ILInjected.Token(Token = "0x4000E0A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
		private string m_serializedNameType;

		// Token: 0x04000B31 RID: 2865
		[global::System.Runtime.Serialization.OptionalField(VersionAdded = 2)]
		[global::Cpp2ILInjected.Token(Token = "0x4000E0B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x68")]
		private string m_serializedRoleType;

		// Token: 0x04000B32 RID: 2866
		[global::System.Runtime.Serialization.OptionalField(VersionAdded = 2)]
		[global::Cpp2ILInjected.Token(Token = "0x4000E0C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x70")]
		private string m_serializedClaims;

		// Token: 0x020005E8 RID: 1512
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x200032F")]
		private sealed class <get_Claims>d__51 : global::System.Collections.Generic.IEnumerable<Claim>, global::System.Collections.IEnumerable, global::System.Collections.Generic.IEnumerator<Claim>, global::System.IDisposable, global::System.Collections.IEnumerator
		{
			// Token: 0x060040F1 RID: 16625 RVA: 0x0001FD81 File Offset: 0x0001DF81
			[global::System.Diagnostics.DebuggerHidden]
			[global::Cpp2ILInjected.Token(Token = "0x6001B94")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B219BC", Offset = "0x1B219BC", Length = "0x34")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Environment), Member = "get_CurrentManagedThreadId", ReturnType = typeof(int))]
			public <get_Claims>d__51(int <>1__state)
			{
				throw null;
			}

			// Token: 0x060040F2 RID: 16626 RVA: 0x0001FD84 File Offset: 0x0001DF84
			[global::System.Diagnostics.DebuggerHidden]
			[global::Cpp2ILInjected.Token(Token = "0x6001B95")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B22AB0", Offset = "0x1B22AB0", Length = "0x1C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ClaimsIdentity.<get_Claims>d__51), Member = "<>m__Finally1", ReturnType = typeof(void))]
			private void System.IDisposable.Dispose()
			{
				throw null;
			}

			// Token: 0x060040F3 RID: 16627 RVA: 0x0001FD87 File Offset: 0x0001DF87
			[global::Cpp2ILInjected.Token(Token = "0x6001B96")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B22ACC", Offset = "0x1B22ACC", Length = "0x388")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Collections.Generic.List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Collections.ObjectModel.Collection<>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ClaimsIdentity.<get_Claims>d__51), Member = "<>m__Finally1", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Collections.ObjectModel.Collection<>), Member = "get_Count", ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 17)]
			private bool MoveNext()
			{
				throw null;
			}

			// Token: 0x060040F4 RID: 16628 RVA: 0x0001FD8A File Offset: 0x0001DF8A
			[global::Cpp2ILInjected.Token(Token = "0x6001B97")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B22E54", Offset = "0x1B22E54", Length = "0xB0")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ClaimsIdentity.<get_Claims>d__51), Member = "System.IDisposable.Dispose", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ClaimsIdentity.<get_Claims>d__51), Member = "MoveNext", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			private void <>m__Finally1()
			{
				throw null;
			}

			// Token: 0x17000751 RID: 1873
			// (get) Token: 0x060040F5 RID: 16629 RVA: 0x0001FD8D File Offset: 0x0001DF8D
			[global::Cpp2ILInjected.Token(Token = "0x1700031F")]
			private Claim System.Collections.Generic.IEnumerator<System.Security.Claims.Claim>.Current
			{
				[global::System.Diagnostics.DebuggerHidden]
				[global::Cpp2ILInjected.Token(Token = "0x6001B98")]
				[global::Cpp2ILInjected.Address(RVA = "0x1B22F04", Offset = "0x1B22F04", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				get
				{
					throw null;
				}
			}

			// Token: 0x060040F6 RID: 16630 RVA: 0x0001FD90 File Offset: 0x0001DF90
			[global::System.Diagnostics.DebuggerHidden]
			[global::Cpp2ILInjected.Token(Token = "0x6001B99")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B22F0C", Offset = "0x1B22F0C", Length = "0x38")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			private void System.Collections.IEnumerator.Reset()
			{
				throw null;
			}

			// Token: 0x17000752 RID: 1874
			// (get) Token: 0x060040F7 RID: 16631 RVA: 0x0001FD93 File Offset: 0x0001DF93
			[global::Cpp2ILInjected.Token(Token = "0x17000320")]
			private object System.Collections.IEnumerator.Current
			{
				[global::System.Diagnostics.DebuggerHidden]
				[global::Cpp2ILInjected.Token(Token = "0x6001B9A")]
				[global::Cpp2ILInjected.Address(RVA = "0x1B22F44", Offset = "0x1B22F44", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				get
				{
					throw null;
				}
			}

			// Token: 0x060040F8 RID: 16632 RVA: 0x0001FD96 File Offset: 0x0001DF96
			[global::System.Diagnostics.DebuggerHidden]
			[global::Cpp2ILInjected.Token(Token = "0x6001B9B")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B22F4C", Offset = "0x1B22F4C", Length = "0x9C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ClaimsIdentity.<get_Claims>d__51), Member = "System.Collections.IEnumerable.GetEnumerator", ReturnType = typeof(global::System.Collections.IEnumerator))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Environment), Member = "get_CurrentManagedThreadId", ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			private global::System.Collections.Generic.IEnumerator<Claim> System.Collections.Generic.IEnumerable<System.Security.Claims.Claim>.GetEnumerator()
			{
				throw null;
			}

			// Token: 0x060040F9 RID: 16633 RVA: 0x0001FD99 File Offset: 0x0001DF99
			[global::System.Diagnostics.DebuggerHidden]
			[global::Cpp2ILInjected.Token(Token = "0x6001B9C")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B22FE8", Offset = "0x1B22FE8", Length = "0x4")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ClaimsIdentity.<get_Claims>d__51), Member = "System.Collections.Generic.IEnumerable<System.Security.Claims.Claim>.GetEnumerator", ReturnType = typeof(global::System.Collections.Generic.IEnumerator<Claim>))]
			private global::System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
			{
				throw null;
			}

			// Token: 0x04001962 RID: 6498
			[global::Cpp2ILInjected.Token(Token = "0x4000E0D")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			// Token: 0x04001963 RID: 6499
			[global::Cpp2ILInjected.Token(Token = "0x4000E0E")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
			private Claim <>2__current;

			// Token: 0x04001964 RID: 6500
			[global::Cpp2ILInjected.Token(Token = "0x4000E0F")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
			private int <>l__initialThreadId;

			// Token: 0x04001965 RID: 6501
			[global::Cpp2ILInjected.Token(Token = "0x4000E10")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
			public ClaimsIdentity <>4__this;

			// Token: 0x04001966 RID: 6502
			[global::Cpp2ILInjected.Token(Token = "0x4000E11")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
			private int <i>5__2;

			// Token: 0x04001967 RID: 6503
			[global::Cpp2ILInjected.Token(Token = "0x4000E12")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
			private global::System.Collections.Generic.IEnumerator<Claim> <>7__wrap2;
		}
	}
}
