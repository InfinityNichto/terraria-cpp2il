using System;
using System.Runtime.CompilerServices;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Threading
{
	[global::Cpp2ILInjected.Token(Token = "0x200020E")]
	[StructLayout(0)]
	internal sealed class InternalThread : global::System.Runtime.ConstrainedExecution.CriticalFinalizerObject
	{
		[global::Cpp2ILInjected.Token(Token = "0x60012AD")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CA22BC", Offset = "0x1CA22BC", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[MethodImpl(4096)]
		private extern void Thread_free_internal();

		[global::System.Runtime.ConstrainedExecution.ReliabilityContract(global::System.Runtime.ConstrainedExecution.Consistency.WillNotCorruptState, global::System.Runtime.ConstrainedExecution.Cer.Success)]
		[global::Cpp2ILInjected.Token(Token = "0x60012AE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CA22C0", Offset = "0x1CA22C0", Length = "0x94")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.ConstrainedExecution.CriticalFinalizerObject), Member = "Finalize", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		protected override void Finalize()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60012AF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CA2354", Offset = "0x1CA2354", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.ConstrainedExecution.CriticalFinalizerObject), Member = ".ctor", ReturnType = typeof(void))]
		public InternalThread()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x40009E3")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private int lock_thread_id;

		[global::Cpp2ILInjected.Token(Token = "0x40009E4")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private global::System.IntPtr handle;

		[global::Cpp2ILInjected.Token(Token = "0x40009E5")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private global::System.IntPtr native_handle;

		[global::Cpp2ILInjected.Token(Token = "0x40009E6")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private global::System.IntPtr name_chars;

		[global::Cpp2ILInjected.Token(Token = "0x40009E7")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private int name_free;

		[global::Cpp2ILInjected.Token(Token = "0x40009E8")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x34")]
		private int name_length;

		[global::Cpp2ILInjected.Token(Token = "0x40009E9")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		private ThreadState state;

		[global::Cpp2ILInjected.Token(Token = "0x40009EA")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		private object abort_exc;

		[global::Cpp2ILInjected.Token(Token = "0x40009EB")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
		private int abort_state_handle;

		[global::Cpp2ILInjected.Token(Token = "0x40009EC")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
		internal long thread_id;

		[global::Cpp2ILInjected.Token(Token = "0x40009ED")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
		private global::System.IntPtr debugger_thread;

		[global::Cpp2ILInjected.Token(Token = "0x40009EE")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
		private global::System.UIntPtr static_data;

		[global::Cpp2ILInjected.Token(Token = "0x40009EF")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x68")]
		private global::System.IntPtr runtime_thread_info;

		[global::Cpp2ILInjected.Token(Token = "0x40009F0")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x70")]
		private object current_appcontext;

		[global::Cpp2ILInjected.Token(Token = "0x40009F1")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x78")]
		private object root_domain_thread;

		[global::Cpp2ILInjected.Token(Token = "0x40009F2")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x80")]
		internal byte[] _serialized_principal;

		[global::Cpp2ILInjected.Token(Token = "0x40009F3")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x88")]
		internal int _serialized_principal_version;

		[global::Cpp2ILInjected.Token(Token = "0x40009F4")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x90")]
		private global::System.IntPtr appdomain_refs;

		[global::Cpp2ILInjected.Token(Token = "0x40009F5")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x98")]
		private int interruption_requested;

		[global::Cpp2ILInjected.Token(Token = "0x40009F6")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xA0")]
		private global::System.IntPtr longlived;

		[global::Cpp2ILInjected.Token(Token = "0x40009F7")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xA8")]
		internal bool threadpool_thread;

		[global::Cpp2ILInjected.Token(Token = "0x40009F8")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xA9")]
		private bool thread_interrupt_requested;

		[global::Cpp2ILInjected.Token(Token = "0x40009F9")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xAC")]
		internal int stack_size;

		[global::Cpp2ILInjected.Token(Token = "0x40009FA")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xB0")]
		internal byte apartment_state;

		[global::Cpp2ILInjected.Token(Token = "0x40009FB")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xB4")]
		internal int critical_region_level;

		[global::Cpp2ILInjected.Token(Token = "0x40009FC")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xB8")]
		internal int managed_id;

		[global::Cpp2ILInjected.Token(Token = "0x40009FD")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xBC")]
		private int small_id;

		[global::Cpp2ILInjected.Token(Token = "0x40009FE")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xC0")]
		private global::System.IntPtr manage_callback;

		[global::Cpp2ILInjected.Token(Token = "0x40009FF")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xC8")]
		private global::System.IntPtr flags;

		[global::Cpp2ILInjected.Token(Token = "0x4000A00")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xD0")]
		private global::System.IntPtr thread_pinning_ref;

		[global::Cpp2ILInjected.Token(Token = "0x4000A01")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xD8")]
		private global::System.IntPtr abort_protected_block_count;

		[global::Cpp2ILInjected.Token(Token = "0x4000A02")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xE0")]
		private int priority;

		[global::Cpp2ILInjected.Token(Token = "0x4000A03")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xE8")]
		private global::System.IntPtr owned_mutex;

		[global::Cpp2ILInjected.Token(Token = "0x4000A04")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xF0")]
		private global::System.IntPtr suspended_event;

		[global::Cpp2ILInjected.Token(Token = "0x4000A05")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xF8")]
		private int self_suspended;

		[global::Cpp2ILInjected.Token(Token = "0x4000A06")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x100")]
		private global::System.IntPtr thread_state;

		[global::Cpp2ILInjected.Token(Token = "0x4000A07")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x108")]
		private global::System.IntPtr netcore0;

		[global::Cpp2ILInjected.Token(Token = "0x4000A08")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x110")]
		private global::System.IntPtr netcore1;

		[global::Cpp2ILInjected.Token(Token = "0x4000A09")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x118")]
		private global::System.IntPtr netcore2;

		[global::Cpp2ILInjected.Token(Token = "0x4000A0A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x120")]
		private global::System.IntPtr last;
	}
}
