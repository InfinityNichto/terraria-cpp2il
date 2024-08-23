using System;
using System.Text;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Reflection
{
	// Token: 0x0200042E RID: 1070
	[global::Cpp2ILInjected.Token(Token = "0x20004ED")]
	internal sealed class SignatureConstructedGenericType : SignatureType
	{
		// Token: 0x060021A9 RID: 8617 RVA: 0x0001A303 File Offset: 0x00018503
		[global::Cpp2ILInjected.Token(Token = "0x6002443")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B845C0", Offset = "0x1B845C0", Length = "0x18C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Type), Member = "MakeGenericSignatureType", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(global::System.Type[])
		}, ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SignatureType), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(global::System.Type)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array), Member = "Clone", ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 13)]
		internal SignatureConstructedGenericType(global::System.Type genericTypeDefinition, global::System.Type[] typeArguments)
		{
			throw null;
		}

		// Token: 0x17000461 RID: 1121
		// (get) Token: 0x060021AA RID: 8618 RVA: 0x0001A306 File Offset: 0x00018506
		[global::Cpp2ILInjected.Token(Token = "0x170004D9")]
		public sealed override bool IsGenericTypeDefinition
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002444")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B847A4", Offset = "0x1B847A4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x060021AB RID: 8619 RVA: 0x0001A309 File Offset: 0x00018509
		[global::Cpp2ILInjected.Token(Token = "0x6002445")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B847AC", Offset = "0x1B847AC", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		protected sealed override bool HasElementTypeImpl()
		{
			throw null;
		}

		// Token: 0x060021AC RID: 8620 RVA: 0x0001A30C File Offset: 0x0001850C
		[global::Cpp2ILInjected.Token(Token = "0x6002446")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B847B4", Offset = "0x1B847B4", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		protected sealed override bool IsArrayImpl()
		{
			throw null;
		}

		// Token: 0x060021AD RID: 8621 RVA: 0x0001A30F File Offset: 0x0001850F
		[global::Cpp2ILInjected.Token(Token = "0x6002447")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B847BC", Offset = "0x1B847BC", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		protected sealed override bool IsByRefImpl()
		{
			throw null;
		}

		// Token: 0x060021AE RID: 8622 RVA: 0x0001A312 File Offset: 0x00018512
		[global::Cpp2ILInjected.Token(Token = "0x6002448")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B847C4", Offset = "0x1B847C4", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		protected sealed override bool IsPointerImpl()
		{
			throw null;
		}

		// Token: 0x17000462 RID: 1122
		// (get) Token: 0x060021AF RID: 8623 RVA: 0x0001A315 File Offset: 0x00018515
		[global::Cpp2ILInjected.Token(Token = "0x170004DA")]
		public sealed override bool IsSZArray
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002449")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B847CC", Offset = "0x1B847CC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000463 RID: 1123
		// (get) Token: 0x060021B0 RID: 8624 RVA: 0x0001A318 File Offset: 0x00018518
		[global::Cpp2ILInjected.Token(Token = "0x170004DB")]
		public sealed override bool IsVariableBoundArray
		{
			[global::Cpp2ILInjected.Token(Token = "0x600244A")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B847D4", Offset = "0x1B847D4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000464 RID: 1124
		// (get) Token: 0x060021B1 RID: 8625 RVA: 0x0001A31B File Offset: 0x0001851B
		[global::Cpp2ILInjected.Token(Token = "0x170004DC")]
		public sealed override bool IsConstructedGenericType
		{
			[global::Cpp2ILInjected.Token(Token = "0x600244B")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B847DC", Offset = "0x1B847DC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000465 RID: 1125
		// (get) Token: 0x060021B2 RID: 8626 RVA: 0x0001A31E File Offset: 0x0001851E
		[global::Cpp2ILInjected.Token(Token = "0x170004DD")]
		public sealed override bool IsGenericParameter
		{
			[global::Cpp2ILInjected.Token(Token = "0x600244C")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B847E4", Offset = "0x1B847E4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000466 RID: 1126
		// (get) Token: 0x060021B3 RID: 8627 RVA: 0x0001A321 File Offset: 0x00018521
		[global::Cpp2ILInjected.Token(Token = "0x170004DE")]
		public sealed override bool IsGenericMethodParameter
		{
			[global::Cpp2ILInjected.Token(Token = "0x600244D")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B847EC", Offset = "0x1B847EC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000467 RID: 1127
		// (get) Token: 0x060021B4 RID: 8628 RVA: 0x0001A324 File Offset: 0x00018524
		[global::Cpp2ILInjected.Token(Token = "0x170004DF")]
		public sealed override bool ContainsGenericParameters
		{
			[global::Cpp2ILInjected.Token(Token = "0x600244E")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B847F4", Offset = "0x1B847F4", Length = "0x68")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000468 RID: 1128
		// (get) Token: 0x060021B5 RID: 8629 RVA: 0x0001A327 File Offset: 0x00018527
		[global::Cpp2ILInjected.Token(Token = "0x170004E0")]
		internal sealed override SignatureType ElementType
		{
			[global::Cpp2ILInjected.Token(Token = "0x600244F")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B8485C", Offset = "0x1B8485C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x060021B6 RID: 8630 RVA: 0x0001A32A File Offset: 0x0001852A
		[global::Cpp2ILInjected.Token(Token = "0x6002450")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B84864", Offset = "0x1B84864", Length = "0x4C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public sealed override int GetArrayRank()
		{
			throw null;
		}

		// Token: 0x060021B7 RID: 8631 RVA: 0x0001A32D File Offset: 0x0001852D
		[global::Cpp2ILInjected.Token(Token = "0x6002451")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B848B0", Offset = "0x1B848B0", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public sealed override global::System.Type GetGenericTypeDefinition()
		{
			throw null;
		}

		// Token: 0x060021B8 RID: 8632 RVA: 0x0001A330 File Offset: 0x00018530
		[global::Cpp2ILInjected.Token(Token = "0x6002452")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B848B8", Offset = "0x1B848B8", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public sealed override global::System.Type[] GetGenericArguments()
		{
			throw null;
		}

		// Token: 0x17000469 RID: 1129
		// (get) Token: 0x060021B9 RID: 8633 RVA: 0x0001A333 File Offset: 0x00018533
		[global::Cpp2ILInjected.Token(Token = "0x170004E1")]
		public sealed override global::System.Type[] GenericTypeArguments
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002453")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B848C8", Offset = "0x1B848C8", Length = "0x70")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array), Member = "Clone", ReturnType = typeof(object))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700046A RID: 1130
		// (get) Token: 0x060021BA RID: 8634 RVA: 0x0001A336 File Offset: 0x00018536
		[global::Cpp2ILInjected.Token(Token = "0x170004E2")]
		public sealed override int GenericParameterPosition
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002454")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B84938", Offset = "0x1B84938", Length = "0x4C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700046B RID: 1131
		// (get) Token: 0x060021BB RID: 8635 RVA: 0x0001A339 File Offset: 0x00018539
		[global::Cpp2ILInjected.Token(Token = "0x170004E3")]
		public sealed override string Name
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002455")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B84984", Offset = "0x1B84984", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700046C RID: 1132
		// (get) Token: 0x060021BC RID: 8636 RVA: 0x0001A33C File Offset: 0x0001853C
		[global::Cpp2ILInjected.Token(Token = "0x170004E4")]
		public sealed override string Namespace
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002456")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B84994", Offset = "0x1B84994", Length = "0x14")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x060021BD RID: 8637 RVA: 0x0001A33F File Offset: 0x0001853F
		[global::Cpp2ILInjected.Token(Token = "0x6002457")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B849A8", Offset = "0x1B849A8", Length = "0x104")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Text.StringBuilder), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Text.StringBuilder), Member = "Append", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(global::System.Text.StringBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Text.StringBuilder), Member = "Append", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(global::System.Text.StringBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public sealed override string ToString()
		{
			throw null;
		}

		// Token: 0x04001100 RID: 4352
		[global::Cpp2ILInjected.Token(Token = "0x400141A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private readonly global::System.Type _genericTypeDefinition;

		// Token: 0x04001101 RID: 4353
		[global::Cpp2ILInjected.Token(Token = "0x400141B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private readonly global::System.Type[] _genericTypeArguments;
	}
}
