using System;
using System.Collections;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security.Cryptography.X509Certificates;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System
{
	// Token: 0x02000159 RID: 345
	[global::Cpp2ILInjected.Token(Token = "0x20001A5")]
	[global::System.Serializable]
	public sealed class WeakReference<T> : global::System.Runtime.Serialization.ISerializable where T : class
	{
		// Token: 0x06000F06 RID: 3846 RVA: 0x00016F8E File Offset: 0x0001518E
		[global::Cpp2ILInjected.Token(Token = "0x6001004")]
		[global::Cpp2ILInjected.Address(RVA = "0x18D9B10", Offset = "0x18D9B10", Length = "0x18")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Mono.Net.Security.ChainValidationHelper", Member = ".ctor", MemberParameters = new object[]
		{
			"System.Net.Security.SslStream",
			"Mono.Net.Security.MobileTlsProvider",
			"Mono.Security.Interface.MonoTlsSettings",
			typeof(bool),
			"Mono.Net.Security.MonoTlsStream"
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Text.RegularExpressions.Regex", Member = "InitializeReferences", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public WeakReference(T target)
		{
			throw null;
		}

		// Token: 0x06000F07 RID: 3847 RVA: 0x00016F91 File Offset: 0x00015191
		[global::Cpp2ILInjected.Token(Token = "0x6001005")]
		[global::Cpp2ILInjected.Address(RVA = "0x18D9B28", Offset = "0x18D9B28", Length = "0x40")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.InteropServices.GCHandle), Member = "Alloc", MemberParameters = new object[]
		{
			typeof(object),
			typeof(global::System.Runtime.InteropServices.GCHandleType)
		}, ReturnType = typeof(global::System.Runtime.InteropServices.GCHandle))]
		public WeakReference(T target, bool trackResurrection)
		{
			throw null;
		}

		// Token: 0x06000F08 RID: 3848 RVA: 0x00016F94 File Offset: 0x00015194
		[global::Cpp2ILInjected.Token(Token = "0x6001006")]
		[global::Cpp2ILInjected.Address(RVA = "0x18D9B68", Offset = "0x18D9B68", Length = "0x134")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.Serialization.SerializationInfo), Member = "GetBoolean", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(global::System.RuntimeTypeHandle) }, ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.Serialization.SerializationInfo), Member = "GetValue", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.Type)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.InteropServices.GCHandle), Member = "Alloc", MemberParameters = new object[]
		{
			typeof(object),
			typeof(global::System.Runtime.InteropServices.GCHandleType)
		}, ReturnType = typeof(global::System.Runtime.InteropServices.GCHandle))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		private WeakReference(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			throw null;
		}

		// Token: 0x06000F09 RID: 3849 RVA: 0x00016F97 File Offset: 0x00015197
		[global::Cpp2ILInjected.Token(Token = "0x6001007")]
		[global::Cpp2ILInjected.Address(RVA = "0x18D9C9C", Offset = "0x18D9C9C", Length = "0xEC")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.Serialization.SerializationInfo), Member = "AddValue", MemberParameters = new object[]
		{
			typeof(string),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.InteropServices.GCHandle), Member = "get_IsAllocated", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.InteropServices.GCHandle), Member = "get_Target", ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.Serialization.SerializationInfo), Member = "AddValue", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public void GetObjectData(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			throw null;
		}

		// Token: 0x06000F0A RID: 3850 RVA: 0x00016F9A File Offset: 0x0001519A
		[global::Cpp2ILInjected.Token(Token = "0x6001008")]
		[global::Cpp2ILInjected.Address(RVA = "0x18D9D88", Offset = "0x18D9D88", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Text.RegularExpressions.RegexReplacement", Member = "GetOrCreate", MemberParameters = new object[]
		{
			"System.WeakReference`1<RegexReplacement>",
			typeof(string),
			typeof(global::System.Collections.Hashtable),
			typeof(int),
			typeof(global::System.Collections.Hashtable),
			"System.Text.RegularExpressions.RegexOptions"
		}, ReturnType = "System.Text.RegularExpressions.RegexReplacement")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.InteropServices.GCHandle), Member = "set_Target", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		public void SetTarget(T target)
		{
			throw null;
		}

		// Token: 0x06000F0B RID: 3851 RVA: 0x00016F9D File Offset: 0x0001519D
		[global::Cpp2ILInjected.Token(Token = "0x6001009")]
		[global::Cpp2ILInjected.Address(RVA = "0x18D9D94", Offset = "0x18D9D94", Length = "0xE8")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Mono.Net.Security.ChainValidationHelper", Member = "InvokeCallback", MemberParameters = new object[]
		{
			typeof(global::System.Security.Cryptography.X509Certificates.X509Certificate),
			"System.Security.Cryptography.X509Certificates.X509Chain",
			"System.Net.Security.SslPolicyErrors"
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Text.RegularExpressions.RegexReplacement", Member = "GetOrCreate", MemberParameters = new object[]
		{
			"System.WeakReference`1<RegexReplacement>",
			typeof(string),
			typeof(global::System.Collections.Hashtable),
			typeof(int),
			typeof(global::System.Collections.Hashtable),
			"System.Text.RegularExpressions.RegexOptions"
		}, ReturnType = "System.Text.RegularExpressions.RegexReplacement")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.InteropServices.GCHandle), Member = "get_IsAllocated", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.InteropServices.GCHandle), Member = "get_Target", ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public bool TryGetTarget(out T target)
		{
			throw null;
		}

		// Token: 0x06000F0C RID: 3852 RVA: 0x00016FA0 File Offset: 0x000151A0
		[global::Cpp2ILInjected.Token(Token = "0x600100A")]
		[global::Cpp2ILInjected.Address(RVA = "0x18D9E7C", Offset = "0x18D9E7C", Length = "0x9C")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.InteropServices.GCHandle), Member = "Free", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "Finalize", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		protected override void Finalize()
		{
			throw null;
		}

		// Token: 0x040006CF RID: 1743
		[global::Cpp2ILInjected.Token(Token = "0x40008AA")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private global::System.Runtime.InteropServices.GCHandle handle;

		// Token: 0x040006D0 RID: 1744
		[global::Cpp2ILInjected.Token(Token = "0x40008AB")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private bool trackResurrection;
	}
}
