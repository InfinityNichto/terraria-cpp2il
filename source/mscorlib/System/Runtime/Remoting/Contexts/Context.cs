using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Activation;
using System.Runtime.Remoting.Messaging;
using System.Runtime.Remoting.Proxies;
using System.Threading;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Runtime.Remoting.Contexts
{
	[global::System.Runtime.InteropServices.ComVisible(true)]
	[global::Cpp2ILInjected.Token(Token = "0x2000365")]
	[StructLayout(0)]
	public class Context
	{
		[global::Cpp2ILInjected.Token(Token = "0x6001CDB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B39C74", Offset = "0x1B39C74", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[MethodImpl(4096)]
		private static extern void RegisterContext(Context ctx);

		[global::Cpp2ILInjected.Token(Token = "0x6001CDC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B39C78", Offset = "0x1B39C78", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[MethodImpl(4096)]
		private static extern void ReleaseContext(Context ctx);

		[global::Cpp2ILInjected.Token(Token = "0x6001CDD")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B39C7C", Offset = "0x1B39C7C", Length = "0x84")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Context), Member = "CreateNewContext", MemberParameters = new object[] { typeof(global::System.Runtime.Remoting.Activation.IConstructionCallMessage) }, ReturnType = typeof(Context))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Thread), Member = "GetDomainID", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Interlocked), Member = "Increment", MemberParameters = new object[] { typeof(ref int) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public Context()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001CDE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B39D00", Offset = "0x1B39D00", Length = "0xD0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "Finalize", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		protected override void Finalize()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x1700035C")]
		public static Context DefaultContext
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001CDF")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B31398", Offset = "0x1B31398", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RemotingServices), Member = "CreateClientActivatedServerIdentity", MemberParameters = new object[]
			{
				typeof(global::System.MarshalByRefObject),
				typeof(global::System.Type),
				typeof(string)
			}, ReturnType = typeof(ClientActivatedIdentity))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RemotingServices), Member = "CreateWellKnownServerIdentity", MemberParameters = new object[]
			{
				typeof(global::System.Type),
				typeof(string),
				typeof(WellKnownObjectMode)
			}, ReturnType = typeof(ServerIdentity))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.AppDomain), Member = "InternalGetDefaultContext", ReturnType = typeof(Context))]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x1700035D")]
		public virtual int ContextID
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001CE0")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B39DD0", Offset = "0x1B39DD0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x1700035E")]
		public virtual IContextProperty[] ContextProperties
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001CE1")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B39DD8", Offset = "0x1B39DD8", Length = "0x74")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Collections.Generic.List<object>), Member = "ToArray", ReturnType = "T[]")]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x1700035F")]
		internal bool IsDefaultContext
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001CE2")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B39E4C", Offset = "0x1B39E4C", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000360")]
		internal bool NeedsContextSink
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001CE3")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B39E5C", Offset = "0x1B39E5C", Length = "0xD0")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001CE4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B39F54", Offset = "0x1B39F54", Length = "0x70")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Context), Member = "GetDynamicPropertyCollection", MemberParameters = new object[]
		{
			typeof(global::System.ContextBoundObject),
			typeof(Context)
		}, ReturnType = typeof(DynamicPropertyCollection))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DynamicPropertyCollection), Member = "RegisterDynamicProperty", MemberParameters = new object[] { typeof(IDynamicProperty) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static bool RegisterDynamicProperty(IDynamicProperty prop, global::System.ContextBoundObject obj, Context ctx)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001CE5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B3A448", Offset = "0x1B3A448", Length = "0x70")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Context), Member = "GetDynamicPropertyCollection", MemberParameters = new object[]
		{
			typeof(global::System.ContextBoundObject),
			typeof(Context)
		}, ReturnType = typeof(DynamicPropertyCollection))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static bool UnregisterDynamicProperty(string name, global::System.ContextBoundObject obj, Context ctx)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001CE6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B39FC4", Offset = "0x1B39FC4", Length = "0x1C4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Context), Member = "RegisterDynamicProperty", MemberParameters = new object[]
		{
			typeof(IDynamicProperty),
			typeof(global::System.ContextBoundObject),
			typeof(Context)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Context), Member = "UnregisterDynamicProperty", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.ContextBoundObject),
			typeof(Context)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RemotingServices), Member = "IsTransparentProxy", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RemotingServices), Member = "GetRealProxy", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(global::System.Runtime.Remoting.Proxies.RealProxy))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Identity), Member = "get_ClientDynamicProperties", ReturnType = typeof(DynamicPropertyCollection))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DynamicPropertyCollection), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 17)]
		private static DynamicPropertyCollection GetDynamicPropertyCollection(global::System.ContextBoundObject obj, Context ctx)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001CE7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B3A67C", Offset = "0x1B3A67C", Length = "0xF0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Runtime.Remoting.Contexts.CrossContextChannel.ContextRestoreSink", Member = "SyncProcessMessage", MemberParameters = new object[] { typeof(global::System.Runtime.Remoting.Messaging.IMessage) }, ReturnType = typeof(global::System.Runtime.Remoting.Messaging.IMessage))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CrossContextChannel), Member = "SyncProcessMessage", MemberParameters = new object[] { typeof(global::System.Runtime.Remoting.Messaging.IMessage) }, ReturnType = typeof(global::System.Runtime.Remoting.Messaging.IMessage))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CrossContextChannel), Member = "AsyncProcessMessage", MemberParameters = new object[]
		{
			typeof(global::System.Runtime.Remoting.Messaging.IMessage),
			typeof(global::System.Runtime.Remoting.Messaging.IMessageSink)
		}, ReturnType = typeof(global::System.Runtime.Remoting.Messaging.IMessageCtrl))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Remoting.Messaging.ClientContextTerminatorSink), Member = "SyncProcessMessage", MemberParameters = new object[] { typeof(global::System.Runtime.Remoting.Messaging.IMessage) }, ReturnType = typeof(global::System.Runtime.Remoting.Messaging.IMessage))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Remoting.Messaging.ClientContextTerminatorSink), Member = "AsyncProcessMessage", MemberParameters = new object[]
		{
			typeof(global::System.Runtime.Remoting.Messaging.IMessage),
			typeof(global::System.Runtime.Remoting.Messaging.IMessageSink)
		}, ReturnType = typeof(global::System.Runtime.Remoting.Messaging.IMessageCtrl))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Remoting.Messaging.ClientContextReplySink), Member = "SyncProcessMessage", MemberParameters = new object[] { typeof(global::System.Runtime.Remoting.Messaging.IMessage) }, ReturnType = typeof(global::System.Runtime.Remoting.Messaging.IMessage))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 10)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		internal static void NotifyGlobalDynamicSinks(bool start, global::System.Runtime.Remoting.Messaging.IMessage req_msg, bool client_site, bool async)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000361")]
		internal static bool HasGlobalDynamicSinks
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001CE8")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B3AD7C", Offset = "0x1B3AD7C", Length = "0x98")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Context), Member = "get_HasExitSinks", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Remoting.Messaging.ClientContextTerminatorSink), Member = "AsyncProcessMessage", MemberParameters = new object[]
			{
				typeof(global::System.Runtime.Remoting.Messaging.IMessage),
				typeof(global::System.Runtime.Remoting.Messaging.IMessageSink)
			}, ReturnType = typeof(global::System.Runtime.Remoting.Messaging.IMessageCtrl))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001CE9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B3AE14", Offset = "0x1B3AE14", Length = "0x78")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Runtime.Remoting.Contexts.CrossContextChannel.ContextRestoreSink", Member = "SyncProcessMessage", MemberParameters = new object[] { typeof(global::System.Runtime.Remoting.Messaging.IMessage) }, ReturnType = typeof(global::System.Runtime.Remoting.Messaging.IMessage))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CrossContextChannel), Member = "SyncProcessMessage", MemberParameters = new object[] { typeof(global::System.Runtime.Remoting.Messaging.IMessage) }, ReturnType = typeof(global::System.Runtime.Remoting.Messaging.IMessage))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CrossContextChannel), Member = "AsyncProcessMessage", MemberParameters = new object[]
		{
			typeof(global::System.Runtime.Remoting.Messaging.IMessage),
			typeof(global::System.Runtime.Remoting.Messaging.IMessageSink)
		}, ReturnType = typeof(global::System.Runtime.Remoting.Messaging.IMessageCtrl))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Remoting.Messaging.ClientContextTerminatorSink), Member = "SyncProcessMessage", MemberParameters = new object[] { typeof(global::System.Runtime.Remoting.Messaging.IMessage) }, ReturnType = typeof(global::System.Runtime.Remoting.Messaging.IMessage))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Remoting.Messaging.ClientContextTerminatorSink), Member = "AsyncProcessMessage", MemberParameters = new object[]
		{
			typeof(global::System.Runtime.Remoting.Messaging.IMessage),
			typeof(global::System.Runtime.Remoting.Messaging.IMessageSink)
		}, ReturnType = typeof(global::System.Runtime.Remoting.Messaging.IMessageCtrl))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Remoting.Messaging.ClientContextReplySink), Member = "SyncProcessMessage", MemberParameters = new object[] { typeof(global::System.Runtime.Remoting.Messaging.IMessage) }, ReturnType = typeof(global::System.Runtime.Remoting.Messaging.IMessage))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 10)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DynamicPropertyCollection), Member = "NotifyMessage", MemberParameters = new object[]
		{
			typeof(bool),
			typeof(global::System.Runtime.Remoting.Messaging.IMessage),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(void))]
		internal void NotifyDynamicSinks(bool start, global::System.Runtime.Remoting.Messaging.IMessage req_msg, bool client_site, bool async)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000362")]
		internal bool HasDynamicSinks
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001CEA")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B3AE8C", Offset = "0x1B3AE8C", Length = "0x38")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000363")]
		internal bool HasExitSinks
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001CEB")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B373F4", Offset = "0x1B373F4", Length = "0xD0")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Remoting.Proxies.RemotingProxy), Member = "Invoke", MemberParameters = new object[] { typeof(global::System.Runtime.Remoting.Messaging.IMessage) }, ReturnType = typeof(global::System.Runtime.Remoting.Messaging.IMessage))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Remoting.Activation.ActivationServices), Member = "Activate", MemberParameters = new object[]
			{
				typeof(global::System.Runtime.Remoting.Proxies.RemotingProxy),
				typeof(global::System.Runtime.Remoting.Messaging.ConstructionCall)
			}, ReturnType = typeof(global::System.Runtime.Remoting.Messaging.IMessage))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Context), Member = "GetClientContextSinkChain", ReturnType = typeof(global::System.Runtime.Remoting.Messaging.IMessageSink))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Context), Member = "get_HasGlobalDynamicSinks", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001CEC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B3AEC4", Offset = "0x1B3AEC4", Length = "0x1CC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Collections.Generic.List<object>), Member = "GetEnumerator", ReturnType = "Enumerator<T>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Collections.Generic.List<object>.Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Collections.Generic.List<object>.Enumerator), Member = "Dispose", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 12)]
		public virtual IContextProperty GetProperty(string name)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001CED")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B3B090", Offset = "0x1B3B090", Length = "0x1A4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.AppDomain), Member = "InternalGetDefaultContext", ReturnType = typeof(Context))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Collections.Generic.List<object>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 15)]
		public virtual void SetProperty(IContextProperty prop)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001CEE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B3B234", Offset = "0x1B3B234", Length = "0x1A0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Collections.Generic.List<object>), Member = "GetEnumerator", ReturnType = "Enumerator<T>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Collections.Generic.List<object>.Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Collections.Generic.List<object>.Enumerator), Member = "Dispose", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 12)]
		public virtual void Freeze()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001CEF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B3B3D4", Offset = "0x1B3B3D4", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(int), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override string ToString()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001CF0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B3B430", Offset = "0x1B3B430", Length = "0x1BC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CrossContextChannel), Member = "SyncProcessMessage", MemberParameters = new object[] { typeof(global::System.Runtime.Remoting.Messaging.IMessage) }, ReturnType = typeof(global::System.Runtime.Remoting.Messaging.IMessage))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Remoting.Activation.ConstructionLevelActivator), Member = "Activate", MemberParameters = new object[] { typeof(global::System.Runtime.Remoting.Activation.IConstructionCallMessage) }, ReturnType = typeof(global::System.Runtime.Remoting.Activation.IConstructionReturnMessage))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Collections.Generic.List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
		internal global::System.Runtime.Remoting.Messaging.IMessageSink GetServerContextSinkChain()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001CF1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B374C4", Offset = "0x1B374C4", Length = "0x200")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Remoting.Proxies.RemotingProxy), Member = "Invoke", MemberParameters = new object[] { typeof(global::System.Runtime.Remoting.Messaging.IMessage) }, ReturnType = typeof(global::System.Runtime.Remoting.Messaging.IMessage))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Context), Member = "get_HasExitSinks", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Remoting.Activation.ActivationServices), Member = "Activate", MemberParameters = new object[]
		{
			typeof(global::System.Runtime.Remoting.Proxies.RemotingProxy),
			typeof(global::System.Runtime.Remoting.Messaging.ConstructionCall)
		}, ReturnType = typeof(global::System.Runtime.Remoting.Messaging.IMessage))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Remoting.Messaging.EnvoyTerminatorSink), Member = "SyncProcessMessage", MemberParameters = new object[] { typeof(global::System.Runtime.Remoting.Messaging.IMessage) }, ReturnType = typeof(global::System.Runtime.Remoting.Messaging.IMessage))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Remoting.Messaging.EnvoyTerminatorSink), Member = "AsyncProcessMessage", MemberParameters = new object[]
		{
			typeof(global::System.Runtime.Remoting.Messaging.IMessage),
			typeof(global::System.Runtime.Remoting.Messaging.IMessageSink)
		}, ReturnType = typeof(global::System.Runtime.Remoting.Messaging.IMessageCtrl))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Collections.Generic.List<object>), Member = "GetEnumerator", ReturnType = "Enumerator<T>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Collections.Generic.List<object>.Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Collections.Generic.List<object>.Enumerator), Member = "Dispose", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 15)]
		internal global::System.Runtime.Remoting.Messaging.IMessageSink GetClientContextSinkChain()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001CF2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B30F10", Offset = "0x1B30F10", Length = "0x1A8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ClientActivatedIdentity), Member = "SyncObjectProcessMessage", MemberParameters = new object[] { typeof(global::System.Runtime.Remoting.Messaging.IMessage) }, ReturnType = typeof(global::System.Runtime.Remoting.Messaging.IMessage))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ClientActivatedIdentity), Member = "AsyncObjectProcessMessage", MemberParameters = new object[]
		{
			typeof(global::System.Runtime.Remoting.Messaging.IMessage),
			typeof(global::System.Runtime.Remoting.Messaging.IMessageSink)
		}, ReturnType = typeof(global::System.Runtime.Remoting.Messaging.IMessageCtrl))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SingletonIdentity), Member = "SyncObjectProcessMessage", MemberParameters = new object[] { typeof(global::System.Runtime.Remoting.Messaging.IMessage) }, ReturnType = typeof(global::System.Runtime.Remoting.Messaging.IMessage))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SingletonIdentity), Member = "AsyncObjectProcessMessage", MemberParameters = new object[]
		{
			typeof(global::System.Runtime.Remoting.Messaging.IMessage),
			typeof(global::System.Runtime.Remoting.Messaging.IMessageSink)
		}, ReturnType = typeof(global::System.Runtime.Remoting.Messaging.IMessageCtrl))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SingleCallIdentity), Member = "SyncObjectProcessMessage", MemberParameters = new object[] { typeof(global::System.Runtime.Remoting.Messaging.IMessage) }, ReturnType = typeof(global::System.Runtime.Remoting.Messaging.IMessage))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SingleCallIdentity), Member = "AsyncObjectProcessMessage", MemberParameters = new object[]
		{
			typeof(global::System.Runtime.Remoting.Messaging.IMessage),
			typeof(global::System.Runtime.Remoting.Messaging.IMessageSink)
		}, ReturnType = typeof(global::System.Runtime.Remoting.Messaging.IMessageCtrl))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.Remoting.Messaging.StackBuilderSink), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(global::System.MarshalByRefObject),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.Remoting.Messaging.ServerObjectTerminatorSink), Member = ".ctor", MemberParameters = new object[] { typeof(global::System.Runtime.Remoting.Messaging.IMessageSink) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Collections.Generic.List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
		internal global::System.Runtime.Remoting.Messaging.IMessageSink CreateServerObjectSinkChain(global::System.MarshalByRefObject obj, bool forceInternalExecute)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001CF3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B3B61C", Offset = "0x1B3B61C", Length = "0x204")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Collections.Generic.List<object>), Member = "GetEnumerator", ReturnType = "Enumerator<T>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Collections.Generic.List<object>.Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Collections.Generic.List<object>.Enumerator), Member = "Dispose", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 15)]
		internal global::System.Runtime.Remoting.Messaging.IMessageSink CreateEnvoySink(global::System.MarshalByRefObject serverObject)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001CF4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B3B820", Offset = "0x1B3B820", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.AppDomain), Member = "InternalSetContext", MemberParameters = new object[] { typeof(Context) }, ReturnType = typeof(Context))]
		internal static Context SwitchToContext(Context newContext)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001CF5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B3B828", Offset = "0x1B3B828", Length = "0x800")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Remoting.Activation.ContextLevelActivator), Member = "Activate", MemberParameters = new object[] { typeof(global::System.Runtime.Remoting.Activation.IConstructionCallMessage) }, ReturnType = typeof(global::System.Runtime.Remoting.Activation.IConstructionReturnMessage))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Context), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RemotingException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 46)]
		internal static Context CreateNewContext(global::System.Runtime.Remoting.Activation.IConstructionCallMessage msg)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001CF6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B3C028", Offset = "0x1B3C028", Length = "0x150")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Monitor), Member = "Enter", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.AppDomain), Member = "InternalSetContext", MemberParameters = new object[] { typeof(Context) }, ReturnType = typeof(Context))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ContextBoundObject), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		public void DoCallBack(CrossContextDelegate deleg)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000364")]
		private global::System.LocalDataStore MyLocalStore
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001CF7")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B3C184", Offset = "0x1B3C184", Length = "0x160")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Context), Member = "GetData", MemberParameters = new object[] { typeof(global::System.LocalDataStoreSlot) }, ReturnType = typeof(object))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Context), Member = "SetData", MemberParameters = new object[]
			{
				typeof(global::System.LocalDataStoreSlot),
				typeof(object)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Monitor), Member = "Enter", MemberParameters = new object[]
			{
				typeof(object),
				typeof(ref bool)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.LocalDataStoreMgr), Member = "CreateLocalDataStore", ReturnType = typeof(global::System.LocalDataStoreHolder))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 13)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001CF8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B3C2E4", Offset = "0x1B3C2E4", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.LocalDataStoreMgr), Member = "AllocateDataSlot", ReturnType = typeof(global::System.LocalDataStoreSlot))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static global::System.LocalDataStoreSlot AllocateDataSlot()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001CF9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B3C340", Offset = "0x1B3C340", Length = "0x64")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.LocalDataStoreMgr), Member = "AllocateNamedDataSlot", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(global::System.LocalDataStoreSlot))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static global::System.LocalDataStoreSlot AllocateNamedDataSlot(string name)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001CFA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B3C3A4", Offset = "0x1B3C3A4", Length = "0x64")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.LocalDataStoreMgr), Member = "FreeNamedDataSlot", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static void FreeNamedDataSlot(string name)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001CFB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B3C408", Offset = "0x1B3C408", Length = "0x64")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.LocalDataStoreMgr), Member = "GetNamedDataSlot", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(global::System.LocalDataStoreSlot))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static global::System.LocalDataStoreSlot GetNamedDataSlot(string name)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001CFC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B3C46C", Offset = "0x1B3C46C", Length = "0x24")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Thread), Member = "get_CurrentContext", ReturnType = typeof(Context))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Context), Member = "get_MyLocalStore", ReturnType = typeof(global::System.LocalDataStore))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.LocalDataStore), Member = "GetData", MemberParameters = new object[] { typeof(global::System.LocalDataStoreSlot) }, ReturnType = typeof(object))]
		public static object GetData(global::System.LocalDataStoreSlot slot)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001CFD")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B3C490", Offset = "0x1B3C490", Length = "0x34")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Thread), Member = "get_CurrentContext", ReturnType = typeof(Context))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Context), Member = "get_MyLocalStore", ReturnType = typeof(global::System.LocalDataStore))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.LocalDataStore), Member = "SetData", MemberParameters = new object[]
		{
			typeof(global::System.LocalDataStoreSlot),
			typeof(object)
		}, ReturnType = typeof(void))]
		public static void SetData(global::System.LocalDataStoreSlot slot, object data)
		{
			throw null;
		}

		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x6001CFE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B3C4C4", Offset = "0x1B3C4C4", Length = "0x70")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.LocalDataStoreMgr), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		static Context()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x4000EA1")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private int domain_id;

		[global::Cpp2ILInjected.Token(Token = "0x4000EA2")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
		private int context_id;

		[global::Cpp2ILInjected.Token(Token = "0x4000EA3")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private global::System.UIntPtr static_data;

		[global::Cpp2ILInjected.Token(Token = "0x4000EA4")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private global::System.UIntPtr data;

		[global::System.ContextStatic]
		[global::Cpp2ILInjected.Token(Token = "0x4000EA5")]
		private static object[] local_slots;

		[global::Cpp2ILInjected.Token(Token = "0x4000EA6")]
		private static global::System.Runtime.Remoting.Messaging.IMessageSink default_server_context_sink;

		[global::Cpp2ILInjected.Token(Token = "0x4000EA7")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private global::System.Runtime.Remoting.Messaging.IMessageSink server_context_sink_chain;

		[global::Cpp2ILInjected.Token(Token = "0x4000EA8")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private global::System.Runtime.Remoting.Messaging.IMessageSink client_context_sink_chain;

		[global::Cpp2ILInjected.Token(Token = "0x4000EA9")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		private global::System.Collections.Generic.List<IContextProperty> context_properties;

		[global::Cpp2ILInjected.Token(Token = "0x4000EAA")]
		private static int global_count;

		[global::Cpp2ILInjected.Token(Token = "0x4000EAB")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		private global::System.LocalDataStoreHolder _localDataStore;

		[global::Cpp2ILInjected.Token(Token = "0x4000EAC")]
		private static global::System.LocalDataStoreMgr _localDataStoreMgr;

		[global::Cpp2ILInjected.Token(Token = "0x4000EAD")]
		private static DynamicPropertyCollection global_dynamic_properties;

		[global::Cpp2ILInjected.Token(Token = "0x4000EAE")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
		private DynamicPropertyCollection context_dynamic_properties;

		[global::Cpp2ILInjected.Token(Token = "0x4000EAF")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
		private ContextCallbackObject callback_object;
	}
}
