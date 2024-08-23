using System;
using System.Diagnostics;
using System.Net;
using System.Runtime.InteropServices;
using System.Threading;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.ComponentModel
{
	// Token: 0x020002DB RID: 731
	[ClassInterface(ClassInterfaceType.AutoDispatch)]
	[ComVisible(true)]
	[DesignerCategory("Component")]
	[global::Cpp2ILInjected.Token(Token = "0x20003DA")]
	public class Component : MarshalByRefObject, IComponent, IDisposable
	{
		// Token: 0x060017A1 RID: 6049 RVA: 0x0000709D File Offset: 0x0000529D
		[global::Cpp2ILInjected.Token(Token = "0x6001A03")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E62060", Offset = "0x1E62060", Length = "0xA4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "Finalize", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		protected override void Finalize()
		{
			throw null;
		}

		// Token: 0x170005C3 RID: 1475
		// (get) Token: 0x060017A2 RID: 6050 RVA: 0x000070A0 File Offset: 0x000052A0
		[global::Cpp2ILInjected.Token(Token = "0x170005F7")]
		protected virtual bool CanRaiseEvents
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001A04")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E62104", Offset = "0x1E62104", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170005C4 RID: 1476
		// (get) Token: 0x060017A3 RID: 6051 RVA: 0x000070A3 File Offset: 0x000052A3
		[global::Cpp2ILInjected.Token(Token = "0x170005F8")]
		internal bool CanRaiseEventsInternal
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001A05")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E6210C", Offset = "0x1E6210C", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(EventHandlerList), Member = "get_Item", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(Delegate))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x14000019 RID: 25
		// (add) Token: 0x060017A4 RID: 6052 RVA: 0x000070A6 File Offset: 0x000052A6
		// (remove) Token: 0x060017A5 RID: 6053 RVA: 0x000070A9 File Offset: 0x000052A9
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		[Browsable(false)]
		[global::Cpp2ILInjected.Token(Token = "0x14000019")]
		public event EventHandler Disposed
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001A06")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E62118", Offset = "0x1E62118", Length = "0x84")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Component), Member = "get_Events", ReturnType = typeof(EventHandlerList))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EventHandlerList), Member = "AddHandler", MemberParameters = new object[]
			{
				typeof(object),
				typeof(Delegate)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			add
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6001A07")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E62204", Offset = "0x1E62204", Length = "0x84")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Component), Member = "get_Events", ReturnType = typeof(EventHandlerList))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EventHandlerList), Member = "RemoveHandler", MemberParameters = new object[]
			{
				typeof(object),
				typeof(Delegate)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			remove
			{
				throw null;
			}
		}

		// Token: 0x170005C5 RID: 1477
		// (get) Token: 0x060017A6 RID: 6054 RVA: 0x000070AC File Offset: 0x000052AC
		[global::Cpp2ILInjected.Token(Token = "0x170005F9")]
		protected EventHandlerList Events
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001A08")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E6219C", Offset = "0x1E6219C", Length = "0x68")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Component), Member = "add_Disposed", MemberParameters = new object[] { typeof(EventHandler) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Component), Member = "remove_Disposed", MemberParameters = new object[] { typeof(EventHandler) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EventHandlerList), Member = ".ctor", MemberParameters = new object[] { typeof(Component) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170005C6 RID: 1478
		// (get) Token: 0x060017A7 RID: 6055 RVA: 0x000070AF File Offset: 0x000052AF
		// (set) Token: 0x060017A8 RID: 6056 RVA: 0x000070B2 File Offset: 0x000052B2
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		[Browsable(false)]
		[global::Cpp2ILInjected.Token(Token = "0x170005FA")]
		public virtual ISite Site
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001A09")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E62288", Offset = "0x1E62288", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6001A0A")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E62290", Offset = "0x1E62290", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x060017A9 RID: 6057 RVA: 0x000070B5 File Offset: 0x000052B5
		[global::Cpp2ILInjected.Token(Token = "0x6001A0B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E62298", Offset = "0x1E62298", Length = "0x70")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TraceEventCache), Member = "InitProcessInfo", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GC), Member = "SuppressFinalize", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public void Dispose()
		{
			throw null;
		}

		// Token: 0x060017AA RID: 6058 RVA: 0x000070B8 File Offset: 0x000052B8
		[global::Cpp2ILInjected.Token(Token = "0x6001A0C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E62308", Offset = "0x1E62308", Length = "0x2F8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Process), Member = "Dispose", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EventHandlerList), Member = "get_Item", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(Delegate))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 17)]
		protected virtual void Dispose(bool disposing)
		{
			throw null;
		}

		// Token: 0x170005C7 RID: 1479
		// (get) Token: 0x060017AB RID: 6059 RVA: 0x000070BB File Offset: 0x000052BB
		[Browsable(false)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		[global::Cpp2ILInjected.Token(Token = "0x170005FB")]
		public IContainer Container
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001A0D")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E62600", Offset = "0x1E62600", Length = "0xB0")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			get
			{
				throw null;
			}
		}

		// Token: 0x060017AC RID: 6060 RVA: 0x000070BE File Offset: 0x000052BE
		[global::Cpp2ILInjected.Token(Token = "0x6001A0E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E626B0", Offset = "0x1E626B0", Length = "0xB4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		protected virtual object GetService(Type service)
		{
			throw null;
		}

		// Token: 0x170005C8 RID: 1480
		// (get) Token: 0x060017AD RID: 6061 RVA: 0x000070C1 File Offset: 0x000052C1
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		[Browsable(false)]
		[global::Cpp2ILInjected.Token(Token = "0x170005FC")]
		protected bool DesignMode
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001A0F")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E62764", Offset = "0x1E62764", Length = "0xB0")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Process), Member = "get_SynchronizingObject", ReturnType = typeof(ISynchronizeInvoke))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			get
			{
				throw null;
			}
		}

		// Token: 0x060017AE RID: 6062 RVA: 0x000070C4 File Offset: 0x000052C4
		[global::Cpp2ILInjected.Token(Token = "0x6001A10")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E62814", Offset = "0x1E62814", Length = "0x130")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Process), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public override string ToString()
		{
			throw null;
		}

		// Token: 0x060017AF RID: 6063 RVA: 0x000070C7 File Offset: 0x000052C7
		[global::Cpp2ILInjected.Token(Token = "0x6001A11")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E62944", Offset = "0x1E62944", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Process), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Process), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(bool),
			typeof(int),
			typeof(ProcessInfo)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebClient), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BackgroundWorker), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MarshalByRefObject), Member = ".ctor", ReturnType = typeof(void))]
		public Component()
		{
			throw null;
		}

		// Token: 0x060017B0 RID: 6064 RVA: 0x000070CA File Offset: 0x000052CA
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x6001A12")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E6294C", Offset = "0x1E6294C", Length = "0x70")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		static Component()
		{
			throw null;
		}

		// Token: 0x04000EDA RID: 3802
		[global::Cpp2ILInjected.Token(Token = "0x40012F8")]
		private static readonly object EventDisposed;

		// Token: 0x04000EDB RID: 3803
		[global::Cpp2ILInjected.Token(Token = "0x40012F9")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private ISite site;

		// Token: 0x04000EDC RID: 3804
		[global::Cpp2ILInjected.Token(Token = "0x40012FA")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private EventHandlerList events;
	}
}
