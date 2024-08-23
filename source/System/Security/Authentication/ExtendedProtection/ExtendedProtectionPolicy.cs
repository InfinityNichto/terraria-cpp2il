using System;
using System.ComponentModel;
using System.Net;
using System.Runtime.Serialization;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Security.Authentication.ExtendedProtection
{
	// Token: 0x0200008F RID: 143
	[TypeConverter(typeof(ExtendedProtectionPolicyTypeConverter))]
	[MonoTODO]
	[global::Cpp2ILInjected.Token(Token = "0x20000EA")]
	[Serializable]
	public class ExtendedProtectionPolicy : ISerializable
	{
		// Token: 0x060004A4 RID: 1188 RVA: 0x00003B75 File Offset: 0x00001D75
		[MonoTODO("Not implemented.")]
		[global::Cpp2ILInjected.Token(Token = "0x6000544")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ECD2E0", Offset = "0x1ECD2E0", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HttpListener), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public ExtendedProtectionPolicy(PolicyEnforcement policyEnforcement)
		{
			throw null;
		}

		// Token: 0x060004A5 RID: 1189 RVA: 0x00003B78 File Offset: 0x00001D78
		[global::Cpp2ILInjected.Token(Token = "0x6000545")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ECD2E8", Offset = "0x1ECD2E8", Length = "0x40")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NotImplementedException), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		protected ExtendedProtectionPolicy(SerializationInfo info, StreamingContext context)
		{
			throw null;
		}

		// Token: 0x170000FE RID: 254
		// (get) Token: 0x060004A6 RID: 1190 RVA: 0x00003B7B File Offset: 0x00001D7B
		[global::Cpp2ILInjected.Token(Token = "0x17000104")]
		public ChannelBinding CustomChannelBinding
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000546")]
			[global::Cpp2ILInjected.Address(RVA = "0x1ECD328", Offset = "0x1ECD328", Length = "0x38")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HttpListener), Member = "set_ExtendedProtectionPolicy", MemberParameters = new object[] { typeof(ExtendedProtectionPolicy) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NotImplementedException), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170000FF RID: 255
		// (get) Token: 0x060004A7 RID: 1191 RVA: 0x00003B7E File Offset: 0x00001D7E
		[global::Cpp2ILInjected.Token(Token = "0x17000105")]
		public PolicyEnforcement PolicyEnforcement
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000547")]
			[global::Cpp2ILInjected.Address(RVA = "0x1ECD360", Offset = "0x1ECD360", Length = "0x38")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HttpListener), Member = "set_ExtendedProtectionPolicy", MemberParameters = new object[] { typeof(ExtendedProtectionPolicy) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NotImplementedException), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			get
			{
				throw null;
			}
		}

		// Token: 0x060004A8 RID: 1192 RVA: 0x00003B81 File Offset: 0x00001D81
		[MonoTODO]
		[global::Cpp2ILInjected.Token(Token = "0x6000548")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ECD398", Offset = "0x1ECD398", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "ToString", ReturnType = typeof(string))]
		public override string ToString()
		{
			throw null;
		}

		// Token: 0x060004A9 RID: 1193 RVA: 0x00003B84 File Offset: 0x00001D84
		[global::Cpp2ILInjected.Token(Token = "0x6000549")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ECD3A0", Offset = "0x1ECD3A0", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NotImplementedException), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context)
		{
			throw null;
		}
	}
}
