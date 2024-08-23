using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Mono;

namespace System.Reflection
{
	// Token: 0x02000412 RID: 1042
	[global::Cpp2ILInjected.Token(Token = "0x20004D0")]
	[global::System.Serializable]
	public abstract class EventInfo : MemberInfo
	{
		// Token: 0x060020E8 RID: 8424 RVA: 0x0001A12F File Offset: 0x0001832F
		[global::Cpp2ILInjected.Token(Token = "0x6002380")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B80AA4", Offset = "0x1B80AA4", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RuntimeEventInfo), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		protected EventInfo()
		{
			throw null;
		}

		// Token: 0x17000423 RID: 1059
		// (get) Token: 0x060020E9 RID: 8425 RVA: 0x0001A132 File Offset: 0x00018332
		[global::Cpp2ILInjected.Token(Token = "0x1700049B")]
		public override MemberTypes MemberType
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002381")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B80AB4", Offset = "0x1B80AB4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x060020EA RID: 8426 RVA: 0x0001A135 File Offset: 0x00018335
		[global::Cpp2ILInjected.Token(Token = "0x6002382")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B80ABC", Offset = "0x1B80ABC", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.ComponentModel.ReflectEventDescriptor", Member = "FillMethods", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.ComponentModel.ReflectTypeDescriptionProvider", Member = "ReflectGetEvents", MemberParameters = new object[] { typeof(global::System.Type) }, ReturnType = "System.ComponentModel.EventDescriptor[]")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public MethodInfo GetAddMethod()
		{
			throw null;
		}

		// Token: 0x060020EB RID: 8427 RVA: 0x0001A138 File Offset: 0x00018338
		[global::Cpp2ILInjected.Token(Token = "0x6002383")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B80AD0", Offset = "0x1B80AD0", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.ComponentModel.ReflectEventDescriptor", Member = "FillMethods", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.ComponentModel.ReflectTypeDescriptionProvider", Member = "ReflectGetEvents", MemberParameters = new object[] { typeof(global::System.Type) }, ReturnType = "System.ComponentModel.EventDescriptor[]")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public MethodInfo GetRemoveMethod()
		{
			throw null;
		}

		// Token: 0x060020EC RID: 8428
		[global::Cpp2ILInjected.Token(Token = "0x6002384")]
		public abstract MethodInfo GetAddMethod(bool nonPublic);

		// Token: 0x060020ED RID: 8429
		[global::Cpp2ILInjected.Token(Token = "0x6002385")]
		public abstract MethodInfo GetRemoveMethod(bool nonPublic);

		// Token: 0x060020EE RID: 8430
		[global::Cpp2ILInjected.Token(Token = "0x6002386")]
		public abstract MethodInfo GetRaiseMethod(bool nonPublic);

		// Token: 0x17000424 RID: 1060
		// (get) Token: 0x060020EF RID: 8431 RVA: 0x0001A13B File Offset: 0x0001833B
		[global::Cpp2ILInjected.Token(Token = "0x1700049C")]
		public virtual global::System.Type EventHandlerType
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002387")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B80AE4", Offset = "0x1B80AE4", Length = "0x108")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(global::System.RuntimeTypeHandle) }, ReturnType = typeof(global::System.Type))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			get
			{
				throw null;
			}
		}

		// Token: 0x060020F0 RID: 8432 RVA: 0x0001A13E File Offset: 0x0001833E
		[global::Cpp2ILInjected.Token(Token = "0x6002388")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B80BEC", Offset = "0x1B80BEC", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "Equals", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(bool))]
		public override bool Equals(object obj)
		{
			throw null;
		}

		// Token: 0x060020F1 RID: 8433 RVA: 0x0001A141 File Offset: 0x00018341
		[global::Cpp2ILInjected.Token(Token = "0x6002389")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B80BFC", Offset = "0x1B80BFC", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "GetHashCode", ReturnType = typeof(int))]
		public override int GetHashCode()
		{
			throw null;
		}

		// Token: 0x060020F2 RID: 8434 RVA: 0x0001A144 File Offset: 0x00018344
		[global::Cpp2ILInjected.Token(Token = "0x600238A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B80C0C", Offset = "0x1B80C0C", Length = "0x2C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public static bool operator ==(EventInfo left, EventInfo right)
		{
			throw null;
		}

		// Token: 0x060020F3 RID: 8435 RVA: 0x0001A147 File Offset: 0x00018347
		[global::Cpp2ILInjected.Token(Token = "0x600238B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B80C38", Offset = "0x1B80C38", Length = "0x3C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.RuntimeType), Member = "GetEvent", MemberParameters = new object[]
		{
			typeof(string),
			typeof(BindingFlags)
		}, ReturnType = typeof(EventInfo))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.ComponentModel.ReflectEventDescriptor", Member = "FillAttributes", MemberParameters = new object[] { typeof(global::System.Collections.IList) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.ComponentModel.ReflectEventDescriptor", Member = "FillMethods", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
		public static bool operator !=(EventInfo left, EventInfo right)
		{
			throw null;
		}

		// Token: 0x060020F4 RID: 8436
		[global::Cpp2ILInjected.Token(Token = "0x600238C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B80C74", Offset = "0x1B80C74", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[MethodImpl(4096)]
		private static extern EventInfo internal_from_handle_type(global::System.IntPtr event_handle, global::System.IntPtr type_handle);

		// Token: 0x060020F5 RID: 8437 RVA: 0x0001A14A File Offset: 0x0001834A
		[global::Cpp2ILInjected.Token(Token = "0x600238D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B80C78", Offset = "0x1B80C78", Length = "0xE0")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.RuntimeType), Member = "GetEvents_internal", MemberParameters = new object[]
		{
			typeof(string),
			typeof(BindingFlags),
			typeof(global::System.RuntimeType.MemberListType),
			typeof(global::System.RuntimeType)
		}, ReturnType = typeof(RuntimeEventInfo[]))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.IntPtr), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(global::System.IntPtr),
			typeof(global::System.IntPtr)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		internal static EventInfo GetEventFromHandle(global::Mono.RuntimeEventHandle handle, global::System.RuntimeTypeHandle reflectedType)
		{
			throw null;
		}

		// Token: 0x04001073 RID: 4211
		[global::Cpp2ILInjected.Token(Token = "0x400138D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private EventInfo.AddEventAdapter cached_add_event;

		// Token: 0x02000609 RID: 1545
		// (Invoke) Token: 0x06004170 RID: 16752
		[global::Cpp2ILInjected.Token(Token = "0x20004D1")]
		private delegate void AddEventAdapter(object _this, global::System.Delegate dele);
	}
}
