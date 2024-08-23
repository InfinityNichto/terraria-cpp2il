using System;
using System.IO;
using System.Runtime.Remoting.Messaging;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Threading
{
	// Token: 0x0200016B RID: 363
	[global::Cpp2ILInjected.Token(Token = "0x20001BD")]
	public sealed class ManualResetEvent : EventWaitHandle
	{
		// Token: 0x06000F87 RID: 3975 RVA: 0x000170FC File Offset: 0x000152FC
		[global::Cpp2ILInjected.Token(Token = "0x60010B9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C93F38", Offset = "0x1C93F38", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "DrPlatform.User", Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "CacheFileManager", Member = ".ctor", MemberParameters = new object[]
		{
			"FileManager",
			"FileAPI",
			typeof(bool),
			"PlatformUser"
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Telepathy.Client", Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Telepathy.Server.ClientToken", Member = ".ctor", MemberParameters = new object[] { "System.Net.Sockets.TcpClient" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RegisteredWaitHandle), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(WaitHandle),
			typeof(WaitOrTimerCallback),
			typeof(object),
			typeof(global::System.TimeSpan),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Threading.Timer.Scheduler", Member = "InitScheduler", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Remoting.Messaging.AsyncResult), Member = "get_AsyncWaitHandle", ReturnType = typeof(WaitHandle))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.IO.Stream.SynchronousAsyncResult.<>c", Member = "<get_AsyncWaitHandle>b__12_0", ReturnType = typeof(ManualResetEvent))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.IO.FileStreamAsyncResult), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(global::System.AsyncCallback),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.IOAsyncResult", Member = "get_AsyncWaitHandle", ReturnType = typeof(WaitHandle))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.LazyAsyncResult", Member = "LazilyCreateEvent", MemberParameters = new object[] { typeof(ref ManualResetEvent) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.TimerThread", Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.FileWebRequest", Member = "GetResponseCallback", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.HttpStreamAsyncResult", Member = "get_AsyncWaitHandle", ReturnType = typeof(WaitHandle))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.ListenerAsyncResult", Member = "get_AsyncWaitHandle", ReturnType = typeof(WaitHandle))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UnitySynchronizationContext", Member = "Send", MemberParameters = new object[]
		{
			typeof(SendOrPostCallback),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 16)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EventWaitHandle), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(bool),
			typeof(EventResetMode),
			typeof(string)
		}, ReturnType = typeof(void))]
		public ManualResetEvent(bool initialState)
		{
			throw null;
		}
	}
}
