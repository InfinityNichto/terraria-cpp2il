using System;
using System.Runtime.InteropServices;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Messaging;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System
{
	// Token: 0x02000139 RID: 313
	[global::System.Runtime.InteropServices.ComVisible(true)]
	[global::Cpp2ILInjected.Token(Token = "0x200017F")]
	[global::System.Serializable]
	[StructLayout(0)]
	public abstract class MarshalByRefObject
	{
		// Token: 0x06000E1F RID: 3615 RVA: 0x00016D45 File Offset: 0x00014F45
		[global::Cpp2ILInjected.Token(Token = "0x6000F07")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C7740C", Offset = "0x1C7740C", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 31)]
		protected MarshalByRefObject()
		{
			throw null;
		}

		// Token: 0x1700013A RID: 314
		// (get) Token: 0x06000E20 RID: 3616 RVA: 0x00016D48 File Offset: 0x00014F48
		// (set) Token: 0x06000E21 RID: 3617 RVA: 0x00016D4B File Offset: 0x00014F4B
		[global::Cpp2ILInjected.Token(Token = "0x1700015C")]
		internal global::System.Runtime.Remoting.ServerIdentity ObjectIdentity
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000F08")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C7DDF4", Offset = "0x1C7DDF4", Length = "0x38")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Remoting.SingleCallIdentity), Member = "SyncObjectProcessMessage", MemberParameters = new object[] { typeof(global::System.Runtime.Remoting.Messaging.IMessage) }, ReturnType = typeof(global::System.Runtime.Remoting.Messaging.IMessage))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000F09")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C7DE2C", Offset = "0x1C7DE2C", Length = "0x38")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Remoting.ServerIdentity), Member = "DisposeServerObject", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Remoting.SingleCallIdentity), Member = "SyncObjectProcessMessage", MemberParameters = new object[] { typeof(global::System.Runtime.Remoting.Messaging.IMessage) }, ReturnType = typeof(global::System.Runtime.Remoting.Messaging.IMessage))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			set
			{
				throw null;
			}
		}

		// Token: 0x06000E22 RID: 3618 RVA: 0x00016D4E File Offset: 0x00014F4E
		[global::Cpp2ILInjected.Token(Token = "0x6000F0A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C7DE64", Offset = "0x1C7DE64", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public virtual global::System.Runtime.Remoting.ObjRef CreateObjRef(global::System.Type requestedType)
		{
			throw null;
		}

		// Token: 0x06000E23 RID: 3619 RVA: 0x00016D51 File Offset: 0x00014F51
		[global::Cpp2ILInjected.Token(Token = "0x6000F0B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C7DE9C", Offset = "0x1C7DE9C", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public virtual object InitializeLifetimeService()
		{
			throw null;
		}

		// Token: 0x040004AD RID: 1197
		[global::Cpp2ILInjected.Token(Token = "0x400067C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		[global::System.NonSerialized]
		private object _identity;
	}
}
