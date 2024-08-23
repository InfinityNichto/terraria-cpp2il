﻿using System;
using System.Runtime.InteropServices;
using System.Runtime.Remoting;
using System.Runtime.Serialization;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System
{
	// Token: 0x02000158 RID: 344
	[global::System.Runtime.InteropServices.ComVisible(true)]
	[global::Cpp2ILInjected.Token(Token = "0x20001A4")]
	[global::System.Serializable]
	public class WeakReference : global::System.Runtime.Serialization.ISerializable
	{
		// Token: 0x06000EFB RID: 3835 RVA: 0x00016F6D File Offset: 0x0001516D
		[global::Cpp2ILInjected.Token(Token = "0x6000FF9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C8BE28", Offset = "0x1C8BE28", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.WeakReference), Member = ".ctor", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.WeakReference), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.WeakReference), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(global::System.Runtime.Serialization.SerializationInfo),
			typeof(global::System.Runtime.Serialization.StreamingContext)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.InteropServices.GCHandle), Member = "Alloc", MemberParameters = new object[]
		{
			typeof(object),
			typeof(global::System.Runtime.InteropServices.GCHandleType)
		}, ReturnType = typeof(global::System.Runtime.InteropServices.GCHandle))]
		private void AllocateHandle(object target)
		{
			throw null;
		}

		// Token: 0x06000EFC RID: 3836 RVA: 0x00016F70 File Offset: 0x00015170
		[global::Cpp2ILInjected.Token(Token = "0x6000FFA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C8BE50", Offset = "0x1C8BE50", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		protected WeakReference()
		{
			throw null;
		}

		// Token: 0x06000EFD RID: 3837 RVA: 0x00016F73 File Offset: 0x00015173
		[global::Cpp2ILInjected.Token(Token = "0x6000FFB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C8BE58", Offset = "0x1C8BE58", Length = "0x30")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Remoting.ClientIdentity), Member = "set_ClientProxy", MemberParameters = new object[] { typeof(global::System.MarshalByRefObject) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Diagnostics.Switch", Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Diagnostics.ProcessStartInfo", Member = ".ctor", MemberParameters = new object[] { "System.Diagnostics.Process" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.FtpControlStream", Member = "set_Credentials", MemberParameters = new object[] { "System.Net.NetworkCredential" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.TimerThread", Member = "CreateQueue", MemberParameters = new object[] { typeof(int) }, ReturnType = "System.Net.TimerThread.Queue")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.TimerThread", Member = "GetOrCreateQueue", MemberParameters = new object[] { typeof(int) }, ReturnType = "System.Net.TimerThread.Queue")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.ComponentModel.TypeDescriptor", Member = "CreateAssociation", MemberParameters = new object[]
		{
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.ComponentModel.WeakHashtable.EqualityWeakReference", Member = ".ctor", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.ComponentModel.WeakHashtable", Member = "SetWeak", MemberParameters = new object[]
		{
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Xml.XmlDocument", Member = "AddElementWithId", MemberParameters = new object[]
		{
			typeof(string),
			"System.Xml.XmlElement"
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Xml.Linq.XNamespace", Member = "Get", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int),
			typeof(int)
		}, ReturnType = "System.Xml.Linq.XNamespace")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Xml.Linq.XNamespace", Member = "EnsureNamespace", MemberParameters = new object[]
		{
			typeof(ref global::System.WeakReference),
			typeof(string)
		}, ReturnType = "System.Xml.Linq.XNamespace")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 13)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.WeakReference), Member = "AllocateHandle", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		public WeakReference(object target)
		{
			throw null;
		}

		// Token: 0x06000EFE RID: 3838 RVA: 0x00016F76 File Offset: 0x00015176
		[global::Cpp2ILInjected.Token(Token = "0x6000FFC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C8BE88", Offset = "0x1C8BE88", Length = "0x34")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.WeakReference), Member = "AllocateHandle", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		public WeakReference(object target, bool trackResurrection)
		{
			throw null;
		}

		// Token: 0x06000EFF RID: 3839 RVA: 0x00016F79 File Offset: 0x00015179
		[global::Cpp2ILInjected.Token(Token = "0x6000FFD")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C8BEBC", Offset = "0x1C8BEBC", Length = "0x134")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.Serialization.SerializationInfo), Member = "GetBoolean", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(global::System.RuntimeTypeHandle) }, ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.Serialization.SerializationInfo), Member = "GetValue", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.Type)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.WeakReference), Member = "AllocateHandle", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		protected WeakReference(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			throw null;
		}

		// Token: 0x17000146 RID: 326
		// (get) Token: 0x06000F00 RID: 3840 RVA: 0x00016F7C File Offset: 0x0001517C
		[global::Cpp2ILInjected.Token(Token = "0x17000170")]
		public virtual bool IsAlive
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000FFE")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C8BFF0", Offset = "0x1C8BFF0", Length = "0x20")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000147 RID: 327
		// (get) Token: 0x06000F01 RID: 3841 RVA: 0x00016F7F File Offset: 0x0001517F
		// (set) Token: 0x06000F02 RID: 3842 RVA: 0x00016F82 File Offset: 0x00015182
		[global::Cpp2ILInjected.Token(Token = "0x17000171")]
		public virtual object Target
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000FFF")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C8C010", Offset = "0x1C8C010", Length = "0x34")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.InteropServices.GCHandle), Member = "get_IsAllocated", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.InteropServices.GCHandle), Member = "get_Target", ReturnType = typeof(object))]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6001000")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C8C044", Offset = "0x1C8C044", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.InteropServices.GCHandle), Member = "set_Target", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000148 RID: 328
		// (get) Token: 0x06000F03 RID: 3843 RVA: 0x00016F85 File Offset: 0x00015185
		[global::Cpp2ILInjected.Token(Token = "0x17000172")]
		public virtual bool TrackResurrection
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001001")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C8C050", Offset = "0x1C8C050", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06000F04 RID: 3844 RVA: 0x00016F88 File Offset: 0x00015188
		[global::Cpp2ILInjected.Token(Token = "0x6001002")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C8C058", Offset = "0x1C8C058", Length = "0x9C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.InteropServices.GCHandle), Member = "Free", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "Finalize", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		protected override void Finalize()
		{
			throw null;
		}

		// Token: 0x06000F05 RID: 3845 RVA: 0x00016F8B File Offset: 0x0001518B
		[global::Cpp2ILInjected.Token(Token = "0x6001003")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C8C0F4", Offset = "0x1C8C0F4", Length = "0x180")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.Serialization.SerializationInfo), Member = "AddValue", MemberParameters = new object[]
		{
			typeof(string),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.Serialization.SerializationInfo), Member = "AddValue", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 17)]
		public virtual void GetObjectData(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			throw null;
		}

		// Token: 0x040006CD RID: 1741
		[global::Cpp2ILInjected.Token(Token = "0x40008A8")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private bool isLongReference;

		// Token: 0x040006CE RID: 1742
		[global::Cpp2ILInjected.Token(Token = "0x40008A9")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private global::System.Runtime.InteropServices.GCHandle gcHandle;
	}
}