using System;
using System.Threading;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.ComponentModel
{
	[TypeConverter(typeof(ComponentConverter))]
	[DesignerCategory("Component")]
	[global::Cpp2ILInjected.Token(Token = "0x20003A1")]
	public class MarshalByValueComponent : IComponent, IDisposable, IServiceProvider
	{
		[global::Cpp2ILInjected.Token(Token = "0x6001826")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E502A4", Offset = "0x1E502A4", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public MarshalByValueComponent()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001827")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E502AC", Offset = "0x1E502AC", Length = "0xA0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "Finalize", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		protected override void Finalize()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x14000015")]
		public event EventHandler Disposed
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001828")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E5034C", Offset = "0x1E5034C", Length = "0x84")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MarshalByValueComponent), Member = "get_Events", ReturnType = typeof(EventHandlerList))]
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
			[global::Cpp2ILInjected.Token(Token = "0x6001829")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E50434", Offset = "0x1E50434", Length = "0x84")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MarshalByValueComponent), Member = "get_Events", ReturnType = typeof(EventHandlerList))]
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

		[global::Cpp2ILInjected.Token(Token = "0x17000585")]
		protected EventHandlerList Events
		{
			[global::Cpp2ILInjected.Token(Token = "0x600182A")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E503D0", Offset = "0x1E503D0", Length = "0x64")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MarshalByValueComponent), Member = "add_Disposed", MemberParameters = new object[] { typeof(EventHandler) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MarshalByValueComponent), Member = "remove_Disposed", MemberParameters = new object[] { typeof(EventHandler) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EventHandlerList), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		[Browsable(false)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		[global::Cpp2ILInjected.Token(Token = "0x17000586")]
		public virtual ISite Site
		{
			[global::Cpp2ILInjected.Token(Token = "0x600182B")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E504B8", Offset = "0x1E504B8", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x600182C")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E504C0", Offset = "0x1E504C0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x600182D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E504C8", Offset = "0x1E504C8", Length = "0x6C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GC), Member = "SuppressFinalize", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public void Dispose()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600182E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E50534", Offset = "0x1E50534", Length = "0x294")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EventHandlerList), Member = "get_Item", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(Delegate))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 16)]
		protected virtual void Dispose(bool disposing)
		{
			throw null;
		}

		[Browsable(false)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		[global::Cpp2ILInjected.Token(Token = "0x17000587")]
		public virtual IContainer Container
		{
			[global::Cpp2ILInjected.Token(Token = "0x600182F")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E507C8", Offset = "0x1E507C8", Length = "0xB0")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001830")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E50878", Offset = "0x1E50878", Length = "0xB4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public virtual object GetService(Type service)
		{
			throw null;
		}

		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		[Browsable(false)]
		[global::Cpp2ILInjected.Token(Token = "0x17000588")]
		public virtual bool DesignMode
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001831")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E5092C", Offset = "0x1E5092C", Length = "0xB0")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001832")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E509DC", Offset = "0x1E509DC", Length = "0x130")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
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

		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x6001833")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E50B0C", Offset = "0x1E50B0C", Length = "0x70")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		static MarshalByValueComponent()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x4001258")]
		private static readonly object s_eventDisposed;

		[global::Cpp2ILInjected.Token(Token = "0x4001259")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private ISite _site;

		[global::Cpp2ILInjected.Token(Token = "0x400125A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private EventHandlerList _events;
	}
}
