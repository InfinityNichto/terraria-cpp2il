using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Activation;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Contexts;
using System.Runtime.Remoting.Messaging;
using System.Security.Policy;
using System.Threading;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System
{
	// Token: 0x02000121 RID: 289
	[global::System.Runtime.InteropServices.ComVisible(true)]
	[global::System.Runtime.InteropServices.ClassInterface(global::System.Runtime.InteropServices.ClassInterfaceType.None)]
	[global::Cpp2ILInjected.Token(Token = "0x2000162")]
	[StructLayout(0)]
	public sealed class AppDomain : global::System.MarshalByRefObject
	{
		// Token: 0x06000D61 RID: 3425 RVA: 0x00016B83 File Offset: 0x00014D83
		[global::System.Runtime.CompilerServices.Intrinsic]
		[global::Cpp2ILInjected.Token(Token = "0x6000E3F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C77400", Offset = "0x1C77400", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		internal static bool IsAppXModel()
		{
			throw null;
		}

		// Token: 0x06000D62 RID: 3426 RVA: 0x00016B86 File Offset: 0x00014D86
		[global::Cpp2ILInjected.Token(Token = "0x6000E40")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C77408", Offset = "0x1C77408", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private AppDomain()
		{
			throw null;
		}

		// Token: 0x06000D63 RID: 3427
		[global::Cpp2ILInjected.Token(Token = "0x6000E41")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C77410", Offset = "0x1C77410", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[MethodImpl(4096)]
		private extern string getFriendlyName();

		// Token: 0x06000D64 RID: 3428
		[global::Cpp2ILInjected.Token(Token = "0x6000E42")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C77414", Offset = "0x1C77414", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[MethodImpl(4096)]
		private static extern global::System.AppDomain getCurDomain();

		// Token: 0x17000120 RID: 288
		// (get) Token: 0x06000D65 RID: 3429 RVA: 0x00016B89 File Offset: 0x00014D89
		[global::Cpp2ILInjected.Token(Token = "0x17000142")]
		public static global::System.AppDomain CurrentDomain
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000E43")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C77418", Offset = "0x1C77418", Length = "0x4")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Program", Member = "ForceLoadAssembly", MemberParameters = new object[]
			{
				typeof(string),
				typeof(bool)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Utilities.CrashWatcher", Member = "Inititialize", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Threading.ThreadPoolWorkQueueThreadLocals), Member = "Finalize", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Remoting.Channels.CrossAppDomainSink), Member = "ProcessMessageInDomain", MemberParameters = new object[]
			{
				typeof(byte[]),
				typeof(global::System.Runtime.Remoting.Messaging.CADMethodCallMessage)
			}, ReturnType = "System.Runtime.Remoting.Channels.CrossAppDomainSink.ProcessMessageRes")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Reflection.Assembly), Member = "InternalGetSatelliteAssembly", MemberParameters = new object[]
			{
				typeof(string),
				typeof(global::System.Globalization.CultureInfo),
				typeof(global::System.Version),
				typeof(bool),
				typeof(ref global::System.Threading.StackCrawlMark)
			}, ReturnType = typeof(global::System.Reflection.RuntimeAssembly))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Reflection.Assembly), Member = "Load", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(global::System.Reflection.Assembly))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Reflection.Assembly), Member = "ReflectionOnlyLoad", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(global::System.Reflection.Assembly))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Reflection.RuntimeAssembly), Member = "GetManifestResourceStream", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(global::System.IO.Stream))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Text.RegularExpressions.Regex", Member = "InitDefaultMatchTimeout", ReturnType = typeof(global::System.TimeSpan))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.NclUtilities", Member = "get_HasShutdownStarted", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.TimerThread", Member = ".cctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.ComponentModel.Design.RuntimeLicenseContext", Member = "GetSavedLicenseKey", MemberParameters = new object[]
			{
				typeof(global::System.Type),
				typeof(global::System.Reflection.Assembly)
			}, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "InControl.Reflector", Member = "GetAllAssemblyTypes", ReturnType = "System.Collections.Generic.IEnumerable`1<Type>")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Serialization.DefaultSerializationBinder", Member = "GetTypeFromTypeNameKey", MemberParameters = new object[] { "Newtonsoft.Json.Serialization.DefaultSerializationBinder.TypeNameKey" }, ReturnType = typeof(global::System.Type))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UnhandledExceptionHandler", Member = "RegisterUECatcher", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 16)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06000D66 RID: 3430
		[global::Cpp2ILInjected.Token(Token = "0x6000E44")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C7741C", Offset = "0x1C7741C", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[MethodImpl(4096)]
		private extern global::System.Reflection.Assembly[] GetAssemblies(bool refOnly);

		// Token: 0x06000D67 RID: 3431 RVA: 0x00016B8C File Offset: 0x00014D8C
		[global::Cpp2ILInjected.Token(Token = "0x6000E45")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C77424", Offset = "0x1C77424", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Program", Member = "ForceLoadAssembly", MemberParameters = new object[]
		{
			typeof(string),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.ComponentModel.Design.RuntimeLicenseContext", Member = "GetSavedLicenseKey", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(global::System.Reflection.Assembly)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "InControl.Reflector", Member = "GetAllAssemblyTypes", ReturnType = "System.Collections.Generic.IEnumerable`1<Type>")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Serialization.DefaultSerializationBinder", Member = "GetTypeFromTypeNameKey", MemberParameters = new object[] { "Newtonsoft.Json.Serialization.DefaultSerializationBinder.TypeNameKey" }, ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public global::System.Reflection.Assembly[] GetAssemblies()
		{
			throw null;
		}

		// Token: 0x06000D68 RID: 3432
		[global::Cpp2ILInjected.Token(Token = "0x6000E46")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C7742C", Offset = "0x1C7742C", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Text.RegularExpressions.Regex", Member = "InitDefaultMatchTimeout", ReturnType = typeof(global::System.TimeSpan))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[MethodImpl(4096)]
		public extern object GetData(string name);

		// Token: 0x06000D69 RID: 3433 RVA: 0x00016B8F File Offset: 0x00014D8F
		[global::Cpp2ILInjected.Token(Token = "0x6000E47")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C77430", Offset = "0x1C77430", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public override object InitializeLifetimeService()
		{
			throw null;
		}

		// Token: 0x06000D6A RID: 3434
		[global::Cpp2ILInjected.Token(Token = "0x6000E48")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C77438", Offset = "0x1C77438", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[MethodImpl(4096)]
		internal extern global::System.Reflection.Assembly LoadAssembly(string assemblyRef, global::System.Security.Policy.Evidence securityEvidence, bool refOnly, ref global::System.Threading.StackCrawlMark stackMark);

		// Token: 0x06000D6B RID: 3435 RVA: 0x00016B92 File Offset: 0x00014D92
		[global::Cpp2ILInjected.Token(Token = "0x6000E49")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C77440", Offset = "0x1C77440", Length = "0xF8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Reflection.Assembly), Member = "InternalGetSatelliteAssembly", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.Globalization.CultureInfo),
			typeof(global::System.Version),
			typeof(bool),
			typeof(ref global::System.Threading.StackCrawlMark)
		}, ReturnType = typeof(global::System.Reflection.RuntimeAssembly))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Reflection.AssemblyName), Member = "get_FullName", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Reflection.Assembly), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(global::System.Reflection.Assembly),
			typeof(global::System.Reflection.Assembly)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.IO.FileNotFoundException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		internal global::System.Reflection.Assembly LoadSatellite(global::System.Reflection.AssemblyName assemblyRef, bool throwOnError, ref global::System.Threading.StackCrawlMark stackMark)
		{
			throw null;
		}

		// Token: 0x06000D6C RID: 3436 RVA: 0x00016B95 File Offset: 0x00014D95
		[global::Cpp2ILInjected.Token(Token = "0x6000E4A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C77538", Offset = "0x1C77538", Length = "0x24")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Reflection.Assembly), Member = "Load", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(global::System.Reflection.Assembly))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.AppDomain), Member = "Load", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.Security.Policy.Evidence),
			typeof(bool),
			typeof(ref global::System.Threading.StackCrawlMark)
		}, ReturnType = typeof(global::System.Reflection.Assembly))]
		[MethodImpl(8)]
		public global::System.Reflection.Assembly Load(string assemblyString)
		{
			throw null;
		}

		// Token: 0x06000D6D RID: 3437 RVA: 0x00016B98 File Offset: 0x00014D98
		[global::Cpp2ILInjected.Token(Token = "0x6000E4B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C7755C", Offset = "0x1C7755C", Length = "0x100")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.AppDomain), Member = "Load", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(global::System.Reflection.Assembly))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Reflection.Assembly), Member = "ReflectionOnlyLoad", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(global::System.Reflection.Assembly))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Reflection.Assembly), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(global::System.Reflection.Assembly),
			typeof(global::System.Reflection.Assembly)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.IO.FileNotFoundException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 13)]
		internal global::System.Reflection.Assembly Load(string assemblyString, global::System.Security.Policy.Evidence assemblySecurity, bool refonly, ref global::System.Threading.StackCrawlMark stackMark)
		{
			throw null;
		}

		// Token: 0x06000D6E RID: 3438
		[global::Cpp2ILInjected.Token(Token = "0x6000E4C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C7765C", Offset = "0x1C7765C", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[MethodImpl(4096)]
		private static extern global::System.AppDomain InternalSetDomainByID(int domain_id);

		// Token: 0x06000D6F RID: 3439
		[global::Cpp2ILInjected.Token(Token = "0x6000E4D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C77660", Offset = "0x1C77660", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[MethodImpl(4096)]
		private static extern global::System.AppDomain InternalSetDomain(global::System.AppDomain context);

		// Token: 0x06000D70 RID: 3440
		[global::Cpp2ILInjected.Token(Token = "0x6000E4E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C77664", Offset = "0x1C77664", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[MethodImpl(4096)]
		internal static extern void InternalPushDomainRefByID(int domain_id);

		// Token: 0x06000D71 RID: 3441
		[global::Cpp2ILInjected.Token(Token = "0x6000E4F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C77668", Offset = "0x1C77668", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[MethodImpl(4096)]
		internal static extern void InternalPopDomainRef();

		// Token: 0x06000D72 RID: 3442
		[global::Cpp2ILInjected.Token(Token = "0x6000E50")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C7766C", Offset = "0x1C7766C", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Remoting.Contexts.Context), Member = "SwitchToContext", MemberParameters = new object[] { typeof(global::System.Runtime.Remoting.Contexts.Context) }, ReturnType = typeof(global::System.Runtime.Remoting.Contexts.Context))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Remoting.Contexts.Context), Member = "DoCallBack", MemberParameters = new object[] { typeof(global::System.Runtime.Remoting.Contexts.CrossContextDelegate) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Runtime.Remoting.Contexts.CrossContextChannel.ContextRestoreSink", Member = "SyncProcessMessage", MemberParameters = new object[] { typeof(global::System.Runtime.Remoting.Messaging.IMessage) }, ReturnType = typeof(global::System.Runtime.Remoting.Messaging.IMessage))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Remoting.Contexts.CrossContextChannel), Member = "SyncProcessMessage", MemberParameters = new object[] { typeof(global::System.Runtime.Remoting.Messaging.IMessage) }, ReturnType = typeof(global::System.Runtime.Remoting.Messaging.IMessage))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Remoting.Contexts.CrossContextChannel), Member = "AsyncProcessMessage", MemberParameters = new object[]
		{
			typeof(global::System.Runtime.Remoting.Messaging.IMessage),
			typeof(global::System.Runtime.Remoting.Messaging.IMessageSink)
		}, ReturnType = typeof(global::System.Runtime.Remoting.Messaging.IMessageCtrl))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Remoting.Channels.CrossAppDomainSink), Member = "SyncProcessMessage", MemberParameters = new object[] { typeof(global::System.Runtime.Remoting.Messaging.IMessage) }, ReturnType = typeof(global::System.Runtime.Remoting.Messaging.IMessage))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Remoting.Activation.ContextLevelActivator), Member = "Activate", MemberParameters = new object[] { typeof(global::System.Runtime.Remoting.Activation.IConstructionCallMessage) }, ReturnType = typeof(global::System.Runtime.Remoting.Activation.IConstructionReturnMessage))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 16)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[MethodImpl(4096)]
		internal static extern global::System.Runtime.Remoting.Contexts.Context InternalSetContext(global::System.Runtime.Remoting.Contexts.Context context);

		// Token: 0x06000D73 RID: 3443
		[global::Cpp2ILInjected.Token(Token = "0x6000E51")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C77670", Offset = "0x1C77670", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Threading.Thread), Member = "get_CurrentContext", ReturnType = typeof(global::System.Runtime.Remoting.Contexts.Context))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[MethodImpl(4096)]
		internal static extern global::System.Runtime.Remoting.Contexts.Context InternalGetContext();

		// Token: 0x06000D74 RID: 3444
		[global::Cpp2ILInjected.Token(Token = "0x6000E52")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C77674", Offset = "0x1C77674", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Remoting.SingletonIdentity), Member = "GetServerObject", ReturnType = typeof(global::System.MarshalByRefObject))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Remoting.Contexts.Context), Member = "get_DefaultContext", ReturnType = typeof(global::System.Runtime.Remoting.Contexts.Context))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Remoting.Contexts.Context), Member = "SetProperty", MemberParameters = new object[] { typeof(global::System.Runtime.Remoting.Contexts.IContextProperty) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[MethodImpl(4096)]
		internal static extern global::System.Runtime.Remoting.Contexts.Context InternalGetDefaultContext();

		// Token: 0x06000D75 RID: 3445
		[global::Cpp2ILInjected.Token(Token = "0x6000E53")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C77678", Offset = "0x1C77678", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[MethodImpl(4096)]
		internal static extern string InternalGetProcessGuid(string newguid);

		// Token: 0x06000D76 RID: 3446 RVA: 0x00016B9B File Offset: 0x00014D9B
		[global::Cpp2ILInjected.Token(Token = "0x6000E54")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C7767C", Offset = "0x1C7767C", Length = "0x18C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Remoting.Channels.CrossAppDomainSink), Member = "SyncProcessMessage", MemberParameters = new object[] { typeof(global::System.Runtime.Remoting.Messaging.IMessage) }, ReturnType = typeof(global::System.Runtime.Remoting.Messaging.IMessage))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Reflection.RuntimeMethodInfo), Member = "InternalInvoke", MemberParameters = new object[]
		{
			typeof(object),
			typeof(object[]),
			typeof(ref global::System.Exception)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 18)]
		internal static object InvokeInDomainByID(int domain_id, global::System.Reflection.MethodInfo method, object obj, object[] args)
		{
			throw null;
		}

		// Token: 0x06000D77 RID: 3447 RVA: 0x00016B9E File Offset: 0x00014D9E
		[global::Cpp2ILInjected.Token(Token = "0x6000E55")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C77808", Offset = "0x1C77808", Length = "0x88")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Remoting.RemotingConfiguration), Member = "get_ProcessId", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Guid), Member = "NewGuid", ReturnType = typeof(global::System.Guid))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Guid), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal static string GetProcessGuid()
		{
			throw null;
		}

		// Token: 0x06000D78 RID: 3448
		[global::Cpp2ILInjected.Token(Token = "0x6000E56")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C77890", Offset = "0x1C77890", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[MethodImpl(4096)]
		private static extern bool InternalIsFinalizingForUnload(int domain_id);

		// Token: 0x06000D79 RID: 3449 RVA: 0x00016BA1 File Offset: 0x00014DA1
		[global::Cpp2ILInjected.Token(Token = "0x6000E57")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C77894", Offset = "0x1C77894", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Threading.ThreadPoolWorkQueueThreadLocals), Member = "Finalize", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.NclUtilities", Member = "get_HasShutdownStarted", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Thread), Member = "GetDomainID", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public bool IsFinalizingForUnload()
		{
			throw null;
		}

		// Token: 0x06000D7A RID: 3450 RVA: 0x00016BA4 File Offset: 0x00014DA4
		[global::Cpp2ILInjected.Token(Token = "0x6000E58")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C778A8", Offset = "0x1C778A8", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Thread), Member = "GetDomainID", ReturnType = typeof(int))]
		private int getDomainID()
		{
			throw null;
		}

		// Token: 0x06000D7B RID: 3451 RVA: 0x00016BA7 File Offset: 0x00014DA7
		[global::Cpp2ILInjected.Token(Token = "0x6000E59")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C778B0", Offset = "0x1C778B0", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override string ToString()
		{
			throw null;
		}

		// Token: 0x06000D7C RID: 3452 RVA: 0x00016BAA File Offset: 0x00014DAA
		[global::Cpp2ILInjected.Token(Token = "0x6000E5A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C778B4", Offset = "0x1C778B4", Length = "0x90")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.AssemblyLoadEventArgs), Member = ".ctor", MemberParameters = new object[] { typeof(global::System.Reflection.Assembly) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		private void DoAssemblyLoad(global::System.Reflection.Assembly assembly)
		{
			throw null;
		}

		// Token: 0x06000D7D RID: 3453 RVA: 0x00016BAD File Offset: 0x00014DAD
		[global::Cpp2ILInjected.Token(Token = "0x6000E5B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C77944", Offset = "0x1C77944", Length = "0x2EC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Collections.Generic.Dictionary<object, object>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Collections.Generic.Dictionary<object, object>), Member = "ContainsKey", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Collections.Generic.Dictionary<object, object>), Member = "set_Item", MemberParameters = new object[]
		{
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ResolveEventArgs), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.Reflection.Assembly)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Reflection.Assembly), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(global::System.Reflection.Assembly),
			typeof(global::System.Reflection.Assembly)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Collections.Generic.Dictionary<object, object>), Member = "Remove", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 22)]
		private global::System.Reflection.Assembly DoAssemblyResolve(string name, global::System.Reflection.Assembly requestingAssembly, bool refonly)
		{
			throw null;
		}

		// Token: 0x06000D7E RID: 3454 RVA: 0x00016BB0 File Offset: 0x00014DB0
		[global::Cpp2ILInjected.Token(Token = "0x6000E5C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C77C30", Offset = "0x1C77C30", Length = "0x290")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Collections.Generic.Dictionary<object, object>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Collections.Generic.Dictionary<object, object>), Member = "ContainsKey", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Collections.Generic.Dictionary<object, object>), Member = "set_Item", MemberParameters = new object[]
		{
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ResolveEventArgs), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Reflection.Assembly), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(global::System.Reflection.Assembly),
			typeof(global::System.Reflection.Assembly)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Collections.Generic.Dictionary<object, object>), Member = "Remove", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 20)]
		internal global::System.Reflection.Assembly DoTypeResolve(string name)
		{
			throw null;
		}

		// Token: 0x06000D7F RID: 3455 RVA: 0x00016BB3 File Offset: 0x00014DB3
		[global::Cpp2ILInjected.Token(Token = "0x6000E5D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C77EC0", Offset = "0x1C77EC0", Length = "0x128")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Reflection.RuntimeAssembly), Member = "GetManifestResourceStream", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(global::System.IO.Stream))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ResolveEventArgs), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.Reflection.Assembly)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Reflection.Assembly), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(global::System.Reflection.Assembly),
			typeof(global::System.Reflection.Assembly)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		internal global::System.Reflection.Assembly DoResourceResolve(string name, global::System.Reflection.Assembly requesting)
		{
			throw null;
		}

		// Token: 0x06000D80 RID: 3456 RVA: 0x00016BB6 File Offset: 0x00014DB6
		[global::Cpp2ILInjected.Token(Token = "0x6000E5E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C77FE8", Offset = "0x1C77FE8", Length = "0x24")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		private void DoDomainUnload()
		{
			throw null;
		}

		// Token: 0x06000D81 RID: 3457 RVA: 0x00016BB9 File Offset: 0x00014DB9
		[global::Cpp2ILInjected.Token(Token = "0x6000E5F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C7800C", Offset = "0x1C7800C", Length = "0xD0")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(global::System.RuntimeTypeHandle) }, ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.Remoting.RemotingServices), Member = "Marshal", MemberParameters = new object[]
		{
			typeof(global::System.MarshalByRefObject),
			typeof(string),
			typeof(global::System.Type)
		}, ReturnType = typeof(global::System.Runtime.Remoting.ObjRef))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.Remoting.Channels.CADSerializer), Member = "SerializeObject", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(global::System.IO.MemoryStream))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		internal byte[] GetMarshalledDomainObjRef()
		{
			throw null;
		}

		// Token: 0x06000D82 RID: 3458 RVA: 0x00016BBC File Offset: 0x00014DBC
		[global::Cpp2ILInjected.Token(Token = "0x6000E60")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C780DC", Offset = "0x1C780DC", Length = "0x120")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Remoting.Channels.CrossAppDomainSink), Member = "ProcessMessageInDomain", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(global::System.Runtime.Remoting.Messaging.CADMethodCallMessage)
		}, ReturnType = "System.Runtime.Remoting.Channels.CrossAppDomainSink.ProcessMessageRes")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.IO.MemoryStream), Member = ".ctor", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.Remoting.Channels.CADSerializer), Member = "DeserializeMessage", MemberParameters = new object[]
		{
			typeof(global::System.IO.MemoryStream),
			typeof(global::System.Runtime.Remoting.Messaging.IMethodCallMessage)
		}, ReturnType = typeof(global::System.Runtime.Remoting.Messaging.IMessage))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.Remoting.Messaging.MethodCall), Member = ".ctor", MemberParameters = new object[] { typeof(global::System.Runtime.Remoting.Messaging.CADMethodCallMessage) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.Remoting.Channels.ChannelServices), Member = "SyncDispatchMessage", MemberParameters = new object[] { typeof(global::System.Runtime.Remoting.Messaging.IMessage) }, ReturnType = typeof(global::System.Runtime.Remoting.Messaging.IMessage))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.Remoting.Messaging.CADMethodReturnMessage), Member = "Create", MemberParameters = new object[] { typeof(global::System.Runtime.Remoting.Messaging.IMessage) }, ReturnType = typeof(global::System.Runtime.Remoting.Messaging.CADMethodReturnMessage))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.Remoting.Channels.CADSerializer), Member = "SerializeMessage", MemberParameters = new object[] { typeof(global::System.Runtime.Remoting.Messaging.IMessage) }, ReturnType = typeof(global::System.IO.MemoryStream))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		internal void ProcessMessageInDomain(byte[] arrRequest, global::System.Runtime.Remoting.Messaging.CADMethodCallMessage cadMsg, out byte[] arrResponse, out global::System.Runtime.Remoting.Messaging.CADMethodReturnMessage cadMrm)
		{
			throw null;
		}

		// Token: 0x14000003 RID: 3
		// (add) Token: 0x06000D83 RID: 3459 RVA: 0x00016BBF File Offset: 0x00014DBF
		// (remove) Token: 0x06000D84 RID: 3460 RVA: 0x00016BC2 File Offset: 0x00014DC2
		[global::Cpp2ILInjected.Token(Token = "0x14000003")]
		public event global::System.EventHandler DomainUnload
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6000E61")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C781FC", Offset = "0x1C781FC", Length = "0x98")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.TimerThread", Member = ".cctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Delegate), Member = "Combine", MemberParameters = new object[]
			{
				typeof(global::System.Delegate),
				typeof(global::System.Delegate)
			}, ReturnType = typeof(global::System.Delegate))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			add
			{
				throw null;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6000E62")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C783E0", Offset = "0x1C783E0", Length = "0x98")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Delegate), Member = "Remove", MemberParameters = new object[]
			{
				typeof(global::System.Delegate),
				typeof(global::System.Delegate)
			}, ReturnType = typeof(global::System.Delegate))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			remove
			{
				throw null;
			}
		}

		// Token: 0x14000004 RID: 4
		// (add) Token: 0x06000D85 RID: 3461 RVA: 0x00016BC5 File Offset: 0x00014DC5
		// (remove) Token: 0x06000D86 RID: 3462 RVA: 0x00016BC8 File Offset: 0x00014DC8
		[global::Cpp2ILInjected.Token(Token = "0x14000004")]
		public event global::System.UnhandledExceptionEventHandler UnhandledException
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6000E63")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C785C0", Offset = "0x1C785C0", Length = "0x98")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Utilities.CrashWatcher", Member = "Inititialize", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UnhandledExceptionHandler", Member = "RegisterUECatcher", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Delegate), Member = "Combine", MemberParameters = new object[]
			{
				typeof(global::System.Delegate),
				typeof(global::System.Delegate)
			}, ReturnType = typeof(global::System.Delegate))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			add
			{
				throw null;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6000E64")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C78658", Offset = "0x1C78658", Length = "0x98")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Delegate), Member = "Remove", MemberParameters = new object[]
			{
				typeof(global::System.Delegate),
				typeof(global::System.Delegate)
			}, ReturnType = typeof(global::System.Delegate))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			remove
			{
				throw null;
			}
		}

		// Token: 0x14000005 RID: 5
		// (add) Token: 0x06000D87 RID: 3463 RVA: 0x00016BCB File Offset: 0x00014DCB
		// (remove) Token: 0x06000D88 RID: 3464 RVA: 0x00016BCE File Offset: 0x00014DCE
		[global::Cpp2ILInjected.Token(Token = "0x14000005")]
		public event global::System.EventHandler<global::System.Runtime.ExceptionServices.FirstChanceExceptionEventArgs> FirstChanceException
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6000E65")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C786F0", Offset = "0x1C786F0", Length = "0xAC")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Utilities.CrashWatcher", Member = "Inititialize", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Delegate), Member = "Combine", MemberParameters = new object[]
			{
				typeof(global::System.Delegate),
				typeof(global::System.Delegate)
			}, ReturnType = typeof(global::System.Delegate))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			add
			{
				throw null;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6000E66")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C7879C", Offset = "0x1C7879C", Length = "0xAC")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Delegate), Member = "Remove", MemberParameters = new object[]
			{
				typeof(global::System.Delegate),
				typeof(global::System.Delegate)
			}, ReturnType = typeof(global::System.Delegate))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			remove
			{
				throw null;
			}
		}

		// Token: 0x0400044F RID: 1103
		[global::Cpp2ILInjected.Token(Token = "0x40005E1")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private global::System.IntPtr _mono_app_domain;

		// Token: 0x04000450 RID: 1104
		[global::Cpp2ILInjected.Token(Token = "0x40005E2")]
		private static string _process_guid;

		// Token: 0x04000451 RID: 1105
		[global::System.ThreadStatic]
		[global::Cpp2ILInjected.Token(Token = "0x40005E3")]
		private static global::System.Collections.Generic.Dictionary<string, object> type_resolve_in_progress;

		// Token: 0x04000452 RID: 1106
		[global::System.ThreadStatic]
		[global::Cpp2ILInjected.Token(Token = "0x40005E4")]
		private static global::System.Collections.Generic.Dictionary<string, object> assembly_resolve_in_progress;

		// Token: 0x04000453 RID: 1107
		[global::System.ThreadStatic]
		[global::Cpp2ILInjected.Token(Token = "0x40005E5")]
		private static global::System.Collections.Generic.Dictionary<string, object> assembly_resolve_in_progress_refonly;

		// Token: 0x04000454 RID: 1108
		[global::Cpp2ILInjected.Token(Token = "0x40005E6")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private object _evidence;

		// Token: 0x04000455 RID: 1109
		[global::Cpp2ILInjected.Token(Token = "0x40005E7")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private object _granted;

		// Token: 0x04000456 RID: 1110
		[global::Cpp2ILInjected.Token(Token = "0x40005E8")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private int _principalPolicy;

		// Token: 0x04000457 RID: 1111
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x40005E9")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		private global::System.AssemblyLoadEventHandler AssemblyLoad;

		// Token: 0x04000458 RID: 1112
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x40005EA")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		private global::System.ResolveEventHandler AssemblyResolve;

		// Token: 0x04000459 RID: 1113
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x40005EB")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
		private global::System.EventHandler DomainUnload;

		// Token: 0x0400045A RID: 1114
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x40005EC")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
		private global::System.EventHandler ProcessExit;

		// Token: 0x0400045B RID: 1115
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x40005ED")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
		private global::System.ResolveEventHandler ResourceResolve;

		// Token: 0x0400045C RID: 1116
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x40005EE")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
		private global::System.ResolveEventHandler TypeResolve;

		// Token: 0x0400045D RID: 1117
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x40005EF")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x68")]
		private global::System.UnhandledExceptionEventHandler UnhandledException;

		// Token: 0x0400045E RID: 1118
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x40005F0")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x70")]
		private global::System.EventHandler<global::System.Runtime.ExceptionServices.FirstChanceExceptionEventArgs> FirstChanceException;

		// Token: 0x0400045F RID: 1119
		[global::Cpp2ILInjected.Token(Token = "0x40005F1")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x78")]
		private object _domain_manager;

		// Token: 0x04000460 RID: 1120
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x40005F2")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x80")]
		private global::System.ResolveEventHandler ReflectionOnlyAssemblyResolve;

		// Token: 0x04000461 RID: 1121
		[global::Cpp2ILInjected.Token(Token = "0x40005F3")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x88")]
		private object _activation;

		// Token: 0x04000462 RID: 1122
		[global::Cpp2ILInjected.Token(Token = "0x40005F4")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x90")]
		private object _applicationIdentity;

		// Token: 0x04000463 RID: 1123
		[global::Cpp2ILInjected.Token(Token = "0x40005F5")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x98")]
		private global::System.Collections.Generic.List<string> compatibility_switch;
	}
}
