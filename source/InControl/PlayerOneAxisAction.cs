using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace InControl
{
	// Token: 0x02000013 RID: 19
	[global::Cpp2ILInjected.Token(Token = "0x2000013")]
	public class PlayerOneAxisAction : OneAxisInputControl
	{
		// Token: 0x14000004 RID: 4
		// (add) Token: 0x060000DC RID: 220 RVA: 0x000022FD File Offset: 0x000004FD
		// (remove) Token: 0x060000DD RID: 221 RVA: 0x00002300 File Offset: 0x00000500
		[global::Cpp2ILInjected.Token(Token = "0x14000004")]
		public event Action<BindingSourceType> OnLastInputTypeChanged
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60000DC")]
			[global::Cpp2ILInjected.Address(RVA = "0x1983228", Offset = "0x1983228", Length = "0xB0")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new object[]
			{
				typeof(Delegate),
				typeof(Delegate)
			}, ReturnType = typeof(Delegate))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			add
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60000DD")]
			[global::Cpp2ILInjected.Address(RVA = "0x19832D8", Offset = "0x19832D8", Length = "0xB0")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new object[]
			{
				typeof(Delegate),
				typeof(Delegate)
			}, ReturnType = typeof(Delegate))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			remove
			{
				throw null;
			}
		}

		// Token: 0x17000039 RID: 57
		// (get) Token: 0x060000DE RID: 222 RVA: 0x00002303 File Offset: 0x00000503
		// (set) Token: 0x060000DF RID: 223 RVA: 0x00002306 File Offset: 0x00000506
		[global::Cpp2ILInjected.Token(Token = "0x17000039")]
		public object UserData
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60000DE")]
			[global::Cpp2ILInjected.Address(RVA = "0x1983388", Offset = "0x1983388", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60000DF")]
			[global::Cpp2ILInjected.Address(RVA = "0x1983390", Offset = "0x1983390", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x060000E0 RID: 224 RVA: 0x00002309 File Offset: 0x00000509
		[global::Cpp2ILInjected.Token(Token = "0x60000E0")]
		[global::Cpp2ILInjected.Address(RVA = "0x19819A8", Offset = "0x19819A8", Length = "0x54")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		internal PlayerOneAxisAction(PlayerAction negativeAction, PlayerAction positiveAction)
		{
			throw null;
		}

		// Token: 0x060000E1 RID: 225 RVA: 0x0000230C File Offset: 0x0000050C
		[global::Cpp2ILInjected.Token(Token = "0x60000E1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1981F28", Offset = "0x1981F28", Length = "0xD0")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PlayerActionSet), Member = "Update", MemberParameters = new object[]
		{
			typeof(ulong),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlayerOneAxisAction), Member = "ProcessActionUpdate", MemberParameters = new object[] { typeof(PlayerAction) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utility), Member = "ValueFromSides", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(OneAxisInputControl), Member = "UpdateWithValue", MemberParameters = new object[]
		{
			typeof(float),
			typeof(ulong),
			typeof(float)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(OneAxisInputControl), Member = "Commit", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal void Update(ulong updateTick, float deltaTime)
		{
			throw null;
		}

		// Token: 0x060000E2 RID: 226 RVA: 0x0000230F File Offset: 0x0000050F
		[global::Cpp2ILInjected.Token(Token = "0x60000E2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1983398", Offset = "0x1983398", Length = "0x44")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PlayerOneAxisAction), Member = "Update", MemberParameters = new object[]
		{
			typeof(ulong),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		private void ProcessActionUpdate(PlayerAction action)
		{
			throw null;
		}

		// Token: 0x1700003A RID: 58
		// (get) Token: 0x060000E3 RID: 227 RVA: 0x00002312 File Offset: 0x00000512
		// (set) Token: 0x060000E4 RID: 228 RVA: 0x00002315 File Offset: 0x00000515
		[Obsolete("Please set this property on device controls directly. It does nothing here.")]
		[global::Cpp2ILInjected.Token(Token = "0x1700003A")]
		public new float LowerDeadZone
		{
			[global::Cpp2ILInjected.Token(Token = "0x60000E3")]
			[global::Cpp2ILInjected.Address(RVA = "0x1983410", Offset = "0x1983410", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x60000E4")]
			[global::Cpp2ILInjected.Address(RVA = "0x1983418", Offset = "0x1983418", Length = "0x4")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x1700003B RID: 59
		// (get) Token: 0x060000E5 RID: 229 RVA: 0x00002318 File Offset: 0x00000518
		// (set) Token: 0x060000E6 RID: 230 RVA: 0x0000231B File Offset: 0x0000051B
		[Obsolete("Please set this property on device controls directly. It does nothing here.")]
		[global::Cpp2ILInjected.Token(Token = "0x1700003B")]
		public new float UpperDeadZone
		{
			[global::Cpp2ILInjected.Token(Token = "0x60000E5")]
			[global::Cpp2ILInjected.Address(RVA = "0x198341C", Offset = "0x198341C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x60000E6")]
			[global::Cpp2ILInjected.Address(RVA = "0x1983424", Offset = "0x1983424", Length = "0x4")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x040000F5 RID: 245
		[global::Cpp2ILInjected.Token(Token = "0x40000F5")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x70")]
		private PlayerAction negativeAction;

		// Token: 0x040000F6 RID: 246
		[global::Cpp2ILInjected.Token(Token = "0x40000F6")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x78")]
		private PlayerAction positiveAction;

		// Token: 0x040000F7 RID: 247
		[global::Cpp2ILInjected.Token(Token = "0x40000F7")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x80")]
		public BindingSourceType LastInputType;

		// Token: 0x040000F8 RID: 248
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x40000F8")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x88")]
		private Action<BindingSourceType> OnLastInputTypeChanged;

		// Token: 0x040000F9 RID: 249
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x40000F9")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x90")]
		private object <UserData>k__BackingField;
	}
}
