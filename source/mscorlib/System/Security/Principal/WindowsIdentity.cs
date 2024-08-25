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
	[global::System.Runtime.InteropServices.ComVisible(true)]
	[global::Cpp2ILInjected.Token(Token = "0x200032B")]
	[global::System.Serializable]
	public class WindowsIdentity : global::System.Security.Claims.ClaimsIdentity, IIdentity, global::System.Runtime.Serialization.IDeserializationCallback, global::System.Runtime.Serialization.ISerializable, global::System.IDisposable
	{
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

		[global::System.Runtime.InteropServices.ComVisible(false)]
		[global::Cpp2ILInjected.Token(Token = "0x6001B5C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B1F3E0", Offset = "0x1B1F3E0", Length = "0x50")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public void Dispose()
		{
			throw null;
		}

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

		[global::Cpp2ILInjected.Token(Token = "0x6001B5E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B1F4B0", Offset = "0x1B1F4B0", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WindowsImpersonationContext), Member = ".ctor", MemberParameters = new object[] { typeof(global::System.IntPtr) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public virtual WindowsImpersonationContext Impersonate()
		{
			throw null;
		}

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

		[global::Cpp2ILInjected.Token(Token = "0x6001B63")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B1FA30", Offset = "0x1B1FA30", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallAnalysisNotSupported]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		internal global::System.Security.Claims.ClaimsIdentity CloneAsBase()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001B64")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B1FB74", Offset = "0x1B1FB74", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		internal global::System.IntPtr GetTokenInternal()
		{
			throw null;
		}

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

		[global::Cpp2ILInjected.Token(Token = "0x6001B66")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B1F4AC", Offset = "0x1B1F4AC", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[MethodImpl(4096)]
		internal static extern global::System.IntPtr GetCurrentToken();

		[global::Cpp2ILInjected.Token(Token = "0x6001B67")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B1F604", Offset = "0x1B1F604", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[MethodImpl(4096)]
		private static extern string GetTokenName(global::System.IntPtr token);

		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x6001B68")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B1FB7C", Offset = "0x1B1FB7C", Length = "0x68")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		static WindowsIdentity()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x4000DEE")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x78")]
		private global::System.IntPtr _token;

		[global::Cpp2ILInjected.Token(Token = "0x4000DEF")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x80")]
		private string _type;

		[global::Cpp2ILInjected.Token(Token = "0x4000DF0")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x88")]
		private WindowsAccountType _account;

		[global::Cpp2ILInjected.Token(Token = "0x4000DF1")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x8C")]
		private bool _authenticated;

		[global::Cpp2ILInjected.Token(Token = "0x4000DF2")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x90")]
		private string _name;

		[global::Cpp2ILInjected.Token(Token = "0x4000DF3")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x98")]
		private global::System.Runtime.Serialization.SerializationInfo _info;

		[global::Cpp2ILInjected.Token(Token = "0x4000DF4")]
		private static global::System.IntPtr invalidWindows;
	}
}
