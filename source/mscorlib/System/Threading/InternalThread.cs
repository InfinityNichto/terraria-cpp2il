using System;
using System.Runtime.CompilerServices;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Threading
{
	// Token: 0x020001A5 RID: 421
	[global::Cpp2ILInjected.Token(Token = "0x200020E")]
	[StructLayout(0)]
	internal sealed class InternalThread : global::System.Runtime.ConstrainedExecution.CriticalFinalizerObject
	{
		// Token: 0x06001142 RID: 4418
		[global::Cpp2ILInjected.Token(Token = "0x60012AD")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CA22BC", Offset = "0x1CA22BC", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[MethodImpl(4096)]
		private extern void Thread_free_internal();

		// Token: 0x06001143 RID: 4419 RVA: 0x00017558 File Offset: 0x00015758
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

		// Token: 0x06001144 RID: 4420 RVA: 0x0001755B File Offset: 0x0001575B
		[global::Cpp2ILInjected.Token(Token = "0x60012AF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CA2354", Offset = "0x1CA2354", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.ConstrainedExecution.CriticalFinalizerObject), Member = ".ctor", ReturnType = typeof(void))]
		public InternalThread()
		{
			throw null;
		}

		// Token: 0x040007AF RID: 1967
		[global::Cpp2ILInjected.Token(Token = "0x40009E3")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private int lock_thread_id;

		// Token: 0x040007B0 RID: 1968
		[global::Cpp2ILInjected.Token(Token = "0x40009E4")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private global::System.IntPtr handle;

		// Token: 0x040007B1 RID: 1969
		[global::Cpp2ILInjected.Token(Token = "0x40009E5")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private global::System.IntPtr native_handle;

		// Token: 0x040007B2 RID: 1970
		[global::Cpp2ILInjected.Token(Token = "0x40009E6")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private global::System.IntPtr name_chars;

		// Token: 0x040007B3 RID: 1971
		[global::Cpp2ILInjected.Token(Token = "0x40009E7")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private int name_free;

		// Token: 0x040007B4 RID: 1972
		[global::Cpp2ILInjected.Token(Token = "0x40009E8")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x34")]
		private int name_length;

		// Token: 0x040007B5 RID: 1973
		[global::Cpp2ILInjected.Token(Token = "0x40009E9")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		private ThreadState state;

		// Token: 0x040007B6 RID: 1974
		[global::Cpp2ILInjected.Token(Token = "0x40009EA")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		private object abort_exc;

		// Token: 0x040007B7 RID: 1975
		[global::Cpp2ILInjected.Token(Token = "0x40009EB")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
		private int abort_state_handle;

		// Token: 0x040007B8 RID: 1976
		[global::Cpp2ILInjected.Token(Token = "0x40009EC")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
		internal long thread_id;

		// Token: 0x040007B9 RID: 1977
		[global::Cpp2ILInjected.Token(Token = "0x40009ED")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
		private global::System.IntPtr debugger_thread;

		// Token: 0x040007BA RID: 1978
		[global::Cpp2ILInjected.Token(Token = "0x40009EE")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
		private global::System.UIntPtr static_data;

		// Token: 0x040007BB RID: 1979
		[global::Cpp2ILInjected.Token(Token = "0x40009EF")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x68")]
		private global::System.IntPtr runtime_thread_info;

		// Token: 0x040007BC RID: 1980
		[global::Cpp2ILInjected.Token(Token = "0x40009F0")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x70")]
		private object current_appcontext;

		// Token: 0x040007BD RID: 1981
		[global::Cpp2ILInjected.Token(Token = "0x40009F1")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x78")]
		private object root_domain_thread;

		// Token: 0x040007BE RID: 1982
		[global::Cpp2ILInjected.Token(Token = "0x40009F2")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x80")]
		internal byte[] _serialized_principal;

		// Token: 0x040007BF RID: 1983
		[global::Cpp2ILInjected.Token(Token = "0x40009F3")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x88")]
		internal int _serialized_principal_version;

		// Token: 0x040007C0 RID: 1984
		[global::Cpp2ILInjected.Token(Token = "0x40009F4")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x90")]
		private global::System.IntPtr appdomain_refs;

		// Token: 0x040007C1 RID: 1985
		[global::Cpp2ILInjected.Token(Token = "0x40009F5")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x98")]
		private int interruption_requested;

		// Token: 0x040007C2 RID: 1986
		[global::Cpp2ILInjected.Token(Token = "0x40009F6")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xA0")]
		private global::System.IntPtr longlived;

		// Token: 0x040007C3 RID: 1987
		[global::Cpp2ILInjected.Token(Token = "0x40009F7")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xA8")]
		internal bool threadpool_thread;

		// Token: 0x040007C4 RID: 1988
		[global::Cpp2ILInjected.Token(Token = "0x40009F8")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xA9")]
		private bool thread_interrupt_requested;

		// Token: 0x040007C5 RID: 1989
		[global::Cpp2ILInjected.Token(Token = "0x40009F9")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xAC")]
		internal int stack_size;

		// Token: 0x040007C6 RID: 1990
		[global::Cpp2ILInjected.Token(Token = "0x40009FA")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xB0")]
		internal byte apartment_state;

		// Token: 0x040007C7 RID: 1991
		[global::Cpp2ILInjected.Token(Token = "0x40009FB")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xB4")]
		internal int critical_region_level;

		// Token: 0x040007C8 RID: 1992
		[global::Cpp2ILInjected.Token(Token = "0x40009FC")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xB8")]
		internal int managed_id;

		// Token: 0x040007C9 RID: 1993
		[global::Cpp2ILInjected.Token(Token = "0x40009FD")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xBC")]
		private int small_id;

		// Token: 0x040007CA RID: 1994
		[global::Cpp2ILInjected.Token(Token = "0x40009FE")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xC0")]
		private global::System.IntPtr manage_callback;

		// Token: 0x040007CB RID: 1995
		[global::Cpp2ILInjected.Token(Token = "0x40009FF")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xC8")]
		private global::System.IntPtr flags;

		// Token: 0x040007CC RID: 1996
		[global::Cpp2ILInjected.Token(Token = "0x4000A00")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xD0")]
		private global::System.IntPtr thread_pinning_ref;

		// Token: 0x040007CD RID: 1997
		[global::Cpp2ILInjected.Token(Token = "0x4000A01")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xD8")]
		private global::System.IntPtr abort_protected_block_count;

		// Token: 0x040007CE RID: 1998
		[global::Cpp2ILInjected.Token(Token = "0x4000A02")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xE0")]
		private int priority;

		// Token: 0x040007CF RID: 1999
		[global::Cpp2ILInjected.Token(Token = "0x4000A03")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xE8")]
		private global::System.IntPtr owned_mutex;

		// Token: 0x040007D0 RID: 2000
		[global::Cpp2ILInjected.Token(Token = "0x4000A04")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xF0")]
		private global::System.IntPtr suspended_event;

		// Token: 0x040007D1 RID: 2001
		[global::Cpp2ILInjected.Token(Token = "0x4000A05")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xF8")]
		private int self_suspended;

		// Token: 0x040007D2 RID: 2002
		[global::Cpp2ILInjected.Token(Token = "0x4000A06")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x100")]
		private global::System.IntPtr thread_state;

		// Token: 0x040007D3 RID: 2003
		[global::Cpp2ILInjected.Token(Token = "0x4000A07")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x108")]
		private global::System.IntPtr netcore0;

		// Token: 0x040007D4 RID: 2004
		[global::Cpp2ILInjected.Token(Token = "0x4000A08")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x110")]
		private global::System.IntPtr netcore1;

		// Token: 0x040007D5 RID: 2005
		[global::Cpp2ILInjected.Token(Token = "0x4000A09")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x118")]
		private global::System.IntPtr netcore2;

		// Token: 0x040007D6 RID: 2006
		[global::Cpp2ILInjected.Token(Token = "0x4000A0A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x120")]
		private global::System.IntPtr last;
	}
}
