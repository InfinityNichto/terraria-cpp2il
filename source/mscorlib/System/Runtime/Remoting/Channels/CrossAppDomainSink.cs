﻿using System;
using System.Collections;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting.Contexts;
using System.Runtime.Remoting.Messaging;
using System.Threading;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Runtime.Remoting.Channels
{
	// Token: 0x020002D5 RID: 725
	[global::System.MonoTODO("Handle domain unloading?")]
	[global::Cpp2ILInjected.Token(Token = "0x2000378")]
	internal class CrossAppDomainSink : global::System.Runtime.Remoting.Messaging.IMessageSink
	{
		// Token: 0x06001B08 RID: 6920 RVA: 0x000190D0 File Offset: 0x000172D0
		[global::Cpp2ILInjected.Token(Token = "0x6001D35")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B40694", Offset = "0x1B40694", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		internal CrossAppDomainSink(int domainID)
		{
			throw null;
		}

		// Token: 0x06001B09 RID: 6921 RVA: 0x000190D3 File Offset: 0x000172D3
		[global::Cpp2ILInjected.Token(Token = "0x6001D36")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B403B0", Offset = "0x1B403B0", Length = "0x274")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Monitor), Member = "Enter", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 17)]
		internal static CrossAppDomainSink GetSink(int domainID)
		{
			throw null;
		}

		// Token: 0x17000316 RID: 790
		// (get) Token: 0x06001B0A RID: 6922 RVA: 0x000190D6 File Offset: 0x000172D6
		[global::Cpp2ILInjected.Token(Token = "0x1700036E")]
		internal int TargetDomainId
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001D37")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B406BC", Offset = "0x1B406BC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06001B0B RID: 6923 RVA: 0x000190D9 File Offset: 0x000172D9
		[global::Cpp2ILInjected.Token(Token = "0x6001D38")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B406C4", Offset = "0x1B406C4", Length = "0x120")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.AppDomain), Member = "get_CurrentDomain", ReturnType = typeof(global::System.AppDomain))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.AppDomain), Member = "ProcessMessageInDomain", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(global::System.Runtime.Remoting.Messaging.CADMethodCallMessage),
			typeof(ref byte[]),
			typeof(ref global::System.Runtime.Remoting.Messaging.CADMethodReturnMessage)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.Remoting.Messaging.ErrorMessage), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.Remoting.Messaging.MethodResponse), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(global::System.Exception),
			typeof(global::System.Runtime.Remoting.Messaging.IMethodCallMessage)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CADSerializer), Member = "SerializeMessage", MemberParameters = new object[] { typeof(global::System.Runtime.Remoting.Messaging.IMessage) }, ReturnType = typeof(global::System.IO.MemoryStream))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 13)]
		private static CrossAppDomainSink.ProcessMessageRes ProcessMessageInDomain(byte[] arrRequest, global::System.Runtime.Remoting.Messaging.CADMethodCallMessage cadMsg)
		{
			throw null;
		}

		// Token: 0x06001B0C RID: 6924 RVA: 0x000190DC File Offset: 0x000172DC
		[global::Cpp2ILInjected.Token(Token = "0x6001D39")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B40914", Offset = "0x1B40914", Length = "0x3E8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.Remoting.Messaging.CADMethodCallMessage), Member = "Create", MemberParameters = new object[] { typeof(global::System.Runtime.Remoting.Messaging.IMessage) }, ReturnType = typeof(global::System.Runtime.Remoting.Messaging.CADMethodCallMessage))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CADSerializer), Member = "SerializeMessage", MemberParameters = new object[] { typeof(global::System.Runtime.Remoting.Messaging.IMessage) }, ReturnType = typeof(global::System.IO.MemoryStream))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Thread), Member = "get_CurrentContext", ReturnType = typeof(global::System.Runtime.Remoting.Contexts.Context))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.AppDomain), Member = "InvokeInDomainByID", MemberParameters = new object[]
		{
			typeof(int),
			typeof(global::System.Reflection.MethodInfo),
			typeof(object),
			typeof(object[])
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.AppDomain), Member = "InternalSetContext", MemberParameters = new object[] { typeof(global::System.Runtime.Remoting.Contexts.Context) }, ReturnType = typeof(global::System.Runtime.Remoting.Contexts.Context))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.IO.MemoryStream), Member = ".ctor", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CADSerializer), Member = "DeserializeMessage", MemberParameters = new object[]
		{
			typeof(global::System.IO.MemoryStream),
			typeof(global::System.Runtime.Remoting.Messaging.IMethodCallMessage)
		}, ReturnType = typeof(global::System.Runtime.Remoting.Messaging.IMessage))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.Remoting.Messaging.MethodResponse), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(global::System.Runtime.Remoting.Messaging.IMethodCallMessage),
			typeof(global::System.Runtime.Remoting.Messaging.CADMethodReturnMessage)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.Remoting.Messaging.ReturnMessage), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(global::System.Exception),
			typeof(global::System.Runtime.Remoting.Messaging.IMethodCallMessage)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 44)]
		public virtual global::System.Runtime.Remoting.Messaging.IMessage SyncProcessMessage(global::System.Runtime.Remoting.Messaging.IMessage msgRequest)
		{
			throw null;
		}

		// Token: 0x06001B0D RID: 6925 RVA: 0x000190DF File Offset: 0x000172DF
		[global::Cpp2ILInjected.Token(Token = "0x6001D3A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B40FE8", Offset = "0x1B40FE8", Length = "0xC8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
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
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public virtual global::System.Runtime.Remoting.Messaging.IMessageCtrl AsyncProcessMessage(global::System.Runtime.Remoting.Messaging.IMessage reqMsg, global::System.Runtime.Remoting.Messaging.IMessageSink replySink)
		{
			throw null;
		}

		// Token: 0x06001B0E RID: 6926 RVA: 0x000190E2 File Offset: 0x000172E2
		[global::Cpp2ILInjected.Token(Token = "0x6001D3B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B410DC", Offset = "0x1B410DC", Length = "0x104")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CrossAppDomainSink), Member = "<AsyncProcessMessage>b__10_0", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public void SendAsyncMessage(object data)
		{
			throw null;
		}

		// Token: 0x06001B0F RID: 6927 RVA: 0x000190E5 File Offset: 0x000172E5
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x6001D3C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B411E0", Offset = "0x1B411E0", Length = "0xF0")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Collections.Hashtable), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(global::System.RuntimeTypeHandle) }, ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "GetMethod", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.Reflection.BindingFlags)
		}, ReturnType = typeof(global::System.Reflection.MethodInfo))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		static CrossAppDomainSink()
		{
			throw null;
		}

		// Token: 0x06001B10 RID: 6928 RVA: 0x000190E8 File Offset: 0x000172E8
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x6001D3D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B412D0", Offset = "0x1B412D0", Length = "0x80")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CrossAppDomainSink), Member = "SendAsyncMessage", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		private void <AsyncProcessMessage>b__10_0(object data)
		{
			throw null;
		}

		// Token: 0x04000BD6 RID: 3030
		[global::Cpp2ILInjected.Token(Token = "0x4000EBF")]
		private static global::System.Collections.Hashtable s_sinks;

		// Token: 0x04000BD7 RID: 3031
		[global::Cpp2ILInjected.Token(Token = "0x4000EC0")]
		private static global::System.Reflection.MethodInfo processMessageMethod;

		// Token: 0x04000BD8 RID: 3032
		[global::Cpp2ILInjected.Token(Token = "0x4000EC1")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private int _domainID;

		// Token: 0x020005EE RID: 1518
		[global::Cpp2ILInjected.Token(Token = "0x2000379")]
		private struct ProcessMessageRes
		{
			// Token: 0x04001971 RID: 6513
			[global::Cpp2ILInjected.Token(Token = "0x4000EC2")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			public byte[] arrResponse;

			// Token: 0x04001972 RID: 6514
			[global::Cpp2ILInjected.Token(Token = "0x4000EC3")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
			public global::System.Runtime.Remoting.Messaging.CADMethodReturnMessage cadMrm;
		}
	}
}