using System;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting.Contexts;
using System.Runtime.Remoting.Proxies;
using System.Threading;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Runtime.Remoting.Messaging
{
	// Token: 0x0200031B RID: 795
	[global::Cpp2ILInjected.Token(Token = "0x20003C1")]
	internal class StackBuilderSink : IMessageSink
	{
		// Token: 0x06001C7C RID: 7292 RVA: 0x000194B4 File Offset: 0x000176B4
		[global::Cpp2ILInjected.Token(Token = "0x6001EB5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B500F0", Offset = "0x1B500F0", Length = "0xA4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Remoting.Contexts.Context), Member = "CreateServerObjectSinkChain", MemberParameters = new object[]
		{
			typeof(global::System.MarshalByRefObject),
			typeof(bool)
		}, ReturnType = typeof(IMessageSink))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RemotingServices), Member = "IsTransparentProxy", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RemotingServices), Member = "GetRealProxy", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(global::System.Runtime.Remoting.Proxies.RealProxy))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public StackBuilderSink(global::System.MarshalByRefObject obj, bool forceInternalExecute)
		{
			throw null;
		}

		// Token: 0x06001C7D RID: 7293 RVA: 0x000194B7 File Offset: 0x000176B7
		[global::Cpp2ILInjected.Token(Token = "0x6001EB6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B50194", Offset = "0x1B50194", Length = "0xCC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StackBuilderSink), Member = "CheckParameters", MemberParameters = new object[] { typeof(IMessage) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RemotingServices), Member = "InternalExecuteMessage", MemberParameters = new object[]
		{
			typeof(global::System.MarshalByRefObject),
			typeof(IMethodCallMessage)
		}, ReturnType = typeof(IMethodReturnMessage))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public IMessage SyncProcessMessage(IMessage msg)
		{
			throw null;
		}

		// Token: 0x06001C7E RID: 7294 RVA: 0x000194BA File Offset: 0x000176BA
		[global::Cpp2ILInjected.Token(Token = "0x6001EB7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B505DC", Offset = "0x1B505DC", Length = "0xFC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.WaitCallback), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(global::System.IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.ThreadPool), Member = "QueueUserWorkItem", MemberParameters = new object[]
		{
			typeof(global::System.Threading.WaitCallback),
			typeof(object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		public IMessageCtrl AsyncProcessMessage(IMessage msg, IMessageSink replySink)
		{
			throw null;
		}

		// Token: 0x06001C7F RID: 7295 RVA: 0x000194BD File Offset: 0x000176BD
		[global::Cpp2ILInjected.Token(Token = "0x6001EB8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B506D8", Offset = "0x1B506D8", Length = "0x1E4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(StackBuilderSink), Member = "<AsyncProcessMessage>b__4_0", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StackBuilderSink), Member = "CheckParameters", MemberParameters = new object[] { typeof(IMessage) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RemotingServices), Member = "InternalExecuteMessage", MemberParameters = new object[]
		{
			typeof(global::System.MarshalByRefObject),
			typeof(IMethodCallMessage)
		}, ReturnType = typeof(IMethodReturnMessage))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 13)]
		private void ExecuteAsyncMessage(object ob)
		{
			throw null;
		}

		// Token: 0x06001C80 RID: 7296 RVA: 0x000194C0 File Offset: 0x000176C0
		[global::Cpp2ILInjected.Token(Token = "0x6001EB9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B50260", Offset = "0x1B50260", Length = "0x37C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(StackBuilderSink), Member = "SyncProcessMessage", MemberParameters = new object[] { typeof(IMessage) }, ReturnType = typeof(IMessage))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(StackBuilderSink), Member = "ExecuteAsyncMessage", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "get_IsByRef", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(int), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[] { typeof(string[]) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RemotingException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 27)]
		private void CheckParameters(IMessage msg)
		{
			throw null;
		}

		// Token: 0x06001C81 RID: 7297 RVA: 0x000194C3 File Offset: 0x000176C3
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x6001EBA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B508BC", Offset = "0x1B508BC", Length = "0x80")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StackBuilderSink), Member = "ExecuteAsyncMessage", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		private void <AsyncProcessMessage>b__4_0(object data)
		{
			throw null;
		}

		// Token: 0x04000C82 RID: 3202
		[global::Cpp2ILInjected.Token(Token = "0x4000F71")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private global::System.MarshalByRefObject _target;

		// Token: 0x04000C83 RID: 3203
		[global::Cpp2ILInjected.Token(Token = "0x4000F72")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private global::System.Runtime.Remoting.Proxies.RealProxy _rp;
	}
}
