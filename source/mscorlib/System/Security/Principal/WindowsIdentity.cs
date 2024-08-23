using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security.Claims;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Security.Principal
{
	// Token: 0x0200028E RID: 654
	[global::System.Runtime.InteropServices.ComVisible(true)]
	[global::Cpp2ILInjected.Token(Token = "0x200032B")]
	[global::System.Serializable]
	public class WindowsIdentity : global::System.Security.Claims.ClaimsIdentity, IIdentity, global::System.Runtime.Serialization.IDeserializationCallback, global::System.Runtime.Serialization.ISerializable, global::System.IDisposable
	{
		// Token: 0x0600193F RID: 6463 RVA: 0x00018BFF File Offset: 0x00016DFF
		[global::Cpp2ILInjected.Token(Token = "0x6001B59")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B1F140", Offset = "0x1B1F140", Length = "0x64")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WindowsIdentity), Member = "GetCurrent", ReturnType = typeof(WindowsIdentity))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Security.Claims.ClaimsIdentity), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(IIdentity),
			typeof(global::System.Collections.Generic.IEnumerable<global::System.Security.Claims.Claim>),
			typeof(string),
			typeof(string),
			typeof(string),
			typeof(bool)
		}, ReturnType = typeof(void))]
		public WindowsIdentity(global::System.IntPtr userToken, string type, WindowsAccountType acctType, bool isAuthenticated)
		{
			throw null;
		}

		// Token: 0x06001940 RID: 6464 RVA: 0x00018C02 File Offset: 0x00016E02
		[global::Cpp2ILInjected.Token(Token = "0x6001B5A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B1F300", Offset = "0x1B1F300", Length = "0x3C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Security.Claims.ClaimsIdentity), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(IIdentity),
			typeof(global::System.Collections.Generic.IEnumerable<global::System.Security.Claims.Claim>),
			typeof(string),
			typeof(string),
			typeof(string),
			typeof(bool)
		}, ReturnType = typeof(void))]
		public WindowsIdentity(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			throw null;
		}

		// Token: 0x06001941 RID: 6465 RVA: 0x00018C05 File Offset: 0x00016E05
		[global::Cpp2ILInjected.Token(Token = "0x6001B5B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B1F33C", Offset = "0x1B1F33C", Length = "0xA4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Security.Claims.ClaimsPrincipal), Member = "DeserializeIdentities", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Security.Claims.ClaimsIdentity), Member = ".ctor", MemberParameters = new object[] { typeof(global::System.Security.Claims.ClaimsIdentity) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.IntPtr), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(global::System.IntPtr),
			typeof(global::System.IntPtr)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.IntPtr), Member = "ToInt64", ReturnType = typeof(long))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WindowsIdentity), Member = "SetToken", MemberParameters = new object[] { typeof(global::System.IntPtr) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		internal WindowsIdentity(global::System.Security.Claims.ClaimsIdentity claimsIdentity, global::System.IntPtr userToken)
		{
			throw null;
		}

		// Token: 0x06001942 RID: 6466 RVA: 0x00018C08 File Offset: 0x00016E08
		[global::System.Runtime.InteropServices.ComVisible(false)]
		[global::Cpp2ILInjected.Token(Token = "0x6001B5C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B1F3E0", Offset = "0x1B1F3E0", Length = "0x50")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public void Dispose()
		{
			throw null;
		}

		// Token: 0x06001943 RID: 6467 RVA: 0x00018C0B File Offset: 0x00016E0B
		[global::Cpp2ILInjected.Token(Token = "0x6001B5D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B1F430", Offset = "0x1B1F430", Length = "0x7C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.WebRequest", Member = "SafeCaptureIdenity", ReturnType = typeof(WindowsIdentity))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WindowsIdentity), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(global::System.IntPtr),
			typeof(string),
			typeof(WindowsAccountType),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public static WindowsIdentity GetCurrent()
		{
			throw null;
		}

		// Token: 0x06001944 RID: 6468 RVA: 0x00018C0E File Offset: 0x00016E0E
		[global::Cpp2ILInjected.Token(Token = "0x6001B5E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B1F4B0", Offset = "0x1B1F4B0", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WindowsImpersonationContext), Member = ".ctor", MemberParameters = new object[] { typeof(global::System.IntPtr) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public virtual WindowsImpersonationContext Impersonate()
		{
			throw null;
		}

		// Token: 0x170002BE RID: 702
		// (get) Token: 0x06001945 RID: 6469 RVA: 0x00018C11 File Offset: 0x00016E11
		[global::Cpp2ILInjected.Token(Token = "0x17000314")]
		public sealed override string AuthenticationType
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001B5F")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B1F594", Offset = "0x1B1F594", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170002BF RID: 703
		// (get) Token: 0x06001946 RID: 6470 RVA: 0x00018C14 File Offset: 0x00016E14
		[global::Cpp2ILInjected.Token(Token = "0x17000315")]
		public override string Name
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001B60")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B1F59C", Offset = "0x1B1F59C", Length = "0x68")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06001947 RID: 6471 RVA: 0x00018C17 File Offset: 0x00016E17
		[global::Cpp2ILInjected.Token(Token = "0x6001B61")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B1F608", Offset = "0x1B1F608", Length = "0x2B8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(global::System.RuntimeTypeHandle) }, ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.Serialization.SerializationInfo), Member = "GetValue", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.Type)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.Serialization.SerializationInfo), Member = "GetString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.Serialization.SerializationInfo), Member = "GetBoolean", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.Serialization.SerializationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 25)]
		private void System.Runtime.Serialization.IDeserializationCallback.OnDeserialization(object sender)
		{
			throw null;
		}

		// Token: 0x06001948 RID: 6472 RVA: 0x00018C1A File Offset: 0x00016E1A
		[global::Cpp2ILInjected.Token(Token = "0x6001B62")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B1F8C0", Offset = "0x1B1F8C0", Length = "0x170")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.Serialization.SerializationInfo), Member = "AddValue", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.Serialization.SerializationInfo), Member = "AddValue", MemberParameters = new object[]
		{
			typeof(string),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		private void System.Runtime.Serialization.ISerializable.GetObjectData(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			throw null;
		}

		// Token: 0x06001949 RID: 6473 RVA: 0x00018C1D File Offset: 0x00016E1D
		[global::Cpp2ILInjected.Token(Token = "0x6001B63")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B1FA30", Offset = "0x1B1FA30", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallAnalysisNotSupported]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		internal global::System.Security.Claims.ClaimsIdentity CloneAsBase()
		{
			throw null;
		}

		// Token: 0x0600194A RID: 6474 RVA: 0x00018C20 File Offset: 0x00016E20
		[global::Cpp2ILInjected.Token(Token = "0x6001B64")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B1FB74", Offset = "0x1B1FB74", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		internal global::System.IntPtr GetTokenInternal()
		{
			throw null;
		}

		// Token: 0x0600194B RID: 6475 RVA: 0x00018C23 File Offset: 0x00016E23
		[global::Cpp2ILInjected.Token(Token = "0x6001B65")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B1F1A4", Offset = "0x1B1F1A4", Length = "0x15C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WindowsIdentity), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(global::System.Security.Claims.ClaimsIdentity),
			typeof(global::System.IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Environment), Member = "get_IsUnix", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.IntPtr), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(global::System.IntPtr),
			typeof(global::System.IntPtr)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		private void SetToken(global::System.IntPtr token)
		{
			throw null;
		}

		// Token: 0x0600194C RID: 6476
		[global::Cpp2ILInjected.Token(Token = "0x6001B66")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B1F4AC", Offset = "0x1B1F4AC", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[MethodImpl(4096)]
		internal static extern global::System.IntPtr GetCurrentToken();

		// Token: 0x0600194D RID: 6477
		[global::Cpp2ILInjected.Token(Token = "0x6001B67")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B1F604", Offset = "0x1B1F604", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[MethodImpl(4096)]
		private static extern string GetTokenName(global::System.IntPtr token);

		// Token: 0x0600194E RID: 6478 RVA: 0x00018C26 File Offset: 0x00016E26
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x6001B68")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B1FB7C", Offset = "0x1B1FB7C", Length = "0x68")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		static WindowsIdentity()
		{
			throw null;
		}

		// Token: 0x04000B14 RID: 2836
		[global::Cpp2ILInjected.Token(Token = "0x4000DEE")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x78")]
		private global::System.IntPtr _token;

		// Token: 0x04000B15 RID: 2837
		[global::Cpp2ILInjected.Token(Token = "0x4000DEF")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x80")]
		private string _type;

		// Token: 0x04000B16 RID: 2838
		[global::Cpp2ILInjected.Token(Token = "0x4000DF0")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x88")]
		private WindowsAccountType _account;

		// Token: 0x04000B17 RID: 2839
		[global::Cpp2ILInjected.Token(Token = "0x4000DF1")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x8C")]
		private bool _authenticated;

		// Token: 0x04000B18 RID: 2840
		[global::Cpp2ILInjected.Token(Token = "0x4000DF2")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x90")]
		private string _name;

		// Token: 0x04000B19 RID: 2841
		[global::Cpp2ILInjected.Token(Token = "0x4000DF3")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x98")]
		private global::System.Runtime.Serialization.SerializationInfo _info;

		// Token: 0x04000B1A RID: 2842
		[global::Cpp2ILInjected.Token(Token = "0x4000DF4")]
		private static global::System.IntPtr invalidWindows;
	}
}
