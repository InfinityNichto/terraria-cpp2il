using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Proxies;
using System.Threading;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Runtime.Remoting.Messaging
{
	[global::System.Runtime.InteropServices.ComVisible(true)]
	[global::Cpp2ILInjected.Token(Token = "0x200039A")]
	[StructLayout(0)]
	public class AsyncResult : global::System.IAsyncResult, IMessageSink, global::System.Threading.IThreadPoolWorkItem
	{
		[global::Cpp2ILInjected.Token(Token = "0x6001DA9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B44960", Offset = "0x1B44960", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		internal AsyncResult()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000399")]
		public virtual object AsyncState
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001DAA")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B44968", Offset = "0x1B44968", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x1700039A")]
		public virtual global::System.Threading.WaitHandle AsyncWaitHandle
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001DAB")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B44970", Offset = "0x1B44970", Length = "0x118")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Monitor), Member = "Enter", MemberParameters = new object[]
			{
				typeof(object),
				typeof(ref bool)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.ManualResetEvent), Member = ".ctor", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x1700039B")]
		public virtual bool CompletedSynchronously
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001DAC")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B44A88", Offset = "0x1B44A88", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x1700039C")]
		public virtual bool IsCompleted
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001DAD")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B44A90", Offset = "0x1B44A90", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x1700039D")]
		public bool EndInvokeCalled
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001DAE")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B44A98", Offset = "0x1B44A98", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6001DAF")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B44AA0", Offset = "0x1B44AA0", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x1700039E")]
		public virtual object AsyncDelegate
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001DB0")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B44AAC", Offset = "0x1B44AAC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x1700039F")]
		public IMessageSink NextSink
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001DB1")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B44AB4", Offset = "0x1B44AB4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001DB2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B44ABC", Offset = "0x1B44ABC", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public virtual IMessageCtrl AsyncProcessMessage(IMessage msg, IMessageSink replySink)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001DB3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B44AF4", Offset = "0x1B44AF4", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public virtual IMessage GetReplyMessage()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001DB4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B44AFC", Offset = "0x1B44AFC", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public virtual void SetMessageCtrl(IMessageCtrl mc)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001DB5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B44B04", Offset = "0x1B44B04", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		internal void SetCompletedSynchronously(bool completed)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001DB6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B352CC", Offset = "0x1B352CC", Length = "0x108")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Remoting.Proxies.RealProxy), Member = "PrivateInvoke", MemberParameters = new object[]
		{
			typeof(global::System.Runtime.Remoting.Proxies.RealProxy),
			typeof(IMessage),
			typeof(ref global::System.Exception),
			typeof(ref object[])
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Monitor), Member = "Enter", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		internal IMessage EndInvoke()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001DB7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B44B10", Offset = "0x1B44B10", Length = "0x18C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Monitor), Member = "Enter", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.EventWaitHandle), Member = "Set", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		public virtual IMessage SyncProcessMessage(IMessage msg)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x170003A0")]
		internal MonoMethodMessage CallMessage
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001DB8")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B44C9C", Offset = "0x1B44C9C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6001DB9")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B44CA4", Offset = "0x1B44CA4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001DBA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B44CAC", Offset = "0x1B44CAC", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		private void System.Threading.IThreadPoolWorkItem.ExecuteWorkItem()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001DBB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B44CB4", Offset = "0x1B44CB4", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private void System.Threading.IThreadPoolWorkItem.MarkAborted(global::System.Threading.ThreadAbortException tae)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001DBC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B44CB0", Offset = "0x1B44CB0", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[MethodImpl(4096)]
		internal extern object Invoke();

		[global::Cpp2ILInjected.Token(Token = "0x4000EF4")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private object async_state;

		[global::Cpp2ILInjected.Token(Token = "0x4000EF5")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private global::System.Threading.WaitHandle handle;

		[global::Cpp2ILInjected.Token(Token = "0x4000EF6")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private object async_delegate;

		[global::Cpp2ILInjected.Token(Token = "0x4000EF7")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private global::System.IntPtr data;

		[global::Cpp2ILInjected.Token(Token = "0x4000EF8")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private object object_data;

		[global::Cpp2ILInjected.Token(Token = "0x4000EF9")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		private bool sync_completed;

		[global::Cpp2ILInjected.Token(Token = "0x4000EFA")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x39")]
		private bool completed;

		[global::Cpp2ILInjected.Token(Token = "0x4000EFB")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x3A")]
		private bool endinvoke_called;

		[global::Cpp2ILInjected.Token(Token = "0x4000EFC")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		private object async_callback;

		[global::Cpp2ILInjected.Token(Token = "0x4000EFD")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
		private global::System.Threading.ExecutionContext current;

		[global::Cpp2ILInjected.Token(Token = "0x4000EFE")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
		private global::System.Threading.ExecutionContext original;

		[global::Cpp2ILInjected.Token(Token = "0x4000EFF")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
		private long add_time;

		[global::Cpp2ILInjected.Token(Token = "0x4000F00")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
		private MonoMethodMessage call_message;

		[global::Cpp2ILInjected.Token(Token = "0x4000F01")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x68")]
		private IMessageCtrl message_ctrl;

		[global::Cpp2ILInjected.Token(Token = "0x4000F02")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x70")]
		private IMessage reply_message;

		[global::Cpp2ILInjected.Token(Token = "0x4000F03")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x78")]
		private global::System.Threading.WaitCallback orig_cb;
	}
}
