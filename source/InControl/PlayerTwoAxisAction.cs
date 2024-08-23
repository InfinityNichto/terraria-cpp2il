using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace InControl
{
	// Token: 0x02000014 RID: 20
	[global::Cpp2ILInjected.Token(Token = "0x2000014")]
	public class PlayerTwoAxisAction : TwoAxisInputControl
	{
		// Token: 0x1700003C RID: 60
		// (get) Token: 0x060000E7 RID: 231 RVA: 0x0000231E File Offset: 0x0000051E
		// (set) Token: 0x060000E8 RID: 232 RVA: 0x00002321 File Offset: 0x00000521
		[global::Cpp2ILInjected.Token(Token = "0x1700003C")]
		public bool InvertXAxis
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60000E7")]
			[global::Cpp2ILInjected.Address(RVA = "0x1983428", Offset = "0x1983428", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60000E8")]
			[global::Cpp2ILInjected.Address(RVA = "0x1983430", Offset = "0x1983430", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x1700003D RID: 61
		// (get) Token: 0x060000E9 RID: 233 RVA: 0x00002324 File Offset: 0x00000524
		// (set) Token: 0x060000EA RID: 234 RVA: 0x00002327 File Offset: 0x00000527
		[global::Cpp2ILInjected.Token(Token = "0x1700003D")]
		public bool InvertYAxis
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60000E9")]
			[global::Cpp2ILInjected.Address(RVA = "0x198343C", Offset = "0x198343C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60000EA")]
			[global::Cpp2ILInjected.Address(RVA = "0x1983444", Offset = "0x1983444", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x14000005 RID: 5
		// (add) Token: 0x060000EB RID: 235 RVA: 0x0000232A File Offset: 0x0000052A
		// (remove) Token: 0x060000EC RID: 236 RVA: 0x0000232D File Offset: 0x0000052D
		[global::Cpp2ILInjected.Token(Token = "0x14000005")]
		public event Action<BindingSourceType> OnLastInputTypeChanged
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60000EB")]
			[global::Cpp2ILInjected.Address(RVA = "0x1983450", Offset = "0x1983450", Length = "0xB0")]
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
			[global::Cpp2ILInjected.Token(Token = "0x60000EC")]
			[global::Cpp2ILInjected.Address(RVA = "0x1983500", Offset = "0x1983500", Length = "0xB0")]
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

		// Token: 0x1700003E RID: 62
		// (get) Token: 0x060000ED RID: 237 RVA: 0x00002330 File Offset: 0x00000530
		// (set) Token: 0x060000EE RID: 238 RVA: 0x00002333 File Offset: 0x00000533
		[global::Cpp2ILInjected.Token(Token = "0x1700003E")]
		public object UserData
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60000ED")]
			[global::Cpp2ILInjected.Address(RVA = "0x19835B0", Offset = "0x19835B0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60000EE")]
			[global::Cpp2ILInjected.Address(RVA = "0x19835B8", Offset = "0x19835B8", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x060000EF RID: 239 RVA: 0x00002336 File Offset: 0x00000536
		[global::Cpp2ILInjected.Token(Token = "0x60000EF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1981AF0", Offset = "0x1981AF0", Length = "0x8C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PlayerActionSet), Member = "CreateTwoAxisPlayerAction", MemberParameters = new object[]
		{
			typeof(PlayerAction),
			typeof(PlayerAction),
			typeof(PlayerAction),
			typeof(PlayerAction)
		}, ReturnType = typeof(PlayerTwoAxisAction))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TwoAxisInputControl), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal PlayerTwoAxisAction(PlayerAction negativeXAction, PlayerAction positiveXAction, PlayerAction negativeYAction, PlayerAction positiveYAction)
		{
			throw null;
		}

		// Token: 0x060000F0 RID: 240 RVA: 0x00002339 File Offset: 0x00000539
		[global::Cpp2ILInjected.Token(Token = "0x60000F0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1981FF8", Offset = "0x1981FF8", Length = "0x1E0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PlayerActionSet), Member = "Update", MemberParameters = new object[]
		{
			typeof(ulong),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlayerTwoAxisAction), Member = "ProcessActionUpdate", MemberParameters = new object[] { typeof(PlayerAction) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utility), Member = "ValueFromSides", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float),
			typeof(bool)
		}, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TwoAxisInputControl), Member = "UpdateWithAxes", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float),
			typeof(ulong),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		internal void Update(ulong updateTick, float deltaTime)
		{
			throw null;
		}

		// Token: 0x060000F1 RID: 241 RVA: 0x0000233C File Offset: 0x0000053C
		[global::Cpp2ILInjected.Token(Token = "0x60000F1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1983718", Offset = "0x1983718", Length = "0x44")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PlayerTwoAxisAction), Member = "Update", MemberParameters = new object[]
		{
			typeof(ulong),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		private void ProcessActionUpdate(PlayerAction action)
		{
			throw null;
		}

		// Token: 0x1700003F RID: 63
		// (get) Token: 0x060000F2 RID: 242 RVA: 0x0000233F File Offset: 0x0000053F
		// (set) Token: 0x060000F3 RID: 243 RVA: 0x00002342 File Offset: 0x00000542
		[Obsolete("Please set this property on device controls directly. It does nothing here.")]
		[global::Cpp2ILInjected.Token(Token = "0x1700003F")]
		public new float LowerDeadZone
		{
			[global::Cpp2ILInjected.Token(Token = "0x60000F2")]
			[global::Cpp2ILInjected.Address(RVA = "0x19839E0", Offset = "0x19839E0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x60000F3")]
			[global::Cpp2ILInjected.Address(RVA = "0x19839E8", Offset = "0x19839E8", Length = "0x4")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000040 RID: 64
		// (get) Token: 0x060000F4 RID: 244 RVA: 0x00002345 File Offset: 0x00000545
		// (set) Token: 0x060000F5 RID: 245 RVA: 0x00002348 File Offset: 0x00000548
		[Obsolete("Please set this property on device controls directly. It does nothing here.")]
		[global::Cpp2ILInjected.Token(Token = "0x17000040")]
		public new float UpperDeadZone
		{
			[global::Cpp2ILInjected.Token(Token = "0x60000F4")]
			[global::Cpp2ILInjected.Address(RVA = "0x19839EC", Offset = "0x19839EC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x60000F5")]
			[global::Cpp2ILInjected.Address(RVA = "0x19839F4", Offset = "0x19839F4", Length = "0x4")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x040000FA RID: 250
		[global::Cpp2ILInjected.Token(Token = "0x40000FA")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x70")]
		private PlayerAction negativeXAction;

		// Token: 0x040000FB RID: 251
		[global::Cpp2ILInjected.Token(Token = "0x40000FB")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x78")]
		private PlayerAction positiveXAction;

		// Token: 0x040000FC RID: 252
		[global::Cpp2ILInjected.Token(Token = "0x40000FC")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x80")]
		private PlayerAction negativeYAction;

		// Token: 0x040000FD RID: 253
		[global::Cpp2ILInjected.Token(Token = "0x40000FD")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x88")]
		private PlayerAction positiveYAction;

		// Token: 0x040000FE RID: 254
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x40000FE")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x90")]
		private bool <InvertXAxis>k__BackingField;

		// Token: 0x040000FF RID: 255
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x40000FF")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x91")]
		private bool <InvertYAxis>k__BackingField;

		// Token: 0x04000100 RID: 256
		[global::Cpp2ILInjected.Token(Token = "0x4000100")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x94")]
		public BindingSourceType LastInputType;

		// Token: 0x04000101 RID: 257
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4000101")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x98")]
		private Action<BindingSourceType> OnLastInputTypeChanged;

		// Token: 0x04000102 RID: 258
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4000102")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xA0")]
		private object <UserData>k__BackingField;
	}
}
