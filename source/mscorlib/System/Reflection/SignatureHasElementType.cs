using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Reflection
{
	// Token: 0x0200042F RID: 1071
	[global::Cpp2ILInjected.Token(Token = "0x20004EE")]
	internal abstract class SignatureHasElementType : SignatureType
	{
		// Token: 0x060021BE RID: 8638 RVA: 0x0001A342 File Offset: 0x00018542
		[global::Cpp2ILInjected.Token(Token = "0x6002458")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B843C4", Offset = "0x1B843C4", Length = "0x24")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SignatureType), Member = ".ctor", ReturnType = typeof(void))]
		protected SignatureHasElementType(SignatureType elementType)
		{
			throw null;
		}

		// Token: 0x1700046D RID: 1133
		// (get) Token: 0x060021BF RID: 8639 RVA: 0x0001A345 File Offset: 0x00018545
		[global::Cpp2ILInjected.Token(Token = "0x170004E5")]
		public sealed override bool IsGenericTypeDefinition
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002459")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B84AAC", Offset = "0x1B84AAC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x060021C0 RID: 8640 RVA: 0x0001A348 File Offset: 0x00018548
		[global::Cpp2ILInjected.Token(Token = "0x600245A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B84AB4", Offset = "0x1B84AB4", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		protected sealed override bool HasElementTypeImpl()
		{
			throw null;
		}

		// Token: 0x060021C1 RID: 8641
		[global::Cpp2ILInjected.Token(Token = "0x600245B")]
		protected abstract override bool IsArrayImpl();

		// Token: 0x060021C2 RID: 8642
		[global::Cpp2ILInjected.Token(Token = "0x600245C")]
		protected abstract override bool IsByRefImpl();

		// Token: 0x060021C3 RID: 8643
		[global::Cpp2ILInjected.Token(Token = "0x600245D")]
		protected abstract override bool IsPointerImpl();

		// Token: 0x1700046E RID: 1134
		// (get) Token: 0x060021C4 RID: 8644
		[global::Cpp2ILInjected.Token(Token = "0x170004E6")]
		public abstract override bool IsSZArray
		{
			[global::Cpp2ILInjected.Token(Token = "0x600245E")]
			get;
		}

		// Token: 0x1700046F RID: 1135
		// (get) Token: 0x060021C5 RID: 8645
		[global::Cpp2ILInjected.Token(Token = "0x170004E7")]
		public abstract override bool IsVariableBoundArray
		{
			[global::Cpp2ILInjected.Token(Token = "0x600245F")]
			get;
		}

		// Token: 0x17000470 RID: 1136
		// (get) Token: 0x060021C6 RID: 8646 RVA: 0x0001A34B File Offset: 0x0001854B
		[global::Cpp2ILInjected.Token(Token = "0x170004E8")]
		public sealed override bool IsConstructedGenericType
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002460")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B84ABC", Offset = "0x1B84ABC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000471 RID: 1137
		// (get) Token: 0x060021C7 RID: 8647 RVA: 0x0001A34E File Offset: 0x0001854E
		[global::Cpp2ILInjected.Token(Token = "0x170004E9")]
		public sealed override bool IsGenericParameter
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002461")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B84AC4", Offset = "0x1B84AC4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000472 RID: 1138
		// (get) Token: 0x060021C8 RID: 8648 RVA: 0x0001A351 File Offset: 0x00018551
		[global::Cpp2ILInjected.Token(Token = "0x170004EA")]
		public sealed override bool IsGenericMethodParameter
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002462")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B84ACC", Offset = "0x1B84ACC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000473 RID: 1139
		// (get) Token: 0x060021C9 RID: 8649 RVA: 0x0001A354 File Offset: 0x00018554
		[global::Cpp2ILInjected.Token(Token = "0x170004EB")]
		public sealed override bool ContainsGenericParameters
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002463")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B84AD4", Offset = "0x1B84AD4", Length = "0x14")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000474 RID: 1140
		// (get) Token: 0x060021CA RID: 8650 RVA: 0x0001A357 File Offset: 0x00018557
		[global::Cpp2ILInjected.Token(Token = "0x170004EC")]
		internal sealed override SignatureType ElementType
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002464")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B84AE8", Offset = "0x1B84AE8", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x060021CB RID: 8651
		[global::Cpp2ILInjected.Token(Token = "0x6002465")]
		public abstract override int GetArrayRank();

		// Token: 0x060021CC RID: 8652 RVA: 0x0001A35A File Offset: 0x0001855A
		[global::Cpp2ILInjected.Token(Token = "0x6002466")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B84AF0", Offset = "0x1B84AF0", Length = "0x4C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public sealed override global::System.Type GetGenericTypeDefinition()
		{
			throw null;
		}

		// Token: 0x060021CD RID: 8653 RVA: 0x0001A35D File Offset: 0x0001855D
		[global::Cpp2ILInjected.Token(Token = "0x6002467")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B84B3C", Offset = "0x1B84B3C", Length = "0x7C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public sealed override global::System.Type[] GetGenericArguments()
		{
			throw null;
		}

		// Token: 0x17000475 RID: 1141
		// (get) Token: 0x060021CE RID: 8654 RVA: 0x0001A360 File Offset: 0x00018560
		[global::Cpp2ILInjected.Token(Token = "0x170004ED")]
		public sealed override global::System.Type[] GenericTypeArguments
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002468")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B84BB8", Offset = "0x1B84BB8", Length = "0x7C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000476 RID: 1142
		// (get) Token: 0x060021CF RID: 8655 RVA: 0x0001A363 File Offset: 0x00018563
		[global::Cpp2ILInjected.Token(Token = "0x170004EE")]
		public sealed override int GenericParameterPosition
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002469")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B84C34", Offset = "0x1B84C34", Length = "0x4C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000477 RID: 1143
		// (get) Token: 0x060021D0 RID: 8656 RVA: 0x0001A366 File Offset: 0x00018566
		[global::Cpp2ILInjected.Token(Token = "0x170004EF")]
		public sealed override string Name
		{
			[global::Cpp2ILInjected.Token(Token = "0x600246A")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B84C80", Offset = "0x1B84C80", Length = "0x4C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
			{
				typeof(string),
				typeof(string)
			}, ReturnType = typeof(string))]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000478 RID: 1144
		// (get) Token: 0x060021D1 RID: 8657 RVA: 0x0001A369 File Offset: 0x00018569
		[global::Cpp2ILInjected.Token(Token = "0x170004F0")]
		public sealed override string Namespace
		{
			[global::Cpp2ILInjected.Token(Token = "0x600246B")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B84CCC", Offset = "0x1B84CCC", Length = "0x14")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x060021D2 RID: 8658 RVA: 0x0001A36C File Offset: 0x0001856C
		[global::Cpp2ILInjected.Token(Token = "0x600246C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B84CE0", Offset = "0x1B84CE0", Length = "0x4C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		public sealed override string ToString()
		{
			throw null;
		}

		// Token: 0x17000479 RID: 1145
		// (get) Token: 0x060021D3 RID: 8659
		[global::Cpp2ILInjected.Token(Token = "0x170004F1")]
		protected abstract string Suffix
		{
			[global::Cpp2ILInjected.Token(Token = "0x600246D")]
			get;
		}

		// Token: 0x04001102 RID: 4354
		[global::Cpp2ILInjected.Token(Token = "0x400141C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private readonly SignatureType _elementType;
	}
}
