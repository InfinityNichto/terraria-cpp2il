using System;
using System.Runtime.Remoting.Proxies;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Runtime.Remoting
{
	[global::Cpp2ILInjected.Token(Token = "0x2000340")]
	internal class ClientIdentity : Identity
	{
		[global::Cpp2ILInjected.Token(Token = "0x6001BCD")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B24F14", Offset = "0x1B24F14", Length = "0xF4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RemotingServices), Member = "GetOrCreateClientIdentity", MemberParameters = new object[]
		{
			typeof(ObjRef),
			typeof(global::System.Type),
			typeof(ref object)
		}, ReturnType = typeof(ClientIdentity))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public ClientIdentity(string objectUri, ObjRef objRef)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000332")]
		public global::System.MarshalByRefObject ClientProxy
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001BCE")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B25008", Offset = "0x1B25008", Length = "0x88")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RemotingServices), Member = "GetOrCreateClientIdentity", MemberParameters = new object[]
			{
				typeof(ObjRef),
				typeof(global::System.Type),
				typeof(ref object)
			}, ReturnType = typeof(ClientIdentity))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6001BCF")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B25090", Offset = "0x1B25090", Length = "0x68")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RemotingServices), Member = "GetOrCreateClientIdentity", MemberParameters = new object[]
			{
				typeof(ObjRef),
				typeof(global::System.Type),
				typeof(ref object)
			}, ReturnType = typeof(ClientIdentity))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Remoting.Proxies.RemotingProxy), Member = "AttachIdentity", MemberParameters = new object[] { typeof(Identity) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.WeakReference), Member = ".ctor", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001BD0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B250F8", Offset = "0x1B250F8", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public override ObjRef CreateObjRef(global::System.Type requestedType)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000333")]
		public string TargetUri
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001BD1")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B25100", Offset = "0x1B25100", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Remoting.Proxies.RemotingProxy), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(global::System.Type),
				typeof(ClientIdentity)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Remoting.Proxies.RemotingProxy), Member = "AttachIdentity", MemberParameters = new object[] { typeof(Identity) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x4000E28")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
		private global::System.WeakReference _proxyReference;
	}
}
